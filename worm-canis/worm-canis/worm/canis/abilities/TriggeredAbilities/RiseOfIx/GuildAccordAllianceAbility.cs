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
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.RiseOfIx
{
	// Token: 0x02000360 RID: 864
	public class GuildAccordAllianceAbility : AllianceAbility
	{
		// Token: 0x0600237D RID: 9085 RVA: 0x000E60F8 File Offset: 0x000E42F8
		// Note: this type is marked as 'beforefieldinit'.
		static GuildAccordAllianceAbility()
		{
			Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.RiseOfIx", "GuildAccordAllianceAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr);
			GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, "AbilityName");
			GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, "AbilityID");
			GuildAccordAllianceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672692);
			GuildAccordAllianceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672693);
			GuildAccordAllianceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672694);
			GuildAccordAllianceAbility.NativeMethodInfoPtr_get_AllianceFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672695);
			GuildAccordAllianceAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672696);
			GuildAccordAllianceAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672697);
			GuildAccordAllianceAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672698);
			GuildAccordAllianceAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, 100672699);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000E61F0 File Offset: 0x000E43F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184395, XrefRangeEnd = 184399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000E623C File Offset: 0x000E443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184399, XrefRangeEnd = 184412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAccordAllianceAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000E6288 File Offset: 0x000E4488
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuildAccordAllianceAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000E62F8 File Offset: 0x000E44F8
		public unsafe override Factions AllianceFaction
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_get_AllianceFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x000E6340 File Offset: 0x000E4540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184412, XrefRangeEnd = 184416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x000E63B0 File Offset: 0x000E45B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184416, XrefRangeEnd = 184424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x000E6430 File Offset: 0x000E4630
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x000E64AC File Offset: 0x000E46AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184424, XrefRangeEnd = 184439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuildAccordAllianceAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0000E18B File Offset: 0x0000C38B
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x0000E19A File Offset: 0x0000C39A
		public GuildAccordAllianceAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000E6528 File Offset: 0x000E4728
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x0000E1A3 File Offset: 0x0000C3A3
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000E6548 File Offset: 0x000E4748
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x0000E1B5 File Offset: 0x0000C3B5
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuildAccordAllianceAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_get_AllianceFaction_Public_Virtual_get_Factions_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x02000875 RID: 2165
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.GuildAccordAllianceAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06007D93 RID: 32147 RVA: 0x0023349C File Offset: 0x0023169C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr);
				GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr, "<>9");
				GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr, "<>9__8_0");
				GuildAccordAllianceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr, 100672702);
				GuildAccordAllianceAbility.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr, 100672703);
			}

			// Token: 0x06007D94 RID: 32148 RVA: 0x00233518 File Offset: 0x00231718
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAccordAllianceAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D95 RID: 32149 RVA: 0x00233554 File Offset: 0x00231754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184335, XrefRangeEnd = 184339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__8_0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06007D96 RID: 32150 RVA: 0x00033BC2 File Offset: 0x00031DC2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002384 RID: 9092
			// (get) Token: 0x06007D97 RID: 32151 RVA: 0x002335A4 File Offset: 0x002317A4
			// (set) Token: 0x06007D98 RID: 32152 RVA: 0x00033BCB File Offset: 0x00031DCB
			public unsafe static GuildAccordAllianceAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuildAccordAllianceAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002385 RID: 9093
			// (get) Token: 0x06007D99 RID: 32153 RVA: 0x002335CC File Offset: 0x002317CC
			// (set) Token: 0x06007D9A RID: 32154 RVA: 0x00033BDD File Offset: 0x00031DDD
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuildAccordAllianceAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040050AE RID: 20654
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040050AF RID: 20655
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040050B0 RID: 20656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040050B1 RID: 20657
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000876 RID: 2166
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.GuildAccordAllianceAbility+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x06007D9B RID: 32155 RVA: 0x002335F4 File Offset: 0x002317F4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuildAccordAllianceAbility>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "match");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, "<>4__this");
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672704);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672705);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672706);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672707);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672708);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672709);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672710);
				GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr, 100672711);
			}

			// Token: 0x06007D9C RID: 32156 RVA: 0x00233760 File Offset: 0x00231960
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuildAccordAllianceAbility._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007D9D RID: 32157 RVA: 0x002337A8 File Offset: 0x002319A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D9E RID: 32158 RVA: 0x002337DC File Offset: 0x002319DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184339, XrefRangeEnd = 184380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700238E RID: 9102
			// (get) Token: 0x06007D9F RID: 32159 RVA: 0x00233818 File Offset: 0x00231A18
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007DA0 RID: 32160 RVA: 0x00233858 File Offset: 0x00231A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184380, XrefRangeEnd = 184385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700238F RID: 9103
			// (get) Token: 0x06007DA1 RID: 32161 RVA: 0x0023388C File Offset: 0x00231A8C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007DA2 RID: 32162 RVA: 0x002338CC File Offset: 0x00231ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184385, XrefRangeEnd = 184395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007DA3 RID: 32163 RVA: 0x0023390C File Offset: 0x00231B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuildAccordAllianceAbility._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007DA4 RID: 32164 RVA: 0x00033BEF File Offset: 0x00031DEF
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002386 RID: 9094
			// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x0023394C File Offset: 0x00231B4C
			// (set) Token: 0x06007DA6 RID: 32166 RVA: 0x00033BF8 File Offset: 0x00031DF8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002387 RID: 9095
			// (get) Token: 0x06007DA7 RID: 32167 RVA: 0x00233974 File Offset: 0x00231B74
			// (set) Token: 0x06007DA8 RID: 32168 RVA: 0x00033C13 File Offset: 0x00031E13
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002388 RID: 9096
			// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x002339A4 File Offset: 0x00231BA4
			// (set) Token: 0x06007DAA RID: 32170 RVA: 0x00033C32 File Offset: 0x00031E32
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002389 RID: 9097
			// (get) Token: 0x06007DAB RID: 32171 RVA: 0x002339CC File Offset: 0x00231BCC
			// (set) Token: 0x06007DAC RID: 32172 RVA: 0x00033C4D File Offset: 0x00031E4D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700238A RID: 9098
			// (get) Token: 0x06007DAD RID: 32173 RVA: 0x002339FC File Offset: 0x00231BFC
			// (set) Token: 0x06007DAE RID: 32174 RVA: 0x00033C6C File Offset: 0x00031E6C
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700238B RID: 9099
			// (get) Token: 0x06007DAF RID: 32175 RVA: 0x00233A2C File Offset: 0x00231C2C
			// (set) Token: 0x06007DB0 RID: 32176 RVA: 0x00033C8B File Offset: 0x00031E8B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700238C RID: 9100
			// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x00233A5C File Offset: 0x00231C5C
			// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x00033CAA File Offset: 0x00031EAA
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700238D RID: 9101
			// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x00233A8C File Offset: 0x00231C8C
			// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x00033CC9 File Offset: 0x00031EC9
			public unsafe GuildAccordAllianceAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuildAccordAllianceAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuildAccordAllianceAbility._BeginExecution_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040050B2 RID: 20658
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040050B3 RID: 20659
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040050B4 RID: 20660
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040050B5 RID: 20661
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040050B6 RID: 20662
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040050B7 RID: 20663
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040050B8 RID: 20664
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040050B9 RID: 20665
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040050BA RID: 20666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040050BB RID: 20667
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040050BC RID: 20668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040050BD RID: 20669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040050BE RID: 20670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040050BF RID: 20671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040050C0 RID: 20672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040050C1 RID: 20673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
