using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.attributes;
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
using Networking.selection.targetinformation;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.SpaceAbilities;
using worm.canis.abilities.TriggeredAbilities;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities
{
	// Token: 0x0200042B RID: 1067
	public class AgentAbility : PlayAbility
	{
		// Token: 0x06002E1D RID: 11805 RVA: 0x0011850C File Offset: 0x0011670C
		// Note: this type is marked as 'beforefieldinit'.
		static AgentAbility()
		{
			Il2CppClassPointerStore<AgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities", "AgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr);
			AgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "AbilityName");
			AgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "AbilityID");
			AgentAbility.NativeFieldInfoPtr_AgentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "AgentAttributes");
			AgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677055);
			AgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677056);
			AgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677057);
			AgentAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677058);
			AgentAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677059);
			AgentAbility.NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677060);
			AgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677061);
			AgentAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677062);
			AgentAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677063);
			AgentAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, 100677064);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00118640 File Offset: 0x00116840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214727, XrefRangeEnd = 214731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x0011868C File Offset: 0x0011688C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 214764, RefRangeEnd = 214776, XrefRangeStart = 214731, XrefRangeEnd = 214764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentAbility(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x001186FC File Offset: 0x001168FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 214798, RefRangeEnd = 214808, XrefRangeStart = 214776, XrefRangeEnd = 214798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x0011876C File Offset: 0x0011696C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214816, RefRangeEnd = 214818, XrefRangeStart = 214808, XrefRangeEnd = 214816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x001187DC File Offset: 0x001169DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214818, XrefRangeEnd = 214822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x0011884C File Offset: 0x00116A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214822, XrefRangeEnd = 214828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x001188CC File Offset: 0x00116ACC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 214836, RefRangeEnd = 214854, XrefRangeStart = 214828, XrefRangeEnd = 214836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x0011894C File Offset: 0x00116B4C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x001189B8 File Offset: 0x00116BB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 215124, RefRangeEnd = 215131, XrefRangeStart = 214854, XrefRangeEnd = 215124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00118A34 File Offset: 0x00116C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215131, XrefRangeEnd = 215231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00010A46 File Offset: 0x0000EC46
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00010A55 File Offset: 0x0000EC55
		public AgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x00118A90 File Offset: 0x00116C90
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x00010A5E File Offset: 0x0000EC5E
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x00118AB0 File Offset: 0x00116CB0
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x00010A70 File Offset: 0x0000EC70
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x00118AD8 File Offset: 0x00116CD8
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x00010A82 File Offset: 0x0000EC82
		public unsafe Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>> AgentAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.NativeFieldInfoPtr_AgentAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.NativeFieldInfoPtr_AgentAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr_AgentAttributes;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_PutInPlay_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000A07 RID: 2567
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009FD9 RID: 40921 RVA: 0x00297F84 File Offset: 0x00296184
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr);
				AgentAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_2");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_3");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_4");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_6");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_5");
				AgentAbility.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__5_1");
				AgentAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__8_0");
				AgentAbility.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__11_3");
				AgentAbility.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__11_5");
				AgentAbility.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, "<>9__11_2");
				AgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677067);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_2_Internal_EntityID_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677068);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_3_Internal_ReadOnlyAttributes_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677069);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_4_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677070);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_6_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677071);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_5_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677072);
				AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677073);
				AgentAbility.__c.NativeMethodInfoPtr__PutInPlay_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677074);
				AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_3_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677075);
				AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_5_Internal_Boolean_TriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677076);
				AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_2_Internal_Boolean_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr, 100677077);
			}

			// Token: 0x06009FDA RID: 40922 RVA: 0x00298168 File Offset: 0x00296368
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009FDB RID: 40923 RVA: 0x002981A4 File Offset: 0x002963A4
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__5_2(WormSpace s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_2_Internal_EntityID_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06009FDC RID: 40924 RVA: 0x002981F4 File Offset: 0x002963F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214055, XrefRangeEnd = 214084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__5_3(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_3_Internal_ReadOnlyAttributes_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x06009FDD RID: 40925 RVA: 0x00298244 File Offset: 0x00296444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214084, XrefRangeEnd = 214088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__5_4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_4_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FDE RID: 40926 RVA: 0x00298294 File Offset: 0x00296494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214088, XrefRangeEnd = 214093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__5_6(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_6_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FDF RID: 40927 RVA: 0x002982E4 File Offset: 0x002964E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214093, XrefRangeEnd = 214102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__5_5(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_5_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FE0 RID: 40928 RVA: 0x00298334 File Offset: 0x00296534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214102, XrefRangeEnd = 214111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__5_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__Targets_b__5_1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FE1 RID: 40929 RVA: 0x00298384 File Offset: 0x00296584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214111, XrefRangeEnd = 214115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _PutInPlay_b__8_0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__PutInPlay_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06009FE2 RID: 40930 RVA: 0x002983D4 File Offset: 0x002965D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214115, XrefRangeEnd = 214122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__11_3(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_3_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FE3 RID: 40931 RVA: 0x00298424 File Offset: 0x00296624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214122, XrefRangeEnd = 214129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__11_5(TriggeredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_5_Internal_Boolean_TriggeredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FE4 RID: 40932 RVA: 0x00298474 File Offset: 0x00296674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214129, XrefRangeEnd = 214132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__11_2(AIValueSummer<double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__11_2_Internal_Boolean_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009FE5 RID: 40933 RVA: 0x000477A0 File Offset: 0x000459A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700301F RID: 12319
			// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x002984C4 File Offset: 0x002966C4
			// (set) Token: 0x06009FE7 RID: 40935 RVA: 0x000477A9 File Offset: 0x000459A9
			public unsafe static AgentAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003020 RID: 12320
			// (get) Token: 0x06009FE8 RID: 40936 RVA: 0x002984EC File Offset: 0x002966EC
			// (set) Token: 0x06009FE9 RID: 40937 RVA: 0x000477BB File Offset: 0x000459BB
			public unsafe static Func<WormSpace, EntityID> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003021 RID: 12321
			// (get) Token: 0x06009FEA RID: 40938 RVA: 0x00298514 File Offset: 0x00296714
			// (set) Token: 0x06009FEB RID: 40939 RVA: 0x000477CD File Offset: 0x000459CD
			public unsafe static Func<WormSpace, ReadOnlyAttributes> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003022 RID: 12322
			// (get) Token: 0x06009FEC RID: 40940 RVA: 0x0029853C File Offset: 0x0029673C
			// (set) Token: 0x06009FED RID: 40941 RVA: 0x000477DF File Offset: 0x000459DF
			public unsafe static Func<Entity, bool> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003023 RID: 12323
			// (get) Token: 0x06009FEE RID: 40942 RVA: 0x00298564 File Offset: 0x00296764
			// (set) Token: 0x06009FEF RID: 40943 RVA: 0x000477F1 File Offset: 0x000459F1
			public unsafe static Func<Entity, bool> __9__5_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003024 RID: 12324
			// (get) Token: 0x06009FF0 RID: 40944 RVA: 0x0029858C File Offset: 0x0029678C
			// (set) Token: 0x06009FF1 RID: 40945 RVA: 0x00047803 File Offset: 0x00045A03
			public unsafe static Func<Entity, bool> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003025 RID: 12325
			// (get) Token: 0x06009FF2 RID: 40946 RVA: 0x002985B4 File Offset: 0x002967B4
			// (set) Token: 0x06009FF3 RID: 40947 RVA: 0x00047815 File Offset: 0x00045A15
			public unsafe static Func<WormSpace, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003026 RID: 12326
			// (get) Token: 0x06009FF4 RID: 40948 RVA: 0x002985DC File Offset: 0x002967DC
			// (set) Token: 0x06009FF5 RID: 40949 RVA: 0x00047827 File Offset: 0x00045A27
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003027 RID: 12327
			// (get) Token: 0x06009FF6 RID: 40950 RVA: 0x00298604 File Offset: 0x00296804
			// (set) Token: 0x06009FF7 RID: 40951 RVA: 0x00047839 File Offset: 0x00045A39
			public unsafe static Func<DeferredAbility, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003028 RID: 12328
			// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x0029862C File Offset: 0x0029682C
			// (set) Token: 0x06009FF9 RID: 40953 RVA: 0x0004784B File Offset: 0x00045A4B
			public unsafe static Func<TriggeredAbility, bool> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggeredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003029 RID: 12329
			// (get) Token: 0x06009FFA RID: 40954 RVA: 0x00298654 File Offset: 0x00296854
			// (set) Token: 0x06009FFB RID: 40955 RVA: 0x0004785D File Offset: 0x00045A5D
			public unsafe static Func<AIValueSummer<double>, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentAbility.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400657D RID: 25981
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400657E RID: 25982
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x0400657F RID: 25983
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x04006580 RID: 25984
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x04006581 RID: 25985
			private static readonly IntPtr NativeFieldInfoPtr___9__5_6;

			// Token: 0x04006582 RID: 25986
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x04006583 RID: 25987
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04006584 RID: 25988
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04006585 RID: 25989
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04006586 RID: 25990
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04006587 RID: 25991
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04006588 RID: 25992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006589 RID: 25993
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_2_Internal_EntityID_WormSpace_0;

			// Token: 0x0400658A RID: 25994
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_3_Internal_ReadOnlyAttributes_WormSpace_0;

			// Token: 0x0400658B RID: 25995
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_4_Internal_Boolean_Entity_0;

			// Token: 0x0400658C RID: 25996
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_6_Internal_Boolean_Entity_0;

			// Token: 0x0400658D RID: 25997
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_5_Internal_Boolean_Entity_0;

			// Token: 0x0400658E RID: 25998
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__5_1_Internal_Boolean_WormSpace_0;

			// Token: 0x0400658F RID: 25999
			private static readonly IntPtr NativeMethodInfoPtr__PutInPlay_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006590 RID: 26000
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__11_3_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04006591 RID: 26001
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__11_5_Internal_Boolean_TriggeredAbility_0;

			// Token: 0x04006592 RID: 26002
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__11_2_Internal_Boolean_AIValueSummer_1_Double_0;
		}

		// Token: 0x02000A08 RID: 2568
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c__DisplayClass11_0")]
		public new sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06009FFC RID: 40956 RVA: 0x0029867C File Offset: 0x0029687C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr);
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "player");
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_withEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "withEntities");
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "<>9__4");
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "<>9__6");
				AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, "<>9__7");
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677078);
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__4_Internal_AIValueSummer_1_Double_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677079);
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__6_Internal_AIValueSummer_1_Double_TriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677080);
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Double_KeyValuePair_2_AttributeDefinition_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677081);
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_AIValueSummer_1_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677082);
				AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__7_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677083);
			}

			// Token: 0x06009FFD RID: 40957 RVA: 0x00298798 File Offset: 0x00296998
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009FFE RID: 40958 RVA: 0x002987D4 File Offset: 0x002969D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214132, XrefRangeEnd = 214133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__4(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__4_Internal_AIValueSummer_1_Double_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x06009FFF RID: 40959 RVA: 0x00298824 File Offset: 0x00296A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__6(TriggeredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__6_Internal_AIValueSummer_1_Double_TriggeredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600A000 RID: 40960 RVA: 0x00298874 File Offset: 0x00296A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214133, XrefRangeEnd = 214140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _ValueForPlayer_b__0(KeyValuePair<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Double_KeyValuePair_2_AttributeDefinition_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A001 RID: 40961 RVA: 0x002988C8 File Offset: 0x00296AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214140, XrefRangeEnd = 214152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AIValueSummer<double>> _ValueForPlayer_b__1(WormImperiumPlayable handCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handCard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_AIValueSummer_1_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AIValueSummer<double>>>(intPtr3) : null;
				}
			}

			// Token: 0x0600A002 RID: 40962 RVA: 0x00298918 File Offset: 0x00296B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214152, XrefRangeEnd = 214155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__7(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ValueForPlayer_b__7_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600A003 RID: 40963 RVA: 0x0004786F File Offset: 0x00045A6F
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700302A RID: 12330
			// (get) Token: 0x0600A004 RID: 40964 RVA: 0x00298968 File Offset: 0x00296B68
			// (set) Token: 0x0600A005 RID: 40965 RVA: 0x00047878 File Offset: 0x00045A78
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302B RID: 12331
			// (get) Token: 0x0600A006 RID: 40966 RVA: 0x00298998 File Offset: 0x00296B98
			// (set) Token: 0x0600A007 RID: 40967 RVA: 0x00047897 File Offset: 0x00045A97
			public unsafe Il2CppReferenceArray<WormEntity> withEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_withEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_withEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302C RID: 12332
			// (get) Token: 0x0600A008 RID: 40968 RVA: 0x002989C8 File Offset: 0x00296BC8
			// (set) Token: 0x0600A009 RID: 40969 RVA: 0x000478B6 File Offset: 0x00045AB6
			public unsafe AgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302D RID: 12333
			// (get) Token: 0x0600A00A RID: 40970 RVA: 0x002989F8 File Offset: 0x00296BF8
			// (set) Token: 0x0600A00B RID: 40971 RVA: 0x000478D5 File Offset: 0x00045AD5
			public unsafe Func<DeferredAbility, AIValueSummer<double>> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302E RID: 12334
			// (get) Token: 0x0600A00C RID: 40972 RVA: 0x00298A28 File Offset: 0x00296C28
			// (set) Token: 0x0600A00D RID: 40973 RVA: 0x000478F4 File Offset: 0x00045AF4
			public unsafe Func<TriggeredAbility, AIValueSummer<double>> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggeredAbility, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302F RID: 12335
			// (get) Token: 0x0600A00E RID: 40974 RVA: 0x00298A58 File Offset: 0x00296C58
			// (set) Token: 0x0600A00F RID: 40975 RVA: 0x00047913 File Offset: 0x00045B13
			public unsafe Func<WormAbilityDefinition, AIValueSummer<double>> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass11_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006593 RID: 26003
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006594 RID: 26004
			private static readonly IntPtr NativeFieldInfoPtr_withEntities;

			// Token: 0x04006595 RID: 26005
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006596 RID: 26006
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006597 RID: 26007
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04006598 RID: 26008
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04006599 RID: 26009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400659A RID: 26010
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__4_Internal_AIValueSummer_1_Double_DeferredAbility_0;

			// Token: 0x0400659B RID: 26011
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__6_Internal_AIValueSummer_1_Double_TriggeredAbility_0;

			// Token: 0x0400659C RID: 26012
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Double_KeyValuePair_2_AttributeDefinition_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

			// Token: 0x0400659D RID: 26013
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_AIValueSummer_1_Double_WormImperiumPlayable_0;

			// Token: 0x0400659E RID: 26014
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__7_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000A09 RID: 2569
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600A010 RID: 40976 RVA: 0x00298A88 File Offset: 0x00296C88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr);
				AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, "player");
				AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, "owner");
				AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, "<>9__1");
				AgentAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, 100677084);
				AgentAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr, 100677085);
			}

			// Token: 0x0600A011 RID: 40977 RVA: 0x00298B2C File Offset: 0x00296D2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A012 RID: 40978 RVA: 0x00298B68 File Offset: 0x00296D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214155, XrefRangeEnd = 214159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600A013 RID: 40979 RVA: 0x00047932 File Offset: 0x00045B32
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003030 RID: 12336
			// (get) Token: 0x0600A014 RID: 40980 RVA: 0x00298BB8 File Offset: 0x00296DB8
			// (set) Token: 0x0600A015 RID: 40981 RVA: 0x0004793B File Offset: 0x00045B3B
			public unsafe AgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003031 RID: 12337
			// (get) Token: 0x0600A016 RID: 40982 RVA: 0x00298BE8 File Offset: 0x00296DE8
			// (set) Token: 0x0600A017 RID: 40983 RVA: 0x0004795A File Offset: 0x00045B5A
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003032 RID: 12338
			// (get) Token: 0x0600A018 RID: 40984 RVA: 0x00298C18 File Offset: 0x00296E18
			// (set) Token: 0x0600A019 RID: 40985 RVA: 0x00047979 File Offset: 0x00045B79
			public unsafe WormImperiumPlayable owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003033 RID: 12339
			// (get) Token: 0x0600A01A RID: 40986 RVA: 0x00298C48 File Offset: 0x00296E48
			// (set) Token: 0x0600A01B RID: 40987 RVA: 0x00047998 File Offset: 0x00045B98
			public unsafe Func<WormAbilityDefinition, AIValueSummer<double>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400659F RID: 26015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065A0 RID: 26016
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040065A1 RID: 26017
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040065A2 RID: 26018
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040065A3 RID: 26019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040065A4 RID: 26020
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000A0A RID: 2570
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Object
		{
			// Token: 0x0600A01C RID: 40988 RVA: 0x00298C78 File Offset: 0x00296E78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr);
				AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr, "space");
				AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
				AgentAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr, 100677086);
				AgentAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr, 100677087);
			}

			// Token: 0x0600A01D RID: 40989 RVA: 0x00298CF4 File Offset: 0x00296EF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A01E RID: 40990 RVA: 0x00298D30 File Offset: 0x00296F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214159, XrefRangeEnd = 214160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(SpaceAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A01F RID: 40991 RVA: 0x000479B7 File Offset: 0x00045BB7
			public __c__DisplayClass12_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003034 RID: 12340
			// (get) Token: 0x0600A020 RID: 40992 RVA: 0x00298D80 File Offset: 0x00296F80
			// (set) Token: 0x0600A021 RID: 40993 RVA: 0x000479C0 File Offset: 0x00045BC0
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003035 RID: 12341
			// (get) Token: 0x0600A022 RID: 40994 RVA: 0x00298DB0 File Offset: 0x00296FB0
			// (set) Token: 0x0600A023 RID: 40995 RVA: 0x000479DF File Offset: 0x00045BDF
			public unsafe AgentAbility.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065A5 RID: 26021
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x040065A6 RID: 26022
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;

			// Token: 0x040065A7 RID: 26023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040065A8 RID: 26024
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0;
		}

		// Token: 0x02000A0B RID: 2571
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600A024 RID: 40996 RVA: 0x00298DE0 File Offset: 0x00296FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr);
				AgentAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr, "agentCard");
				AgentAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr, 100677088);
				AgentAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr, 100677089);
			}

			// Token: 0x0600A025 RID: 40997 RVA: 0x00298E48 File Offset: 0x00297048
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A026 RID: 40998 RVA: 0x00298E84 File Offset: 0x00297084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214160, XrefRangeEnd = 214161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__0(WormImperiumPlayable handCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handCard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A027 RID: 40999 RVA: 0x000479FE File Offset: 0x00045BFE
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003036 RID: 12342
			// (get) Token: 0x0600A028 RID: 41000 RVA: 0x00298ED4 File Offset: 0x002970D4
			// (set) Token: 0x0600A029 RID: 41001 RVA: 0x00047A07 File Offset: 0x00045C07
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065A9 RID: 26025
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x040065AA RID: 26026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040065AB RID: 26027
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000A0C RID: 2572
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Object
		{
			// Token: 0x0600A02A RID: 41002 RVA: 0x00298F04 File Offset: 0x00297104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr);
				AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr, "agentTroops");
				AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentSpecimen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr, "agentSpecimen");
				AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr, "<>9__7");
				AgentAbility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr, 100677090);
				AgentAbility.__c__DisplayClass5_1.NativeMethodInfoPtr__Targets_b__7_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr, 100677091);
			}

			// Token: 0x0600A02B RID: 41003 RVA: 0x00298F94 File Offset: 0x00297194
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A02C RID: 41004 RVA: 0x00298FD0 File Offset: 0x002971D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214161, XrefRangeEnd = 214162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Targets_b__7(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility.__c__DisplayClass5_1.NativeMethodInfoPtr__Targets_b__7_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A02D RID: 41005 RVA: 0x00047A26 File Offset: 0x00045C26
			public __c__DisplayClass5_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003037 RID: 12343
			// (get) Token: 0x0600A02E RID: 41006 RVA: 0x00299020 File Offset: 0x00297220
			// (set) Token: 0x0600A02F RID: 41007 RVA: 0x00047A2F File Offset: 0x00045C2F
			public unsafe int agentTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentTroops)) = value;
				}
			}

			// Token: 0x17003038 RID: 12344
			// (get) Token: 0x0600A030 RID: 41008 RVA: 0x00299048 File Offset: 0x00297248
			// (set) Token: 0x0600A031 RID: 41009 RVA: 0x00047A4A File Offset: 0x00045C4A
			public unsafe int agentSpecimen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentSpecimen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr_agentSpecimen)) = value;
				}
			}

			// Token: 0x17003039 RID: 12345
			// (get) Token: 0x0600A032 RID: 41010 RVA: 0x00299070 File Offset: 0x00297270
			// (set) Token: 0x0600A033 RID: 41011 RVA: 0x00047A65 File Offset: 0x00045C65
			public unsafe Func<Entity, int> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility.__c__DisplayClass5_1.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065AC RID: 26028
			private static readonly IntPtr NativeFieldInfoPtr_agentTroops;

			// Token: 0x040065AD RID: 26029
			private static readonly IntPtr NativeFieldInfoPtr_agentSpecimen;

			// Token: 0x040065AE RID: 26030
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040065AF RID: 26031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040065B0 RID: 26032
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__7_Internal_Int32_Entity_0;
		}

		// Token: 0x02000A0D RID: 2573
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<PutInPlay>d__8")]
		public sealed class _PutInPlay_d__8 : Object
		{
			// Token: 0x0600A034 RID: 41012 RVA: 0x002990A0 File Offset: 0x002972A0
			// Note: this type is marked as 'beforefieldinit'.
			static _PutInPlay_d__8()
			{
				Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<PutInPlay>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr);
				AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, "<>1__state");
				AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, "<>2__current");
				AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, "<>l__initialThreadId");
				AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, "activeAbility");
				AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, "<>3__activeAbility");
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677092);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677093);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677094);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677095);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677096);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677097);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677098);
				AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr, 100677099);
			}

			// Token: 0x0600A035 RID: 41013 RVA: 0x002991D0 File Offset: 0x002973D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PutInPlay_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility._PutInPlay_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A036 RID: 41014 RVA: 0x00299218 File Offset: 0x00297418
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A037 RID: 41015 RVA: 0x0029924C File Offset: 0x0029744C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214162, XrefRangeEnd = 214179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700303F RID: 12351
			// (get) Token: 0x0600A038 RID: 41016 RVA: 0x00299288 File Offset: 0x00297488
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A039 RID: 41017 RVA: 0x002992C8 File Offset: 0x002974C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214179, XrefRangeEnd = 214184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003040 RID: 12352
			// (get) Token: 0x0600A03A RID: 41018 RVA: 0x002992FC File Offset: 0x002974FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A03B RID: 41019 RVA: 0x0029933C File Offset: 0x0029753C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214184, XrefRangeEnd = 214192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A03C RID: 41020 RVA: 0x0029937C File Offset: 0x0029757C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._PutInPlay_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A03D RID: 41021 RVA: 0x00047A84 File Offset: 0x00045C84
			public _PutInPlay_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700303A RID: 12346
			// (get) Token: 0x0600A03E RID: 41022 RVA: 0x002993BC File Offset: 0x002975BC
			// (set) Token: 0x0600A03F RID: 41023 RVA: 0x00047A8D File Offset: 0x00045C8D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700303B RID: 12347
			// (get) Token: 0x0600A040 RID: 41024 RVA: 0x002993E4 File Offset: 0x002975E4
			// (set) Token: 0x0600A041 RID: 41025 RVA: 0x00047AA8 File Offset: 0x00045CA8
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700303C RID: 12348
			// (get) Token: 0x0600A042 RID: 41026 RVA: 0x00299414 File Offset: 0x00297614
			// (set) Token: 0x0600A043 RID: 41027 RVA: 0x00047AC7 File Offset: 0x00045CC7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700303D RID: 12349
			// (get) Token: 0x0600A044 RID: 41028 RVA: 0x0029943C File Offset: 0x0029763C
			// (set) Token: 0x0600A045 RID: 41029 RVA: 0x00047AE2 File Offset: 0x00045CE2
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700303E RID: 12350
			// (get) Token: 0x0600A046 RID: 41030 RVA: 0x0029946C File Offset: 0x0029766C
			// (set) Token: 0x0600A047 RID: 41031 RVA: 0x00047B01 File Offset: 0x00045D01
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._PutInPlay_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065B1 RID: 26033
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040065B2 RID: 26034
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040065B3 RID: 26035
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040065B4 RID: 26036
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040065B5 RID: 26037
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040065B6 RID: 26038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040065B7 RID: 26039
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065B8 RID: 26040
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040065B9 RID: 26041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040065BA RID: 26042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065BB RID: 26043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040065BC RID: 26044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040065BD RID: 26045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A0E RID: 2574
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<RunImmediateEffects>d__9")]
		public sealed class _RunImmediateEffects_d__9 : Object
		{
			// Token: 0x0600A048 RID: 41032 RVA: 0x0029949C File Offset: 0x0029769C
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__9()
			{
				Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<RunImmediateEffects>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr);
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>1__state");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>2__current");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>l__initialThreadId");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>4__this");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "activeAbility");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>3__activeAbility");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "match");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>3__match");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<player>5__2");
				AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, "<>7__wrap2");
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677100);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677101);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677102);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677103);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677104);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677105);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677106);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677107);
				AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr, 100677108);
			}

			// Token: 0x0600A049 RID: 41033 RVA: 0x00299644 File Offset: 0x00297844
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility._RunImmediateEffects_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A04A RID: 41034 RVA: 0x0029968C File Offset: 0x0029788C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214192, XrefRangeEnd = 214197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A04B RID: 41035 RVA: 0x002996C0 File Offset: 0x002978C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214197, XrefRangeEnd = 214294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A04C RID: 41036 RVA: 0x002996FC File Offset: 0x002978FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214294, XrefRangeEnd = 214297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700304B RID: 12363
			// (get) Token: 0x0600A04D RID: 41037 RVA: 0x00299730 File Offset: 0x00297930
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A04E RID: 41038 RVA: 0x00299770 File Offset: 0x00297970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214297, XrefRangeEnd = 214302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700304C RID: 12364
			// (get) Token: 0x0600A04F RID: 41039 RVA: 0x002997A4 File Offset: 0x002979A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A050 RID: 41040 RVA: 0x002997E4 File Offset: 0x002979E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214302, XrefRangeEnd = 214312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A051 RID: 41041 RVA: 0x00299824 File Offset: 0x00297A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._RunImmediateEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A052 RID: 41042 RVA: 0x00047B20 File Offset: 0x00045D20
			public _RunImmediateEffects_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003041 RID: 12353
			// (get) Token: 0x0600A053 RID: 41043 RVA: 0x00299864 File Offset: 0x00297A64
			// (set) Token: 0x0600A054 RID: 41044 RVA: 0x00047B29 File Offset: 0x00045D29
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003042 RID: 12354
			// (get) Token: 0x0600A055 RID: 41045 RVA: 0x0029988C File Offset: 0x00297A8C
			// (set) Token: 0x0600A056 RID: 41046 RVA: 0x00047B44 File Offset: 0x00045D44
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003043 RID: 12355
			// (get) Token: 0x0600A057 RID: 41047 RVA: 0x002998BC File Offset: 0x00297ABC
			// (set) Token: 0x0600A058 RID: 41048 RVA: 0x00047B63 File Offset: 0x00045D63
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003044 RID: 12356
			// (get) Token: 0x0600A059 RID: 41049 RVA: 0x002998E4 File Offset: 0x00297AE4
			// (set) Token: 0x0600A05A RID: 41050 RVA: 0x00047B7E File Offset: 0x00045D7E
			public unsafe AgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003045 RID: 12357
			// (get) Token: 0x0600A05B RID: 41051 RVA: 0x00299914 File Offset: 0x00297B14
			// (set) Token: 0x0600A05C RID: 41052 RVA: 0x00047B9D File Offset: 0x00045D9D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003046 RID: 12358
			// (get) Token: 0x0600A05D RID: 41053 RVA: 0x00299944 File Offset: 0x00297B44
			// (set) Token: 0x0600A05E RID: 41054 RVA: 0x00047BBC File Offset: 0x00045DBC
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003047 RID: 12359
			// (get) Token: 0x0600A05F RID: 41055 RVA: 0x00299974 File Offset: 0x00297B74
			// (set) Token: 0x0600A060 RID: 41056 RVA: 0x00047BDB File Offset: 0x00045DDB
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003048 RID: 12360
			// (get) Token: 0x0600A061 RID: 41057 RVA: 0x002999A4 File Offset: 0x00297BA4
			// (set) Token: 0x0600A062 RID: 41058 RVA: 0x00047BFA File Offset: 0x00045DFA
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003049 RID: 12361
			// (get) Token: 0x0600A063 RID: 41059 RVA: 0x002999D4 File Offset: 0x00297BD4
			// (set) Token: 0x0600A064 RID: 41060 RVA: 0x00047C19 File Offset: 0x00045E19
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304A RID: 12362
			// (get) Token: 0x0600A065 RID: 41061 RVA: 0x00299A04 File Offset: 0x00297C04
			// (set) Token: 0x0600A066 RID: 41062 RVA: 0x00047C38 File Offset: 0x00045E38
			public Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.KeyCollection.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___7__wrap2);
					return new Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.KeyCollection.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.KeyCollection.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._RunImmediateEffects_d__9.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.KeyCollection.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040065BE RID: 26046
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040065BF RID: 26047
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040065C0 RID: 26048
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040065C1 RID: 26049
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065C2 RID: 26050
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040065C3 RID: 26051
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040065C4 RID: 26052
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040065C5 RID: 26053
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040065C6 RID: 26054
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040065C7 RID: 26055
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040065C8 RID: 26056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040065C9 RID: 26057
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065CA RID: 26058
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040065CB RID: 26059
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040065CC RID: 26060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040065CD RID: 26061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065CE RID: 26062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040065CF RID: 26063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040065D0 RID: 26064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A0F RID: 2575
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.AgentAbility+<Targets>d__5")]
		public sealed class _Targets_d__5 : Object
		{
			// Token: 0x0600A067 RID: 41063 RVA: 0x00299A34 File Offset: 0x00297C34
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__5()
			{
				Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentAbility>.NativeClassPtr, "<Targets>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr);
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>1__state");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>2__current");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>l__initialThreadId");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "context");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>3__context");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>4__this");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "match");
				AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, "<>3__match");
				AgentAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677109);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677110);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677111);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677112);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677113);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677114);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677115);
				AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr, 100677116);
			}

			// Token: 0x0600A068 RID: 41064 RVA: 0x00299BA0 File Offset: 0x00297DA0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentAbility._Targets_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A069 RID: 41065 RVA: 0x00299BE8 File Offset: 0x00297DE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A06A RID: 41066 RVA: 0x00299C1C File Offset: 0x00297E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214312, XrefRangeEnd = 214712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003055 RID: 12373
			// (get) Token: 0x0600A06B RID: 41067 RVA: 0x00299C58 File Offset: 0x00297E58
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600A06C RID: 41068 RVA: 0x00299C98 File Offset: 0x00297E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214712, XrefRangeEnd = 214717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003056 RID: 12374
			// (get) Token: 0x0600A06D RID: 41069 RVA: 0x00299CCC File Offset: 0x00297ECC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A06E RID: 41070 RVA: 0x00299D0C File Offset: 0x00297F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214717, XrefRangeEnd = 214727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600A06F RID: 41071 RVA: 0x00299D4C File Offset: 0x00297F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentAbility._Targets_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A070 RID: 41072 RVA: 0x00047C66 File Offset: 0x00045E66
			public _Targets_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700304D RID: 12365
			// (get) Token: 0x0600A071 RID: 41073 RVA: 0x00299D8C File Offset: 0x00297F8C
			// (set) Token: 0x0600A072 RID: 41074 RVA: 0x00047C6F File Offset: 0x00045E6F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700304E RID: 12366
			// (get) Token: 0x0600A073 RID: 41075 RVA: 0x00299DB4 File Offset: 0x00297FB4
			// (set) Token: 0x0600A074 RID: 41076 RVA: 0x00047C8A File Offset: 0x00045E8A
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700304F RID: 12367
			// (get) Token: 0x0600A075 RID: 41077 RVA: 0x00299DE4 File Offset: 0x00297FE4
			// (set) Token: 0x0600A076 RID: 41078 RVA: 0x00047CA9 File Offset: 0x00045EA9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003050 RID: 12368
			// (get) Token: 0x0600A077 RID: 41079 RVA: 0x00299E0C File Offset: 0x0029800C
			// (set) Token: 0x0600A078 RID: 41080 RVA: 0x00047CC4 File Offset: 0x00045EC4
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003051 RID: 12369
			// (get) Token: 0x0600A079 RID: 41081 RVA: 0x00299E3C File Offset: 0x0029803C
			// (set) Token: 0x0600A07A RID: 41082 RVA: 0x00047CE3 File Offset: 0x00045EE3
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003052 RID: 12370
			// (get) Token: 0x0600A07B RID: 41083 RVA: 0x00299E6C File Offset: 0x0029806C
			// (set) Token: 0x0600A07C RID: 41084 RVA: 0x00047D02 File Offset: 0x00045F02
			public unsafe AgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003053 RID: 12371
			// (get) Token: 0x0600A07D RID: 41085 RVA: 0x00299E9C File Offset: 0x0029809C
			// (set) Token: 0x0600A07E RID: 41086 RVA: 0x00047D21 File Offset: 0x00045F21
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003054 RID: 12372
			// (get) Token: 0x0600A07F RID: 41087 RVA: 0x00299ECC File Offset: 0x002980CC
			// (set) Token: 0x0600A080 RID: 41088 RVA: 0x00047D40 File Offset: 0x00045F40
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentAbility._Targets_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065D1 RID: 26065
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040065D2 RID: 26066
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040065D3 RID: 26067
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040065D4 RID: 26068
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040065D5 RID: 26069
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040065D6 RID: 26070
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065D7 RID: 26071
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040065D8 RID: 26072
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040065D9 RID: 26073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040065DA RID: 26074
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065DB RID: 26075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040065DC RID: 26076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040065DD RID: 26077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065DE RID: 26078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040065DF RID: 26079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040065E0 RID: 26080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
