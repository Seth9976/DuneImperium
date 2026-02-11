using System;
using Canis.entities.ai;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.entities;

namespace worm.canis.ai.evaluators
{
	// Token: 0x0200021B RID: 539
	public class ConvertSpecimenEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017C2 RID: 6082 RVA: 0x000B5114 File Offset: 0x000B3314
		// Note: this type is marked as 'beforefieldinit'.
		static ConvertSpecimenEvaluator()
		{
			Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "ConvertSpecimenEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr);
			ConvertSpecimenEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr, 100667307);
			ConvertSpecimenEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr, 100667308);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000B516C File Offset: 0x000B336C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129155, XrefRangeEnd = 129190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConvertSpecimenEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000B51C8 File Offset: 0x000B33C8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConvertSpecimenEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertSpecimenEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0000A5CE File Offset: 0x000087CE
		public ConvertSpecimenEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000648 RID: 1608
		[ObfuscatedName("worm.canis.ai.evaluators.ConvertSpecimenEvaluator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051BA RID: 20922 RVA: 0x001AE538 File Offset: 0x001AC738
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConvertSpecimenEvaluator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr);
				ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr, "<>9");
				ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr, "<>9__0_0");
				ConvertSpecimenEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr, 100667310);
				ConvertSpecimenEvaluator.__c.NativeMethodInfoPtr__Evaluate_b__0_0_Internal_EntityID_WormTroop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr, 100667311);
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x001AE5B4 File Offset: 0x001AC7B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvertSpecimenEvaluator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertSpecimenEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x001AE5F0 File Offset: 0x001AC7F0
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__0_0(WormTroop e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertSpecimenEvaluator.__c.NativeMethodInfoPtr__Evaluate_b__0_0_Internal_EntityID_WormTroop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0001C616 File Offset: 0x0001A816
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700142F RID: 5167
			// (get) Token: 0x060051BE RID: 20926 RVA: 0x001AE640 File Offset: 0x001AC840
			// (set) Token: 0x060051BF RID: 20927 RVA: 0x0001C61F File Offset: 0x0001A81F
			public unsafe static ConvertSpecimenEvaluator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConvertSpecimenEvaluator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001430 RID: 5168
			// (get) Token: 0x060051C0 RID: 20928 RVA: 0x001AE668 File Offset: 0x001AC868
			// (set) Token: 0x060051C1 RID: 20929 RVA: 0x0001C631 File Offset: 0x0001A831
			public unsafe static Func<WormTroop, EntityID> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTroop, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConvertSpecimenEvaluator.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003594 RID: 13716
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003595 RID: 13717
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04003596 RID: 13718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003597 RID: 13719
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_0_Internal_EntityID_WormTroop_0;
		}
	}
}
