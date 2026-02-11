using System;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.abilities;
using worm.canis.entities;

namespace worm.canis.ai.evaluators
{
	// Token: 0x0200021D RID: 541
	public class KwisatzHaderachAgentRecallEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x000B54B0 File Offset: 0x000B36B0
		// Note: this type is marked as 'beforefieldinit'.
		static KwisatzHaderachAgentRecallEvaluator()
		{
			Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "KwisatzHaderachAgentRecallEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr);
			KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr_AgentRetrievalValue_Public_Static_Double_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr, 100667320);
			KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr, 100667321);
			KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr, 100667322);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000B551C File Offset: 0x000B371C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129429, RefRangeEnd = 129431, XrefRangeStart = 129396, XrefRangeEnd = 129429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double AgentRetrievalValue(WormAgent agent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr_AgentRetrievalValue_Public_Static_Double_WormAgent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000B5560 File Offset: 0x000B3760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129431, XrefRangeEnd = 129466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000B55BC File Offset: 0x000B37BC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KwisatzHaderachAgentRecallEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAgentRecallEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0000A61E File Offset: 0x0000881E
		public KwisatzHaderachAgentRecallEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_AgentRetrievalValue_Public_Static_Double_WormAgent_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200064B RID: 1611
		[ObfuscatedName("worm.canis.ai.evaluators.KwisatzHaderachAgentRecallEvaluator+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060051D0 RID: 20944 RVA: 0x001AE918 File Offset: 0x001ACB18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr);
				KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr, "owner");
				KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667323);
				KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__AgentRetrievalValue_b__0_Internal_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667324);
			}

			// Token: 0x060051D1 RID: 20945 RVA: 0x001AE980 File Offset: 0x001ACB80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x001AE9BC File Offset: 0x001ACBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129389, XrefRangeEnd = 129396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _AgentRetrievalValue_b__0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__AgentRetrievalValue_b__0_Internal_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D3 RID: 20947 RVA: 0x0001C6B2 File Offset: 0x0001A8B2
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001434 RID: 5172
			// (get) Token: 0x060051D4 RID: 20948 RVA: 0x001AEA0C File Offset: 0x001ACC0C
			// (set) Token: 0x060051D5 RID: 20949 RVA: 0x0001C6BB File Offset: 0x0001A8BB
			public unsafe WormPlayer owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KwisatzHaderachAgentRecallEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400359F RID: 13727
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040035A0 RID: 13728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040035A1 RID: 13729
			private static readonly IntPtr NativeMethodInfoPtr__AgentRetrievalValue_b__0_Internal_Double_WormAbilityDefinition_0;
		}
	}
}
