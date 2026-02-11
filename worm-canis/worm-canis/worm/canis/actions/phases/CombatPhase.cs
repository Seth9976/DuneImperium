using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.ConflictAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B6 RID: 694
	public class CombatPhase : StateMachineAction<CombatState>
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x000C84D8 File Offset: 0x000C66D8
		// Note: this type is marked as 'beforefieldinit'.
		static CombatPhase()
		{
			Il2CppClassPointerStore<CombatPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "CombatPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr);
			CombatPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "wormMatch");
			CombatPhase.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "selectingPlayer");
			CombatPhase.NativeFieldInfoPtr_passedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "passedPlayers");
			CombatPhase.NativeFieldInfoPtr_playerRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "playerRewards");
			CombatPhase.NativeMethodInfoPtr_FindInitialState_Private_Static_CombatState_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669297);
			CombatPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669298);
			CombatPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedCombatPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669299);
			CombatPhase.NativeMethodInfoPtr_get_NonCombatants_Private_get_IEnumerable_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669300);
			CombatPhase.NativeMethodInfoPtr_get_NextSelectingPlayer_Private_get_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669301);
			CombatPhase.NativeMethodInfoPtr_get_PlayerRewards_Private_get_List_1_PlayerRewards_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669302);
			CombatPhase.NativeMethodInfoPtr_HasMatchingCombatTiming_Private_Boolean_PlayAbility_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669303);
			CombatPhase.NativeMethodInfoPtr_GetUsableCombatIntrigueAbilities_Private_IEnumerable_1_PlayAbility_WormPlayer_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669304);
			CombatPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_CombatState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669305);
			CombatPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_CombatState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669306);
			CombatPhase.NativeMethodInfoPtr_BeginCombat_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669307);
			CombatPhase.NativeMethodInfoPtr_PlayCombatIntrigueCards_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669308);
			CombatPhase.NativeMethodInfoPtr_DetermineRewards_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669309);
			CombatPhase.NativeMethodInfoPtr_ResolveCombat_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669310);
			CombatPhase.NativeMethodInfoPtr_PlayCombatResolutionIntrigueCards_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669311);
			CombatPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669312);
			CombatPhase.NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669313);
			CombatPhase.NativeMethodInfoPtr__get_NonCombatants_b__8_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669314);
			CombatPhase.NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669315);
			CombatPhase.NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_1_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669316);
			CombatPhase.NativeMethodInfoPtr__get_PlayerRewards_b__12_0_Private_PlayerRewards_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669317);
			CombatPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__15_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, 100669318);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000C8710 File Offset: 0x000C6910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155015, XrefRangeEnd = 155030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CombatState FindInitialState(WormMatch m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_FindInitialState_Private_Static_CombatState_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000C8754 File Offset: 0x000C6954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155030, XrefRangeEnd = 155076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatPhase(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000C87A0 File Offset: 0x000C69A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155132, RefRangeEnd = 155133, XrefRangeStart = 155076, XrefRangeEnd = 155132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatPhase(SerializedCombatPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedCombatPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x000C8800 File Offset: 0x000C6A00
		public unsafe IEnumerable<WormPlayer> NonCombatants
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 155144, RefRangeEnd = 155147, XrefRangeStart = 155133, XrefRangeEnd = 155144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_get_NonCombatants_Private_get_IEnumerable_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000C8840 File Offset: 0x000C6A40
		public unsafe WormPlayer NextSelectingPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155147, XrefRangeEnd = 155166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_get_NextSelectingPlayer_Private_get_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x000C8880 File Offset: 0x000C6A80
		public unsafe List<PlayerRewards> PlayerRewards
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 155193, RefRangeEnd = 155199, XrefRangeStart = 155166, XrefRangeEnd = 155193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_get_PlayerRewards_Private_get_List_1_PlayerRewards_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerRewards>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000C88C0 File Offset: 0x000C6AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155199, XrefRangeEnd = 155200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMatchingCombatTiming(PlayAbility intrigueAbility, bool resolutionTiming)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigueAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolutionTiming;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_HasMatchingCombatTiming_Private_Boolean_PlayAbility_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000C891C File Offset: 0x000C6B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155250, RefRangeEnd = 155252, XrefRangeStart = 155200, XrefRangeEnd = 155250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PlayAbility> GetUsableCombatIntrigueAbilities(WormPlayer player, bool resolutionTiming = false, [Optional] Il2CppReferenceArray<ValueTuple<string, Object>> contextParams)
		{
			if (contextParams == null)
			{
				contextParams = new Il2CppStructArray<ValueTuple<string, Object>>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolutionTiming;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contextParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_GetUsableCombatIntrigueAbilities_Private_IEnumerable_1_PlayAbility_WormPlayer_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayAbility>>(intPtr3) : null;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000C899C File Offset: 0x000C6B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155252, XrefRangeEnd = 155363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<CombatState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_CombatState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<CombatState>(intPtr);
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000C89F0 File Offset: 0x000C6BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155363, XrefRangeEnd = 155373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(CombatState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_CombatState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000C8A48 File Offset: 0x000C6C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155373, XrefRangeEnd = 155379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> BeginCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_BeginCombat_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000C8A88 File Offset: 0x000C6C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155379, XrefRangeEnd = 155384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayCombatIntrigueCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_PlayCombatIntrigueCards_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000C8AC8 File Offset: 0x000C6CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155384, XrefRangeEnd = 155389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineRewards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_DetermineRewards_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000C8B08 File Offset: 0x000C6D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155389, XrefRangeEnd = 155394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_ResolveCombat_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000C8B48 File Offset: 0x000C6D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155394, XrefRangeEnd = 155399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayCombatResolutionIntrigueCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr_PlayCombatResolutionIntrigueCards_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000C8B88 File Offset: 0x000C6D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155399, XrefRangeEnd = 155449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000C8BE4 File Offset: 0x000C6DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155449, XrefRangeEnd = 155452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__5_0(WormPlayer p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000C8C34 File Offset: 0x000C6E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155452, XrefRangeEnd = 155455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_NonCombatants_b__8_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__get_NonCombatants_b__8_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000C8C84 File Offset: 0x000C6E84
		[CallerCount(0)]
		public unsafe bool _get_NextSelectingPlayer_b__10_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000C8CD4 File Offset: 0x000C6ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155455, XrefRangeEnd = 155458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_NextSelectingPlayer_b__10_1(WormPlayer nxt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nxt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_1_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000C8D24 File Offset: 0x000C6F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155458, XrefRangeEnd = 155461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerRewards _get_PlayerRewards_b__12_0(SerializedPlayerReward _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__get_PlayerRewards_b__12_0_Private_PlayerRewards_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PlayerRewards(intPtr);
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000C8D6C File Offset: 0x000C6F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155461, XrefRangeEnd = 155465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineNextTypedState_b__15_0(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__15_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
		public IEnumerable<PlayAbility> GetUsableCombatIntrigueAbilities(WormPlayer player, [Optional] bool resolutionTiming, params ValueTuple<string, Object>[] contextParams)
		{
			return this.GetUsableCombatIntrigueAbilities(player, resolutionTiming, new Il2CppReferenceArray<ValueTuple<string, Object>>(contextParams));
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
		public CombatPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000C8DBC File Offset: 0x000C6FBC
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000C8DEC File Offset: 0x000C6FEC
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0000C2EB File Offset: 0x0000A4EB
		public unsafe WormPlayer selectingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_selectingPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000C8E1C File Offset: 0x000C701C
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0000C30A File Offset: 0x0000A50A
		public unsafe List<WormPlayer> passedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_passedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_passedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000C8E4C File Offset: 0x000C704C
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000C329 File Offset: 0x0000A529
		public unsafe List<PlayerRewards> playerRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_playerRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerRewards>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.NativeFieldInfoPtr_playerRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_passedPlayers;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr_playerRewards;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_FindInitialState_Private_Static_CombatState_WormMatch_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedCombatPhase_WormMatch_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_get_NonCombatants_Private_get_IEnumerable_1_WormPlayer_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSelectingPlayer_Private_get_WormPlayer_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerRewards_Private_get_List_1_PlayerRewards_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_HasMatchingCombatTiming_Private_Boolean_PlayAbility_Boolean_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableCombatIntrigueAbilities_Private_IEnumerable_1_PlayAbility_WormPlayer_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_CombatState_Action_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_CombatState_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_BeginCombat_Private_IEnumerable_1_Action_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_PlayCombatIntrigueCards_Private_IEnumerable_1_Action_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_DetermineRewards_Private_IEnumerable_1_Action_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_ResolveCombat_Private_IEnumerable_1_Action_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_PlayCombatResolutionIntrigueCards_Private_IEnumerable_1_Action_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_WormPlayer_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr__get_NonCombatants_b__8_0_Private_Boolean_WormPlayer_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_0_Private_Boolean_WormPlayer_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr__get_NextSelectingPlayer_b__10_1_Private_Boolean_WormPlayer_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr__get_PlayerRewards_b__12_0_Private_PlayerRewards_SerializedPlayerReward_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__15_0_Private_Boolean_WormPlayer_0;

		// Token: 0x02000712 RID: 1810
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060062C5 RID: 25285 RVA: 0x001E0C50 File Offset: 0x001DEE50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr);
				CombatPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9");
				CombatPhase.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__4_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__14_0");
				CombatPhase.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__14_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__17_0");
				CombatPhase.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__17_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__17_3");
				CombatPhase.__c.NativeFieldInfoPtr___9__17_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__17_4");
				CombatPhase.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__17_2");
				CombatPhase.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__18_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__18_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__18_3");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_0");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_2");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_3");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_5");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_9");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_10");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_7");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_12");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_8");
				CombatPhase.__c.NativeFieldInfoPtr___9__19_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__19_4");
				CombatPhase.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__20_0");
				CombatPhase.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__21_1");
				CombatPhase.__c.NativeFieldInfoPtr___9__21_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__21_7");
				CombatPhase.__c.NativeFieldInfoPtr___9__21_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__21_9");
				CombatPhase.__c.NativeFieldInfoPtr___9__21_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__21_3");
				CombatPhase.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__22_0");
				CombatPhase.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, "<>9__22_1");
				CombatPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669320);
				CombatPhase.__c.NativeMethodInfoPtr__FindInitialState_b__4_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669321);
				CombatPhase.__c.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_0_Internal_String_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669322);
				CombatPhase.__c.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_1_Internal_Object_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669323);
				CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669324);
				CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_1_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669325);
				CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669326);
				CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669327);
				CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_2_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669328);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_1_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669329);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_3_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669330);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_0_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669331);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669332);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_2_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669333);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_3_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669334);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_5_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669335);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_9_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669336);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_10_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669337);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_7_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669338);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_12_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669339);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_8_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669340);
				CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_4_Internal_SerializedPlayerReward_PlayerRewards_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669341);
				CombatPhase.__c.NativeMethodInfoPtr__ResolveCombat_b__20_0_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669342);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_1_Internal_IEnumerable_1_ConflictAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669343);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669344);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_9_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669345);
				CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_3_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669346);
				CombatPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_0_Internal_EntityID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669347);
				CombatPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_1_Internal_SerializedPlayerReward_PlayerRewards_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr, 100669348);
			}

			// Token: 0x060062C6 RID: 25286 RVA: 0x001E1104 File Offset: 0x001DF304
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060062C7 RID: 25287 RVA: 0x001E1140 File Offset: 0x001DF340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152586, XrefRangeEnd = 152587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindInitialState_b__4_1(Entity t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__FindInitialState_b__4_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062C8 RID: 25288 RVA: 0x001E1190 File Offset: 0x001DF390
			[CallerCount(0)]
			public unsafe string _GetUsableCombatIntrigueAbilities_b__14_0(ValueTuple<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_0_Internal_String_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060062C9 RID: 25289 RVA: 0x001E11E0 File Offset: 0x001DF3E0
			[CallerCount(0)]
			public unsafe Object _GetUsableCombatIntrigueAbilities_b__14_1(ValueTuple<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_1_Internal_Object_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060062CA RID: 25290 RVA: 0x001E1238 File Offset: 0x001DF438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginCombat_b__17_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062CB RID: 25291 RVA: 0x001E1288 File Offset: 0x001DF488
			[CallerCount(0)]
			public unsafe AccountID _BeginCombat_b__17_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_1_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060062CC RID: 25292 RVA: 0x001E12D8 File Offset: 0x001DF4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152587, XrefRangeEnd = 152588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginCombat_b__17_3(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062CD RID: 25293 RVA: 0x001E1328 File Offset: 0x001DF528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152588, XrefRangeEnd = 152589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginCombat_b__17_4(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062CE RID: 25294 RVA: 0x001E1378 File Offset: 0x001DF578
			[CallerCount(0)]
			public unsafe AccountID _BeginCombat_b__17_2(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__BeginCombat_b__17_2_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060062CF RID: 25295 RVA: 0x001E13C8 File Offset: 0x001DF5C8
			[CallerCount(0)]
			public unsafe AccountID _PlayCombatIntrigueCards_b__18_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_1_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060062D0 RID: 25296 RVA: 0x001E1418 File Offset: 0x001DF618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152589, XrefRangeEnd = 152598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatIntrigueCards_b__18_3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_3_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D1 RID: 25297 RVA: 0x001E1468 File Offset: 0x001DF668
			[CallerCount(0)]
			public unsafe AccountID _DetermineRewards_b__19_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_0_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060062D2 RID: 25298 RVA: 0x001E14B8 File Offset: 0x001DF6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152598, XrefRangeEnd = 152599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__19_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D3 RID: 25299 RVA: 0x001E1508 File Offset: 0x001DF708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DetermineRewards_b__19_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_2_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D4 RID: 25300 RVA: 0x001E1558 File Offset: 0x001DF758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DetermineRewards_b__19_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_3_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D5 RID: 25301 RVA: 0x001E15A8 File Offset: 0x001DF7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152599, XrefRangeEnd = 152608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__19_5(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_5_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D6 RID: 25302 RVA: 0x001E15F8 File Offset: 0x001DF7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152608, XrefRangeEnd = 152613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__19_9(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_9_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D7 RID: 25303 RVA: 0x001E1648 File Offset: 0x001DF848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152613, XrefRangeEnd = 152618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__19_10(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_10_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D8 RID: 25304 RVA: 0x001E1698 File Offset: 0x001DF898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DetermineRewards_b__19_7(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_7_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D9 RID: 25305 RVA: 0x001E16E8 File Offset: 0x001DF8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DetermineRewards_b__19_12(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_12_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062DA RID: 25306 RVA: 0x001E1738 File Offset: 0x001DF938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152618, XrefRangeEnd = 152623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, Object> _DetermineRewards_b__19_8(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_8_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060062DB RID: 25307 RVA: 0x001E1788 File Offset: 0x001DF988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152623, XrefRangeEnd = 152624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedPlayerReward _DetermineRewards_b__19_4(PlayerRewards pr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pr));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__DetermineRewards_b__19_4_Internal_SerializedPlayerReward_PlayerRewards_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedPlayerReward>(intPtr3) : null;
				}
			}

			// Token: 0x060062DC RID: 25308 RVA: 0x001E17E0 File Offset: 0x001DF9E0
			[CallerCount(0)]
			public unsafe AccountID _ResolveCombat_b__20_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__ResolveCombat_b__20_0_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060062DD RID: 25309 RVA: 0x001E1830 File Offset: 0x001DFA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152624, XrefRangeEnd = 152627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ConflictAbility> _PlayCombatResolutionIntrigueCards_b__21_1(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_1_Internal_IEnumerable_1_ConflictAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ConflictAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060062DE RID: 25310 RVA: 0x001E1880 File Offset: 0x001DFA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152627, XrefRangeEnd = 152630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _PlayCombatResolutionIntrigueCards_b__21_7(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060062DF RID: 25311 RVA: 0x001E18D0 File Offset: 0x001DFAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152630, XrefRangeEnd = 152631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__21_9(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_9_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062E0 RID: 25312 RVA: 0x001E1920 File Offset: 0x001DFB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152631, XrefRangeEnd = 152639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__21_3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_3_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062E1 RID: 25313 RVA: 0x001E1970 File Offset: 0x001DFB70
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedStateMachineAction_b__22_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_0_Internal_EntityID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060062E2 RID: 25314 RVA: 0x001E19C0 File Offset: 0x001DFBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedPlayerReward _MakeSerializedStateMachineAction_b__22_1(PlayerRewards _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_1_Internal_SerializedPlayerReward_PlayerRewards_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedPlayerReward>(intPtr3) : null;
				}
			}

			// Token: 0x060062E3 RID: 25315 RVA: 0x000260A2 File Offset: 0x000242A2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A5C RID: 6748
			// (get) Token: 0x060062E4 RID: 25316 RVA: 0x001E1A18 File Offset: 0x001DFC18
			// (set) Token: 0x060062E5 RID: 25317 RVA: 0x000260AB File Offset: 0x000242AB
			public unsafe static CombatPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A5D RID: 6749
			// (get) Token: 0x060062E6 RID: 25318 RVA: 0x001E1A40 File Offset: 0x001DFC40
			// (set) Token: 0x060062E7 RID: 25319 RVA: 0x000260BD File Offset: 0x000242BD
			public unsafe static Func<Entity, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A5E RID: 6750
			// (get) Token: 0x060062E8 RID: 25320 RVA: 0x001E1A68 File Offset: 0x001DFC68
			// (set) Token: 0x060062E9 RID: 25321 RVA: 0x000260CF File Offset: 0x000242CF
			public unsafe static Func<ValueTuple<string, Object>, string> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A5F RID: 6751
			// (get) Token: 0x060062EA RID: 25322 RVA: 0x001E1A90 File Offset: 0x001DFC90
			// (set) Token: 0x060062EB RID: 25323 RVA: 0x000260E1 File Offset: 0x000242E1
			public unsafe static Func<ValueTuple<string, Object>, Object> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, Object>, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A60 RID: 6752
			// (get) Token: 0x060062EC RID: 25324 RVA: 0x001E1AB8 File Offset: 0x001DFCB8
			// (set) Token: 0x060062ED RID: 25325 RVA: 0x000260F3 File Offset: 0x000242F3
			public unsafe static Func<WormPlayer, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A61 RID: 6753
			// (get) Token: 0x060062EE RID: 25326 RVA: 0x001E1AE0 File Offset: 0x001DFCE0
			// (set) Token: 0x060062EF RID: 25327 RVA: 0x00026105 File Offset: 0x00024305
			public unsafe static Func<WormPlayer, AccountID> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A62 RID: 6754
			// (get) Token: 0x060062F0 RID: 25328 RVA: 0x001E1B08 File Offset: 0x001DFD08
			// (set) Token: 0x060062F1 RID: 25329 RVA: 0x00026117 File Offset: 0x00024317
			public unsafe static Func<WormPlayer, bool> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A63 RID: 6755
			// (get) Token: 0x060062F2 RID: 25330 RVA: 0x001E1B30 File Offset: 0x001DFD30
			// (set) Token: 0x060062F3 RID: 25331 RVA: 0x00026129 File Offset: 0x00024329
			public unsafe static Func<WormPlayer, bool> __9__17_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A64 RID: 6756
			// (get) Token: 0x060062F4 RID: 25332 RVA: 0x001E1B58 File Offset: 0x001DFD58
			// (set) Token: 0x060062F5 RID: 25333 RVA: 0x0002613B File Offset: 0x0002433B
			public unsafe static Func<WormPlayer, AccountID> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A65 RID: 6757
			// (get) Token: 0x060062F6 RID: 25334 RVA: 0x001E1B80 File Offset: 0x001DFD80
			// (set) Token: 0x060062F7 RID: 25335 RVA: 0x0002614D File Offset: 0x0002434D
			public unsafe static Func<WormPlayer, AccountID> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A66 RID: 6758
			// (get) Token: 0x060062F8 RID: 25336 RVA: 0x001E1BA8 File Offset: 0x001DFDA8
			// (set) Token: 0x060062F9 RID: 25337 RVA: 0x0002615F File Offset: 0x0002435F
			public unsafe static Func<WormAbilityDefinition, bool> __9__18_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__18_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__18_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A67 RID: 6759
			// (get) Token: 0x060062FA RID: 25338 RVA: 0x001E1BD0 File Offset: 0x001DFDD0
			// (set) Token: 0x060062FB RID: 25339 RVA: 0x00026171 File Offset: 0x00024371
			public unsafe static Func<WormPlayer, AccountID> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A68 RID: 6760
			// (get) Token: 0x060062FC RID: 25340 RVA: 0x001E1BF8 File Offset: 0x001DFDF8
			// (set) Token: 0x060062FD RID: 25341 RVA: 0x00026183 File Offset: 0x00024383
			public unsafe static Func<WormPlayer, bool> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A69 RID: 6761
			// (get) Token: 0x060062FE RID: 25342 RVA: 0x001E1C20 File Offset: 0x001DFE20
			// (set) Token: 0x060062FF RID: 25343 RVA: 0x00026195 File Offset: 0x00024395
			public unsafe static Func<WormPlayer, int> __9__19_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6A RID: 6762
			// (get) Token: 0x06006300 RID: 25344 RVA: 0x001E1C48 File Offset: 0x001DFE48
			// (set) Token: 0x06006301 RID: 25345 RVA: 0x000261A7 File Offset: 0x000243A7
			public unsafe static Func<WormPlayer, int> __9__19_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6B RID: 6763
			// (get) Token: 0x06006302 RID: 25346 RVA: 0x001E1C70 File Offset: 0x001DFE70
			// (set) Token: 0x06006303 RID: 25347 RVA: 0x000261B9 File Offset: 0x000243B9
			public unsafe static Func<Entity, bool> __9__19_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6C RID: 6764
			// (get) Token: 0x06006304 RID: 25348 RVA: 0x001E1C98 File Offset: 0x001DFE98
			// (set) Token: 0x06006305 RID: 25349 RVA: 0x000261CB File Offset: 0x000243CB
			public unsafe static Func<Entity, bool> __9__19_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6D RID: 6765
			// (get) Token: 0x06006306 RID: 25350 RVA: 0x001E1CC0 File Offset: 0x001DFEC0
			// (set) Token: 0x06006307 RID: 25351 RVA: 0x000261DD File Offset: 0x000243DD
			public unsafe static Func<Entity, bool> __9__19_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6E RID: 6766
			// (get) Token: 0x06006308 RID: 25352 RVA: 0x001E1CE8 File Offset: 0x001DFEE8
			// (set) Token: 0x06006309 RID: 25353 RVA: 0x000261EF File Offset: 0x000243EF
			public unsafe static Func<WormUnit, int> __9__19_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6F RID: 6767
			// (get) Token: 0x0600630A RID: 25354 RVA: 0x001E1D10 File Offset: 0x001DFF10
			// (set) Token: 0x0600630B RID: 25355 RVA: 0x00026201 File Offset: 0x00024401
			public unsafe static Func<WormUnit, int> __9__19_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A70 RID: 6768
			// (get) Token: 0x0600630C RID: 25356 RVA: 0x001E1D38 File Offset: 0x001DFF38
			// (set) Token: 0x0600630D RID: 25357 RVA: 0x00026213 File Offset: 0x00024413
			public unsafe static Func<KeyValuePair<string, Object>, ValueTuple<string, Object>> __9__19_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, ValueTuple<string, Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A71 RID: 6769
			// (get) Token: 0x0600630E RID: 25358 RVA: 0x001E1D60 File Offset: 0x001DFF60
			// (set) Token: 0x0600630F RID: 25359 RVA: 0x00026225 File Offset: 0x00024425
			public unsafe static Func<PlayerRewards, SerializedPlayerReward> __9__19_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerRewards, SerializedPlayerReward>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__19_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A72 RID: 6770
			// (get) Token: 0x06006310 RID: 25360 RVA: 0x001E1D88 File Offset: 0x001DFF88
			// (set) Token: 0x06006311 RID: 25361 RVA: 0x00026237 File Offset: 0x00024437
			public unsafe static Func<WormPlayer, AccountID> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A73 RID: 6771
			// (get) Token: 0x06006312 RID: 25362 RVA: 0x001E1DB0 File Offset: 0x001DFFB0
			// (set) Token: 0x06006313 RID: 25363 RVA: 0x00026249 File Offset: 0x00024449
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<ConflictAbility>> __9__21_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<ConflictAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A74 RID: 6772
			// (get) Token: 0x06006314 RID: 25364 RVA: 0x001E1DD8 File Offset: 0x001DFFD8
			// (set) Token: 0x06006315 RID: 25365 RVA: 0x0002625B File Offset: 0x0002445B
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__21_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A75 RID: 6773
			// (get) Token: 0x06006316 RID: 25366 RVA: 0x001E1E00 File Offset: 0x001E0000
			// (set) Token: 0x06006317 RID: 25367 RVA: 0x0002626D File Offset: 0x0002446D
			public unsafe static Func<WormAbilityDefinition, bool> __9__21_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A76 RID: 6774
			// (get) Token: 0x06006318 RID: 25368 RVA: 0x001E1E28 File Offset: 0x001E0028
			// (set) Token: 0x06006319 RID: 25369 RVA: 0x0002627F File Offset: 0x0002447F
			public unsafe static Func<WormAbilityDefinition, bool> __9__21_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__21_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A77 RID: 6775
			// (get) Token: 0x0600631A RID: 25370 RVA: 0x001E1E50 File Offset: 0x001E0050
			// (set) Token: 0x0600631B RID: 25371 RVA: 0x00026291 File Offset: 0x00024491
			public unsafe static Func<WormPlayer, EntityID> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A78 RID: 6776
			// (get) Token: 0x0600631C RID: 25372 RVA: 0x001E1E78 File Offset: 0x001E0078
			// (set) Token: 0x0600631D RID: 25373 RVA: 0x000262A3 File Offset: 0x000244A3
			public unsafe static Func<PlayerRewards, SerializedPlayerReward> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombatPhase.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerRewards, SerializedPlayerReward>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombatPhase.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004000 RID: 16384
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004001 RID: 16385
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04004002 RID: 16386
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04004003 RID: 16387
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04004004 RID: 16388
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04004005 RID: 16389
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04004006 RID: 16390
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04004007 RID: 16391
			private static readonly IntPtr NativeFieldInfoPtr___9__17_4;

			// Token: 0x04004008 RID: 16392
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04004009 RID: 16393
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x0400400A RID: 16394
			private static readonly IntPtr NativeFieldInfoPtr___9__18_3;

			// Token: 0x0400400B RID: 16395
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400400C RID: 16396
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x0400400D RID: 16397
			private static readonly IntPtr NativeFieldInfoPtr___9__19_2;

			// Token: 0x0400400E RID: 16398
			private static readonly IntPtr NativeFieldInfoPtr___9__19_3;

			// Token: 0x0400400F RID: 16399
			private static readonly IntPtr NativeFieldInfoPtr___9__19_5;

			// Token: 0x04004010 RID: 16400
			private static readonly IntPtr NativeFieldInfoPtr___9__19_9;

			// Token: 0x04004011 RID: 16401
			private static readonly IntPtr NativeFieldInfoPtr___9__19_10;

			// Token: 0x04004012 RID: 16402
			private static readonly IntPtr NativeFieldInfoPtr___9__19_7;

			// Token: 0x04004013 RID: 16403
			private static readonly IntPtr NativeFieldInfoPtr___9__19_12;

			// Token: 0x04004014 RID: 16404
			private static readonly IntPtr NativeFieldInfoPtr___9__19_8;

			// Token: 0x04004015 RID: 16405
			private static readonly IntPtr NativeFieldInfoPtr___9__19_4;

			// Token: 0x04004016 RID: 16406
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04004017 RID: 16407
			private static readonly IntPtr NativeFieldInfoPtr___9__21_1;

			// Token: 0x04004018 RID: 16408
			private static readonly IntPtr NativeFieldInfoPtr___9__21_7;

			// Token: 0x04004019 RID: 16409
			private static readonly IntPtr NativeFieldInfoPtr___9__21_9;

			// Token: 0x0400401A RID: 16410
			private static readonly IntPtr NativeFieldInfoPtr___9__21_3;

			// Token: 0x0400401B RID: 16411
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400401C RID: 16412
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400401D RID: 16413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400401E RID: 16414
			private static readonly IntPtr NativeMethodInfoPtr__FindInitialState_b__4_1_Internal_Boolean_Entity_0;

			// Token: 0x0400401F RID: 16415
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_0_Internal_String_ValueTuple_2_String_Object_0;

			// Token: 0x04004020 RID: 16416
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__14_1_Internal_Object_ValueTuple_2_String_Object_0;

			// Token: 0x04004021 RID: 16417
			private static readonly IntPtr NativeMethodInfoPtr__BeginCombat_b__17_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004022 RID: 16418
			private static readonly IntPtr NativeMethodInfoPtr__BeginCombat_b__17_1_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004023 RID: 16419
			private static readonly IntPtr NativeMethodInfoPtr__BeginCombat_b__17_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004024 RID: 16420
			private static readonly IntPtr NativeMethodInfoPtr__BeginCombat_b__17_4_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004025 RID: 16421
			private static readonly IntPtr NativeMethodInfoPtr__BeginCombat_b__17_2_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004026 RID: 16422
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_1_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004027 RID: 16423
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatIntrigueCards_b__18_3_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04004028 RID: 16424
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_0_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004029 RID: 16425
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400402A RID: 16426
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_2_Internal_Int32_WormPlayer_0;

			// Token: 0x0400402B RID: 16427
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_3_Internal_Int32_WormPlayer_0;

			// Token: 0x0400402C RID: 16428
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_5_Internal_Boolean_Entity_0;

			// Token: 0x0400402D RID: 16429
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_9_Internal_Boolean_Entity_0;

			// Token: 0x0400402E RID: 16430
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_10_Internal_Boolean_Entity_0;

			// Token: 0x0400402F RID: 16431
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_7_Internal_Int32_WormUnit_0;

			// Token: 0x04004030 RID: 16432
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_12_Internal_Int32_WormUnit_0;

			// Token: 0x04004031 RID: 16433
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_8_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0;

			// Token: 0x04004032 RID: 16434
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__19_4_Internal_SerializedPlayerReward_PlayerRewards_0;

			// Token: 0x04004033 RID: 16435
			private static readonly IntPtr NativeMethodInfoPtr__ResolveCombat_b__20_0_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004034 RID: 16436
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_1_Internal_IEnumerable_1_ConflictAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04004035 RID: 16437
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04004036 RID: 16438
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_9_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04004037 RID: 16439
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__21_3_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04004038 RID: 16440
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_0_Internal_EntityID_WormPlayer_0;

			// Token: 0x04004039 RID: 16441
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__22_1_Internal_SerializedPlayerReward_PlayerRewards_0;
		}

		// Token: 0x02000713 RID: 1811
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600631E RID: 25374 RVA: 0x001E1EA0 File Offset: 0x001E00A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr_resolutionTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr, "resolutionTiming");
				CombatPhase.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr, 100669349);
				CombatPhase.__c__DisplayClass14_0.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr, 100669350);
			}

			// Token: 0x0600631F RID: 25375 RVA: 0x001E1F1C File Offset: 0x001E011C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006320 RID: 25376 RVA: 0x001E1F58 File Offset: 0x001E0158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152639, XrefRangeEnd = 152640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableCombatIntrigueAbilities_b__2(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass14_0.NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006321 RID: 25377 RVA: 0x000262B5 File Offset: 0x000244B5
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A79 RID: 6777
			// (get) Token: 0x06006322 RID: 25378 RVA: 0x001E1FA8 File Offset: 0x001E01A8
			// (set) Token: 0x06006323 RID: 25379 RVA: 0x000262BE File Offset: 0x000244BE
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A7A RID: 6778
			// (get) Token: 0x06006324 RID: 25380 RVA: 0x001E1FD8 File Offset: 0x001E01D8
			// (set) Token: 0x06006325 RID: 25381 RVA: 0x000262DD File Offset: 0x000244DD
			public unsafe bool resolutionTiming
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr_resolutionTiming);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass14_0.NativeFieldInfoPtr_resolutionTiming)) = value;
				}
			}

			// Token: 0x0400403A RID: 16442
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400403B RID: 16443
			private static readonly IntPtr NativeFieldInfoPtr_resolutionTiming;

			// Token: 0x0400403C RID: 16444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400403D RID: 16445
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableCombatIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0;
		}

		// Token: 0x02000714 RID: 1812
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x06006326 RID: 25382 RVA: 0x001E2000 File Offset: 0x001E0200
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr_lastIntrigueAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr, "lastIntrigueAccountID");
				CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr, 100669351);
				CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr, 100669352);
				CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__2_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr, 100669353);
			}

			// Token: 0x06006327 RID: 25383 RVA: 0x001E2090 File Offset: 0x001E0290
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006328 RID: 25384 RVA: 0x001E20CC File Offset: 0x001E02CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152640, XrefRangeEnd = 152645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatIntrigueCards_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006329 RID: 25385 RVA: 0x001E211C File Offset: 0x001E031C
			[CallerCount(0)]
			public unsafe bool _PlayCombatIntrigueCards_b__2(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayCombatIntrigueCards_b__2_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600632A RID: 25386 RVA: 0x000262F8 File Offset: 0x000244F8
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A7B RID: 6779
			// (get) Token: 0x0600632B RID: 25387 RVA: 0x001E216C File Offset: 0x001E036C
			// (set) Token: 0x0600632C RID: 25388 RVA: 0x00026301 File Offset: 0x00024501
			public unsafe AccountID lastIntrigueAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr_lastIntrigueAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr_lastIntrigueAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A7C RID: 6780
			// (get) Token: 0x0600632D RID: 25389 RVA: 0x001E219C File Offset: 0x001E039C
			// (set) Token: 0x0600632E RID: 25390 RVA: 0x00026320 File Offset: 0x00024520
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400403E RID: 16446
			private static readonly IntPtr NativeFieldInfoPtr_lastIntrigueAccountID;

			// Token: 0x0400403F RID: 16447
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004040 RID: 16448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004041 RID: 16449
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatIntrigueCards_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004042 RID: 16450
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatIntrigueCards_b__2_Internal_Boolean_ActivatedAbility_0;
		}

		// Token: 0x02000715 RID: 1813
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600632F RID: 25391 RVA: 0x001E21CC File Offset: 0x001E03CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass19_0.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr, "reward");
				CombatPhase.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr, 100669354);
				CombatPhase.__c__DisplayClass19_0.NativeMethodInfoPtr__DetermineRewards_b__6_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr, 100669355);
			}

			// Token: 0x06006330 RID: 25392 RVA: 0x001E2234 File Offset: 0x001E0434
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006331 RID: 25393 RVA: 0x001E2270 File Offset: 0x001E0470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152645, XrefRangeEnd = 152650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__6(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass19_0.NativeMethodInfoPtr__DetermineRewards_b__6_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006332 RID: 25394 RVA: 0x0002633F File Offset: 0x0002453F
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A7D RID: 6781
			// (get) Token: 0x06006333 RID: 25395 RVA: 0x001E22C0 File Offset: 0x001E04C0
			// (set) Token: 0x06006334 RID: 25396 RVA: 0x00026348 File Offset: 0x00024548
			public unsafe AbilityID reward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass19_0.NativeFieldInfoPtr_reward);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass19_0.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004043 RID: 16451
			private static readonly IntPtr NativeFieldInfoPtr_reward;

			// Token: 0x04004044 RID: 16452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004045 RID: 16453
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__6_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000716 RID: 1814
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Object
		{
			// Token: 0x06006335 RID: 25397 RVA: 0x001E22F0 File Offset: 0x001E04F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr);
				CombatPhase.__c__DisplayClass19_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr, "player");
				CombatPhase.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr, 100669356);
				CombatPhase.__c__DisplayClass19_1.NativeMethodInfoPtr__DetermineRewards_b__11_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr, 100669357);
			}

			// Token: 0x06006336 RID: 25398 RVA: 0x001E2358 File Offset: 0x001E0558
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006337 RID: 25399 RVA: 0x001E2394 File Offset: 0x001E0594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152650, XrefRangeEnd = 152652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineRewards_b__11(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass19_1.NativeMethodInfoPtr__DetermineRewards_b__11_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006338 RID: 25400 RVA: 0x00026367 File Offset: 0x00024567
			public __c__DisplayClass19_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A7E RID: 6782
			// (get) Token: 0x06006339 RID: 25401 RVA: 0x001E23E4 File Offset: 0x001E05E4
			// (set) Token: 0x0600633A RID: 25402 RVA: 0x00026370 File Offset: 0x00024570
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass19_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass19_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004046 RID: 16454
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04004047 RID: 16455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004048 RID: 16456
			private static readonly IntPtr NativeMethodInfoPtr__DetermineRewards_b__11_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000717 RID: 1815
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x0600633B RID: 25403 RVA: 0x001E2414 File Offset: 0x001E0614
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_rewardPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, "rewardPlayer");
				CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_playmatContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, "playmatContext");
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669358);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__0_Internal_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669359);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__2_Internal_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669360);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__4_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669361);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__5_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669362);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__6_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669363);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__8_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669364);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__10_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669365);
				CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__12_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr, 100669366);
			}

			// Token: 0x0600633C RID: 25404 RVA: 0x001E2530 File Offset: 0x001E0730
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600633D RID: 25405 RVA: 0x001E256C File Offset: 0x001E076C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152652, XrefRangeEnd = 152659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__0(ConflictAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__0_Internal_Boolean_ConflictAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600633E RID: 25406 RVA: 0x001E25BC File Offset: 0x001E07BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152659, XrefRangeEnd = 152666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__2(ConflictAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__2_Internal_Boolean_ConflictAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600633F RID: 25407 RVA: 0x001E260C File Offset: 0x001E080C
			[CallerCount(0)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__4(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__4_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006340 RID: 25408 RVA: 0x001E265C File Offset: 0x001E085C
			[CallerCount(0)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__5(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__5_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006341 RID: 25409 RVA: 0x001E26AC File Offset: 0x001E08AC
			[CallerCount(0)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__6(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__6_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006342 RID: 25410 RVA: 0x001E26FC File Offset: 0x001E08FC
			[CallerCount(0)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__8(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__8_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006343 RID: 25411 RVA: 0x001E274C File Offset: 0x001E094C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152666, XrefRangeEnd = 152667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__10(DeferredAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__10_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006344 RID: 25412 RVA: 0x001E279C File Offset: 0x001E099C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152667, XrefRangeEnd = 152674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__12(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_0.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__12_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006345 RID: 25413 RVA: 0x0002638F File Offset: 0x0002458F
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A7F RID: 6783
			// (get) Token: 0x06006346 RID: 25414 RVA: 0x001E27EC File Offset: 0x001E09EC
			// (set) Token: 0x06006347 RID: 25415 RVA: 0x00026398 File Offset: 0x00024598
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A80 RID: 6784
			// (get) Token: 0x06006348 RID: 25416 RVA: 0x001E281C File Offset: 0x001E0A1C
			// (set) Token: 0x06006349 RID: 25417 RVA: 0x000263B7 File Offset: 0x000245B7
			public unsafe WormPlayer rewardPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_rewardPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_rewardPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A81 RID: 6785
			// (get) Token: 0x0600634A RID: 25418 RVA: 0x001E284C File Offset: 0x001E0A4C
			// (set) Token: 0x0600634B RID: 25419 RVA: 0x000263D6 File Offset: 0x000245D6
			public unsafe Context playmatContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_playmatContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_0.NativeFieldInfoPtr_playmatContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004049 RID: 16457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400404A RID: 16458
			private static readonly IntPtr NativeFieldInfoPtr_rewardPlayer;

			// Token: 0x0400404B RID: 16459
			private static readonly IntPtr NativeFieldInfoPtr_playmatContext;

			// Token: 0x0400404C RID: 16460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400404D RID: 16461
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__0_Internal_Boolean_ConflictAbility_0;

			// Token: 0x0400404E RID: 16462
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__2_Internal_Boolean_ConflictAbility_0;

			// Token: 0x0400404F RID: 16463
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__4_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04004050 RID: 16464
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__5_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04004051 RID: 16465
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__6_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04004052 RID: 16466
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__8_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04004053 RID: 16467
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__10_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04004054 RID: 16468
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__12_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000718 RID: 1816
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : Object
		{
			// Token: 0x0600634C RID: 25420 RVA: 0x001E287C File Offset: 0x001E0A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr);
				CombatPhase.__c__DisplayClass21_1.NativeFieldInfoPtr_immediates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr, "immediates");
				CombatPhase.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr, 100669367);
				CombatPhase.__c__DisplayClass21_1.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__11_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr, 100669368);
			}

			// Token: 0x0600634D RID: 25421 RVA: 0x001E28E4 File Offset: 0x001E0AE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600634E RID: 25422 RVA: 0x001E2920 File Offset: 0x001E0B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152674, XrefRangeEnd = 152677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayCombatResolutionIntrigueCards_b__11(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass21_1.NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__11_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600634F RID: 25423 RVA: 0x000263F5 File Offset: 0x000245F5
			public __c__DisplayClass21_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A82 RID: 6786
			// (get) Token: 0x06006350 RID: 25424 RVA: 0x001E2970 File Offset: 0x001E0B70
			// (set) Token: 0x06006351 RID: 25425 RVA: 0x000263FE File Offset: 0x000245FE
			public unsafe List<DeferredAbility> immediates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_1.NativeFieldInfoPtr_immediates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeferredAbility>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass21_1.NativeFieldInfoPtr_immediates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004055 RID: 16469
			private static readonly IntPtr NativeFieldInfoPtr_immediates;

			// Token: 0x04004056 RID: 16470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004057 RID: 16471
			private static readonly IntPtr NativeMethodInfoPtr__PlayCombatResolutionIntrigueCards_b__11_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000719 RID: 1817
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06006352 RID: 25426 RVA: 0x001E29A0 File Offset: 0x001E0BA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass4_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr, "m");
				CombatPhase.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr, 100669369);
				CombatPhase.__c__DisplayClass4_0.NativeMethodInfoPtr__FindInitialState_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr, 100669370);
			}

			// Token: 0x06006353 RID: 25427 RVA: 0x001E2A08 File Offset: 0x001E0C08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006354 RID: 25428 RVA: 0x001E2A44 File Offset: 0x001E0C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152677, XrefRangeEnd = 152697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindInitialState_b__0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass4_0.NativeMethodInfoPtr__FindInitialState_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006355 RID: 25429 RVA: 0x0002641D File Offset: 0x0002461D
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A83 RID: 6787
			// (get) Token: 0x06006356 RID: 25430 RVA: 0x001E2A94 File Offset: 0x001E0C94
			// (set) Token: 0x06006357 RID: 25431 RVA: 0x00026426 File Offset: 0x00024626
			public unsafe WormMatch m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass4_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass4_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004058 RID: 16472
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x04004059 RID: 16473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400405A RID: 16474
			private static readonly IntPtr NativeMethodInfoPtr__FindInitialState_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200071A RID: 1818
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06006358 RID: 25432 RVA: 0x001E2AC4 File Offset: 0x001E0CC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr);
				CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr, "m");
				CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr, 100669371);
				CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormPlayer_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr, 100669372);
				CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__1_Internal_IEnumerable_1_PlayerRewards_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr, 100669373);
			}

			// Token: 0x06006359 RID: 25433 RVA: 0x001E2B54 File Offset: 0x001E0D54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600635A RID: 25434 RVA: 0x001E2B90 File Offset: 0x001E0D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152697, XrefRangeEnd = 152707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormPlayer> __ctor_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormPlayer_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
				}
			}

			// Token: 0x0600635B RID: 25435 RVA: 0x001E2BE0 File Offset: 0x001E0DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152707, XrefRangeEnd = 152717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PlayerRewards> __ctor_b__1(SerializedPlayerReward spr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(spr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase.__c__DisplayClass6_0.NativeMethodInfoPtr___ctor_b__1_Internal_IEnumerable_1_PlayerRewards_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerRewards>>(intPtr3) : null;
				}
			}

			// Token: 0x0600635C RID: 25436 RVA: 0x00026445 File Offset: 0x00024645
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A84 RID: 6788
			// (get) Token: 0x0600635D RID: 25437 RVA: 0x001E2C30 File Offset: 0x001E0E30
			// (set) Token: 0x0600635E RID: 25438 RVA: 0x0002644E File Offset: 0x0002464E
			public unsafe WormMatch m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A85 RID: 6789
			// (get) Token: 0x0600635F RID: 25439 RVA: 0x001E2C60 File Offset: 0x001E0E60
			// (set) Token: 0x06006360 RID: 25440 RVA: 0x0002646D File Offset: 0x0002466D
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400405B RID: 16475
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x0400405C RID: 16476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400405D RID: 16477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400405E RID: 16478
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormPlayer_EntityID_0;

			// Token: 0x0400405F RID: 16479
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_IEnumerable_1_PlayerRewards_SerializedPlayerReward_0;
		}

		// Token: 0x0200071B RID: 1819
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<BeginCombat>d__17")]
		public sealed class _BeginCombat_d__17 : Object
		{
			// Token: 0x06006361 RID: 25441 RVA: 0x001E2C90 File Offset: 0x001E0E90
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginCombat_d__17()
			{
				Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<BeginCombat>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr);
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<>1__state");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<>2__current");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<>l__initialThreadId");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<>4__this");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__conflictParticipants_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<conflictParticipants>5__2");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__enterConflictSequence_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<enterConflictSequence>5__3");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<>7__wrap3");
				CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__hagalPlayer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, "<hagalPlayer>5__5");
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669374);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669375);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669376);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669377);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669378);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669379);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669380);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669381);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669382);
				CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr, 100669383);
			}

			// Token: 0x06006362 RID: 25442 RVA: 0x001E2E24 File Offset: 0x001E1024
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginCombat_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase._BeginCombat_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006363 RID: 25443 RVA: 0x001E2E6C File Offset: 0x001E106C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 152717, RefRangeEnd = 152718, XrefRangeStart = 152717, XrefRangeEnd = 152717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006364 RID: 25444 RVA: 0x001E2EA0 File Offset: 0x001E10A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152718, XrefRangeEnd = 152940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006365 RID: 25445 RVA: 0x001E2EDC File Offset: 0x001E10DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152940, XrefRangeEnd = 152943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006366 RID: 25446 RVA: 0x001E2F10 File Offset: 0x001E1110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152943, XrefRangeEnd = 152946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A8E RID: 6798
			// (get) Token: 0x06006367 RID: 25447 RVA: 0x001E2F44 File Offset: 0x001E1144
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006368 RID: 25448 RVA: 0x001E2F84 File Offset: 0x001E1184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152946, XrefRangeEnd = 152951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A8F RID: 6799
			// (get) Token: 0x06006369 RID: 25449 RVA: 0x001E2FB8 File Offset: 0x001E11B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600636A RID: 25450 RVA: 0x001E2FF8 File Offset: 0x001E11F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152951, XrefRangeEnd = 152953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600636B RID: 25451 RVA: 0x001E3038 File Offset: 0x001E1238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._BeginCombat_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600636C RID: 25452 RVA: 0x0002648C File Offset: 0x0002468C
			public _BeginCombat_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A86 RID: 6790
			// (get) Token: 0x0600636D RID: 25453 RVA: 0x001E3078 File Offset: 0x001E1278
			// (set) Token: 0x0600636E RID: 25454 RVA: 0x00026495 File Offset: 0x00024695
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A87 RID: 6791
			// (get) Token: 0x0600636F RID: 25455 RVA: 0x001E30A0 File Offset: 0x001E12A0
			// (set) Token: 0x06006370 RID: 25456 RVA: 0x000264B0 File Offset: 0x000246B0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A88 RID: 6792
			// (get) Token: 0x06006371 RID: 25457 RVA: 0x001E30D0 File Offset: 0x001E12D0
			// (set) Token: 0x06006372 RID: 25458 RVA: 0x000264CF File Offset: 0x000246CF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A89 RID: 6793
			// (get) Token: 0x06006373 RID: 25459 RVA: 0x001E30F8 File Offset: 0x001E12F8
			// (set) Token: 0x06006374 RID: 25460 RVA: 0x000264EA File Offset: 0x000246EA
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8A RID: 6794
			// (get) Token: 0x06006375 RID: 25461 RVA: 0x001E3128 File Offset: 0x001E1328
			// (set) Token: 0x06006376 RID: 25462 RVA: 0x00026509 File Offset: 0x00024709
			public unsafe List<AccountID> _conflictParticipants_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__conflictParticipants_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__conflictParticipants_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8B RID: 6795
			// (get) Token: 0x06006377 RID: 25463 RVA: 0x001E3158 File Offset: 0x001E1358
			// (set) Token: 0x06006378 RID: 25464 RVA: 0x00026528 File Offset: 0x00024728
			public unsafe SequenceHelper _enterConflictSequence_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__enterConflictSequence_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__enterConflictSequence_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8C RID: 6796
			// (get) Token: 0x06006379 RID: 25465 RVA: 0x001E3188 File Offset: 0x001E1388
			// (set) Token: 0x0600637A RID: 25466 RVA: 0x00026547 File Offset: 0x00024747
			public unsafe IEnumerator<WormPlayer> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8D RID: 6797
			// (get) Token: 0x0600637B RID: 25467 RVA: 0x001E31B8 File Offset: 0x001E13B8
			// (set) Token: 0x0600637C RID: 25468 RVA: 0x00026566 File Offset: 0x00024766
			public unsafe WormPlayer _hagalPlayer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__hagalPlayer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._BeginCombat_d__17.NativeFieldInfoPtr__hagalPlayer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004060 RID: 16480
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004061 RID: 16481
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004062 RID: 16482
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004063 RID: 16483
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004064 RID: 16484
			private static readonly IntPtr NativeFieldInfoPtr__conflictParticipants_5__2;

			// Token: 0x04004065 RID: 16485
			private static readonly IntPtr NativeFieldInfoPtr__enterConflictSequence_5__3;

			// Token: 0x04004066 RID: 16486
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04004067 RID: 16487
			private static readonly IntPtr NativeFieldInfoPtr__hagalPlayer_5__5;

			// Token: 0x04004068 RID: 16488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004069 RID: 16489
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400406A RID: 16490
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400406B RID: 16491
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400406C RID: 16492
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400406D RID: 16493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400406E RID: 16494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400406F RID: 16495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004070 RID: 16496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004071 RID: 16497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200071C RID: 1820
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<DetermineRewards>d__19")]
		public sealed class _DetermineRewards_d__19 : Object
		{
			// Token: 0x0600637D RID: 25469 RVA: 0x001E31E8 File Offset: 0x001E13E8
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineRewards_d__19()
			{
				Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<DetermineRewards>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr);
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>1__state");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>2__current");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>l__initialThreadId");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>4__this");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>8__1");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__activeConflict_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<activeConflict>5__2");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementGroups_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<placementGroups>5__3");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementRewards_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<placementRewards>5__4");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewards_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<rewards>5__5");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__worstPlaceAllowed_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<worstPlaceAllowed>5__6");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__place_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<place>5__7");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__serializedPlayerRewards_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<serializedPlayerRewards>5__8");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__exceptions_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<exceptions>5__9");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap9");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap10");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__group_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<group>5__12");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__tied_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<tied>5__13");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewardAbility_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<rewardAbility>5__14");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap14");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentTroopStrength_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<currentTroopStrength>5__16");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentSwords_5__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<currentSwords>5__17");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__clearSpace_5__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<clearSpace>5__18");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__oldController_5__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<oldController>5__19");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap19");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap20");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<>7__wrap21");
				CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__battleResolutionSequenceHelper_5__23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, "<battleResolutionSequenceHelper>5__23");
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669384);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669385);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669386);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669387);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669388);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669389);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669390);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669391);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669392);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669393);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669394);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669395);
				CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr, 100669396);
			}

			// Token: 0x0600637E RID: 25470 RVA: 0x001E3534 File Offset: 0x001E1734
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineRewards_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase._DetermineRewards_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600637F RID: 25471 RVA: 0x001E357C File Offset: 0x001E177C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152953, XrefRangeEnd = 152981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006380 RID: 25472 RVA: 0x001E35B0 File Offset: 0x001E17B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152981, XrefRangeEnd = 153950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006381 RID: 25473 RVA: 0x001E35EC File Offset: 0x001E17EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 153953, RefRangeEnd = 153954, XrefRangeStart = 153950, XrefRangeEnd = 153953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006382 RID: 25474 RVA: 0x001E3620 File Offset: 0x001E1820
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 153957, RefRangeEnd = 153958, XrefRangeStart = 153954, XrefRangeEnd = 153957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006383 RID: 25475 RVA: 0x001E3654 File Offset: 0x001E1854
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 153961, RefRangeEnd = 153962, XrefRangeStart = 153958, XrefRangeEnd = 153961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006384 RID: 25476 RVA: 0x001E3688 File Offset: 0x001E1888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153962, XrefRangeEnd = 153965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006385 RID: 25477 RVA: 0x001E36BC File Offset: 0x001E18BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153965, XrefRangeEnd = 153968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AAB RID: 6827
			// (get) Token: 0x06006386 RID: 25478 RVA: 0x001E36F0 File Offset: 0x001E18F0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006387 RID: 25479 RVA: 0x001E3730 File Offset: 0x001E1930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153968, XrefRangeEnd = 153973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AAC RID: 6828
			// (get) Token: 0x06006388 RID: 25480 RVA: 0x001E3764 File Offset: 0x001E1964
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006389 RID: 25481 RVA: 0x001E37A4 File Offset: 0x001E19A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153973, XrefRangeEnd = 153975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600638A RID: 25482 RVA: 0x001E37E4 File Offset: 0x001E19E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._DetermineRewards_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600638B RID: 25483 RVA: 0x00026585 File Offset: 0x00024785
			public _DetermineRewards_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A90 RID: 6800
			// (get) Token: 0x0600638C RID: 25484 RVA: 0x001E3824 File Offset: 0x001E1A24
			// (set) Token: 0x0600638D RID: 25485 RVA: 0x0002658E File Offset: 0x0002478E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A91 RID: 6801
			// (get) Token: 0x0600638E RID: 25486 RVA: 0x001E384C File Offset: 0x001E1A4C
			// (set) Token: 0x0600638F RID: 25487 RVA: 0x000265A9 File Offset: 0x000247A9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A92 RID: 6802
			// (get) Token: 0x06006390 RID: 25488 RVA: 0x001E387C File Offset: 0x001E1A7C
			// (set) Token: 0x06006391 RID: 25489 RVA: 0x000265C8 File Offset: 0x000247C8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A93 RID: 6803
			// (get) Token: 0x06006392 RID: 25490 RVA: 0x001E38A4 File Offset: 0x001E1AA4
			// (set) Token: 0x06006393 RID: 25491 RVA: 0x000265E3 File Offset: 0x000247E3
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A94 RID: 6804
			// (get) Token: 0x06006394 RID: 25492 RVA: 0x001E38D4 File Offset: 0x001E1AD4
			// (set) Token: 0x06006395 RID: 25493 RVA: 0x00026602 File Offset: 0x00024802
			public unsafe CombatPhase.__c__DisplayClass19_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase.__c__DisplayClass19_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A95 RID: 6805
			// (get) Token: 0x06006396 RID: 25494 RVA: 0x001E3904 File Offset: 0x001E1B04
			// (set) Token: 0x06006397 RID: 25495 RVA: 0x00026621 File Offset: 0x00024821
			public unsafe WormConflictPlayable _activeConflict_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__activeConflict_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__activeConflict_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A96 RID: 6806
			// (get) Token: 0x06006398 RID: 25496 RVA: 0x001E3934 File Offset: 0x001E1B34
			// (set) Token: 0x06006399 RID: 25497 RVA: 0x00026640 File Offset: 0x00024840
			public unsafe List<IGrouping<int, WormPlayer>> _placementGroups_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementGroups_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGrouping<int, WormPlayer>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementGroups_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A97 RID: 6807
			// (get) Token: 0x0600639A RID: 25498 RVA: 0x001E3964 File Offset: 0x001E1B64
			// (set) Token: 0x0600639B RID: 25499 RVA: 0x0002665F File Offset: 0x0002485F
			public unsafe List<AbilityID> _placementRewards_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementRewards_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__placementRewards_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A98 RID: 6808
			// (get) Token: 0x0600639C RID: 25500 RVA: 0x001E3994 File Offset: 0x001E1B94
			// (set) Token: 0x0600639D RID: 25501 RVA: 0x0002667E File Offset: 0x0002487E
			public unsafe List<PlayerRewards> _rewards_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewards_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerRewards>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewards_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A99 RID: 6809
			// (get) Token: 0x0600639E RID: 25502 RVA: 0x001E39C4 File Offset: 0x001E1BC4
			// (set) Token: 0x0600639F RID: 25503 RVA: 0x0002669D File Offset: 0x0002489D
			public unsafe int _worstPlaceAllowed_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__worstPlaceAllowed_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__worstPlaceAllowed_5__6)) = value;
				}
			}

			// Token: 0x17001A9A RID: 6810
			// (get) Token: 0x060063A0 RID: 25504 RVA: 0x001E39EC File Offset: 0x001E1BEC
			// (set) Token: 0x060063A1 RID: 25505 RVA: 0x000266B8 File Offset: 0x000248B8
			public unsafe int _place_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__place_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__place_5__7)) = value;
				}
			}

			// Token: 0x17001A9B RID: 6811
			// (get) Token: 0x060063A2 RID: 25506 RVA: 0x001E3A14 File Offset: 0x001E1C14
			// (set) Token: 0x060063A3 RID: 25507 RVA: 0x000266D3 File Offset: 0x000248D3
			public unsafe List<SerializedPlayerReward> _serializedPlayerRewards_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__serializedPlayerRewards_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedPlayerReward>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__serializedPlayerRewards_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A9C RID: 6812
			// (get) Token: 0x060063A4 RID: 25508 RVA: 0x001E3A44 File Offset: 0x001E1C44
			// (set) Token: 0x060063A5 RID: 25509 RVA: 0x000266F2 File Offset: 0x000248F2
			public unsafe List<ArchetypeID> _exceptions_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__exceptions_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__exceptions_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A9D RID: 6813
			// (get) Token: 0x060063A6 RID: 25510 RVA: 0x001E3A74 File Offset: 0x001E1C74
			// (set) Token: 0x060063A7 RID: 25511 RVA: 0x00026711 File Offset: 0x00024911
			public List<WormPlayer>.Enumerator __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap9);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001A9E RID: 6814
			// (get) Token: 0x060063A8 RID: 25512 RVA: 0x001E3AA4 File Offset: 0x001E1CA4
			// (set) Token: 0x060063A9 RID: 25513 RVA: 0x0002673F File Offset: 0x0002493F
			public List<IGrouping<int, WormPlayer>>.Enumerator __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap10);
					return new List<IGrouping<int, WormPlayer>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IGrouping<int, WormPlayer>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IGrouping<int, WormPlayer>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001A9F RID: 6815
			// (get) Token: 0x060063AA RID: 25514 RVA: 0x001E3AD4 File Offset: 0x001E1CD4
			// (set) Token: 0x060063AB RID: 25515 RVA: 0x0002676D File Offset: 0x0002496D
			public unsafe IGrouping<int, WormPlayer> _group_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__group_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGrouping<int, WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__group_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA0 RID: 6816
			// (get) Token: 0x060063AC RID: 25516 RVA: 0x001E3B04 File Offset: 0x001E1D04
			// (set) Token: 0x060063AD RID: 25517 RVA: 0x0002678C File Offset: 0x0002498C
			public unsafe bool _tied_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__tied_5__13);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__tied_5__13)) = value;
				}
			}

			// Token: 0x17001AA1 RID: 6817
			// (get) Token: 0x060063AE RID: 25518 RVA: 0x001E3B2C File Offset: 0x001E1D2C
			// (set) Token: 0x060063AF RID: 25519 RVA: 0x000267A7 File Offset: 0x000249A7
			public unsafe ConflictAbility _rewardAbility_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewardAbility_5__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__rewardAbility_5__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA2 RID: 6818
			// (get) Token: 0x060063B0 RID: 25520 RVA: 0x001E3B5C File Offset: 0x001E1D5C
			// (set) Token: 0x060063B1 RID: 25521 RVA: 0x000267C6 File Offset: 0x000249C6
			public unsafe IEnumerator<WormPlayer> __7__wrap14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA3 RID: 6819
			// (get) Token: 0x060063B2 RID: 25522 RVA: 0x001E3B8C File Offset: 0x001E1D8C
			// (set) Token: 0x060063B3 RID: 25523 RVA: 0x000267E5 File Offset: 0x000249E5
			public unsafe int _currentTroopStrength_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentTroopStrength_5__16);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentTroopStrength_5__16)) = value;
				}
			}

			// Token: 0x17001AA4 RID: 6820
			// (get) Token: 0x060063B4 RID: 25524 RVA: 0x001E3BB4 File Offset: 0x001E1DB4
			// (set) Token: 0x060063B5 RID: 25525 RVA: 0x00026800 File Offset: 0x00024A00
			public unsafe int _currentSwords_5__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentSwords_5__17);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__currentSwords_5__17)) = value;
				}
			}

			// Token: 0x17001AA5 RID: 6821
			// (get) Token: 0x060063B6 RID: 25526 RVA: 0x001E3BDC File Offset: 0x001E1DDC
			// (set) Token: 0x060063B7 RID: 25527 RVA: 0x0002681B File Offset: 0x00024A1B
			public unsafe WormSpace _clearSpace_5__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__clearSpace_5__18);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__clearSpace_5__18), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA6 RID: 6822
			// (get) Token: 0x060063B8 RID: 25528 RVA: 0x001E3C0C File Offset: 0x001E1E0C
			// (set) Token: 0x060063B9 RID: 25529 RVA: 0x0002683A File Offset: 0x00024A3A
			public unsafe WormPlayer _oldController_5__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__oldController_5__19);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__oldController_5__19), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA7 RID: 6823
			// (get) Token: 0x060063BA RID: 25530 RVA: 0x001E3C3C File Offset: 0x001E1E3C
			// (set) Token: 0x060063BB RID: 25531 RVA: 0x00026859 File Offset: 0x00024A59
			public unsafe Il2CppReferenceArray<ArchetypeID> __7__wrap19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap19);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap19), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA8 RID: 6824
			// (get) Token: 0x060063BC RID: 25532 RVA: 0x001E3C6C File Offset: 0x001E1E6C
			// (set) Token: 0x060063BD RID: 25533 RVA: 0x00026878 File Offset: 0x00024A78
			public unsafe int __7__wrap20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap20);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap20)) = value;
				}
			}

			// Token: 0x17001AA9 RID: 6825
			// (get) Token: 0x060063BE RID: 25534 RVA: 0x001E3C94 File Offset: 0x001E1E94
			// (set) Token: 0x060063BF RID: 25535 RVA: 0x00026893 File Offset: 0x00024A93
			public unsafe IEnumerator<WormPlayer> __7__wrap21
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap21);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr___7__wrap21), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AAA RID: 6826
			// (get) Token: 0x060063C0 RID: 25536 RVA: 0x001E3CC4 File Offset: 0x001E1EC4
			// (set) Token: 0x060063C1 RID: 25537 RVA: 0x000268B2 File Offset: 0x00024AB2
			public unsafe SequenceHelper _battleResolutionSequenceHelper_5__23
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__battleResolutionSequenceHelper_5__23);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._DetermineRewards_d__19.NativeFieldInfoPtr__battleResolutionSequenceHelper_5__23), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004072 RID: 16498
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004073 RID: 16499
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004074 RID: 16500
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004075 RID: 16501
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004076 RID: 16502
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04004077 RID: 16503
			private static readonly IntPtr NativeFieldInfoPtr__activeConflict_5__2;

			// Token: 0x04004078 RID: 16504
			private static readonly IntPtr NativeFieldInfoPtr__placementGroups_5__3;

			// Token: 0x04004079 RID: 16505
			private static readonly IntPtr NativeFieldInfoPtr__placementRewards_5__4;

			// Token: 0x0400407A RID: 16506
			private static readonly IntPtr NativeFieldInfoPtr__rewards_5__5;

			// Token: 0x0400407B RID: 16507
			private static readonly IntPtr NativeFieldInfoPtr__worstPlaceAllowed_5__6;

			// Token: 0x0400407C RID: 16508
			private static readonly IntPtr NativeFieldInfoPtr__place_5__7;

			// Token: 0x0400407D RID: 16509
			private static readonly IntPtr NativeFieldInfoPtr__serializedPlayerRewards_5__8;

			// Token: 0x0400407E RID: 16510
			private static readonly IntPtr NativeFieldInfoPtr__exceptions_5__9;

			// Token: 0x0400407F RID: 16511
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04004080 RID: 16512
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x04004081 RID: 16513
			private static readonly IntPtr NativeFieldInfoPtr__group_5__12;

			// Token: 0x04004082 RID: 16514
			private static readonly IntPtr NativeFieldInfoPtr__tied_5__13;

			// Token: 0x04004083 RID: 16515
			private static readonly IntPtr NativeFieldInfoPtr__rewardAbility_5__14;

			// Token: 0x04004084 RID: 16516
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap14;

			// Token: 0x04004085 RID: 16517
			private static readonly IntPtr NativeFieldInfoPtr__currentTroopStrength_5__16;

			// Token: 0x04004086 RID: 16518
			private static readonly IntPtr NativeFieldInfoPtr__currentSwords_5__17;

			// Token: 0x04004087 RID: 16519
			private static readonly IntPtr NativeFieldInfoPtr__clearSpace_5__18;

			// Token: 0x04004088 RID: 16520
			private static readonly IntPtr NativeFieldInfoPtr__oldController_5__19;

			// Token: 0x04004089 RID: 16521
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap19;

			// Token: 0x0400408A RID: 16522
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap20;

			// Token: 0x0400408B RID: 16523
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap21;

			// Token: 0x0400408C RID: 16524
			private static readonly IntPtr NativeFieldInfoPtr__battleResolutionSequenceHelper_5__23;

			// Token: 0x0400408D RID: 16525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400408E RID: 16526
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400408F RID: 16527
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004090 RID: 16528
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004091 RID: 16529
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004092 RID: 16530
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04004093 RID: 16531
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04004094 RID: 16532
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x04004095 RID: 16533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004096 RID: 16534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004097 RID: 16535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004098 RID: 16536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004099 RID: 16537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200071D RID: 1821
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<PlayCombatIntrigueCards>d__18")]
		public sealed class _PlayCombatIntrigueCards_d__18 : Object
		{
			// Token: 0x060063C2 RID: 25538 RVA: 0x001E3CF4 File Offset: 0x001E1EF4
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayCombatIntrigueCards_d__18()
			{
				Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<PlayCombatIntrigueCards>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<>1__state");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<>2__current");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<>l__initialThreadId");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<>4__this");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<>8__1");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr__combatIntrigueCardAbilities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, "<combatIntrigueCardAbilities>5__2");
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669397);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669398);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669399);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669400);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669401);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669402);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669403);
				CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr, 100669404);
			}

			// Token: 0x060063C3 RID: 25539 RVA: 0x001E3E38 File Offset: 0x001E2038
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayCombatIntrigueCards_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase._PlayCombatIntrigueCards_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060063C4 RID: 25540 RVA: 0x001E3E80 File Offset: 0x001E2080
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060063C5 RID: 25541 RVA: 0x001E3EB4 File Offset: 0x001E20B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153975, XrefRangeEnd = 154263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AB3 RID: 6835
			// (get) Token: 0x060063C6 RID: 25542 RVA: 0x001E3EF0 File Offset: 0x001E20F0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060063C7 RID: 25543 RVA: 0x001E3F30 File Offset: 0x001E2130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154263, XrefRangeEnd = 154268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AB4 RID: 6836
			// (get) Token: 0x060063C8 RID: 25544 RVA: 0x001E3F64 File Offset: 0x001E2164
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060063C9 RID: 25545 RVA: 0x001E3FA4 File Offset: 0x001E21A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154268, XrefRangeEnd = 154270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060063CA RID: 25546 RVA: 0x001E3FE4 File Offset: 0x001E21E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatIntrigueCards_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060063CB RID: 25547 RVA: 0x000268D1 File Offset: 0x00024AD1
			public _PlayCombatIntrigueCards_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AAD RID: 6829
			// (get) Token: 0x060063CC RID: 25548 RVA: 0x001E4024 File Offset: 0x001E2224
			// (set) Token: 0x060063CD RID: 25549 RVA: 0x000268DA File Offset: 0x00024ADA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AAE RID: 6830
			// (get) Token: 0x060063CE RID: 25550 RVA: 0x001E404C File Offset: 0x001E224C
			// (set) Token: 0x060063CF RID: 25551 RVA: 0x000268F5 File Offset: 0x00024AF5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AAF RID: 6831
			// (get) Token: 0x060063D0 RID: 25552 RVA: 0x001E407C File Offset: 0x001E227C
			// (set) Token: 0x060063D1 RID: 25553 RVA: 0x00026914 File Offset: 0x00024B14
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AB0 RID: 6832
			// (get) Token: 0x060063D2 RID: 25554 RVA: 0x001E40A4 File Offset: 0x001E22A4
			// (set) Token: 0x060063D3 RID: 25555 RVA: 0x0002692F File Offset: 0x00024B2F
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB1 RID: 6833
			// (get) Token: 0x060063D4 RID: 25556 RVA: 0x001E40D4 File Offset: 0x001E22D4
			// (set) Token: 0x060063D5 RID: 25557 RVA: 0x0002694E File Offset: 0x00024B4E
			public unsafe CombatPhase.__c__DisplayClass18_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB2 RID: 6834
			// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001E4104 File Offset: 0x001E2304
			// (set) Token: 0x060063D7 RID: 25559 RVA: 0x0002696D File Offset: 0x00024B6D
			public unsafe List<WormAbilityDefinition> _combatIntrigueCardAbilities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr__combatIntrigueCardAbilities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatIntrigueCards_d__18.NativeFieldInfoPtr__combatIntrigueCardAbilities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400409A RID: 16538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400409B RID: 16539
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400409C RID: 16540
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400409D RID: 16541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400409E RID: 16542
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400409F RID: 16543
			private static readonly IntPtr NativeFieldInfoPtr__combatIntrigueCardAbilities_5__2;

			// Token: 0x040040A0 RID: 16544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040A1 RID: 16545
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040A2 RID: 16546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040A3 RID: 16547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040A4 RID: 16548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040A5 RID: 16549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040A6 RID: 16550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040A7 RID: 16551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200071E RID: 1822
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<PlayCombatResolutionIntrigueCards>d__21")]
		public sealed class _PlayCombatResolutionIntrigueCards_d__21 : Object
		{
			// Token: 0x060063D8 RID: 25560 RVA: 0x001E4134 File Offset: 0x001E2334
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayCombatResolutionIntrigueCards_d__21()
			{
				Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<PlayCombatResolutionIntrigueCards>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>1__state");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>2__current");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>l__initialThreadId");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>4__this");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>8__1");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>8__2");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__place_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<place>5__2");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__combatResolutionAbilities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<combatResolutionAbilities>5__3");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__prompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<prompt>5__4");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>7__wrap4");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__conflictAbility_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<conflictAbility>5__6");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__exceptions_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<exceptions>5__7");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>7__wrap7");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, "<>7__wrap8");
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669405);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669406);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669407);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669408);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669409);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669410);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669411);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669412);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669413);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669414);
				CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr, 100669415);
			}

			// Token: 0x060063D9 RID: 25561 RVA: 0x001E4354 File Offset: 0x001E2554
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayCombatResolutionIntrigueCards_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase._PlayCombatResolutionIntrigueCards_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060063DA RID: 25562 RVA: 0x001E439C File Offset: 0x001E259C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154270, XrefRangeEnd = 154283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060063DB RID: 25563 RVA: 0x001E43D0 File Offset: 0x001E25D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154283, XrefRangeEnd = 154862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060063DC RID: 25564 RVA: 0x001E440C File Offset: 0x001E260C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 154865, RefRangeEnd = 154866, XrefRangeStart = 154862, XrefRangeEnd = 154865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060063DD RID: 25565 RVA: 0x001E4440 File Offset: 0x001E2640
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 154869, RefRangeEnd = 154870, XrefRangeStart = 154866, XrefRangeEnd = 154869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060063DE RID: 25566 RVA: 0x001E4474 File Offset: 0x001E2674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154870, XrefRangeEnd = 154873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AC3 RID: 6851
			// (get) Token: 0x060063DF RID: 25567 RVA: 0x001E44A8 File Offset: 0x001E26A8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060063E0 RID: 25568 RVA: 0x001E44E8 File Offset: 0x001E26E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154873, XrefRangeEnd = 154878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AC4 RID: 6852
			// (get) Token: 0x060063E1 RID: 25569 RVA: 0x001E451C File Offset: 0x001E271C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060063E2 RID: 25570 RVA: 0x001E455C File Offset: 0x001E275C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154878, XrefRangeEnd = 154880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060063E3 RID: 25571 RVA: 0x001E459C File Offset: 0x001E279C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060063E4 RID: 25572 RVA: 0x0002698C File Offset: 0x00024B8C
			public _PlayCombatResolutionIntrigueCards_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AB5 RID: 6837
			// (get) Token: 0x060063E5 RID: 25573 RVA: 0x001E45DC File Offset: 0x001E27DC
			// (set) Token: 0x060063E6 RID: 25574 RVA: 0x00026995 File Offset: 0x00024B95
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AB6 RID: 6838
			// (get) Token: 0x060063E7 RID: 25575 RVA: 0x001E4604 File Offset: 0x001E2804
			// (set) Token: 0x060063E8 RID: 25576 RVA: 0x000269B0 File Offset: 0x00024BB0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB7 RID: 6839
			// (get) Token: 0x060063E9 RID: 25577 RVA: 0x001E4634 File Offset: 0x001E2834
			// (set) Token: 0x060063EA RID: 25578 RVA: 0x000269CF File Offset: 0x00024BCF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AB8 RID: 6840
			// (get) Token: 0x060063EB RID: 25579 RVA: 0x001E465C File Offset: 0x001E285C
			// (set) Token: 0x060063EC RID: 25580 RVA: 0x000269EA File Offset: 0x00024BEA
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AB9 RID: 6841
			// (get) Token: 0x060063ED RID: 25581 RVA: 0x001E468C File Offset: 0x001E288C
			// (set) Token: 0x060063EE RID: 25582 RVA: 0x00026A09 File Offset: 0x00024C09
			public unsafe CombatPhase.__c__DisplayClass21_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase.__c__DisplayClass21_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABA RID: 6842
			// (get) Token: 0x060063EF RID: 25583 RVA: 0x001E46BC File Offset: 0x001E28BC
			// (set) Token: 0x060063F0 RID: 25584 RVA: 0x00026A28 File Offset: 0x00024C28
			public unsafe CombatPhase.__c__DisplayClass21_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase.__c__DisplayClass21_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABB RID: 6843
			// (get) Token: 0x060063F1 RID: 25585 RVA: 0x001E46EC File Offset: 0x001E28EC
			// (set) Token: 0x060063F2 RID: 25586 RVA: 0x00026A47 File Offset: 0x00024C47
			public unsafe int _place_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__place_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__place_5__2)) = value;
				}
			}

			// Token: 0x17001ABC RID: 6844
			// (get) Token: 0x060063F3 RID: 25587 RVA: 0x001E4714 File Offset: 0x001E2914
			// (set) Token: 0x060063F4 RID: 25588 RVA: 0x00026A62 File Offset: 0x00024C62
			public unsafe List<WormAbilityDefinition> _combatResolutionAbilities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__combatResolutionAbilities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__combatResolutionAbilities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABD RID: 6845
			// (get) Token: 0x060063F5 RID: 25589 RVA: 0x001E4744 File Offset: 0x001E2944
			// (set) Token: 0x060063F6 RID: 25590 RVA: 0x00026A81 File Offset: 0x00024C81
			public unsafe string _prompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__prompt_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__prompt_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001ABE RID: 6846
			// (get) Token: 0x060063F7 RID: 25591 RVA: 0x001E476C File Offset: 0x001E296C
			// (set) Token: 0x060063F8 RID: 25592 RVA: 0x00026AA0 File Offset: 0x00024CA0
			public List<ConflictAbility>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap4);
					return new List<ConflictAbility>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ConflictAbility>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ConflictAbility>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001ABF RID: 6847
			// (get) Token: 0x060063F9 RID: 25593 RVA: 0x001E479C File Offset: 0x001E299C
			// (set) Token: 0x060063FA RID: 25594 RVA: 0x00026ACE File Offset: 0x00024CCE
			public unsafe ConflictAbility _conflictAbility_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__conflictAbility_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__conflictAbility_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC0 RID: 6848
			// (get) Token: 0x060063FB RID: 25595 RVA: 0x001E47CC File Offset: 0x001E29CC
			// (set) Token: 0x060063FC RID: 25596 RVA: 0x00026AED File Offset: 0x00024CED
			public unsafe List<ArchetypeID> _exceptions_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__exceptions_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr__exceptions_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC1 RID: 6849
			// (get) Token: 0x060063FD RID: 25597 RVA: 0x001E47FC File Offset: 0x001E29FC
			// (set) Token: 0x060063FE RID: 25598 RVA: 0x00026B0C File Offset: 0x00024D0C
			public List<WormPlayer>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap7);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001AC2 RID: 6850
			// (get) Token: 0x060063FF RID: 25599 RVA: 0x001E482C File Offset: 0x001E2A2C
			// (set) Token: 0x06006400 RID: 25600 RVA: 0x00026B3A File Offset: 0x00024D3A
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._PlayCombatResolutionIntrigueCards_d__21.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040A8 RID: 16552
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040040A9 RID: 16553
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040040AA RID: 16554
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040040AB RID: 16555
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040040AC RID: 16556
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040040AD RID: 16557
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x040040AE RID: 16558
			private static readonly IntPtr NativeFieldInfoPtr__place_5__2;

			// Token: 0x040040AF RID: 16559
			private static readonly IntPtr NativeFieldInfoPtr__combatResolutionAbilities_5__3;

			// Token: 0x040040B0 RID: 16560
			private static readonly IntPtr NativeFieldInfoPtr__prompt_5__4;

			// Token: 0x040040B1 RID: 16561
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040040B2 RID: 16562
			private static readonly IntPtr NativeFieldInfoPtr__conflictAbility_5__6;

			// Token: 0x040040B3 RID: 16563
			private static readonly IntPtr NativeFieldInfoPtr__exceptions_5__7;

			// Token: 0x040040B4 RID: 16564
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x040040B5 RID: 16565
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x040040B6 RID: 16566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040B7 RID: 16567
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040B8 RID: 16568
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040B9 RID: 16569
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040040BA RID: 16570
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040040BB RID: 16571
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040040BC RID: 16572
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040BD RID: 16573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040BE RID: 16574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040BF RID: 16575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040C0 RID: 16576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200071F RID: 1823
		[ObfuscatedName("worm.canis.actions.phases.CombatPhase+<ResolveCombat>d__20")]
		public sealed class _ResolveCombat_d__20 : Object
		{
			// Token: 0x06006401 RID: 25601 RVA: 0x001E485C File Offset: 0x001E2A5C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveCombat_d__20()
			{
				Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatPhase>.NativeClassPtr, "<ResolveCombat>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr);
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<>1__state");
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<>2__current");
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<>l__initialThreadId");
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<>4__this");
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardPlayer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<rewardPlayer>5__2");
				CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardAbility_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, "<rewardAbility>5__3");
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669416);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669417);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669418);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669419);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669420);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669421);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669422);
				CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr, 100669423);
			}

			// Token: 0x06006402 RID: 25602 RVA: 0x001E49A0 File Offset: 0x001E2BA0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveCombat_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatPhase._ResolveCombat_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006403 RID: 25603 RVA: 0x001E49E8 File Offset: 0x001E2BE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006404 RID: 25604 RVA: 0x001E4A1C File Offset: 0x001E2C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154880, XrefRangeEnd = 155008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001ACB RID: 6859
			// (get) Token: 0x06006405 RID: 25605 RVA: 0x001E4A58 File Offset: 0x001E2C58
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006406 RID: 25606 RVA: 0x001E4A98 File Offset: 0x001E2C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155008, XrefRangeEnd = 155013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001ACC RID: 6860
			// (get) Token: 0x06006407 RID: 25607 RVA: 0x001E4ACC File Offset: 0x001E2CCC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006408 RID: 25608 RVA: 0x001E4B0C File Offset: 0x001E2D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155013, XrefRangeEnd = 155015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006409 RID: 25609 RVA: 0x001E4B4C File Offset: 0x001E2D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatPhase._ResolveCombat_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600640A RID: 25610 RVA: 0x00026B59 File Offset: 0x00024D59
			public _ResolveCombat_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AC5 RID: 6853
			// (get) Token: 0x0600640B RID: 25611 RVA: 0x001E4B8C File Offset: 0x001E2D8C
			// (set) Token: 0x0600640C RID: 25612 RVA: 0x00026B62 File Offset: 0x00024D62
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AC6 RID: 6854
			// (get) Token: 0x0600640D RID: 25613 RVA: 0x001E4BB4 File Offset: 0x001E2DB4
			// (set) Token: 0x0600640E RID: 25614 RVA: 0x00026B7D File Offset: 0x00024D7D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC7 RID: 6855
			// (get) Token: 0x0600640F RID: 25615 RVA: 0x001E4BE4 File Offset: 0x001E2DE4
			// (set) Token: 0x06006410 RID: 25616 RVA: 0x00026B9C File Offset: 0x00024D9C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AC8 RID: 6856
			// (get) Token: 0x06006411 RID: 25617 RVA: 0x001E4C0C File Offset: 0x001E2E0C
			// (set) Token: 0x06006412 RID: 25618 RVA: 0x00026BB7 File Offset: 0x00024DB7
			public unsafe CombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC9 RID: 6857
			// (get) Token: 0x06006413 RID: 25619 RVA: 0x001E4C3C File Offset: 0x001E2E3C
			// (set) Token: 0x06006414 RID: 25620 RVA: 0x00026BD6 File Offset: 0x00024DD6
			public unsafe WormPlayer _rewardPlayer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardPlayer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardPlayer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ACA RID: 6858
			// (get) Token: 0x06006415 RID: 25621 RVA: 0x001E4C6C File Offset: 0x001E2E6C
			// (set) Token: 0x06006416 RID: 25622 RVA: 0x00026BF5 File Offset: 0x00024DF5
			public unsafe ConflictAbility _rewardAbility_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardAbility_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatPhase._ResolveCombat_d__20.NativeFieldInfoPtr__rewardAbility_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040C1 RID: 16577
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040040C2 RID: 16578
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040040C3 RID: 16579
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040040C4 RID: 16580
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040040C5 RID: 16581
			private static readonly IntPtr NativeFieldInfoPtr__rewardPlayer_5__2;

			// Token: 0x040040C6 RID: 16582
			private static readonly IntPtr NativeFieldInfoPtr__rewardAbility_5__3;

			// Token: 0x040040C7 RID: 16583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040C8 RID: 16584
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040C9 RID: 16585
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040CA RID: 16586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040CB RID: 16587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040CC RID: 16588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040CD RID: 16589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040CE RID: 16590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
