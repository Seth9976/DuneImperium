using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000478 RID: 1144
	public class CornerTheMarketAbility : IntrigueAbility
	{
		// Token: 0x060032BA RID: 12986 RVA: 0x0012FCFC File Offset: 0x0012DEFC
		// Note: this type is marked as 'beforefieldinit'.
		static CornerTheMarketAbility()
		{
			Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "CornerTheMarketAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr);
			CornerTheMarketAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "AbilityName");
			CornerTheMarketAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "AbilityID");
			CornerTheMarketAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679069);
			CornerTheMarketAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679070);
			CornerTheMarketAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679071);
			CornerTheMarketAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679072);
			CornerTheMarketAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679073);
			CornerTheMarketAbility.NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679074);
			CornerTheMarketAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679075);
			CornerTheMarketAbility.NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679076);
			CornerTheMarketAbility.NativeMethodInfoPtr_CountTotalPoints_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679077);
			CornerTheMarketAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679078);
			CornerTheMarketAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679079);
			CornerTheMarketAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679080);
			CornerTheMarketAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679081);
			CornerTheMarketAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679082);
			CornerTheMarketAbility.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679083);
			CornerTheMarketAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, 100679085);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x0012FE94 File Offset: 0x0012E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232444, XrefRangeEnd = 232448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x0012FEE0 File Offset: 0x0012E0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232448, XrefRangeEnd = 232454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x0012FF3C File Offset: 0x0012E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232454, XrefRangeEnd = 232467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerTheMarketAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x0012FF88 File Offset: 0x0012E188
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerTheMarketAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x0012FFF8 File Offset: 0x0012E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232467, XrefRangeEnd = 232471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00130068 File Offset: 0x0012E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232471, XrefRangeEnd = 232480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> PutInPlay(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x001300E8 File Offset: 0x0012E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232480, XrefRangeEnd = 232488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00130168 File Offset: 0x0012E368
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 232536, RefRangeEnd = 232541, XrefRangeStart = 232488, XrefRangeEnd = 232536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountTheSpiceMustFlow(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x001301B8 File Offset: 0x0012E3B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232565, RefRangeEnd = 232566, XrefRangeStart = 232541, XrefRangeEnd = 232565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountTotalPoints(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.NativeMethodInfoPtr_CountTotalPoints_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00130208 File Offset: 0x0012E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232566, XrefRangeEnd = 232571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeRunImmediateEffects(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00130274 File Offset: 0x0012E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232571, XrefRangeEnd = 232580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEndgamePlayable(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x001302E0 File Offset: 0x0012E4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232580, XrefRangeEnd = 232595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<AccountID, int> GetConditionalEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, int>>(intPtr3) : null;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0013032C File Offset: 0x0012E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232595, XrefRangeEnd = 232596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsBadIntrigue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00130398 File Offset: 0x0012E598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232596, XrefRangeEnd = 232605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x001303F4 File Offset: 0x0012E5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232605, XrefRangeEnd = 232644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueInPileForOtherPlay(WormPlayArea pile, WormPlayable card, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CornerTheMarketAbility.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x00130474 File Offset: 0x0012E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerable<global::Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000119AB File Offset: 0x0000FBAB
		public CornerTheMarketAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x001304E8 File Offset: 0x0012E6E8
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x000119B4 File Offset: 0x0000FBB4
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x00130508 File Offset: 0x0012E708
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x000119C6 File Offset: 0x0000FBC6
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeMethodInfoPtr_CountTotalPoints_Private_Int32_WormPlayer_0;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000AE5 RID: 2789
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600AFF1 RID: 45041 RVA: 0x002C6FC0 File Offset: 0x002C51C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr);
				CornerTheMarketAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, "<>9");
				CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, "<>9__9_0");
				CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, "<>9__9_1");
				CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, "<>9__9_2");
				CornerTheMarketAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, 100679087);
				CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, 100679088);
				CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, 100679089);
				CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr, 100679090);
			}

			// Token: 0x0600AFF2 RID: 45042 RVA: 0x002C708C File Offset: 0x002C528C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AFF3 RID: 45043 RVA: 0x002C70C8 File Offset: 0x002C52C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232291, XrefRangeEnd = 232298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__9_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AFF4 RID: 45044 RVA: 0x002C7118 File Offset: 0x002C5318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232298, XrefRangeEnd = 232305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__9_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AFF5 RID: 45045 RVA: 0x002C7168 File Offset: 0x002C5368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232305, XrefRangeEnd = 232312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__9_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AFF6 RID: 45046 RVA: 0x000508E7 File Offset: 0x0004EAE7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035C8 RID: 13768
			// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x002C71B8 File Offset: 0x002C53B8
			// (set) Token: 0x0600AFF8 RID: 45048 RVA: 0x000508F0 File Offset: 0x0004EAF0
			public unsafe static CornerTheMarketAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035C9 RID: 13769
			// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x002C71E0 File Offset: 0x002C53E0
			// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x00050902 File Offset: 0x0004EB02
			public unsafe static Func<Entity, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CA RID: 13770
			// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x002C7208 File Offset: 0x002C5408
			// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x00050914 File Offset: 0x0004EB14
			public unsafe static Func<Entity, bool> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CB RID: 13771
			// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x002C7230 File Offset: 0x002C5430
			// (set) Token: 0x0600AFFE RID: 45054 RVA: 0x00050926 File Offset: 0x0004EB26
			public unsafe static Func<Entity, bool> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CornerTheMarketAbility.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F0A RID: 28426
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006F0B RID: 28427
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04006F0C RID: 28428
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04006F0D RID: 28429
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04006F0E RID: 28430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F0F RID: 28431
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_0_Internal_Boolean_Entity_0;

			// Token: 0x04006F10 RID: 28432
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_1_Internal_Boolean_Entity_0;

			// Token: 0x04006F11 RID: 28433
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__9_2_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000AE6 RID: 2790
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600AFFF RID: 45055 RVA: 0x002C7258 File Offset: 0x002C5458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr);
				CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_playerTSMF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr, "playerTSMF");
				CornerTheMarketAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679091);
				CornerTheMarketAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__CountTotalPoints_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679092);
			}

			// Token: 0x0600B000 RID: 45056 RVA: 0x002C72D4 File Offset: 0x002C54D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B001 RID: 45057 RVA: 0x002C7310 File Offset: 0x002C5510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232312, XrefRangeEnd = 232313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTotalPoints_b__0(WormPlayer opponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__CountTotalPoints_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B002 RID: 45058 RVA: 0x00050938 File Offset: 0x0004EB38
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035CC RID: 13772
			// (get) Token: 0x0600B003 RID: 45059 RVA: 0x002C7360 File Offset: 0x002C5560
			// (set) Token: 0x0600B004 RID: 45060 RVA: 0x00050941 File Offset: 0x0004EB41
			public unsafe CornerTheMarketAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CD RID: 13773
			// (get) Token: 0x0600B005 RID: 45061 RVA: 0x002C7390 File Offset: 0x002C5590
			// (set) Token: 0x0600B006 RID: 45062 RVA: 0x00050960 File Offset: 0x0004EB60
			public unsafe int playerTSMF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_playerTSMF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_playerTSMF)) = value;
				}
			}

			// Token: 0x04006F12 RID: 28434
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F13 RID: 28435
			private static readonly IntPtr NativeFieldInfoPtr_playerTSMF;

			// Token: 0x04006F14 RID: 28436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F15 RID: 28437
			private static readonly IntPtr NativeMethodInfoPtr__CountTotalPoints_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000AE7 RID: 2791
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600B007 RID: 45063 RVA: 0x002C73B8 File Offset: 0x002C55B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr);
				CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_playerTSMF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr, "playerTSMF");
				CornerTheMarketAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr, 100679093);
				CornerTheMarketAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__IsEndgamePlayable_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr, 100679094);
			}

			// Token: 0x0600B008 RID: 45064 RVA: 0x002C7434 File Offset: 0x002C5634
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B009 RID: 45065 RVA: 0x002C7470 File Offset: 0x002C5670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsEndgamePlayable_b__0(WormPlayer opponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__IsEndgamePlayable_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B00A RID: 45066 RVA: 0x0005097B File Offset: 0x0004EB7B
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035CE RID: 13774
			// (get) Token: 0x0600B00B RID: 45067 RVA: 0x002C74C0 File Offset: 0x002C56C0
			// (set) Token: 0x0600B00C RID: 45068 RVA: 0x00050984 File Offset: 0x0004EB84
			public unsafe CornerTheMarketAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CF RID: 13775
			// (get) Token: 0x0600B00D RID: 45069 RVA: 0x002C74F0 File Offset: 0x002C56F0
			// (set) Token: 0x0600B00E RID: 45070 RVA: 0x000509A3 File Offset: 0x0004EBA3
			public unsafe int playerTSMF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_playerTSMF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_playerTSMF)) = value;
				}
			}

			// Token: 0x04006F16 RID: 28438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F17 RID: 28439
			private static readonly IntPtr NativeFieldInfoPtr_playerTSMF;

			// Token: 0x04006F18 RID: 28440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F19 RID: 28441
			private static readonly IntPtr NativeMethodInfoPtr__IsEndgamePlayable_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000AE8 RID: 2792
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600B00F RID: 45071 RVA: 0x002C7518 File Offset: 0x002C5718
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr);
				CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr, "player");
				CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_totalPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr, "totalPoints");
				CornerTheMarketAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679095);
				CornerTheMarketAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679096);
			}

			// Token: 0x0600B010 RID: 45072 RVA: 0x002C7594 File Offset: 0x002C5794
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B011 RID: 45073 RVA: 0x002C75D0 File Offset: 0x002C57D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232313, XrefRangeEnd = 232323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600B012 RID: 45074 RVA: 0x000509BE File Offset: 0x0004EBBE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035D0 RID: 13776
			// (get) Token: 0x0600B013 RID: 45075 RVA: 0x002C7620 File Offset: 0x002C5820
			// (set) Token: 0x0600B014 RID: 45076 RVA: 0x000509C7 File Offset: 0x0004EBC7
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D1 RID: 13777
			// (get) Token: 0x0600B015 RID: 45077 RVA: 0x002C7650 File Offset: 0x002C5850
			// (set) Token: 0x0600B016 RID: 45078 RVA: 0x000509E6 File Offset: 0x0004EBE6
			public unsafe int totalPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_totalPoints);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_totalPoints)) = value;
				}
			}

			// Token: 0x04006F1A RID: 28442
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006F1B RID: 28443
			private static readonly IntPtr NativeFieldInfoPtr_totalPoints;

			// Token: 0x04006F1C RID: 28444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F1D RID: 28445
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000AE9 RID: 2793
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<PutInPlay>d__7")]
		public new sealed class _PutInPlay_d__7 : Object
		{
			// Token: 0x0600B017 RID: 45079 RVA: 0x002C7678 File Offset: 0x002C5878
			// Note: this type is marked as 'beforefieldinit'.
			static _PutInPlay_d__7()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<PutInPlay>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr);
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>1__state");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>2__current");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>l__initialThreadId");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "activeAbility");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>3__activeAbility");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "match");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>3__match");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>4__this");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "context");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>3__context");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr__sequenceHelper_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<sequenceHelper>5__2");
				CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, "<>7__wrap2");
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679097);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679098);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679099);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679100);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679101);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679102);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679103);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679104);
				CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr, 100679105);
			}

			// Token: 0x0600B018 RID: 45080 RVA: 0x002C7848 File Offset: 0x002C5A48
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PutInPlay_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility._PutInPlay_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B019 RID: 45081 RVA: 0x002C7890 File Offset: 0x002C5A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232323, XrefRangeEnd = 232328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B01A RID: 45082 RVA: 0x002C78C4 File Offset: 0x002C5AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232328, XrefRangeEnd = 232390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B01B RID: 45083 RVA: 0x002C7900 File Offset: 0x002C5B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232390, XrefRangeEnd = 232393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035DE RID: 13790
			// (get) Token: 0x0600B01C RID: 45084 RVA: 0x002C7934 File Offset: 0x002C5B34
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B01D RID: 45085 RVA: 0x002C7974 File Offset: 0x002C5B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232393, XrefRangeEnd = 232398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035DF RID: 13791
			// (get) Token: 0x0600B01E RID: 45086 RVA: 0x002C79A8 File Offset: 0x002C5BA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B01F RID: 45087 RVA: 0x002C79E8 File Offset: 0x002C5BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232398, XrefRangeEnd = 232409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B020 RID: 45088 RVA: 0x002C7A28 File Offset: 0x002C5C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._PutInPlay_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B021 RID: 45089 RVA: 0x00050A01 File Offset: 0x0004EC01
			public _PutInPlay_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035D2 RID: 13778
			// (get) Token: 0x0600B022 RID: 45090 RVA: 0x002C7A68 File Offset: 0x002C5C68
			// (set) Token: 0x0600B023 RID: 45091 RVA: 0x00050A0A File Offset: 0x0004EC0A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035D3 RID: 13779
			// (get) Token: 0x0600B024 RID: 45092 RVA: 0x002C7A90 File Offset: 0x002C5C90
			// (set) Token: 0x0600B025 RID: 45093 RVA: 0x00050A25 File Offset: 0x0004EC25
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D4 RID: 13780
			// (get) Token: 0x0600B026 RID: 45094 RVA: 0x002C7AC0 File Offset: 0x002C5CC0
			// (set) Token: 0x0600B027 RID: 45095 RVA: 0x00050A44 File Offset: 0x0004EC44
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170035D5 RID: 13781
			// (get) Token: 0x0600B028 RID: 45096 RVA: 0x002C7AE8 File Offset: 0x002C5CE8
			// (set) Token: 0x0600B029 RID: 45097 RVA: 0x00050A5F File Offset: 0x0004EC5F
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D6 RID: 13782
			// (get) Token: 0x0600B02A RID: 45098 RVA: 0x002C7B18 File Offset: 0x002C5D18
			// (set) Token: 0x0600B02B RID: 45099 RVA: 0x00050A7E File Offset: 0x0004EC7E
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D7 RID: 13783
			// (get) Token: 0x0600B02C RID: 45100 RVA: 0x002C7B48 File Offset: 0x002C5D48
			// (set) Token: 0x0600B02D RID: 45101 RVA: 0x00050A9D File Offset: 0x0004EC9D
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D8 RID: 13784
			// (get) Token: 0x0600B02E RID: 45102 RVA: 0x002C7B78 File Offset: 0x002C5D78
			// (set) Token: 0x0600B02F RID: 45103 RVA: 0x00050ABC File Offset: 0x0004ECBC
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D9 RID: 13785
			// (get) Token: 0x0600B030 RID: 45104 RVA: 0x002C7BA8 File Offset: 0x002C5DA8
			// (set) Token: 0x0600B031 RID: 45105 RVA: 0x00050ADB File Offset: 0x0004ECDB
			public unsafe CornerTheMarketAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DA RID: 13786
			// (get) Token: 0x0600B032 RID: 45106 RVA: 0x002C7BD8 File Offset: 0x002C5DD8
			// (set) Token: 0x0600B033 RID: 45107 RVA: 0x00050AFA File Offset: 0x0004ECFA
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DB RID: 13787
			// (get) Token: 0x0600B034 RID: 45108 RVA: 0x002C7C08 File Offset: 0x002C5E08
			// (set) Token: 0x0600B035 RID: 45109 RVA: 0x00050B19 File Offset: 0x0004ED19
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DC RID: 13788
			// (get) Token: 0x0600B036 RID: 45110 RVA: 0x002C7C38 File Offset: 0x002C5E38
			// (set) Token: 0x0600B037 RID: 45111 RVA: 0x00050B38 File Offset: 0x0004ED38
			public unsafe SequenceHelper _sequenceHelper_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr__sequenceHelper_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr__sequenceHelper_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DD RID: 13789
			// (get) Token: 0x0600B038 RID: 45112 RVA: 0x002C7C68 File Offset: 0x002C5E68
			// (set) Token: 0x0600B039 RID: 45113 RVA: 0x00050B57 File Offset: 0x0004ED57
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._PutInPlay_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F1E RID: 28446
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F1F RID: 28447
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F20 RID: 28448
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006F21 RID: 28449
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006F22 RID: 28450
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006F23 RID: 28451
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006F24 RID: 28452
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006F25 RID: 28453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F26 RID: 28454
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006F27 RID: 28455
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006F28 RID: 28456
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__2;

			// Token: 0x04006F29 RID: 28457
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006F2A RID: 28458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F2B RID: 28459
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F2C RID: 28460
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F2D RID: 28461
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006F2E RID: 28462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006F2F RID: 28463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F30 RID: 28464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F31 RID: 28465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006F32 RID: 28466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000AEA RID: 2794
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.CornerTheMarketAbility+<RunImmediateEffects>d__8")]
		public sealed class _RunImmediateEffects_d__8 : Object
		{
			// Token: 0x0600B03A RID: 45114 RVA: 0x002C7C98 File Offset: 0x002C5E98
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__8()
			{
				Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CornerTheMarketAbility>.NativeClassPtr, "<RunImmediateEffects>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>1__state");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>2__current");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>l__initialThreadId");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "activeAbility");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__activeAbility");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>4__this");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "match");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__match");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>8__1");
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679106);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679107);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679108);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679109);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679110);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679111);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679112);
				CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679113);
			}

			// Token: 0x0600B03B RID: 45115 RVA: 0x002C7E18 File Offset: 0x002C6018
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerTheMarketAbility._RunImmediateEffects_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B03C RID: 45116 RVA: 0x002C7E60 File Offset: 0x002C6060
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B03D RID: 45117 RVA: 0x002C7E94 File Offset: 0x002C6094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232409, XrefRangeEnd = 232429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170035E9 RID: 13801
			// (get) Token: 0x0600B03E RID: 45118 RVA: 0x002C7ED0 File Offset: 0x002C60D0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B03F RID: 45119 RVA: 0x002C7F10 File Offset: 0x002C6110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232429, XrefRangeEnd = 232434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035EA RID: 13802
			// (get) Token: 0x0600B040 RID: 45120 RVA: 0x002C7F44 File Offset: 0x002C6144
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B041 RID: 45121 RVA: 0x002C7F84 File Offset: 0x002C6184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232434, XrefRangeEnd = 232444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B042 RID: 45122 RVA: 0x002C7FC4 File Offset: 0x002C61C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B043 RID: 45123 RVA: 0x00050B76 File Offset: 0x0004ED76
			public _RunImmediateEffects_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170035E0 RID: 13792
			// (get) Token: 0x0600B044 RID: 45124 RVA: 0x002C8004 File Offset: 0x002C6204
			// (set) Token: 0x0600B045 RID: 45125 RVA: 0x00050B7F File Offset: 0x0004ED7F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035E1 RID: 13793
			// (get) Token: 0x0600B046 RID: 45126 RVA: 0x002C802C File Offset: 0x002C622C
			// (set) Token: 0x0600B047 RID: 45127 RVA: 0x00050B9A File Offset: 0x0004ED9A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E2 RID: 13794
			// (get) Token: 0x0600B048 RID: 45128 RVA: 0x002C805C File Offset: 0x002C625C
			// (set) Token: 0x0600B049 RID: 45129 RVA: 0x00050BB9 File Offset: 0x0004EDB9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170035E3 RID: 13795
			// (get) Token: 0x0600B04A RID: 45130 RVA: 0x002C8084 File Offset: 0x002C6284
			// (set) Token: 0x0600B04B RID: 45131 RVA: 0x00050BD4 File Offset: 0x0004EDD4
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E4 RID: 13796
			// (get) Token: 0x0600B04C RID: 45132 RVA: 0x002C80B4 File Offset: 0x002C62B4
			// (set) Token: 0x0600B04D RID: 45133 RVA: 0x00050BF3 File Offset: 0x0004EDF3
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E5 RID: 13797
			// (get) Token: 0x0600B04E RID: 45134 RVA: 0x002C80E4 File Offset: 0x002C62E4
			// (set) Token: 0x0600B04F RID: 45135 RVA: 0x00050C12 File Offset: 0x0004EE12
			public unsafe CornerTheMarketAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E6 RID: 13798
			// (get) Token: 0x0600B050 RID: 45136 RVA: 0x002C8114 File Offset: 0x002C6314
			// (set) Token: 0x0600B051 RID: 45137 RVA: 0x00050C31 File Offset: 0x0004EE31
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E7 RID: 13799
			// (get) Token: 0x0600B052 RID: 45138 RVA: 0x002C8144 File Offset: 0x002C6344
			// (set) Token: 0x0600B053 RID: 45139 RVA: 0x00050C50 File Offset: 0x0004EE50
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E8 RID: 13800
			// (get) Token: 0x0600B054 RID: 45140 RVA: 0x002C8174 File Offset: 0x002C6374
			// (set) Token: 0x0600B055 RID: 45141 RVA: 0x00050C6F File Offset: 0x0004EE6F
			public unsafe CornerTheMarketAbility.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerTheMarketAbility.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerTheMarketAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F33 RID: 28467
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F34 RID: 28468
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F35 RID: 28469
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006F36 RID: 28470
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006F37 RID: 28471
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006F38 RID: 28472
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F39 RID: 28473
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006F3A RID: 28474
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006F3B RID: 28475
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006F3C RID: 28476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F3D RID: 28477
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F3E RID: 28478
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F3F RID: 28479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006F40 RID: 28480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F41 RID: 28481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F42 RID: 28482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006F43 RID: 28483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
