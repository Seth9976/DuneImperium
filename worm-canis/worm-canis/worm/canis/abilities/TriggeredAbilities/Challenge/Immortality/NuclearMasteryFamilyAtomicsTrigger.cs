using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
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
using Networking.selection.targetinformation;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003A4 RID: 932
	public class NuclearMasteryFamilyAtomicsTrigger : RuleModAbility
	{
		// Token: 0x060026EB RID: 9963 RVA: 0x000F6518 File Offset: 0x000F4718
		// Note: this type is marked as 'beforefieldinit'.
		static NuclearMasteryFamilyAtomicsTrigger()
		{
			Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "NuclearMasteryFamilyAtomicsTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr);
			NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "AbilityName");
			NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "AbilityID");
			NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AcquireLogKeyPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "AcquireLogKeyPrefix");
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674365);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674366);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674367);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674368);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674369);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674370);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674371);
			NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_ActionLogReplacement_Private_Static_String_AcquireEffects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, 100674372);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000F6624 File Offset: 0x000F4824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194433, XrefRangeEnd = 194437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000F6670 File Offset: 0x000F4870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194437, XrefRangeEnd = 194440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NuclearMasteryFamilyAtomicsTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000F66BC File Offset: 0x000F48BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NuclearMasteryFamilyAtomicsTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000F672C File Offset: 0x000F492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194440, XrefRangeEnd = 194446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000F6788 File Offset: 0x000F4988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194446, XrefRangeEnd = 194453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000F67F8 File Offset: 0x000F49F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194453, XrefRangeEnd = 194462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000F6878 File Offset: 0x000F4A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194462, XrefRangeEnd = 194517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000F68D4 File Offset: 0x000F4AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194517, XrefRangeEnd = 194552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ActionLogReplacement(AcquireEffects effect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref effect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.NativeMethodInfoPtr_ActionLogReplacement_Private_Static_String_AcquireEffects_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0000EDA2 File Offset: 0x0000CFA2
		public NuclearMasteryFamilyAtomicsTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000F690C File Offset: 0x000F4B0C
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x0000EDAB File Offset: 0x0000CFAB
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000F692C File Offset: 0x000F4B2C
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x0000EDBD File Offset: 0x0000CFBD
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000F6954 File Offset: 0x000F4B54
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x0000EDCF File Offset: 0x0000CFCF
		public unsafe static string AcquireLogKeyPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AcquireLogKeyPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.NativeFieldInfoPtr_AcquireLogKeyPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeFieldInfoPtr_AcquireLogKeyPrefix;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_ActionLogReplacement_Private_Static_String_AcquireEffects_0;

		// Token: 0x02000923 RID: 2339
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryFamilyAtomicsTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008B67 RID: 35687 RVA: 0x0025C188 File Offset: 0x0025A388
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr);
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, "<>9");
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, "<>9__6_0");
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, "<>9__6_1");
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, "<>9__6_2");
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, "<>9__6_3");
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, 100674375);
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, 100674376);
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, 100674377);
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_EntityID_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, 100674378);
				NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_3_Internal_ReadOnlyAttributes_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr, 100674379);
			}

			// Token: 0x06008B68 RID: 35688 RVA: 0x0025C27C File Offset: 0x0025A47C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B69 RID: 35689 RVA: 0x0025C2B8 File Offset: 0x0025A4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193970, XrefRangeEnd = 193979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__6_0(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008B6A RID: 35690 RVA: 0x0025C308 File Offset: 0x0025A508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__6_1(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008B6B RID: 35691 RVA: 0x0025C358 File Offset: 0x0025A558
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__6_2(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_EntityID_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06008B6C RID: 35692 RVA: 0x0025C3A8 File Offset: 0x0025A5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193979, XrefRangeEnd = 193999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__6_3(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger.__c.NativeMethodInfoPtr__Targets_b__6_3_Internal_ReadOnlyAttributes_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x06008B6D RID: 35693 RVA: 0x0003B83E File Offset: 0x00039A3E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002885 RID: 10373
			// (get) Token: 0x06008B6E RID: 35694 RVA: 0x0025C3F8 File Offset: 0x0025A5F8
			// (set) Token: 0x06008B6F RID: 35695 RVA: 0x0003B847 File Offset: 0x00039A47
			public unsafe static NuclearMasteryFamilyAtomicsTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NuclearMasteryFamilyAtomicsTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002886 RID: 10374
			// (get) Token: 0x06008B70 RID: 35696 RVA: 0x0025C420 File Offset: 0x0025A620
			// (set) Token: 0x06008B71 RID: 35697 RVA: 0x0003B859 File Offset: 0x00039A59
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002887 RID: 10375
			// (get) Token: 0x06008B72 RID: 35698 RVA: 0x0025C448 File Offset: 0x0025A648
			// (set) Token: 0x06008B73 RID: 35699 RVA: 0x0003B86B File Offset: 0x00039A6B
			public unsafe static Func<WormFactionTrack, bool> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002888 RID: 10376
			// (get) Token: 0x06008B74 RID: 35700 RVA: 0x0025C470 File Offset: 0x0025A670
			// (set) Token: 0x06008B75 RID: 35701 RVA: 0x0003B87D File Offset: 0x00039A7D
			public unsafe static Func<WormFactionTrack, EntityID> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002889 RID: 10377
			// (get) Token: 0x06008B76 RID: 35702 RVA: 0x0025C498 File Offset: 0x0025A698
			// (set) Token: 0x06008B77 RID: 35703 RVA: 0x0003B88F File Offset: 0x00039A8F
			public unsafe static Func<WormFactionTrack, ReadOnlyAttributes> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryFamilyAtomicsTrigger.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005911 RID: 22801
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005912 RID: 22802
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04005913 RID: 22803
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04005914 RID: 22804
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04005915 RID: 22805
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04005916 RID: 22806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005917 RID: 22807
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_Entity_0;

			// Token: 0x04005918 RID: 22808
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_1_Internal_Boolean_WormFactionTrack_0;

			// Token: 0x04005919 RID: 22809
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_2_Internal_EntityID_WormFactionTrack_0;

			// Token: 0x0400591A RID: 22810
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_3_Internal_ReadOnlyAttributes_WormFactionTrack_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryFamilyAtomicsTrigger+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x06008B78 RID: 35704 RVA: 0x0025C4C0 File Offset: 0x0025A6C0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "context");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__context");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>4__this");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "match");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<player>5__2");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap2");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap3");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__card_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<card>5__5");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__specialLog_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<specialLog>5__6");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap6");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__acquireEffect_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<acquireEffect>5__8");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap8");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__rowCard_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, "<rowCard>5__10");
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674380);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674381);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674382);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674383);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674384);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674385);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674386);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674387);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674388);
				NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr, 100674389);
			}

			// Token: 0x06008B79 RID: 35705 RVA: 0x0025C730 File Offset: 0x0025A930
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008B7A RID: 35706 RVA: 0x0025C778 File Offset: 0x0025A978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193999, XrefRangeEnd = 194009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B7B RID: 35707 RVA: 0x0025C7AC File Offset: 0x0025A9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194009, XrefRangeEnd = 194240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008B7C RID: 35708 RVA: 0x0025C7E8 File Offset: 0x0025A9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194240, XrefRangeEnd = 194243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B7D RID: 35709 RVA: 0x0025C81C File Offset: 0x0025AA1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 194246, RefRangeEnd = 194247, XrefRangeStart = 194243, XrefRangeEnd = 194246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700289D RID: 10397
			// (get) Token: 0x06008B7E RID: 35710 RVA: 0x0025C850 File Offset: 0x0025AA50
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008B7F RID: 35711 RVA: 0x0025C890 File Offset: 0x0025AA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194247, XrefRangeEnd = 194252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700289E RID: 10398
			// (get) Token: 0x06008B80 RID: 35712 RVA: 0x0025C8C4 File Offset: 0x0025AAC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B81 RID: 35713 RVA: 0x0025C904 File Offset: 0x0025AB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194252, XrefRangeEnd = 194263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008B82 RID: 35714 RVA: 0x0025C944 File Offset: 0x0025AB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008B83 RID: 35715 RVA: 0x0003B8A1 File Offset: 0x00039AA1
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700288A RID: 10378
			// (get) Token: 0x06008B84 RID: 35716 RVA: 0x0025C984 File Offset: 0x0025AB84
			// (set) Token: 0x06008B85 RID: 35717 RVA: 0x0003B8AA File Offset: 0x00039AAA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700288B RID: 10379
			// (get) Token: 0x06008B86 RID: 35718 RVA: 0x0025C9AC File Offset: 0x0025ABAC
			// (set) Token: 0x06008B87 RID: 35719 RVA: 0x0003B8C5 File Offset: 0x00039AC5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700288C RID: 10380
			// (get) Token: 0x06008B88 RID: 35720 RVA: 0x0025C9DC File Offset: 0x0025ABDC
			// (set) Token: 0x06008B89 RID: 35721 RVA: 0x0003B8E4 File Offset: 0x00039AE4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700288D RID: 10381
			// (get) Token: 0x06008B8A RID: 35722 RVA: 0x0025CA04 File Offset: 0x0025AC04
			// (set) Token: 0x06008B8B RID: 35723 RVA: 0x0003B8FF File Offset: 0x00039AFF
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700288E RID: 10382
			// (get) Token: 0x06008B8C RID: 35724 RVA: 0x0025CA34 File Offset: 0x0025AC34
			// (set) Token: 0x06008B8D RID: 35725 RVA: 0x0003B91E File Offset: 0x00039B1E
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700288F RID: 10383
			// (get) Token: 0x06008B8E RID: 35726 RVA: 0x0025CA64 File Offset: 0x0025AC64
			// (set) Token: 0x06008B8F RID: 35727 RVA: 0x0003B93D File Offset: 0x00039B3D
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002890 RID: 10384
			// (get) Token: 0x06008B90 RID: 35728 RVA: 0x0025CA94 File Offset: 0x0025AC94
			// (set) Token: 0x06008B91 RID: 35729 RVA: 0x0003B95C File Offset: 0x00039B5C
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002891 RID: 10385
			// (get) Token: 0x06008B92 RID: 35730 RVA: 0x0025CAC4 File Offset: 0x0025ACC4
			// (set) Token: 0x06008B93 RID: 35731 RVA: 0x0003B97B File Offset: 0x00039B7B
			public unsafe NuclearMasteryFamilyAtomicsTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NuclearMasteryFamilyAtomicsTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002892 RID: 10386
			// (get) Token: 0x06008B94 RID: 35732 RVA: 0x0025CAF4 File Offset: 0x0025ACF4
			// (set) Token: 0x06008B95 RID: 35733 RVA: 0x0003B99A File Offset: 0x00039B9A
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002893 RID: 10387
			// (get) Token: 0x06008B96 RID: 35734 RVA: 0x0025CB24 File Offset: 0x0025AD24
			// (set) Token: 0x06008B97 RID: 35735 RVA: 0x0003B9B9 File Offset: 0x00039BB9
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002894 RID: 10388
			// (get) Token: 0x06008B98 RID: 35736 RVA: 0x0025CB54 File Offset: 0x0025AD54
			// (set) Token: 0x06008B99 RID: 35737 RVA: 0x0003B9D8 File Offset: 0x00039BD8
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002895 RID: 10389
			// (get) Token: 0x06008B9A RID: 35738 RVA: 0x0025CB84 File Offset: 0x0025AD84
			// (set) Token: 0x06008B9B RID: 35739 RVA: 0x0003B9F7 File Offset: 0x00039BF7
			public unsafe Il2CppReferenceArray<Entity> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002896 RID: 10390
			// (get) Token: 0x06008B9C RID: 35740 RVA: 0x0025CBB4 File Offset: 0x0025ADB4
			// (set) Token: 0x06008B9D RID: 35741 RVA: 0x0003BA16 File Offset: 0x00039C16
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17002897 RID: 10391
			// (get) Token: 0x06008B9E RID: 35742 RVA: 0x0025CBDC File Offset: 0x0025ADDC
			// (set) Token: 0x06008B9F RID: 35743 RVA: 0x0003BA31 File Offset: 0x00039C31
			public unsafe WormPlayable _card_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__card_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__card_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002898 RID: 10392
			// (get) Token: 0x06008BA0 RID: 35744 RVA: 0x0025CC0C File Offset: 0x0025AE0C
			// (set) Token: 0x06008BA1 RID: 35745 RVA: 0x0003BA50 File Offset: 0x00039C50
			public unsafe GameLogBuilder _specialLog_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__specialLog_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__specialLog_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002899 RID: 10393
			// (get) Token: 0x06008BA2 RID: 35746 RVA: 0x0025CC3C File Offset: 0x0025AE3C
			// (set) Token: 0x06008BA3 RID: 35747 RVA: 0x0003BA6F File Offset: 0x00039C6F
			public List<AcquireEffects>.Enumerator __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap6);
					return new List<AcquireEffects>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700289A RID: 10394
			// (get) Token: 0x06008BA4 RID: 35748 RVA: 0x0025CC6C File Offset: 0x0025AE6C
			// (set) Token: 0x06008BA5 RID: 35749 RVA: 0x0003BA9D File Offset: 0x00039C9D
			public unsafe AcquireEffects _acquireEffect_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__acquireEffect_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__acquireEffect_5__8)) = value;
				}
			}

			// Token: 0x1700289B RID: 10395
			// (get) Token: 0x06008BA6 RID: 35750 RVA: 0x0025CC94 File Offset: 0x0025AE94
			// (set) Token: 0x06008BA7 RID: 35751 RVA: 0x0003BAB8 File Offset: 0x00039CB8
			public List<Entity>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8);
					return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700289C RID: 10396
			// (get) Token: 0x06008BA8 RID: 35752 RVA: 0x0025CCC4 File Offset: 0x0025AEC4
			// (set) Token: 0x06008BA9 RID: 35753 RVA: 0x0003BAE6 File Offset: 0x00039CE6
			public unsafe Entity _rowCard_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__rowCard_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._BeginExecution_d__7.NativeFieldInfoPtr__rowCard_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400591B RID: 22811
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400591C RID: 22812
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400591D RID: 22813
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400591E RID: 22814
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400591F RID: 22815
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005920 RID: 22816
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005921 RID: 22817
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005922 RID: 22818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005923 RID: 22819
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005924 RID: 22820
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005925 RID: 22821
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005926 RID: 22822
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04005927 RID: 22823
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04005928 RID: 22824
			private static readonly IntPtr NativeFieldInfoPtr__card_5__5;

			// Token: 0x04005929 RID: 22825
			private static readonly IntPtr NativeFieldInfoPtr__specialLog_5__6;

			// Token: 0x0400592A RID: 22826
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x0400592B RID: 22827
			private static readonly IntPtr NativeFieldInfoPtr__acquireEffect_5__8;

			// Token: 0x0400592C RID: 22828
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x0400592D RID: 22829
			private static readonly IntPtr NativeFieldInfoPtr__rowCard_5__10;

			// Token: 0x0400592E RID: 22830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400592F RID: 22831
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005930 RID: 22832
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005931 RID: 22833
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005932 RID: 22834
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04005933 RID: 22835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005934 RID: 22836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005935 RID: 22837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005936 RID: 22838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005937 RID: 22839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000925 RID: 2341
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryFamilyAtomicsTrigger+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06008BAA RID: 35754 RVA: 0x0025CCF4 File Offset: 0x0025AEF4
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, "evt");
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674390);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674391);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674392);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674393);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674394);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674395);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674396);
				NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr, 100674397);
			}

			// Token: 0x06008BAB RID: 35755 RVA: 0x0025CE24 File Offset: 0x0025B024
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008BAC RID: 35756 RVA: 0x0025CE6C File Offset: 0x0025B06C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BAD RID: 35757 RVA: 0x0025CEA0 File Offset: 0x0025B0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194263, XrefRangeEnd = 194270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170028A4 RID: 10404
			// (get) Token: 0x06008BAE RID: 35758 RVA: 0x0025CEDC File Offset: 0x0025B0DC
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06008BAF RID: 35759 RVA: 0x0025CF1C File Offset: 0x0025B11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194270, XrefRangeEnd = 194275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028A5 RID: 10405
			// (get) Token: 0x06008BB0 RID: 35760 RVA: 0x0025CF50 File Offset: 0x0025B150
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BB1 RID: 35761 RVA: 0x0025CF90 File Offset: 0x0025B190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194275, XrefRangeEnd = 194283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008BB2 RID: 35762 RVA: 0x0025CFD0 File Offset: 0x0025B1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008BB3 RID: 35763 RVA: 0x0003BB05 File Offset: 0x00039D05
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700289F RID: 10399
			// (get) Token: 0x06008BB4 RID: 35764 RVA: 0x0025D010 File Offset: 0x0025B210
			// (set) Token: 0x06008BB5 RID: 35765 RVA: 0x0003BB0E File Offset: 0x00039D0E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170028A0 RID: 10400
			// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x0025D038 File Offset: 0x0025B238
			// (set) Token: 0x06008BB7 RID: 35767 RVA: 0x0003BB29 File Offset: 0x00039D29
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028A1 RID: 10401
			// (get) Token: 0x06008BB8 RID: 35768 RVA: 0x0025D068 File Offset: 0x0025B268
			// (set) Token: 0x06008BB9 RID: 35769 RVA: 0x0003BB48 File Offset: 0x00039D48
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170028A2 RID: 10402
			// (get) Token: 0x06008BBA RID: 35770 RVA: 0x0025D090 File Offset: 0x0025B290
			// (set) Token: 0x06008BBB RID: 35771 RVA: 0x0003BB63 File Offset: 0x00039D63
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028A3 RID: 10403
			// (get) Token: 0x06008BBC RID: 35772 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
			// (set) Token: 0x06008BBD RID: 35773 RVA: 0x0003BB82 File Offset: 0x00039D82
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005938 RID: 22840
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005939 RID: 22841
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400593A RID: 22842
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400593B RID: 22843
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400593C RID: 22844
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400593D RID: 22845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400593E RID: 22846
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400593F RID: 22847
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005940 RID: 22848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04005941 RID: 22849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005942 RID: 22850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005943 RID: 22851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005944 RID: 22852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000926 RID: 2342
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryFamilyAtomicsTrigger+<Targets>d__6")]
		public sealed class _Targets_d__6 : Object
		{
			// Token: 0x06008BBE RID: 35774 RVA: 0x0025D0F0 File Offset: 0x0025B2F0
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "<>1__state");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "<>2__current");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "context");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "<>3__context");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, "<>4__this");
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674398);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674399);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674400);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674401);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674402);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674403);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674404);
				NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr, 100674405);
			}

			// Token: 0x06008BBF RID: 35775 RVA: 0x0025D234 File Offset: 0x0025B434
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryFamilyAtomicsTrigger._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008BC0 RID: 35776 RVA: 0x0025D27C File Offset: 0x0025B47C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008BC1 RID: 35777 RVA: 0x0025D2B0 File Offset: 0x0025B4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194283, XrefRangeEnd = 194419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170028AC RID: 10412
			// (get) Token: 0x06008BC2 RID: 35778 RVA: 0x0025D2EC File Offset: 0x0025B4EC
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06008BC3 RID: 35779 RVA: 0x0025D32C File Offset: 0x0025B52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194419, XrefRangeEnd = 194424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170028AD RID: 10413
			// (get) Token: 0x06008BC4 RID: 35780 RVA: 0x0025D360 File Offset: 0x0025B560
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008BC5 RID: 35781 RVA: 0x0025D3A0 File Offset: 0x0025B5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194424, XrefRangeEnd = 194433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x06008BC6 RID: 35782 RVA: 0x0025D3E0 File Offset: 0x0025B5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008BC7 RID: 35783 RVA: 0x0003BBA1 File Offset: 0x00039DA1
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028A6 RID: 10406
			// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x0025D420 File Offset: 0x0025B620
			// (set) Token: 0x06008BC9 RID: 35785 RVA: 0x0003BBAA File Offset: 0x00039DAA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170028A7 RID: 10407
			// (get) Token: 0x06008BCA RID: 35786 RVA: 0x0025D448 File Offset: 0x0025B648
			// (set) Token: 0x06008BCB RID: 35787 RVA: 0x0003BBC5 File Offset: 0x00039DC5
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028A8 RID: 10408
			// (get) Token: 0x06008BCC RID: 35788 RVA: 0x0025D478 File Offset: 0x0025B678
			// (set) Token: 0x06008BCD RID: 35789 RVA: 0x0003BBE4 File Offset: 0x00039DE4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170028A9 RID: 10409
			// (get) Token: 0x06008BCE RID: 35790 RVA: 0x0025D4A0 File Offset: 0x0025B6A0
			// (set) Token: 0x06008BCF RID: 35791 RVA: 0x0003BBFF File Offset: 0x00039DFF
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028AA RID: 10410
			// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x0025D4D0 File Offset: 0x0025B6D0
			// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x0003BC1E File Offset: 0x00039E1E
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028AB RID: 10411
			// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x0025D500 File Offset: 0x0025B700
			// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x0003BC3D File Offset: 0x00039E3D
			public unsafe NuclearMasteryFamilyAtomicsTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NuclearMasteryFamilyAtomicsTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryFamilyAtomicsTrigger._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005945 RID: 22853
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005946 RID: 22854
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005947 RID: 22855
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005948 RID: 22856
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005949 RID: 22857
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400594A RID: 22858
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400594B RID: 22859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400594C RID: 22860
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400594D RID: 22861
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400594E RID: 22862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x0400594F RID: 22863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005950 RID: 22864
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005951 RID: 22865
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04005952 RID: 22866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
