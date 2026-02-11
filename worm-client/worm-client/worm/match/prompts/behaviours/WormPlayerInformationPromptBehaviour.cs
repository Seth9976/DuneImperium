using System;
using boardgames.match.behaviours;
using boardgames.match.data;
using dwd.core.prefabs.implementations.byflavor;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E0 RID: 224
	public class WormPlayerInformationPromptBehaviour : PromptBehaviour<WormPlayerInformationPrompt>
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x000359A0 File Offset: 0x00033BA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInformationPromptBehaviour()
		{
			Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormPlayerInformationPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr);
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_promptAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "promptAnimator");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_infoParentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "infoParentTransform");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeftParentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "slideInLeftParentTransform");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRightParentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "slideInRightParentTransform");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideOutParentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "slideOutParentTransform");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "prefabLoader");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_leftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "leftButton");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_rightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "rightButton");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_closeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "closeButton");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "slideInLeft");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "slideInRight");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentPlayerInfoPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "currentPlayerInfoPrefabs");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "entitiesProvider");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_previousShownPlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "previousShownPlayerInfo");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentShownPlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "currentShownPlayerInfo");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "currentIndex");
			WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_optionsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, "optionsData");
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664628);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664629);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_Increment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664630);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_Decrement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664631);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_SlideInComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664632);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_UpdatePlayerInfoPrompt_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664633);
			WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr, 100664634);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00035BB0 File Offset: 0x00033DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700404, XrefRangeEnd = 700494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00035BEC File Offset: 0x00033DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700494, XrefRangeEnd = 700500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00035C20 File Offset: 0x00033E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700500, XrefRangeEnd = 700503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Increment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_Increment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00035C54 File Offset: 0x00033E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700503, XrefRangeEnd = 700506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Decrement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_Decrement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00035C88 File Offset: 0x00033E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700506, XrefRangeEnd = 700515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SlideInComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_Event_SlideInComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00035CBC File Offset: 0x00033EBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 700558, RefRangeEnd = 700560, XrefRangeStart = 700515, XrefRangeEnd = 700558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerInfoPrompt(bool isIncrement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isIncrement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr_UpdatePlayerInfoPrompt_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00035CFC File Offset: 0x00033EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700560, XrefRangeEnd = 700570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInformationPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInformationPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInformationPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00006F6A File Offset: 0x0000516A
		public WormPlayerInformationPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00035D38 File Offset: 0x00033F38
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00006F73 File Offset: 0x00005173
		public unsafe Animator promptAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_promptAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_promptAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00035D68 File Offset: 0x00033F68
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00006F92 File Offset: 0x00005192
		public unsafe RectTransform infoParentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_infoParentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_infoParentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00035D98 File Offset: 0x00033F98
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00006FB1 File Offset: 0x000051B1
		public unsafe RectTransform slideInLeftParentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeftParentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeftParentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00035DC8 File Offset: 0x00033FC8
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00006FD0 File Offset: 0x000051D0
		public unsafe RectTransform slideInRightParentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRightParentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRightParentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00035DF8 File Offset: 0x00033FF8
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00006FEF File Offset: 0x000051EF
		public unsafe RectTransform slideOutParentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideOutParentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideOutParentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00035E28 File Offset: 0x00034028
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0000700E File Offset: 0x0000520E
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00035E58 File Offset: 0x00034058
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0000702D File Offset: 0x0000522D
		public unsafe Button leftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_leftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_leftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00035E88 File Offset: 0x00034088
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x0000704C File Offset: 0x0000524C
		public unsafe Button rightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_rightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_rightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00035EB8 File Offset: 0x000340B8
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x0000706B File Offset: 0x0000526B
		public unsafe Button closeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_closeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_closeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00035EE8 File Offset: 0x000340E8
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0000708A File Offset: 0x0000528A
		public unsafe static int slideInLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInLeft, (void*)(&value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00035F04 File Offset: 0x00034104
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00007098 File Offset: 0x00005298
		public unsafe static int slideInRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_slideInRight, (void*)(&value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00035F20 File Offset: 0x00034120
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000070A6 File Offset: 0x000052A6
		public unsafe List<GameObject> currentPlayerInfoPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentPlayerInfoPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentPlayerInfoPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00035F50 File Offset: 0x00034150
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000070C5 File Offset: 0x000052C5
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00035F80 File Offset: 0x00034180
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000070E4 File Offset: 0x000052E4
		public unsafe GameObject previousShownPlayerInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_previousShownPlayerInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_previousShownPlayerInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00035FB0 File Offset: 0x000341B0
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00007103 File Offset: 0x00005303
		public unsafe GameObject currentShownPlayerInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentShownPlayerInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentShownPlayerInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00035FE0 File Offset: 0x000341E0
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00007122 File Offset: 0x00005322
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00036008 File Offset: 0x00034208
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000713D File Offset: 0x0000533D
		public unsafe GameOptionsData optionsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_optionsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInformationPromptBehaviour.NativeFieldInfoPtr_optionsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_promptAnimator;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_infoParentTransform;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_slideInLeftParentTransform;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_slideInRightParentTransform;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_slideOutParentTransform;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_leftButton;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_rightButton;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_closeButton;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_slideInLeft;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_slideInRight;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerInfoPrefabs;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_previousShownPlayerInfo;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_currentShownPlayerInfo;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_optionsData;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_Event_Increment_Public_Void_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_Event_Decrement_Public_Void_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_Event_SlideInComplete_Private_Void_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerInfoPrompt_Private_Void_Boolean_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
