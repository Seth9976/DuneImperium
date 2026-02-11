using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
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

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x02000456 RID: 1110
	public class CounterattackCombatAbility : StrengthIntrigueAbility
	{
		// Token: 0x060030B5 RID: 12469 RVA: 0x00125C9C File Offset: 0x00123E9C
		// Note: this type is marked as 'beforefieldinit'.
		static CounterattackCombatAbility()
		{
			Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "CounterattackCombatAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr);
			CounterattackCombatAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, "AbilityName");
			CounterattackCombatAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, "AbilityID");
			CounterattackCombatAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678277);
			CounterattackCombatAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678278);
			CounterattackCombatAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678279);
			CounterattackCombatAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678280);
			CounterattackCombatAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678281);
			CounterattackCombatAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678282);
			CounterattackCombatAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, 100678283);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00125D80 File Offset: 0x00123F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224969, XrefRangeEnd = 224973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CounterattackCombatAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00125DCC File Offset: 0x00123FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224973, XrefRangeEnd = 224979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CounterattackCombatAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00125E28 File Offset: 0x00124028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224979, XrefRangeEnd = 224982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterattackCombatAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00125E74 File Offset: 0x00124074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterattackCombatAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00125EE4 File Offset: 0x001240E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224982, XrefRangeEnd = 224986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CounterattackCombatAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00125F54 File Offset: 0x00124154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224986, XrefRangeEnd = 224993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CounterattackCombatAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00125FD4 File Offset: 0x001241D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224993, XrefRangeEnd = 224998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowHinting(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CounterattackCombatAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00011283 File Offset: 0x0000F483
		public CounterattackCombatAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x00126040 File Offset: 0x00124240
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x0001128C File Offset: 0x0000F48C
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CounterattackCombatAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterattackCombatAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x00126060 File Offset: 0x00124260
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x0001129E File Offset: 0x0000F49E
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CounterattackCombatAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterattackCombatAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x02000A91 RID: 2705
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.CounterattackCombatAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600A9EF RID: 43503 RVA: 0x002B57DC File Offset: 0x002B39DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr);
				CounterattackCombatAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, "<>9");
				CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, "<>9__7_0");
				CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, "<>9__8_0");
				CounterattackCombatAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, 100678286);
				CounterattackCombatAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, 100678287);
				CounterattackCombatAbility.__c.NativeMethodInfoPtr__ShowHinting_b__8_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr, 100678288);
			}

			// Token: 0x0600A9F0 RID: 43504 RVA: 0x002B5880 File Offset: 0x002B3A80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterattackCombatAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A9F1 RID: 43505 RVA: 0x002B58BC File Offset: 0x002B3ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224914, XrefRangeEnd = 224918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__7_0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600A9F2 RID: 43506 RVA: 0x002B590C File Offset: 0x002B3B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ShowHinting_b__8_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility.__c.NativeMethodInfoPtr__ShowHinting_b__8_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A9F3 RID: 43507 RVA: 0x0004D2DD File Offset: 0x0004B4DD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170033AD RID: 13229
			// (get) Token: 0x0600A9F4 RID: 43508 RVA: 0x002B595C File Offset: 0x002B3B5C
			// (set) Token: 0x0600A9F5 RID: 43509 RVA: 0x0004D2E6 File Offset: 0x0004B4E6
			public unsafe static CounterattackCombatAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterattackCombatAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AE RID: 13230
			// (get) Token: 0x0600A9F6 RID: 43510 RVA: 0x002B5984 File Offset: 0x002B3B84
			// (set) Token: 0x0600A9F7 RID: 43511 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AF RID: 13231
			// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x002B59AC File Offset: 0x002B3BAC
			// (set) Token: 0x0600A9F9 RID: 43513 RVA: 0x0004D30A File Offset: 0x0004B50A
			public unsafe static Func<WormPlayer, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterattackCombatAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B7D RID: 27517
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006B7E RID: 27518
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04006B7F RID: 27519
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04006B80 RID: 27520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B81 RID: 27521
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006B82 RID: 27522
			private static readonly IntPtr NativeMethodInfoPtr__ShowHinting_b__8_0_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x02000A92 RID: 2706
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.CounterattackCombatAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600A9FA RID: 43514 RVA: 0x002B59D4 File Offset: 0x002B3BD4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterattackCombatAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678289);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678290);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678291);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678292);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678293);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678294);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678295);
				CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678296);
			}

			// Token: 0x0600A9FB RID: 43515 RVA: 0x002B5B2C File Offset: 0x002B3D2C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterattackCombatAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A9FC RID: 43516 RVA: 0x002B5B74 File Offset: 0x002B3D74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A9FD RID: 43517 RVA: 0x002B5BA8 File Offset: 0x002B3DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224918, XrefRangeEnd = 224955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170033B7 RID: 13239
			// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x002B5BE4 File Offset: 0x002B3DE4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A9FF RID: 43519 RVA: 0x002B5C24 File Offset: 0x002B3E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224955, XrefRangeEnd = 224960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170033B8 RID: 13240
			// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x002B5C58 File Offset: 0x002B3E58
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AA01 RID: 43521 RVA: 0x002B5C98 File Offset: 0x002B3E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224960, XrefRangeEnd = 224969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AA02 RID: 43522 RVA: 0x002B5CD8 File Offset: 0x002B3ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AA03 RID: 43523 RVA: 0x0004D31C File Offset: 0x0004B51C
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170033B0 RID: 13232
			// (get) Token: 0x0600AA04 RID: 43524 RVA: 0x002B5D18 File Offset: 0x002B3F18
			// (set) Token: 0x0600AA05 RID: 43525 RVA: 0x0004D325 File Offset: 0x0004B525
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170033B1 RID: 13233
			// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x002B5D40 File Offset: 0x002B3F40
			// (set) Token: 0x0600AA07 RID: 43527 RVA: 0x0004D340 File Offset: 0x0004B540
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B2 RID: 13234
			// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x002B5D70 File Offset: 0x002B3F70
			// (set) Token: 0x0600AA09 RID: 43529 RVA: 0x0004D35F File Offset: 0x0004B55F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170033B3 RID: 13235
			// (get) Token: 0x0600AA0A RID: 43530 RVA: 0x002B5D98 File Offset: 0x002B3F98
			// (set) Token: 0x0600AA0B RID: 43531 RVA: 0x0004D37A File Offset: 0x0004B57A
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B4 RID: 13236
			// (get) Token: 0x0600AA0C RID: 43532 RVA: 0x002B5DC8 File Offset: 0x002B3FC8
			// (set) Token: 0x0600AA0D RID: 43533 RVA: 0x0004D399 File Offset: 0x0004B599
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B5 RID: 13237
			// (get) Token: 0x0600AA0E RID: 43534 RVA: 0x002B5DF8 File Offset: 0x002B3FF8
			// (set) Token: 0x0600AA0F RID: 43535 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B6 RID: 13238
			// (get) Token: 0x0600AA10 RID: 43536 RVA: 0x002B5E28 File Offset: 0x002B4028
			// (set) Token: 0x0600AA11 RID: 43537 RVA: 0x0004D3D7 File Offset: 0x0004B5D7
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterattackCombatAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B83 RID: 27523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006B84 RID: 27524
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006B85 RID: 27525
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006B86 RID: 27526
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006B87 RID: 27527
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006B88 RID: 27528
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006B89 RID: 27529
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006B8A RID: 27530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006B8B RID: 27531
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006B8C RID: 27532
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006B8D RID: 27533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006B8E RID: 27534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006B8F RID: 27535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006B90 RID: 27536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006B91 RID: 27537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
