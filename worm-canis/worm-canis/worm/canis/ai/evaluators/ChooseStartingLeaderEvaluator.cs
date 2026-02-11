using System;
using Canis.attributes;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.ai.evaluators
{
	// Token: 0x02000219 RID: 537
	public class ChooseStartingLeaderEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017BA RID: 6074 RVA: 0x000B4F34 File Offset: 0x000B3134
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseStartingLeaderEvaluator()
		{
			Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "ChooseStartingLeaderEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr);
			ChooseStartingLeaderEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr, 100667301);
			ChooseStartingLeaderEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr, 100667302);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000B4F8C File Offset: 0x000B318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129092, XrefRangeEnd = 129130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseStartingLeaderEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseStartingLeaderEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseStartingLeaderEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0000A5BC File Offset: 0x000087BC
		public ChooseStartingLeaderEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000647 RID: 1607
		[ObfuscatedName("worm.canis.ai.evaluators.ChooseStartingLeaderEvaluator+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060051B4 RID: 20916 RVA: 0x001AE410 File Offset: 0x001AC610
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr);
				ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_wormContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr, "wormContext");
				ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667303);
				ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_ValueTuple_2_SerializableAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667304);
			}

			// Token: 0x060051B5 RID: 20917 RVA: 0x001AE478 File Offset: 0x001AC678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseStartingLeaderEvaluator.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051B6 RID: 20918 RVA: 0x001AE4B4 File Offset: 0x001AC6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129078, XrefRangeEnd = 129092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(ValueTuple<SerializableAttributes, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_ValueTuple_2_SerializableAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051B7 RID: 20919 RVA: 0x0001C5EE File Offset: 0x0001A7EE
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700142E RID: 5166
			// (get) Token: 0x060051B8 RID: 20920 RVA: 0x001AE508 File Offset: 0x001AC708
			// (set) Token: 0x060051B9 RID: 20921 RVA: 0x0001C5F7 File Offset: 0x0001A7F7
			public unsafe WormAIChoiceContext wormContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_wormContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseStartingLeaderEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_wormContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003591 RID: 13713
			private static readonly IntPtr NativeFieldInfoPtr_wormContext;

			// Token: 0x04003592 RID: 13714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003593 RID: 13715
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_ValueTuple_2_SerializableAttributes_Int32_0;
		}
	}
}
