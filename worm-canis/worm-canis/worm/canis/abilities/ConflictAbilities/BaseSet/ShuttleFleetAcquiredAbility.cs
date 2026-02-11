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
using worm.canis.abilities.ActivatedAbilities.RiseOfIx.TechTileAcquiredAbilities;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.ConflictAbilities.BaseSet
{
	// Token: 0x020003E4 RID: 996
	public class ShuttleFleetAcquiredAbility : TechTileAcquiredAbility
	{
		// Token: 0x06002A29 RID: 10793 RVA: 0x001058EC File Offset: 0x00103AEC
		// Note: this type is marked as 'beforefieldinit'.
		static ShuttleFleetAcquiredAbility()
		{
			Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ConflictAbilities.BaseSet", "ShuttleFleetAcquiredAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr);
			ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "AbilityName");
			ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "AbilityID");
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675739);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675740);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675741);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675742);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675743);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675744);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675745);
			ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, 100675746);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x001059E4 File Offset: 0x00103BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203950, XrefRangeEnd = 203954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00105A30 File Offset: 0x00103C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203954, XrefRangeEnd = 203970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShuttleFleetAcquiredAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00105A7C File Offset: 0x00103C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203970, XrefRangeEnd = 203974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShuttleFleetAcquiredAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00105AEC File Offset: 0x00103CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203974, XrefRangeEnd = 203980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00105B5C File Offset: 0x00103D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203980, XrefRangeEnd = 203987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00105BCC File Offset: 0x00103DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203987, XrefRangeEnd = 203995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> CustomExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00105C4C File Offset: 0x00103E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203995, XrefRangeEnd = 204063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00105CC8 File Offset: 0x00103EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204063, XrefRangeEnd = 204185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShuttleFleetAcquiredAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0000F9CF File Offset: 0x0000DBCF
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0000F9DE File Offset: 0x0000DBDE
		public ShuttleFleetAcquiredAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x00105D24 File Offset: 0x00103F24
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x0000F9E7 File Offset: 0x0000DBE7
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00105D44 File Offset: 0x00103F44
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x0000F9F9 File Offset: 0x0000DBF9
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x020009A1 RID: 2465
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.ShuttleFleetAcquiredAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009650 RID: 38480 RVA: 0x0027C478 File Offset: 0x0027A678
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr);
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__6_0");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__6_1");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__6_2");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__7_0");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__7_1");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__8_0");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__9_0");
				ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, "<>9__9_2");
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675749);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675750);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675751);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675752);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__CustomExecution_b__7_0_Internal_Factions_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675753);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__CustomExecution_b__7_1_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675754);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675755);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675756);
				ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Evaluate_b__9_2_Internal_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr, 100675757);
			}

			// Token: 0x06009651 RID: 38481 RVA: 0x0027C60C File Offset: 0x0027A80C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009652 RID: 38482 RVA: 0x0027C648 File Offset: 0x0027A848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__6_0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009653 RID: 38483 RVA: 0x0027C698 File Offset: 0x0027A898
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__6_1(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06009654 RID: 38484 RVA: 0x0027C6E8 File Offset: 0x0027A8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203656, XrefRangeEnd = 203676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__6_2(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x06009655 RID: 38485 RVA: 0x0027C738 File Offset: 0x0027A938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Factions _CustomExecution_b__7_0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__CustomExecution_b__7_0_Internal_Factions_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009656 RID: 38486 RVA: 0x0027C788 File Offset: 0x0027A988
			[CallerCount(0)]
			public unsafe bool _CustomExecution_b__7_1(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__CustomExecution_b__7_1_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009657 RID: 38487 RVA: 0x0027C7D4 File Offset: 0x0027A9D4
			[CallerCount(0)]
			public unsafe double _ValueForPlayer_b__8_0(double _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009658 RID: 38488 RVA: 0x0027C820 File Offset: 0x0027AA20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203676, XrefRangeEnd = 203680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__9_0(AIValueSummer<double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009659 RID: 38489 RVA: 0x0027C870 File Offset: 0x0027AA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203680, XrefRangeEnd = 203684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__9_2(AIValueSummer<double> c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c.NativeMethodInfoPtr__Evaluate_b__9_2_Internal_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600965A RID: 38490 RVA: 0x00041C62 File Offset: 0x0003FE62
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002C87 RID: 11399
			// (get) Token: 0x0600965B RID: 38491 RVA: 0x0027C8C0 File Offset: 0x0027AAC0
			// (set) Token: 0x0600965C RID: 38492 RVA: 0x00041C6B File Offset: 0x0003FE6B
			public unsafe static ShuttleFleetAcquiredAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShuttleFleetAcquiredAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C88 RID: 11400
			// (get) Token: 0x0600965D RID: 38493 RVA: 0x0027C8E8 File Offset: 0x0027AAE8
			// (set) Token: 0x0600965E RID: 38494 RVA: 0x00041C7D File Offset: 0x0003FE7D
			public unsafe static Func<WormFactionTrack, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C89 RID: 11401
			// (get) Token: 0x0600965F RID: 38495 RVA: 0x0027C910 File Offset: 0x0027AB10
			// (set) Token: 0x06009660 RID: 38496 RVA: 0x00041C8F File Offset: 0x0003FE8F
			public unsafe static Func<WormFactionTrack, EntityID> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8A RID: 11402
			// (get) Token: 0x06009661 RID: 38497 RVA: 0x0027C938 File Offset: 0x0027AB38
			// (set) Token: 0x06009662 RID: 38498 RVA: 0x00041CA1 File Offset: 0x0003FEA1
			public unsafe static Func<WormFactionTrack, ReadOnlyAttributes> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8B RID: 11403
			// (get) Token: 0x06009663 RID: 38499 RVA: 0x0027C960 File Offset: 0x0027AB60
			// (set) Token: 0x06009664 RID: 38500 RVA: 0x00041CB3 File Offset: 0x0003FEB3
			public unsafe static Func<WormFactionTrack, Factions> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8C RID: 11404
			// (get) Token: 0x06009665 RID: 38501 RVA: 0x0027C988 File Offset: 0x0027AB88
			// (set) Token: 0x06009666 RID: 38502 RVA: 0x00041CC5 File Offset: 0x0003FEC5
			public unsafe static Func<Factions, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8D RID: 11405
			// (get) Token: 0x06009667 RID: 38503 RVA: 0x0027C9B0 File Offset: 0x0027ABB0
			// (set) Token: 0x06009668 RID: 38504 RVA: 0x00041CD7 File Offset: 0x0003FED7
			public unsafe static Func<double, double> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8E RID: 11406
			// (get) Token: 0x06009669 RID: 38505 RVA: 0x0027C9D8 File Offset: 0x0027ABD8
			// (set) Token: 0x0600966A RID: 38506 RVA: 0x00041CE9 File Offset: 0x0003FEE9
			public unsafe static Func<AIValueSummer<double>, double> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C8F RID: 11407
			// (get) Token: 0x0600966B RID: 38507 RVA: 0x0027CA00 File Offset: 0x0027AC00
			// (set) Token: 0x0600966C RID: 38508 RVA: 0x00041CFB File Offset: 0x0003FEFB
			public unsafe static Func<AIValueSummer<double>, double> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShuttleFleetAcquiredAbility.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FB8 RID: 24504
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005FB9 RID: 24505
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04005FBA RID: 24506
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04005FBB RID: 24507
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04005FBC RID: 24508
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04005FBD RID: 24509
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04005FBE RID: 24510
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04005FBF RID: 24511
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04005FC0 RID: 24512
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04005FC1 RID: 24513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FC2 RID: 24514
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0;

			// Token: 0x04005FC3 RID: 24515
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0;

			// Token: 0x04005FC4 RID: 24516
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0;

			// Token: 0x04005FC5 RID: 24517
			private static readonly IntPtr NativeMethodInfoPtr__CustomExecution_b__7_0_Internal_Factions_WormFactionTrack_0;

			// Token: 0x04005FC6 RID: 24518
			private static readonly IntPtr NativeMethodInfoPtr__CustomExecution_b__7_1_Internal_Boolean_Factions_0;

			// Token: 0x04005FC7 RID: 24519
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Double_Double_0;

			// Token: 0x04005FC8 RID: 24520
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__9_0_Internal_Double_AIValueSummer_1_Double_0;

			// Token: 0x04005FC9 RID: 24521
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__9_2_Internal_Double_AIValueSummer_1_Double_0;
		}

		// Token: 0x020009A2 RID: 2466
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.ShuttleFleetAcquiredAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600966D RID: 38509 RVA: 0x0027CA28 File Offset: 0x0027AC28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr);
				ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_factionScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr, "factionScores");
				ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr, 100675758);
				ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_EntityID_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr, 100675759);
			}

			// Token: 0x0600966E RID: 38510 RVA: 0x0027CA90 File Offset: 0x0027AC90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600966F RID: 38511 RVA: 0x0027CACC File Offset: 0x0027ACCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203684, XrefRangeEnd = 203687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _Evaluate_b__1(AIValueSummer<double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_EntityID_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06009670 RID: 38512 RVA: 0x00041D0D File Offset: 0x0003FF0D
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002C90 RID: 11408
			// (get) Token: 0x06009671 RID: 38513 RVA: 0x0027CB1C File Offset: 0x0027AD1C
			// (set) Token: 0x06009672 RID: 38514 RVA: 0x00041D16 File Offset: 0x0003FF16
			public unsafe Dictionary<AIValueSummer<double>, WormFactionTrack> factionScores
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_factionScores);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AIValueSummer<double>, WormFactionTrack>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_factionScores), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FCA RID: 24522
			private static readonly IntPtr NativeFieldInfoPtr_factionScores;

			// Token: 0x04005FCB RID: 24523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FCC RID: 24524
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_EntityID_AIValueSummer_1_Double_0;
		}

		// Token: 0x020009A3 RID: 2467
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.ShuttleFleetAcquiredAbility+<CustomExecution>d__7")]
		public sealed class _CustomExecution_d__7 : Object
		{
			// Token: 0x06009673 RID: 38515 RVA: 0x0027CB4C File Offset: 0x0027AD4C
			// Note: this type is marked as 'beforefieldinit'.
			static _CustomExecution_d__7()
			{
				Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "<CustomExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>1__state");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>2__current");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "activeAbility");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>4__this");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "match");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__match");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<player>5__2");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__gameLogID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<gameLogID>5__3");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, "<>7__wrap3");
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675760);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675761);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675762);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675763);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675764);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675765);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675766);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675767);
				ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr, 100675768);
			}

			// Token: 0x06009674 RID: 38516 RVA: 0x0027CD08 File Offset: 0x0027AF08
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CustomExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._CustomExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009675 RID: 38517 RVA: 0x0027CD50 File Offset: 0x0027AF50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203687, XrefRangeEnd = 203692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009676 RID: 38518 RVA: 0x0027CD84 File Offset: 0x0027AF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203692, XrefRangeEnd = 203808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009677 RID: 38519 RVA: 0x0027CDC0 File Offset: 0x0027AFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203808, XrefRangeEnd = 203811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C9C RID: 11420
			// (get) Token: 0x06009678 RID: 38520 RVA: 0x0027CDF4 File Offset: 0x0027AFF4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009679 RID: 38521 RVA: 0x0027CE34 File Offset: 0x0027B034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203811, XrefRangeEnd = 203816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C9D RID: 11421
			// (get) Token: 0x0600967A RID: 38522 RVA: 0x0027CE68 File Offset: 0x0027B068
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600967B RID: 38523 RVA: 0x0027CEA8 File Offset: 0x0027B0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203816, XrefRangeEnd = 203826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600967C RID: 38524 RVA: 0x0027CEE8 File Offset: 0x0027B0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600967D RID: 38525 RVA: 0x00041D35 File Offset: 0x0003FF35
			public _CustomExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002C91 RID: 11409
			// (get) Token: 0x0600967E RID: 38526 RVA: 0x0027CF28 File Offset: 0x0027B128
			// (set) Token: 0x0600967F RID: 38527 RVA: 0x00041D3E File Offset: 0x0003FF3E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C92 RID: 11410
			// (get) Token: 0x06009680 RID: 38528 RVA: 0x0027CF50 File Offset: 0x0027B150
			// (set) Token: 0x06009681 RID: 38529 RVA: 0x00041D59 File Offset: 0x0003FF59
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C93 RID: 11411
			// (get) Token: 0x06009682 RID: 38530 RVA: 0x0027CF80 File Offset: 0x0027B180
			// (set) Token: 0x06009683 RID: 38531 RVA: 0x00041D78 File Offset: 0x0003FF78
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002C94 RID: 11412
			// (get) Token: 0x06009684 RID: 38532 RVA: 0x0027CFA8 File Offset: 0x0027B1A8
			// (set) Token: 0x06009685 RID: 38533 RVA: 0x00041D93 File Offset: 0x0003FF93
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C95 RID: 11413
			// (get) Token: 0x06009686 RID: 38534 RVA: 0x0027CFD8 File Offset: 0x0027B1D8
			// (set) Token: 0x06009687 RID: 38535 RVA: 0x00041DB2 File Offset: 0x0003FFB2
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C96 RID: 11414
			// (get) Token: 0x06009688 RID: 38536 RVA: 0x0027D008 File Offset: 0x0027B208
			// (set) Token: 0x06009689 RID: 38537 RVA: 0x00041DD1 File Offset: 0x0003FFD1
			public unsafe ShuttleFleetAcquiredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShuttleFleetAcquiredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C97 RID: 11415
			// (get) Token: 0x0600968A RID: 38538 RVA: 0x0027D038 File Offset: 0x0027B238
			// (set) Token: 0x0600968B RID: 38539 RVA: 0x00041DF0 File Offset: 0x0003FFF0
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C98 RID: 11416
			// (get) Token: 0x0600968C RID: 38540 RVA: 0x0027D068 File Offset: 0x0027B268
			// (set) Token: 0x0600968D RID: 38541 RVA: 0x00041E0F File Offset: 0x0004000F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C99 RID: 11417
			// (get) Token: 0x0600968E RID: 38542 RVA: 0x0027D098 File Offset: 0x0027B298
			// (set) Token: 0x0600968F RID: 38543 RVA: 0x00041E2E File Offset: 0x0004002E
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C9A RID: 11418
			// (get) Token: 0x06009690 RID: 38544 RVA: 0x0027D0C8 File Offset: 0x0027B2C8
			// (set) Token: 0x06009691 RID: 38545 RVA: 0x00041E4D File Offset: 0x0004004D
			public unsafe int _gameLogID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__gameLogID_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr__gameLogID_5__3)) = value;
				}
			}

			// Token: 0x17002C9B RID: 11419
			// (get) Token: 0x06009692 RID: 38546 RVA: 0x0027D0F0 File Offset: 0x0027B2F0
			// (set) Token: 0x06009693 RID: 38547 RVA: 0x00041E68 File Offset: 0x00040068
			public List<Factions>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___7__wrap3);
					return new List<Factions>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._CustomExecution_d__7.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005FCD RID: 24525
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005FCE RID: 24526
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005FCF RID: 24527
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005FD0 RID: 24528
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005FD1 RID: 24529
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005FD2 RID: 24530
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005FD3 RID: 24531
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005FD4 RID: 24532
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005FD5 RID: 24533
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005FD6 RID: 24534
			private static readonly IntPtr NativeFieldInfoPtr__gameLogID_5__3;

			// Token: 0x04005FD7 RID: 24535
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04005FD8 RID: 24536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005FD9 RID: 24537
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FDA RID: 24538
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005FDB RID: 24539
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005FDC RID: 24540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005FDD RID: 24541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FDE RID: 24542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005FDF RID: 24543
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005FE0 RID: 24544
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020009A4 RID: 2468
		[ObfuscatedName("worm.canis.abilities.ConflictAbilities.BaseSet.ShuttleFleetAcquiredAbility+<Targets>d__6")]
		public sealed class _Targets_d__6 : Object
		{
			// Token: 0x06009694 RID: 38548 RVA: 0x0027D120 File Offset: 0x0027B320
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "<>1__state");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "<>2__current");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "context");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "<>3__context");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, "<>4__this");
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675769);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675770);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675771);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675772);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675773);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675774);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675775);
				ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr, 100675776);
			}

			// Token: 0x06009695 RID: 38549 RVA: 0x0027D264 File Offset: 0x0027B464
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShuttleFleetAcquiredAbility._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009696 RID: 38550 RVA: 0x0027D2AC File Offset: 0x0027B4AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009697 RID: 38551 RVA: 0x0027D2E0 File Offset: 0x0027B4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203826, XrefRangeEnd = 203936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002CA4 RID: 11428
			// (get) Token: 0x06009698 RID: 38552 RVA: 0x0027D31C File Offset: 0x0027B51C
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06009699 RID: 38553 RVA: 0x0027D35C File Offset: 0x0027B55C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203936, XrefRangeEnd = 203941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002CA5 RID: 11429
			// (get) Token: 0x0600969A RID: 38554 RVA: 0x0027D390 File Offset: 0x0027B590
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600969B RID: 38555 RVA: 0x0027D3D0 File Offset: 0x0027B5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203941, XrefRangeEnd = 203950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600969C RID: 38556 RVA: 0x0027D410 File Offset: 0x0027B610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShuttleFleetAcquiredAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600969D RID: 38557 RVA: 0x00041E96 File Offset: 0x00040096
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002C9E RID: 11422
			// (get) Token: 0x0600969E RID: 38558 RVA: 0x0027D450 File Offset: 0x0027B650
			// (set) Token: 0x0600969F RID: 38559 RVA: 0x00041E9F File Offset: 0x0004009F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C9F RID: 11423
			// (get) Token: 0x060096A0 RID: 38560 RVA: 0x0027D478 File Offset: 0x0027B678
			// (set) Token: 0x060096A1 RID: 38561 RVA: 0x00041EBA File Offset: 0x000400BA
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CA0 RID: 11424
			// (get) Token: 0x060096A2 RID: 38562 RVA: 0x0027D4A8 File Offset: 0x0027B6A8
			// (set) Token: 0x060096A3 RID: 38563 RVA: 0x00041ED9 File Offset: 0x000400D9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002CA1 RID: 11425
			// (get) Token: 0x060096A4 RID: 38564 RVA: 0x0027D4D0 File Offset: 0x0027B6D0
			// (set) Token: 0x060096A5 RID: 38565 RVA: 0x00041EF4 File Offset: 0x000400F4
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CA2 RID: 11426
			// (get) Token: 0x060096A6 RID: 38566 RVA: 0x0027D500 File Offset: 0x0027B700
			// (set) Token: 0x060096A7 RID: 38567 RVA: 0x00041F13 File Offset: 0x00040113
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CA3 RID: 11427
			// (get) Token: 0x060096A8 RID: 38568 RVA: 0x0027D530 File Offset: 0x0027B730
			// (set) Token: 0x060096A9 RID: 38569 RVA: 0x00041F32 File Offset: 0x00040132
			public unsafe ShuttleFleetAcquiredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShuttleFleetAcquiredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShuttleFleetAcquiredAbility._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FE1 RID: 24545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005FE2 RID: 24546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005FE3 RID: 24547
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005FE4 RID: 24548
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005FE5 RID: 24549
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005FE6 RID: 24550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005FE7 RID: 24551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005FE8 RID: 24552
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FE9 RID: 24553
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005FEA RID: 24554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04005FEB RID: 24555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FEC RID: 24556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005FED RID: 24557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04005FEE RID: 24558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
