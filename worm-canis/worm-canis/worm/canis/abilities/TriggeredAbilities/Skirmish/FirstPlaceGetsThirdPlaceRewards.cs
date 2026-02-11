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
using worm.canis.abilities.ConflictAbilities;
using worm.canis.actions.phases;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x02000331 RID: 817
	public class FirstPlaceGetsThirdPlaceRewards : RuleModAbility
	{
		// Token: 0x06002147 RID: 8519 RVA: 0x000DBF80 File Offset: 0x000DA180
		// Note: this type is marked as 'beforefieldinit'.
		static FirstPlaceGetsThirdPlaceRewards()
		{
			Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "FirstPlaceGetsThirdPlaceRewards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr);
			FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "AbilityName");
			FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "AbilityID");
			FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, 100671583);
			FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, 100671584);
			FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, 100671585);
			FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, 100671586);
			FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, 100671587);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000DC03C File Offset: 0x000DA23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178163, XrefRangeEnd = 178167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000DC088 File Offset: 0x000DA288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178167, XrefRangeEnd = 178170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirstPlaceGetsThirdPlaceRewards(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000DC0D4 File Offset: 0x000DA2D4
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirstPlaceGetsThirdPlaceRewards(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000DC144 File Offset: 0x000DA344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178170, XrefRangeEnd = 178177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000DC1A0 File Offset: 0x000DA3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178177, XrefRangeEnd = 178185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirstPlaceGetsThirdPlaceRewards.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0000D948 File Offset: 0x0000BB48
		public FirstPlaceGetsThirdPlaceRewards(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x000DC220 File Offset: 0x000DA420
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x0000D951 File Offset: 0x0000BB51
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x000DC240 File Offset: 0x000DA440
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x0000D963 File Offset: 0x0000BB63
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirstPlaceGetsThirdPlaceRewards.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x020007FE RID: 2046
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.FirstPlaceGetsThirdPlaceRewards+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600745D RID: 29789 RVA: 0x00217E54 File Offset: 0x00216054
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr);
				FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, "<>9");
				FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, "<>9__6_1");
				FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, "<>9__6_2");
				FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, 100671590);
				FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, 100671591);
				FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__BeginExecution_b__6_2_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr, 100671592);
			}

			// Token: 0x0600745E RID: 29790 RVA: 0x00217EF8 File Offset: 0x002160F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600745F RID: 29791 RVA: 0x00217F34 File Offset: 0x00216134
			[CallerCount(0)]
			public unsafe bool _BeginExecution_b__6_1(SerializedPlayerReward _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007460 RID: 29792 RVA: 0x00217F84 File Offset: 0x00216184
			[CallerCount(0)]
			public unsafe bool _BeginExecution_b__6_2(SerializedPlayerReward _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.__c.NativeMethodInfoPtr__BeginExecution_b__6_2_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007461 RID: 29793 RVA: 0x0002EA03 File Offset: 0x0002CC03
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002037 RID: 8247
			// (get) Token: 0x06007462 RID: 29794 RVA: 0x00217FD4 File Offset: 0x002161D4
			// (set) Token: 0x06007463 RID: 29795 RVA: 0x0002EA0C File Offset: 0x0002CC0C
			public unsafe static FirstPlaceGetsThirdPlaceRewards.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FirstPlaceGetsThirdPlaceRewards.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002038 RID: 8248
			// (get) Token: 0x06007464 RID: 29796 RVA: 0x00217FFC File Offset: 0x002161FC
			// (set) Token: 0x06007465 RID: 29797 RVA: 0x0002EA1E File Offset: 0x0002CC1E
			public unsafe static Predicate<SerializedPlayerReward> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<SerializedPlayerReward>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002039 RID: 8249
			// (get) Token: 0x06007466 RID: 29798 RVA: 0x00218024 File Offset: 0x00216224
			// (set) Token: 0x06007467 RID: 29799 RVA: 0x0002EA30 File Offset: 0x0002CC30
			public unsafe static Func<SerializedPlayerReward, bool> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedPlayerReward, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FirstPlaceGetsThirdPlaceRewards.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B0F RID: 19215
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004B10 RID: 19216
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04004B11 RID: 19217
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04004B12 RID: 19218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004B13 RID: 19219
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Boolean_SerializedPlayerReward_0;

			// Token: 0x04004B14 RID: 19220
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_2_Internal_Boolean_SerializedPlayerReward_0;
		}

		// Token: 0x020007FF RID: 2047
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.FirstPlaceGetsThirdPlaceRewards+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06007468 RID: 29800 RVA: 0x0021804C File Offset: 0x0021624C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr);
				FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeFieldInfoPtr_thirdPlaceConflictAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr, "thirdPlaceConflictAbility");
				FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr, 100671593);
				FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr, 100671594);
			}

			// Token: 0x06007469 RID: 29801 RVA: 0x002180B4 File Offset: 0x002162B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600746A RID: 29802 RVA: 0x002180F0 File Offset: 0x002162F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178016, XrefRangeEnd = 178021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(ConflictAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_ConflictAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600746B RID: 29803 RVA: 0x0002EA42 File Offset: 0x0002CC42
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700203A RID: 8250
			// (get) Token: 0x0600746C RID: 29804 RVA: 0x00218140 File Offset: 0x00216340
			// (set) Token: 0x0600746D RID: 29805 RVA: 0x0002EA4B File Offset: 0x0002CC4B
			public unsafe AbilityID thirdPlaceConflictAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeFieldInfoPtr_thirdPlaceConflictAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards.__c__DisplayClass6_0.NativeFieldInfoPtr_thirdPlaceConflictAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B15 RID: 19221
			private static readonly IntPtr NativeFieldInfoPtr_thirdPlaceConflictAbility;

			// Token: 0x04004B16 RID: 19222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004B17 RID: 19223
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_ConflictAbility_0;
		}

		// Token: 0x02000800 RID: 2048
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.FirstPlaceGetsThirdPlaceRewards+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x0600746E RID: 29806 RVA: 0x00218170 File Offset: 0x00216370
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "match");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>4__this");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671595);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671596);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671597);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671598);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671599);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671600);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671601);
				FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr, 100671602);
			}

			// Token: 0x0600746F RID: 29807 RVA: 0x002182DC File Offset: 0x002164DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007470 RID: 29808 RVA: 0x00218324 File Offset: 0x00216524
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007471 RID: 29809 RVA: 0x00218358 File Offset: 0x00216558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178021, XrefRangeEnd = 178127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002043 RID: 8259
			// (get) Token: 0x06007472 RID: 29810 RVA: 0x00218394 File Offset: 0x00216594
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007473 RID: 29811 RVA: 0x002183D4 File Offset: 0x002165D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178127, XrefRangeEnd = 178132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002044 RID: 8260
			// (get) Token: 0x06007474 RID: 29812 RVA: 0x00218408 File Offset: 0x00216608
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007475 RID: 29813 RVA: 0x00218448 File Offset: 0x00216648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178132, XrefRangeEnd = 178142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007476 RID: 29814 RVA: 0x00218488 File Offset: 0x00216688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007477 RID: 29815 RVA: 0x0002EA6A File Offset: 0x0002CC6A
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700203B RID: 8251
			// (get) Token: 0x06007478 RID: 29816 RVA: 0x002184C8 File Offset: 0x002166C8
			// (set) Token: 0x06007479 RID: 29817 RVA: 0x0002EA73 File Offset: 0x0002CC73
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700203C RID: 8252
			// (get) Token: 0x0600747A RID: 29818 RVA: 0x002184F0 File Offset: 0x002166F0
			// (set) Token: 0x0600747B RID: 29819 RVA: 0x0002EA8E File Offset: 0x0002CC8E
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700203D RID: 8253
			// (get) Token: 0x0600747C RID: 29820 RVA: 0x00218520 File Offset: 0x00216720
			// (set) Token: 0x0600747D RID: 29821 RVA: 0x0002EAAD File Offset: 0x0002CCAD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700203E RID: 8254
			// (get) Token: 0x0600747E RID: 29822 RVA: 0x00218548 File Offset: 0x00216748
			// (set) Token: 0x0600747F RID: 29823 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700203F RID: 8255
			// (get) Token: 0x06007480 RID: 29824 RVA: 0x00218578 File Offset: 0x00216778
			// (set) Token: 0x06007481 RID: 29825 RVA: 0x0002EAE7 File Offset: 0x0002CCE7
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002040 RID: 8256
			// (get) Token: 0x06007482 RID: 29826 RVA: 0x002185A8 File Offset: 0x002167A8
			// (set) Token: 0x06007483 RID: 29827 RVA: 0x0002EB06 File Offset: 0x0002CD06
			public unsafe FirstPlaceGetsThirdPlaceRewards __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FirstPlaceGetsThirdPlaceRewards>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002041 RID: 8257
			// (get) Token: 0x06007484 RID: 29828 RVA: 0x002185D8 File Offset: 0x002167D8
			// (set) Token: 0x06007485 RID: 29829 RVA: 0x0002EB25 File Offset: 0x0002CD25
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002042 RID: 8258
			// (get) Token: 0x06007486 RID: 29830 RVA: 0x00218608 File Offset: 0x00216808
			// (set) Token: 0x06007487 RID: 29831 RVA: 0x0002EB44 File Offset: 0x0002CD44
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B18 RID: 19224
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004B19 RID: 19225
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004B1A RID: 19226
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004B1B RID: 19227
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004B1C RID: 19228
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004B1D RID: 19229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004B1E RID: 19230
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004B1F RID: 19231
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004B20 RID: 19232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004B21 RID: 19233
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B22 RID: 19234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004B23 RID: 19235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004B24 RID: 19236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B25 RID: 19237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B26 RID: 19238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004B27 RID: 19239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000801 RID: 2049
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.FirstPlaceGetsThirdPlaceRewards+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06007488 RID: 29832 RVA: 0x00218638 File Offset: 0x00216838
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "evt");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671603);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671604);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671605);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671606);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671607);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671608);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671609);
				FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr, 100671610);
			}

			// Token: 0x06007489 RID: 29833 RVA: 0x0021877C File Offset: 0x0021697C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600748A RID: 29834 RVA: 0x002187C4 File Offset: 0x002169C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600748B RID: 29835 RVA: 0x002187F8 File Offset: 0x002169F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178142, XrefRangeEnd = 178149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700204B RID: 8267
			// (get) Token: 0x0600748C RID: 29836 RVA: 0x00218834 File Offset: 0x00216A34
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600748D RID: 29837 RVA: 0x00218874 File Offset: 0x00216A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178149, XrefRangeEnd = 178154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700204C RID: 8268
			// (get) Token: 0x0600748E RID: 29838 RVA: 0x002188A8 File Offset: 0x00216AA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600748F RID: 29839 RVA: 0x002188E8 File Offset: 0x00216AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178154, XrefRangeEnd = 178163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007490 RID: 29840 RVA: 0x00218928 File Offset: 0x00216B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007491 RID: 29841 RVA: 0x0002EB63 File Offset: 0x0002CD63
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002045 RID: 8261
			// (get) Token: 0x06007492 RID: 29842 RVA: 0x00218968 File Offset: 0x00216B68
			// (set) Token: 0x06007493 RID: 29843 RVA: 0x0002EB6C File Offset: 0x0002CD6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002046 RID: 8262
			// (get) Token: 0x06007494 RID: 29844 RVA: 0x00218990 File Offset: 0x00216B90
			// (set) Token: 0x06007495 RID: 29845 RVA: 0x0002EB87 File Offset: 0x0002CD87
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002047 RID: 8263
			// (get) Token: 0x06007496 RID: 29846 RVA: 0x002189C0 File Offset: 0x00216BC0
			// (set) Token: 0x06007497 RID: 29847 RVA: 0x0002EBA6 File Offset: 0x0002CDA6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002048 RID: 8264
			// (get) Token: 0x06007498 RID: 29848 RVA: 0x002189E8 File Offset: 0x00216BE8
			// (set) Token: 0x06007499 RID: 29849 RVA: 0x0002EBC1 File Offset: 0x0002CDC1
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002049 RID: 8265
			// (get) Token: 0x0600749A RID: 29850 RVA: 0x00218A18 File Offset: 0x00216C18
			// (set) Token: 0x0600749B RID: 29851 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700204A RID: 8266
			// (get) Token: 0x0600749C RID: 29852 RVA: 0x00218A48 File Offset: 0x00216C48
			// (set) Token: 0x0600749D RID: 29853 RVA: 0x0002EBFF File Offset: 0x0002CDFF
			public unsafe FirstPlaceGetsThirdPlaceRewards __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FirstPlaceGetsThirdPlaceRewards>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirstPlaceGetsThirdPlaceRewards._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B28 RID: 19240
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004B29 RID: 19241
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004B2A RID: 19242
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004B2B RID: 19243
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04004B2C RID: 19244
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04004B2D RID: 19245
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004B2E RID: 19246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004B2F RID: 19247
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B30 RID: 19248
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004B31 RID: 19249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004B32 RID: 19250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B33 RID: 19251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B34 RID: 19252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004B35 RID: 19253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
