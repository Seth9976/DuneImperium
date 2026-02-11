using System;
using boardgames.prompts;
using Canis.utils.ids;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using localization;
using UnityEngine;

namespace boardgames.match.behaviours
{
	// Token: 0x02000287 RID: 647
	public class TutorialPromptBehaviour : PromptBehaviour<TutorialPrompt>
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x00082C84 File Offset: 0x00080E84
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialPromptBehaviour()
		{
			Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "TutorialPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr);
			TutorialPromptBehaviour.NativeFieldInfoPtr_showAnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, "showAnimationName");
			TutorialPromptBehaviour.NativeFieldInfoPtr_hideForTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, "hideForTutorial");
			TutorialPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, "selectionPromptAnimators");
			TutorialPromptBehaviour.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, "description");
			TutorialPromptBehaviour.NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, "skipButton");
			TutorialPromptBehaviour.NativeMethodInfoPtr_getAssociatedEntity_Public_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, 100668281);
			TutorialPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, 100668282);
			TutorialPromptBehaviour.NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, 100668283);
			TutorialPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, 100668284);
			TutorialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr, 100668285);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00082D7C File Offset: 0x00080F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538863, XrefRangeEnd = 538869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID getAssociatedEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPromptBehaviour.NativeMethodInfoPtr_getAssociatedEntity_Public_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00082DBC File Offset: 0x00080FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538869, XrefRangeEnd = 538966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00082DF8 File Offset: 0x00080FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538966, XrefRangeEnd = 538969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SuppressTutorials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPromptBehaviour.NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00082E2C File Offset: 0x0008102C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538969, XrefRangeEnd = 538988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00082E60 File Offset: 0x00081060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 539004, RefRangeEnd = 539005, XrefRangeStart = 538988, XrefRangeEnd = 539004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000100D5 File Offset: 0x0000E2D5
		public TutorialPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00082E9C File Offset: 0x0008109C
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x000100DE File Offset: 0x0000E2DE
		public unsafe int showAnimationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_showAnimationName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_showAnimationName)) = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00082EC4 File Offset: 0x000810C4
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x000100F9 File Offset: 0x0000E2F9
		public unsafe int hideForTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_hideForTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_hideForTutorial)) = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00082EEC File Offset: 0x000810EC
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00010114 File Offset: 0x0000E314
		public unsafe List<Animator> selectionPromptAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Animator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_selectionPromptAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00082F1C File Offset: 0x0008111C
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x00010133 File Offset: 0x0000E333
		public unsafe TMPLocalizer description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMPLocalizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00082F4C File Offset: 0x0008114C
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x00010152 File Offset: 0x0000E352
		public unsafe GameObject skipButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_skipButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialPromptBehaviour.NativeFieldInfoPtr_skipButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_showAnimationName;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_hideForTutorial;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr_selectionPromptAnimators;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeFieldInfoPtr_skipButton;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_getAssociatedEntity_Public_EntityID_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_Event_SuppressTutorials_Public_Void_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
