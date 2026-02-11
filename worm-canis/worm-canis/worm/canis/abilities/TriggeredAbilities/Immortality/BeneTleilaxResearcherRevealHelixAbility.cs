using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.events;
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
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Immortality
{
	// Token: 0x02000374 RID: 884
	public class BeneTleilaxResearcherRevealHelixAbility : TriggeredAbility
	{
		// Token: 0x060024B9 RID: 9401 RVA: 0x000EC654 File Offset: 0x000EA854
		// Note: this type is marked as 'beforefieldinit'.
		static BeneTleilaxResearcherRevealHelixAbility()
		{
			Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Immortality", "BeneTleilaxResearcherRevealHelixAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr);
			BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, "AbilityName");
			BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, "AbilityID");
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673277);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673278);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673279);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673280);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673281);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673282);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673283);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673284);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673285);
			BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__BeginExecution_b__9_0_Private_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, 100673287);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000EC774 File Offset: 0x000EA974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187810, XrefRangeEnd = 187814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000EC7C0 File Offset: 0x000EA9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187814, XrefRangeEnd = 187828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneTleilaxResearcherRevealHelixAbility(WormMatch m, string name = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000EC820 File Offset: 0x000EAA20
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneTleilaxResearcherRevealHelixAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000EC890 File Offset: 0x000EAA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187828, XrefRangeEnd = 187832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000EC900 File Offset: 0x000EAB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187832, XrefRangeEnd = 187839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000EC950 File Offset: 0x000EAB50
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000EC998 File Offset: 0x000EAB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187839, XrefRangeEnd = 187847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000ECA18 File Offset: 0x000EAC18
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000ECA94 File Offset: 0x000EAC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187847, XrefRangeEnd = 187862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000ECB10 File Offset: 0x000EAD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187862, XrefRangeEnd = 187869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder _BeginExecution_b__9_0(GameLogBuilder _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility.NativeMethodInfoPtr__BeginExecution_b__9_0_Private_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0000E587 File Offset: 0x0000C787
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0000E596 File Offset: 0x0000C796
		public BeneTleilaxResearcherRevealHelixAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000ECB60 File Offset: 0x000EAD60
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000E59F File Offset: 0x0000C79F
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000ECB80 File Offset: 0x000EAD80
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0000E5B1 File Offset: 0x0000C7B1
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneTleilaxResearcherRevealHelixAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__9_0_Private_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x020008B0 RID: 2224
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Immortality.BeneTleilaxResearcherRevealHelixAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600823F RID: 33343 RVA: 0x002410BC File Offset: 0x0023F2BC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673288);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673289);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673290);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673291);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673292);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673293);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673294);
				BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr, 100673295);
			}

			// Token: 0x06008240 RID: 33344 RVA: 0x00241228 File Offset: 0x0023F428
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008241 RID: 33345 RVA: 0x00241270 File Offset: 0x0023F470
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008242 RID: 33346 RVA: 0x002412A4 File Offset: 0x0023F4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187739, XrefRangeEnd = 187761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002540 RID: 9536
			// (get) Token: 0x06008243 RID: 33347 RVA: 0x002412E0 File Offset: 0x0023F4E0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008244 RID: 33348 RVA: 0x00241320 File Offset: 0x0023F520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187761, XrefRangeEnd = 187766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002541 RID: 9537
			// (get) Token: 0x06008245 RID: 33349 RVA: 0x00241354 File Offset: 0x0023F554
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008246 RID: 33350 RVA: 0x00241394 File Offset: 0x0023F594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187766, XrefRangeEnd = 187776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008247 RID: 33351 RVA: 0x002413D4 File Offset: 0x0023F5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008248 RID: 33352 RVA: 0x000366A8 File Offset: 0x000348A8
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002538 RID: 9528
			// (get) Token: 0x06008249 RID: 33353 RVA: 0x00241414 File Offset: 0x0023F614
			// (set) Token: 0x0600824A RID: 33354 RVA: 0x000366B1 File Offset: 0x000348B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002539 RID: 9529
			// (get) Token: 0x0600824B RID: 33355 RVA: 0x0024143C File Offset: 0x0023F63C
			// (set) Token: 0x0600824C RID: 33356 RVA: 0x000366CC File Offset: 0x000348CC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700253A RID: 9530
			// (get) Token: 0x0600824D RID: 33357 RVA: 0x0024146C File Offset: 0x0023F66C
			// (set) Token: 0x0600824E RID: 33358 RVA: 0x000366EB File Offset: 0x000348EB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700253B RID: 9531
			// (get) Token: 0x0600824F RID: 33359 RVA: 0x00241494 File Offset: 0x0023F694
			// (set) Token: 0x06008250 RID: 33360 RVA: 0x00036706 File Offset: 0x00034906
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700253C RID: 9532
			// (get) Token: 0x06008251 RID: 33361 RVA: 0x002414C4 File Offset: 0x0023F6C4
			// (set) Token: 0x06008252 RID: 33362 RVA: 0x00036725 File Offset: 0x00034925
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700253D RID: 9533
			// (get) Token: 0x06008253 RID: 33363 RVA: 0x002414F4 File Offset: 0x0023F6F4
			// (set) Token: 0x06008254 RID: 33364 RVA: 0x00036744 File Offset: 0x00034944
			public unsafe BeneTleilaxResearcherRevealHelixAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeneTleilaxResearcherRevealHelixAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700253E RID: 9534
			// (get) Token: 0x06008255 RID: 33365 RVA: 0x00241524 File Offset: 0x0023F724
			// (set) Token: 0x06008256 RID: 33366 RVA: 0x00036763 File Offset: 0x00034963
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700253F RID: 9535
			// (get) Token: 0x06008257 RID: 33367 RVA: 0x00241554 File Offset: 0x0023F754
			// (set) Token: 0x06008258 RID: 33368 RVA: 0x00036782 File Offset: 0x00034982
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005382 RID: 21378
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005383 RID: 21379
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005384 RID: 21380
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005385 RID: 21381
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005386 RID: 21382
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005387 RID: 21383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005388 RID: 21384
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005389 RID: 21385
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400538A RID: 21386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400538B RID: 21387
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400538C RID: 21388
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400538D RID: 21389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400538E RID: 21390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400538F RID: 21391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005390 RID: 21392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005391 RID: 21393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020008B1 RID: 2225
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Immortality.BeneTleilaxResearcherRevealHelixAbility+<IsValidFor>d__6")]
		public sealed class _IsValidFor_d__6 : Object
		{
			// Token: 0x06008259 RID: 33369 RVA: 0x00241584 File Offset: 0x0023F784
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__6()
			{
				Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility>.NativeClassPtr, "<IsValidFor>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "<>1__state");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "<>2__current");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "<>l__initialThreadId");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "evt");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "<>3__evt");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, "<>4__this");
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673296);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673297);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673298);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673299);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673300);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673301);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673302);
				BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr, 100673303);
			}

			// Token: 0x0600825A RID: 33370 RVA: 0x002416C8 File Offset: 0x0023F8C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600825B RID: 33371 RVA: 0x00241710 File Offset: 0x0023F910
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600825C RID: 33372 RVA: 0x00241744 File Offset: 0x0023F944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187776, XrefRangeEnd = 187796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002548 RID: 9544
			// (get) Token: 0x0600825D RID: 33373 RVA: 0x00241780 File Offset: 0x0023F980
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600825E RID: 33374 RVA: 0x002417C0 File Offset: 0x0023F9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187796, XrefRangeEnd = 187801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002549 RID: 9545
			// (get) Token: 0x0600825F RID: 33375 RVA: 0x002417F4 File Offset: 0x0023F9F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008260 RID: 33376 RVA: 0x00241834 File Offset: 0x0023FA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187801, XrefRangeEnd = 187810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008261 RID: 33377 RVA: 0x00241874 File Offset: 0x0023FA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008262 RID: 33378 RVA: 0x000367A1 File Offset: 0x000349A1
			public _IsValidFor_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002542 RID: 9538
			// (get) Token: 0x06008263 RID: 33379 RVA: 0x002418B4 File Offset: 0x0023FAB4
			// (set) Token: 0x06008264 RID: 33380 RVA: 0x000367AA File Offset: 0x000349AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002543 RID: 9539
			// (get) Token: 0x06008265 RID: 33381 RVA: 0x002418DC File Offset: 0x0023FADC
			// (set) Token: 0x06008266 RID: 33382 RVA: 0x000367C5 File Offset: 0x000349C5
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002544 RID: 9540
			// (get) Token: 0x06008267 RID: 33383 RVA: 0x0024190C File Offset: 0x0023FB0C
			// (set) Token: 0x06008268 RID: 33384 RVA: 0x000367E4 File Offset: 0x000349E4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002545 RID: 9541
			// (get) Token: 0x06008269 RID: 33385 RVA: 0x00241934 File Offset: 0x0023FB34
			// (set) Token: 0x0600826A RID: 33386 RVA: 0x000367FF File Offset: 0x000349FF
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002546 RID: 9542
			// (get) Token: 0x0600826B RID: 33387 RVA: 0x00241964 File Offset: 0x0023FB64
			// (set) Token: 0x0600826C RID: 33388 RVA: 0x0003681E File Offset: 0x00034A1E
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002547 RID: 9543
			// (get) Token: 0x0600826D RID: 33389 RVA: 0x00241994 File Offset: 0x0023FB94
			// (set) Token: 0x0600826E RID: 33390 RVA: 0x0003683D File Offset: 0x00034A3D
			public unsafe BeneTleilaxResearcherRevealHelixAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeneTleilaxResearcherRevealHelixAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeneTleilaxResearcherRevealHelixAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005392 RID: 21394
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005393 RID: 21395
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005394 RID: 21396
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005395 RID: 21397
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04005396 RID: 21398
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04005397 RID: 21399
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005398 RID: 21400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005399 RID: 21401
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400539A RID: 21402
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400539B RID: 21403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x0400539C RID: 21404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400539D RID: 21405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400539E RID: 21406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x0400539F RID: 21407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
