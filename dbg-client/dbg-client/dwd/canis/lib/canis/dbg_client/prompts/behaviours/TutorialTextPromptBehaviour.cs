using System;
using boardgames.prompts;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lib.boardgames.src.localization;
using TMPro;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.prompts.behaviours
{
	// Token: 0x02000051 RID: 81
	public class TutorialTextPromptBehaviour : PromptBehaviour<TutorialPrompt>
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0002778C File Offset: 0x0002598C
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialTextPromptBehaviour()
		{
			Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.prompts.behaviours", "TutorialTextPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr);
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_showAnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "showAnimationName");
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_hideForTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "hideForTutorial");
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "selectionPromptAnimators");
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_locSubstitutor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "locSubstitutor");
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "description");
			TutorialTextPromptBehaviour.NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, "skipButton");
			TutorialTextPromptBehaviour.NativeMethodInfoPtr_GetAssociatedEntity_Public_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663800);
			TutorialTextPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663801);
			TutorialTextPromptBehaviour.NativeMethodInfoPtr_SetPromptText_Private_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663802);
			TutorialTextPromptBehaviour.NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663803);
			TutorialTextPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663804);
			TutorialTextPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr, 100663805);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000278AC File Offset: 0x00025AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499444, XrefRangeEnd = 499450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID GetAssociatedEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTextPromptBehaviour.NativeMethodInfoPtr_GetAssociatedEntity_Public_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000278EC File Offset: 0x00025AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499450, XrefRangeEnd = 499556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialTextPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00027928 File Offset: 0x00025B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499556, XrefRangeEnd = 499565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPromptText(LocalizableText locText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTextPromptBehaviour.NativeMethodInfoPtr_SetPromptText_Private_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0002796C File Offset: 0x00025B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499565, XrefRangeEnd = 499568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SuppressTutorials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTextPromptBehaviour.NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000279A0 File Offset: 0x00025BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499568, XrefRangeEnd = 499587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTextPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000279D4 File Offset: 0x00025BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499587, XrefRangeEnd = 499603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialTextPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTextPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTextPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003598 File Offset: 0x00001798
		public TutorialTextPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00027A10 File Offset: 0x00025C10
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000035A1 File Offset: 0x000017A1
		public unsafe int showAnimationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_showAnimationName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_showAnimationName)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00027A38 File Offset: 0x00025C38
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000035BC File Offset: 0x000017BC
		public unsafe int hideForTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_hideForTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_hideForTutorial)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00027A60 File Offset: 0x00025C60
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000035D7 File Offset: 0x000017D7
		public unsafe List<Animator> selectionPromptAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00027A90 File Offset: 0x00025C90
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000035F6 File Offset: 0x000017F6
		public unsafe ILocalizationSubstitutor locSubstitutor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_locSubstitutor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalizationSubstitutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_locSubstitutor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00027AC0 File Offset: 0x00025CC0
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003615 File Offset: 0x00001815
		public unsafe TMP_Text description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00027AF0 File Offset: 0x00025CF0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003634 File Offset: 0x00001834
		public unsafe GameObject skipButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_skipButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTextPromptBehaviour.NativeFieldInfoPtr_skipButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_showAnimationName;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_hideForTutorial;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_selectionPromptAnimators;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_locSubstitutor;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_skipButton;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_GetAssociatedEntity_Public_EntityID_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_SetPromptText_Private_Void_LocalizableText_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
