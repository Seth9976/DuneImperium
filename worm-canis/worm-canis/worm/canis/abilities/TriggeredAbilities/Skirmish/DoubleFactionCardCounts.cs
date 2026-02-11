using System;
using Canis.actions;
using canis.archetypes;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x0200032E RID: 814
	public class DoubleFactionCardCounts : RuleModAbility
	{
		// Token: 0x06002129 RID: 8489 RVA: 0x000DB7C8 File Offset: 0x000D99C8
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleFactionCardCounts()
		{
			Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "DoubleFactionCardCounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr);
			DoubleFactionCardCounts.NativeFieldInfoPtr__ToCardsOfFaction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, "<ToCardsOfFaction>k__BackingField");
			DoubleFactionCardCounts.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671547);
			DoubleFactionCardCounts.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671548);
			DoubleFactionCardCounts.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_New_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671549);
			DoubleFactionCardCounts.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671550);
			DoubleFactionCardCounts.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671551);
			DoubleFactionCardCounts.NativeMethodInfoPtr__BeginExecution_b__6_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, 100671552);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000DB884 File Offset: 0x000D9A84
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 176120, RefRangeEnd = 176274, XrefRangeStart = 176120, XrefRangeEnd = 176274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleFactionCardCounts(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000DB8F4 File Offset: 0x000D9AF4
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleFactionCardCounts(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x000DB964 File Offset: 0x000D9B64
		public unsafe virtual Factions ToCardsOfFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleFactionCardCounts.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_New_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000DB9AC File Offset: 0x000D9BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177982, XrefRangeEnd = 177989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleFactionCardCounts.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000DBA08 File Offset: 0x000D9C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177989, XrefRangeEnd = 177997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleFactionCardCounts.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000DBA88 File Offset: 0x000D9C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177997, XrefRangeEnd = 178002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BeginExecution_b__6_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts.NativeMethodInfoPtr__BeginExecution_b__6_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0000D8CA File Offset: 0x0000BACA
		public DoubleFactionCardCounts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000DBAD8 File Offset: 0x000D9CD8
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000D8D3 File Offset: 0x0000BAD3
		public unsafe Factions _ToCardsOfFaction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts.NativeFieldInfoPtr__ToCardsOfFaction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts.NativeFieldInfoPtr__ToCardsOfFaction_k__BackingField)) = value;
			}
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr__ToCardsOfFaction_k__BackingField;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_New_get_Factions_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_0_Private_Boolean_Entity_0;

		// Token: 0x020007FB RID: 2043
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.DoubleFactionCardCounts+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06007420 RID: 29728 RVA: 0x00217324 File Offset: 0x00215524
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr);
				DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr, "<>9");
				DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr, "<>9__6_1");
				DoubleFactionCardCounts.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr, 100671554);
				DoubleFactionCardCounts.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Archetype_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr, 100671555);
			}

			// Token: 0x06007421 RID: 29729 RVA: 0x002173A0 File Offset: 0x002155A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleFactionCardCounts.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007422 RID: 29730 RVA: 0x002173DC File Offset: 0x002155DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177848, XrefRangeEnd = 177849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _BeginExecution_b__6_1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts.__c.NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Archetype_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06007423 RID: 29731 RVA: 0x0002E7D5 File Offset: 0x0002C9D5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002021 RID: 8225
			// (get) Token: 0x06007424 RID: 29732 RVA: 0x0021742C File Offset: 0x0021562C
			// (set) Token: 0x06007425 RID: 29733 RVA: 0x0002E7DE File Offset: 0x0002C9DE
			public unsafe static DoubleFactionCardCounts.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleFactionCardCounts.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002022 RID: 8226
			// (get) Token: 0x06007426 RID: 29734 RVA: 0x00217454 File Offset: 0x00215654
			// (set) Token: 0x06007427 RID: 29735 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
			public unsafe static Func<WormImperiumPlayable, Archetype> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, Archetype>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleFactionCardCounts.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AEA RID: 19178
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004AEB RID: 19179
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04004AEC RID: 19180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004AED RID: 19181
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__6_1_Internal_Archetype_WormImperiumPlayable_0;
		}

		// Token: 0x020007FC RID: 2044
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.DoubleFactionCardCounts+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x06007428 RID: 29736 RVA: 0x0021747C File Offset: 0x0021567C
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "match");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>4__this");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<>7__wrap1");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr__newCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, "<newCard>5__3");
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671556);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671557);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671558);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671559);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671560);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671561);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671562);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671563);
				DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr, 100671564);
			}

			// Token: 0x06007429 RID: 29737 RVA: 0x00217624 File Offset: 0x00215824
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleFactionCardCounts._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600742A RID: 29738 RVA: 0x0021766C File Offset: 0x0021586C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 177854, RefRangeEnd = 177855, XrefRangeStart = 177849, XrefRangeEnd = 177854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600742B RID: 29739 RVA: 0x002176A0 File Offset: 0x002158A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177855, XrefRangeEnd = 177943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600742C RID: 29740 RVA: 0x002176DC File Offset: 0x002158DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177943, XrefRangeEnd = 177946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700202D RID: 8237
			// (get) Token: 0x0600742D RID: 29741 RVA: 0x00217710 File Offset: 0x00215910
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600742E RID: 29742 RVA: 0x00217750 File Offset: 0x00215950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177946, XrefRangeEnd = 177951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700202E RID: 8238
			// (get) Token: 0x0600742F RID: 29743 RVA: 0x00217784 File Offset: 0x00215984
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007430 RID: 29744 RVA: 0x002177C4 File Offset: 0x002159C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177951, XrefRangeEnd = 177961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007431 RID: 29745 RVA: 0x00217804 File Offset: 0x00215A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007432 RID: 29746 RVA: 0x0002E802 File Offset: 0x0002CA02
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002023 RID: 8227
			// (get) Token: 0x06007433 RID: 29747 RVA: 0x00217844 File Offset: 0x00215A44
			// (set) Token: 0x06007434 RID: 29748 RVA: 0x0002E80B File Offset: 0x0002CA0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002024 RID: 8228
			// (get) Token: 0x06007435 RID: 29749 RVA: 0x0021786C File Offset: 0x00215A6C
			// (set) Token: 0x06007436 RID: 29750 RVA: 0x0002E826 File Offset: 0x0002CA26
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002025 RID: 8229
			// (get) Token: 0x06007437 RID: 29751 RVA: 0x0021789C File Offset: 0x00215A9C
			// (set) Token: 0x06007438 RID: 29752 RVA: 0x0002E845 File Offset: 0x0002CA45
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002026 RID: 8230
			// (get) Token: 0x06007439 RID: 29753 RVA: 0x002178C4 File Offset: 0x00215AC4
			// (set) Token: 0x0600743A RID: 29754 RVA: 0x0002E860 File Offset: 0x0002CA60
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002027 RID: 8231
			// (get) Token: 0x0600743B RID: 29755 RVA: 0x002178F4 File Offset: 0x00215AF4
			// (set) Token: 0x0600743C RID: 29756 RVA: 0x0002E87F File Offset: 0x0002CA7F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002028 RID: 8232
			// (get) Token: 0x0600743D RID: 29757 RVA: 0x00217924 File Offset: 0x00215B24
			// (set) Token: 0x0600743E RID: 29758 RVA: 0x0002E89E File Offset: 0x0002CA9E
			public unsafe DoubleFactionCardCounts __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleFactionCardCounts>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002029 RID: 8233
			// (get) Token: 0x0600743F RID: 29759 RVA: 0x00217954 File Offset: 0x00215B54
			// (set) Token: 0x06007440 RID: 29760 RVA: 0x0002E8BD File Offset: 0x0002CABD
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700202A RID: 8234
			// (get) Token: 0x06007441 RID: 29761 RVA: 0x00217984 File Offset: 0x00215B84
			// (set) Token: 0x06007442 RID: 29762 RVA: 0x0002E8DC File Offset: 0x0002CADC
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700202B RID: 8235
			// (get) Token: 0x06007443 RID: 29763 RVA: 0x002179B4 File Offset: 0x00215BB4
			// (set) Token: 0x06007444 RID: 29764 RVA: 0x0002E8FB File Offset: 0x0002CAFB
			public List<Archetype>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap1);
					return new List<Archetype>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Archetype>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Archetype>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700202C RID: 8236
			// (get) Token: 0x06007445 RID: 29765 RVA: 0x002179E4 File Offset: 0x00215BE4
			// (set) Token: 0x06007446 RID: 29766 RVA: 0x0002E929 File Offset: 0x0002CB29
			public unsafe Entity _newCard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr__newCard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._BeginExecution_d__6.NativeFieldInfoPtr__newCard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AEE RID: 19182
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004AEF RID: 19183
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004AF0 RID: 19184
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004AF1 RID: 19185
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004AF2 RID: 19186
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004AF3 RID: 19187
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004AF4 RID: 19188
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004AF5 RID: 19189
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004AF6 RID: 19190
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004AF7 RID: 19191
			private static readonly IntPtr NativeFieldInfoPtr__newCard_5__3;

			// Token: 0x04004AF8 RID: 19192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004AF9 RID: 19193
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004AFA RID: 19194
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004AFB RID: 19195
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004AFC RID: 19196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004AFD RID: 19197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004AFE RID: 19198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004AFF RID: 19199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004B00 RID: 19200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007FD RID: 2045
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.DoubleFactionCardCounts+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x06007447 RID: 29767 RVA: 0x00217A14 File Offset: 0x00215C14
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleFactionCardCounts>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "evt");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671565);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671566);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671567);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671568);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671569);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671570);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671571);
				DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr, 100671572);
			}

			// Token: 0x06007448 RID: 29768 RVA: 0x00217B58 File Offset: 0x00215D58
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleFactionCardCounts._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007449 RID: 29769 RVA: 0x00217BA0 File Offset: 0x00215DA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600744A RID: 29770 RVA: 0x00217BD4 File Offset: 0x00215DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177961, XrefRangeEnd = 177968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002035 RID: 8245
			// (get) Token: 0x0600744B RID: 29771 RVA: 0x00217C10 File Offset: 0x00215E10
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600744C RID: 29772 RVA: 0x00217C50 File Offset: 0x00215E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177968, XrefRangeEnd = 177973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002036 RID: 8246
			// (get) Token: 0x0600744D RID: 29773 RVA: 0x00217C84 File Offset: 0x00215E84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600744E RID: 29774 RVA: 0x00217CC4 File Offset: 0x00215EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177973, XrefRangeEnd = 177982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x0600744F RID: 29775 RVA: 0x00217D04 File Offset: 0x00215F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleFactionCardCounts._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007450 RID: 29776 RVA: 0x0002E948 File Offset: 0x0002CB48
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700202F RID: 8239
			// (get) Token: 0x06007451 RID: 29777 RVA: 0x00217D44 File Offset: 0x00215F44
			// (set) Token: 0x06007452 RID: 29778 RVA: 0x0002E951 File Offset: 0x0002CB51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002030 RID: 8240
			// (get) Token: 0x06007453 RID: 29779 RVA: 0x00217D6C File Offset: 0x00215F6C
			// (set) Token: 0x06007454 RID: 29780 RVA: 0x0002E96C File Offset: 0x0002CB6C
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002031 RID: 8241
			// (get) Token: 0x06007455 RID: 29781 RVA: 0x00217D9C File Offset: 0x00215F9C
			// (set) Token: 0x06007456 RID: 29782 RVA: 0x0002E98B File Offset: 0x0002CB8B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002032 RID: 8242
			// (get) Token: 0x06007457 RID: 29783 RVA: 0x00217DC4 File Offset: 0x00215FC4
			// (set) Token: 0x06007458 RID: 29784 RVA: 0x0002E9A6 File Offset: 0x0002CBA6
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002033 RID: 8243
			// (get) Token: 0x06007459 RID: 29785 RVA: 0x00217DF4 File Offset: 0x00215FF4
			// (set) Token: 0x0600745A RID: 29786 RVA: 0x0002E9C5 File Offset: 0x0002CBC5
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002034 RID: 8244
			// (get) Token: 0x0600745B RID: 29787 RVA: 0x00217E24 File Offset: 0x00216024
			// (set) Token: 0x0600745C RID: 29788 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
			public unsafe DoubleFactionCardCounts __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleFactionCardCounts>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleFactionCardCounts._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B01 RID: 19201
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004B02 RID: 19202
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004B03 RID: 19203
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004B04 RID: 19204
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04004B05 RID: 19205
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04004B06 RID: 19206
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004B07 RID: 19207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004B08 RID: 19208
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B09 RID: 19209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004B0A RID: 19210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004B0B RID: 19211
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B0C RID: 19212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B0D RID: 19213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004B0E RID: 19214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
