using System;
using System.Runtime.InteropServices;
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
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004E1 RID: 1249
	public class HoltzmanEngineEndgameAbility : DeferredAbility
	{
		// Token: 0x060038D5 RID: 14549 RVA: 0x0014EFC8 File Offset: 0x0014D1C8
		// Note: this type is marked as 'beforefieldinit'.
		static HoltzmanEngineEndgameAbility()
		{
			Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "HoltzmanEngineEndgameAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr);
			HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, "AbilityName");
			HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, "AbilityID");
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681523);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681524);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681525);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681526);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681527);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681528);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681529);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681530);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681531);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681532);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681533);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681534);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681535);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681536);
			HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_1_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, 100681538);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0014F14C File Offset: 0x0014D34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253431, XrefRangeEnd = 253435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0014F198 File Offset: 0x0014D398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253435, XrefRangeEnd = 253448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0014F1F4 File Offset: 0x0014D3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253448, XrefRangeEnd = 253461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoltzmanEngineEndgameAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0014F240 File Offset: 0x0014D440
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoltzmanEngineEndgameAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0014F2B0 File Offset: 0x0014D4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253461, XrefRangeEnd = 253465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0014F320 File Offset: 0x0014D520
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0014F378 File Offset: 0x0014D578
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x0014F3D0 File Offset: 0x0014D5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253465, XrefRangeEnd = 253473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0014F450 File Offset: 0x0014D650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253521, RefRangeEnd = 253523, XrefRangeStart = 253473, XrefRangeEnd = 253521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountTheSpiceMustFlow(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0014F4A0 File Offset: 0x0014D6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0014F51C File Offset: 0x0014D71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253523, XrefRangeEnd = 253524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0014F588 File Offset: 0x0014D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253524, XrefRangeEnd = 253588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<AccountID, int> GetConditionalEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, int>>(intPtr3) : null;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0014F5D4 File Offset: 0x0014D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253588, XrefRangeEnd = 253602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0014F650 File Offset: 0x0014D850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253602, XrefRangeEnd = 253606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoltzmanEngineEndgameAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0014F6AC File Offset: 0x0014D8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253606, XrefRangeEnd = 253607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetConditionalEndgameVP_b__13_1(WormPlayer p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_1_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00012CFD File Offset: 0x00010EFD
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00012D0C File Offset: 0x00010F0C
		public HoltzmanEngineEndgameAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0014F6FC File Offset: 0x0014D8FC
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x00012D15 File Offset: 0x00010F15
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x0014F71C File Offset: 0x0014D91C
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x00012D27 File Offset: 0x00010F27
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_CountTheSpiceMustFlow_Private_Int32_WormPlayer_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_1_Private_Int32_WormPlayer_0;

		// Token: 0x02000BE0 RID: 3040
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.HoltzmanEngineEndgameAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600C2A9 RID: 49833 RVA: 0x002FD4E4 File Offset: 0x002FB6E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr);
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9");
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9__10_0");
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9__10_1");
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9__10_2");
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9__13_2");
				HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, "<>9__13_0");
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681540);
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681541);
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681542);
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681543);
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681544);
				HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_0_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr, 100681545);
			}

			// Token: 0x0600C2AA RID: 49834 RVA: 0x002FD600 File Offset: 0x002FB800
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2AB RID: 49835 RVA: 0x002FD63C File Offset: 0x002FB83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253307, XrefRangeEnd = 253314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__10_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C2AC RID: 49836 RVA: 0x002FD68C File Offset: 0x002FB88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253314, XrefRangeEnd = 253321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__10_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C2AD RID: 49837 RVA: 0x002FD6DC File Offset: 0x002FB8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253321, XrefRangeEnd = 253328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountTheSpiceMustFlow_b__10_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C2AE RID: 49838 RVA: 0x002FD72C File Offset: 0x002FB92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConditionalEndgameVP_b__13_2(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C2AF RID: 49839 RVA: 0x002FD77C File Offset: 0x002FB97C
			[CallerCount(0)]
			public unsafe AccountID _GetConditionalEndgameVP_b__13_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c.NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_0_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2B0 RID: 49840 RVA: 0x0005B5FB File Offset: 0x000597FB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003C79 RID: 15481
			// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x002FD7CC File Offset: 0x002FB9CC
			// (set) Token: 0x0600C2B2 RID: 49842 RVA: 0x0005B604 File Offset: 0x00059804
			public unsafe static HoltzmanEngineEndgameAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HoltzmanEngineEndgameAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x002FD7F4 File Offset: 0x002FB9F4
			// (set) Token: 0x0600C2B4 RID: 49844 RVA: 0x0005B616 File Offset: 0x00059816
			public unsafe static Func<Entity, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7B RID: 15483
			// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x002FD81C File Offset: 0x002FBA1C
			// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x0005B628 File Offset: 0x00059828
			public unsafe static Func<Entity, bool> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7C RID: 15484
			// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x002FD844 File Offset: 0x002FBA44
			// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x0005B63A File Offset: 0x0005983A
			public unsafe static Func<Entity, bool> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x002FD86C File Offset: 0x002FBA6C
			// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x0005B64C File Offset: 0x0005984C
			public unsafe static Func<WormPlayer, bool> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x002FD894 File Offset: 0x002FBA94
			// (set) Token: 0x0600C2BC RID: 49852 RVA: 0x0005B65E File Offset: 0x0005985E
			public unsafe static Func<WormPlayer, AccountID> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HoltzmanEngineEndgameAbility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007A21 RID: 31265
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007A22 RID: 31266
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04007A23 RID: 31267
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04007A24 RID: 31268
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x04007A25 RID: 31269
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04007A26 RID: 31270
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04007A27 RID: 31271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007A28 RID: 31272
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_0_Internal_Boolean_Entity_0;

			// Token: 0x04007A29 RID: 31273
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_1_Internal_Boolean_Entity_0;

			// Token: 0x04007A2A RID: 31274
			private static readonly IntPtr NativeMethodInfoPtr__CountTheSpiceMustFlow_b__10_2_Internal_Boolean_Entity_0;

			// Token: 0x04007A2B RID: 31275
			private static readonly IntPtr NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x04007A2C RID: 31276
			private static readonly IntPtr NativeMethodInfoPtr__GetConditionalEndgameVP_b__13_0_Internal_AccountID_WormPlayer_0;
		}

		// Token: 0x02000BE1 RID: 3041
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.HoltzmanEngineEndgameAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600C2BD RID: 49853 RVA: 0x002FD8BC File Offset: 0x002FBABC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr);
				HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr, "player");
				HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr, 100681546);
				HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr, 100681547);
			}

			// Token: 0x0600C2BE RID: 49854 RVA: 0x002FD924 File Offset: 0x002FBB24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2BF RID: 49855 RVA: 0x002FD960 File Offset: 0x002FBB60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253328, XrefRangeEnd = 253389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2C0 RID: 49856 RVA: 0x0005B670 File Offset: 0x00059870
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003C7F RID: 15487
			// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x002FD9B0 File Offset: 0x002FBBB0
			// (set) Token: 0x0600C2C2 RID: 49858 RVA: 0x0005B679 File Offset: 0x00059879
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007A2D RID: 31277
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007A2E RID: 31278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007A2F RID: 31279
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000BE2 RID: 3042
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.HoltzmanEngineEndgameAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600C2C3 RID: 49859 RVA: 0x002FD9E0 File Offset: 0x002FBBE0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<>8__1");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, "<sequenceHelper>5__2");
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681548);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681549);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681550);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681551);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681552);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681553);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681554);
				HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr, 100681555);
			}

			// Token: 0x0600C2C4 RID: 49860 RVA: 0x002FDB74 File Offset: 0x002FBD74
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoltzmanEngineEndgameAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600C2C5 RID: 49861 RVA: 0x002FDBBC File Offset: 0x002FBDBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2C6 RID: 49862 RVA: 0x002FDBF0 File Offset: 0x002FBDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253389, XrefRangeEnd = 253416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C8A RID: 15498
			// (get) Token: 0x0600C2C7 RID: 49863 RVA: 0x002FDC2C File Offset: 0x002FBE2C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2C8 RID: 49864 RVA: 0x002FDC6C File Offset: 0x002FBE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253416, XrefRangeEnd = 253421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C8B RID: 15499
			// (get) Token: 0x0600C2C9 RID: 49865 RVA: 0x002FDCA0 File Offset: 0x002FBEA0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x002FDCE0 File Offset: 0x002FBEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253421, XrefRangeEnd = 253431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x002FDD20 File Offset: 0x002FBF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C2CC RID: 49868 RVA: 0x0005B698 File Offset: 0x00059898
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003C80 RID: 15488
			// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x002FDD60 File Offset: 0x002FBF60
			// (set) Token: 0x0600C2CE RID: 49870 RVA: 0x0005B6A1 File Offset: 0x000598A1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C81 RID: 15489
			// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x002FDD88 File Offset: 0x002FBF88
			// (set) Token: 0x0600C2D0 RID: 49872 RVA: 0x0005B6BC File Offset: 0x000598BC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C82 RID: 15490
			// (get) Token: 0x0600C2D1 RID: 49873 RVA: 0x002FDDB8 File Offset: 0x002FBFB8
			// (set) Token: 0x0600C2D2 RID: 49874 RVA: 0x0005B6DB File Offset: 0x000598DB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003C83 RID: 15491
			// (get) Token: 0x0600C2D3 RID: 49875 RVA: 0x002FDDE0 File Offset: 0x002FBFE0
			// (set) Token: 0x0600C2D4 RID: 49876 RVA: 0x0005B6F6 File Offset: 0x000598F6
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C84 RID: 15492
			// (get) Token: 0x0600C2D5 RID: 49877 RVA: 0x002FDE10 File Offset: 0x002FC010
			// (set) Token: 0x0600C2D6 RID: 49878 RVA: 0x0005B715 File Offset: 0x00059915
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C85 RID: 15493
			// (get) Token: 0x0600C2D7 RID: 49879 RVA: 0x002FDE40 File Offset: 0x002FC040
			// (set) Token: 0x0600C2D8 RID: 49880 RVA: 0x0005B734 File Offset: 0x00059934
			public unsafe HoltzmanEngineEndgameAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HoltzmanEngineEndgameAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C86 RID: 15494
			// (get) Token: 0x0600C2D9 RID: 49881 RVA: 0x002FDE70 File Offset: 0x002FC070
			// (set) Token: 0x0600C2DA RID: 49882 RVA: 0x0005B753 File Offset: 0x00059953
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C87 RID: 15495
			// (get) Token: 0x0600C2DB RID: 49883 RVA: 0x002FDEA0 File Offset: 0x002FC0A0
			// (set) Token: 0x0600C2DC RID: 49884 RVA: 0x0005B772 File Offset: 0x00059972
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C88 RID: 15496
			// (get) Token: 0x0600C2DD RID: 49885 RVA: 0x002FDED0 File Offset: 0x002FC0D0
			// (set) Token: 0x0600C2DE RID: 49886 RVA: 0x0005B791 File Offset: 0x00059991
			public unsafe HoltzmanEngineEndgameAbility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HoltzmanEngineEndgameAbility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C89 RID: 15497
			// (get) Token: 0x0600C2DF RID: 49887 RVA: 0x002FDF00 File Offset: 0x002FC100
			// (set) Token: 0x0600C2E0 RID: 49888 RVA: 0x0005B7B0 File Offset: 0x000599B0
			public unsafe SequenceHelper _sequenceHelper_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoltzmanEngineEndgameAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007A30 RID: 31280
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007A31 RID: 31281
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007A32 RID: 31282
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007A33 RID: 31283
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007A34 RID: 31284
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007A35 RID: 31285
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007A36 RID: 31286
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007A37 RID: 31287
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007A38 RID: 31288
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007A39 RID: 31289
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__2;

			// Token: 0x04007A3A RID: 31290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007A3B RID: 31291
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007A3C RID: 31292
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007A3D RID: 31293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007A3E RID: 31294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007A3F RID: 31295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007A40 RID: 31296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007A41 RID: 31297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
