using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.SpaceAbilities;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x0200045C RID: 1116
	public class GraftAgentAbility : AgentAbility
	{
		// Token: 0x0600311D RID: 12573 RVA: 0x00127C10 File Offset: 0x00125E10
		// Note: this type is marked as 'beforefieldinit'.
		static GraftAgentAbility()
		{
			Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "GraftAgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr);
			GraftAgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "AbilityName");
			GraftAgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "AbilityID");
			GraftAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678451);
			GraftAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678452);
			GraftAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678453);
			GraftAgentAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678454);
			GraftAgentAbility.NativeMethodInfoPtr_GraftTargets_Protected_Virtual_New_List_1_WormImperiumPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678455);
			GraftAgentAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678456);
			GraftAgentAbility.NativeMethodInfoPtr__GraftTargets_b__6_0_Private_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, 100678458);
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00127CF4 File Offset: 0x00125EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227053, XrefRangeEnd = 227057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00127D40 File Offset: 0x00125F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227061, RefRangeEnd = 227062, XrefRangeStart = 227057, XrefRangeEnd = 227061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraftAgentAbility(WormMatch m, string abilityName = "GraftAgentAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00127DA0 File Offset: 0x00125FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227066, RefRangeEnd = 227069, XrefRangeStart = 227062, XrefRangeEnd = 227066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraftAgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00127E10 File Offset: 0x00126010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227069, XrefRangeEnd = 227121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftAgentAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x00127E80 File Offset: 0x00126080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227137, RefRangeEnd = 227138, XrefRangeStart = 227121, XrefRangeEnd = 227137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<WormImperiumPlayable> GraftTargets(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftAgentAbility.NativeMethodInfoPtr_GraftTargets_Protected_Virtual_New_List_1_WormImperiumPlayable_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormImperiumPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00127EDC File Offset: 0x001260DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227138, XrefRangeEnd = 227267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftAgentAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x00127F38 File Offset: 0x00126138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227267, XrefRangeEnd = 227268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GraftTargets_b__6_0(WormImperiumPlayable handCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.NativeMethodInfoPtr__GraftTargets_b__6_0_Private_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x0001144D File Offset: 0x0000F64D
		public GraftAgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x00127F88 File Offset: 0x00126188
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x00011456 File Offset: 0x0000F656
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraftAgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraftAgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x00127FA8 File Offset: 0x001261A8
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00011468 File Offset: 0x0000F668
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraftAgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraftAgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_GraftTargets_Protected_Virtual_New_List_1_WormImperiumPlayable_WormPlayer_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr__GraftTargets_b__6_0_Private_Boolean_WormImperiumPlayable_0;

		// Token: 0x02000AA4 RID: 2724
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GraftAgentAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600AB68 RID: 43880 RVA: 0x002B9C20 File Offset: 0x002B7E20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr);
				GraftAgentAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr, "<>9");
				GraftAgentAbility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr, "<>9__5_0");
				GraftAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr, 100678460);
				GraftAgentAbility.__c.NativeMethodInfoPtr__Cost_b__5_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr, 100678461);
			}

			// Token: 0x0600AB69 RID: 43881 RVA: 0x002B9C9C File Offset: 0x002B7E9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB6A RID: 43882 RVA: 0x002B9CD8 File Offset: 0x002B7ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227039, XrefRangeEnd = 227048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cost_b__5_0(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c.NativeMethodInfoPtr__Cost_b__5_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AB6B RID: 43883 RVA: 0x0004E07A File Offset: 0x0004C27A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003434 RID: 13364
			// (get) Token: 0x0600AB6C RID: 43884 RVA: 0x002B9D28 File Offset: 0x002B7F28
			// (set) Token: 0x0600AB6D RID: 43885 RVA: 0x0004E083 File Offset: 0x0004C283
			public unsafe static GraftAgentAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraftAgentAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraftAgentAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraftAgentAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003435 RID: 13365
			// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x002B9D50 File Offset: 0x002B7F50
			// (set) Token: 0x0600AB6F RID: 43887 RVA: 0x0004E095 File Offset: 0x0004C295
			public unsafe static Func<Entity, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraftAgentAbility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraftAgentAbility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C5D RID: 27741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006C5E RID: 27742
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04006C5F RID: 27743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C60 RID: 27744
			private static readonly IntPtr NativeMethodInfoPtr__Cost_b__5_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000AA5 RID: 2725
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GraftAgentAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600AB70 RID: 43888 RVA: 0x002B9D78 File Offset: 0x002B7F78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr);
				GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, "owner");
				GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, "<>9__0");
				GraftAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678462);
				GraftAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678463);
			}

			// Token: 0x0600AB71 RID: 43889 RVA: 0x002B9E1C File Offset: 0x002B801C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB72 RID: 43890 RVA: 0x002B9E58 File Offset: 0x002B8058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227048, XrefRangeEnd = 227052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600AB73 RID: 43891 RVA: 0x0004E0A7 File Offset: 0x0004C2A7
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003436 RID: 13366
			// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x002B9EA8 File Offset: 0x002B80A8
			// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
			public unsafe GraftAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraftAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003437 RID: 13367
			// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x002B9ED8 File Offset: 0x002B80D8
			// (set) Token: 0x0600AB77 RID: 43895 RVA: 0x0004E0CF File Offset: 0x0004C2CF
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003438 RID: 13368
			// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x002B9F08 File Offset: 0x002B8108
			// (set) Token: 0x0600AB79 RID: 43897 RVA: 0x0004E0EE File Offset: 0x0004C2EE
			public unsafe WormImperiumPlayable owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003439 RID: 13369
			// (get) Token: 0x0600AB7A RID: 43898 RVA: 0x002B9F38 File Offset: 0x002B8138
			// (set) Token: 0x0600AB7B RID: 43899 RVA: 0x0004E10D File Offset: 0x0004C30D
			public unsafe Func<WormAbilityDefinition, AIValueSummer<double>> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C61 RID: 27745
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C62 RID: 27746
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006C63 RID: 27747
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04006C64 RID: 27748
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04006C65 RID: 27749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C66 RID: 27750
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000AA6 RID: 2726
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GraftAgentAbility+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Object
		{
			// Token: 0x0600AB7C RID: 43900 RVA: 0x002B9F68 File Offset: 0x002B8168
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr);
				GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr, "space");
				GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				GraftAgentAbility.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr, 100678464);
			}

			// Token: 0x0600AB7D RID: 43901 RVA: 0x002B9FD0 File Offset: 0x002B81D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB7E RID: 43902 RVA: 0x0004E12C File Offset: 0x0004C32C
			public __c__DisplayClass7_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700343A RID: 13370
			// (get) Token: 0x0600AB7F RID: 43903 RVA: 0x002BA00C File Offset: 0x002B820C
			// (set) Token: 0x0600AB80 RID: 43904 RVA: 0x0004E135 File Offset: 0x0004C335
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700343B RID: 13371
			// (get) Token: 0x0600AB81 RID: 43905 RVA: 0x002BA03C File Offset: 0x002B823C
			// (set) Token: 0x0600AB82 RID: 43906 RVA: 0x0004E154 File Offset: 0x0004C354
			public unsafe GraftAgentAbility.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraftAgentAbility.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C67 RID: 27751
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x04006C68 RID: 27752
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x04006C69 RID: 27753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AA7 RID: 2727
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GraftAgentAbility+<>c__DisplayClass7_2")]
		public sealed class __c__DisplayClass7_2 : Object
		{
			// Token: 0x0600AB83 RID: 43907 RVA: 0x002BA06C File Offset: 0x002B826C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_2()
			{
				Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftAgentAbility>.NativeClassPtr, "<>c__DisplayClass7_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr);
				GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_graftCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr, "graftCard");
				GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr, "CS$<>8__locals2");
				GraftAgentAbility.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr, 100678465);
				GraftAgentAbility.__c__DisplayClass7_2.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr, 100678466);
			}

			// Token: 0x0600AB84 RID: 43908 RVA: 0x002BA0E8 File Offset: 0x002B82E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftAgentAbility.__c__DisplayClass7_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB85 RID: 43909 RVA: 0x002BA124 File Offset: 0x002B8324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227052, XrefRangeEnd = 227053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__1(SpaceAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftAgentAbility.__c__DisplayClass7_2.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AB86 RID: 43910 RVA: 0x0004E173 File Offset: 0x0004C373
			public __c__DisplayClass7_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700343C RID: 13372
			// (get) Token: 0x0600AB87 RID: 43911 RVA: 0x002BA174 File Offset: 0x002B8374
			// (set) Token: 0x0600AB88 RID: 43912 RVA: 0x0004E17C File Offset: 0x0004C37C
			public unsafe WormImperiumPlayable graftCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_graftCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_graftCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700343D RID: 13373
			// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x002BA1A4 File Offset: 0x002B83A4
			// (set) Token: 0x0600AB8A RID: 43914 RVA: 0x0004E19B File Offset: 0x0004C39B
			public unsafe GraftAgentAbility.__c__DisplayClass7_1 field_Public___c__DisplayClass7_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraftAgentAbility.__c__DisplayClass7_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftAgentAbility.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C6A RID: 27754
			private static readonly IntPtr NativeFieldInfoPtr_graftCard;

			// Token: 0x04006C6B RID: 27755
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0;

			// Token: 0x04006C6C RID: 27756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C6D RID: 27757
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_SpaceAbility_0;
		}
	}
}
