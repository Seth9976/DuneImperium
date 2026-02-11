using System;
using boardgames.match;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.UI;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000DF RID: 223
	public class WormOtherMemoryPromptBehaviour : PromptBehaviour<WormSelectEntityPrompt>
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x0003549C File Offset: 0x0003369C
		// Note: this type is marked as 'beforefieldinit'.
		static WormOtherMemoryPromptBehaviour()
		{
			Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormOtherMemoryPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr);
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "confirmButton");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "cancelButton");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "pileView");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_toggleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "toggleGroup");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_deckView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "deckView");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_emptyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "emptyText");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "entities");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "tempPile");
			WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "selectedEntities");
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664617);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664618);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664619);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664620);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664621);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664622);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664623);
			WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, 100664624);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00035620 File Offset: 0x00033820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700247, XrefRangeEnd = 700326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0003565C File Offset: 0x0003385C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 700335, RefRangeEnd = 700339, XrefRangeStart = 700326, XrefRangeEnd = 700335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00035690 File Offset: 0x00033890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 700363, RefRangeEnd = 700364, XrefRangeStart = 700339, XrefRangeEnd = 700363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOn(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000356D0 File Offset: 0x000338D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700364, XrefRangeEnd = 700377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOff(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00035710 File Offset: 0x00033910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700377, XrefRangeEnd = 700384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00035744 File Offset: 0x00033944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700384, XrefRangeEnd = 700391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00035778 File Offset: 0x00033978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700391, XrefRangeEnd = 700394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000357B4 File Offset: 0x000339B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700394, XrefRangeEnd = 700404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOtherMemoryPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00006E4A File Offset: 0x0000504A
		public WormOtherMemoryPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x000357F0 File Offset: 0x000339F0
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00006E53 File Offset: 0x00005053
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00035820 File Offset: 0x00033A20
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006E72 File Offset: 0x00005072
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00035850 File Offset: 0x00033A50
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006E91 File Offset: 0x00005091
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00035880 File Offset: 0x00033A80
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00006EB0 File Offset: 0x000050B0
		public unsafe ToggleGroup toggleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_toggleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_toggleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000358B0 File Offset: 0x00033AB0
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00006ECF File Offset: 0x000050CF
		public unsafe EntityView deckView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_deckView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_deckView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000358E0 File Offset: 0x00033AE0
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00006EEE File Offset: 0x000050EE
		public unsafe GameObject emptyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_emptyText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_emptyText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00035910 File Offset: 0x00033B10
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00006F0D File Offset: 0x0000510D
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00035940 File Offset: 0x00033B40
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00006F2C File Offset: 0x0000512C
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00035970 File Offset: 0x00033B70
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00006F4B File Offset: 0x0000514B
		public unsafe List<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_toggleGroup;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_deckView;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_emptyText;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOn_Public_Void_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOff_Public_Void_Int32_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000340 RID: 832
		[ObfuscatedName("worm.match.prompts.behaviours.WormOtherMemoryPromptBehaviour+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060021A6 RID: 8614 RVA: 0x0007E888 File Offset: 0x0007CA88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
				WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "buttonIndex");
				WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664625);
				WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664626);
				WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664627);
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x0007E918 File Offset: 0x0007CB18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x0007E954 File Offset: 0x0007CB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700162, XrefRangeEnd = 700164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A9 RID: 8617 RVA: 0x0007E988 File Offset: 0x0007CB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700164, XrefRangeEnd = 700247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__initialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021AA RID: 8618 RVA: 0x00012E3F File Offset: 0x0001103F
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x060021AB RID: 8619 RVA: 0x0007E9BC File Offset: 0x0007CBBC
			// (set) Token: 0x060021AC RID: 8620 RVA: 0x00012E48 File Offset: 0x00011048
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
			// (set) Token: 0x060021AE RID: 8622 RVA: 0x00012E63 File Offset: 0x00011063
			public unsafe WormOtherMemoryPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormOtherMemoryPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormOtherMemoryPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001365 RID: 4965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001366 RID: 4966
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Void_0;

			// Token: 0x04001367 RID: 4967
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_Internal_Void_0;
		}
	}
}
