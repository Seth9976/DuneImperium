using System;
using boardgames.match.behaviours;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using worm.match.dataRenderers;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000DC RID: 220
	public class WormLeaderSelectionDisplayPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x0003490C File Offset: 0x00032B0C
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderSelectionDisplayPromptBehaviour()
		{
			Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormLeaderSelectionDisplayPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr);
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_playerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "playerView");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "pileView");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_toggleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "toggleGroup");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "leaderDetailsProvider");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_headerRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "headerRenderer");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "leaderDetailsDisplays");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDisplayOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "leaderDisplayOrder");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_onLeaderChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "onLeaderChanged");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "entities");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "archetypeProvider");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "tempPile");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_lastSelectedLeadersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "lastSelectedLeadersCount");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_showOpponentSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "showOpponentSelections");
			WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_availableSelectionLeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "availableSelectionLeaders");
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_get_SelectedLeader_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664562);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_get_OnLeaderChanged_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664563);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664564);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664565);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_SetAvailableLeaders_Public_Void_IReadOnlyCollection_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664566);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664567);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Event_SetDisplayedLeader_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664568);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664569);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664570);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664571);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__Init_b__19_0_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664572);
			WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__Init_b__19_1_Private_EntityComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, 100664573);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00034B44 File Offset: 0x00032D44
		public unsafe ArchetypeID SelectedLeader
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 699809, RefRangeEnd = 699811, XrefRangeStart = 699805, XrefRangeEnd = 699809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_get_SelectedLeader_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00034B84 File Offset: 0x00032D84
		public unsafe UnityEvent OnLeaderChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_get_OnLeaderChanged_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00034BC4 File Offset: 0x00032DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699811, XrefRangeEnd = 699824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00034C00 File Offset: 0x00032E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699824, XrefRangeEnd = 699829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00034C40 File Offset: 0x00032E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvailableLeaders(IReadOnlyCollection<EntityComponent> leaders)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaders);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_SetAvailableLeaders_Public_Void_IReadOnlyCollection_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00034C84 File Offset: 0x00032E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699829, XrefRangeEnd = 699969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00034CB8 File Offset: 0x00032EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699969, XrefRangeEnd = 699975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetDisplayedLeader(GameObject display)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(display);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_Event_SetDisplayedLeader_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00034CFC File Offset: 0x00032EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699975, XrefRangeEnd = 699978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00034D38 File Offset: 0x00032F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699978, XrefRangeEnd = 699982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00034D6C File Offset: 0x00032F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699982, XrefRangeEnd = 699998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderSelectionDisplayPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00034DA8 File Offset: 0x00032FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699998, XrefRangeEnd = 700013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Init_b__19_0(ArchetypeID a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__Init_b__19_0_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00034DF8 File Offset: 0x00032FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700013, XrefRangeEnd = 700015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent _Init_b__19_1(ArchetypeID a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.NativeMethodInfoPtr__Init_b__19_1_Private_EntityComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00006C66 File Offset: 0x00004E66
		public WormLeaderSelectionDisplayPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00034E48 File Offset: 0x00033048
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00006C6F File Offset: 0x00004E6F
		public unsafe EntityView playerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_playerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_playerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00034E78 File Offset: 0x00033078
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00006C8E File Offset: 0x00004E8E
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00034EA8 File Offset: 0x000330A8
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00006CAD File Offset: 0x00004EAD
		public unsafe ToggleGroup toggleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_toggleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_toggleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00034ED8 File Offset: 0x000330D8
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00006CCC File Offset: 0x00004ECC
		public unsafe SubscriptionProvider leaderDetailsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00034F08 File Offset: 0x00033108
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00006CEB File Offset: 0x00004EEB
		public unsafe WormSelectLeaderHeaderRenderer headerRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_headerRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectLeaderHeaderRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_headerRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00034F38 File Offset: 0x00033138
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00006D0A File Offset: 0x00004F0A
		public unsafe Il2CppReferenceArray<GameObject> leaderDetailsDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDetailsDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00034F68 File Offset: 0x00033168
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00006D29 File Offset: 0x00004F29
		public unsafe Il2CppReferenceArray<ArchetypeID> leaderDisplayOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDisplayOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_leaderDisplayOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00034F98 File Offset: 0x00033198
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00006D48 File Offset: 0x00004F48
		public unsafe UnityEvent onLeaderChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_onLeaderChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_onLeaderChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00034FC8 File Offset: 0x000331C8
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00006D67 File Offset: 0x00004F67
		public unsafe WormEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00034FF8 File Offset: 0x000331F8
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00006D86 File Offset: 0x00004F86
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00035028 File Offset: 0x00033228
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00006DA5 File Offset: 0x00004FA5
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00035058 File Offset: 0x00033258
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00006DC4 File Offset: 0x00004FC4
		public unsafe int lastSelectedLeadersCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_lastSelectedLeadersCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_lastSelectedLeadersCount)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00035080 File Offset: 0x00033280
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00006DDF File Offset: 0x00004FDF
		public unsafe bool showOpponentSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_showOpponentSelections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_showOpponentSelections)) = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x000350A8 File Offset: 0x000332A8
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00006DFA File Offset: 0x00004FFA
		public unsafe IReadOnlyCollection<EntityComponent> availableSelectionLeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_availableSelectionLeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.NativeFieldInfoPtr_availableSelectionLeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_playerView;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_toggleGroup;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_leaderDetailsProvider;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_headerRenderer;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_leaderDetailsDisplays;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_leaderDisplayOrder;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_onLeaderChanged;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedLeadersCount;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_showOpponentSelections;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_availableSelectionLeaders;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedLeader_Public_get_ArchetypeID_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_get_OnLeaderChanged_Public_get_UnityEvent_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_SetAvailableLeaders_Public_Void_IReadOnlyCollection_1_EntityComponent_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetDisplayedLeader_Public_Void_GameObject_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr__Init_b__19_0_Private_Boolean_ArchetypeID_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr__Init_b__19_1_Private_EntityComponent_ArchetypeID_0;

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("worm.match.prompts.behaviours.WormLeaderSelectionDisplayPromptBehaviour+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002140 RID: 8512 RVA: 0x0007D62C File Offset: 0x0007B82C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr, "a");
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr, 100664574);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr, 100664575);
			}

			// Token: 0x06002141 RID: 8513 RVA: 0x0007D694 File Offset: 0x0007B894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002142 RID: 8514 RVA: 0x0007D6D0 File Offset: 0x0007B8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699692, XrefRangeEnd = 699707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__2(EntityComponent l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002143 RID: 8515 RVA: 0x00012AEA File Offset: 0x00010CEA
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06002144 RID: 8516 RVA: 0x0007D720 File Offset: 0x0007B920
			// (set) Token: 0x06002145 RID: 8517 RVA: 0x00012AF3 File Offset: 0x00010CF3
			public unsafe ArchetypeID a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000337 RID: 823
		[ObfuscatedName("worm.match.prompts.behaviours.WormLeaderSelectionDisplayPromptBehaviour+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002146 RID: 8518 RVA: 0x0007D750 File Offset: 0x0007B950
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr, "view");
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr, "<>4__this");
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr, 100664576);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__Init_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr, 100664577);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__Init_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr, 100664578);
			}

			// Token: 0x06002147 RID: 8519 RVA: 0x0007D7E0 File Offset: 0x0007B9E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002148 RID: 8520 RVA: 0x0007D81C File Offset: 0x0007BA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699707, XrefRangeEnd = 699711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Init_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__Init_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002149 RID: 8521 RVA: 0x0007D850 File Offset: 0x0007BA50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699711, XrefRangeEnd = 699735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Init_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeMethodInfoPtr__Init_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x00012B12 File Offset: 0x00010D12
			public __c__DisplayClass19_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x0007D884 File Offset: 0x0007BA84
			// (set) Token: 0x0600214C RID: 8524 RVA: 0x00012B1B File Offset: 0x00010D1B
			public unsafe UnitView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x0007D8B4 File Offset: 0x0007BAB4
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x00012B3A File Offset: 0x00010D3A
			public unsafe WormLeaderSelectionDisplayPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeaderSelectionDisplayPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass19_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__3_Internal_Void_0;

			// Token: 0x04001331 RID: 4913
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__4_Internal_Void_0;
		}

		// Token: 0x02000338 RID: 824
		[ObfuscatedName("worm.match.prompts.behaviours.WormLeaderSelectionDisplayPromptBehaviour+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600214F RID: 8527 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_currentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, "currentSelection");
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100664579);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_KeyValuePair_2_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100664580);
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x0007D94C File Offset: 0x0007BB4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x0007D988 File Offset: 0x0007BB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699735, XrefRangeEnd = 699751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Update_b__0(KeyValuePair<AccountID, EntityComponent> leader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(leader));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_KeyValuePair_2_AccountID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x00012B59 File Offset: 0x00010D59
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x0007D9DC File Offset: 0x0007BBDC
			// (set) Token: 0x06002154 RID: 8532 RVA: 0x00012B62 File Offset: 0x00010D62
			public unsafe ArchetypeID currentSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_currentSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_currentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001332 RID: 4914
			private static readonly IntPtr NativeFieldInfoPtr_currentSelection;

			// Token: 0x04001333 RID: 4915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001334 RID: 4916
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Boolean_KeyValuePair_2_AccountID_EntityComponent_0;
		}

		// Token: 0x02000339 RID: 825
		[ObfuscatedName("worm.match.prompts.behaviours.WormLeaderSelectionDisplayPromptBehaviour+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002155 RID: 8533 RVA: 0x0007DA0C File Offset: 0x0007BC0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr, "archID");
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr, 100664581);
				WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr, 100664582);
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x0007DA74 File Offset: 0x0007BC74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x0007DAB0 File Offset: 0x0007BCB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699751, XrefRangeEnd = 699766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Update_b__1(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__Update_b__1_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002158 RID: 8536 RVA: 0x00012B81 File Offset: 0x00010D81
			public __c__DisplayClass21_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x0007DB00 File Offset: 0x0007BD00
			// (set) Token: 0x0600215A RID: 8538 RVA: 0x00012B8A File Offset: 0x00010D8A
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__1_Internal_Boolean_UnitView_0;
		}

		// Token: 0x0200033A RID: 826
		[ObfuscatedName("worm.match.prompts.behaviours.WormLeaderSelectionDisplayPromptBehaviour+<Init>d__19")]
		public sealed class _Init_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x0600215B RID: 8539 RVA: 0x0007DB30 File Offset: 0x0007BD30
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__19()
			{
				Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour>.NativeClassPtr, "<Init>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<>1__state");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<>2__current");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<>4__this");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<entitiesProvider>5__2");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__localPlayer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<localPlayer>5__3");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__leaderOptions_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<leaderOptions>5__4");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__preSelectionLeaderOptions_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, "<preSelectionLeaderOptions>5__5");
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664583);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664584);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664585);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664586);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664587);
				WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr, 100664588);
			}

			// Token: 0x0600215C RID: 8540 RVA: 0x0007DC60 File Offset: 0x0007BE60
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionDisplayPromptBehaviour._Init_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x0007DCDC File Offset: 0x0007BEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699766, XrefRangeEnd = 699800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x0600215F RID: 8543 RVA: 0x0007DD18 File Offset: 0x0007BF18
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002160 RID: 8544 RVA: 0x0007DD58 File Offset: 0x0007BF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699800, XrefRangeEnd = 699805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x06002161 RID: 8545 RVA: 0x0007DD8C File Offset: 0x0007BF8C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002162 RID: 8546 RVA: 0x00012BA9 File Offset: 0x00010DA9
			public _Init_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06002163 RID: 8547 RVA: 0x0007DDCC File Offset: 0x0007BFCC
			// (set) Token: 0x06002164 RID: 8548 RVA: 0x00012BB2 File Offset: 0x00010DB2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06002165 RID: 8549 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
			// (set) Token: 0x06002166 RID: 8550 RVA: 0x00012BCD File Offset: 0x00010DCD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x06002167 RID: 8551 RVA: 0x0007DE24 File Offset: 0x0007C024
			// (set) Token: 0x06002168 RID: 8552 RVA: 0x00012BEC File Offset: 0x00010DEC
			public unsafe WormLeaderSelectionDisplayPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeaderSelectionDisplayPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x06002169 RID: 8553 RVA: 0x0007DE54 File Offset: 0x0007C054
			// (set) Token: 0x0600216A RID: 8554 RVA: 0x00012C0B File Offset: 0x00010E0B
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x0600216B RID: 8555 RVA: 0x0007DE84 File Offset: 0x0007C084
			// (set) Token: 0x0600216C RID: 8556 RVA: 0x00012C2A File Offset: 0x00010E2A
			public unsafe EntityComponent _localPlayer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__localPlayer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__localPlayer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x0600216D RID: 8557 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
			// (set) Token: 0x0600216E RID: 8558 RVA: 0x00012C49 File Offset: 0x00010E49
			public unsafe IEnumerable<ArchetypeID> _leaderOptions_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__leaderOptions_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__leaderOptions_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x0600216F RID: 8559 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
			// (set) Token: 0x06002170 RID: 8560 RVA: 0x00012C68 File Offset: 0x00010E68
			public unsafe ReadOnlyAttribute<List<ArchetypeID>> _preSelectionLeaderOptions_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__preSelectionLeaderOptions_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<List<ArchetypeID>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionDisplayPromptBehaviour._Init_d__19.NativeFieldInfoPtr__preSelectionLeaderOptions_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeFieldInfoPtr__localPlayer_5__3;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeFieldInfoPtr__leaderOptions_5__4;

			// Token: 0x0400133E RID: 4926
			private static readonly IntPtr NativeFieldInfoPtr__preSelectionLeaderOptions_5__5;

			// Token: 0x0400133F RID: 4927
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001340 RID: 4928
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001341 RID: 4929
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001342 RID: 4930
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001343 RID: 4931
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001344 RID: 4932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
