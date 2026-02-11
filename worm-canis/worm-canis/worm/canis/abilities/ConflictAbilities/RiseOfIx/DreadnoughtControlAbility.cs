using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.attributes;
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
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ConflictAbilities.RiseOfIx
{
	// Token: 0x020003D1 RID: 977
	public class DreadnoughtControlAbility : ConflictAbility
	{
		// Token: 0x0600291C RID: 10524 RVA: 0x001008A8 File Offset: 0x000FEAA8
		// Note: this type is marked as 'beforefieldinit'.
		static DreadnoughtControlAbility()
		{
			Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.RiseOfIx", "DreadnoughtControlAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr);
			DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "AbilityName");
			DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "AbilityID");
			DreadnoughtControlAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675381);
			DreadnoughtControlAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675382);
			DreadnoughtControlAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675383);
			DreadnoughtControlAbility.NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675384);
			DreadnoughtControlAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675385);
			DreadnoughtControlAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675386);
			DreadnoughtControlAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675387);
			DreadnoughtControlAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675388);
			DreadnoughtControlAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675389);
			DreadnoughtControlAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, 100675390);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x001009C8 File Offset: 0x000FEBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201272, XrefRangeEnd = 201276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00100A14 File Offset: 0x000FEC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201276, XrefRangeEnd = 201289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DreadnoughtControlAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00100A60 File Offset: 0x000FEC60
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DreadnoughtControlAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00100AD0 File Offset: 0x000FECD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 201291, RefRangeEnd = 201295, XrefRangeStart = 201289, XrefRangeEnd = 201291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControllable(ObjectAttributes oa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00100B20 File Offset: 0x000FED20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201295, XrefRangeEnd = 201303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00100B90 File Offset: 0x000FED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201303, XrefRangeEnd = 201311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00100C00 File Offset: 0x000FEE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201311, XrefRangeEnd = 201320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00100C80 File Offset: 0x000FEE80
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00100CFC File Offset: 0x000FEEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201320, XrefRangeEnd = 201334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00100D78 File Offset: 0x000FEF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201334, XrefRangeEnd = 201504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtControlAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0000F597 File Offset: 0x0000D797
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0000F5A6 File Offset: 0x0000D7A6
		public DreadnoughtControlAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00100DD4 File Offset: 0x000FEFD4
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x0000F5AF File Offset: 0x0000D7AF
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x00100DF4 File Offset: 0x000FEFF4
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x0000F5C1 File Offset: 0x0000D7C1
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_IsControllable_Private_Boolean_ObjectAttributes_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000985 RID: 2437
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.RiseOfIx.DreadnoughtControlAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060093C3 RID: 37827 RVA: 0x00274C9C File Offset: 0x00272E9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr);
				DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, "<>9");
				DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__6_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, "<>9__6_4");
				DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, "<>9__8_1");
				DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, "<>9__11_0");
				DreadnoughtControlAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, 100675393);
				DreadnoughtControlAbility.__c.NativeMethodInfoPtr__Targets_b__6_4_Internal_EntityID_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, 100675394);
				DreadnoughtControlAbility.__c.NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, 100675395);
				DreadnoughtControlAbility.__c.NativeMethodInfoPtr__Evaluate_b__11_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr, 100675396);
			}

			// Token: 0x060093C4 RID: 37828 RVA: 0x00274D68 File Offset: 0x00272F68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093C5 RID: 37829 RVA: 0x00274DA4 File Offset: 0x00272FA4
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__6_4(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c.NativeMethodInfoPtr__Targets_b__6_4_Internal_EntityID_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060093C6 RID: 37830 RVA: 0x00274DF4 File Offset: 0x00272FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200760, XrefRangeEnd = 200769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c.NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093C7 RID: 37831 RVA: 0x00274E44 File Offset: 0x00273044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200769, XrefRangeEnd = 200770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__11_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c.NativeMethodInfoPtr__Evaluate_b__11_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093C8 RID: 37832 RVA: 0x00040446 File Offset: 0x0003E646
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B93 RID: 11155
			// (get) Token: 0x060093C9 RID: 37833 RVA: 0x00274E94 File Offset: 0x00273094
			// (set) Token: 0x060093CA RID: 37834 RVA: 0x0004044F File Offset: 0x0003E64F
			public unsafe static DreadnoughtControlAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B94 RID: 11156
			// (get) Token: 0x060093CB RID: 37835 RVA: 0x00274EBC File Offset: 0x002730BC
			// (set) Token: 0x060093CC RID: 37836 RVA: 0x00040461 File Offset: 0x0003E661
			public unsafe static Func<WormSpace, EntityID> __9__6_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__6_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__6_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B95 RID: 11157
			// (get) Token: 0x060093CD RID: 37837 RVA: 0x00274EE4 File Offset: 0x002730E4
			// (set) Token: 0x060093CE RID: 37838 RVA: 0x00040473 File Offset: 0x0003E673
			public unsafe static Func<Entity, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B96 RID: 11158
			// (get) Token: 0x060093CF RID: 37839 RVA: 0x00274F0C File Offset: 0x0027310C
			// (set) Token: 0x060093D0 RID: 37840 RVA: 0x00040485 File Offset: 0x0003E685
			public unsafe static Func<TargetInformation, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DreadnoughtControlAbility.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E2B RID: 24107
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005E2C RID: 24108
			private static readonly IntPtr NativeFieldInfoPtr___9__6_4;

			// Token: 0x04005E2D RID: 24109
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04005E2E RID: 24110
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04005E2F RID: 24111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E30 RID: 24112
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_4_Internal_EntityID_WormSpace_0;

			// Token: 0x04005E31 RID: 24113
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_1_Internal_Boolean_Entity_0;

			// Token: 0x04005E32 RID: 24114
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__11_0_Internal_Boolean_TargetInformation_0;
		}

		// Token: 0x02000986 RID: 2438
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.RiseOfIx.DreadnoughtControlAbility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060093D1 RID: 37841 RVA: 0x00274F34 File Offset: 0x00273134
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr);
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, "player");
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, 100675397);
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, 100675398);
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, 100675399);
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__2_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, 100675400);
				DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__3_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr, 100675401);
			}

			// Token: 0x060093D2 RID: 37842 RVA: 0x00274FEC File Offset: 0x002731EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D3 RID: 37843 RVA: 0x00275028 File Offset: 0x00273228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200770, XrefRangeEnd = 200774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__0(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093D4 RID: 37844 RVA: 0x00275078 File Offset: 0x00273278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200774, XrefRangeEnd = 200775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093D5 RID: 37845 RVA: 0x002750C8 File Offset: 0x002732C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__2(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__2_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093D6 RID: 37846 RVA: 0x00275118 File Offset: 0x00273318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200775, XrefRangeEnd = 200776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__3(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__Targets_b__3_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093D7 RID: 37847 RVA: 0x00040497 File Offset: 0x0003E697
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B97 RID: 11159
			// (get) Token: 0x060093D8 RID: 37848 RVA: 0x00275168 File Offset: 0x00273368
			// (set) Token: 0x060093D9 RID: 37849 RVA: 0x000404A0 File Offset: 0x0003E6A0
			public unsafe DreadnoughtControlAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B98 RID: 11160
			// (get) Token: 0x060093DA RID: 37850 RVA: 0x00275198 File Offset: 0x00273398
			// (set) Token: 0x060093DB RID: 37851 RVA: 0x000404BF File Offset: 0x0003E6BF
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E33 RID: 24115
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E34 RID: 24116
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005E35 RID: 24117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E36 RID: 24118
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormSpace_0;

			// Token: 0x04005E37 RID: 24119
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__1_Internal_Boolean_WormSpace_0;

			// Token: 0x04005E38 RID: 24120
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__2_Internal_Boolean_WormSpace_0;

			// Token: 0x04005E39 RID: 24121
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__3_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x02000987 RID: 2439
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.RiseOfIx.DreadnoughtControlAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060093DC RID: 37852 RVA: 0x002751C8 File Offset: 0x002733C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr);
				DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr, "player");
				DreadnoughtControlAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr, 100675402);
				DreadnoughtControlAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr, 100675403);
			}

			// Token: 0x060093DD RID: 37853 RVA: 0x00275244 File Offset: 0x00273444
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093DE RID: 37854 RVA: 0x00275280 File Offset: 0x00273480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200776, XrefRangeEnd = 200785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060093DF RID: 37855 RVA: 0x000404DE File Offset: 0x0003E6DE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B99 RID: 11161
			// (get) Token: 0x060093E0 RID: 37856 RVA: 0x002752D0 File Offset: 0x002734D0
			// (set) Token: 0x060093E1 RID: 37857 RVA: 0x000404E7 File Offset: 0x0003E6E7
			public unsafe DreadnoughtControlAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B9A RID: 11162
			// (get) Token: 0x060093E2 RID: 37858 RVA: 0x00275300 File Offset: 0x00273500
			// (set) Token: 0x060093E3 RID: 37859 RVA: 0x00040506 File Offset: 0x0003E706
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E3A RID: 24122
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E3B RID: 24123
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005E3C RID: 24124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E3D RID: 24125
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x02000988 RID: 2440
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.RiseOfIx.DreadnoughtControlAbility+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x060093E4 RID: 37860 RVA: 0x00275330 File Offset: 0x00273530
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>4__this");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "context");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>3__context");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "match");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<>8__1");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__dreadnought_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<dreadnought>5__2");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__chosenSpace_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<chosenSpace>5__3");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<sequenceHelper>5__4");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__entityID_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, "<entityID>5__5");
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675404);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675405);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675406);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675407);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675408);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675409);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675410);
				DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr, 100675411);
			}

			// Token: 0x060093E5 RID: 37861 RVA: 0x00275528 File Offset: 0x00273728
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060093E6 RID: 37862 RVA: 0x00275570 File Offset: 0x00273770
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E7 RID: 37863 RVA: 0x002755A4 File Offset: 0x002737A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200785, XrefRangeEnd = 201092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002BAA RID: 11178
			// (get) Token: 0x060093E8 RID: 37864 RVA: 0x002755E0 File Offset: 0x002737E0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060093E9 RID: 37865 RVA: 0x00275620 File Offset: 0x00273820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201092, XrefRangeEnd = 201097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BAB RID: 11179
			// (get) Token: 0x060093EA RID: 37866 RVA: 0x00275654 File Offset: 0x00273854
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060093EB RID: 37867 RVA: 0x00275694 File Offset: 0x00273894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201097, XrefRangeEnd = 201108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060093EC RID: 37868 RVA: 0x002756D4 File Offset: 0x002738D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060093ED RID: 37869 RVA: 0x00040525 File Offset: 0x0003E725
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B9B RID: 11163
			// (get) Token: 0x060093EE RID: 37870 RVA: 0x00275714 File Offset: 0x00273914
			// (set) Token: 0x060093EF RID: 37871 RVA: 0x0004052E File Offset: 0x0003E72E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B9C RID: 11164
			// (get) Token: 0x060093F0 RID: 37872 RVA: 0x0027573C File Offset: 0x0027393C
			// (set) Token: 0x060093F1 RID: 37873 RVA: 0x00040549 File Offset: 0x0003E749
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B9D RID: 11165
			// (get) Token: 0x060093F2 RID: 37874 RVA: 0x0027576C File Offset: 0x0027396C
			// (set) Token: 0x060093F3 RID: 37875 RVA: 0x00040568 File Offset: 0x0003E768
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B9E RID: 11166
			// (get) Token: 0x060093F4 RID: 37876 RVA: 0x00275794 File Offset: 0x00273994
			// (set) Token: 0x060093F5 RID: 37877 RVA: 0x00040583 File Offset: 0x0003E783
			public unsafe DreadnoughtControlAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B9F RID: 11167
			// (get) Token: 0x060093F6 RID: 37878 RVA: 0x002757C4 File Offset: 0x002739C4
			// (set) Token: 0x060093F7 RID: 37879 RVA: 0x000405A2 File Offset: 0x0003E7A2
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA0 RID: 11168
			// (get) Token: 0x060093F8 RID: 37880 RVA: 0x002757F4 File Offset: 0x002739F4
			// (set) Token: 0x060093F9 RID: 37881 RVA: 0x000405C1 File Offset: 0x0003E7C1
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA1 RID: 11169
			// (get) Token: 0x060093FA RID: 37882 RVA: 0x00275824 File Offset: 0x00273A24
			// (set) Token: 0x060093FB RID: 37883 RVA: 0x000405E0 File Offset: 0x0003E7E0
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA2 RID: 11170
			// (get) Token: 0x060093FC RID: 37884 RVA: 0x00275854 File Offset: 0x00273A54
			// (set) Token: 0x060093FD RID: 37885 RVA: 0x000405FF File Offset: 0x0003E7FF
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA3 RID: 11171
			// (get) Token: 0x060093FE RID: 37886 RVA: 0x00275884 File Offset: 0x00273A84
			// (set) Token: 0x060093FF RID: 37887 RVA: 0x0004061E File Offset: 0x0003E81E
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA4 RID: 11172
			// (get) Token: 0x06009400 RID: 37888 RVA: 0x002758B4 File Offset: 0x00273AB4
			// (set) Token: 0x06009401 RID: 37889 RVA: 0x0004063D File Offset: 0x0003E83D
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA5 RID: 11173
			// (get) Token: 0x06009402 RID: 37890 RVA: 0x002758E4 File Offset: 0x00273AE4
			// (set) Token: 0x06009403 RID: 37891 RVA: 0x0004065C File Offset: 0x0003E85C
			public unsafe DreadnoughtControlAbility.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA6 RID: 11174
			// (get) Token: 0x06009404 RID: 37892 RVA: 0x00275914 File Offset: 0x00273B14
			// (set) Token: 0x06009405 RID: 37893 RVA: 0x0004067B File Offset: 0x0003E87B
			public unsafe WormDreadnought _dreadnought_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__dreadnought_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDreadnought>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__dreadnought_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA7 RID: 11175
			// (get) Token: 0x06009406 RID: 37894 RVA: 0x00275944 File Offset: 0x00273B44
			// (set) Token: 0x06009407 RID: 37895 RVA: 0x0004069A File Offset: 0x0003E89A
			public unsafe WormSpace _chosenSpace_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__chosenSpace_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__chosenSpace_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA8 RID: 11176
			// (get) Token: 0x06009408 RID: 37896 RVA: 0x00275974 File Offset: 0x00273B74
			// (set) Token: 0x06009409 RID: 37897 RVA: 0x000406B9 File Offset: 0x0003E8B9
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA9 RID: 11177
			// (get) Token: 0x0600940A RID: 37898 RVA: 0x002759A4 File Offset: 0x00273BA4
			// (set) Token: 0x0600940B RID: 37899 RVA: 0x000406D8 File Offset: 0x0003E8D8
			public unsafe EntityID _entityID_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__entityID_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._BeginExecution_d__8.NativeFieldInfoPtr__entityID_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E3E RID: 24126
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005E3F RID: 24127
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005E40 RID: 24128
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005E41 RID: 24129
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E42 RID: 24130
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005E43 RID: 24131
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005E44 RID: 24132
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005E45 RID: 24133
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005E46 RID: 24134
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005E47 RID: 24135
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005E48 RID: 24136
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005E49 RID: 24137
			private static readonly IntPtr NativeFieldInfoPtr__dreadnought_5__2;

			// Token: 0x04005E4A RID: 24138
			private static readonly IntPtr NativeFieldInfoPtr__chosenSpace_5__3;

			// Token: 0x04005E4B RID: 24139
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x04005E4C RID: 24140
			private static readonly IntPtr NativeFieldInfoPtr__entityID_5__5;

			// Token: 0x04005E4D RID: 24141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005E4E RID: 24142
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E4F RID: 24143
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005E50 RID: 24144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005E51 RID: 24145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E52 RID: 24146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005E53 RID: 24147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005E54 RID: 24148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000989 RID: 2441
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.RiseOfIx.DreadnoughtControlAbility+<Targets>d__6")]
		public sealed class _Targets_d__6 : Object
		{
			// Token: 0x0600940C RID: 37900 RVA: 0x002759D4 File Offset: 0x00273BD4
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DreadnoughtControlAbility>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr);
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>1__state");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>2__current");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>4__this");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "context");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>3__context");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "match");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>3__match");
				DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, "<>8__1");
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675412);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675413);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675414);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675415);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675416);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675417);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675418);
				DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr, 100675419);
			}

			// Token: 0x0600940D RID: 37901 RVA: 0x00275B54 File Offset: 0x00273D54
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtControlAbility._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600940E RID: 37902 RVA: 0x00275B9C File Offset: 0x00273D9C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600940F RID: 37903 RVA: 0x00275BD0 File Offset: 0x00273DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201108, XrefRangeEnd = 201257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002BB5 RID: 11189
			// (get) Token: 0x06009410 RID: 37904 RVA: 0x00275C0C File Offset: 0x00273E0C
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06009411 RID: 37905 RVA: 0x00275C4C File Offset: 0x00273E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201257, XrefRangeEnd = 201262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BB6 RID: 11190
			// (get) Token: 0x06009412 RID: 37906 RVA: 0x00275C80 File Offset: 0x00273E80
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009413 RID: 37907 RVA: 0x00275CC0 File Offset: 0x00273EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201262, XrefRangeEnd = 201272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x06009414 RID: 37908 RVA: 0x00275D00 File Offset: 0x00273F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtControlAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009415 RID: 37909 RVA: 0x000406F7 File Offset: 0x0003E8F7
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002BAC RID: 11180
			// (get) Token: 0x06009416 RID: 37910 RVA: 0x00275D40 File Offset: 0x00273F40
			// (set) Token: 0x06009417 RID: 37911 RVA: 0x00040700 File Offset: 0x0003E900
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002BAD RID: 11181
			// (get) Token: 0x06009418 RID: 37912 RVA: 0x00275D68 File Offset: 0x00273F68
			// (set) Token: 0x06009419 RID: 37913 RVA: 0x0004071B File Offset: 0x0003E91B
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BAE RID: 11182
			// (get) Token: 0x0600941A RID: 37914 RVA: 0x00275D98 File Offset: 0x00273F98
			// (set) Token: 0x0600941B RID: 37915 RVA: 0x0004073A File Offset: 0x0003E93A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002BAF RID: 11183
			// (get) Token: 0x0600941C RID: 37916 RVA: 0x00275DC0 File Offset: 0x00273FC0
			// (set) Token: 0x0600941D RID: 37917 RVA: 0x00040755 File Offset: 0x0003E955
			public unsafe DreadnoughtControlAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB0 RID: 11184
			// (get) Token: 0x0600941E RID: 37918 RVA: 0x00275DF0 File Offset: 0x00273FF0
			// (set) Token: 0x0600941F RID: 37919 RVA: 0x00040774 File Offset: 0x0003E974
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB1 RID: 11185
			// (get) Token: 0x06009420 RID: 37920 RVA: 0x00275E20 File Offset: 0x00274020
			// (set) Token: 0x06009421 RID: 37921 RVA: 0x00040793 File Offset: 0x0003E993
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB2 RID: 11186
			// (get) Token: 0x06009422 RID: 37922 RVA: 0x00275E50 File Offset: 0x00274050
			// (set) Token: 0x06009423 RID: 37923 RVA: 0x000407B2 File Offset: 0x0003E9B2
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB3 RID: 11187
			// (get) Token: 0x06009424 RID: 37924 RVA: 0x00275E80 File Offset: 0x00274080
			// (set) Token: 0x06009425 RID: 37925 RVA: 0x000407D1 File Offset: 0x0003E9D1
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB4 RID: 11188
			// (get) Token: 0x06009426 RID: 37926 RVA: 0x00275EB0 File Offset: 0x002740B0
			// (set) Token: 0x06009427 RID: 37927 RVA: 0x000407F0 File Offset: 0x0003E9F0
			public unsafe DreadnoughtControlAbility.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DreadnoughtControlAbility.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DreadnoughtControlAbility._Targets_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E55 RID: 24149
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005E56 RID: 24150
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005E57 RID: 24151
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005E58 RID: 24152
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E59 RID: 24153
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005E5A RID: 24154
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005E5B RID: 24155
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005E5C RID: 24156
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005E5D RID: 24157
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005E5E RID: 24158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005E5F RID: 24159
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E60 RID: 24160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005E61 RID: 24161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04005E62 RID: 24162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E63 RID: 24163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005E64 RID: 24164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04005E65 RID: 24165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
