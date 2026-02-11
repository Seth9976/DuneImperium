using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities
{
	// Token: 0x0200042C RID: 1068
	public class GainInfluenceIntrigueAbility : IntrigueAbility
	{
		// Token: 0x06002E30 RID: 11824 RVA: 0x00118B08 File Offset: 0x00116D08
		// Note: this type is marked as 'beforefieldinit'.
		static GainInfluenceIntrigueAbility()
		{
			Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities", "GainInfluenceIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677117);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677118);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Abstract_Virtual_New_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677119);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677120);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677121);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677122);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677123);
			GainInfluenceIntrigueAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, 100677124);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00118BD8 File Offset: 0x00116DD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215278, RefRangeEnd = 215282, XrefRangeStart = 215277, XrefRangeEnd = 215278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainInfluenceIntrigueAbility(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00118C48 File Offset: 0x00116E48
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215282, XrefRangeEnd = 215283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainInfluenceIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x00118CB8 File Offset: 0x00116EB8
		public unsafe virtual Factions SpecifiedFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Abstract_Virtual_New_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00118D00 File Offset: 0x00116F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215298, XrefRangeEnd = 215302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00118D70 File Offset: 0x00116F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215302, XrefRangeEnd = 215310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00118DF0 File Offset: 0x00116FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215310, XrefRangeEnd = 215311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00118E5C File Offset: 0x0011705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215311, XrefRangeEnd = 215335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsBadIntrigue(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00118EC8 File Offset: 0x001170C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215335, XrefRangeEnd = 215360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainInfluenceIntrigueAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00010AA1 File Offset: 0x0000ECA1
		public GainInfluenceIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Abstract_Virtual_New_get_Factions_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000A10 RID: 2576
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.GainInfluenceIntrigueAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600A081 RID: 41089 RVA: 0x00299EFC File Offset: 0x002980FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr);
				GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_playerInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr, "playerInfluence");
				GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr, 100677125);
				GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr, 100677126);
				GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__IsBadIntrigue_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr, 100677127);
			}

			// Token: 0x0600A082 RID: 41090 RVA: 0x00299F8C File Offset: 0x0029818C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainInfluenceIntrigueAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A083 RID: 41091 RVA: 0x00299FC8 File Offset: 0x002981C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215231, XrefRangeEnd = 215232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsBadIntrigue_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A084 RID: 41092 RVA: 0x0029A018 File Offset: 0x00298218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215232, XrefRangeEnd = 215233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsBadIntrigue_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__IsBadIntrigue_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A085 RID: 41093 RVA: 0x00047D5F File Offset: 0x00045F5F
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003057 RID: 12375
			// (get) Token: 0x0600A086 RID: 41094 RVA: 0x0029A068 File Offset: 0x00298268
			// (set) Token: 0x0600A087 RID: 41095 RVA: 0x00047D68 File Offset: 0x00045F68
			public unsafe GainInfluenceIntrigueAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainInfluenceIntrigueAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003058 RID: 12376
			// (get) Token: 0x0600A088 RID: 41096 RVA: 0x0029A098 File Offset: 0x00298298
			// (set) Token: 0x0600A089 RID: 41097 RVA: 0x00047D87 File Offset: 0x00045F87
			public unsafe int playerInfluence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_playerInfluence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_playerInfluence)) = value;
				}
			}

			// Token: 0x040065E1 RID: 26081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065E2 RID: 26082
			private static readonly IntPtr NativeFieldInfoPtr_playerInfluence;

			// Token: 0x040065E3 RID: 26083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040065E4 RID: 26084
			private static readonly IntPtr NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040065E5 RID: 26085
			private static readonly IntPtr NativeMethodInfoPtr__IsBadIntrigue_b__1_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000A11 RID: 2577
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.GainInfluenceIntrigueAbility+<RunImmediateEffects>d__5")]
		public sealed class _RunImmediateEffects_d__5 : Object
		{
			// Token: 0x0600A08A RID: 41098 RVA: 0x0029A0C0 File Offset: 0x002982C0
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__5()
			{
				Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainInfluenceIntrigueAbility>.NativeClassPtr, "<RunImmediateEffects>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>1__state");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>2__current");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>l__initialThreadId");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "activeAbility");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>3__activeAbility");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "match");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>3__match");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<>4__this");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, "<player>5__2");
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677128);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677129);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677130);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677131);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677132);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677133);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677134);
				GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr, 100677135);
			}

			// Token: 0x0600A08B RID: 41099 RVA: 0x0029A240 File Offset: 0x00298440
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainInfluenceIntrigueAbility._RunImmediateEffects_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A08C RID: 41100 RVA: 0x0029A288 File Offset: 0x00298488
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A08D RID: 41101 RVA: 0x0029A2BC File Offset: 0x002984BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215233, XrefRangeEnd = 215262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003062 RID: 12386
			// (get) Token: 0x0600A08E RID: 41102 RVA: 0x0029A2F8 File Offset: 0x002984F8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A08F RID: 41103 RVA: 0x0029A338 File Offset: 0x00298538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215262, XrefRangeEnd = 215267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003063 RID: 12387
			// (get) Token: 0x0600A090 RID: 41104 RVA: 0x0029A36C File Offset: 0x0029856C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A091 RID: 41105 RVA: 0x0029A3AC File Offset: 0x002985AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215267, XrefRangeEnd = 215277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A092 RID: 41106 RVA: 0x0029A3EC File Offset: 0x002985EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A093 RID: 41107 RVA: 0x00047DA2 File Offset: 0x00045FA2
			public _RunImmediateEffects_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003059 RID: 12377
			// (get) Token: 0x0600A094 RID: 41108 RVA: 0x0029A42C File Offset: 0x0029862C
			// (set) Token: 0x0600A095 RID: 41109 RVA: 0x00047DAB File Offset: 0x00045FAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700305A RID: 12378
			// (get) Token: 0x0600A096 RID: 41110 RVA: 0x0029A454 File Offset: 0x00298654
			// (set) Token: 0x0600A097 RID: 41111 RVA: 0x00047DC6 File Offset: 0x00045FC6
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305B RID: 12379
			// (get) Token: 0x0600A098 RID: 41112 RVA: 0x0029A484 File Offset: 0x00298684
			// (set) Token: 0x0600A099 RID: 41113 RVA: 0x00047DE5 File Offset: 0x00045FE5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700305C RID: 12380
			// (get) Token: 0x0600A09A RID: 41114 RVA: 0x0029A4AC File Offset: 0x002986AC
			// (set) Token: 0x0600A09B RID: 41115 RVA: 0x00047E00 File Offset: 0x00046000
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305D RID: 12381
			// (get) Token: 0x0600A09C RID: 41116 RVA: 0x0029A4DC File Offset: 0x002986DC
			// (set) Token: 0x0600A09D RID: 41117 RVA: 0x00047E1F File Offset: 0x0004601F
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305E RID: 12382
			// (get) Token: 0x0600A09E RID: 41118 RVA: 0x0029A50C File Offset: 0x0029870C
			// (set) Token: 0x0600A09F RID: 41119 RVA: 0x00047E3E File Offset: 0x0004603E
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700305F RID: 12383
			// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x0029A53C File Offset: 0x0029873C
			// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x00047E5D File Offset: 0x0004605D
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003060 RID: 12384
			// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x0029A56C File Offset: 0x0029876C
			// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x00047E7C File Offset: 0x0004607C
			public unsafe GainInfluenceIntrigueAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainInfluenceIntrigueAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003061 RID: 12385
			// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x0029A59C File Offset: 0x0029879C
			// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x00047E9B File Offset: 0x0004609B
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainInfluenceIntrigueAbility._RunImmediateEffects_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065E6 RID: 26086
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040065E7 RID: 26087
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040065E8 RID: 26088
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040065E9 RID: 26089
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040065EA RID: 26090
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040065EB RID: 26091
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040065EC RID: 26092
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040065ED RID: 26093
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065EE RID: 26094
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040065EF RID: 26095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040065F0 RID: 26096
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065F1 RID: 26097
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040065F2 RID: 26098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040065F3 RID: 26099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040065F4 RID: 26100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040065F5 RID: 26101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040065F6 RID: 26102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
