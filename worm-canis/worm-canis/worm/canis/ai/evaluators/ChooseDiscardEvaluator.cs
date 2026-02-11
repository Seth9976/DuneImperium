using System;
using Canis.entities.ai;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.ai.evaluators
{
	// Token: 0x02000218 RID: 536
	public class ChooseDiscardEvaluator : WormAISelectionEvaluator
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x000B4DD8 File Offset: 0x000B2FD8
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseDiscardEvaluator()
		{
			Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.evaluators", "ChooseDiscardEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr);
			ChooseDiscardEvaluator.NativeMethodInfoPtr_GetDiscardOrder_Public_Static_List_1_WormImperiumPlayable_WormPlayer_IEnumerable_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr, 100667290);
			ChooseDiscardEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr, 100667291);
			ChooseDiscardEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr, 100667292);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000B4E44 File Offset: 0x000B3044
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 128984, RefRangeEnd = 128995, XrefRangeStart = 128953, XrefRangeEnd = 128984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<WormImperiumPlayable> GetDiscardOrder(WormPlayer player, IEnumerable<WormImperiumPlayable> targets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.NativeMethodInfoPtr_GetDiscardOrder_Public_Static_List_1_WormImperiumPlayable_WormPlayer_IEnumerable_1_WormImperiumPlayable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormImperiumPlayable>>(intPtr3) : null;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000B4E9C File Offset: 0x000B309C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128995, XrefRangeEnd = 129078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseDiscardEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000B4EF8 File Offset: 0x000B30F8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseDiscardEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0000A5B3 File Offset: 0x000087B3
		public ChooseDiscardEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_GetDiscardOrder_Public_Static_List_1_WormImperiumPlayable_WormPlayer_IEnumerable_1_WormImperiumPlayable_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000645 RID: 1605
		[ObfuscatedName("worm.canis.ai.evaluators.ChooseDiscardEvaluator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051A3 RID: 20899 RVA: 0x001AE068 File Offset: 0x001AC268
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr);
				ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr, "<>9");
				ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr, "<>9__1_0");
				ChooseDiscardEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr, 100667294);
				ChooseDiscardEvaluator.__c.NativeMethodInfoPtr__Evaluate_b__1_0_Internal_EntityID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr, 100667295);
			}

			// Token: 0x060051A4 RID: 20900 RVA: 0x001AE0E4 File Offset: 0x001AC2E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051A5 RID: 20901 RVA: 0x001AE120 File Offset: 0x001AC320
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__1_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c.NativeMethodInfoPtr__Evaluate_b__1_0_Internal_EntityID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060051A6 RID: 20902 RVA: 0x0001C599 File Offset: 0x0001A799
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700142B RID: 5163
			// (get) Token: 0x060051A7 RID: 20903 RVA: 0x001AE170 File Offset: 0x001AC370
			// (set) Token: 0x060051A8 RID: 20904 RVA: 0x0001C5A2 File Offset: 0x0001A7A2
			public unsafe static ChooseDiscardEvaluator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChooseDiscardEvaluator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700142C RID: 5164
			// (get) Token: 0x060051A9 RID: 20905 RVA: 0x001AE198 File Offset: 0x001AC398
			// (set) Token: 0x060051AA RID: 20906 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
			public unsafe static Func<WormImperiumPlayable, EntityID> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChooseDiscardEvaluator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003587 RID: 13703
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003588 RID: 13704
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003589 RID: 13705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400358A RID: 13706
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_0_Internal_EntityID_WormImperiumPlayable_0;
		}

		// Token: 0x02000646 RID: 1606
		[ObfuscatedName("worm.canis.ai.evaluators.ChooseDiscardEvaluator+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060051AB RID: 20907 RVA: 0x001AE1C0 File Offset: 0x001AC3C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseDiscardEvaluator>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr);
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, "player");
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667296);
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667297);
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667298);
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667299);
				ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr, 100667300);
			}

			// Token: 0x060051AC RID: 20908 RVA: 0x001AE264 File Offset: 0x001AC464
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseDiscardEvaluator.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051AD RID: 20909 RVA: 0x001AE2A0 File Offset: 0x001AC4A0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 128884, RefRangeEnd = 128886, XrefRangeStart = 128871, XrefRangeEnd = 128884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double Method_Internal_Double_WormImperiumPlayable_PDM_0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051AE RID: 20910 RVA: 0x001AE2F0 File Offset: 0x001AC4F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 128899, RefRangeEnd = 128901, XrefRangeStart = 128886, XrefRangeEnd = 128899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double Method_Internal_Double_WormImperiumPlayable_PDM_1(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051AF RID: 20911 RVA: 0x001AE340 File Offset: 0x001AC540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128901, XrefRangeEnd = 128925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double Method_Internal_Double_WormImperiumPlayable_PDM_2(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051B0 RID: 20912 RVA: 0x001AE390 File Offset: 0x001AC590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128925, XrefRangeEnd = 128953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double Method_Internal_Double_WormImperiumPlayable_PDM_3(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051B1 RID: 20913 RVA: 0x0001C5C6 File Offset: 0x0001A7C6
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700142D RID: 5165
			// (get) Token: 0x060051B2 RID: 20914 RVA: 0x001AE3E0 File Offset: 0x001AC5E0
			// (set) Token: 0x060051B3 RID: 20915 RVA: 0x0001C5CF File Offset: 0x0001A7CF
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChooseDiscardEvaluator.__c__DisplayClass0_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400358B RID: 13707
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400358C RID: 13708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400358D RID: 13709
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_0;

			// Token: 0x0400358E RID: 13710
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_1;

			// Token: 0x0400358F RID: 13711
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_2;

			// Token: 0x04003590 RID: 13712
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Double_WormImperiumPlayable_PDM_3;
		}
	}
}
