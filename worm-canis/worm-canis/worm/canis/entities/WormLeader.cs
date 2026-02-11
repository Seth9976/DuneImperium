using System;
using Canis;
using Canis.actions;
using canis.archetypes;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;

namespace worm.canis.entities
{
	// Token: 0x0200002E RID: 46
	public class WormLeader : WormEntity
	{
		// Token: 0x06000398 RID: 920 RVA: 0x000778C8 File Offset: 0x00075AC8
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeader()
		{
			Il2CppClassPointerStore<WormLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeader>.NativeClassPtr);
			WormLeader.NativeFieldInfoPtr_abilitiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, "abilitiesContainer");
			WormLeader.NativeFieldInfoPtr__AgentSupply_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, "<AgentSupply>k__BackingField");
			WormLeader.NativeMethodInfoPtr_get_AgentSupply_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664114);
			WormLeader.NativeMethodInfoPtr_set_AgentSupply_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664115);
			WormLeader.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664116);
			WormLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664117);
			WormLeader.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664118);
			WormLeader.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664119);
			WormLeader.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664120);
			WormLeader.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664121);
			WormLeader.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664122);
			WormLeader.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, 100664123);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000399 RID: 921 RVA: 0x000779E8 File Offset: 0x00075BE8
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00077A28 File Offset: 0x00075C28
		public unsafe WormPlayArea AgentSupply
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_get_AgentSupply_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_set_AgentSupply_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00077A6C File Offset: 0x00075C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38784, RefRangeEnd = 38785, XrefRangeStart = 38744, XrefRangeEnd = 38784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeader(WormMatch m, PlayerEntity owner, Archetype arch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00077ADC File Offset: 0x00075CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38786, RefRangeEnd = 38788, XrefRangeStart = 38785, XrefRangeEnd = 38786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeader(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeader>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00077B4C File Offset: 0x00075D4C
		public unsafe virtual IEnumerable<AbilityDefinition> BaseAbilities
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 38792, RefRangeEnd = 38809, XrefRangeStart = 38788, XrefRangeEnd = 38792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00077B8C File Offset: 0x00075D8C
		public unsafe virtual Entity AbilitiesContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00077BCC File Offset: 0x00075DCC
		public unsafe virtual IEnumerable<WormAbilityDefinition> Abilities
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 38792, RefRangeEnd = 38809, XrefRangeStart = 38792, XrefRangeEnd = 38809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00077C0C File Offset: 0x00075E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38809, XrefRangeEnd = 38813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSerializedChildAbilities(Entity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00077C50 File Offset: 0x00075E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38813, XrefRangeEnd = 38814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSerializedChildAbilities(WormEntity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00077C94 File Offset: 0x00075E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38814, XrefRangeEnd = 38821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> AddChildAbility(WormAbilityDefinition abilityDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00003745 File Offset: 0x00001945
		public WormLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00077CE4 File Offset: 0x00075EE4
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000374E File Offset: 0x0000194E
		public unsafe WormEntity abilitiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader.NativeFieldInfoPtr_abilitiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader.NativeFieldInfoPtr_abilitiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00077D14 File Offset: 0x00075F14
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000376D File Offset: 0x0000196D
		public unsafe WormPlayArea _AgentSupply_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader.NativeFieldInfoPtr__AgentSupply_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader.NativeFieldInfoPtr__AgentSupply_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesContainer;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr__AgentSupply_k__BackingField;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_get_AgentSupply_Public_get_WormPlayArea_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_set_AgentSupply_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_Archetype_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0;

		// Token: 0x0200059F RID: 1439
		[ObfuscatedName("worm.canis.entities.WormLeader+<AddChildAbility>d__15")]
		public sealed class _AddChildAbility_d__15 : Object
		{
			// Token: 0x06004507 RID: 17671 RVA: 0x00183EC4 File Offset: 0x001820C4
			// Note: this type is marked as 'beforefieldinit'.
			static _AddChildAbility_d__15()
			{
				Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeader>.NativeClassPtr, "<AddChildAbility>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr);
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "<>1__state");
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "<>2__current");
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "<>l__initialThreadId");
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "<>4__this");
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr_abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "abilityDefinition");
				WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___3__abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, "<>3__abilityDefinition");
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664124);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664125);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664126);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664127);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664128);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664129);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664130);
				WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr, 100664131);
			}

			// Token: 0x06004508 RID: 17672 RVA: 0x00184008 File Offset: 0x00182208
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddChildAbility_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeader._AddChildAbility_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004509 RID: 17673 RVA: 0x00184050 File Offset: 0x00182250
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600450A RID: 17674 RVA: 0x00184084 File Offset: 0x00182284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38717, XrefRangeEnd = 38730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001077 RID: 4215
			// (get) Token: 0x0600450B RID: 17675 RVA: 0x001840C0 File Offset: 0x001822C0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600450C RID: 17676 RVA: 0x00184100 File Offset: 0x00182300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38730, XrefRangeEnd = 38735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x0600450D RID: 17677 RVA: 0x00184134 File Offset: 0x00182334
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600450E RID: 17678 RVA: 0x00184174 File Offset: 0x00182374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38735, XrefRangeEnd = 38744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600450F RID: 17679 RVA: 0x001841B4 File Offset: 0x001823B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeader._AddChildAbility_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004510 RID: 17680 RVA: 0x00016DB6 File Offset: 0x00014FB6
			public _AddChildAbility_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001071 RID: 4209
			// (get) Token: 0x06004511 RID: 17681 RVA: 0x001841F4 File Offset: 0x001823F4
			// (set) Token: 0x06004512 RID: 17682 RVA: 0x00016DBF File Offset: 0x00014FBF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001072 RID: 4210
			// (get) Token: 0x06004513 RID: 17683 RVA: 0x0018421C File Offset: 0x0018241C
			// (set) Token: 0x06004514 RID: 17684 RVA: 0x00016DDA File Offset: 0x00014FDA
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001073 RID: 4211
			// (get) Token: 0x06004515 RID: 17685 RVA: 0x0018424C File Offset: 0x0018244C
			// (set) Token: 0x06004516 RID: 17686 RVA: 0x00016DF9 File Offset: 0x00014FF9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001074 RID: 4212
			// (get) Token: 0x06004517 RID: 17687 RVA: 0x00184274 File Offset: 0x00182474
			// (set) Token: 0x06004518 RID: 17688 RVA: 0x00016E14 File Offset: 0x00015014
			public unsafe WormLeader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001075 RID: 4213
			// (get) Token: 0x06004519 RID: 17689 RVA: 0x001842A4 File Offset: 0x001824A4
			// (set) Token: 0x0600451A RID: 17690 RVA: 0x00016E33 File Offset: 0x00015033
			public unsafe WormAbilityDefinition abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr_abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr_abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001076 RID: 4214
			// (get) Token: 0x0600451B RID: 17691 RVA: 0x001842D4 File Offset: 0x001824D4
			// (set) Token: 0x0600451C RID: 17692 RVA: 0x00016E52 File Offset: 0x00015052
			public unsafe WormAbilityDefinition __3__abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___3__abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeader._AddChildAbility_d__15.NativeFieldInfoPtr___3__abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D85 RID: 11653
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D86 RID: 11654
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D87 RID: 11655
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D88 RID: 11656
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D89 RID: 11657
			private static readonly IntPtr NativeFieldInfoPtr_abilityDefinition;

			// Token: 0x04002D8A RID: 11658
			private static readonly IntPtr NativeFieldInfoPtr___3__abilityDefinition;

			// Token: 0x04002D8B RID: 11659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D8C RID: 11660
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D8D RID: 11661
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D8E RID: 11662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002D8F RID: 11663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D90 RID: 11664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002D91 RID: 11665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002D92 RID: 11666
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
