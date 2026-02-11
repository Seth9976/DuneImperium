using System;
using boardgames.match.selection;
using boardgames.tutorials;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001EC RID: 492
	public class WormEndRevealTurnButtonHinter : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060015C0 RID: 5568 RVA: 0x0005A388 File Offset: 0x00058588
		// Note: this type is marked as 'beforefieldinit'.
		static WormEndRevealTurnButtonHinter()
		{
			Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEndRevealTurnButtonHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr);
			WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, "animator");
			WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, "entities");
			WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_tutorialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, "tutorialEffects");
			WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_HintParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, "HintParam");
			WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, 100666305);
			WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, 100666306);
			WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, 100666307);
			WormEndRevealTurnButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, 100666308);
			WormEndRevealTurnButtonHinter.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, 100666310);
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0005A46C File Offset: 0x0005866C
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715785, XrefRangeEnd = 715791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0005A4B4 File Offset: 0x000586B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715791, XrefRangeEnd = 715810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0005A4F0 File Offset: 0x000586F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715810, XrefRangeEnd = 715854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEndRevealTurnButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0005A52C File Offset: 0x0005872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715854, XrefRangeEnd = 715857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEndRevealTurnButtonHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndRevealTurnButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0005A568 File Offset: 0x00058768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715857, XrefRangeEnd = 715882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__7_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndRevealTurnButtonHinter.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0000D26E File Offset: 0x0000B46E
		public WormEndRevealTurnButtonHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0005A5B8 File Offset: 0x000587B8
		// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000D277 File Offset: 0x0000B477
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x0005A5E8 File Offset: 0x000587E8
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000D296 File Offset: 0x0000B496
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0005A618 File Offset: 0x00058818
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000D2B5 File Offset: 0x0000B4B5
		public unsafe ITutorialPrompter tutorialEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_tutorialEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITutorialPrompter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_tutorialEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x0005A648 File Offset: 0x00058848
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		public unsafe static int HintParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEndRevealTurnButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&value));
			}
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_tutorialEffects;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_HintParam;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__7_0_Private_Boolean_EntityID_0;

		// Token: 0x020003EA RID: 1002
		[ObfuscatedName("worm.match.components.WormEndRevealTurnButtonHinter+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060028B2 RID: 10418 RVA: 0x00093590 File Offset: 0x00091790
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr);
				WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr, "<>9");
				WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr, "<>9__7_1");
				WormEndRevealTurnButtonHinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr, 100666312);
				WormEndRevealTurnButtonHinter.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr, 100666313);
			}

			// Token: 0x060028B3 RID: 10419 RVA: 0x0009360C File Offset: 0x0009180C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEndRevealTurnButtonHinter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndRevealTurnButtonHinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028B4 RID: 10420 RVA: 0x00093648 File Offset: 0x00091848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715779, XrefRangeEnd = 715785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__7_1(IPrompt p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndRevealTurnButtonHinter.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060028B5 RID: 10421 RVA: 0x0001653F File Offset: 0x0001473F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x060028B6 RID: 10422 RVA: 0x00093698 File Offset: 0x00091898
			// (set) Token: 0x060028B7 RID: 10423 RVA: 0x00016548 File Offset: 0x00014748
			public unsafe static WormEndRevealTurnButtonHinter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEndRevealTurnButtonHinter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000936C0 File Offset: 0x000918C0
			// (set) Token: 0x060028B9 RID: 10425 RVA: 0x0001655A File Offset: 0x0001475A
			public unsafe static Func<IPrompt, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPrompt, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEndRevealTurnButtonHinter.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001771 RID: 6001
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001772 RID: 6002
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04001773 RID: 6003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001774 RID: 6004
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_IPrompt_0;
		}
	}
}
