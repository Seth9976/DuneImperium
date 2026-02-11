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
using worm.canis.entities;

namespace worm.canis.abilities.SpaceAbilities.BaseSet
{
	// Token: 0x02000424 RID: 1060
	public class HeighlinerSpaceAbility : SpaceAbility
	{
		// Token: 0x06002DB6 RID: 11702 RVA: 0x00116578 File Offset: 0x00114778
		// Note: this type is marked as 'beforefieldinit'.
		static HeighlinerSpaceAbility()
		{
			Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.SpaceAbilities.BaseSet", "HeighlinerSpaceAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr);
			HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, "AbilityName");
			HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, "AbilityID");
			HeighlinerSpaceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676887);
			HeighlinerSpaceAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676888);
			HeighlinerSpaceAbility.NativeMethodInfoPtr_PayCost_Protected_Virtual_IEnumerable_1_Action_Context_WormActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676889);
			HeighlinerSpaceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676890);
			HeighlinerSpaceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676891);
			HeighlinerSpaceAbility.NativeMethodInfoPtr_GetSpiceReduction_Public_Static_Int32_ArchetypeID_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676892);
			HeighlinerSpaceAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, 100676893);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0011665C File Offset: 0x0011485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212145, XrefRangeEnd = 212149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeighlinerSpaceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x001166A8 File Offset: 0x001148A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212149, XrefRangeEnd = 212279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeighlinerSpaceAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00116718 File Offset: 0x00114918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212279, XrefRangeEnd = 212286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> PayCost(Context context, WormActiveAbility activeAbility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeighlinerSpaceAbility.NativeMethodInfoPtr_PayCost_Protected_Virtual_IEnumerable_1_Action_Context_WormActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00116788 File Offset: 0x00114988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212286, XrefRangeEnd = 212292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeighlinerSpaceAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x001167D4 File Offset: 0x001149D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212292, XrefRangeEnd = 212296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeighlinerSpaceAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00116844 File Offset: 0x00114A44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212311, RefRangeEnd = 212314, XrefRangeStart = 212296, XrefRangeEnd = 212311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSpiceReduction(ArchetypeID agentCard, ArchetypeID graftedCard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftedCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.NativeMethodInfoPtr_GetSpiceReduction_Public_Static_Int32_ArchetypeID_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00116898 File Offset: 0x00114A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212314, XrefRangeEnd = 212387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeighlinerSpaceAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000108B1 File Offset: 0x0000EAB1
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000108C0 File Offset: 0x0000EAC0
		public HeighlinerSpaceAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x00116914 File Offset: 0x00114B14
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x000108C9 File Offset: 0x0000EAC9
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x00116934 File Offset: 0x00114B34
		// (set) Token: 0x06002DC3 RID: 11715 RVA: 0x000108DB File Offset: 0x0000EADB
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeighlinerSpaceAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_PayCost_Protected_Virtual_IEnumerable_1_Action_Context_WormActiveAbility_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_GetSpiceReduction_Public_Static_Int32_ArchetypeID_ArchetypeID_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x020009F4 RID: 2548
		[ObfuscatedName("worm.canis.abilities.SpaceAbilities.BaseSet.HeighlinerSpaceAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009E55 RID: 40533 RVA: 0x00293B54 File Offset: 0x00291D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr);
				HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr, "<>9");
				HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr, "<>9__8_0");
				HeighlinerSpaceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr, 100676896);
				HeighlinerSpaceAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr, 100676897);
			}

			// Token: 0x06009E56 RID: 40534 RVA: 0x00293BD0 File Offset: 0x00291DD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E57 RID: 40535 RVA: 0x00293C0C File Offset: 0x00291E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212049, XrefRangeEnd = 212050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__8_0(WormPlayer op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009E58 RID: 40536 RVA: 0x000468CB File Offset: 0x00044ACB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002F91 RID: 12177
			// (get) Token: 0x06009E59 RID: 40537 RVA: 0x00293C5C File Offset: 0x00291E5C
			// (set) Token: 0x06009E5A RID: 40538 RVA: 0x000468D4 File Offset: 0x00044AD4
			public unsafe static HeighlinerSpaceAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeighlinerSpaceAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F92 RID: 12178
			// (get) Token: 0x06009E5B RID: 40539 RVA: 0x00293C84 File Offset: 0x00291E84
			// (set) Token: 0x06009E5C RID: 40540 RVA: 0x000468E6 File Offset: 0x00044AE6
			public unsafe static Func<WormPlayer, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HeighlinerSpaceAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400649B RID: 25755
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400649C RID: 25756
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400649D RID: 25757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400649E RID: 25758
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__8_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020009F5 RID: 2549
		[ObfuscatedName("worm.canis.abilities.SpaceAbilities.BaseSet.HeighlinerSpaceAbility+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06009E5D RID: 40541 RVA: 0x00293CAC File Offset: 0x00291EAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr);
				HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr, "agentCard");
				HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr, 100676898);
				HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeMethodInfoPtr__Cost_b__0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr, 100676899);
			}

			// Token: 0x06009E5E RID: 40542 RVA: 0x00293D14 File Offset: 0x00291F14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeighlinerSpaceAbility.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E5F RID: 40543 RVA: 0x00293D50 File Offset: 0x00291F50
			[CallerCount(0)]
			public unsafe bool _Cost_b__0(WormAgent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeMethodInfoPtr__Cost_b__0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009E60 RID: 40544 RVA: 0x000468F8 File Offset: 0x00044AF8
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002F93 RID: 12179
			// (get) Token: 0x06009E61 RID: 40545 RVA: 0x00293DA0 File Offset: 0x00291FA0
			// (set) Token: 0x06009E62 RID: 40546 RVA: 0x00046901 File Offset: 0x00044B01
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility.__c__DisplayClass3_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400649F RID: 25759
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x040064A0 RID: 25760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064A1 RID: 25761
			private static readonly IntPtr NativeMethodInfoPtr__Cost_b__0_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x020009F6 RID: 2550
		[ObfuscatedName("worm.canis.abilities.SpaceAbilities.BaseSet.HeighlinerSpaceAbility+<PayCost>d__4")]
		public sealed class _PayCost_d__4 : Object
		{
			// Token: 0x06009E63 RID: 40547 RVA: 0x00293DD0 File Offset: 0x00291FD0
			// Note: this type is marked as 'beforefieldinit'.
			static _PayCost_d__4()
			{
				Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeighlinerSpaceAbility>.NativeClassPtr, "<PayCost>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr);
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<>1__state");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<>2__current");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<>l__initialThreadId");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "context");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<>3__context");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<>4__this");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<player>5__2");
				HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__spiceCost_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, "<spiceCost>5__3");
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676900);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676901);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676902);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676903);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676904);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676905);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676906);
				HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr, 100676907);
			}

			// Token: 0x06009E64 RID: 40548 RVA: 0x00293F3C File Offset: 0x0029213C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PayCost_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeighlinerSpaceAbility._PayCost_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009E65 RID: 40549 RVA: 0x00293F84 File Offset: 0x00292184
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E66 RID: 40550 RVA: 0x00293FB8 File Offset: 0x002921B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212050, XrefRangeEnd = 212131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002F9C RID: 12188
			// (get) Token: 0x06009E67 RID: 40551 RVA: 0x00293FF4 File Offset: 0x002921F4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009E68 RID: 40552 RVA: 0x00294034 File Offset: 0x00292234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212131, XrefRangeEnd = 212136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002F9D RID: 12189
			// (get) Token: 0x06009E69 RID: 40553 RVA: 0x00294068 File Offset: 0x00292268
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009E6A RID: 40554 RVA: 0x002940A8 File Offset: 0x002922A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212136, XrefRangeEnd = 212145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009E6B RID: 40555 RVA: 0x002940E8 File Offset: 0x002922E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeighlinerSpaceAbility._PayCost_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009E6C RID: 40556 RVA: 0x00046920 File Offset: 0x00044B20
			public _PayCost_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002F94 RID: 12180
			// (get) Token: 0x06009E6D RID: 40557 RVA: 0x00294128 File Offset: 0x00292328
			// (set) Token: 0x06009E6E RID: 40558 RVA: 0x00046929 File Offset: 0x00044B29
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F95 RID: 12181
			// (get) Token: 0x06009E6F RID: 40559 RVA: 0x00294150 File Offset: 0x00292350
			// (set) Token: 0x06009E70 RID: 40560 RVA: 0x00046944 File Offset: 0x00044B44
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F96 RID: 12182
			// (get) Token: 0x06009E71 RID: 40561 RVA: 0x00294180 File Offset: 0x00292380
			// (set) Token: 0x06009E72 RID: 40562 RVA: 0x00046963 File Offset: 0x00044B63
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002F97 RID: 12183
			// (get) Token: 0x06009E73 RID: 40563 RVA: 0x002941A8 File Offset: 0x002923A8
			// (set) Token: 0x06009E74 RID: 40564 RVA: 0x0004697E File Offset: 0x00044B7E
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F98 RID: 12184
			// (get) Token: 0x06009E75 RID: 40565 RVA: 0x002941D8 File Offset: 0x002923D8
			// (set) Token: 0x06009E76 RID: 40566 RVA: 0x0004699D File Offset: 0x00044B9D
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F99 RID: 12185
			// (get) Token: 0x06009E77 RID: 40567 RVA: 0x00294208 File Offset: 0x00292408
			// (set) Token: 0x06009E78 RID: 40568 RVA: 0x000469BC File Offset: 0x00044BBC
			public unsafe HeighlinerSpaceAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeighlinerSpaceAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F9A RID: 12186
			// (get) Token: 0x06009E79 RID: 40569 RVA: 0x00294238 File Offset: 0x00292438
			// (set) Token: 0x06009E7A RID: 40570 RVA: 0x000469DB File Offset: 0x00044BDB
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F9B RID: 12187
			// (get) Token: 0x06009E7B RID: 40571 RVA: 0x00294268 File Offset: 0x00292468
			// (set) Token: 0x06009E7C RID: 40572 RVA: 0x000469FA File Offset: 0x00044BFA
			public unsafe int _spiceCost_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__spiceCost_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeighlinerSpaceAbility._PayCost_d__4.NativeFieldInfoPtr__spiceCost_5__3)) = value;
				}
			}

			// Token: 0x040064A2 RID: 25762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040064A3 RID: 25763
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040064A4 RID: 25764
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040064A5 RID: 25765
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040064A6 RID: 25766
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040064A7 RID: 25767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040064A8 RID: 25768
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040064A9 RID: 25769
			private static readonly IntPtr NativeFieldInfoPtr__spiceCost_5__3;

			// Token: 0x040064AA RID: 25770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040064AB RID: 25771
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040064AC RID: 25772
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040064AD RID: 25773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040064AE RID: 25774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040064AF RID: 25775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040064B0 RID: 25776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040064B1 RID: 25777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
