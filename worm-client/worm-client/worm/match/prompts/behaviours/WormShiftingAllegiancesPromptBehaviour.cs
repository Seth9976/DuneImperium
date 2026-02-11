using System;
using boardgames.match.behaviours;
using Canis.utils.ids;
using dwd.core.match.selection;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using worm.canis.data.enums;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E4 RID: 228
	public class WormShiftingAllegiancesPromptBehaviour : PromptBehaviour<WormSelectEntityPrompt>
	{
		// Token: 0x06000A19 RID: 2585 RVA: 0x00036DB0 File Offset: 0x00034FB0
		// Note: this type is marked as 'beforefieldinit'.
		static WormShiftingAllegiancesPromptBehaviour()
		{
			Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormShiftingAllegiancesPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr);
			WormShiftingAllegiancesPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, "pileView");
			WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, 100664680);
			WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr_DisableFactions_Private_IEnumerator_IReadOnlyList_1_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, 100664681);
			WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, 100664682);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00036E30 File Offset: 0x00035030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701120, XrefRangeEnd = 701210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00036E6C File Offset: 0x0003506C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701210, XrefRangeEnd = 701216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisableFactions(IReadOnlyList<Factions> disableFactions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(disableFactions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr_DisableFactions_Private_IEnumerator_IReadOnlyList_1_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00036EBC File Offset: 0x000350BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701216, XrefRangeEnd = 701219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShiftingAllegiancesPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000744F File Offset: 0x0000564F
		public WormShiftingAllegiancesPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00036EF8 File Offset: 0x000350F8
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00007458 File Offset: 0x00005658
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_DisableFactions_Private_IEnumerator_IReadOnlyList_1_Factions_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("worm.match.prompts.behaviours.WormShiftingAllegiancesPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060021EC RID: 8684 RVA: 0x0007F54C File Offset: 0x0007D74C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr);
				WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, "<>9__1_0");
				WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, "<>9__1_1");
				WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, 100664684);
				WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__1_0_Internal_Boolean_KeyValuePair_2_Factions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, 100664685);
				WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__1_1_Internal_Factions_KeyValuePair_2_Factions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr, 100664686);
			}

			// Token: 0x060021ED RID: 8685 RVA: 0x0007F5F0 File Offset: 0x0007D7F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021EE RID: 8686 RVA: 0x0007F62C File Offset: 0x0007D82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701061, XrefRangeEnd = 701062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__1_0(KeyValuePair<Factions, int> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__1_0_Internal_Boolean_KeyValuePair_2_Factions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021EF RID: 8687 RVA: 0x0007F680 File Offset: 0x0007D880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701062, XrefRangeEnd = 701063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Factions _initialize_b__1_1(KeyValuePair<Factions, int> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__1_1_Internal_Factions_KeyValuePair_2_Factions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021F0 RID: 8688 RVA: 0x00013040 File Offset: 0x00011240
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00013049 File Offset: 0x00011249
			public unsafe static WormShiftingAllegiancesPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShiftingAllegiancesPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0007F6FC File Offset: 0x0007D8FC
			// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0001305B File Offset: 0x0001125B
			public unsafe static Func<KeyValuePair<Factions, int>, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Factions, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0007F724 File Offset: 0x0007D924
			// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0001306D File Offset: 0x0001126D
			public unsafe static Func<KeyValuePair<Factions, int>, Factions> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Factions, int>, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShiftingAllegiancesPromptBehaviour.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400138B RID: 5003
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400138C RID: 5004
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400138D RID: 5005
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400138E RID: 5006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400138F RID: 5007
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_0_Internal_Boolean_KeyValuePair_2_Factions_Int32_0;

			// Token: 0x04001390 RID: 5008
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_1_Internal_Factions_KeyValuePair_2_Factions_Int32_0;
		}

		// Token: 0x02000348 RID: 840
		[ObfuscatedName("worm.match.prompts.behaviours.WormShiftingAllegiancesPromptBehaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060021F7 RID: 8695 RVA: 0x0007F74C File Offset: 0x0007D94C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr);
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_listSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, "listSelection");
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, "entitiesProvider");
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100664687);
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100664688);
			}

			// Token: 0x060021F8 RID: 8696 RVA: 0x0007F7C8 File Offset: 0x0007D9C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F9 RID: 8697 RVA: 0x0007F804 File Offset: 0x0007DA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701063, XrefRangeEnd = 701081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__2(Factions f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref f;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021FA RID: 8698 RVA: 0x0001307F File Offset: 0x0001127F
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x060021FB RID: 8699 RVA: 0x0007F850 File Offset: 0x0007DA50
			// (set) Token: 0x060021FC RID: 8700 RVA: 0x00013088 File Offset: 0x00011288
			public unsafe IEntityListSelection listSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_listSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityListSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_listSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x0007F880 File Offset: 0x0007DA80
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x000130A7 File Offset: 0x000112A7
			public unsafe DBGEntitiesProvider entitiesProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_entitiesProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001391 RID: 5009
			private static readonly IntPtr NativeFieldInfoPtr_listSelection;

			// Token: 0x04001392 RID: 5010
			private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

			// Token: 0x04001393 RID: 5011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001394 RID: 5012
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_Factions_0;
		}

		// Token: 0x02000349 RID: 841
		[ObfuscatedName("worm.match.prompts.behaviours.WormShiftingAllegiancesPromptBehaviour+<>c__DisplayClass1_1")]
		public sealed class __c__DisplayClass1_1 : Object
		{
			// Token: 0x060021FF RID: 8703 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_1()
			{
				Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass1_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr);
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr, "f");
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr, "CS$<>8__locals1");
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr, 100664689);
				WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeMethodInfoPtr__initialize_b__3_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr, 100664690);
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x0007F92C File Offset: 0x0007DB2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002201 RID: 8705 RVA: 0x0007F968 File Offset: 0x0007DB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701081, XrefRangeEnd = 701087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__3(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeMethodInfoPtr__initialize_b__3_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002202 RID: 8706 RVA: 0x000130C6 File Offset: 0x000112C6
			public __c__DisplayClass1_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x0007F9B8 File Offset: 0x0007DBB8
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x000130CF File Offset: 0x000112CF
			public unsafe Factions f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_f);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_f)) = value;
				}
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x0007F9E0 File Offset: 0x0007DBE0
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x000130EA File Offset: 0x000112EA
			public unsafe WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0 field_Public___c__DisplayClass1_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001395 RID: 5013
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001396 RID: 5014
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0;

			// Token: 0x04001397 RID: 5015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001398 RID: 5016
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__3_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200034A RID: 842
		[ObfuscatedName("worm.match.prompts.behaviours.WormShiftingAllegiancesPromptBehaviour+<DisableFactions>d__2")]
		public sealed class _DisableFactions_d__2 : Object
		{
			// Token: 0x06002207 RID: 8711 RVA: 0x0007FA10 File Offset: 0x0007DC10
			// Note: this type is marked as 'beforefieldinit'.
			static _DisableFactions_d__2()
			{
				Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour>.NativeClassPtr, "<DisableFactions>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, "<>1__state");
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, "<>2__current");
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, "<>4__this");
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr_disableFactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, "disableFactions");
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664691);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664692);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664693);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664694);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664695);
				WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr, 100664696);
			}

			// Token: 0x06002208 RID: 8712 RVA: 0x0007FB04 File Offset: 0x0007DD04
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisableFactions_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x0007FB4C File Offset: 0x0007DD4C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x0007FB80 File Offset: 0x0007DD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701087, XrefRangeEnd = 701115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x0600220B RID: 8715 RVA: 0x0007FBBC File Offset: 0x0007DDBC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600220C RID: 8716 RVA: 0x0007FBFC File Offset: 0x0007DDFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701115, XrefRangeEnd = 701120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x0600220D RID: 8717 RVA: 0x0007FC30 File Offset: 0x0007DE30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x00013109 File Offset: 0x00011309
			public _DisableFactions_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x0600220F RID: 8719 RVA: 0x0007FC70 File Offset: 0x0007DE70
			// (set) Token: 0x06002210 RID: 8720 RVA: 0x00013112 File Offset: 0x00011312
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x06002211 RID: 8721 RVA: 0x0007FC98 File Offset: 0x0007DE98
			// (set) Token: 0x06002212 RID: 8722 RVA: 0x0001312D File Offset: 0x0001132D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x06002213 RID: 8723 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
			// (set) Token: 0x06002214 RID: 8724 RVA: 0x0001314C File Offset: 0x0001134C
			public unsafe WormShiftingAllegiancesPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShiftingAllegiancesPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x06002215 RID: 8725 RVA: 0x0007FCF8 File Offset: 0x0007DEF8
			// (set) Token: 0x06002216 RID: 8726 RVA: 0x0001316B File Offset: 0x0001136B
			public unsafe IReadOnlyList<Factions> disableFactions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr_disableFactions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Factions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShiftingAllegiancesPromptBehaviour._DisableFactions_d__2.NativeFieldInfoPtr_disableFactions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001399 RID: 5017
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400139A RID: 5018
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400139B RID: 5019
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400139C RID: 5020
			private static readonly IntPtr NativeFieldInfoPtr_disableFactions;

			// Token: 0x0400139D RID: 5021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400139E RID: 5022
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400139F RID: 5023
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013A0 RID: 5024
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013A1 RID: 5025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013A2 RID: 5026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
