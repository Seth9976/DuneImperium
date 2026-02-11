using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.RiseOfIx
{
	// Token: 0x02000362 RID: 866
	public class HeavyLasgunCannonsAbility : TriggeredAbility
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x000E6B9C File Offset: 0x000E4D9C
		// Note: this type is marked as 'beforefieldinit'.
		static HeavyLasgunCannonsAbility()
		{
			Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.RiseOfIx", "HeavyLasgunCannonsAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr);
			HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, "AbilityName");
			HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, "AbilityID");
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672749);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672750);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672751);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672752);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672753);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672754);
			HeavyLasgunCannonsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, 100672755);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000E6C80 File Offset: 0x000E4E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184726, XrefRangeEnd = 184730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyLasgunCannonsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000E6CCC File Offset: 0x000E4ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184730, XrefRangeEnd = 184733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeavyLasgunCannonsAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000E6D18 File Offset: 0x000E4F18
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeavyLasgunCannonsAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000E6D88 File Offset: 0x000E4F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184733, XrefRangeEnd = 184740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyLasgunCannonsAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000E6DE4 File Offset: 0x000E4FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184740, XrefRangeEnd = 184744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyLasgunCannonsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000E6E54 File Offset: 0x000E5054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184744, XrefRangeEnd = 184752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyLasgunCannonsAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000E6ED4 File Offset: 0x000E50D4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyLasgunCannonsAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		public HeavyLasgunCannonsAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000E6F50 File Offset: 0x000E5150
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x0000E1FD File Offset: 0x0000C3FD
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000E6F70 File Offset: 0x000E5170
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x0000E20F File Offset: 0x0000C40F
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeavyLasgunCannonsAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x0200087A RID: 2170
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.HeavyLasgunCannonsAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06007DFF RID: 32255 RVA: 0x0023488C File Offset: 0x00232A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr);
				HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr, 100672757);
				HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr, 100672758);
			}

			// Token: 0x06007E00 RID: 32256 RVA: 0x002348F4 File Offset: 0x00232AF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E01 RID: 32257 RVA: 0x00234930 File Offset: 0x00232B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184594, XrefRangeEnd = 184599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06007E02 RID: 32258 RVA: 0x00033F95 File Offset: 0x00032195
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170023AC RID: 9132
			// (get) Token: 0x06007E03 RID: 32259 RVA: 0x00234980 File Offset: 0x00232B80
			// (set) Token: 0x06007E04 RID: 32260 RVA: 0x00033F9E File Offset: 0x0003219E
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040050F0 RID: 20720
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040050F1 RID: 20721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040050F2 RID: 20722
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x0200087B RID: 2171
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.HeavyLasgunCannonsAbility+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x06007E05 RID: 32261 RVA: 0x002349B0 File Offset: 0x00232BB0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>4__this");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>8__1");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "match");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr__sequenceHelper_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<sequenceHelper>5__2");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap2");
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672759);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672760);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672761);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672762);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672763);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672764);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672765);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672766);
				HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr, 100672767);
			}

			// Token: 0x06007E06 RID: 32262 RVA: 0x00234B6C File Offset: 0x00232D6C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007E07 RID: 32263 RVA: 0x00234BB4 File Offset: 0x00232DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184599, XrefRangeEnd = 184604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E08 RID: 32264 RVA: 0x00234BE8 File Offset: 0x00232DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184604, XrefRangeEnd = 184684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E09 RID: 32265 RVA: 0x00234C24 File Offset: 0x00232E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184684, XrefRangeEnd = 184687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170023B8 RID: 9144
			// (get) Token: 0x06007E0A RID: 32266 RVA: 0x00234C58 File Offset: 0x00232E58
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007E0B RID: 32267 RVA: 0x00234C98 File Offset: 0x00232E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184687, XrefRangeEnd = 184692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170023B9 RID: 9145
			// (get) Token: 0x06007E0C RID: 32268 RVA: 0x00234CCC File Offset: 0x00232ECC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E0D RID: 32269 RVA: 0x00234D0C File Offset: 0x00232F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184692, XrefRangeEnd = 184702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007E0E RID: 32270 RVA: 0x00234D4C File Offset: 0x00232F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007E0F RID: 32271 RVA: 0x00033FBD File Offset: 0x000321BD
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170023AD RID: 9133
			// (get) Token: 0x06007E10 RID: 32272 RVA: 0x00234D8C File Offset: 0x00232F8C
			// (set) Token: 0x06007E11 RID: 32273 RVA: 0x00033FC6 File Offset: 0x000321C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170023AE RID: 9134
			// (get) Token: 0x06007E12 RID: 32274 RVA: 0x00234DB4 File Offset: 0x00232FB4
			// (set) Token: 0x06007E13 RID: 32275 RVA: 0x00033FE1 File Offset: 0x000321E1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023AF RID: 9135
			// (get) Token: 0x06007E14 RID: 32276 RVA: 0x00234DE4 File Offset: 0x00232FE4
			// (set) Token: 0x06007E15 RID: 32277 RVA: 0x00034000 File Offset: 0x00032200
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170023B0 RID: 9136
			// (get) Token: 0x06007E16 RID: 32278 RVA: 0x00234E0C File Offset: 0x0023300C
			// (set) Token: 0x06007E17 RID: 32279 RVA: 0x0003401B File Offset: 0x0003221B
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B1 RID: 9137
			// (get) Token: 0x06007E18 RID: 32280 RVA: 0x00234E3C File Offset: 0x0023303C
			// (set) Token: 0x06007E19 RID: 32281 RVA: 0x0003403A File Offset: 0x0003223A
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B2 RID: 9138
			// (get) Token: 0x06007E1A RID: 32282 RVA: 0x00234E6C File Offset: 0x0023306C
			// (set) Token: 0x06007E1B RID: 32283 RVA: 0x00034059 File Offset: 0x00032259
			public unsafe HeavyLasgunCannonsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyLasgunCannonsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B3 RID: 9139
			// (get) Token: 0x06007E1C RID: 32284 RVA: 0x00234E9C File Offset: 0x0023309C
			// (set) Token: 0x06007E1D RID: 32285 RVA: 0x00034078 File Offset: 0x00032278
			public unsafe HeavyLasgunCannonsAbility.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyLasgunCannonsAbility.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B4 RID: 9140
			// (get) Token: 0x06007E1E RID: 32286 RVA: 0x00234ECC File Offset: 0x002330CC
			// (set) Token: 0x06007E1F RID: 32287 RVA: 0x00034097 File Offset: 0x00032297
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B5 RID: 9141
			// (get) Token: 0x06007E20 RID: 32288 RVA: 0x00234EFC File Offset: 0x002330FC
			// (set) Token: 0x06007E21 RID: 32289 RVA: 0x000340B6 File Offset: 0x000322B6
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B6 RID: 9142
			// (get) Token: 0x06007E22 RID: 32290 RVA: 0x00234F2C File Offset: 0x0023312C
			// (set) Token: 0x06007E23 RID: 32291 RVA: 0x000340D5 File Offset: 0x000322D5
			public unsafe SequenceHelper _sequenceHelper_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr__sequenceHelper_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr__sequenceHelper_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023B7 RID: 9143
			// (get) Token: 0x06007E24 RID: 32292 RVA: 0x00234F5C File Offset: 0x0023315C
			// (set) Token: 0x06007E25 RID: 32293 RVA: 0x000340F4 File Offset: 0x000322F4
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040050F3 RID: 20723
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040050F4 RID: 20724
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040050F5 RID: 20725
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040050F6 RID: 20726
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040050F7 RID: 20727
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040050F8 RID: 20728
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040050F9 RID: 20729
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040050FA RID: 20730
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040050FB RID: 20731
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040050FC RID: 20732
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__2;

			// Token: 0x040050FD RID: 20733
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040050FE RID: 20734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040050FF RID: 20735
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005100 RID: 20736
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005101 RID: 20737
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005102 RID: 20738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005103 RID: 20739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005104 RID: 20740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005105 RID: 20741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005106 RID: 20742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200087C RID: 2172
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.HeavyLasgunCannonsAbility+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06007E26 RID: 32294 RVA: 0x00234F8C File Offset: 0x0023318C
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeavyLasgunCannonsAbility>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "evt");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672768);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672769);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672770);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672771);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672772);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672773);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672774);
				HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr, 100672775);
			}

			// Token: 0x06007E27 RID: 32295 RVA: 0x002350D0 File Offset: 0x002332D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyLasgunCannonsAbility._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007E28 RID: 32296 RVA: 0x00235118 File Offset: 0x00233318
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E29 RID: 32297 RVA: 0x0023514C File Offset: 0x0023334C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184702, XrefRangeEnd = 184712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170023C0 RID: 9152
			// (get) Token: 0x06007E2A RID: 32298 RVA: 0x00235188 File Offset: 0x00233388
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06007E2B RID: 32299 RVA: 0x002351C8 File Offset: 0x002333C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184712, XrefRangeEnd = 184717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170023C1 RID: 9153
			// (get) Token: 0x06007E2C RID: 32300 RVA: 0x002351FC File Offset: 0x002333FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E2D RID: 32301 RVA: 0x0023523C File Offset: 0x0023343C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184717, XrefRangeEnd = 184726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007E2E RID: 32302 RVA: 0x0023527C File Offset: 0x0023347C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007E2F RID: 32303 RVA: 0x00034113 File Offset: 0x00032313
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170023BA RID: 9146
			// (get) Token: 0x06007E30 RID: 32304 RVA: 0x002352BC File Offset: 0x002334BC
			// (set) Token: 0x06007E31 RID: 32305 RVA: 0x0003411C File Offset: 0x0003231C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170023BB RID: 9147
			// (get) Token: 0x06007E32 RID: 32306 RVA: 0x002352E4 File Offset: 0x002334E4
			// (set) Token: 0x06007E33 RID: 32307 RVA: 0x00034137 File Offset: 0x00032337
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023BC RID: 9148
			// (get) Token: 0x06007E34 RID: 32308 RVA: 0x00235314 File Offset: 0x00233514
			// (set) Token: 0x06007E35 RID: 32309 RVA: 0x00034156 File Offset: 0x00032356
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170023BD RID: 9149
			// (get) Token: 0x06007E36 RID: 32310 RVA: 0x0023533C File Offset: 0x0023353C
			// (set) Token: 0x06007E37 RID: 32311 RVA: 0x00034171 File Offset: 0x00032371
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023BE RID: 9150
			// (get) Token: 0x06007E38 RID: 32312 RVA: 0x0023536C File Offset: 0x0023356C
			// (set) Token: 0x06007E39 RID: 32313 RVA: 0x00034190 File Offset: 0x00032390
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170023BF RID: 9151
			// (get) Token: 0x06007E3A RID: 32314 RVA: 0x0023539C File Offset: 0x0023359C
			// (set) Token: 0x06007E3B RID: 32315 RVA: 0x000341AF File Offset: 0x000323AF
			public unsafe HeavyLasgunCannonsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyLasgunCannonsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyLasgunCannonsAbility._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005107 RID: 20743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005108 RID: 20744
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005109 RID: 20745
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400510A RID: 20746
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400510B RID: 20747
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400510C RID: 20748
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400510D RID: 20749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400510E RID: 20750
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400510F RID: 20751
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005110 RID: 20752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04005111 RID: 20753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005112 RID: 20754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005113 RID: 20755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005114 RID: 20756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
