using System;
using Canis.actions;
using canis.archetypes;
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
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx
{
	// Token: 0x0200039B RID: 923
	public class OverpoweringDreadCombatIntrigue : RuleModAbility
	{
		// Token: 0x06002680 RID: 9856 RVA: 0x000F46F0 File Offset: 0x000F28F0
		// Note: this type is marked as 'beforefieldinit'.
		static OverpoweringDreadCombatIntrigue()
		{
			Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx", "OverpoweringDreadCombatIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr);
			OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, "AbilityName");
			OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, "AbilityID");
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674124);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674125);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674126);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674127);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674128);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674129);
			OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__IsValidFor_b__6_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, 100674131);
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000F47D4 File Offset: 0x000F29D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192495, XrefRangeEnd = 192499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x000F4820 File Offset: 0x000F2A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192499, XrefRangeEnd = 192505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x000F487C File Offset: 0x000F2A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192505, XrefRangeEnd = 192508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverpoweringDreadCombatIntrigue(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverpoweringDreadCombatIntrigue(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000F4938 File Offset: 0x000F2B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192508, XrefRangeEnd = 192520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000F4994 File Offset: 0x000F2B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192520, XrefRangeEnd = 192526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000F4A14 File Offset: 0x000F2C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192526, XrefRangeEnd = 192546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _IsValidFor_b__6_0(WormPlayer p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.NativeMethodInfoPtr__IsValidFor_b__6_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x0000EC0D File Offset: 0x0000CE0D
		public OverpoweringDreadCombatIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x000F4A64 File Offset: 0x000F2C64
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x0000EC16 File Offset: 0x0000CE16
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x000F4A84 File Offset: 0x000F2C84
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x0000EC28 File Offset: 0x0000CE28
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OverpoweringDreadCombatIntrigue.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__6_0_Private_Boolean_WormPlayer_0;

		// Token: 0x02000907 RID: 2311
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OverpoweringDreadCombatIntrigue+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008945 RID: 35141 RVA: 0x00255C2C File Offset: 0x00253E2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr);
				OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, "<>9");
				OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, "<>9__6_1");
				OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, "<>9__7_0");
				OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, 100674133);
				OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__IsValidFor_b__6_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, 100674134);
				OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr, 100674135);
			}

			// Token: 0x06008946 RID: 35142 RVA: 0x00255CD0 File Offset: 0x00253ED0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008947 RID: 35143 RVA: 0x00255D0C File Offset: 0x00253F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192437, XrefRangeEnd = 192438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__6_1(Entity t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__IsValidFor_b__6_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008948 RID: 35144 RVA: 0x00255D5C File Offset: 0x00253F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192438, XrefRangeEnd = 192446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008949 RID: 35145 RVA: 0x0003A598 File Offset: 0x00038798
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027C4 RID: 10180
			// (get) Token: 0x0600894A RID: 35146 RVA: 0x00255DAC File Offset: 0x00253FAC
			// (set) Token: 0x0600894B RID: 35147 RVA: 0x0003A5A1 File Offset: 0x000387A1
			public unsafe static OverpoweringDreadCombatIntrigue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverpoweringDreadCombatIntrigue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027C5 RID: 10181
			// (get) Token: 0x0600894C RID: 35148 RVA: 0x00255DD4 File Offset: 0x00253FD4
			// (set) Token: 0x0600894D RID: 35149 RVA: 0x0003A5B3 File Offset: 0x000387B3
			public unsafe static Func<Entity, bool> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027C6 RID: 10182
			// (get) Token: 0x0600894E RID: 35150 RVA: 0x00255DFC File Offset: 0x00253FFC
			// (set) Token: 0x0600894F RID: 35151 RVA: 0x0003A5C5 File Offset: 0x000387C5
			public unsafe static Func<Archetype, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OverpoweringDreadCombatIntrigue.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057C6 RID: 22470
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040057C7 RID: 22471
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x040057C8 RID: 22472
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040057C9 RID: 22473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057CA RID: 22474
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__6_1_Internal_Boolean_Entity_0;

			// Token: 0x040057CB RID: 22475
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x02000908 RID: 2312
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OverpoweringDreadCombatIntrigue+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06008950 RID: 35152 RVA: 0x00255E24 File Offset: 0x00254024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr);
				OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr, "player");
				OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr, 100674136);
				OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr, 100674137);
			}

			// Token: 0x06008951 RID: 35153 RVA: 0x00255E8C File Offset: 0x0025408C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008952 RID: 35154 RVA: 0x00255EC8 File Offset: 0x002540C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192446, XrefRangeEnd = 192450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__1(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06008953 RID: 35155 RVA: 0x0003A5D7 File Offset: 0x000387D7
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027C7 RID: 10183
			// (get) Token: 0x06008954 RID: 35156 RVA: 0x00255F18 File Offset: 0x00254118
			// (set) Token: 0x06008955 RID: 35157 RVA: 0x0003A5E0 File Offset: 0x000387E0
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057CC RID: 22476
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040057CD RID: 22477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040057CE RID: 22478
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000909 RID: 2313
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RiseOfIx.OverpoweringDreadCombatIntrigue+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x06008956 RID: 35158 RVA: 0x00255F48 File Offset: 0x00254148
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "match");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<>8__1");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr__copy_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, "<copy>5__2");
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674138);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674139);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674140);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674141);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674142);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674143);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674144);
				OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr, 100674145);
			}

			// Token: 0x06008957 RID: 35159 RVA: 0x002560C8 File Offset: 0x002542C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverpoweringDreadCombatIntrigue._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008958 RID: 35160 RVA: 0x00256110 File Offset: 0x00254310
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008959 RID: 35161 RVA: 0x00256144 File Offset: 0x00254344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192450, XrefRangeEnd = 192481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170027D1 RID: 10193
			// (get) Token: 0x0600895A RID: 35162 RVA: 0x00256180 File Offset: 0x00254380
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600895B RID: 35163 RVA: 0x002561C0 File Offset: 0x002543C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192481, XrefRangeEnd = 192486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170027D2 RID: 10194
			// (get) Token: 0x0600895C RID: 35164 RVA: 0x002561F4 File Offset: 0x002543F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600895D RID: 35165 RVA: 0x00256234 File Offset: 0x00254434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192486, XrefRangeEnd = 192495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600895E RID: 35166 RVA: 0x00256274 File Offset: 0x00254474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600895F RID: 35167 RVA: 0x0003A5FF File Offset: 0x000387FF
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170027C8 RID: 10184
			// (get) Token: 0x06008960 RID: 35168 RVA: 0x002562B4 File Offset: 0x002544B4
			// (set) Token: 0x06008961 RID: 35169 RVA: 0x0003A608 File Offset: 0x00038808
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170027C9 RID: 10185
			// (get) Token: 0x06008962 RID: 35170 RVA: 0x002562DC File Offset: 0x002544DC
			// (set) Token: 0x06008963 RID: 35171 RVA: 0x0003A623 File Offset: 0x00038823
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027CA RID: 10186
			// (get) Token: 0x06008964 RID: 35172 RVA: 0x0025630C File Offset: 0x0025450C
			// (set) Token: 0x06008965 RID: 35173 RVA: 0x0003A642 File Offset: 0x00038842
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170027CB RID: 10187
			// (get) Token: 0x06008966 RID: 35174 RVA: 0x00256334 File Offset: 0x00254534
			// (set) Token: 0x06008967 RID: 35175 RVA: 0x0003A65D File Offset: 0x0003885D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027CC RID: 10188
			// (get) Token: 0x06008968 RID: 35176 RVA: 0x00256364 File Offset: 0x00254564
			// (set) Token: 0x06008969 RID: 35177 RVA: 0x0003A67C File Offset: 0x0003887C
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027CD RID: 10189
			// (get) Token: 0x0600896A RID: 35178 RVA: 0x00256394 File Offset: 0x00254594
			// (set) Token: 0x0600896B RID: 35179 RVA: 0x0003A69B File Offset: 0x0003889B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027CE RID: 10190
			// (get) Token: 0x0600896C RID: 35180 RVA: 0x002563C4 File Offset: 0x002545C4
			// (set) Token: 0x0600896D RID: 35181 RVA: 0x0003A6BA File Offset: 0x000388BA
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027CF RID: 10191
			// (get) Token: 0x0600896E RID: 35182 RVA: 0x002563F4 File Offset: 0x002545F4
			// (set) Token: 0x0600896F RID: 35183 RVA: 0x0003A6D9 File Offset: 0x000388D9
			public unsafe OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverpoweringDreadCombatIntrigue.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170027D0 RID: 10192
			// (get) Token: 0x06008970 RID: 35184 RVA: 0x00256424 File Offset: 0x00254624
			// (set) Token: 0x06008971 RID: 35185 RVA: 0x0003A6F8 File Offset: 0x000388F8
			public unsafe Entity _copy_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr__copy_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverpoweringDreadCombatIntrigue._BeginExecution_d__7.NativeFieldInfoPtr__copy_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040057CF RID: 22479
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040057D0 RID: 22480
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040057D1 RID: 22481
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040057D2 RID: 22482
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040057D3 RID: 22483
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040057D4 RID: 22484
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040057D5 RID: 22485
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040057D6 RID: 22486
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040057D7 RID: 22487
			private static readonly IntPtr NativeFieldInfoPtr__copy_5__2;

			// Token: 0x040057D8 RID: 22488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040057D9 RID: 22489
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057DA RID: 22490
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040057DB RID: 22491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040057DC RID: 22492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040057DD RID: 22493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040057DE RID: 22494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040057DF RID: 22495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
