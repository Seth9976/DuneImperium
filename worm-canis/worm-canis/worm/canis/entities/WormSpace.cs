using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.archetypes;

namespace worm.canis.entities
{
	// Token: 0x02000036 RID: 54
	public class WormSpace : WormEntity
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x0007D1F0 File Offset: 0x0007B3F0
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpace()
		{
			Il2CppClassPointerStore<WormSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormSpace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpace>.NativeClassPtr);
			WormSpace.NativeFieldInfoPtr_abilitiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, "abilitiesContainer");
			WormSpace.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664601);
			WormSpace.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664602);
			WormSpace.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664603);
			WormSpace.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664604);
			WormSpace.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664605);
			WormSpace.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664606);
			WormSpace.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664607);
			WormSpace.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664608);
			WormSpace.NativeMethodInfoPtr_get_Agents_Public_get_IEnumerable_1_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664609);
			WormSpace.NativeMethodInfoPtr_PlayerAgent_Public_WormAgent_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664610);
			WormSpace.NativeMethodInfoPtr_get_ControllingPlayer_Public_get_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664611);
			WormSpace.NativeMethodInfoPtr_get_HasAgent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664612);
			WormSpace.NativeMethodInfoPtr_ValueForPlayer_Public_AIValueSummer_1_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, 100664613);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0007D338 File Offset: 0x0007B538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 47606, RefRangeEnd = 47611, XrefRangeStart = 47582, XrefRangeEnd = 47606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpace(WormMatch m, WormArchetype archetype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0007D398 File Offset: 0x0007B598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47612, RefRangeEnd = 47614, XrefRangeStart = 47611, XrefRangeEnd = 47612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpace(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0007D408 File Offset: 0x0007B608
		public unsafe virtual IEnumerable<AbilityDefinition> BaseAbilities
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 47618, RefRangeEnd = 47643, XrefRangeStart = 47614, XrefRangeEnd = 47618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0007D448 File Offset: 0x0007B648
		public unsafe virtual Entity AbilitiesContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0007D488 File Offset: 0x0007B688
		public unsafe virtual IEnumerable<WormAbilityDefinition> Abilities
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 47618, RefRangeEnd = 47643, XrefRangeStart = 47618, XrefRangeEnd = 47643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47643, XrefRangeEnd = 47647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSerializedChildAbilities(Entity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0007D50C File Offset: 0x0007B70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSerializedChildAbilities(WormEntity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0007D550 File Offset: 0x0007B750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47654, RefRangeEnd = 47656, XrefRangeStart = 47647, XrefRangeEnd = 47654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> AddChildAbility(WormAbilityDefinition abilityDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0007D5A0 File Offset: 0x0007B7A0
		public unsafe IEnumerable<WormAgent> Agents
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 47659, RefRangeEnd = 47669, XrefRangeStart = 47656, XrefRangeEnd = 47659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_Agents_Public_get_IEnumerable_1_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007D5E0 File Offset: 0x0007B7E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47687, RefRangeEnd = 47690, XrefRangeStart = 47669, XrefRangeEnd = 47687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgent PlayerAgent(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_PlayerAgent_Public_WormAgent_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr3) : null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0007D630 File Offset: 0x0007B830
		public unsafe WormPlayer ControllingPlayer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 47721, RefRangeEnd = 47735, XrefRangeStart = 47690, XrefRangeEnd = 47721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_ControllingPlayer_Public_get_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0007D670 File Offset: 0x0007B870
		public unsafe bool HasAgent
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 47756, RefRangeEnd = 47765, XrefRangeStart = 47735, XrefRangeEnd = 47756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_get_HasAgent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0007D6AC File Offset: 0x0007B8AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47801, RefRangeEnd = 47804, XrefRangeStart = 47765, XrefRangeEnd = 47801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> ValueForPlayer(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.NativeMethodInfoPtr_ValueForPlayer_Public_AIValueSummer_1_Double_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public WormSpace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0007D6FC File Offset: 0x0007B8FC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003CBA File Offset: 0x00001EBA
		public unsafe WormEntity abilitiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.NativeFieldInfoPtr_abilitiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.NativeFieldInfoPtr_abilitiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesContainer;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormArchetype_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_Agents_Public_get_IEnumerable_1_WormAgent_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_PlayerAgent_Public_WormAgent_WormPlayer_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_ControllingPlayer_Public_get_WormPlayer_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAgent_Public_get_Boolean_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_AIValueSummer_1_Double_WormPlayer_0;

		// Token: 0x020005D0 RID: 1488
		[ObfuscatedName("worm.canis.entities.WormSpace+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004850 RID: 18512 RVA: 0x0018E37C File Offset: 0x0018C57C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr);
				WormSpace.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, "<>9");
				WormSpace.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, "<>9__16_0");
				WormSpace.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, "<>9__18_0");
				WormSpace.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, "<>9__19_1");
				WormSpace.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, 100664615);
				WormSpace.__c.NativeMethodInfoPtr__get_ControllingPlayer_b__16_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, 100664616);
				WormSpace.__c.NativeMethodInfoPtr__get_HasAgent_b__18_0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, 100664617);
				WormSpace.__c.NativeMethodInfoPtr__ValueForPlayer_b__19_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr, 100664618);
			}

			// Token: 0x06004851 RID: 18513 RVA: 0x0018E448 File Offset: 0x0018C648
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004852 RID: 18514 RVA: 0x0018E484 File Offset: 0x0018C684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47536, XrefRangeEnd = 47541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ControllingPlayer_b__16_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c.NativeMethodInfoPtr__get_ControllingPlayer_b__16_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004853 RID: 18515 RVA: 0x0018E4D4 File Offset: 0x0018C6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47541, XrefRangeEnd = 47548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasAgent_b__18_0(WormAgent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c.NativeMethodInfoPtr__get_HasAgent_b__18_0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004854 RID: 18516 RVA: 0x0018E524 File Offset: 0x0018C724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47548, XrefRangeEnd = 47551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__19_1(AIValueSummer<double> a, AIValueSummer<double> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c.NativeMethodInfoPtr__ValueForPlayer_b__19_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}

			// Token: 0x06004855 RID: 18517 RVA: 0x0001876C File Offset: 0x0001696C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x06004856 RID: 18518 RVA: 0x0018E588 File Offset: 0x0018C788
			// (set) Token: 0x06004857 RID: 18519 RVA: 0x00018775 File Offset: 0x00016975
			public unsafe static WormSpace.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSpace.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSpace.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x06004858 RID: 18520 RVA: 0x0018E5B0 File Offset: 0x0018C7B0
			// (set) Token: 0x06004859 RID: 18521 RVA: 0x00018787 File Offset: 0x00016987
			public unsafe static Func<Entity, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSpace.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSpace.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x0600485A RID: 18522 RVA: 0x0018E5D8 File Offset: 0x0018C7D8
			// (set) Token: 0x0600485B RID: 18523 RVA: 0x00018799 File Offset: 0x00016999
			public unsafe static Func<WormAgent, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSpace.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAgent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSpace.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x0600485C RID: 18524 RVA: 0x0018E600 File Offset: 0x0018C800
			// (set) Token: 0x0600485D RID: 18525 RVA: 0x000187AB File Offset: 0x000169AB
			public unsafe static Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSpace.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSpace.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F8C RID: 12172
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002F8D RID: 12173
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04002F8E RID: 12174
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04002F8F RID: 12175
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x04002F90 RID: 12176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F91 RID: 12177
			private static readonly IntPtr NativeMethodInfoPtr__get_ControllingPlayer_b__16_0_Internal_Boolean_Entity_0;

			// Token: 0x04002F92 RID: 12178
			private static readonly IntPtr NativeMethodInfoPtr__get_HasAgent_b__18_0_Internal_Boolean_WormAgent_0;

			// Token: 0x04002F93 RID: 12179
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__19_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0;
		}

		// Token: 0x020005D1 RID: 1489
		[ObfuscatedName("worm.canis.entities.WormSpace+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600485E RID: 18526 RVA: 0x0018E628 File Offset: 0x0018C828
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr);
				WormSpace.__c__DisplayClass14_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr, "player");
				WormSpace.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr, 100664619);
				WormSpace.__c__DisplayClass14_0.NativeMethodInfoPtr__PlayerAgent_b__0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr, 100664620);
			}

			// Token: 0x0600485F RID: 18527 RVA: 0x0018E690 File Offset: 0x0018C890
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004860 RID: 18528 RVA: 0x0018E6CC File Offset: 0x0018C8CC
			[CallerCount(0)]
			public unsafe bool _PlayerAgent_b__0(WormAgent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c__DisplayClass14_0.NativeMethodInfoPtr__PlayerAgent_b__0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004861 RID: 18529 RVA: 0x000187BD File Offset: 0x000169BD
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x06004862 RID: 18530 RVA: 0x0018E71C File Offset: 0x0018C91C
			// (set) Token: 0x06004863 RID: 18531 RVA: 0x000187C6 File Offset: 0x000169C6
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.__c__DisplayClass14_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.__c__DisplayClass14_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F94 RID: 12180
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F95 RID: 12181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F96 RID: 12182
			private static readonly IntPtr NativeMethodInfoPtr__PlayerAgent_b__0_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x020005D2 RID: 1490
		[ObfuscatedName("worm.canis.entities.WormSpace+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x06004864 RID: 18532 RVA: 0x0018E74C File Offset: 0x0018C94C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr);
				WormSpace.__c__DisplayClass19_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr, "player");
				WormSpace.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr, 100664621);
				WormSpace.__c__DisplayClass19_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr, 100664622);
			}

			// Token: 0x06004865 RID: 18533 RVA: 0x0018E7B4 File Offset: 0x0018C9B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004866 RID: 18534 RVA: 0x0018E7F0 File Offset: 0x0018C9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47551, XrefRangeEnd = 47555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__0(WormAbilityDefinition d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace.__c__DisplayClass19_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x06004867 RID: 18535 RVA: 0x000187E5 File Offset: 0x000169E5
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x06004868 RID: 18536 RVA: 0x0018E840 File Offset: 0x0018CA40
			// (set) Token: 0x06004869 RID: 18537 RVA: 0x000187EE File Offset: 0x000169EE
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.__c__DisplayClass19_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace.__c__DisplayClass19_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F97 RID: 12183
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F98 RID: 12184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F99 RID: 12185
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x020005D3 RID: 1491
		[ObfuscatedName("worm.canis.entities.WormSpace+<AddChildAbility>d__11")]
		public sealed class _AddChildAbility_d__11 : Object
		{
			// Token: 0x0600486A RID: 18538 RVA: 0x0018E870 File Offset: 0x0018CA70
			// Note: this type is marked as 'beforefieldinit'.
			static _AddChildAbility_d__11()
			{
				Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSpace>.NativeClassPtr, "<AddChildAbility>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr);
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "<>1__state");
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "<>2__current");
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "<>l__initialThreadId");
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "<>4__this");
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr_abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "abilityDefinition");
				WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___3__abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, "<>3__abilityDefinition");
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664623);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664624);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664625);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664626);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664627);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664628);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664629);
				WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr, 100664630);
			}

			// Token: 0x0600486B RID: 18539 RVA: 0x0018E9B4 File Offset: 0x0018CBB4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddChildAbility_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpace._AddChildAbility_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600486C RID: 18540 RVA: 0x0018E9FC File Offset: 0x0018CBFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600486D RID: 18541 RVA: 0x0018EA30 File Offset: 0x0018CC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47555, XrefRangeEnd = 47568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x0600486E RID: 18542 RVA: 0x0018EA6C File Offset: 0x0018CC6C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600486F RID: 18543 RVA: 0x0018EAAC File Offset: 0x0018CCAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47568, XrefRangeEnd = 47573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06004870 RID: 18544 RVA: 0x0018EAE0 File Offset: 0x0018CCE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004871 RID: 18545 RVA: 0x0018EB20 File Offset: 0x0018CD20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47573, XrefRangeEnd = 47582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004872 RID: 18546 RVA: 0x0018EB60 File Offset: 0x0018CD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpace._AddChildAbility_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004873 RID: 18547 RVA: 0x0001880D File Offset: 0x00016A0D
			public _AddChildAbility_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06004874 RID: 18548 RVA: 0x0018EBA0 File Offset: 0x0018CDA0
			// (set) Token: 0x06004875 RID: 18549 RVA: 0x00018816 File Offset: 0x00016A16
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06004876 RID: 18550 RVA: 0x0018EBC8 File Offset: 0x0018CDC8
			// (set) Token: 0x06004877 RID: 18551 RVA: 0x00018831 File Offset: 0x00016A31
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06004878 RID: 18552 RVA: 0x0018EBF8 File Offset: 0x0018CDF8
			// (set) Token: 0x06004879 RID: 18553 RVA: 0x00018850 File Offset: 0x00016A50
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x0600487A RID: 18554 RVA: 0x0018EC20 File Offset: 0x0018CE20
			// (set) Token: 0x0600487B RID: 18555 RVA: 0x0001886B File Offset: 0x00016A6B
			public unsafe WormSpace __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x0600487C RID: 18556 RVA: 0x0018EC50 File Offset: 0x0018CE50
			// (set) Token: 0x0600487D RID: 18557 RVA: 0x0001888A File Offset: 0x00016A8A
			public unsafe WormAbilityDefinition abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr_abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr_abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x0600487E RID: 18558 RVA: 0x0018EC80 File Offset: 0x0018CE80
			// (set) Token: 0x0600487F RID: 18559 RVA: 0x000188A9 File Offset: 0x00016AA9
			public unsafe WormAbilityDefinition __3__abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___3__abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpace._AddChildAbility_d__11.NativeFieldInfoPtr___3__abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F9A RID: 12186
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F9B RID: 12187
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F9C RID: 12188
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F9D RID: 12189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F9E RID: 12190
			private static readonly IntPtr NativeFieldInfoPtr_abilityDefinition;

			// Token: 0x04002F9F RID: 12191
			private static readonly IntPtr NativeFieldInfoPtr___3__abilityDefinition;

			// Token: 0x04002FA0 RID: 12192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002FA1 RID: 12193
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FA2 RID: 12194
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FA3 RID: 12195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002FA4 RID: 12196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FA5 RID: 12197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FA6 RID: 12198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002FA7 RID: 12199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
