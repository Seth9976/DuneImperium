using System;
using boardgames.match;
using Canis.utils.ids;
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
using UnityEngine.UI;
using worm.canis.data.enums;
using worm.match.components;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E1 RID: 225
	public class WormSelectEntityPromptBehaviour : PromptBehaviour<WormSelectEntityPrompt>
	{
		// Token: 0x060009CD RID: 2509 RVA: 0x00036038 File Offset: 0x00034238
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectEntityPromptBehaviour()
		{
			Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSelectEntityPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr);
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "confirmButton");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "cancelButton");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "pileView");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "toggleGroup");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "noUndoMessage");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoCursorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "noUndoCursorHandler");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_previewer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "previewer");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_onEntitySelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "onEntitySelected");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "entities");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "tempPile");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "selectedEntities");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_targetWillClearUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "targetWillClearUndo");
			WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_initializeClientEventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "initializeClientEventTrigger");
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664636);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664637);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664638);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664639);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664640);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ClearSelections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664641);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664642);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664643);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664644);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664645);
			WormSelectEntityPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, 100664646);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00036248 File Offset: 0x00034448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700605, XrefRangeEnd = 700695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00036284 File Offset: 0x00034484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700695, XrefRangeEnd = 700700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000362C4 File Offset: 0x000344C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 700719, RefRangeEnd = 700722, XrefRangeStart = 700700, XrefRangeEnd = 700719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000362F8 File Offset: 0x000344F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 700774, RefRangeEnd = 700775, XrefRangeStart = 700722, XrefRangeEnd = 700774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOn(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00036338 File Offset: 0x00034538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 700805, RefRangeEnd = 700806, XrefRangeStart = 700775, XrefRangeEnd = 700805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOff(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00036378 File Offset: 0x00034578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700806, XrefRangeEnd = 700827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClearSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ClearSelections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000363AC File Offset: 0x000345AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700827, XrefRangeEnd = 700833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000363E0 File Offset: 0x000345E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700833, XrefRangeEnd = 700838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator attemptSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00036420 File Offset: 0x00034620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700838, XrefRangeEnd = 700879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00036454 File Offset: 0x00034654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700879, XrefRangeEnd = 700882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectEntityPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00036490 File Offset: 0x00034690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700882, XrefRangeEnd = 700905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectEntityPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0000715C File Offset: 0x0000535C
		public WormSelectEntityPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x000364CC File Offset: 0x000346CC
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00007165 File Offset: 0x00005365
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x000364FC File Offset: 0x000346FC
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00007184 File Offset: 0x00005384
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0003652C File Offset: 0x0003472C
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x000071A3 File Offset: 0x000053A3
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0003655C File Offset: 0x0003475C
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x000071C2 File Offset: 0x000053C2
		public unsafe ToggleGroup toggleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0003658C File Offset: 0x0003478C
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000071E1 File Offset: 0x000053E1
		public unsafe GameObject noUndoMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000365BC File Offset: 0x000347BC
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00007200 File Offset: 0x00005400
		public unsafe WormWillClearUndoCursorHandler noUndoCursorHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoCursorHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_noUndoCursorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000365EC File Offset: 0x000347EC
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0000721F File Offset: 0x0000541F
		public unsafe FactionInfluencePreviewSetter previewer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_previewer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FactionInfluencePreviewSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_previewer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003661C File Offset: 0x0003481C
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000723E File Offset: 0x0000543E
		public unsafe UnityEvent onEntitySelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_onEntitySelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_onEntitySelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003664C File Offset: 0x0003484C
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0000725D File Offset: 0x0000545D
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0003667C File Offset: 0x0003487C
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000727C File Offset: 0x0000547C
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000366AC File Offset: 0x000348AC
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000729B File Offset: 0x0000549B
		public unsafe List<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000366DC File Offset: 0x000348DC
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000072BA File Offset: 0x000054BA
		public unsafe IReadOnlyList<EntityID> targetWillClearUndo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_targetWillClearUndo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_targetWillClearUndo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003670C File Offset: 0x0003490C
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000072D9 File Offset: 0x000054D9
		public unsafe string initializeClientEventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_initializeClientEventTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.NativeFieldInfoPtr_initializeClientEventTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_toggleGroup;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_noUndoMessage;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_noUndoCursorHandler;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_previewer;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_onEntitySelected;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_targetWillClearUndo;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_initializeClientEventTrigger;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClearSelections_Public_Void_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_Event_Submit_Public_Void_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000341 RID: 833
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectEntityPromptBehaviour+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060021AF RID: 8623 RVA: 0x0007EA14 File Offset: 0x0007CC14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr);
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, "buttonIndex");
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100664647);
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100664648);
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__initialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100664649);
			}

			// Token: 0x060021B0 RID: 8624 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B1 RID: 8625 RVA: 0x0007EAE0 File Offset: 0x0007CCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700570, XrefRangeEnd = 700572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B2 RID: 8626 RVA: 0x0007EB14 File Offset: 0x0007CD14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700572, XrefRangeEnd = 700574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__initialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B3 RID: 8627 RVA: 0x00012E82 File Offset: 0x00011082
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0007EB48 File Offset: 0x0007CD48
			// (set) Token: 0x060021B5 RID: 8629 RVA: 0x00012E8B File Offset: 0x0001108B
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0007EB70 File Offset: 0x0007CD70
			// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00012EA6 File Offset: 0x000110A6
			public unsafe WormSelectEntityPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001368 RID: 4968
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Void_0;

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_Internal_Void_0;
		}

		// Token: 0x02000342 RID: 834
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectEntityPromptBehaviour+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : global::Il2CppSystem.Object
		{
			// Token: 0x060021B8 RID: 8632 RVA: 0x0007EBA0 File Offset: 0x0007CDA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr);
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_currentFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr, "currentFaction");
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr, 100664650);
				WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeMethodInfoPtr__initialize_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr, 100664651);
			}

			// Token: 0x060021B9 RID: 8633 RVA: 0x0007EC1C File Offset: 0x0007CE1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BA RID: 8634 RVA: 0x0007EC58 File Offset: 0x0007CE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700574, XrefRangeEnd = 700576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeMethodInfoPtr__initialize_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BB RID: 8635 RVA: 0x00012EC5 File Offset: 0x000110C5
			public __c__DisplayClass13_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x060021BC RID: 8636 RVA: 0x0007EC8C File Offset: 0x0007CE8C
			// (set) Token: 0x060021BD RID: 8637 RVA: 0x00012ECE File Offset: 0x000110CE
			public unsafe Factions currentFaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_currentFaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_currentFaction)) = value;
				}
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x060021BE RID: 8638 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
			// (set) Token: 0x060021BF RID: 8639 RVA: 0x00012EE9 File Offset: 0x000110E9
			public unsafe WormSelectEntityPromptBehaviour.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPromptBehaviour.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeFieldInfoPtr_currentFaction;

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x0400136F RID: 4975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001370 RID: 4976
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__2_Internal_Void_0;
		}

		// Token: 0x02000343 RID: 835
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectEntityPromptBehaviour+<Start>d__14")]
		public sealed class _Start_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x060021C0 RID: 8640 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__14()
			{
				Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "<Start>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, "<>1__state");
				WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, "<>2__current");
				WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, "<>4__this");
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664652);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664653);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664654);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664655);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664656);
				WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr, 100664657);
			}

			// Token: 0x060021C1 RID: 8641 RVA: 0x0007EDC4 File Offset: 0x0007CFC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._Start_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021C2 RID: 8642 RVA: 0x0007EE0C File Offset: 0x0007D00C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021C3 RID: 8643 RVA: 0x0007EE40 File Offset: 0x0007D040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700576, XrefRangeEnd = 700579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0007EE7C File Offset: 0x0007D07C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021C5 RID: 8645 RVA: 0x0007EEBC File Offset: 0x0007D0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700579, XrefRangeEnd = 700584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0007EEF0 File Offset: 0x0007D0F0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._Start_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021C7 RID: 8647 RVA: 0x00012F08 File Offset: 0x00011108
			public _Start_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x060021C8 RID: 8648 RVA: 0x0007EF30 File Offset: 0x0007D130
			// (set) Token: 0x060021C9 RID: 8649 RVA: 0x00012F11 File Offset: 0x00011111
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x060021CA RID: 8650 RVA: 0x0007EF58 File Offset: 0x0007D158
			// (set) Token: 0x060021CB RID: 8651 RVA: 0x00012F2C File Offset: 0x0001112C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x060021CC RID: 8652 RVA: 0x0007EF88 File Offset: 0x0007D188
			// (set) Token: 0x060021CD RID: 8653 RVA: 0x00012F4B File Offset: 0x0001114B
			public unsafe WormSelectEntityPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._Start_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001371 RID: 4977
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001372 RID: 4978
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001373 RID: 4979
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001374 RID: 4980
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001375 RID: 4981
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001376 RID: 4982
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001377 RID: 4983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001378 RID: 4984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001379 RID: 4985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000344 RID: 836
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectEntityPromptBehaviour+<attemptSubmit>d__20")]
		public sealed class _attemptSubmit_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x060021CE RID: 8654 RVA: 0x0007EFB8 File Offset: 0x0007D1B8
			// Note: this type is marked as 'beforefieldinit'.
			static _attemptSubmit_d__20()
			{
				Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour>.NativeClassPtr, "<attemptSubmit>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, "<>1__state");
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, "<>2__current");
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, "<>4__this");
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr__submitConfirmation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, "<submitConfirmation>5__2");
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664658);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664659);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664660);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664661);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664662);
				WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr, 100664663);
			}

			// Token: 0x060021CF RID: 8655 RVA: 0x0007F0AC File Offset: 0x0007D2AC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _attemptSubmit_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPromptBehaviour._attemptSubmit_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021D0 RID: 8656 RVA: 0x0007F0F4 File Offset: 0x0007D2F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021D1 RID: 8657 RVA: 0x0007F128 File Offset: 0x0007D328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700584, XrefRangeEnd = 700600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0007F164 File Offset: 0x0007D364
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021D3 RID: 8659 RVA: 0x0007F1A4 File Offset: 0x0007D3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700600, XrefRangeEnd = 700605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0007F1D8 File Offset: 0x0007D3D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021D5 RID: 8661 RVA: 0x00012F6A File Offset: 0x0001116A
			public _attemptSubmit_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0007F218 File Offset: 0x0007D418
			// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00012F73 File Offset: 0x00011173
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x060021D8 RID: 8664 RVA: 0x0007F240 File Offset: 0x0007D440
			// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00012F8E File Offset: 0x0001118E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x060021DA RID: 8666 RVA: 0x0007F270 File Offset: 0x0007D470
			// (set) Token: 0x060021DB RID: 8667 RVA: 0x00012FAD File Offset: 0x000111AD
			public unsafe WormSelectEntityPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x060021DC RID: 8668 RVA: 0x0007F2A0 File Offset: 0x0007D4A0
			// (set) Token: 0x060021DD RID: 8669 RVA: 0x00012FCC File Offset: 0x000111CC
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr__submitConfirmation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPromptBehaviour._attemptSubmit_d__20.NativeFieldInfoPtr__submitConfirmation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400137A RID: 4986
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400137B RID: 4987
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400137C RID: 4988
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400137D RID: 4989
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__2;

			// Token: 0x0400137E RID: 4990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400137F RID: 4991
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001380 RID: 4992
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001381 RID: 4993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001382 RID: 4994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001383 RID: 4995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
