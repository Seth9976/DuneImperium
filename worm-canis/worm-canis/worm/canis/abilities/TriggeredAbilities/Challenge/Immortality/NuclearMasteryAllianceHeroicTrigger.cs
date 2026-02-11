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
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003A3 RID: 931
	public class NuclearMasteryAllianceHeroicTrigger : RuleModAbility
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x000F6194 File Offset: 0x000F4394
		// Note: this type is marked as 'beforefieldinit'.
		static NuclearMasteryAllianceHeroicTrigger()
		{
			Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "NuclearMasteryAllianceHeroicTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr);
			NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "AbilityName");
			NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "AbilityID");
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674331);
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674332);
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674333);
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674334);
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674335);
			NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, 100674336);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000F6264 File Offset: 0x000F4464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193941, XrefRangeEnd = 193945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000F62B0 File Offset: 0x000F44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193945, XrefRangeEnd = 193948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NuclearMasteryAllianceHeroicTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000F62FC File Offset: 0x000F44FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NuclearMasteryAllianceHeroicTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000F636C File Offset: 0x000F456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193948, XrefRangeEnd = 193954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000F63C8 File Offset: 0x000F45C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193954, XrefRangeEnd = 193962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000F6448 File Offset: 0x000F4648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193962, XrefRangeEnd = 193970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0000ED75 File Offset: 0x0000CF75
		public NuclearMasteryAllianceHeroicTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000F64D0 File Offset: 0x000F46D0
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x0000ED7E File Offset: 0x0000CF7E
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000F64F0 File Offset: 0x000F46F0
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x0000ED90 File Offset: 0x0000CF90
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NuclearMasteryAllianceHeroicTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x0200091F RID: 2335
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryAllianceHeroicTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008B0F RID: 35599 RVA: 0x0025B194 File Offset: 0x00259394
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr);
				NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr, "<>9");
				NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr, "<>9__6_0");
				NuclearMasteryAllianceHeroicTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr, 100674339);
				NuclearMasteryAllianceHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr, 100674340);
			}

			// Token: 0x06008B10 RID: 35600 RVA: 0x0025B210 File Offset: 0x00259410
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B11 RID: 35601 RVA: 0x0025B24C File Offset: 0x0025944C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193713, XrefRangeEnd = 193722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008B12 RID: 35602 RVA: 0x0003B507 File Offset: 0x00039707
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002864 RID: 10340
			// (get) Token: 0x06008B13 RID: 35603 RVA: 0x0025B29C File Offset: 0x0025949C
			// (set) Token: 0x06008B14 RID: 35604 RVA: 0x0003B510 File Offset: 0x00039710
			public unsafe static NuclearMasteryAllianceHeroicTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NuclearMasteryAllianceHeroicTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002865 RID: 10341
			// (get) Token: 0x06008B15 RID: 35605 RVA: 0x0025B2C4 File Offset: 0x002594C4
			// (set) Token: 0x06008B16 RID: 35606 RVA: 0x0003B522 File Offset: 0x00039722
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NuclearMasteryAllianceHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058DC RID: 22748
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040058DD RID: 22749
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040058DE RID: 22750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040058DF RID: 22751
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000920 RID: 2336
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryAllianceHeroicTrigger+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x06008B17 RID: 35607 RVA: 0x0025B2EC File Offset: 0x002594EC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "match");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "context");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<>3__context");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<player>5__2");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, "<tsmfCard>5__3");
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674341);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674342);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674343);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674344);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674345);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674346);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674347);
				NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr, 100674348);
			}

			// Token: 0x06008B18 RID: 35608 RVA: 0x0025B494 File Offset: 0x00259694
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008B19 RID: 35609 RVA: 0x0025B4DC File Offset: 0x002596DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B1A RID: 35610 RVA: 0x0025B510 File Offset: 0x00259710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193722, XrefRangeEnd = 193863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002871 RID: 10353
			// (get) Token: 0x06008B1B RID: 35611 RVA: 0x0025B54C File Offset: 0x0025974C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008B1C RID: 35612 RVA: 0x0025B58C File Offset: 0x0025978C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193863, XrefRangeEnd = 193868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002872 RID: 10354
			// (get) Token: 0x06008B1D RID: 35613 RVA: 0x0025B5C0 File Offset: 0x002597C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B1E RID: 35614 RVA: 0x0025B600 File Offset: 0x00259800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193868, XrefRangeEnd = 193878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008B1F RID: 35615 RVA: 0x0025B640 File Offset: 0x00259840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008B20 RID: 35616 RVA: 0x0003B534 File Offset: 0x00039734
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002866 RID: 10342
			// (get) Token: 0x06008B21 RID: 35617 RVA: 0x0025B680 File Offset: 0x00259880
			// (set) Token: 0x06008B22 RID: 35618 RVA: 0x0003B53D File Offset: 0x0003973D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002867 RID: 10343
			// (get) Token: 0x06008B23 RID: 35619 RVA: 0x0025B6A8 File Offset: 0x002598A8
			// (set) Token: 0x06008B24 RID: 35620 RVA: 0x0003B558 File Offset: 0x00039758
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002868 RID: 10344
			// (get) Token: 0x06008B25 RID: 35621 RVA: 0x0025B6D8 File Offset: 0x002598D8
			// (set) Token: 0x06008B26 RID: 35622 RVA: 0x0003B577 File Offset: 0x00039777
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002869 RID: 10345
			// (get) Token: 0x06008B27 RID: 35623 RVA: 0x0025B700 File Offset: 0x00259900
			// (set) Token: 0x06008B28 RID: 35624 RVA: 0x0003B592 File Offset: 0x00039792
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286A RID: 10346
			// (get) Token: 0x06008B29 RID: 35625 RVA: 0x0025B730 File Offset: 0x00259930
			// (set) Token: 0x06008B2A RID: 35626 RVA: 0x0003B5B1 File Offset: 0x000397B1
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286B RID: 10347
			// (get) Token: 0x06008B2B RID: 35627 RVA: 0x0025B760 File Offset: 0x00259960
			// (set) Token: 0x06008B2C RID: 35628 RVA: 0x0003B5D0 File Offset: 0x000397D0
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286C RID: 10348
			// (get) Token: 0x06008B2D RID: 35629 RVA: 0x0025B790 File Offset: 0x00259990
			// (set) Token: 0x06008B2E RID: 35630 RVA: 0x0003B5EF File Offset: 0x000397EF
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286D RID: 10349
			// (get) Token: 0x06008B2F RID: 35631 RVA: 0x0025B7C0 File Offset: 0x002599C0
			// (set) Token: 0x06008B30 RID: 35632 RVA: 0x0003B60E File Offset: 0x0003980E
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286E RID: 10350
			// (get) Token: 0x06008B31 RID: 35633 RVA: 0x0025B7F0 File Offset: 0x002599F0
			// (set) Token: 0x06008B32 RID: 35634 RVA: 0x0003B62D File Offset: 0x0003982D
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700286F RID: 10351
			// (get) Token: 0x06008B33 RID: 35635 RVA: 0x0025B820 File Offset: 0x00259A20
			// (set) Token: 0x06008B34 RID: 35636 RVA: 0x0003B64C File Offset: 0x0003984C
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002870 RID: 10352
			// (get) Token: 0x06008B35 RID: 35637 RVA: 0x0025B850 File Offset: 0x00259A50
			// (set) Token: 0x06008B36 RID: 35638 RVA: 0x0003B66B File Offset: 0x0003986B
			public unsafe WormImperiumPlayable _tsmfCard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._BeginExecution_d__6.NativeFieldInfoPtr__tsmfCard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058E0 RID: 22752
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040058E1 RID: 22753
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040058E2 RID: 22754
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040058E3 RID: 22755
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040058E4 RID: 22756
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040058E5 RID: 22757
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040058E6 RID: 22758
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040058E7 RID: 22759
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040058E8 RID: 22760
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040058E9 RID: 22761
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040058EA RID: 22762
			private static readonly IntPtr NativeFieldInfoPtr__tsmfCard_5__3;

			// Token: 0x040058EB RID: 22763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040058EC RID: 22764
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058ED RID: 22765
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040058EE RID: 22766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040058EF RID: 22767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058F0 RID: 22768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040058F1 RID: 22769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040058F2 RID: 22770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000921 RID: 2337
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryAllianceHeroicTrigger+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06008B37 RID: 35639 RVA: 0x0025B880 File Offset: 0x00259A80
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, "evt");
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674349);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674350);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674351);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674352);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674353);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674354);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674355);
				NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr, 100674356);
			}

			// Token: 0x06008B38 RID: 35640 RVA: 0x0025B9B0 File Offset: 0x00259BB0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008B39 RID: 35641 RVA: 0x0025B9F8 File Offset: 0x00259BF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B3A RID: 35642 RVA: 0x0025BA2C File Offset: 0x00259C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193878, XrefRangeEnd = 193885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002878 RID: 10360
			// (get) Token: 0x06008B3B RID: 35643 RVA: 0x0025BA68 File Offset: 0x00259C68
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06008B3C RID: 35644 RVA: 0x0025BAA8 File Offset: 0x00259CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193885, XrefRangeEnd = 193890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002879 RID: 10361
			// (get) Token: 0x06008B3D RID: 35645 RVA: 0x0025BADC File Offset: 0x00259CDC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B3E RID: 35646 RVA: 0x0025BB1C File Offset: 0x00259D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193890, XrefRangeEnd = 193898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008B3F RID: 35647 RVA: 0x0025BB5C File Offset: 0x00259D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008B40 RID: 35648 RVA: 0x0003B68A File Offset: 0x0003988A
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002873 RID: 10355
			// (get) Token: 0x06008B41 RID: 35649 RVA: 0x0025BB9C File Offset: 0x00259D9C
			// (set) Token: 0x06008B42 RID: 35650 RVA: 0x0003B693 File Offset: 0x00039893
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002874 RID: 10356
			// (get) Token: 0x06008B43 RID: 35651 RVA: 0x0025BBC4 File Offset: 0x00259DC4
			// (set) Token: 0x06008B44 RID: 35652 RVA: 0x0003B6AE File Offset: 0x000398AE
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002875 RID: 10357
			// (get) Token: 0x06008B45 RID: 35653 RVA: 0x0025BBF4 File Offset: 0x00259DF4
			// (set) Token: 0x06008B46 RID: 35654 RVA: 0x0003B6CD File Offset: 0x000398CD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002876 RID: 10358
			// (get) Token: 0x06008B47 RID: 35655 RVA: 0x0025BC1C File Offset: 0x00259E1C
			// (set) Token: 0x06008B48 RID: 35656 RVA: 0x0003B6E8 File Offset: 0x000398E8
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002877 RID: 10359
			// (get) Token: 0x06008B49 RID: 35657 RVA: 0x0025BC4C File Offset: 0x00259E4C
			// (set) Token: 0x06008B4A RID: 35658 RVA: 0x0003B707 File Offset: 0x00039907
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040058F3 RID: 22771
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040058F4 RID: 22772
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040058F5 RID: 22773
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040058F6 RID: 22774
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040058F7 RID: 22775
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x040058F8 RID: 22776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040058F9 RID: 22777
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058FA RID: 22778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040058FB RID: 22779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x040058FC RID: 22780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040058FD RID: 22781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040058FE RID: 22782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x040058FF RID: 22783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000922 RID: 2338
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.NuclearMasteryAllianceHeroicTrigger+<Undo>d__7")]
		public sealed class _Undo_d__7 : Object
		{
			// Token: 0x06008B4B RID: 35659 RVA: 0x0025BC7C File Offset: 0x00259E7C
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__7()
			{
				Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger>.NativeClassPtr, "<Undo>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>1__state");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>2__current");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>l__initialThreadId");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "node");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>3__node");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "match");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>3__match");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "player");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, "<>3__player");
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674357);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674358);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674359);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674360);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674361);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674362);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674363);
				NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr, 100674364);
			}

			// Token: 0x06008B4C RID: 35660 RVA: 0x0025BDFC File Offset: 0x00259FFC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearMasteryAllianceHeroicTrigger._Undo_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008B4D RID: 35661 RVA: 0x0025BE44 File Offset: 0x0025A044
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008B4E RID: 35662 RVA: 0x0025BE78 File Offset: 0x0025A078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193898, XrefRangeEnd = 193926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002883 RID: 10371
			// (get) Token: 0x06008B4F RID: 35663 RVA: 0x0025BEB4 File Offset: 0x0025A0B4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008B50 RID: 35664 RVA: 0x0025BEF4 File Offset: 0x0025A0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193926, XrefRangeEnd = 193931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002884 RID: 10372
			// (get) Token: 0x06008B51 RID: 35665 RVA: 0x0025BF28 File Offset: 0x0025A128
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008B52 RID: 35666 RVA: 0x0025BF68 File Offset: 0x0025A168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193931, XrefRangeEnd = 193941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008B53 RID: 35667 RVA: 0x0025BFA8 File Offset: 0x0025A1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008B54 RID: 35668 RVA: 0x0003B726 File Offset: 0x00039926
			public _Undo_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700287A RID: 10362
			// (get) Token: 0x06008B55 RID: 35669 RVA: 0x0025BFE8 File Offset: 0x0025A1E8
			// (set) Token: 0x06008B56 RID: 35670 RVA: 0x0003B72F File Offset: 0x0003992F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700287B RID: 10363
			// (get) Token: 0x06008B57 RID: 35671 RVA: 0x0025C010 File Offset: 0x0025A210
			// (set) Token: 0x06008B58 RID: 35672 RVA: 0x0003B74A File Offset: 0x0003994A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700287C RID: 10364
			// (get) Token: 0x06008B59 RID: 35673 RVA: 0x0025C040 File Offset: 0x0025A240
			// (set) Token: 0x06008B5A RID: 35674 RVA: 0x0003B769 File Offset: 0x00039969
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700287D RID: 10365
			// (get) Token: 0x06008B5B RID: 35675 RVA: 0x0025C068 File Offset: 0x0025A268
			// (set) Token: 0x06008B5C RID: 35676 RVA: 0x0003B784 File Offset: 0x00039984
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700287E RID: 10366
			// (get) Token: 0x06008B5D RID: 35677 RVA: 0x0025C098 File Offset: 0x0025A298
			// (set) Token: 0x06008B5E RID: 35678 RVA: 0x0003B7A3 File Offset: 0x000399A3
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700287F RID: 10367
			// (get) Token: 0x06008B5F RID: 35679 RVA: 0x0025C0C8 File Offset: 0x0025A2C8
			// (set) Token: 0x06008B60 RID: 35680 RVA: 0x0003B7C2 File Offset: 0x000399C2
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002880 RID: 10368
			// (get) Token: 0x06008B61 RID: 35681 RVA: 0x0025C0F8 File Offset: 0x0025A2F8
			// (set) Token: 0x06008B62 RID: 35682 RVA: 0x0003B7E1 File Offset: 0x000399E1
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002881 RID: 10369
			// (get) Token: 0x06008B63 RID: 35683 RVA: 0x0025C128 File Offset: 0x0025A328
			// (set) Token: 0x06008B64 RID: 35684 RVA: 0x0003B800 File Offset: 0x00039A00
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002882 RID: 10370
			// (get) Token: 0x06008B65 RID: 35685 RVA: 0x0025C158 File Offset: 0x0025A358
			// (set) Token: 0x06008B66 RID: 35686 RVA: 0x0003B81F File Offset: 0x00039A1F
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearMasteryAllianceHeroicTrigger._Undo_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005900 RID: 22784
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005901 RID: 22785
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005902 RID: 22786
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005903 RID: 22787
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04005904 RID: 22788
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x04005905 RID: 22789
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005906 RID: 22790
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005907 RID: 22791
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005908 RID: 22792
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04005909 RID: 22793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400590A RID: 22794
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400590B RID: 22795
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400590C RID: 22796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400590D RID: 22797
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400590E RID: 22798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400590F RID: 22799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005910 RID: 22800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
