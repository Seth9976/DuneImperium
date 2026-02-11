using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge
{
	// Token: 0x02000395 RID: 917
	public class SpiceMustPourCostReduction : RuleModAbility
	{
		// Token: 0x06002639 RID: 9785 RVA: 0x000F339C File Offset: 0x000F159C
		// Note: this type is marked as 'beforefieldinit'.
		static SpiceMustPourCostReduction()
		{
			Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "SpiceMustPourCostReduction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr);
			SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "AbilityName");
			SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "AbilityID");
			SpiceMustPourCostReduction.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673952);
			SpiceMustPourCostReduction.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673953);
			SpiceMustPourCostReduction.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673954);
			SpiceMustPourCostReduction.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673955);
			SpiceMustPourCostReduction.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673956);
			SpiceMustPourCostReduction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, 100673957);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000F346C File Offset: 0x000F166C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191469, XrefRangeEnd = 191473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpiceMustPourCostReduction.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000F34B8 File Offset: 0x000F16B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191473, XrefRangeEnd = 191476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiceMustPourCostReduction(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000F3504 File Offset: 0x000F1704
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiceMustPourCostReduction(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000F3574 File Offset: 0x000F1774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191476, XrefRangeEnd = 191482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpiceMustPourCostReduction.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000F35D0 File Offset: 0x000F17D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191482, XrefRangeEnd = 191489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpiceMustPourCostReduction.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000F3650 File Offset: 0x000F1850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191489, XrefRangeEnd = 191497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0000EAF1 File Offset: 0x0000CCF1
		public SpiceMustPourCostReduction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000F36D8 File Offset: 0x000F18D8
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x0000EAFA File Offset: 0x0000CCFA
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000F36F8 File Offset: 0x000F18F8
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiceMustPourCostReduction.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x020008F4 RID: 2292
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.SpiceMustPourCostReduction+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060087B7 RID: 34743 RVA: 0x002511EC File Offset: 0x0024F3EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr);
				SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, "<>9");
				SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, "<>9__6_0");
				SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, "<>9__6_1");
				SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, 100673960);
				SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, 100673961);
				SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr, 100673962);
			}

			// Token: 0x060087B8 RID: 34744 RVA: 0x00251290 File Offset: 0x0024F490
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060087B9 RID: 34745 RVA: 0x002512CC File Offset: 0x0024F4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191344, XrefRangeEnd = 191353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060087BA RID: 34746 RVA: 0x0025131C File Offset: 0x0024F51C
			[CallerCount(0)]
			public unsafe EntityID _BeginExecution_b__6_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060087BB RID: 34747 RVA: 0x0003982E File Offset: 0x00037A2E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002736 RID: 10038
			// (get) Token: 0x060087BC RID: 34748 RVA: 0x0025136C File Offset: 0x0024F56C
			// (set) Token: 0x060087BD RID: 34749 RVA: 0x00039837 File Offset: 0x00037A37
			public unsafe static SpiceMustPourCostReduction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpiceMustPourCostReduction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002737 RID: 10039
			// (get) Token: 0x060087BE RID: 34750 RVA: 0x00251394 File Offset: 0x0024F594
			// (set) Token: 0x060087BF RID: 34751 RVA: 0x00039849 File Offset: 0x00037A49
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002738 RID: 10040
			// (get) Token: 0x060087C0 RID: 34752 RVA: 0x002513BC File Offset: 0x0024F5BC
			// (set) Token: 0x060087C1 RID: 34753 RVA: 0x0003985B File Offset: 0x00037A5B
			public unsafe static Func<Entity, EntityID> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpiceMustPourCostReduction.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056D2 RID: 22226
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040056D3 RID: 22227
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040056D4 RID: 22228
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x040056D5 RID: 22229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040056D6 RID: 22230
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0;

			// Token: 0x040056D7 RID: 22231
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_EntityID_Entity_0;
		}

		// Token: 0x020008F5 RID: 2293
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.SpiceMustPourCostReduction+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x060087C2 RID: 34754 RVA: 0x002513E4 File Offset: 0x0024F5E4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "match");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCards_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<tsmfCards>5__2");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__spacingGuildPlayed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<spacingGuildPlayed>5__3");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__undoNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, "<undoNode>5__4");
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673963);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673964);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673965);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673966);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673967);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673968);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673969);
				SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr, 100673970);
			}

			// Token: 0x060087C3 RID: 34755 RVA: 0x00251578 File Offset: 0x0024F778
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060087C4 RID: 34756 RVA: 0x002515C0 File Offset: 0x0024F7C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060087C5 RID: 34757 RVA: 0x002515F4 File Offset: 0x0024F7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191353, XrefRangeEnd = 191398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002743 RID: 10051
			// (get) Token: 0x060087C6 RID: 34758 RVA: 0x00251630 File Offset: 0x0024F830
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060087C7 RID: 34759 RVA: 0x00251670 File Offset: 0x0024F870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191398, XrefRangeEnd = 191403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002744 RID: 10052
			// (get) Token: 0x060087C8 RID: 34760 RVA: 0x002516A4 File Offset: 0x0024F8A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060087C9 RID: 34761 RVA: 0x002516E4 File Offset: 0x0024F8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191403, XrefRangeEnd = 191412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060087CA RID: 34762 RVA: 0x00251724 File Offset: 0x0024F924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060087CB RID: 34763 RVA: 0x0003986D File Offset: 0x00037A6D
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002739 RID: 10041
			// (get) Token: 0x060087CC RID: 34764 RVA: 0x00251764 File Offset: 0x0024F964
			// (set) Token: 0x060087CD RID: 34765 RVA: 0x00039876 File Offset: 0x00037A76
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700273A RID: 10042
			// (get) Token: 0x060087CE RID: 34766 RVA: 0x0025178C File Offset: 0x0024F98C
			// (set) Token: 0x060087CF RID: 34767 RVA: 0x00039891 File Offset: 0x00037A91
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700273B RID: 10043
			// (get) Token: 0x060087D0 RID: 34768 RVA: 0x002517BC File Offset: 0x0024F9BC
			// (set) Token: 0x060087D1 RID: 34769 RVA: 0x000398B0 File Offset: 0x00037AB0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700273C RID: 10044
			// (get) Token: 0x060087D2 RID: 34770 RVA: 0x002517E4 File Offset: 0x0024F9E4
			// (set) Token: 0x060087D3 RID: 34771 RVA: 0x000398CB File Offset: 0x00037ACB
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700273D RID: 10045
			// (get) Token: 0x060087D4 RID: 34772 RVA: 0x00251814 File Offset: 0x0024FA14
			// (set) Token: 0x060087D5 RID: 34773 RVA: 0x000398EA File Offset: 0x00037AEA
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700273E RID: 10046
			// (get) Token: 0x060087D6 RID: 34774 RVA: 0x00251844 File Offset: 0x0024FA44
			// (set) Token: 0x060087D7 RID: 34775 RVA: 0x00039909 File Offset: 0x00037B09
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700273F RID: 10047
			// (get) Token: 0x060087D8 RID: 34776 RVA: 0x00251874 File Offset: 0x0024FA74
			// (set) Token: 0x060087D9 RID: 34777 RVA: 0x00039928 File Offset: 0x00037B28
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002740 RID: 10048
			// (get) Token: 0x060087DA RID: 34778 RVA: 0x002518A4 File Offset: 0x0024FAA4
			// (set) Token: 0x060087DB RID: 34779 RVA: 0x00039947 File Offset: 0x00037B47
			public unsafe Il2CppReferenceArray<Entity> _tsmfCards_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCards_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCards_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002741 RID: 10049
			// (get) Token: 0x060087DC RID: 34780 RVA: 0x002518D4 File Offset: 0x0024FAD4
			// (set) Token: 0x060087DD RID: 34781 RVA: 0x00039966 File Offset: 0x00037B66
			public unsafe int _spacingGuildPlayed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__spacingGuildPlayed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__spacingGuildPlayed_5__3)) = value;
				}
			}

			// Token: 0x17002742 RID: 10050
			// (get) Token: 0x060087DE RID: 34782 RVA: 0x002518FC File Offset: 0x0024FAFC
			// (set) Token: 0x060087DF RID: 34783 RVA: 0x00039981 File Offset: 0x00037B81
			public unsafe UndoNode _undoNode_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__undoNode_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._BeginExecution_d__6.NativeFieldInfoPtr__undoNode_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056D8 RID: 22232
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040056D9 RID: 22233
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040056DA RID: 22234
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040056DB RID: 22235
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040056DC RID: 22236
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040056DD RID: 22237
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040056DE RID: 22238
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040056DF RID: 22239
			private static readonly IntPtr NativeFieldInfoPtr__tsmfCards_5__2;

			// Token: 0x040056E0 RID: 22240
			private static readonly IntPtr NativeFieldInfoPtr__spacingGuildPlayed_5__3;

			// Token: 0x040056E1 RID: 22241
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__4;

			// Token: 0x040056E2 RID: 22242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040056E3 RID: 22243
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056E4 RID: 22244
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040056E5 RID: 22245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040056E6 RID: 22246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056E7 RID: 22247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040056E8 RID: 22248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040056E9 RID: 22249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020008F6 RID: 2294
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.SpiceMustPourCostReduction+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x060087E0 RID: 34784 RVA: 0x0025192C File Offset: 0x0024FB2C
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, "evt");
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673971);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673972);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673973);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673974);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673975);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673976);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673977);
				SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr, 100673978);
			}

			// Token: 0x060087E1 RID: 34785 RVA: 0x00251A5C File Offset: 0x0024FC5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060087E2 RID: 34786 RVA: 0x00251AA4 File Offset: 0x0024FCA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060087E3 RID: 34787 RVA: 0x00251AD8 File Offset: 0x0024FCD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191412, XrefRangeEnd = 191420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700274A RID: 10058
			// (get) Token: 0x060087E4 RID: 34788 RVA: 0x00251B14 File Offset: 0x0024FD14
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x060087E5 RID: 34789 RVA: 0x00251B54 File Offset: 0x0024FD54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191420, XrefRangeEnd = 191425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700274B RID: 10059
			// (get) Token: 0x060087E6 RID: 34790 RVA: 0x00251B88 File Offset: 0x0024FD88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060087E7 RID: 34791 RVA: 0x00251BC8 File Offset: 0x0024FDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191425, XrefRangeEnd = 191433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x060087E8 RID: 34792 RVA: 0x00251C08 File Offset: 0x0024FE08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060087E9 RID: 34793 RVA: 0x000399A0 File Offset: 0x00037BA0
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002745 RID: 10053
			// (get) Token: 0x060087EA RID: 34794 RVA: 0x00251C48 File Offset: 0x0024FE48
			// (set) Token: 0x060087EB RID: 34795 RVA: 0x000399A9 File Offset: 0x00037BA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002746 RID: 10054
			// (get) Token: 0x060087EC RID: 34796 RVA: 0x00251C70 File Offset: 0x0024FE70
			// (set) Token: 0x060087ED RID: 34797 RVA: 0x000399C4 File Offset: 0x00037BC4
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002747 RID: 10055
			// (get) Token: 0x060087EE RID: 34798 RVA: 0x00251CA0 File Offset: 0x0024FEA0
			// (set) Token: 0x060087EF RID: 34799 RVA: 0x000399E3 File Offset: 0x00037BE3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002748 RID: 10056
			// (get) Token: 0x060087F0 RID: 34800 RVA: 0x00251CC8 File Offset: 0x0024FEC8
			// (set) Token: 0x060087F1 RID: 34801 RVA: 0x000399FE File Offset: 0x00037BFE
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002749 RID: 10057
			// (get) Token: 0x060087F2 RID: 34802 RVA: 0x00251CF8 File Offset: 0x0024FEF8
			// (set) Token: 0x060087F3 RID: 34803 RVA: 0x00039A1D File Offset: 0x00037C1D
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056EA RID: 22250
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040056EB RID: 22251
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040056EC RID: 22252
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040056ED RID: 22253
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040056EE RID: 22254
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x040056EF RID: 22255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040056F0 RID: 22256
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056F1 RID: 22257
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040056F2 RID: 22258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x040056F3 RID: 22259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056F4 RID: 22260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040056F5 RID: 22261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x040056F6 RID: 22262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020008F7 RID: 2295
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.SpiceMustPourCostReduction+<Undo>d__7")]
		public sealed class _Undo_d__7 : Object
		{
			// Token: 0x060087F4 RID: 34804 RVA: 0x00251D28 File Offset: 0x0024FF28
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__7()
			{
				Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpiceMustPourCostReduction>.NativeClassPtr, "<Undo>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr);
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>1__state");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>2__current");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>l__initialThreadId");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "player");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>3__player");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "match");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>3__match");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "node");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<>3__node");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__spacingGuildPlayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<spacingGuildPlayed>5__2");
				SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__tsmfCards_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, "<tsmfCards>5__3");
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673979);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673980);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673981);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673982);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673983);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673984);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673985);
				SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr, 100673986);
			}

			// Token: 0x060087F5 RID: 34805 RVA: 0x00251ED0 File Offset: 0x002500D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceMustPourCostReduction._Undo_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060087F6 RID: 34806 RVA: 0x00251F18 File Offset: 0x00250118
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060087F7 RID: 34807 RVA: 0x00251F4C File Offset: 0x0025014C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191433, XrefRangeEnd = 191450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002757 RID: 10071
			// (get) Token: 0x060087F8 RID: 34808 RVA: 0x00251F88 File Offset: 0x00250188
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060087F9 RID: 34809 RVA: 0x00251FC8 File Offset: 0x002501C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191450, XrefRangeEnd = 191459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002758 RID: 10072
			// (get) Token: 0x060087FA RID: 34810 RVA: 0x00251FFC File Offset: 0x002501FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060087FB RID: 34811 RVA: 0x0025203C File Offset: 0x0025023C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191459, XrefRangeEnd = 191469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060087FC RID: 34812 RVA: 0x0025207C File Offset: 0x0025027C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceMustPourCostReduction._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060087FD RID: 34813 RVA: 0x00039A3C File Offset: 0x00037C3C
			public _Undo_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700274C RID: 10060
			// (get) Token: 0x060087FE RID: 34814 RVA: 0x002520BC File Offset: 0x002502BC
			// (set) Token: 0x060087FF RID: 34815 RVA: 0x00039A45 File Offset: 0x00037C45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700274D RID: 10061
			// (get) Token: 0x06008800 RID: 34816 RVA: 0x002520E4 File Offset: 0x002502E4
			// (set) Token: 0x06008801 RID: 34817 RVA: 0x00039A60 File Offset: 0x00037C60
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700274E RID: 10062
			// (get) Token: 0x06008802 RID: 34818 RVA: 0x00252114 File Offset: 0x00250314
			// (set) Token: 0x06008803 RID: 34819 RVA: 0x00039A7F File Offset: 0x00037C7F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700274F RID: 10063
			// (get) Token: 0x06008804 RID: 34820 RVA: 0x0025213C File Offset: 0x0025033C
			// (set) Token: 0x06008805 RID: 34821 RVA: 0x00039A9A File Offset: 0x00037C9A
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002750 RID: 10064
			// (get) Token: 0x06008806 RID: 34822 RVA: 0x0025216C File Offset: 0x0025036C
			// (set) Token: 0x06008807 RID: 34823 RVA: 0x00039AB9 File Offset: 0x00037CB9
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002751 RID: 10065
			// (get) Token: 0x06008808 RID: 34824 RVA: 0x0025219C File Offset: 0x0025039C
			// (set) Token: 0x06008809 RID: 34825 RVA: 0x00039AD8 File Offset: 0x00037CD8
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002752 RID: 10066
			// (get) Token: 0x0600880A RID: 34826 RVA: 0x002521CC File Offset: 0x002503CC
			// (set) Token: 0x0600880B RID: 34827 RVA: 0x00039AF7 File Offset: 0x00037CF7
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002753 RID: 10067
			// (get) Token: 0x0600880C RID: 34828 RVA: 0x002521FC File Offset: 0x002503FC
			// (set) Token: 0x0600880D RID: 34829 RVA: 0x00039B16 File Offset: 0x00037D16
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002754 RID: 10068
			// (get) Token: 0x0600880E RID: 34830 RVA: 0x0025222C File Offset: 0x0025042C
			// (set) Token: 0x0600880F RID: 34831 RVA: 0x00039B35 File Offset: 0x00037D35
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002755 RID: 10069
			// (get) Token: 0x06008810 RID: 34832 RVA: 0x0025225C File Offset: 0x0025045C
			// (set) Token: 0x06008811 RID: 34833 RVA: 0x00039B54 File Offset: 0x00037D54
			public unsafe int _spacingGuildPlayed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__spacingGuildPlayed_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__spacingGuildPlayed_5__2)) = value;
				}
			}

			// Token: 0x17002756 RID: 10070
			// (get) Token: 0x06008812 RID: 34834 RVA: 0x00252284 File Offset: 0x00250484
			// (set) Token: 0x06008813 RID: 34835 RVA: 0x00039B6F File Offset: 0x00037D6F
			public unsafe Il2CppReferenceArray<Entity> _tsmfCards_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__tsmfCards_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpiceMustPourCostReduction._Undo_d__7.NativeFieldInfoPtr__tsmfCards_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056F7 RID: 22263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040056F8 RID: 22264
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040056F9 RID: 22265
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040056FA RID: 22266
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040056FB RID: 22267
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040056FC RID: 22268
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040056FD RID: 22269
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040056FE RID: 22270
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x040056FF RID: 22271
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x04005700 RID: 22272
			private static readonly IntPtr NativeFieldInfoPtr__spacingGuildPlayed_5__2;

			// Token: 0x04005701 RID: 22273
			private static readonly IntPtr NativeFieldInfoPtr__tsmfCards_5__3;

			// Token: 0x04005702 RID: 22274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005703 RID: 22275
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005704 RID: 22276
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005705 RID: 22277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005706 RID: 22278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005707 RID: 22279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005708 RID: 22280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005709 RID: 22281
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
