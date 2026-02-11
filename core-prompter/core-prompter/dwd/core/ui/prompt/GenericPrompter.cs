using System;
using boardgames.menus.prompts;
using dwd.core.animation;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.input.context;
using dwd.core.prefabs.implementations.byflavor;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui.prompt
{
	// Token: 0x02000009 RID: 9
	public sealed class GenericPrompter : ScopedPrompter
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00004B18 File Offset: 0x00002D18
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPrompter()
		{
			Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt", "GenericPrompter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr);
			GenericPrompter.NativeFieldInfoPtr_modalBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "modalBackground");
			GenericPrompter.NativeFieldInfoPtr_allowCrossfade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "allowCrossfade");
			GenericPrompter.NativeFieldInfoPtr_fallbackFadeTimeSecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "fallbackFadeTimeSecs");
			GenericPrompter.NativeFieldInfoPtr_blockingCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "blockingCloseAnim");
			GenericPrompter.NativeFieldInfoPtr_onNewPromptingStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "onNewPromptingStarted");
			GenericPrompter.NativeFieldInfoPtr_onShowModalBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "onShowModalBG");
			GenericPrompter.NativeFieldInfoPtr_suppressErrorOnSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "suppressErrorOnSceneChange");
			GenericPrompter.NativeFieldInfoPtr_preloadedPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "preloadedPrompts");
			GenericPrompter.NativeFieldInfoPtr_currentPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "currentPrompts");
			GenericPrompter.NativeFieldInfoPtr_pendingPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "pendingPrompts");
			GenericPrompter.NativeFieldInfoPtr_blockingContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "blockingContexts");
			GenericPrompter.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "animator");
			GenericPrompter.NativeFieldInfoPtr_loadedVignetteScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "loadedVignetteScene");
			GenericPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Virtual_get_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663320);
			GenericPrompter.NativeMethodInfoPtr_get_OnNewPromptingStarted_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663321);
			GenericPrompter.NativeMethodInfoPtr_get_PrefabLoader_Private_get_PrefabByFlavorLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663322);
			GenericPrompter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663323);
			GenericPrompter.NativeMethodInfoPtr_Prompt_Public_Virtual_IEnumerator_IPrompt_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663324);
			GenericPrompter.NativeMethodInfoPtr_displayPrompt_Private_IEnumerator_IPrompt_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663325);
			GenericPrompter.NativeMethodInfoPtr_canBeginPrompting_Private_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663326);
			GenericPrompter.NativeMethodInfoPtr_updatePromptModalBGState_Private_Void_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663327);
			GenericPrompter.NativeMethodInfoPtr_getPromptInstance_Private_GameObject_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663328);
			GenericPrompter.NativeMethodInfoPtr_withInstanceScopedInputBlock_Private_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663329);
			GenericPrompter.NativeMethodInfoPtr_getDataForPrompt_Private_Static_DataComposition_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663330);
			GenericPrompter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, 100663331);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004D3C File Offset: 0x00002F3C
		public unsafe override IPrompt CurrentPrompt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213220, XrefRangeEnd = 1213223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Virtual_get_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr3) : null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004D7C File Offset: 0x00002F7C
		public unsafe UnityEvent OnNewPromptingStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_get_OnNewPromptingStarted_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe PrefabByFlavorLoader PrefabLoader
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213223, XrefRangeEnd = 1213226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_get_PrefabLoader_Private_get_PrefabByFlavorLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr3) : null;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004DFC File Offset: 0x00002FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213226, XrefRangeEnd = 1213263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004E30 File Offset: 0x00003030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213263, XrefRangeEnd = 1213270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator Prompt(IPrompt prompt, ScopedPromptDisplayData displayData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_Prompt_Public_Virtual_IEnumerator_IPrompt_ScopedPromptDisplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004E94 File Offset: 0x00003094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213270, XrefRangeEnd = 1213277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator displayPrompt(IPrompt prompt, ScopedPromptDisplayData displayData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_displayPrompt_Private_IEnumerator_IPrompt_ScopedPromptDisplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004EF8 File Offset: 0x000030F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213304, RefRangeEnd = 1213305, XrefRangeStart = 1213277, XrefRangeEnd = 1213304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool canBeginPrompting(IPrompt newPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_canBeginPrompting_Private_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004F48 File Offset: 0x00003148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213305, XrefRangeEnd = 1213310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updatePromptModalBGState(ScopedPromptDisplayData displayData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_updatePromptModalBGState_Private_Void_ScopedPromptDisplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004F8C File Offset: 0x0000318C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213349, RefRangeEnd = 1213350, XrefRangeStart = 1213310, XrefRangeEnd = 1213349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject getPromptInstance(IPrompt prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_getPromptInstance_Private_GameObject_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004FDC File Offset: 0x000031DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1213356, RefRangeEnd = 1213359, XrefRangeStart = 1213350, XrefRangeEnd = 1213356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator withInstanceScopedInputBlock(IEnumerator innerEnumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerEnumerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_withInstanceScopedInputBlock_Private_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213359, XrefRangeEnd = 1213364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataComposition getDataForPrompt(IPrompt prompt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr_getDataForPrompt_Private_Static_DataComposition_IPrompt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005070 File Offset: 0x00003270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213364, XrefRangeEnd = 1213405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericPrompter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002176 File Offset: 0x00000376
		public GenericPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000050AC File Offset: 0x000032AC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000217F File Offset: 0x0000037F
		public unsafe Transform modalBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_modalBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_modalBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000050DC File Offset: 0x000032DC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000219E File Offset: 0x0000039E
		public unsafe bool allowCrossfade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_allowCrossfade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_allowCrossfade)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005104 File Offset: 0x00003304
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000021B9 File Offset: 0x000003B9
		public unsafe float fallbackFadeTimeSecs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_fallbackFadeTimeSecs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_fallbackFadeTimeSecs)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000512C File Offset: 0x0000332C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000021D4 File Offset: 0x000003D4
		public unsafe TriggeredBlockingAnimation blockingCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_blockingCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_blockingCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000515C File Offset: 0x0000335C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000021F3 File Offset: 0x000003F3
		public unsafe UnityEvent onNewPromptingStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_onNewPromptingStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_onNewPromptingStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000518C File Offset: 0x0000338C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002212 File Offset: 0x00000412
		public unsafe UnityEventBool onShowModalBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_onShowModalBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_onShowModalBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000051BC File Offset: 0x000033BC
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002231 File Offset: 0x00000431
		public unsafe bool suppressErrorOnSceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_suppressErrorOnSceneChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_suppressErrorOnSceneChange)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000051E4 File Offset: 0x000033E4
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000224C File Offset: 0x0000044C
		public unsafe Il2CppReferenceArray<PrefabByFlavorMetadata> preloadedPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_preloadedPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PrefabByFlavorMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_preloadedPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005214 File Offset: 0x00003414
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000226B File Offset: 0x0000046B
		public unsafe List<IPrompt> currentPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_currentPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPrompt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_currentPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005244 File Offset: 0x00003444
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000228A File Offset: 0x0000048A
		public unsafe List<IPrompt> pendingPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_pendingPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPrompt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_pendingPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005274 File Offset: 0x00003474
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000022A9 File Offset: 0x000004A9
		public unsafe List<InputContext> blockingContexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_blockingContexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_blockingContexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000052A4 File Offset: 0x000034A4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000022C8 File Offset: 0x000004C8
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000052D4 File Offset: 0x000034D4
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000022E7 File Offset: 0x000004E7
		public unsafe string loadedVignetteScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_loadedVignetteScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter.NativeFieldInfoPtr_loadedVignetteScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_modalBackground;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_allowCrossfade;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_fallbackFadeTimeSecs;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_blockingCloseAnim;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_onNewPromptingStarted;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_onShowModalBG;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_suppressErrorOnSceneChange;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_preloadedPrompts;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_currentPrompts;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_pendingPrompts;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_blockingContexts;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_loadedVignetteScene;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPrompt_Public_Virtual_get_IPrompt_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_OnNewPromptingStarted_Public_get_UnityEvent_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabLoader_Private_get_PrefabByFlavorLoader_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Prompt_Public_Virtual_IEnumerator_IPrompt_ScopedPromptDisplayData_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_displayPrompt_Private_IEnumerator_IPrompt_ScopedPromptDisplayData_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_canBeginPrompting_Private_Boolean_IPrompt_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_updatePromptModalBGState_Private_Void_ScopedPromptDisplayData_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_getPromptInstance_Private_GameObject_IPrompt_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_withInstanceScopedInputBlock_Private_IEnumerator_IEnumerator_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_getDataForPrompt_Private_Static_DataComposition_IPrompt_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("dwd.core.ui.prompt.GenericPrompter+<Prompt>d__20")]
		public sealed class _Prompt_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x0600029F RID: 671 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Prompt_d__20()
			{
				Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "<Prompt>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr);
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "<>1__state");
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "<>2__current");
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "<>4__this");
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "prompt");
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_displayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "displayData");
				GenericPrompter._Prompt_d__20.NativeFieldInfoPtr__enumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, "<enumerator>5__2");
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663332);
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663333);
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663334);
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663335);
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663336);
				GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr, 100663337);
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Prompt_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompter._Prompt_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000C628 File Offset: 0x0000A828
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000C65C File Offset: 0x0000A85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213055, XrefRangeEnd = 1213071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000C698 File Offset: 0x0000A898
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213071, XrefRangeEnd = 1213076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000C70C File Offset: 0x0000A90C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._Prompt_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x00003536 File Offset: 0x00001736
			public _Prompt_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000C74C File Offset: 0x0000A94C
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000353F File Offset: 0x0000173F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000C774 File Offset: 0x0000A974
			// (set) Token: 0x060002AA RID: 682 RVA: 0x0000355A File Offset: 0x0000175A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
			// (set) Token: 0x060002AC RID: 684 RVA: 0x00003579 File Offset: 0x00001779
			public unsafe GenericPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002AD RID: 685 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
			// (set) Token: 0x060002AE RID: 686 RVA: 0x00003598 File Offset: 0x00001798
			public unsafe IPrompt prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_prompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002AF RID: 687 RVA: 0x0000C804 File Offset: 0x0000AA04
			// (set) Token: 0x060002B0 RID: 688 RVA: 0x000035B7 File Offset: 0x000017B7
			public unsafe ScopedPromptDisplayData displayData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_displayData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedPromptDisplayData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr_displayData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000C834 File Offset: 0x0000AA34
			// (set) Token: 0x060002B2 RID: 690 RVA: 0x000035D6 File Offset: 0x000017D6
			public unsafe IEnumerator _enumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr__enumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._Prompt_d__20.NativeFieldInfoPtr__enumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeFieldInfoPtr_displayData;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeFieldInfoPtr__enumerator_5__2;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("dwd.core.ui.prompt.GenericPrompter+<displayPrompt>d__21")]
		public sealed class _displayPrompt_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x060002B3 RID: 691 RVA: 0x0000C864 File Offset: 0x0000AA64
			// Note: this type is marked as 'beforefieldinit'.
			static _displayPrompt_d__21()
			{
				Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "<displayPrompt>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr);
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<>1__state");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<>2__current");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<>4__this");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "prompt");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_displayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "displayData");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<promptInstance>5__2");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptBehaviours_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<promptBehaviours>5__3");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__vignette_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<vignette>5__4");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptAnims_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<promptAnims>5__5");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__visibilityPromptAnim_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<visibilityPromptAnim>5__6");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__updateDisplayData_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<updateDisplayData>5__7");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptCanvasGroup_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<promptCanvasGroup>5__8");
				GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__block_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, "<block>5__9");
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663338);
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663339);
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663340);
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663341);
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663342);
				GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr, 100663343);
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0000CA0C File Offset: 0x0000AC0C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _displayPrompt_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompter._displayPrompt_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000CA54 File Offset: 0x0000AC54
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000CA88 File Offset: 0x0000AC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213076, XrefRangeEnd = 1213203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0000CB04 File Offset: 0x0000AD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213203, XrefRangeEnd = 1213208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000CB38 File Offset: 0x0000AD38
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._displayPrompt_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002BA RID: 698 RVA: 0x000035F5 File Offset: 0x000017F5
			public _displayPrompt_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002BB RID: 699 RVA: 0x0000CB78 File Offset: 0x0000AD78
			// (set) Token: 0x060002BC RID: 700 RVA: 0x000035FE File Offset: 0x000017FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
			// (set) Token: 0x060002BE RID: 702 RVA: 0x00003619 File Offset: 0x00001819
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x00003638 File Offset: 0x00001838
			public unsafe GenericPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000CC00 File Offset: 0x0000AE00
			// (set) Token: 0x060002C2 RID: 706 RVA: 0x00003657 File Offset: 0x00001857
			public unsafe IPrompt prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_prompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000CC30 File Offset: 0x0000AE30
			// (set) Token: 0x060002C4 RID: 708 RVA: 0x00003676 File Offset: 0x00001876
			public unsafe ScopedPromptDisplayData displayData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_displayData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedPromptDisplayData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr_displayData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000CC60 File Offset: 0x0000AE60
			// (set) Token: 0x060002C6 RID: 710 RVA: 0x00003695 File Offset: 0x00001895
			public unsafe GameObject _promptInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000CC90 File Offset: 0x0000AE90
			// (set) Token: 0x060002C8 RID: 712 RVA: 0x000036B4 File Offset: 0x000018B4
			public unsafe Il2CppReferenceArray<PromptBehaviour> _promptBehaviours_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptBehaviours_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PromptBehaviour>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptBehaviours_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
			// (set) Token: 0x060002CA RID: 714 RVA: 0x000036D3 File Offset: 0x000018D3
			public unsafe IVignetteScenePrompt _vignette_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__vignette_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVignetteScenePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__vignette_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
			// (set) Token: 0x060002CC RID: 716 RVA: 0x000036F2 File Offset: 0x000018F2
			public unsafe PromptAnims _promptAnims_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptAnims_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptAnims_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002CD RID: 717 RVA: 0x0000CD20 File Offset: 0x0000AF20
			// (set) Token: 0x060002CE RID: 718 RVA: 0x00003711 File Offset: 0x00001911
			public unsafe VisibilityPromptAnimator _visibilityPromptAnim_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__visibilityPromptAnim_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityPromptAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__visibilityPromptAnim_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002CF RID: 719 RVA: 0x0000CD50 File Offset: 0x0000AF50
			// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003730 File Offset: 0x00001930
			public unsafe bool _updateDisplayData_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__updateDisplayData_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__updateDisplayData_5__7)) = value;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000CD78 File Offset: 0x0000AF78
			// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000374B File Offset: 0x0000194B
			public unsafe CanvasGroup _promptCanvasGroup_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptCanvasGroup_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__promptCanvasGroup_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
			// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000376A File Offset: 0x0000196A
			public unsafe IEnumerator _block_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__block_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._displayPrompt_d__21.NativeFieldInfoPtr__block_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeFieldInfoPtr_displayData;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeFieldInfoPtr__promptInstance_5__2;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr__promptBehaviours_5__3;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr__vignette_5__4;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr__promptAnims_5__5;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeFieldInfoPtr__visibilityPromptAnim_5__6;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr__updateDisplayData_5__7;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeFieldInfoPtr__promptCanvasGroup_5__8;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeFieldInfoPtr__block_5__9;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("dwd.core.ui.prompt.GenericPrompter+<withInstanceScopedInputBlock>d__25")]
		public sealed class _withInstanceScopedInputBlock_d__25 : global::Il2CppSystem.Object
		{
			// Token: 0x060002D5 RID: 725 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
			// Note: this type is marked as 'beforefieldinit'.
			static _withInstanceScopedInputBlock_d__25()
			{
				Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPrompter>.NativeClassPtr, "<withInstanceScopedInputBlock>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, "<>1__state");
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, "<>2__current");
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr_innerEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, "innerEnumerator");
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, "<>4__this");
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr__blockingTransition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, "<blockingTransition>5__2");
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663344);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663345);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663346);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663347);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663348);
				GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr, 100663349);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _withInstanceScopedInputBlock_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompter._withInstanceScopedInputBlock_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x0000CF28 File Offset: 0x0000B128
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000CF5C File Offset: 0x0000B15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213208, XrefRangeEnd = 1213215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000CF98 File Offset: 0x0000B198
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213215, XrefRangeEnd = 1213220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0000D00C File Offset: 0x0000B20C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002DC RID: 732 RVA: 0x00003789 File Offset: 0x00001989
			public _withInstanceScopedInputBlock_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060002DD RID: 733 RVA: 0x0000D04C File Offset: 0x0000B24C
			// (set) Token: 0x060002DE RID: 734 RVA: 0x00003792 File Offset: 0x00001992
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060002DF RID: 735 RVA: 0x0000D074 File Offset: 0x0000B274
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x000037AD File Offset: 0x000019AD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
			// (set) Token: 0x060002E2 RID: 738 RVA: 0x000037CC File Offset: 0x000019CC
			public unsafe IEnumerator innerEnumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr_innerEnumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr_innerEnumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
			// (set) Token: 0x060002E4 RID: 740 RVA: 0x000037EB File Offset: 0x000019EB
			public unsafe GenericPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000D104 File Offset: 0x0000B304
			// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000380A File Offset: 0x00001A0A
			public unsafe WithBlockingInputContext _blockingTransition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr__blockingTransition_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WithBlockingInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompter._withInstanceScopedInputBlock_d__25.NativeFieldInfoPtr__blockingTransition_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeFieldInfoPtr_innerEnumerator;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeFieldInfoPtr__blockingTransition_5__2;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
