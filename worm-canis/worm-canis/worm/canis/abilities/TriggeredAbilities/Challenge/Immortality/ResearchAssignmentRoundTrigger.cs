using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003A9 RID: 937
	public class ResearchAssignmentRoundTrigger : RuleModAbility
	{
		// Token: 0x06002723 RID: 10019 RVA: 0x000F744C File Offset: 0x000F564C
		// Note: this type is marked as 'beforefieldinit'.
		static ResearchAssignmentRoundTrigger()
		{
			Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "ResearchAssignmentRoundTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr);
			ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, "AbilityName");
			ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, "AbilityID");
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674468);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674469);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674470);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674471);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674472);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674473);
			ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_AddResearchAssignmentAbilityToCard_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, 100674474);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000F7530 File Offset: 0x000F5730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195156, XrefRangeEnd = 195160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000F757C File Offset: 0x000F577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195160, XrefRangeEnd = 195163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchAssignmentRoundTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000F75C8 File Offset: 0x000F57C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchAssignmentRoundTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000F7638 File Offset: 0x000F5838
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000F7680 File Offset: 0x000F5880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195163, XrefRangeEnd = 195176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000F76DC File Offset: 0x000F58DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195176, XrefRangeEnd = 195183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000F775C File Offset: 0x000F595C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195183, XrefRangeEnd = 195191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Canis.actions.Action> AddResearchAssignmentAbilityToCard(WormMatch match, WormPlayable card, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.NativeMethodInfoPtr_AddResearchAssignmentAbilityToCard_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayable_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0000EE71 File Offset: 0x0000D071
		public ResearchAssignmentRoundTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000F77C4 File Offset: 0x000F59C4
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000F77E4 File Offset: 0x000F59E4
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x0000EE8C File Offset: 0x0000D08C
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_AddResearchAssignmentAbilityToCard_Public_Static_IEnumerable_1_Action_WormMatch_WormPlayable_WormPlayer_0;

		// Token: 0x0200092D RID: 2349
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentRoundTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008C45 RID: 35909 RVA: 0x0025EA38 File Offset: 0x0025CC38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr);
				ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, "<>9");
				ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, "<>9__7_0");
				ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, "<>9__8_0");
				ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, "<>9__9_0");
				ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, 100674477);
				ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, 100674478);
				ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, 100674479);
				ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__AddResearchAssignmentAbilityToCard_b__9_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr, 100674480);
			}

			// Token: 0x06008C46 RID: 35910 RVA: 0x0025EB04 File Offset: 0x0025CD04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C47 RID: 35911 RVA: 0x0025EB40 File Offset: 0x0025CD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008C48 RID: 35912 RVA: 0x0025EB90 File Offset: 0x0025CD90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194820, XrefRangeEnd = 194822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__8_0(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008C49 RID: 35913 RVA: 0x0025EBE0 File Offset: 0x0025CDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194822, XrefRangeEnd = 194831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddResearchAssignmentAbilityToCard_b__9_0(WormAbilityDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger.__c.NativeMethodInfoPtr__AddResearchAssignmentAbilityToCard_b__9_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008C4A RID: 35914 RVA: 0x0003C02D File Offset: 0x0003A22D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028D6 RID: 10454
			// (get) Token: 0x06008C4B RID: 35915 RVA: 0x0025EC30 File Offset: 0x0025CE30
			// (set) Token: 0x06008C4C RID: 35916 RVA: 0x0003C036 File Offset: 0x0003A236
			public unsafe static ResearchAssignmentRoundTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResearchAssignmentRoundTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028D7 RID: 10455
			// (get) Token: 0x06008C4D RID: 35917 RVA: 0x0025EC58 File Offset: 0x0025CE58
			// (set) Token: 0x06008C4E RID: 35918 RVA: 0x0003C048 File Offset: 0x0003A248
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028D8 RID: 10456
			// (get) Token: 0x06008C4F RID: 35919 RVA: 0x0025EC80 File Offset: 0x0025CE80
			// (set) Token: 0x06008C50 RID: 35920 RVA: 0x0003C05A File Offset: 0x0003A25A
			public unsafe static Predicate<Entity> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028D9 RID: 10457
			// (get) Token: 0x06008C51 RID: 35921 RVA: 0x0025ECA8 File Offset: 0x0025CEA8
			// (set) Token: 0x06008C52 RID: 35922 RVA: 0x0003C06C File Offset: 0x0003A26C
			public unsafe static Func<WormAbilityDefinition, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentRoundTrigger.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005998 RID: 22936
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005999 RID: 22937
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400599A RID: 22938
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400599B RID: 22939
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400599C RID: 22940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400599D RID: 22941
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400599E RID: 22942
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__8_0_Internal_Boolean_Entity_0;

			// Token: 0x0400599F RID: 22943
			private static readonly IntPtr NativeMethodInfoPtr__AddResearchAssignmentAbilityToCard_b__9_0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x0200092E RID: 2350
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentRoundTrigger+<AddResearchAssignmentAbilityToCard>d__9")]
		public sealed class _AddResearchAssignmentAbilityToCard_d__9 : Object
		{
			// Token: 0x06008C53 RID: 35923 RVA: 0x0025ECD0 File Offset: 0x0025CED0
			// Note: this type is marked as 'beforefieldinit'.
			static _AddResearchAssignmentAbilityToCard_d__9()
			{
				Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, "<AddResearchAssignmentAbilityToCard>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>1__state");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>2__current");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>l__initialThreadId");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "match");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>3__match");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "card");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>3__card");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "player");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>3__player");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, "<>7__wrap1");
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674481);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674482);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674483);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674484);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674485);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674486);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674487);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674488);
				ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr, 100674489);
			}

			// Token: 0x06008C54 RID: 35924 RVA: 0x0025EE78 File Offset: 0x0025D078
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddResearchAssignmentAbilityToCard_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008C55 RID: 35925 RVA: 0x0025EEC0 File Offset: 0x0025D0C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194831, XrefRangeEnd = 194836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C56 RID: 35926 RVA: 0x0025EEF4 File Offset: 0x0025D0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194836, XrefRangeEnd = 194994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C57 RID: 35927 RVA: 0x0025EF30 File Offset: 0x0025D130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194994, XrefRangeEnd = 194997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028E4 RID: 10468
			// (get) Token: 0x06008C58 RID: 35928 RVA: 0x0025EF64 File Offset: 0x0025D164
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008C59 RID: 35929 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194997, XrefRangeEnd = 195002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028E5 RID: 10469
			// (get) Token: 0x06008C5A RID: 35930 RVA: 0x0025EFD8 File Offset: 0x0025D1D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008C5B RID: 35931 RVA: 0x0025F018 File Offset: 0x0025D218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195002, XrefRangeEnd = 195012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008C5C RID: 35932 RVA: 0x0025F058 File Offset: 0x0025D258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008C5D RID: 35933 RVA: 0x0003C07E File Offset: 0x0003A27E
			public _AddResearchAssignmentAbilityToCard_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028DA RID: 10458
			// (get) Token: 0x06008C5E RID: 35934 RVA: 0x0025F098 File Offset: 0x0025D298
			// (set) Token: 0x06008C5F RID: 35935 RVA: 0x0003C087 File Offset: 0x0003A287
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170028DB RID: 10459
			// (get) Token: 0x06008C60 RID: 35936 RVA: 0x0025F0C0 File Offset: 0x0025D2C0
			// (set) Token: 0x06008C61 RID: 35937 RVA: 0x0003C0A2 File Offset: 0x0003A2A2
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028DC RID: 10460
			// (get) Token: 0x06008C62 RID: 35938 RVA: 0x0025F0F0 File Offset: 0x0025D2F0
			// (set) Token: 0x06008C63 RID: 35939 RVA: 0x0003C0C1 File Offset: 0x0003A2C1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170028DD RID: 10461
			// (get) Token: 0x06008C64 RID: 35940 RVA: 0x0025F118 File Offset: 0x0025D318
			// (set) Token: 0x06008C65 RID: 35941 RVA: 0x0003C0DC File Offset: 0x0003A2DC
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028DE RID: 10462
			// (get) Token: 0x06008C66 RID: 35942 RVA: 0x0025F148 File Offset: 0x0025D348
			// (set) Token: 0x06008C67 RID: 35943 RVA: 0x0003C0FB File Offset: 0x0003A2FB
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028DF RID: 10463
			// (get) Token: 0x06008C68 RID: 35944 RVA: 0x0025F178 File Offset: 0x0025D378
			// (set) Token: 0x06008C69 RID: 35945 RVA: 0x0003C11A File Offset: 0x0003A31A
			public unsafe WormPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028E0 RID: 10464
			// (get) Token: 0x06008C6A RID: 35946 RVA: 0x0025F1A8 File Offset: 0x0025D3A8
			// (set) Token: 0x06008C6B RID: 35947 RVA: 0x0003C139 File Offset: 0x0003A339
			public unsafe WormPlayable __3__card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028E1 RID: 10465
			// (get) Token: 0x06008C6C RID: 35948 RVA: 0x0025F1D8 File Offset: 0x0025D3D8
			// (set) Token: 0x06008C6D RID: 35949 RVA: 0x0003C158 File Offset: 0x0003A358
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028E2 RID: 10466
			// (get) Token: 0x06008C6E RID: 35950 RVA: 0x0025F208 File Offset: 0x0025D408
			// (set) Token: 0x06008C6F RID: 35951 RVA: 0x0003C177 File Offset: 0x0003A377
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028E3 RID: 10467
			// (get) Token: 0x06008C70 RID: 35952 RVA: 0x0025F238 File Offset: 0x0025D438
			// (set) Token: 0x06008C71 RID: 35953 RVA: 0x0003C196 File Offset: 0x0003A396
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._AddResearchAssignmentAbilityToCard_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040059A0 RID: 22944
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040059A1 RID: 22945
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040059A2 RID: 22946
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040059A3 RID: 22947
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040059A4 RID: 22948
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040059A5 RID: 22949
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x040059A6 RID: 22950
			private static readonly IntPtr NativeFieldInfoPtr___3__card;

			// Token: 0x040059A7 RID: 22951
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040059A8 RID: 22952
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040059A9 RID: 22953
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040059AA RID: 22954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040059AB RID: 22955
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059AC RID: 22956
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040059AD RID: 22957
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040059AE RID: 22958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040059AF RID: 22959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059B0 RID: 22960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040059B1 RID: 22961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040059B2 RID: 22962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200092F RID: 2351
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentRoundTrigger+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x06008C72 RID: 35954 RVA: 0x0025F268 File Offset: 0x0025D468
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "match");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<player>5__2");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__cards_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<cards>5__3");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__gameRound_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<gameRound>5__4");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>7__wrap4");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>7__wrap5");
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674490);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674491);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674492);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674493);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674494);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674495);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674496);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674497);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674498);
				ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674499);
			}

			// Token: 0x06008C73 RID: 35955 RVA: 0x0025F44C File Offset: 0x0025D64C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentRoundTrigger._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008C74 RID: 35956 RVA: 0x0025F494 File Offset: 0x0025D694
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C75 RID: 35957 RVA: 0x0025F4C8 File Offset: 0x0025D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195012, XrefRangeEnd = 195136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C76 RID: 35958 RVA: 0x0025F504 File Offset: 0x0025D704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195136, XrefRangeEnd = 195139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C77 RID: 35959 RVA: 0x0025F538 File Offset: 0x0025D738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195139, XrefRangeEnd = 195142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028F2 RID: 10482
			// (get) Token: 0x06008C78 RID: 35960 RVA: 0x0025F56C File Offset: 0x0025D76C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008C79 RID: 35961 RVA: 0x0025F5AC File Offset: 0x0025D7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195142, XrefRangeEnd = 195147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028F3 RID: 10483
			// (get) Token: 0x06008C7A RID: 35962 RVA: 0x0025F5E0 File Offset: 0x0025D7E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008C7B RID: 35963 RVA: 0x0025F620 File Offset: 0x0025D820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195147, XrefRangeEnd = 195156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008C7C RID: 35964 RVA: 0x0025F660 File Offset: 0x0025D860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008C7D RID: 35965 RVA: 0x0003C1B5 File Offset: 0x0003A3B5
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028E6 RID: 10470
			// (get) Token: 0x06008C7E RID: 35966 RVA: 0x0025F6A0 File Offset: 0x0025D8A0
			// (set) Token: 0x06008C7F RID: 35967 RVA: 0x0003C1BE File Offset: 0x0003A3BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170028E7 RID: 10471
			// (get) Token: 0x06008C80 RID: 35968 RVA: 0x0025F6C8 File Offset: 0x0025D8C8
			// (set) Token: 0x06008C81 RID: 35969 RVA: 0x0003C1D9 File Offset: 0x0003A3D9
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028E8 RID: 10472
			// (get) Token: 0x06008C82 RID: 35970 RVA: 0x0025F6F8 File Offset: 0x0025D8F8
			// (set) Token: 0x06008C83 RID: 35971 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170028E9 RID: 10473
			// (get) Token: 0x06008C84 RID: 35972 RVA: 0x0025F720 File Offset: 0x0025D920
			// (set) Token: 0x06008C85 RID: 35973 RVA: 0x0003C213 File Offset: 0x0003A413
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028EA RID: 10474
			// (get) Token: 0x06008C86 RID: 35974 RVA: 0x0025F750 File Offset: 0x0025D950
			// (set) Token: 0x06008C87 RID: 35975 RVA: 0x0003C232 File Offset: 0x0003A432
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028EB RID: 10475
			// (get) Token: 0x06008C88 RID: 35976 RVA: 0x0025F780 File Offset: 0x0025D980
			// (set) Token: 0x06008C89 RID: 35977 RVA: 0x0003C251 File Offset: 0x0003A451
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028EC RID: 10476
			// (get) Token: 0x06008C8A RID: 35978 RVA: 0x0025F7B0 File Offset: 0x0025D9B0
			// (set) Token: 0x06008C8B RID: 35979 RVA: 0x0003C270 File Offset: 0x0003A470
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028ED RID: 10477
			// (get) Token: 0x06008C8C RID: 35980 RVA: 0x0025F7E0 File Offset: 0x0025D9E0
			// (set) Token: 0x06008C8D RID: 35981 RVA: 0x0003C28F File Offset: 0x0003A48F
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028EE RID: 10478
			// (get) Token: 0x06008C8E RID: 35982 RVA: 0x0025F810 File Offset: 0x0025DA10
			// (set) Token: 0x06008C8F RID: 35983 RVA: 0x0003C2AE File Offset: 0x0003A4AE
			public unsafe List<Entity> _cards_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__cards_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__cards_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028EF RID: 10479
			// (get) Token: 0x06008C90 RID: 35984 RVA: 0x0025F840 File Offset: 0x0025DA40
			// (set) Token: 0x06008C91 RID: 35985 RVA: 0x0003C2CD File Offset: 0x0003A4CD
			public unsafe int _gameRound_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__gameRound_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__gameRound_5__4)) = value;
				}
			}

			// Token: 0x170028F0 RID: 10480
			// (get) Token: 0x06008C92 RID: 35986 RVA: 0x0025F868 File Offset: 0x0025DA68
			// (set) Token: 0x06008C93 RID: 35987 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
			public unsafe IEnumerator<WormPlayer> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028F1 RID: 10481
			// (get) Token: 0x06008C94 RID: 35988 RVA: 0x0025F898 File Offset: 0x0025DA98
			// (set) Token: 0x06008C95 RID: 35989 RVA: 0x0003C307 File Offset: 0x0003A507
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040059B3 RID: 22963
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040059B4 RID: 22964
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040059B5 RID: 22965
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040059B6 RID: 22966
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040059B7 RID: 22967
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040059B8 RID: 22968
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040059B9 RID: 22969
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040059BA RID: 22970
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040059BB RID: 22971
			private static readonly IntPtr NativeFieldInfoPtr__cards_5__3;

			// Token: 0x040059BC RID: 22972
			private static readonly IntPtr NativeFieldInfoPtr__gameRound_5__4;

			// Token: 0x040059BD RID: 22973
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040059BE RID: 22974
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040059BF RID: 22975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040059C0 RID: 22976
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059C1 RID: 22977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040059C2 RID: 22978
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040059C3 RID: 22979
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040059C4 RID: 22980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040059C5 RID: 22981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059C6 RID: 22982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040059C7 RID: 22983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040059C8 RID: 22984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
