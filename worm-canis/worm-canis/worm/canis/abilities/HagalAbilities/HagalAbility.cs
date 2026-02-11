using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.PlayAbilities;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.HagalAbilities
{
	// Token: 0x020003C0 RID: 960
	public class HagalAbility : PlayAbility
	{
		// Token: 0x0600285A RID: 10330 RVA: 0x000FD0C0 File Offset: 0x000FB2C0
		// Note: this type is marked as 'beforefieldinit'.
		static HagalAbility()
		{
			Il2CppClassPointerStore<HagalAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities", "HagalAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr);
			HagalAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "AbilityName");
			HagalAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "AbilityID");
			HagalAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675075);
			HagalAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675076);
			HagalAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675077);
			HagalAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675078);
			HagalAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675079);
			HagalAbility.NativeMethodInfoPtr_RevealAnotherCard_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675080);
			HagalAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675081);
			HagalAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_New_WormSpace_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675082);
			HagalAbility.NativeMethodInfoPtr_HagalCheckSpace_Public_Static_WormSpace_WormMatch_WormPlayer_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675083);
			HagalAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675084);
			HagalAbility.NativeMethodInfoPtr_MakeConvertSequence_Private_Static_SequenceHelper_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675085);
			HagalAbility.NativeMethodInfoPtr_HagalGainVP_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675086);
			HagalAbility.NativeMethodInfoPtr_UnexhaustedDependency_Protected_Virtual_IEnumerable_1_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675087);
			HagalAbility.NativeMethodInfoPtr_HagalInfluenceEvaluate_Public_Static_WormAIChoice_WormAIChoiceSelectionWithTargets_WormAbilityDefinition_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675088);
			HagalAbility.NativeMethodInfoPtr_HagalShouldDeployUnits_Public_Static_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675089);
			HagalAbility.NativeMethodInfoPtr_GetTechTileStackForTrash_Private_WormTechTileStack_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675090);
			HagalAbility.NativeMethodInfoPtr_HagalAcquireTech_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, 100675091);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000FD26C File Offset: 0x000FB46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199231, XrefRangeEnd = 199235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000FD2B8 File Offset: 0x000FB4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199235, XrefRangeEnd = 199236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalAbility(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000FD328 File Offset: 0x000FB528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199236, XrefRangeEnd = 199237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x000FD398 File Offset: 0x000FB598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199237, XrefRangeEnd = 199248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000FD408 File Offset: 0x000FB608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199248, XrefRangeEnd = 199257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000FD488 File Offset: 0x000FB688
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RevealAnotherCard(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_RevealAnotherCard_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000FD4F4 File Offset: 0x000FB6F4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000FD560 File Offset: 0x000FB760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199257, XrefRangeEnd = 199276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WormSpace GetSpace(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_New_WormSpace_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000FD5D0 File Offset: 0x000FB7D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 199294, RefRangeEnd = 199298, XrefRangeStart = 199276, XrefRangeEnd = 199294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormSpace HagalCheckSpace(WormMatch match, WormPlayer player, ArchetypeID spaceArchID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spaceArchID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_HagalCheckSpace_Public_Static_WormSpace_WormMatch_WormPlayer_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000FD638 File Offset: 0x000FB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199298, XrefRangeEnd = 199306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> GrantResources(WormMatch match, Context context, WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000FD6B8 File Offset: 0x000FB8B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 199331, RefRangeEnd = 199335, XrefRangeStart = 199306, XrefRangeEnd = 199331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SequenceHelper MakeConvertSequence(WormMatch match, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_MakeConvertSequence_Private_Static_SequenceHelper_WormMatch_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr3) : null;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000FD710 File Offset: 0x000FB910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199342, RefRangeEnd = 199343, XrefRangeStart = 199335, XrefRangeEnd = 199342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<global::Canis.actions.Action> HagalGainVP(WormMatch match, WormPlayer player, EntityID sourceEntityID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntityID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_HagalGainVP_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000FD778 File Offset: 0x000FB978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199343, XrefRangeEnd = 199356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> UnexhaustedDependency(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_UnexhaustedDependency_Protected_Virtual_IEnumerable_1_Entity_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000FD7D4 File Offset: 0x000FB9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199356, XrefRangeEnd = 199414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormAIChoice HagalInfluenceEvaluate(WormAIChoiceSelectionWithTargets choice, WormAbilityDefinition ability, EntityID sourceEntityID, int numTargets = 1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ability);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTargets;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_HagalInfluenceEvaluate_Public_Static_WormAIChoice_WormAIChoiceSelectionWithTargets_WormAbilityDefinition_EntityID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000FD84C File Offset: 0x000FBA4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199455, RefRangeEnd = 199457, XrefRangeStart = 199414, XrefRangeEnd = 199455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HagalShouldDeployUnits(WormMatch wormMatch, WormPlayer wormPlayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_HagalShouldDeployUnits_Public_Static_Boolean_WormMatch_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000FD8A0 File Offset: 0x000FBAA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199548, RefRangeEnd = 199550, XrefRangeStart = 199457, XrefRangeEnd = 199548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTileStack GetTechTileStackForTrash(WormMatch match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.NativeMethodInfoPtr_GetTechTileStackForTrash_Private_WormTechTileStack_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTechTileStack>(intPtr3) : null;
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199550, XrefRangeEnd = 199558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> HagalAcquireTech(WormMatch match, Context context, int discount = 0, bool negotiate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negotiate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalAbility.NativeMethodInfoPtr_HagalAcquireTech_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0000F2BE File Offset: 0x0000D4BE
		public HagalAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000FD97C File Offset: 0x000FBB7C
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0000F2C7 File Offset: 0x0000D4C7
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000FD99C File Offset: 0x000FBB9C
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0000F2D9 File Offset: 0x0000D4D9
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_RevealAnotherCard_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_GetSpace_Protected_Virtual_New_WormSpace_WormMatch_WormPlayer_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_HagalCheckSpace_Public_Static_WormSpace_WormMatch_WormPlayer_ArchetypeID_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_MakeConvertSequence_Private_Static_SequenceHelper_WormMatch_WormPlayer_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_HagalGainVP_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayer_EntityID_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_UnexhaustedDependency_Protected_Virtual_IEnumerable_1_Entity_WormPlayer_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_HagalInfluenceEvaluate_Public_Static_WormAIChoice_WormAIChoiceSelectionWithTargets_WormAbilityDefinition_EntityID_Int32_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_HagalShouldDeployUnits_Public_Static_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_GetTechTileStackForTrash_Private_WormTechTileStack_WormMatch_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_HagalAcquireTech_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_Context_Int32_Boolean_0;

		// Token: 0x0200096C RID: 2412
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009133 RID: 37171 RVA: 0x0026D538 File Offset: 0x0026B738
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr);
				HagalAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9");
				HagalAbility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__13_0");
				HagalAbility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__13_1");
				HagalAbility.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__13_2");
				HagalAbility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__13_3");
				HagalAbility.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__15_1");
				HagalAbility.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__16_0");
				HagalAbility.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__17_0");
				HagalAbility.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__17_1");
				HagalAbility.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__17_2");
				HagalAbility.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__17_3");
				HagalAbility.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__18_0");
				HagalAbility.__c.NativeFieldInfoPtr___9__18_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, "<>9__18_2");
				HagalAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675094);
				HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675095);
				HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675096);
				HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675097);
				HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675098);
				HagalAbility.__c.NativeMethodInfoPtr__HagalInfluenceEvaluate_b__15_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675099);
				HagalAbility.__c.NativeMethodInfoPtr__HagalShouldDeployUnits_b__16_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675100);
				HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_0_Internal_Boolean_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675101);
				HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_1_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675102);
				HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_2_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675103);
				HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_3_Internal_Int32_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675104);
				HagalAbility.__c.NativeMethodInfoPtr__HagalAcquireTech_b__18_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675105);
				HagalAbility.__c.NativeMethodInfoPtr__HagalAcquireTech_b__18_2_Internal_Int32_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr, 100675106);
			}

			// Token: 0x06009134 RID: 37172 RVA: 0x0026D76C File Offset: 0x0026B96C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009135 RID: 37173 RVA: 0x0026D7A8 File Offset: 0x0026B9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198306, XrefRangeEnd = 198311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalGainVP_b__13_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009136 RID: 37174 RVA: 0x0026D7F8 File Offset: 0x0026B9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198311, XrefRangeEnd = 198316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalGainVP_b__13_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009137 RID: 37175 RVA: 0x0026D848 File Offset: 0x0026BA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198316, XrefRangeEnd = 198321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalGainVP_b__13_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009138 RID: 37176 RVA: 0x0026D898 File Offset: 0x0026BA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198321, XrefRangeEnd = 198326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalGainVP_b__13_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalGainVP_b__13_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009139 RID: 37177 RVA: 0x0026D8E8 File Offset: 0x0026BAE8
			[CallerCount(0)]
			public unsafe EntityID _HagalInfluenceEvaluate_b__15_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalInfluenceEvaluate_b__15_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600913A RID: 37178 RVA: 0x0026D938 File Offset: 0x0026BB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198326, XrefRangeEnd = 198328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HagalShouldDeployUnits_b__16_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalShouldDeployUnits_b__16_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600913B RID: 37179 RVA: 0x0026D988 File Offset: 0x0026BB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198328, XrefRangeEnd = 198329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTechTileStackForTrash_b__17_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_0_Internal_Boolean_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600913C RID: 37180 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _GetTechTileStackForTrash_b__17_1(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_1_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600913D RID: 37181 RVA: 0x0026DA28 File Offset: 0x0026BC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198329, XrefRangeEnd = 198331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTechTileStackForTrash_b__17_2(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_2_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600913E RID: 37182 RVA: 0x0026DA78 File Offset: 0x0026BC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198331, XrefRangeEnd = 198333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTechTileStackForTrash_b__17_3(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_3_Internal_Int32_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600913F RID: 37183 RVA: 0x0026DAC8 File Offset: 0x0026BCC8
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _HagalAcquireTech_b__18_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalAcquireTech_b__18_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06009140 RID: 37184 RVA: 0x0026DB18 File Offset: 0x0026BD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HagalAcquireTech_b__18_2(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c.NativeMethodInfoPtr__HagalAcquireTech_b__18_2_Internal_Int32_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009141 RID: 37185 RVA: 0x0003EBE6 File Offset: 0x0003CDE6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002A9C RID: 10908
			// (get) Token: 0x06009142 RID: 37186 RVA: 0x0026DB68 File Offset: 0x0026BD68
			// (set) Token: 0x06009143 RID: 37187 RVA: 0x0003EBEF File Offset: 0x0003CDEF
			public unsafe static HagalAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A9D RID: 10909
			// (get) Token: 0x06009144 RID: 37188 RVA: 0x0026DB90 File Offset: 0x0026BD90
			// (set) Token: 0x06009145 RID: 37189 RVA: 0x0003EC01 File Offset: 0x0003CE01
			public unsafe static Func<Entity, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A9E RID: 10910
			// (get) Token: 0x06009146 RID: 37190 RVA: 0x0026DBB8 File Offset: 0x0026BDB8
			// (set) Token: 0x06009147 RID: 37191 RVA: 0x0003EC13 File Offset: 0x0003CE13
			public unsafe static Func<Entity, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A9F RID: 10911
			// (get) Token: 0x06009148 RID: 37192 RVA: 0x0026DBE0 File Offset: 0x0026BDE0
			// (set) Token: 0x06009149 RID: 37193 RVA: 0x0003EC25 File Offset: 0x0003CE25
			public unsafe static Func<Entity, bool> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA0 RID: 10912
			// (get) Token: 0x0600914A RID: 37194 RVA: 0x0026DC08 File Offset: 0x0026BE08
			// (set) Token: 0x0600914B RID: 37195 RVA: 0x0003EC37 File Offset: 0x0003CE37
			public unsafe static Func<Entity, bool> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA1 RID: 10913
			// (get) Token: 0x0600914C RID: 37196 RVA: 0x0026DC30 File Offset: 0x0026BE30
			// (set) Token: 0x0600914D RID: 37197 RVA: 0x0003EC49 File Offset: 0x0003CE49
			public unsafe static Func<Entity, EntityID> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA2 RID: 10914
			// (get) Token: 0x0600914E RID: 37198 RVA: 0x0026DC58 File Offset: 0x0026BE58
			// (set) Token: 0x0600914F RID: 37199 RVA: 0x0003EC5B File Offset: 0x0003CE5B
			public unsafe static Func<WormPlayer, int> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA3 RID: 10915
			// (get) Token: 0x06009150 RID: 37200 RVA: 0x0026DC80 File Offset: 0x0026BE80
			// (set) Token: 0x06009151 RID: 37201 RVA: 0x0003EC6D File Offset: 0x0003CE6D
			public unsafe static Func<WormTechTileStack, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA4 RID: 10916
			// (get) Token: 0x06009152 RID: 37202 RVA: 0x0026DCA8 File Offset: 0x0026BEA8
			// (set) Token: 0x06009153 RID: 37203 RVA: 0x0003EC7F File Offset: 0x0003CE7F
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA5 RID: 10917
			// (get) Token: 0x06009154 RID: 37204 RVA: 0x0026DCD0 File Offset: 0x0026BED0
			// (set) Token: 0x06009155 RID: 37205 RVA: 0x0003EC91 File Offset: 0x0003CE91
			public unsafe static Func<WormTechTilePlayable, bool> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA6 RID: 10918
			// (get) Token: 0x06009156 RID: 37206 RVA: 0x0026DCF8 File Offset: 0x0026BEF8
			// (set) Token: 0x06009157 RID: 37207 RVA: 0x0003ECA3 File Offset: 0x0003CEA3
			public unsafe static Func<WormTechTileStack, int> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA7 RID: 10919
			// (get) Token: 0x06009158 RID: 37208 RVA: 0x0026DD20 File Offset: 0x0026BF20
			// (set) Token: 0x06009159 RID: 37209 RVA: 0x0003ECB5 File Offset: 0x0003CEB5
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA8 RID: 10920
			// (get) Token: 0x0600915A RID: 37210 RVA: 0x0026DD48 File Offset: 0x0026BF48
			// (set) Token: 0x0600915B RID: 37211 RVA: 0x0003ECC7 File Offset: 0x0003CEC7
			public unsafe static Func<WormTechTilePlayable, int> __9__18_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalAbility.__c.NativeFieldInfoPtr___9__18_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalAbility.__c.NativeFieldInfoPtr___9__18_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C9C RID: 23708
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C9D RID: 23709
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04005C9E RID: 23710
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04005C9F RID: 23711
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04005CA0 RID: 23712
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04005CA1 RID: 23713
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04005CA2 RID: 23714
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04005CA3 RID: 23715
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04005CA4 RID: 23716
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04005CA5 RID: 23717
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04005CA6 RID: 23718
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04005CA7 RID: 23719
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04005CA8 RID: 23720
			private static readonly IntPtr NativeFieldInfoPtr___9__18_2;

			// Token: 0x04005CA9 RID: 23721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CAA RID: 23722
			private static readonly IntPtr NativeMethodInfoPtr__HagalGainVP_b__13_0_Internal_Boolean_Entity_0;

			// Token: 0x04005CAB RID: 23723
			private static readonly IntPtr NativeMethodInfoPtr__HagalGainVP_b__13_1_Internal_Boolean_Entity_0;

			// Token: 0x04005CAC RID: 23724
			private static readonly IntPtr NativeMethodInfoPtr__HagalGainVP_b__13_2_Internal_Boolean_Entity_0;

			// Token: 0x04005CAD RID: 23725
			private static readonly IntPtr NativeMethodInfoPtr__HagalGainVP_b__13_3_Internal_Boolean_Entity_0;

			// Token: 0x04005CAE RID: 23726
			private static readonly IntPtr NativeMethodInfoPtr__HagalInfluenceEvaluate_b__15_1_Internal_EntityID_Entity_0;

			// Token: 0x04005CAF RID: 23727
			private static readonly IntPtr NativeMethodInfoPtr__HagalShouldDeployUnits_b__16_0_Internal_Int32_WormPlayer_0;

			// Token: 0x04005CB0 RID: 23728
			private static readonly IntPtr NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_0_Internal_Boolean_WormTechTileStack_0;

			// Token: 0x04005CB1 RID: 23729
			private static readonly IntPtr NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_1_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x04005CB2 RID: 23730
			private static readonly IntPtr NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_2_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x04005CB3 RID: 23731
			private static readonly IntPtr NativeMethodInfoPtr__GetTechTileStackForTrash_b__17_3_Internal_Int32_WormTechTileStack_0;

			// Token: 0x04005CB4 RID: 23732
			private static readonly IntPtr NativeMethodInfoPtr__HagalAcquireTech_b__18_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x04005CB5 RID: 23733
			private static readonly IntPtr NativeMethodInfoPtr__HagalAcquireTech_b__18_2_Internal_Int32_WormTechTilePlayable_0;
		}

		// Token: 0x0200096D RID: 2413
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600915C RID: 37212 RVA: 0x0026DD70 File Offset: 0x0026BF70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr);
				HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_spaceArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, "spaceArchID");
				HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, "player");
				HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, 100675107);
				HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__HagalCheckSpace_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, 100675108);
				HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__HagalCheckSpace_b__1_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr, 100675109);
			}

			// Token: 0x0600915D RID: 37213 RVA: 0x0026DE14 File Offset: 0x0026C014
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600915E RID: 37214 RVA: 0x0026DE50 File Offset: 0x0026C050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198333, XrefRangeEnd = 198347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalCheckSpace_b__0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__HagalCheckSpace_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600915F RID: 37215 RVA: 0x0026DEA0 File Offset: 0x0026C0A0
			[CallerCount(0)]
			public unsafe bool _HagalCheckSpace_b__1(WormAgent agent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__HagalCheckSpace_b__1_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009160 RID: 37216 RVA: 0x0003ECD9 File Offset: 0x0003CED9
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002AA9 RID: 10921
			// (get) Token: 0x06009161 RID: 37217 RVA: 0x0026DEF0 File Offset: 0x0026C0F0
			// (set) Token: 0x06009162 RID: 37218 RVA: 0x0003ECE2 File Offset: 0x0003CEE2
			public unsafe ArchetypeID spaceArchID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_spaceArchID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_spaceArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AAA RID: 10922
			// (get) Token: 0x06009163 RID: 37219 RVA: 0x0026DF20 File Offset: 0x0026C120
			// (set) Token: 0x06009164 RID: 37220 RVA: 0x0003ED01 File Offset: 0x0003CF01
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AAB RID: 10923
			// (get) Token: 0x06009165 RID: 37221 RVA: 0x0026DF50 File Offset: 0x0026C150
			// (set) Token: 0x06009166 RID: 37222 RVA: 0x0003ED20 File Offset: 0x0003CF20
			public unsafe Func<WormAgent, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAgent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CB6 RID: 23734
			private static readonly IntPtr NativeFieldInfoPtr_spaceArchID;

			// Token: 0x04005CB7 RID: 23735
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005CB8 RID: 23736
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04005CB9 RID: 23737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CBA RID: 23738
			private static readonly IntPtr NativeMethodInfoPtr__HagalCheckSpace_b__0_Internal_Boolean_WormSpace_0;

			// Token: 0x04005CBB RID: 23739
			private static readonly IntPtr NativeMethodInfoPtr__HagalCheckSpace_b__1_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06009167 RID: 37223 RVA: 0x0026DF80 File Offset: 0x0026C180
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr);
				HagalAbility.__c__DisplayClass15_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr, "choice");
				HagalAbility.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr, 100675110);
				HagalAbility.__c__DisplayClass15_0.NativeMethodInfoPtr__HagalInfluenceEvaluate_b__0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr, 100675111);
			}

			// Token: 0x06009168 RID: 37224 RVA: 0x0026DFE8 File Offset: 0x0026C1E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009169 RID: 37225 RVA: 0x0026E024 File Offset: 0x0026C224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198347, XrefRangeEnd = 198351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HagalInfluenceEvaluate_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass15_0.NativeMethodInfoPtr__HagalInfluenceEvaluate_b__0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600916A RID: 37226 RVA: 0x0003ED3F File Offset: 0x0003CF3F
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002AAC RID: 10924
			// (get) Token: 0x0600916B RID: 37227 RVA: 0x0026E074 File Offset: 0x0026C274
			// (set) Token: 0x0600916C RID: 37228 RVA: 0x0003ED48 File Offset: 0x0003CF48
			public unsafe WormAIChoiceSelectionWithTargets choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass15_0.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceSelectionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass15_0.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CBC RID: 23740
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04005CBD RID: 23741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CBE RID: 23742
			private static readonly IntPtr NativeMethodInfoPtr__HagalInfluenceEvaluate_b__0_Internal_Int32_Entity_0;
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600916D RID: 37229 RVA: 0x0026E0A4 File Offset: 0x0026C2A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr);
				HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr, "player");
				HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_discount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr, "discount");
				HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_negotiatorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr, "negotiatorCount");
				HagalAbility.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr, 100675112);
				HagalAbility.__c__DisplayClass18_0.NativeMethodInfoPtr__HagalAcquireTech_b__1_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr, 100675113);
			}

			// Token: 0x0600916E RID: 37230 RVA: 0x0026E134 File Offset: 0x0026C334
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600916F RID: 37231 RVA: 0x0026E170 File Offset: 0x0026C370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198351, XrefRangeEnd = 198358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalAcquireTech_b__1(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility.__c__DisplayClass18_0.NativeMethodInfoPtr__HagalAcquireTech_b__1_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009170 RID: 37232 RVA: 0x0003ED67 File Offset: 0x0003CF67
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002AAD RID: 10925
			// (get) Token: 0x06009171 RID: 37233 RVA: 0x0026E1C0 File Offset: 0x0026C3C0
			// (set) Token: 0x06009172 RID: 37234 RVA: 0x0003ED70 File Offset: 0x0003CF70
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AAE RID: 10926
			// (get) Token: 0x06009173 RID: 37235 RVA: 0x0026E1F0 File Offset: 0x0026C3F0
			// (set) Token: 0x06009174 RID: 37236 RVA: 0x0003ED8F File Offset: 0x0003CF8F
			public unsafe int discount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_discount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_discount)) = value;
				}
			}

			// Token: 0x17002AAF RID: 10927
			// (get) Token: 0x06009175 RID: 37237 RVA: 0x0026E218 File Offset: 0x0026C418
			// (set) Token: 0x06009176 RID: 37238 RVA: 0x0003EDAA File Offset: 0x0003CFAA
			public unsafe int negotiatorCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_negotiatorCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility.__c__DisplayClass18_0.NativeFieldInfoPtr_negotiatorCount)) = value;
				}
			}

			// Token: 0x04005CBF RID: 23743
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005CC0 RID: 23744
			private static readonly IntPtr NativeFieldInfoPtr_discount;

			// Token: 0x04005CC1 RID: 23745
			private static readonly IntPtr NativeFieldInfoPtr_negotiatorCount;

			// Token: 0x04005CC2 RID: 23746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CC3 RID: 23747
			private static readonly IntPtr NativeMethodInfoPtr__HagalAcquireTech_b__1_Internal_Boolean_WormTechTilePlayable_0;
		}

		// Token: 0x02000970 RID: 2416
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<GrantResources>d__11")]
		public sealed class _GrantResources_d__11 : Object
		{
			// Token: 0x06009177 RID: 37239 RVA: 0x0026E240 File Offset: 0x0026C440
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__11()
			{
				Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<GrantResources>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr);
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>1__state");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>2__current");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>l__initialThreadId");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "context");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>3__context");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>4__this");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "match");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>3__match");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<player>5__2");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__factionDictionary_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<factionDictionary>5__3");
				HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, "<>7__wrap3");
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675114);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675115);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675116);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675117);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675118);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675119);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675120);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675121);
				HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr, 100675122);
			}

			// Token: 0x06009178 RID: 37240 RVA: 0x0026E3FC File Offset: 0x0026C5FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility._GrantResources_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009179 RID: 37241 RVA: 0x0026E444 File Offset: 0x0026C644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198358, XrefRangeEnd = 198363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600917A RID: 37242 RVA: 0x0026E478 File Offset: 0x0026C678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198363, XrefRangeEnd = 198442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600917B RID: 37243 RVA: 0x0026E4B4 File Offset: 0x0026C6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198442, XrefRangeEnd = 198445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002ABB RID: 10939
			// (get) Token: 0x0600917C RID: 37244 RVA: 0x0026E4E8 File Offset: 0x0026C6E8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600917D RID: 37245 RVA: 0x0026E528 File Offset: 0x0026C728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198445, XrefRangeEnd = 198450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002ABC RID: 10940
			// (get) Token: 0x0600917E RID: 37246 RVA: 0x0026E55C File Offset: 0x0026C75C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600917F RID: 37247 RVA: 0x0026E59C File Offset: 0x0026C79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198450, XrefRangeEnd = 198460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009180 RID: 37248 RVA: 0x0026E5DC File Offset: 0x0026C7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._GrantResources_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009181 RID: 37249 RVA: 0x0003EDC5 File Offset: 0x0003CFC5
			public _GrantResources_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002AB0 RID: 10928
			// (get) Token: 0x06009182 RID: 37250 RVA: 0x0026E61C File Offset: 0x0026C81C
			// (set) Token: 0x06009183 RID: 37251 RVA: 0x0003EDCE File Offset: 0x0003CFCE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AB1 RID: 10929
			// (get) Token: 0x06009184 RID: 37252 RVA: 0x0026E644 File Offset: 0x0026C844
			// (set) Token: 0x06009185 RID: 37253 RVA: 0x0003EDE9 File Offset: 0x0003CFE9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB2 RID: 10930
			// (get) Token: 0x06009186 RID: 37254 RVA: 0x0026E674 File Offset: 0x0026C874
			// (set) Token: 0x06009187 RID: 37255 RVA: 0x0003EE08 File Offset: 0x0003D008
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002AB3 RID: 10931
			// (get) Token: 0x06009188 RID: 37256 RVA: 0x0026E69C File Offset: 0x0026C89C
			// (set) Token: 0x06009189 RID: 37257 RVA: 0x0003EE23 File Offset: 0x0003D023
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB4 RID: 10932
			// (get) Token: 0x0600918A RID: 37258 RVA: 0x0026E6CC File Offset: 0x0026C8CC
			// (set) Token: 0x0600918B RID: 37259 RVA: 0x0003EE42 File Offset: 0x0003D042
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB5 RID: 10933
			// (get) Token: 0x0600918C RID: 37260 RVA: 0x0026E6FC File Offset: 0x0026C8FC
			// (set) Token: 0x0600918D RID: 37261 RVA: 0x0003EE61 File Offset: 0x0003D061
			public unsafe HagalAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB6 RID: 10934
			// (get) Token: 0x0600918E RID: 37262 RVA: 0x0026E72C File Offset: 0x0026C92C
			// (set) Token: 0x0600918F RID: 37263 RVA: 0x0003EE80 File Offset: 0x0003D080
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB7 RID: 10935
			// (get) Token: 0x06009190 RID: 37264 RVA: 0x0026E75C File Offset: 0x0026C95C
			// (set) Token: 0x06009191 RID: 37265 RVA: 0x0003EE9F File Offset: 0x0003D09F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB8 RID: 10936
			// (get) Token: 0x06009192 RID: 37266 RVA: 0x0026E78C File Offset: 0x0026C98C
			// (set) Token: 0x06009193 RID: 37267 RVA: 0x0003EEBE File Offset: 0x0003D0BE
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AB9 RID: 10937
			// (get) Token: 0x06009194 RID: 37268 RVA: 0x0026E7BC File Offset: 0x0026C9BC
			// (set) Token: 0x06009195 RID: 37269 RVA: 0x0003EEDD File Offset: 0x0003D0DD
			public unsafe Dictionary<Factions, int> _factionDictionary_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__factionDictionary_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Factions, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr__factionDictionary_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABA RID: 10938
			// (get) Token: 0x06009196 RID: 37270 RVA: 0x0026E7EC File Offset: 0x0026C9EC
			// (set) Token: 0x06009197 RID: 37271 RVA: 0x0003EEFC File Offset: 0x0003D0FC
			public Dictionary<Factions, int>.KeyCollection.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___7__wrap3);
					return new Dictionary<Factions, int>.KeyCollection.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<Factions, int>.KeyCollection.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._GrantResources_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<Factions, int>.KeyCollection.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005CC4 RID: 23748
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CC5 RID: 23749
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005CC6 RID: 23750
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005CC7 RID: 23751
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005CC8 RID: 23752
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005CC9 RID: 23753
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CCA RID: 23754
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005CCB RID: 23755
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005CCC RID: 23756
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005CCD RID: 23757
			private static readonly IntPtr NativeFieldInfoPtr__factionDictionary_5__3;

			// Token: 0x04005CCE RID: 23758
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04005CCF RID: 23759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005CD0 RID: 23760
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CD1 RID: 23761
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005CD2 RID: 23762
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005CD3 RID: 23763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005CD4 RID: 23764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CD5 RID: 23765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005CD6 RID: 23766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005CD7 RID: 23767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000971 RID: 2417
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<HagalAcquireTech>d__18")]
		public sealed class _HagalAcquireTech_d__18 : Object
		{
			// Token: 0x06009198 RID: 37272 RVA: 0x0026E81C File Offset: 0x0026CA1C
			// Note: this type is marked as 'beforefieldinit'.
			static _HagalAcquireTech_d__18()
			{
				Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<HagalAcquireTech>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr);
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>1__state");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>2__current");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>l__initialThreadId");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_discount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "discount");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__discount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>3__discount");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "context");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>3__context");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>4__this");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "match");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>3__match");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>8__1");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_negotiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "negotiate");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__negotiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>3__negotiate");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileStack_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<techTileStack>5__2");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTile_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<techTile>5__3");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<sequenceHelper>5__4");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileForTrash_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<techTileForTrash>5__5");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<>7__wrap5");
				HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__tileCost_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, "<tileCost>5__7");
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675123);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675124);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675125);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675126);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675127);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675128);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675129);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675130);
				HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr, 100675131);
			}

			// Token: 0x06009199 RID: 37273 RVA: 0x0026EA78 File Offset: 0x0026CC78
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HagalAcquireTech_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility._HagalAcquireTech_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600919A RID: 37274 RVA: 0x0026EAC0 File Offset: 0x0026CCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198460, XrefRangeEnd = 198463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600919B RID: 37275 RVA: 0x0026EAF4 File Offset: 0x0026CCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198463, XrefRangeEnd = 198720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600919C RID: 37276 RVA: 0x0026EB30 File Offset: 0x0026CD30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198720, XrefRangeEnd = 198723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AD0 RID: 10960
			// (get) Token: 0x0600919D RID: 37277 RVA: 0x0026EB64 File Offset: 0x0026CD64
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600919E RID: 37278 RVA: 0x0026EBA4 File Offset: 0x0026CDA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198723, XrefRangeEnd = 198728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AD1 RID: 10961
			// (get) Token: 0x0600919F RID: 37279 RVA: 0x0026EBD8 File Offset: 0x0026CDD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060091A0 RID: 37280 RVA: 0x0026EC18 File Offset: 0x0026CE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198728, XrefRangeEnd = 198738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060091A1 RID: 37281 RVA: 0x0026EC58 File Offset: 0x0026CE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalAcquireTech_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060091A2 RID: 37282 RVA: 0x0003EF2A File Offset: 0x0003D12A
			public _HagalAcquireTech_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002ABD RID: 10941
			// (get) Token: 0x060091A3 RID: 37283 RVA: 0x0026EC98 File Offset: 0x0026CE98
			// (set) Token: 0x060091A4 RID: 37284 RVA: 0x0003EF33 File Offset: 0x0003D133
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002ABE RID: 10942
			// (get) Token: 0x060091A5 RID: 37285 RVA: 0x0026ECC0 File Offset: 0x0026CEC0
			// (set) Token: 0x060091A6 RID: 37286 RVA: 0x0003EF4E File Offset: 0x0003D14E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABF RID: 10943
			// (get) Token: 0x060091A7 RID: 37287 RVA: 0x0026ECF0 File Offset: 0x0026CEF0
			// (set) Token: 0x060091A8 RID: 37288 RVA: 0x0003EF6D File Offset: 0x0003D16D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002AC0 RID: 10944
			// (get) Token: 0x060091A9 RID: 37289 RVA: 0x0026ED18 File Offset: 0x0026CF18
			// (set) Token: 0x060091AA RID: 37290 RVA: 0x0003EF88 File Offset: 0x0003D188
			public unsafe int discount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_discount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_discount)) = value;
				}
			}

			// Token: 0x17002AC1 RID: 10945
			// (get) Token: 0x060091AB RID: 37291 RVA: 0x0026ED40 File Offset: 0x0026CF40
			// (set) Token: 0x060091AC RID: 37292 RVA: 0x0003EFA3 File Offset: 0x0003D1A3
			public unsafe int __3__discount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__discount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__discount)) = value;
				}
			}

			// Token: 0x17002AC2 RID: 10946
			// (get) Token: 0x060091AD RID: 37293 RVA: 0x0026ED68 File Offset: 0x0026CF68
			// (set) Token: 0x060091AE RID: 37294 RVA: 0x0003EFBE File Offset: 0x0003D1BE
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC3 RID: 10947
			// (get) Token: 0x060091AF RID: 37295 RVA: 0x0026ED98 File Offset: 0x0026CF98
			// (set) Token: 0x060091B0 RID: 37296 RVA: 0x0003EFDD File Offset: 0x0003D1DD
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC4 RID: 10948
			// (get) Token: 0x060091B1 RID: 37297 RVA: 0x0026EDC8 File Offset: 0x0026CFC8
			// (set) Token: 0x060091B2 RID: 37298 RVA: 0x0003EFFC File Offset: 0x0003D1FC
			public unsafe HagalAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC5 RID: 10949
			// (get) Token: 0x060091B3 RID: 37299 RVA: 0x0026EDF8 File Offset: 0x0026CFF8
			// (set) Token: 0x060091B4 RID: 37300 RVA: 0x0003F01B File Offset: 0x0003D21B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC6 RID: 10950
			// (get) Token: 0x060091B5 RID: 37301 RVA: 0x0026EE28 File Offset: 0x0026D028
			// (set) Token: 0x060091B6 RID: 37302 RVA: 0x0003F03A File Offset: 0x0003D23A
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC7 RID: 10951
			// (get) Token: 0x060091B7 RID: 37303 RVA: 0x0026EE58 File Offset: 0x0026D058
			// (set) Token: 0x060091B8 RID: 37304 RVA: 0x0003F059 File Offset: 0x0003D259
			public unsafe HagalAbility.__c__DisplayClass18_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC8 RID: 10952
			// (get) Token: 0x060091B9 RID: 37305 RVA: 0x0026EE88 File Offset: 0x0026D088
			// (set) Token: 0x060091BA RID: 37306 RVA: 0x0003F078 File Offset: 0x0003D278
			public unsafe bool negotiate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_negotiate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr_negotiate)) = value;
				}
			}

			// Token: 0x17002AC9 RID: 10953
			// (get) Token: 0x060091BB RID: 37307 RVA: 0x0026EEB0 File Offset: 0x0026D0B0
			// (set) Token: 0x060091BC RID: 37308 RVA: 0x0003F093 File Offset: 0x0003D293
			public unsafe bool __3__negotiate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__negotiate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___3__negotiate)) = value;
				}
			}

			// Token: 0x17002ACA RID: 10954
			// (get) Token: 0x060091BD RID: 37309 RVA: 0x0026EED8 File Offset: 0x0026D0D8
			// (set) Token: 0x060091BE RID: 37310 RVA: 0x0003F0AE File Offset: 0x0003D2AE
			public unsafe WormTechTileStack _techTileStack_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileStack_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTileStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileStack_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ACB RID: 10955
			// (get) Token: 0x060091BF RID: 37311 RVA: 0x0026EF08 File Offset: 0x0026D108
			// (set) Token: 0x060091C0 RID: 37312 RVA: 0x0003F0CD File Offset: 0x0003D2CD
			public unsafe WormTechTilePlayable _techTile_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTile_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTile_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ACC RID: 10956
			// (get) Token: 0x060091C1 RID: 37313 RVA: 0x0026EF38 File Offset: 0x0026D138
			// (set) Token: 0x060091C2 RID: 37314 RVA: 0x0003F0EC File Offset: 0x0003D2EC
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ACD RID: 10957
			// (get) Token: 0x060091C3 RID: 37315 RVA: 0x0026EF68 File Offset: 0x0026D168
			// (set) Token: 0x060091C4 RID: 37316 RVA: 0x0003F10B File Offset: 0x0003D30B
			public unsafe WormTechTilePlayable _techTileForTrash_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileForTrash_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__techTileForTrash_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ACE RID: 10958
			// (get) Token: 0x060091C5 RID: 37317 RVA: 0x0026EF98 File Offset: 0x0026D198
			// (set) Token: 0x060091C6 RID: 37318 RVA: 0x0003F12A File Offset: 0x0003D32A
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ACF RID: 10959
			// (get) Token: 0x060091C7 RID: 37319 RVA: 0x0026EFC8 File Offset: 0x0026D1C8
			// (set) Token: 0x060091C8 RID: 37320 RVA: 0x0003F149 File Offset: 0x0003D349
			public unsafe int _tileCost_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__tileCost_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalAcquireTech_d__18.NativeFieldInfoPtr__tileCost_5__7)) = value;
				}
			}

			// Token: 0x04005CD8 RID: 23768
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CD9 RID: 23769
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005CDA RID: 23770
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005CDB RID: 23771
			private static readonly IntPtr NativeFieldInfoPtr_discount;

			// Token: 0x04005CDC RID: 23772
			private static readonly IntPtr NativeFieldInfoPtr___3__discount;

			// Token: 0x04005CDD RID: 23773
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005CDE RID: 23774
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005CDF RID: 23775
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CE0 RID: 23776
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005CE1 RID: 23777
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005CE2 RID: 23778
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005CE3 RID: 23779
			private static readonly IntPtr NativeFieldInfoPtr_negotiate;

			// Token: 0x04005CE4 RID: 23780
			private static readonly IntPtr NativeFieldInfoPtr___3__negotiate;

			// Token: 0x04005CE5 RID: 23781
			private static readonly IntPtr NativeFieldInfoPtr__techTileStack_5__2;

			// Token: 0x04005CE6 RID: 23782
			private static readonly IntPtr NativeFieldInfoPtr__techTile_5__3;

			// Token: 0x04005CE7 RID: 23783
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x04005CE8 RID: 23784
			private static readonly IntPtr NativeFieldInfoPtr__techTileForTrash_5__5;

			// Token: 0x04005CE9 RID: 23785
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04005CEA RID: 23786
			private static readonly IntPtr NativeFieldInfoPtr__tileCost_5__7;

			// Token: 0x04005CEB RID: 23787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005CEC RID: 23788
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CED RID: 23789
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005CEE RID: 23790
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005CEF RID: 23791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005CF0 RID: 23792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CF1 RID: 23793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005CF2 RID: 23794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005CF3 RID: 23795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000972 RID: 2418
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<HagalGainVP>d__13")]
		public sealed class _HagalGainVP_d__13 : Object
		{
			// Token: 0x060091C9 RID: 37321 RVA: 0x0026EFF0 File Offset: 0x0026D1F0
			// Note: this type is marked as 'beforefieldinit'.
			static _HagalGainVP_d__13()
			{
				Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<HagalGainVP>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr);
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<>1__state");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<>2__current");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<>l__initialThreadId");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "player");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<>3__player");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "match");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<>3__match");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__exchangeSpice_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<exchangeSpice>5__2");
				HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, "<sequenceHelper>5__3");
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675132);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675133);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675134);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675135);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675136);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675137);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675138);
				HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr, 100675139);
			}

			// Token: 0x060091CA RID: 37322 RVA: 0x0026F170 File Offset: 0x0026D370
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HagalGainVP_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility._HagalGainVP_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060091CB RID: 37323 RVA: 0x0026F1B8 File Offset: 0x0026D3B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091CC RID: 37324 RVA: 0x0026F1EC File Offset: 0x0026D3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198738, XrefRangeEnd = 199074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002ADB RID: 10971
			// (get) Token: 0x060091CD RID: 37325 RVA: 0x0026F228 File Offset: 0x0026D428
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060091CE RID: 37326 RVA: 0x0026F268 File Offset: 0x0026D468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199074, XrefRangeEnd = 199079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002ADC RID: 10972
			// (get) Token: 0x060091CF RID: 37327 RVA: 0x0026F29C File Offset: 0x0026D49C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060091D0 RID: 37328 RVA: 0x0026F2DC File Offset: 0x0026D4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199079, XrefRangeEnd = 199088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060091D1 RID: 37329 RVA: 0x0026F31C File Offset: 0x0026D51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._HagalGainVP_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060091D2 RID: 37330 RVA: 0x0003F164 File Offset: 0x0003D364
			public _HagalGainVP_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002AD2 RID: 10962
			// (get) Token: 0x060091D3 RID: 37331 RVA: 0x0026F35C File Offset: 0x0026D55C
			// (set) Token: 0x060091D4 RID: 37332 RVA: 0x0003F16D File Offset: 0x0003D36D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AD3 RID: 10963
			// (get) Token: 0x060091D5 RID: 37333 RVA: 0x0026F384 File Offset: 0x0026D584
			// (set) Token: 0x060091D6 RID: 37334 RVA: 0x0003F188 File Offset: 0x0003D388
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD4 RID: 10964
			// (get) Token: 0x060091D7 RID: 37335 RVA: 0x0026F3B4 File Offset: 0x0026D5B4
			// (set) Token: 0x060091D8 RID: 37336 RVA: 0x0003F1A7 File Offset: 0x0003D3A7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002AD5 RID: 10965
			// (get) Token: 0x060091D9 RID: 37337 RVA: 0x0026F3DC File Offset: 0x0026D5DC
			// (set) Token: 0x060091DA RID: 37338 RVA: 0x0003F1C2 File Offset: 0x0003D3C2
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD6 RID: 10966
			// (get) Token: 0x060091DB RID: 37339 RVA: 0x0026F40C File Offset: 0x0026D60C
			// (set) Token: 0x060091DC RID: 37340 RVA: 0x0003F1E1 File Offset: 0x0003D3E1
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD7 RID: 10967
			// (get) Token: 0x060091DD RID: 37341 RVA: 0x0026F43C File Offset: 0x0026D63C
			// (set) Token: 0x060091DE RID: 37342 RVA: 0x0003F200 File Offset: 0x0003D400
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD8 RID: 10968
			// (get) Token: 0x060091DF RID: 37343 RVA: 0x0026F46C File Offset: 0x0026D66C
			// (set) Token: 0x060091E0 RID: 37344 RVA: 0x0003F21F File Offset: 0x0003D41F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AD9 RID: 10969
			// (get) Token: 0x060091E1 RID: 37345 RVA: 0x0026F49C File Offset: 0x0026D69C
			// (set) Token: 0x060091E2 RID: 37346 RVA: 0x0003F23E File Offset: 0x0003D43E
			public unsafe bool _exchangeSpice_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__exchangeSpice_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__exchangeSpice_5__2)) = value;
				}
			}

			// Token: 0x17002ADA RID: 10970
			// (get) Token: 0x060091E3 RID: 37347 RVA: 0x0026F4C4 File Offset: 0x0026D6C4
			// (set) Token: 0x060091E4 RID: 37348 RVA: 0x0003F259 File Offset: 0x0003D459
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._HagalGainVP_d__13.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CF4 RID: 23796
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CF5 RID: 23797
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005CF6 RID: 23798
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005CF7 RID: 23799
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005CF8 RID: 23800
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04005CF9 RID: 23801
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005CFA RID: 23802
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005CFB RID: 23803
			private static readonly IntPtr NativeFieldInfoPtr__exchangeSpice_5__2;

			// Token: 0x04005CFC RID: 23804
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x04005CFD RID: 23805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005CFE RID: 23806
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CFF RID: 23807
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005D00 RID: 23808
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005D01 RID: 23809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D02 RID: 23810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005D03 RID: 23811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005D04 RID: 23812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000973 RID: 2419
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.HagalAbility+<RunImmediateEffects>d__6")]
		public sealed class _RunImmediateEffects_d__6 : Object
		{
			// Token: 0x060091E5 RID: 37349 RVA: 0x0026F4F4 File Offset: 0x0026D6F4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__6()
			{
				Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalAbility>.NativeClassPtr, "<RunImmediateEffects>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr);
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>1__state");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>2__current");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>l__initialThreadId");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "activeAbility");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__activeAbility");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>4__this");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "match");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__match");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "context");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__context");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<player>5__2");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__chosenSpace_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<chosenSpace>5__3");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__nextAgent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<nextAgent>5__4");
				HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>7__wrap4");
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675140);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675141);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675142);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675143);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675144);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675145);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675146);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675147);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675148);
				HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100675149);
			}

			// Token: 0x060091E6 RID: 37350 RVA: 0x0026F700 File Offset: 0x0026D900
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalAbility._RunImmediateEffects_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060091E7 RID: 37351 RVA: 0x0026F748 File Offset: 0x0026D948
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091E8 RID: 37352 RVA: 0x0026F77C File Offset: 0x0026D97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199088, XrefRangeEnd = 199209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060091E9 RID: 37353 RVA: 0x0026F7B8 File Offset: 0x0026D9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199209, XrefRangeEnd = 199212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091EA RID: 37354 RVA: 0x0026F7EC File Offset: 0x0026D9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199212, XrefRangeEnd = 199215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AEB RID: 10987
			// (get) Token: 0x060091EB RID: 37355 RVA: 0x0026F820 File Offset: 0x0026DA20
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060091EC RID: 37356 RVA: 0x0026F860 File Offset: 0x0026DA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199215, XrefRangeEnd = 199220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AEC RID: 10988
			// (get) Token: 0x060091ED RID: 37357 RVA: 0x0026F894 File Offset: 0x0026DA94
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060091EE RID: 37358 RVA: 0x0026F8D4 File Offset: 0x0026DAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199220, XrefRangeEnd = 199231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060091EF RID: 37359 RVA: 0x0026F914 File Offset: 0x0026DB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060091F0 RID: 37360 RVA: 0x0003F278 File Offset: 0x0003D478
			public _RunImmediateEffects_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002ADD RID: 10973
			// (get) Token: 0x060091F1 RID: 37361 RVA: 0x0026F954 File Offset: 0x0026DB54
			// (set) Token: 0x060091F2 RID: 37362 RVA: 0x0003F281 File Offset: 0x0003D481
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002ADE RID: 10974
			// (get) Token: 0x060091F3 RID: 37363 RVA: 0x0026F97C File Offset: 0x0026DB7C
			// (set) Token: 0x060091F4 RID: 37364 RVA: 0x0003F29C File Offset: 0x0003D49C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ADF RID: 10975
			// (get) Token: 0x060091F5 RID: 37365 RVA: 0x0026F9AC File Offset: 0x0026DBAC
			// (set) Token: 0x060091F6 RID: 37366 RVA: 0x0003F2BB File Offset: 0x0003D4BB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002AE0 RID: 10976
			// (get) Token: 0x060091F7 RID: 37367 RVA: 0x0026F9D4 File Offset: 0x0026DBD4
			// (set) Token: 0x060091F8 RID: 37368 RVA: 0x0003F2D6 File Offset: 0x0003D4D6
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE1 RID: 10977
			// (get) Token: 0x060091F9 RID: 37369 RVA: 0x0026FA04 File Offset: 0x0026DC04
			// (set) Token: 0x060091FA RID: 37370 RVA: 0x0003F2F5 File Offset: 0x0003D4F5
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE2 RID: 10978
			// (get) Token: 0x060091FB RID: 37371 RVA: 0x0026FA34 File Offset: 0x0026DC34
			// (set) Token: 0x060091FC RID: 37372 RVA: 0x0003F314 File Offset: 0x0003D514
			public unsafe HagalAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE3 RID: 10979
			// (get) Token: 0x060091FD RID: 37373 RVA: 0x0026FA64 File Offset: 0x0026DC64
			// (set) Token: 0x060091FE RID: 37374 RVA: 0x0003F333 File Offset: 0x0003D533
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE4 RID: 10980
			// (get) Token: 0x060091FF RID: 37375 RVA: 0x0026FA94 File Offset: 0x0026DC94
			// (set) Token: 0x06009200 RID: 37376 RVA: 0x0003F352 File Offset: 0x0003D552
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE5 RID: 10981
			// (get) Token: 0x06009201 RID: 37377 RVA: 0x0026FAC4 File Offset: 0x0026DCC4
			// (set) Token: 0x06009202 RID: 37378 RVA: 0x0003F371 File Offset: 0x0003D571
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE6 RID: 10982
			// (get) Token: 0x06009203 RID: 37379 RVA: 0x0026FAF4 File Offset: 0x0026DCF4
			// (set) Token: 0x06009204 RID: 37380 RVA: 0x0003F390 File Offset: 0x0003D590
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE7 RID: 10983
			// (get) Token: 0x06009205 RID: 37381 RVA: 0x0026FB24 File Offset: 0x0026DD24
			// (set) Token: 0x06009206 RID: 37382 RVA: 0x0003F3AF File Offset: 0x0003D5AF
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE8 RID: 10984
			// (get) Token: 0x06009207 RID: 37383 RVA: 0x0026FB54 File Offset: 0x0026DD54
			// (set) Token: 0x06009208 RID: 37384 RVA: 0x0003F3CE File Offset: 0x0003D5CE
			public unsafe WormSpace _chosenSpace_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__chosenSpace_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__chosenSpace_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AE9 RID: 10985
			// (get) Token: 0x06009209 RID: 37385 RVA: 0x0026FB84 File Offset: 0x0026DD84
			// (set) Token: 0x0600920A RID: 37386 RVA: 0x0003F3ED File Offset: 0x0003D5ED
			public unsafe WormAgent _nextAgent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__nextAgent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__nextAgent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AEA RID: 10986
			// (get) Token: 0x0600920B RID: 37387 RVA: 0x0026FBB4 File Offset: 0x0026DDB4
			// (set) Token: 0x0600920C RID: 37388 RVA: 0x0003F40C File Offset: 0x0003D60C
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D05 RID: 23813
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D06 RID: 23814
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005D07 RID: 23815
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005D08 RID: 23816
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005D09 RID: 23817
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005D0A RID: 23818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D0B RID: 23819
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005D0C RID: 23820
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005D0D RID: 23821
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005D0E RID: 23822
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005D0F RID: 23823
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005D10 RID: 23824
			private static readonly IntPtr NativeFieldInfoPtr__chosenSpace_5__3;

			// Token: 0x04005D11 RID: 23825
			private static readonly IntPtr NativeFieldInfoPtr__nextAgent_5__4;

			// Token: 0x04005D12 RID: 23826
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04005D13 RID: 23827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005D14 RID: 23828
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D15 RID: 23829
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005D16 RID: 23830
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005D17 RID: 23831
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04005D18 RID: 23832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005D19 RID: 23833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D1A RID: 23834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005D1B RID: 23835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005D1C RID: 23836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
