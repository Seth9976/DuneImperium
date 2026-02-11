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
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x0200046D RID: 1133
	public class ReverendMotherMohiamDeferredAbility : DeferredAbility
	{
		// Token: 0x06003217 RID: 12823 RVA: 0x0012C9D4 File Offset: 0x0012ABD4
		// Note: this type is marked as 'beforefieldinit'.
		static ReverendMotherMohiamDeferredAbility()
		{
			Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "ReverendMotherMohiamDeferredAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr);
			ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "AbilityName");
			ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "AbilityID");
			ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_DefaultLogToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "DefaultLogToken");
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678787);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678788);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678789);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678790);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678791);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678792);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678793);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_SendDiscardSequence_Private_IEnumerable_1_Action_WormPlayer_WormActiveAbility_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678794);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678795);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678796);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678797);
			ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, 100678798);
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x0012CB30 File Offset: 0x0012AD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229945, XrefRangeEnd = 229949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x0012CB7C File Offset: 0x0012AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229949, XrefRangeEnd = 229955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0012CBD8 File Offset: 0x0012ADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229955, XrefRangeEnd = 229968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReverendMotherMohiamDeferredAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0012CC24 File Offset: 0x0012AE24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReverendMotherMohiamDeferredAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x0012CC94 File Offset: 0x0012AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229968, XrefRangeEnd = 229975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0012CD04 File Offset: 0x0012AF04
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x0012CD5C File Offset: 0x0012AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229975, XrefRangeEnd = 229993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x0012CDB4 File Offset: 0x0012AFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230001, RefRangeEnd = 230003, XrefRangeStart = 229993, XrefRangeEnd = 230001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> SendDiscardSequence(WormPlayer opponent, WormActiveAbility activeAbility, WormMatch match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_SendDiscardSequence_Private_IEnumerable_1_Action_WormPlayer_WormActiveAbility_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0012CE28 File Offset: 0x0012B028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230003, XrefRangeEnd = 230011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0012CEA8 File Offset: 0x0012B0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230011, XrefRangeEnd = 230054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x0012CF24 File Offset: 0x0012B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230054, XrefRangeEnd = 230107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x0012CFA0 File Offset: 0x0012B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230107, XrefRangeEnd = 230169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReverendMotherMohiamDeferredAbility.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0001178C File Offset: 0x0000F98C
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0001179B File Offset: 0x0000F99B
		public ReverendMotherMohiamDeferredAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0012D020 File Offset: 0x0012B220
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x000117A4 File Offset: 0x0000F9A4
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0012D040 File Offset: 0x0012B240
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x000117B6 File Offset: 0x0000F9B6
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x0012D068 File Offset: 0x0012B268
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x000117C8 File Offset: 0x0000F9C8
		public unsafe static string DefaultLogToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_DefaultLogToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.NativeFieldInfoPtr_DefaultLogToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLogToken;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_SendDiscardSequence_Private_IEnumerable_1_Action_WormPlayer_WormActiveAbility_WormMatch_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0;

		// Token: 0x02000AC6 RID: 2758
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.ReverendMotherMohiamDeferredAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600ADB7 RID: 44471 RVA: 0x002C0658 File Offset: 0x002BE858
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr);
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__11_1");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__11_2");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__11_3");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__11_4");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__13_0");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__13_1");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__14_0");
				ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, "<>9__14_1");
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678801);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678802);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678803);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678804);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678805);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678806);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678807);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678808);
				ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr, 100678809);
			}

			// Token: 0x0600ADB8 RID: 44472 RVA: 0x002C07EC File Offset: 0x002BE9EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADB9 RID: 44473 RVA: 0x002C0828 File Offset: 0x002BEA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229533, XrefRangeEnd = 229539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__11_1(GameLogBuilder gameLogBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADBA RID: 44474 RVA: 0x002C0878 File Offset: 0x002BEA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229539, XrefRangeEnd = 229545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__11_2(GameLogBuilder gameLogBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADBB RID: 44475 RVA: 0x002C08C8 File Offset: 0x002BEAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229545, XrefRangeEnd = 229551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__11_3(GameLogBuilder gameLogBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADBC RID: 44476 RVA: 0x002C0918 File Offset: 0x002BEB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _BeginExecution_b__11_4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADBD RID: 44477 RVA: 0x002C0968 File Offset: 0x002BEB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229551, XrefRangeEnd = 229556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__13_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600ADBE RID: 44478 RVA: 0x002C09B8 File Offset: 0x002BEBB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229556, XrefRangeEnd = 229557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__13_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600ADBF RID: 44479 RVA: 0x002C0A08 File Offset: 0x002BEC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229557, XrefRangeEnd = 229562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueInPileForOtherPlay_b__14_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600ADC0 RID: 44480 RVA: 0x002C0A58 File Offset: 0x002BEC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueInPileForOtherPlay_b__14_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600ADC1 RID: 44481 RVA: 0x0004F59C File Offset: 0x0004D79C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003505 RID: 13573
			// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002C0AA8 File Offset: 0x002BECA8
			// (set) Token: 0x0600ADC3 RID: 44483 RVA: 0x0004F5A5 File Offset: 0x0004D7A5
			public unsafe static ReverendMotherMohiamDeferredAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverendMotherMohiamDeferredAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003506 RID: 13574
			// (get) Token: 0x0600ADC4 RID: 44484 RVA: 0x002C0AD0 File Offset: 0x002BECD0
			// (set) Token: 0x0600ADC5 RID: 44485 RVA: 0x0004F5B7 File Offset: 0x0004D7B7
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003507 RID: 13575
			// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x002C0AF8 File Offset: 0x002BECF8
			// (set) Token: 0x0600ADC7 RID: 44487 RVA: 0x0004F5C9 File Offset: 0x0004D7C9
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003508 RID: 13576
			// (get) Token: 0x0600ADC8 RID: 44488 RVA: 0x002C0B20 File Offset: 0x002BED20
			// (set) Token: 0x0600ADC9 RID: 44489 RVA: 0x0004F5DB File Offset: 0x0004D7DB
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003509 RID: 13577
			// (get) Token: 0x0600ADCA RID: 44490 RVA: 0x002C0B48 File Offset: 0x002BED48
			// (set) Token: 0x0600ADCB RID: 44491 RVA: 0x0004F5ED File Offset: 0x0004D7ED
			public unsafe static Func<Entity, ArchetypeID> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700350A RID: 13578
			// (get) Token: 0x0600ADCC RID: 44492 RVA: 0x002C0B70 File Offset: 0x002BED70
			// (set) Token: 0x0600ADCD RID: 44493 RVA: 0x0004F5FF File Offset: 0x0004D7FF
			public unsafe static Func<Entity, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700350B RID: 13579
			// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x002C0B98 File Offset: 0x002BED98
			// (set) Token: 0x0600ADCF RID: 44495 RVA: 0x0004F611 File Offset: 0x0004D811
			public unsafe static Func<WormPlayer, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700350C RID: 13580
			// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x002C0BC0 File Offset: 0x002BEDC0
			// (set) Token: 0x0600ADD1 RID: 44497 RVA: 0x0004F623 File Offset: 0x0004D823
			public unsafe static Func<Entity, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700350D RID: 13581
			// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x002C0BE8 File Offset: 0x002BEDE8
			// (set) Token: 0x0600ADD3 RID: 44499 RVA: 0x0004F635 File Offset: 0x0004D835
			public unsafe static Func<WormPlayer, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiamDeferredAbility.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DB7 RID: 28087
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006DB8 RID: 28088
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04006DB9 RID: 28089
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04006DBA RID: 28090
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04006DBB RID: 28091
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04006DBC RID: 28092
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04006DBD RID: 28093
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04006DBE RID: 28094
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04006DBF RID: 28095
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04006DC0 RID: 28096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006DC1 RID: 28097
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006DC2 RID: 28098
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006DC3 RID: 28099
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006DC4 RID: 28100
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_ArchetypeID_Entity_0;

			// Token: 0x04006DC5 RID: 28101
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_Entity_0;

			// Token: 0x04006DC6 RID: 28102
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__13_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04006DC7 RID: 28103
			private static readonly IntPtr NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_0_Internal_Boolean_Entity_0;

			// Token: 0x04006DC8 RID: 28104
			private static readonly IntPtr NativeMethodInfoPtr__ValueInPileForOtherPlay_b__14_1_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000AC7 RID: 2759
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.ReverendMotherMohiamDeferredAbility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600ADD4 RID: 44500 RVA: 0x002C0C10 File Offset: 0x002BEE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr);
				ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr, "player");
				ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678810);
				ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678811);
			}

			// Token: 0x0600ADD5 RID: 44501 RVA: 0x002C0C78 File Offset: 0x002BEE78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADD6 RID: 44502 RVA: 0x002C0CB4 File Offset: 0x002BEEB4
			[CallerCount(0)]
			public unsafe bool _BeginExecution_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600ADD7 RID: 44503 RVA: 0x0004F647 File Offset: 0x0004D847
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700350E RID: 13582
			// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x002C0D04 File Offset: 0x002BEF04
			// (set) Token: 0x0600ADD9 RID: 44505 RVA: 0x0004F650 File Offset: 0x0004D850
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DC9 RID: 28105
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006DCA RID: 28106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006DCB RID: 28107
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000AC8 RID: 2760
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.ReverendMotherMohiamDeferredAbility+<BeginExecution>d__11")]
		public sealed class _BeginExecution_d__11 : Object
		{
			// Token: 0x0600ADDA RID: 44506 RVA: 0x002C0D34 File Offset: 0x002BEF34
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__11()
			{
				Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "<BeginExecution>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>1__state");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>2__current");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>l__initialThreadId");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "activeAbility");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__activeAbility");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "match");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__match");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>4__this");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>8__1");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__nextIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<nextIndex>5__2");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__opponents_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<opponents>5__3");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__previousOpponent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<previousOpponent>5__4");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<>7__wrap4");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<i>5__6");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__targets_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<targets>5__7");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__logBuilder_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, "<logBuilder>5__8");
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678812);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678813);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678814);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678815);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678816);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678817);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678818);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678819);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678820);
				ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr, 100678821);
			}

			// Token: 0x0600ADDB RID: 44507 RVA: 0x002C0F68 File Offset: 0x002BF168
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._BeginExecution_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600ADDC RID: 44508 RVA: 0x002C0FB0 File Offset: 0x002BF1B0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADDD RID: 44509 RVA: 0x002C0FE4 File Offset: 0x002BF1E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229562, XrefRangeEnd = 229891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ADDE RID: 44510 RVA: 0x002C1020 File Offset: 0x002BF220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229891, XrefRangeEnd = 229894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADDF RID: 44511 RVA: 0x002C1054 File Offset: 0x002BF254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229894, XrefRangeEnd = 229897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700351F RID: 13599
			// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x002C1088 File Offset: 0x002BF288
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADE1 RID: 44513 RVA: 0x002C10C8 File Offset: 0x002BF2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229897, XrefRangeEnd = 229902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003520 RID: 13600
			// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x002C10FC File Offset: 0x002BF2FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADE3 RID: 44515 RVA: 0x002C113C File Offset: 0x002BF33C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229902, XrefRangeEnd = 229912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600ADE4 RID: 44516 RVA: 0x002C117C File Offset: 0x002BF37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ADE5 RID: 44517 RVA: 0x0004F66F File Offset: 0x0004D86F
			public _BeginExecution_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700350F RID: 13583
			// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x002C11BC File Offset: 0x002BF3BC
			// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x0004F678 File Offset: 0x0004D878
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003510 RID: 13584
			// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x002C11E4 File Offset: 0x002BF3E4
			// (set) Token: 0x0600ADE9 RID: 44521 RVA: 0x0004F693 File Offset: 0x0004D893
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003511 RID: 13585
			// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x002C1214 File Offset: 0x002BF414
			// (set) Token: 0x0600ADEB RID: 44523 RVA: 0x0004F6B2 File Offset: 0x0004D8B2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003512 RID: 13586
			// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x002C123C File Offset: 0x002BF43C
			// (set) Token: 0x0600ADED RID: 44525 RVA: 0x0004F6CD File Offset: 0x0004D8CD
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003513 RID: 13587
			// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x002C126C File Offset: 0x002BF46C
			// (set) Token: 0x0600ADEF RID: 44527 RVA: 0x0004F6EC File Offset: 0x0004D8EC
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003514 RID: 13588
			// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x002C129C File Offset: 0x002BF49C
			// (set) Token: 0x0600ADF1 RID: 44529 RVA: 0x0004F70B File Offset: 0x0004D90B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003515 RID: 13589
			// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x002C12CC File Offset: 0x002BF4CC
			// (set) Token: 0x0600ADF3 RID: 44531 RVA: 0x0004F72A File Offset: 0x0004D92A
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003516 RID: 13590
			// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x002C12FC File Offset: 0x002BF4FC
			// (set) Token: 0x0600ADF5 RID: 44533 RVA: 0x0004F749 File Offset: 0x0004D949
			public unsafe ReverendMotherMohiamDeferredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverendMotherMohiamDeferredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003517 RID: 13591
			// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x002C132C File Offset: 0x002BF52C
			// (set) Token: 0x0600ADF7 RID: 44535 RVA: 0x0004F768 File Offset: 0x0004D968
			public unsafe ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverendMotherMohiamDeferredAbility.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003518 RID: 13592
			// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x002C135C File Offset: 0x002BF55C
			// (set) Token: 0x0600ADF9 RID: 44537 RVA: 0x0004F787 File Offset: 0x0004D987
			public unsafe int _nextIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__nextIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__nextIndex_5__2)) = value;
				}
			}

			// Token: 0x17003519 RID: 13593
			// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x002C1384 File Offset: 0x002BF584
			// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x0004F7A2 File Offset: 0x0004D9A2
			public unsafe List<WormPlayer> _opponents_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__opponents_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__opponents_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700351A RID: 13594
			// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x002C13B4 File Offset: 0x002BF5B4
			// (set) Token: 0x0600ADFD RID: 44541 RVA: 0x0004F7C1 File Offset: 0x0004D9C1
			public unsafe WormPlayer _previousOpponent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__previousOpponent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__previousOpponent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700351B RID: 13595
			// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x002C13E4 File Offset: 0x002BF5E4
			// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700351C RID: 13596
			// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x002C1414 File Offset: 0x002BF614
			// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x0004F7FF File Offset: 0x0004D9FF
			public unsafe int _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x1700351D RID: 13597
			// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x002C143C File Offset: 0x002BF63C
			// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x0004F81A File Offset: 0x0004DA1A
			public unsafe List<Entity> _targets_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__targets_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__targets_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700351E RID: 13598
			// (get) Token: 0x0600AE04 RID: 44548 RVA: 0x002C146C File Offset: 0x002BF66C
			// (set) Token: 0x0600AE05 RID: 44549 RVA: 0x0004F839 File Offset: 0x0004DA39
			public unsafe GameLogBuilder _logBuilder_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__logBuilder_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._BeginExecution_d__11.NativeFieldInfoPtr__logBuilder_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DCC RID: 28108
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006DCD RID: 28109
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006DCE RID: 28110
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006DCF RID: 28111
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006DD0 RID: 28112
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006DD1 RID: 28113
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006DD2 RID: 28114
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006DD3 RID: 28115
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006DD4 RID: 28116
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006DD5 RID: 28117
			private static readonly IntPtr NativeFieldInfoPtr__nextIndex_5__2;

			// Token: 0x04006DD6 RID: 28118
			private static readonly IntPtr NativeFieldInfoPtr__opponents_5__3;

			// Token: 0x04006DD7 RID: 28119
			private static readonly IntPtr NativeFieldInfoPtr__previousOpponent_5__4;

			// Token: 0x04006DD8 RID: 28120
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04006DD9 RID: 28121
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04006DDA RID: 28122
			private static readonly IntPtr NativeFieldInfoPtr__targets_5__7;

			// Token: 0x04006DDB RID: 28123
			private static readonly IntPtr NativeFieldInfoPtr__logBuilder_5__8;

			// Token: 0x04006DDC RID: 28124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006DDD RID: 28125
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DDE RID: 28126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006DDF RID: 28127
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006DE0 RID: 28128
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04006DE1 RID: 28129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006DE2 RID: 28130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DE3 RID: 28131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006DE4 RID: 28132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006DE5 RID: 28133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000AC9 RID: 2761
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.ReverendMotherMohiamDeferredAbility+<SendDiscardSequence>d__10")]
		public sealed class _SendDiscardSequence_d__10 : Object
		{
			// Token: 0x0600AE06 RID: 44550 RVA: 0x002C149C File Offset: 0x002BF69C
			// Note: this type is marked as 'beforefieldinit'.
			static _SendDiscardSequence_d__10()
			{
				Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility>.NativeClassPtr, "<SendDiscardSequence>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>1__state");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>2__current");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>l__initialThreadId");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "match");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>3__match");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "opponent");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>3__opponent");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "activeAbility");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<>3__activeAbility");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr__sequence_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, "<sequence>5__2");
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678822);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678823);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678824);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678825);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678826);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678827);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678828);
				ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr, 100678829);
			}

			// Token: 0x0600AE07 RID: 44551 RVA: 0x002C1630 File Offset: 0x002BF830
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendDiscardSequence_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AE08 RID: 44552 RVA: 0x002C1678 File Offset: 0x002BF878
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AE09 RID: 44553 RVA: 0x002C16AC File Offset: 0x002BF8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229912, XrefRangeEnd = 229930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700352B RID: 13611
			// (get) Token: 0x0600AE0A RID: 44554 RVA: 0x002C16E8 File Offset: 0x002BF8E8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600AE0B RID: 44555 RVA: 0x002C1728 File Offset: 0x002BF928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229930, XrefRangeEnd = 229935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700352C RID: 13612
			// (get) Token: 0x0600AE0C RID: 44556 RVA: 0x002C175C File Offset: 0x002BF95C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AE0D RID: 44557 RVA: 0x002C179C File Offset: 0x002BF99C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229935, XrefRangeEnd = 229945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AE0E RID: 44558 RVA: 0x002C17DC File Offset: 0x002BF9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AE0F RID: 44559 RVA: 0x0004F858 File Offset: 0x0004DA58
			public _SendDiscardSequence_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003521 RID: 13601
			// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x002C181C File Offset: 0x002BFA1C
			// (set) Token: 0x0600AE11 RID: 44561 RVA: 0x0004F861 File Offset: 0x0004DA61
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003522 RID: 13602
			// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x002C1844 File Offset: 0x002BFA44
			// (set) Token: 0x0600AE13 RID: 44563 RVA: 0x0004F87C File Offset: 0x0004DA7C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003523 RID: 13603
			// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x002C1874 File Offset: 0x002BFA74
			// (set) Token: 0x0600AE15 RID: 44565 RVA: 0x0004F89B File Offset: 0x0004DA9B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003524 RID: 13604
			// (get) Token: 0x0600AE16 RID: 44566 RVA: 0x002C189C File Offset: 0x002BFA9C
			// (set) Token: 0x0600AE17 RID: 44567 RVA: 0x0004F8B6 File Offset: 0x0004DAB6
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003525 RID: 13605
			// (get) Token: 0x0600AE18 RID: 44568 RVA: 0x002C18CC File Offset: 0x002BFACC
			// (set) Token: 0x0600AE19 RID: 44569 RVA: 0x0004F8D5 File Offset: 0x0004DAD5
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003526 RID: 13606
			// (get) Token: 0x0600AE1A RID: 44570 RVA: 0x002C18FC File Offset: 0x002BFAFC
			// (set) Token: 0x0600AE1B RID: 44571 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
			public unsafe WormPlayer opponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_opponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_opponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003527 RID: 13607
			// (get) Token: 0x0600AE1C RID: 44572 RVA: 0x002C192C File Offset: 0x002BFB2C
			// (set) Token: 0x0600AE1D RID: 44573 RVA: 0x0004F913 File Offset: 0x0004DB13
			public unsafe WormPlayer __3__opponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__opponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__opponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003528 RID: 13608
			// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x002C195C File Offset: 0x002BFB5C
			// (set) Token: 0x0600AE1F RID: 44575 RVA: 0x0004F932 File Offset: 0x0004DB32
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003529 RID: 13609
			// (get) Token: 0x0600AE20 RID: 44576 RVA: 0x002C198C File Offset: 0x002BFB8C
			// (set) Token: 0x0600AE21 RID: 44577 RVA: 0x0004F951 File Offset: 0x0004DB51
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700352A RID: 13610
			// (get) Token: 0x0600AE22 RID: 44578 RVA: 0x002C19BC File Offset: 0x002BFBBC
			// (set) Token: 0x0600AE23 RID: 44579 RVA: 0x0004F970 File Offset: 0x0004DB70
			public unsafe SequenceHelper _sequence_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr__sequence_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverendMotherMohiamDeferredAbility._SendDiscardSequence_d__10.NativeFieldInfoPtr__sequence_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DE6 RID: 28134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006DE7 RID: 28135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006DE8 RID: 28136
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006DE9 RID: 28137
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006DEA RID: 28138
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006DEB RID: 28139
			private static readonly IntPtr NativeFieldInfoPtr_opponent;

			// Token: 0x04006DEC RID: 28140
			private static readonly IntPtr NativeFieldInfoPtr___3__opponent;

			// Token: 0x04006DED RID: 28141
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006DEE RID: 28142
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006DEF RID: 28143
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__2;

			// Token: 0x04006DF0 RID: 28144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006DF1 RID: 28145
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DF2 RID: 28146
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006DF3 RID: 28147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006DF4 RID: 28148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DF5 RID: 28149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006DF6 RID: 28150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006DF7 RID: 28151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
