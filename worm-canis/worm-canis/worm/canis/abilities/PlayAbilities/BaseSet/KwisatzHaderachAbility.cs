using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
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
using worm.canis.abilities.SpaceAbilities;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000487 RID: 1159
	public class KwisatzHaderachAbility : AgentAbility
	{
		// Token: 0x06003394 RID: 13204 RVA: 0x00134168 File Offset: 0x00132368
		// Note: this type is marked as 'beforefieldinit'.
		static KwisatzHaderachAbility()
		{
			Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "KwisatzHaderachAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr);
			KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "AbilityName");
			KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "AbilityID");
			KwisatzHaderachAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679422);
			KwisatzHaderachAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679423);
			KwisatzHaderachAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679424);
			KwisatzHaderachAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679425);
			KwisatzHaderachAbility.NativeMethodInfoPtr_GetAgentTargets_Public_Static_IEnumerable_1_WormAgent_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679426);
			KwisatzHaderachAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679427);
			KwisatzHaderachAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679428);
			KwisatzHaderachAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679429);
			KwisatzHaderachAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679430);
			KwisatzHaderachAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679432);
			KwisatzHaderachAbility.NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, 100679433);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x0013429C File Offset: 0x0013249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235813, XrefRangeEnd = 235817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x001342E8 File Offset: 0x001324E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235817, XrefRangeEnd = 235833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KwisatzHaderachAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00134334 File Offset: 0x00132534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235833, XrefRangeEnd = 235837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KwisatzHaderachAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x001343A4 File Offset: 0x001325A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235837, XrefRangeEnd = 235841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00134414 File Offset: 0x00132614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235871, RefRangeEnd = 235872, XrefRangeStart = 235841, XrefRangeEnd = 235871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<WormAgent> GetAgentTargets(WormMatch wormMatch, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.NativeMethodInfoPtr_GetAgentTargets_Public_Static_IEnumerable_1_WormAgent_WormMatch_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0013446C File Offset: 0x0013266C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235872, XrefRangeEnd = 235880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x001344DC File Offset: 0x001326DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235880, XrefRangeEnd = 235889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x0013455C File Offset: 0x0013275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235889, XrefRangeEnd = 235936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x001345D8 File Offset: 0x001327D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235936, XrefRangeEnd = 236056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00134634 File Offset: 0x00132834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236056, XrefRangeEnd = 236057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TargetInformation> __n__0(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00134698 File Offset: 0x00132898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> __n__1(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00011C7B File Offset: 0x0000FE7B
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00011C8A File Offset: 0x0000FE8A
		public KwisatzHaderachAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x0013470C File Offset: 0x0013290C
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x00011C93 File Offset: 0x0000FE93
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x0013472C File Offset: 0x0013292C
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x00011CA5 File Offset: 0x0000FEA5
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KwisatzHaderachAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_GetAgentTargets_Public_Static_IEnumerable_1_WormAgent_WormMatch_WormPlayer_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000B0D RID: 2829
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600B2C9 RID: 45769 RVA: 0x002CF378 File Offset: 0x002CD578
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr);
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, "player");
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, "owner");
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679434);
				KwisatzHaderachAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679435);
			}

			// Token: 0x0600B2CA RID: 45770 RVA: 0x002CF41C File Offset: 0x002CD61C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2CB RID: 45771 RVA: 0x002CF458 File Offset: 0x002CD658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235492, XrefRangeEnd = 235496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2CC RID: 45772 RVA: 0x00052313 File Offset: 0x00050513
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036C7 RID: 14023
			// (get) Token: 0x0600B2CD RID: 45773 RVA: 0x002CF4A8 File Offset: 0x002CD6A8
			// (set) Token: 0x0600B2CE RID: 45774 RVA: 0x0005231C File Offset: 0x0005051C
			public unsafe KwisatzHaderachAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C8 RID: 14024
			// (get) Token: 0x0600B2CF RID: 45775 RVA: 0x002CF4D8 File Offset: 0x002CD6D8
			// (set) Token: 0x0600B2D0 RID: 45776 RVA: 0x0005233B File Offset: 0x0005053B
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C9 RID: 14025
			// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x002CF508 File Offset: 0x002CD708
			// (set) Token: 0x0600B2D2 RID: 45778 RVA: 0x0005235A File Offset: 0x0005055A
			public unsafe WormImperiumPlayable owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CA RID: 14026
			// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x002CF538 File Offset: 0x002CD738
			// (set) Token: 0x0600B2D4 RID: 45780 RVA: 0x00052379 File Offset: 0x00050579
			public unsafe Func<WormAbilityDefinition, AIValueSummer<double>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070B5 RID: 28853
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040070B6 RID: 28854
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070B7 RID: 28855
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040070B8 RID: 28856
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040070B9 RID: 28857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070BA RID: 28858
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000B0E RID: 2830
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<>c__DisplayClass10_1")]
		public sealed class __c__DisplayClass10_1 : Object
		{
			// Token: 0x0600B2D5 RID: 45781 RVA: 0x002CF568 File Offset: 0x002CD768
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_1()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<>c__DisplayClass10_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr);
				KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr, "space");
				KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_field_Public___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr, "CS$<>8__locals1");
				KwisatzHaderachAbility.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr, 100679436);
				KwisatzHaderachAbility.__c__DisplayClass10_1.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr, 100679437);
			}

			// Token: 0x0600B2D6 RID: 45782 RVA: 0x002CF5E4 File Offset: 0x002CD7E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass10_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2D7 RID: 45783 RVA: 0x002CF620 File Offset: 0x002CD820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(SpaceAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B2D8 RID: 45784 RVA: 0x00052398 File Offset: 0x00050598
			public __c__DisplayClass10_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036CB RID: 14027
			// (get) Token: 0x0600B2D9 RID: 45785 RVA: 0x002CF670 File Offset: 0x002CD870
			// (set) Token: 0x0600B2DA RID: 45786 RVA: 0x000523A1 File Offset: 0x000505A1
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CC RID: 14028
			// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x002CF6A0 File Offset: 0x002CD8A0
			// (set) Token: 0x0600B2DC RID: 45788 RVA: 0x000523C0 File Offset: 0x000505C0
			public unsafe KwisatzHaderachAbility.__c__DisplayClass10_0 field_Public___c__DisplayClass10_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_field_Public___c__DisplayClass10_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility.__c__DisplayClass10_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass10_1.NativeFieldInfoPtr_field_Public___c__DisplayClass10_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070BB RID: 28859
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x040070BC RID: 28860
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass10_0_0;

			// Token: 0x040070BD RID: 28861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070BE RID: 28862
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_SpaceAbility_0;
		}

		// Token: 0x02000B0F RID: 2831
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600B2DD RID: 45789 RVA: 0x002CF6D0 File Offset: 0x002CD8D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr);
				KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr, "player");
				KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_isSwordmaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr, "isSwordmaster");
				KwisatzHaderachAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679438);
				KwisatzHaderachAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetAgentTargets_b__0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679439);
			}

			// Token: 0x0600B2DE RID: 45790 RVA: 0x002CF74C File Offset: 0x002CD94C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2DF RID: 45791 RVA: 0x002CF788 File Offset: 0x002CD988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235496, XrefRangeEnd = 235497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAgentTargets_b__0(WormAgent agent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetAgentTargets_b__0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B2E0 RID: 45792 RVA: 0x000523DF File Offset: 0x000505DF
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036CD RID: 14029
			// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x002CF7D8 File Offset: 0x002CD9D8
			// (set) Token: 0x0600B2E2 RID: 45794 RVA: 0x000523E8 File Offset: 0x000505E8
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036CE RID: 14030
			// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x002CF808 File Offset: 0x002CDA08
			// (set) Token: 0x0600B2E4 RID: 45796 RVA: 0x00052407 File Offset: 0x00050607
			public unsafe bool isSwordmaster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_isSwordmaster);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_isSwordmaster)) = value;
				}
			}

			// Token: 0x040070BF RID: 28863
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070C0 RID: 28864
			private static readonly IntPtr NativeFieldInfoPtr_isSwordmaster;

			// Token: 0x040070C1 RID: 28865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070C2 RID: 28866
			private static readonly IntPtr NativeMethodInfoPtr__GetAgentTargets_b__0_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000B10 RID: 2832
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600B2E5 RID: 45797 RVA: 0x002CF830 File Offset: 0x002CDA30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr);
				KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr, "match");
				KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				KwisatzHaderachAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679440);
				KwisatzHaderachAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_IEnumerable_1_WormAgent_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679441);
			}

			// Token: 0x0600B2E6 RID: 45798 RVA: 0x002CF8AC File Offset: 0x002CDAAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2E7 RID: 45799 RVA: 0x002CF8E8 File Offset: 0x002CDAE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235497, XrefRangeEnd = 235508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAgent> _RunImmediateEffects_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_IEnumerable_1_WormAgent_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2E8 RID: 45800 RVA: 0x00052422 File Offset: 0x00050622
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036CF RID: 14031
			// (get) Token: 0x0600B2E9 RID: 45801 RVA: 0x002CF938 File Offset: 0x002CDB38
			// (set) Token: 0x0600B2EA RID: 45802 RVA: 0x0005242B File Offset: 0x0005062B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D0 RID: 14032
			// (get) Token: 0x0600B2EB RID: 45803 RVA: 0x002CF968 File Offset: 0x002CDB68
			// (set) Token: 0x0600B2EC RID: 45804 RVA: 0x0005244A File Offset: 0x0005064A
			public unsafe Func<EntityID, IEnumerable<WormAgent>> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityID, IEnumerable<WormAgent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070C3 RID: 28867
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040070C4 RID: 28868
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040070C5 RID: 28869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070C6 RID: 28870
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_IEnumerable_1_WormAgent_EntityID_0;
		}

		// Token: 0x02000B11 RID: 2833
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600B2ED RID: 45805 RVA: 0x002CF998 File Offset: 0x002CDB98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr);
				KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr, "player");
				KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr, 100679442);
				KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr, 100679443);
				KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr, 100679444);
			}

			// Token: 0x0600B2EE RID: 45806 RVA: 0x002CFA28 File Offset: 0x002CDC28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2EF RID: 45807 RVA: 0x002CFA64 File Offset: 0x002CDC64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235508, XrefRangeEnd = 235516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B2F0 RID: 45808 RVA: 0x002CFAB4 File Offset: 0x002CDCB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235516, XrefRangeEnd = 235518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormSpace> _ValueForPlayer_b__1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2F1 RID: 45809 RVA: 0x00052469 File Offset: 0x00050669
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036D1 RID: 14033
			// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x002CFB04 File Offset: 0x002CDD04
			// (set) Token: 0x0600B2F3 RID: 45811 RVA: 0x00052472 File Offset: 0x00050672
			public unsafe KwisatzHaderachAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D2 RID: 14034
			// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x002CFB34 File Offset: 0x002CDD34
			// (set) Token: 0x0600B2F5 RID: 45813 RVA: 0x00052491 File Offset: 0x00050691
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070C7 RID: 28871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040070C8 RID: 28872
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070C9 RID: 28873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070CA RID: 28874
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x040070CB RID: 28875
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__1_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0;
		}

		// Token: 0x02000B12 RID: 2834
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<RunImmediateEffects>d__8")]
		public sealed class _RunImmediateEffects_d__8 : Object
		{
			// Token: 0x0600B2F6 RID: 45814 RVA: 0x002CFB64 File Offset: 0x002CDD64
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__8()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<RunImmediateEffects>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>1__state");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>2__current");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>l__initialThreadId");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "match");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__match");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>4__this");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "activeAbility");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__activeAbility");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "context");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__context");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>8__1");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__space_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<space>5__2");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>7__wrap2");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__chosenAgent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<chosenAgent>5__4");
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679445);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679446);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679447);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679448);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679449);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679450);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679451);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679452);
				KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679453);
			}

			// Token: 0x0600B2F7 RID: 45815 RVA: 0x002CFD5C File Offset: 0x002CDF5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility._RunImmediateEffects_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B2F8 RID: 45816 RVA: 0x002CFDA4 File Offset: 0x002CDFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235518, XrefRangeEnd = 235523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2F9 RID: 45817 RVA: 0x002CFDD8 File Offset: 0x002CDFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235523, XrefRangeEnd = 235689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B2FA RID: 45818 RVA: 0x002CFE14 File Offset: 0x002CE014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235689, XrefRangeEnd = 235692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036E1 RID: 14049
			// (get) Token: 0x0600B2FB RID: 45819 RVA: 0x002CFE48 File Offset: 0x002CE048
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2FC RID: 45820 RVA: 0x002CFE88 File Offset: 0x002CE088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235692, XrefRangeEnd = 235697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036E2 RID: 14050
			// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x002CFEBC File Offset: 0x002CE0BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2FE RID: 45822 RVA: 0x002CFEFC File Offset: 0x002CE0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235697, XrefRangeEnd = 235708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B2FF RID: 45823 RVA: 0x002CFF3C File Offset: 0x002CE13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B300 RID: 45824 RVA: 0x000524B0 File Offset: 0x000506B0
			public _RunImmediateEffects_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036D3 RID: 14035
			// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002CFF7C File Offset: 0x002CE17C
			// (set) Token: 0x0600B302 RID: 45826 RVA: 0x000524B9 File Offset: 0x000506B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036D4 RID: 14036
			// (get) Token: 0x0600B303 RID: 45827 RVA: 0x002CFFA4 File Offset: 0x002CE1A4
			// (set) Token: 0x0600B304 RID: 45828 RVA: 0x000524D4 File Offset: 0x000506D4
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D5 RID: 14037
			// (get) Token: 0x0600B305 RID: 45829 RVA: 0x002CFFD4 File Offset: 0x002CE1D4
			// (set) Token: 0x0600B306 RID: 45830 RVA: 0x000524F3 File Offset: 0x000506F3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170036D6 RID: 14038
			// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002CFFFC File Offset: 0x002CE1FC
			// (set) Token: 0x0600B308 RID: 45832 RVA: 0x0005250E File Offset: 0x0005070E
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D7 RID: 14039
			// (get) Token: 0x0600B309 RID: 45833 RVA: 0x002D002C File Offset: 0x002CE22C
			// (set) Token: 0x0600B30A RID: 45834 RVA: 0x0005252D File Offset: 0x0005072D
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D8 RID: 14040
			// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002D005C File Offset: 0x002CE25C
			// (set) Token: 0x0600B30C RID: 45836 RVA: 0x0005254C File Offset: 0x0005074C
			public unsafe KwisatzHaderachAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036D9 RID: 14041
			// (get) Token: 0x0600B30D RID: 45837 RVA: 0x002D008C File Offset: 0x002CE28C
			// (set) Token: 0x0600B30E RID: 45838 RVA: 0x0005256B File Offset: 0x0005076B
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DA RID: 14042
			// (get) Token: 0x0600B30F RID: 45839 RVA: 0x002D00BC File Offset: 0x002CE2BC
			// (set) Token: 0x0600B310 RID: 45840 RVA: 0x0005258A File Offset: 0x0005078A
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DB RID: 14043
			// (get) Token: 0x0600B311 RID: 45841 RVA: 0x002D00EC File Offset: 0x002CE2EC
			// (set) Token: 0x0600B312 RID: 45842 RVA: 0x000525A9 File Offset: 0x000507A9
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DC RID: 14044
			// (get) Token: 0x0600B313 RID: 45843 RVA: 0x002D011C File Offset: 0x002CE31C
			// (set) Token: 0x0600B314 RID: 45844 RVA: 0x000525C8 File Offset: 0x000507C8
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DD RID: 14045
			// (get) Token: 0x0600B315 RID: 45845 RVA: 0x002D014C File Offset: 0x002CE34C
			// (set) Token: 0x0600B316 RID: 45846 RVA: 0x000525E7 File Offset: 0x000507E7
			public unsafe KwisatzHaderachAbility.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DE RID: 14046
			// (get) Token: 0x0600B317 RID: 45847 RVA: 0x002D017C File Offset: 0x002CE37C
			// (set) Token: 0x0600B318 RID: 45848 RVA: 0x00052606 File Offset: 0x00050806
			public unsafe Entity _space_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__space_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__space_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036DF RID: 14047
			// (get) Token: 0x0600B319 RID: 45849 RVA: 0x002D01AC File Offset: 0x002CE3AC
			// (set) Token: 0x0600B31A RID: 45850 RVA: 0x00052625 File Offset: 0x00050825
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E0 RID: 14048
			// (get) Token: 0x0600B31B RID: 45851 RVA: 0x002D01DC File Offset: 0x002CE3DC
			// (set) Token: 0x0600B31C RID: 45852 RVA: 0x00052644 File Offset: 0x00050844
			public unsafe WormAgent _chosenAgent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__chosenAgent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__chosenAgent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070CC RID: 28876
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040070CD RID: 28877
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040070CE RID: 28878
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040070CF RID: 28879
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040070D0 RID: 28880
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040070D1 RID: 28881
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040070D2 RID: 28882
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040070D3 RID: 28883
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040070D4 RID: 28884
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040070D5 RID: 28885
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040070D6 RID: 28886
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040070D7 RID: 28887
			private static readonly IntPtr NativeFieldInfoPtr__space_5__2;

			// Token: 0x040070D8 RID: 28888
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040070D9 RID: 28889
			private static readonly IntPtr NativeFieldInfoPtr__chosenAgent_5__4;

			// Token: 0x040070DA RID: 28890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040070DB RID: 28891
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070DC RID: 28892
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040070DD RID: 28893
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040070DE RID: 28894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040070DF RID: 28895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070E0 RID: 28896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040070E1 RID: 28897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040070E2 RID: 28898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.KwisatzHaderachAbility+<Targets>d__7")]
		public sealed class _Targets_d__7 : Object
		{
			// Token: 0x0600B31D RID: 45853 RVA: 0x002D020C File Offset: 0x002CE40C
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__7()
			{
				Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAbility>.NativeClassPtr, "<Targets>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr);
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>1__state");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>2__current");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>l__initialThreadId");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>4__this");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "match");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>3__match");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "context");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>3__context");
				KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, "<>7__wrap1");
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679454);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679455);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679456);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679457);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679458);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679459);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679460);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679461);
				KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr, 100679462);
			}

			// Token: 0x0600B31E RID: 45854 RVA: 0x002D03A0 File Offset: 0x002CE5A0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAbility._Targets_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B31F RID: 45855 RVA: 0x002D03E8 File Offset: 0x002CE5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235708, XrefRangeEnd = 235713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B320 RID: 45856 RVA: 0x002D041C File Offset: 0x002CE61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235713, XrefRangeEnd = 235795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B321 RID: 45857 RVA: 0x002D0458 File Offset: 0x002CE658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235795, XrefRangeEnd = 235798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036EC RID: 14060
			// (get) Token: 0x0600B322 RID: 45858 RVA: 0x002D048C File Offset: 0x002CE68C
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600B323 RID: 45859 RVA: 0x002D04CC File Offset: 0x002CE6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235798, XrefRangeEnd = 235803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036ED RID: 14061
			// (get) Token: 0x0600B324 RID: 45860 RVA: 0x002D0500 File Offset: 0x002CE700
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B325 RID: 45861 RVA: 0x002D0540 File Offset: 0x002CE740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235803, XrefRangeEnd = 235813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600B326 RID: 45862 RVA: 0x002D0580 File Offset: 0x002CE780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B327 RID: 45863 RVA: 0x00052663 File Offset: 0x00050863
			public _Targets_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036E3 RID: 14051
			// (get) Token: 0x0600B328 RID: 45864 RVA: 0x002D05C0 File Offset: 0x002CE7C0
			// (set) Token: 0x0600B329 RID: 45865 RVA: 0x0005266C File Offset: 0x0005086C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036E4 RID: 14052
			// (get) Token: 0x0600B32A RID: 45866 RVA: 0x002D05E8 File Offset: 0x002CE7E8
			// (set) Token: 0x0600B32B RID: 45867 RVA: 0x00052687 File Offset: 0x00050887
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E5 RID: 14053
			// (get) Token: 0x0600B32C RID: 45868 RVA: 0x002D0618 File Offset: 0x002CE818
			// (set) Token: 0x0600B32D RID: 45869 RVA: 0x000526A6 File Offset: 0x000508A6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170036E6 RID: 14054
			// (get) Token: 0x0600B32E RID: 45870 RVA: 0x002D0640 File Offset: 0x002CE840
			// (set) Token: 0x0600B32F RID: 45871 RVA: 0x000526C1 File Offset: 0x000508C1
			public unsafe KwisatzHaderachAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KwisatzHaderachAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E7 RID: 14055
			// (get) Token: 0x0600B330 RID: 45872 RVA: 0x002D0670 File Offset: 0x002CE870
			// (set) Token: 0x0600B331 RID: 45873 RVA: 0x000526E0 File Offset: 0x000508E0
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E8 RID: 14056
			// (get) Token: 0x0600B332 RID: 45874 RVA: 0x002D06A0 File Offset: 0x002CE8A0
			// (set) Token: 0x0600B333 RID: 45875 RVA: 0x000526FF File Offset: 0x000508FF
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E9 RID: 14057
			// (get) Token: 0x0600B334 RID: 45876 RVA: 0x002D06D0 File Offset: 0x002CE8D0
			// (set) Token: 0x0600B335 RID: 45877 RVA: 0x0005271E File Offset: 0x0005091E
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EA RID: 14058
			// (get) Token: 0x0600B336 RID: 45878 RVA: 0x002D0700 File Offset: 0x002CE900
			// (set) Token: 0x0600B337 RID: 45879 RVA: 0x0005273D File Offset: 0x0005093D
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EB RID: 14059
			// (get) Token: 0x0600B338 RID: 45880 RVA: 0x002D0730 File Offset: 0x002CE930
			// (set) Token: 0x0600B339 RID: 45881 RVA: 0x0005275C File Offset: 0x0005095C
			public unsafe IEnumerator<TargetInformation> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAbility._Targets_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070E3 RID: 28899
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040070E4 RID: 28900
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040070E5 RID: 28901
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040070E6 RID: 28902
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040070E7 RID: 28903
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040070E8 RID: 28904
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040070E9 RID: 28905
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040070EA RID: 28906
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040070EB RID: 28907
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040070EC RID: 28908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040070ED RID: 28909
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070EE RID: 28910
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040070EF RID: 28911
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040070F0 RID: 28912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040070F1 RID: 28913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070F2 RID: 28914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040070F3 RID: 28915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040070F4 RID: 28916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
