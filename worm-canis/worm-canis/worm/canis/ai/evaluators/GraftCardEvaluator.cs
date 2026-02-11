using System;
using Canis.context;
using Canis.entities.ai;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.ai.evaluators
{
	// Token: 0x0200021C RID: 540
	public class GraftCardEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x000B5204 File Offset: 0x000B3404
		// Note: this type is marked as 'beforefieldinit'.
		static GraftCardEvaluator()
		{
			Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "GraftCardEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr);
			GraftCardEvaluator.NativeFieldInfoPtr_GraftID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, "GraftID");
			GraftCardEvaluator.NativeFieldInfoPtr_SpaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, "SpaceID");
			GraftCardEvaluator.NativeMethodInfoPtr_GraftCardsValue_Public_Static_AIValueSummer_1_Double_WormMatch_WormPlayer_WormImperiumPlayable_WormImperiumPlayable_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, 100667312);
			GraftCardEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, 100667313);
			GraftCardEvaluator.NativeMethodInfoPtr_ParameterContext_Public_Static_Context_WormPlayer_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, 100667314);
			GraftCardEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, 100667315);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000B52AC File Offset: 0x000B34AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129318, RefRangeEnd = 129320, XrefRangeStart = 129196, XrefRangeEnd = 129318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AIValueSummer<double> GraftCardsValue(WormMatch wm, WormPlayer player, WormImperiumPlayable firstCard, WormImperiumPlayable secondCard, WormSpace space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstCard);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondCard);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.NativeMethodInfoPtr_GraftCardsValue_Public_Static_AIValueSummer_1_Double_WormMatch_WormPlayer_WormImperiumPlayable_WormImperiumPlayable_WormSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000B533C File Offset: 0x000B353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129320, XrefRangeEnd = 129373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftCardEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000B5398 File Offset: 0x000B3598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129386, RefRangeEnd = 129389, XrefRangeStart = 129373, XrefRangeEnd = 129386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context ParameterContext(WormPlayer player, WormSpace space, WormImperiumPlayable agentCard, WormImperiumPlayable graftedCard = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftedCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.NativeMethodInfoPtr_ParameterContext_Public_Static_Context_WormPlayer_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000B5414 File Offset: 0x000B3614
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraftCardEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0000A5D7 File Offset: 0x000087D7
		public GraftCardEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000B5450 File Offset: 0x000B3650
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public unsafe EntityID GraftID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.NativeFieldInfoPtr_GraftID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.NativeFieldInfoPtr_GraftID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x000B5480 File Offset: 0x000B3680
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0000A5FF File Offset: 0x000087FF
		public unsafe EntityID SpaceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.NativeFieldInfoPtr_SpaceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.NativeFieldInfoPtr_SpaceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_GraftID;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_SpaceID;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_GraftCardsValue_Public_Static_AIValueSummer_1_Double_WormMatch_WormPlayer_WormImperiumPlayable_WormImperiumPlayable_WormSpace_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_ParameterContext_Public_Static_Context_WormPlayer_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000649 RID: 1609
		[ObfuscatedName("worm.canis.ai.evaluators.GraftCardEvaluator+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060051C2 RID: 20930 RVA: 0x001AE690 File Offset: 0x001AC890
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr);
				GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_wm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr, "wm");
				GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr, "player");
				GraftCardEvaluator.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr, 100667316);
				GraftCardEvaluator.__c__DisplayClass2_0.NativeMethodInfoPtr__GraftCardsValue_b__0_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr, 100667317);
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x001AE70C File Offset: 0x001AC90C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C4 RID: 20932 RVA: 0x001AE748 File Offset: 0x001AC948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129190, XrefRangeEnd = 129192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormSpace> _GraftCardsValue_b__0(WormImperiumPlayable agentCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.__c__DisplayClass2_0.NativeMethodInfoPtr__GraftCardsValue_b__0_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
				}
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x0001C643 File Offset: 0x0001A843
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001431 RID: 5169
			// (get) Token: 0x060051C6 RID: 20934 RVA: 0x001AE798 File Offset: 0x001AC998
			// (set) Token: 0x060051C7 RID: 20935 RVA: 0x0001C64C File Offset: 0x0001A84C
			public unsafe WormMatch wm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_wm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_wm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001432 RID: 5170
			// (get) Token: 0x060051C8 RID: 20936 RVA: 0x001AE7C8 File Offset: 0x001AC9C8
			// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0001C66B File Offset: 0x0001A86B
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003598 RID: 13720
			private static readonly IntPtr NativeFieldInfoPtr_wm;

			// Token: 0x04003599 RID: 13721
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400359A RID: 13722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400359B RID: 13723
			private static readonly IntPtr NativeMethodInfoPtr__GraftCardsValue_b__0_Internal_IEnumerable_1_WormSpace_WormImperiumPlayable_0;
		}

		// Token: 0x0200064A RID: 1610
		[ObfuscatedName("worm.canis.ai.evaluators.GraftCardEvaluator+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x060051CA RID: 20938 RVA: 0x001AE7F8 File Offset: 0x001AC9F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftCardEvaluator>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr);
				GraftCardEvaluator.__c__DisplayClass2_1.NativeFieldInfoPtr_nonGraftIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr, "nonGraftIcons");
				GraftCardEvaluator.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr, 100667318);
				GraftCardEvaluator.__c__DisplayClass2_1.NativeMethodInfoPtr__GraftCardsValue_b__1_Internal_Boolean_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr, 100667319);
			}

			// Token: 0x060051CB RID: 20939 RVA: 0x001AE860 File Offset: 0x001ACA60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftCardEvaluator.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051CC RID: 20940 RVA: 0x001AE89C File Offset: 0x001ACA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129192, XrefRangeEnd = 129196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftCardsValue_b__1(AgentIcons icon)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref icon;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftCardEvaluator.__c__DisplayClass2_1.NativeMethodInfoPtr__GraftCardsValue_b__1_Internal_Boolean_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051CD RID: 20941 RVA: 0x0001C68A File Offset: 0x0001A88A
			public __c__DisplayClass2_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001433 RID: 5171
			// (get) Token: 0x060051CE RID: 20942 RVA: 0x001AE8E8 File Offset: 0x001ACAE8
			// (set) Token: 0x060051CF RID: 20943 RVA: 0x0001C693 File Offset: 0x0001A893
			public unsafe List<AgentIcons> nonGraftIcons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_1.NativeFieldInfoPtr_nonGraftIcons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AgentIcons>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftCardEvaluator.__c__DisplayClass2_1.NativeFieldInfoPtr_nonGraftIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400359C RID: 13724
			private static readonly IntPtr NativeFieldInfoPtr_nonGraftIcons;

			// Token: 0x0400359D RID: 13725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400359E RID: 13726
			private static readonly IntPtr NativeMethodInfoPtr__GraftCardsValue_b__1_Internal_Boolean_AgentIcons_0;
		}
	}
}
