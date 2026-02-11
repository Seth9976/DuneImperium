using System;
using boardgames.match;
using boardgames.match.behaviours;
using boardgames.match.selection;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using worm.client.match.render;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C3 RID: 195
	public class WormAcquireTechPromptBehaviour : PromptBehaviour
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x000306DC File Offset: 0x0002E8DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormAcquireTechPromptBehaviour()
		{
			Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormAcquireTechPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr);
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "pileView");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_onTilesAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "onTilesAdded");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_negotiatorHintAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "negotiatorHintAnimator");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_minimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "minimize");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "shouldHighlightUnminimize");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "entities");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_responder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "responder");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "tempPile");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_refresher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "refresher");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_stackLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "stackLists");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_Hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "Hint");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "tempEntities");
			WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "cachedVersion");
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664336);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664337);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_DirtyUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664338);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664339);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664340);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_Event_SelectNegotiator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664341);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_SelectNegotiator_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664342);
			WormAcquireTechPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, 100664343);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000308B0 File Offset: 0x0002EAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697288, XrefRangeEnd = 697340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000308EC File Offset: 0x0002EAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697340, XrefRangeEnd = 697345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00030920 File Offset: 0x0002EB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 697398, RefRangeEnd = 697399, XrefRangeStart = 697345, XrefRangeEnd = 697398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_DirtyUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00030954 File Offset: 0x0002EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697399, XrefRangeEnd = 697416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00030990 File Offset: 0x0002EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697416, XrefRangeEnd = 697420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000309C4 File Offset: 0x0002EBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697420, XrefRangeEnd = 697426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectNegotiator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_Event_SelectNegotiator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000309F8 File Offset: 0x0002EBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697426, XrefRangeEnd = 697431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectNegotiator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr_SelectNegotiator_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00030A38 File Offset: 0x0002EC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697431, XrefRangeEnd = 697444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAcquireTechPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00005FF3 File Offset: 0x000041F3
		public WormAcquireTechPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00030A74 File Offset: 0x0002EC74
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00005FFC File Offset: 0x000041FC
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0000601B File Offset: 0x0000421B
		public unsafe UnityEvent onTilesAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_onTilesAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_onTilesAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0000603A File Offset: 0x0000423A
		public unsafe Animator negotiatorHintAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_negotiatorHintAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_negotiatorHintAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00030B04 File Offset: 0x0002ED04
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00006059 File Offset: 0x00004259
		public unsafe MinimizablePrompt minimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_minimize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_minimize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00030B34 File Offset: 0x0002ED34
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00006078 File Offset: 0x00004278
		public unsafe bool shouldHighlightUnminimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_shouldHighlightUnminimize)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00030B5C File Offset: 0x0002ED5C
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00006093 File Offset: 0x00004293
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00030B8C File Offset: 0x0002ED8C
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000060B2 File Offset: 0x000042B2
		public unsafe DBGSelectionResponder responder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_responder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_responder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00030BBC File Offset: 0x0002EDBC
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x000060D1 File Offset: 0x000042D1
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00030BEC File Offset: 0x0002EDEC
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000060F0 File Offset: 0x000042F0
		public unsafe AnimatedPileRefresher refresher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_refresher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedPileRefresher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_refresher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00030C1C File Offset: 0x0002EE1C
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0000610F File Offset: 0x0000430F
		public unsafe List<ReadOnlyVersionedList<EntityComponent>> stackLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_stackLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReadOnlyVersionedList<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_stackLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00030C4C File Offset: 0x0002EE4C
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0000612E File Offset: 0x0000432E
		public unsafe static int Hint
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_Hint, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_Hint, (void*)(&value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00030C68 File Offset: 0x0002EE68
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0000613C File Offset: 0x0000433C
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00030C98 File Offset: 0x0002EE98
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0000615B File Offset: 0x0000435B
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_onTilesAdded;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_negotiatorHintAnimator;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_minimize;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_shouldHighlightUnminimize;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_responder;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_refresher;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_stackLists;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_Hint;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Private_Void_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectNegotiator_Public_Void_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_SelectNegotiator_Private_IEnumerator_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000319 RID: 793
		[ObfuscatedName("worm.match.prompts.behaviours.WormAcquireTechPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001FEA RID: 8170 RVA: 0x00079868 File Offset: 0x00077A68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr);
				WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, "<>9__13_1");
				WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, "<>9__13_0");
				WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, 100664346);
				WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__13_0_Internal_IEnumerable_1_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, 100664347);
				WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__13_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr, 100664348);
			}

			// Token: 0x06001FEB RID: 8171 RVA: 0x0007990C File Offset: 0x00077B0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FEC RID: 8172 RVA: 0x00079948 File Offset: 0x00077B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697193, XrefRangeEnd = 697229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ReadOnlyVersionedList<EntityComponent>> _initialize_b__13_0(EntityComponent s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__13_0_Internal_IEnumerable_1_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ReadOnlyVersionedList<EntityComponent>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001FED RID: 8173 RVA: 0x00079998 File Offset: 0x00077B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697229, XrefRangeEnd = 697236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__13_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__13_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FEE RID: 8174 RVA: 0x00011FC7 File Offset: 0x000101C7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06001FEF RID: 8175 RVA: 0x000799E8 File Offset: 0x00077BE8
			// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00011FD0 File Offset: 0x000101D0
			public unsafe static WormAcquireTechPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00079A10 File Offset: 0x00077C10
			// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00011FE2 File Offset: 0x000101E2
			public unsafe static Func<EntityComponent, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00079A38 File Offset: 0x00077C38
			// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00011FF4 File Offset: 0x000101F4
			public unsafe static Func<EntityComponent, IEnumerable<ReadOnlyVersionedList<EntityComponent>>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, IEnumerable<ReadOnlyVersionedList<EntityComponent>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechPromptBehaviour.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__13_0_Internal_IEnumerable_1_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0;

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__13_1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x0200031A RID: 794
		[ObfuscatedName("worm.match.prompts.behaviours.WormAcquireTechPromptBehaviour+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001FF5 RID: 8181 RVA: 0x00079A60 File Offset: 0x00077C60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr);
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_usedTempEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "usedTempEntity");
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664349);
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664350);
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664351);
				WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664352);
			}

			// Token: 0x06001FF6 RID: 8182 RVA: 0x00079B04 File Offset: 0x00077D04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x00079B40 File Offset: 0x00077D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697236, XrefRangeEnd = 697251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityComponent _DirtyUpdate_b__0(ReadOnlyVersionedList<EntityComponent> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x00079B90 File Offset: 0x00077D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697251, XrefRangeEnd = 697253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FF9 RID: 8185 RVA: 0x00079BCC File Offset: 0x00077DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697253, XrefRangeEnd = 697257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__DirtyUpdate_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x00012006 File Offset: 0x00010206
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00079C08 File Offset: 0x00077E08
			// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0001200F File Offset: 0x0001020F
			public unsafe int usedTempEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_usedTempEntity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_usedTempEntity)) = value;
				}
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00079C30 File Offset: 0x00077E30
			// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0001202A File Offset: 0x0001022A
			public unsafe WormAcquireTechPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeFieldInfoPtr_usedTempEntity;

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_0;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__2_Internal_Boolean_0;
		}

		// Token: 0x0200031B RID: 795
		[ObfuscatedName("worm.match.prompts.behaviours.WormAcquireTechPromptBehaviour+<SelectNegotiator>d__19")]
		public sealed class _SelectNegotiator_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06001FFF RID: 8191 RVA: 0x00079C60 File Offset: 0x00077E60
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectNegotiator_d__19()
			{
				Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour>.NativeClassPtr, "<SelectNegotiator>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, "<>1__state");
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, "<>2__current");
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, "<>4__this");
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__negotiation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, "<negotiation>5__2");
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__confirm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, "<confirm>5__3");
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664353);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664354);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664355);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664356);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664357);
				WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr, 100664358);
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x00079D68 File Offset: 0x00077F68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectNegotiator_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechPromptBehaviour._SelectNegotiator_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002001 RID: 8193 RVA: 0x00079DB0 File Offset: 0x00077FB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002002 RID: 8194 RVA: 0x00079DE4 File Offset: 0x00077FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697257, XrefRangeEnd = 697283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06002003 RID: 8195 RVA: 0x00079E20 File Offset: 0x00078020
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002004 RID: 8196 RVA: 0x00079E60 File Offset: 0x00078060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697283, XrefRangeEnd = 697288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06002005 RID: 8197 RVA: 0x00079E94 File Offset: 0x00078094
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002006 RID: 8198 RVA: 0x00012049 File Offset: 0x00010249
			public _SelectNegotiator_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06002007 RID: 8199 RVA: 0x00079ED4 File Offset: 0x000780D4
			// (set) Token: 0x06002008 RID: 8200 RVA: 0x00012052 File Offset: 0x00010252
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06002009 RID: 8201 RVA: 0x00079EFC File Offset: 0x000780FC
			// (set) Token: 0x0600200A RID: 8202 RVA: 0x0001206D File Offset: 0x0001026D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x0600200B RID: 8203 RVA: 0x00079F2C File Offset: 0x0007812C
			// (set) Token: 0x0600200C RID: 8204 RVA: 0x0001208C File Offset: 0x0001028C
			public unsafe WormAcquireTechPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x0600200D RID: 8205 RVA: 0x00079F5C File Offset: 0x0007815C
			// (set) Token: 0x0600200E RID: 8206 RVA: 0x000120AB File Offset: 0x000102AB
			public unsafe EntityComponent _negotiation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__negotiation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__negotiation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x00079F8C File Offset: 0x0007818C
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x000120CA File Offset: 0x000102CA
			public unsafe IEnumerator<Nullable<bool>> _confirm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__confirm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechPromptBehaviour._SelectNegotiator_d__19.NativeFieldInfoPtr__confirm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001279 RID: 4729
			private static readonly IntPtr NativeFieldInfoPtr__negotiation_5__2;

			// Token: 0x0400127A RID: 4730
			private static readonly IntPtr NativeFieldInfoPtr__confirm_5__3;

			// Token: 0x0400127B RID: 4731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400127C RID: 4732
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400127D RID: 4733
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400127E RID: 4734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400127F RID: 4735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001280 RID: 4736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
