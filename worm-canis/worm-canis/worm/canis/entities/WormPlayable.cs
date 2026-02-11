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
	// Token: 0x0200002F RID: 47
	public class WormPlayable : WormEntity
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00077D44 File Offset: 0x00075F44
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayable()
		{
			Il2CppClassPointerStore<WormPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr);
			WormPlayable.NativeFieldInfoPtr_abilitiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, "abilitiesContainer");
			WormPlayable.NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_Archetype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664132);
			WormPlayable.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664133);
			WormPlayable.NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664134);
			WormPlayable.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664135);
			WormPlayable.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664136);
			WormPlayable.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664137);
			WormPlayable.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664138);
			WormPlayable.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664139);
			WormPlayable.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664140);
			WormPlayable.NativeMethodInfoPtr_SelectableAbilities_Public_IEnumerable_1_WormAbilityDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, 100664141);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00077E50 File Offset: 0x00076050
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38866, RefRangeEnd = 38871, XrefRangeStart = 38852, XrefRangeEnd = 38866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayable(Match m, PlayerEntity owner, Archetype arch, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_Archetype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00077ED4 File Offset: 0x000760D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 35608, RefRangeEnd = 35618, XrefRangeStart = 35608, XrefRangeEnd = 35618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayable(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00077F44 File Offset: 0x00076144
		[CallerCount(0)]
		public unsafe virtual bool IsInPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayable.NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00077F8C File Offset: 0x0007618C
		public unsafe virtual IEnumerable<AbilityDefinition> BaseAbilities
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 38875, RefRangeEnd = 38950, XrefRangeStart = 38871, XrefRangeEnd = 38875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00077FCC File Offset: 0x000761CC
		public unsafe virtual Entity AbilitiesContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0007800C File Offset: 0x0007620C
		public unsafe virtual IEnumerable<WormAbilityDefinition> Abilities
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 38875, RefRangeEnd = 38950, XrefRangeStart = 38875, XrefRangeEnd = 38950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0007804C File Offset: 0x0007624C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38950, XrefRangeEnd = 38954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSerializedChildAbilities(Entity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00078090 File Offset: 0x00076290
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000780D4 File Offset: 0x000762D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38961, RefRangeEnd = 38966, XrefRangeStart = 38954, XrefRangeEnd = 38961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> AddChildAbility(WormAbilityDefinition abilityDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00078124 File Offset: 0x00076324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 38983, RefRangeEnd = 38986, XrefRangeStart = 38966, XrefRangeEnd = 38983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormAbilityDefinition> SelectableAbilities(bool checkExhausted = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkExhausted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.NativeMethodInfoPtr_SelectableAbilities_Public_IEnumerable_1_WormAbilityDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000378C File Offset: 0x0000198C
		public WormPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00078170 File Offset: 0x00076370
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00003795 File Offset: 0x00001995
		public unsafe WormEntity abilitiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable.NativeFieldInfoPtr_abilitiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable.NativeFieldInfoPtr_abilitiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesContainer;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_Archetype_String_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_SelectableAbilities_Public_IEnumerable_1_WormAbilityDefinition_Boolean_0;

		// Token: 0x020005A0 RID: 1440
		[ObfuscatedName("worm.canis.entities.WormPlayable+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600451D RID: 17693 RVA: 0x00184304 File Offset: 0x00182504
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr);
				WormPlayable.__c__DisplayClass13_0.NativeFieldInfoPtr_checkExhausted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr, "checkExhausted");
				WormPlayable.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr, 100664142);
				WormPlayable.__c__DisplayClass13_0.NativeMethodInfoPtr__SelectableAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr, 100664143);
			}

			// Token: 0x0600451E RID: 17694 RVA: 0x0018436C File Offset: 0x0018256C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayable.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600451F RID: 17695 RVA: 0x001843A8 File Offset: 0x001825A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38821, XrefRangeEnd = 38825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectableAbilities_b__0(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable.__c__DisplayClass13_0.NativeMethodInfoPtr__SelectableAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004520 RID: 17696 RVA: 0x00016E71 File Offset: 0x00015071
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x06004521 RID: 17697 RVA: 0x001843F8 File Offset: 0x001825F8
			// (set) Token: 0x06004522 RID: 17698 RVA: 0x00016E7A File Offset: 0x0001507A
			public unsafe bool checkExhausted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable.__c__DisplayClass13_0.NativeFieldInfoPtr_checkExhausted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable.__c__DisplayClass13_0.NativeFieldInfoPtr_checkExhausted)) = value;
				}
			}

			// Token: 0x04002D93 RID: 11667
			private static readonly IntPtr NativeFieldInfoPtr_checkExhausted;

			// Token: 0x04002D94 RID: 11668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D95 RID: 11669
			private static readonly IntPtr NativeMethodInfoPtr__SelectableAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x020005A1 RID: 1441
		[ObfuscatedName("worm.canis.entities.WormPlayable+<AddChildAbility>d__12")]
		public sealed class _AddChildAbility_d__12 : Object
		{
			// Token: 0x06004523 RID: 17699 RVA: 0x00184420 File Offset: 0x00182620
			// Note: this type is marked as 'beforefieldinit'.
			static _AddChildAbility_d__12()
			{
				Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayable>.NativeClassPtr, "<AddChildAbility>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr);
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "<>1__state");
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "<>2__current");
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "<>4__this");
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr_abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "abilityDefinition");
				WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___3__abilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, "<>3__abilityDefinition");
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664144);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664145);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664146);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664147);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664148);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664149);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664150);
				WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr, 100664151);
			}

			// Token: 0x06004524 RID: 17700 RVA: 0x00184564 File Offset: 0x00182764
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddChildAbility_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayable._AddChildAbility_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004525 RID: 17701 RVA: 0x001845AC File Offset: 0x001827AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004526 RID: 17702 RVA: 0x001845E0 File Offset: 0x001827E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38825, XrefRangeEnd = 38838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001080 RID: 4224
			// (get) Token: 0x06004527 RID: 17703 RVA: 0x0018461C File Offset: 0x0018281C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004528 RID: 17704 RVA: 0x0018465C File Offset: 0x0018285C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38838, XrefRangeEnd = 38843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x06004529 RID: 17705 RVA: 0x00184690 File Offset: 0x00182890
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600452A RID: 17706 RVA: 0x001846D0 File Offset: 0x001828D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38843, XrefRangeEnd = 38852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600452B RID: 17707 RVA: 0x00184710 File Offset: 0x00182910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayable._AddChildAbility_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600452C RID: 17708 RVA: 0x00016E95 File Offset: 0x00015095
			public _AddChildAbility_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107A RID: 4218
			// (get) Token: 0x0600452D RID: 17709 RVA: 0x00184750 File Offset: 0x00182950
			// (set) Token: 0x0600452E RID: 17710 RVA: 0x00016E9E File Offset: 0x0001509E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700107B RID: 4219
			// (get) Token: 0x0600452F RID: 17711 RVA: 0x00184778 File Offset: 0x00182978
			// (set) Token: 0x06004530 RID: 17712 RVA: 0x00016EB9 File Offset: 0x000150B9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107C RID: 4220
			// (get) Token: 0x06004531 RID: 17713 RVA: 0x001847A8 File Offset: 0x001829A8
			// (set) Token: 0x06004532 RID: 17714 RVA: 0x00016ED8 File Offset: 0x000150D8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700107D RID: 4221
			// (get) Token: 0x06004533 RID: 17715 RVA: 0x001847D0 File Offset: 0x001829D0
			// (set) Token: 0x06004534 RID: 17716 RVA: 0x00016EF3 File Offset: 0x000150F3
			public unsafe WormPlayable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x06004535 RID: 17717 RVA: 0x00184800 File Offset: 0x00182A00
			// (set) Token: 0x06004536 RID: 17718 RVA: 0x00016F12 File Offset: 0x00015112
			public unsafe WormAbilityDefinition abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr_abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr_abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x06004537 RID: 17719 RVA: 0x00184830 File Offset: 0x00182A30
			// (set) Token: 0x06004538 RID: 17720 RVA: 0x00016F31 File Offset: 0x00015131
			public unsafe WormAbilityDefinition __3__abilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___3__abilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayable._AddChildAbility_d__12.NativeFieldInfoPtr___3__abilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D96 RID: 11670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D97 RID: 11671
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D98 RID: 11672
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D99 RID: 11673
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D9A RID: 11674
			private static readonly IntPtr NativeFieldInfoPtr_abilityDefinition;

			// Token: 0x04002D9B RID: 11675
			private static readonly IntPtr NativeFieldInfoPtr___3__abilityDefinition;

			// Token: 0x04002D9C RID: 11676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D9D RID: 11677
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D9E RID: 11678
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D9F RID: 11679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002DA0 RID: 11680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002DA1 RID: 11681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002DA2 RID: 11682
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002DA3 RID: 11683
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
