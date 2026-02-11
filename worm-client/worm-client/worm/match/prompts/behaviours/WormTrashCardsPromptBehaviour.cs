using System;
using boardgames.match;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E9 RID: 233
	public class WormTrashCardsPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x00037B18 File Offset: 0x00035D18
		// Note: this type is marked as 'beforefieldinit'.
		static WormTrashCardsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormTrashCardsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr);
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_piles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "piles");
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_emptyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "emptyLabel");
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "dragTargetSelectionPromptBehaviour");
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "selectionResponder");
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "entities");
			WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "tempEntities");
			WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, 100664722);
			WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_MakeToggleHandler_Private_UnityAction_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, 100664723);
			WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, 100664724);
			WormTrashCardsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, 100664725);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00037C10 File Offset: 0x00035E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701480, XrefRangeEnd = 701554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00037C4C File Offset: 0x00035E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 701566, RefRangeEnd = 701567, XrefRangeStart = 701554, XrefRangeEnd = 701566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction<bool> MakeToggleHandler(string pileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_MakeToggleHandler_Private_UnityAction_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00037C9C File Offset: 0x00035E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701567, XrefRangeEnd = 701586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrashCardsPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00037CD8 File Offset: 0x00035ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701586, XrefRangeEnd = 701603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTrashCardsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000076D7 File Offset: 0x000058D7
		public WormTrashCardsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00037D14 File Offset: 0x00035F14
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000076E0 File Offset: 0x000058E0
		public unsafe Il2CppReferenceArray<WormTrashCardsPromptBehaviour.PileData> piles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_piles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormTrashCardsPromptBehaviour.PileData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_piles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00037D44 File Offset: 0x00035F44
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000076FF File Offset: 0x000058FF
		public unsafe GameObject emptyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_emptyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_emptyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00037D74 File Offset: 0x00035F74
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0000771E File Offset: 0x0000591E
		public unsafe WormDragTargetSelectionPromptBehaviour dragTargetSelectionPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDragTargetSelectionPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00037DA4 File Offset: 0x00035FA4
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0000773D File Offset: 0x0000593D
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00037DD4 File Offset: 0x00035FD4
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0000775C File Offset: 0x0000595C
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00037E04 File Offset: 0x00036004
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0000777B File Offset: 0x0000597B
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_piles;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_emptyLabel;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_MakeToggleHandler_Private_UnityAction_1_Boolean_String_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200034D RID: 845
		[Serializable]
		public sealed class PileData : ValueType
		{
			// Token: 0x06002225 RID: 8741 RVA: 0x0007FF7C File Offset: 0x0007E17C
			// Note: this type is marked as 'beforefieldinit'.
			static PileData()
			{
				Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "PileData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr);
				WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr, "name");
				WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr, "view");
				WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr, "toggle");
				WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr, "displays");
				WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_combineWithPiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr, "combineWithPiles");
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x000131F5 File Offset: 0x000113F5
			public PileData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002227 RID: 8743 RVA: 0x000131FE File Offset: 0x000113FE
			public PileData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.PileData>.NativeClassPtr))
			{
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06002228 RID: 8744 RVA: 0x0008000C File Offset: 0x0007E20C
			// (set) Token: 0x06002229 RID: 8745 RVA: 0x00013210 File Offset: 0x00011410
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x0600222A RID: 8746 RVA: 0x00080034 File Offset: 0x0007E234
			// (set) Token: 0x0600222B RID: 8747 RVA: 0x0001322F File Offset: 0x0001142F
			public unsafe ContainerView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x0600222C RID: 8748 RVA: 0x00080064 File Offset: 0x0007E264
			// (set) Token: 0x0600222D RID: 8749 RVA: 0x0001324E File Offset: 0x0001144E
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x0600222E RID: 8750 RVA: 0x00080094 File Offset: 0x0007E294
			// (set) Token: 0x0600222F RID: 8751 RVA: 0x0001326D File Offset: 0x0001146D
			public unsafe Il2CppReferenceArray<GameObject> displays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_displays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_displays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06002230 RID: 8752 RVA: 0x000800C4 File Offset: 0x0007E2C4
			// (set) Token: 0x06002231 RID: 8753 RVA: 0x0001328C File Offset: 0x0001148C
			public unsafe Il2CppStringArray combineWithPiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_combineWithPiles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.PileData.NativeFieldInfoPtr_combineWithPiles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013AA RID: 5034
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040013AB RID: 5035
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x040013AC RID: 5036
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x040013AD RID: 5037
			private static readonly IntPtr NativeFieldInfoPtr_displays;

			// Token: 0x040013AE RID: 5038
			private static readonly IntPtr NativeFieldInfoPtr_combineWithPiles;
		}

		// Token: 0x0200034E RID: 846
		[ObfuscatedName("worm.match.prompts.behaviours.WormTrashCardsPromptBehaviour+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002232 RID: 8754 RVA: 0x000800F4 File Offset: 0x0007E2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr);
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "activePlayerID");
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>9__0");
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>9__2");
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664726);
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__0_Internal_IEnumerable_1_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664727);
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664728);
				WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664729);
			}

			// Token: 0x06002233 RID: 8755 RVA: 0x000801D4 File Offset: 0x0007E3D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x00080210 File Offset: 0x0007E410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701471, XrefRangeEnd = 701472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityComponent> _initialize_b__0(string p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__0_Internal_IEnumerable_1_EntityComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityComponent>>(intPtr3) : null;
				}
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x00080260 File Offset: 0x0007E460
			[CallerCount(0)]
			public unsafe bool _initialize_b__1(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x000802B0 File Offset: 0x0007E4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701472, XrefRangeEnd = 701473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__2(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002237 RID: 8759 RVA: 0x000132AB File Offset: 0x000114AB
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06002238 RID: 8760 RVA: 0x00080300 File Offset: 0x0007E500
			// (set) Token: 0x06002239 RID: 8761 RVA: 0x000132B4 File Offset: 0x000114B4
			public unsafe WormTrashCardsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTrashCardsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x0600223A RID: 8762 RVA: 0x00080330 File Offset: 0x0007E530
			// (set) Token: 0x0600223B RID: 8763 RVA: 0x000132D3 File Offset: 0x000114D3
			public unsafe AccountID activePlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_activePlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x0600223C RID: 8764 RVA: 0x00080360 File Offset: 0x0007E560
			// (set) Token: 0x0600223D RID: 8765 RVA: 0x000132F2 File Offset: 0x000114F2
			public unsafe Func<string, IEnumerable<EntityComponent>> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, IEnumerable<EntityComponent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x0600223E RID: 8766 RVA: 0x00080390 File Offset: 0x0007E590
			// (set) Token: 0x0600223F RID: 8767 RVA: 0x00013311 File Offset: 0x00011511
			public unsafe Predicate<EntityComponent> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06002240 RID: 8768 RVA: 0x000803C0 File Offset: 0x0007E5C0
			// (set) Token: 0x06002241 RID: 8769 RVA: 0x00013330 File Offset: 0x00011530
			public unsafe Func<EntityComponent, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013AF RID: 5039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013B0 RID: 5040
			private static readonly IntPtr NativeFieldInfoPtr_activePlayerID;

			// Token: 0x040013B1 RID: 5041
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040013B2 RID: 5042
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040013B3 RID: 5043
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040013B4 RID: 5044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013B5 RID: 5045
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_IEnumerable_1_EntityComponent_String_0;

			// Token: 0x040013B6 RID: 5046
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_EntityComponent_0;

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x0200034F RID: 847
		[ObfuscatedName("worm.match.prompts.behaviours.WormTrashCardsPromptBehaviour+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002242 RID: 8770 RVA: 0x000803F0 File Offset: 0x0007E5F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr);
				WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_pileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, "pileName");
				WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100664730);
				WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__MakeToggleHandler_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100664731);
			}

			// Token: 0x06002243 RID: 8771 RVA: 0x0008046C File Offset: 0x0007E66C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrashCardsPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002244 RID: 8772 RVA: 0x000804A8 File Offset: 0x0007E6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701473, XrefRangeEnd = 701480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MakeToggleHandler_b__0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__MakeToggleHandler_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002245 RID: 8773 RVA: 0x0001334F File Offset: 0x0001154F
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06002246 RID: 8774 RVA: 0x000804E8 File Offset: 0x0007E6E8
			// (set) Token: 0x06002247 RID: 8775 RVA: 0x00013358 File Offset: 0x00011558
			public unsafe WormTrashCardsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTrashCardsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06002248 RID: 8776 RVA: 0x00080518 File Offset: 0x0007E718
			// (set) Token: 0x06002249 RID: 8777 RVA: 0x00013377 File Offset: 0x00011577
			public unsafe string pileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_pileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrashCardsPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_pileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeFieldInfoPtr_pileName;

			// Token: 0x040013BA RID: 5050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013BB RID: 5051
			private static readonly IntPtr NativeMethodInfoPtr__MakeToggleHandler_b__0_Internal_Void_Boolean_0;
		}
	}
}
