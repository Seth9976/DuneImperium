using System;
using boardgames.match.data;
using Canis.utils.localization;
using dwd.core.match.data;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.boardgames.src.localization;
using TMPro;
using UnityEngine;
using voodoo;

namespace boardgames.match.behaviours
{
	// Token: 0x02000286 RID: 646
	public class SelectionPromptRenderer : VersionedDataComponentObserver<OpponentActivityData>
	{
		// Token: 0x06001E45 RID: 7749 RVA: 0x0008272C File Offset: 0x0008092C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionPromptRenderer()
		{
			Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "SelectionPromptRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr);
			SelectionPromptRenderer.NativeFieldInfoPtr_ANIMATION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "ANIMATION_DURATION");
			SelectionPromptRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "animator");
			SelectionPromptRenderer.NativeFieldInfoPtr_promptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "promptText");
			SelectionPromptRenderer.NativeFieldInfoPtr_selectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "selectionString");
			SelectionPromptRenderer.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "selection");
			SelectionPromptRenderer.NativeFieldInfoPtr_showHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "showHash");
			SelectionPromptRenderer.NativeFieldInfoPtr_runningTextSequentially = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "runningTextSequentially");
			SelectionPromptRenderer.NativeFieldInfoPtr_promptTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "promptTexts");
			SelectionPromptRenderer.NativeFieldInfoPtr_showOpponentActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "showOpponentActivity");
			SelectionPromptRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "entitiesProvider");
			SelectionPromptRenderer.NativeFieldInfoPtr_locSubstitutor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "locSubstitutor");
			SelectionPromptRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668268);
			SelectionPromptRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668269);
			SelectionPromptRenderer.NativeMethodInfoPtr_SetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668270);
			SelectionPromptRenderer.NativeMethodInfoPtr_setPromptText_Protected_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668271);
			SelectionPromptRenderer.NativeMethodInfoPtr_DisplayTextSequentially_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668272);
			SelectionPromptRenderer.NativeMethodInfoPtr_ResetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668273);
			SelectionPromptRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, 100668274);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000828C4 File Offset: 0x00080AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538769, XrefRangeEnd = 538780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionPromptRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00082900 File Offset: 0x00080B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538780, XrefRangeEnd = 538793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionPromptRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0008293C File Offset: 0x00080B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538793, XrefRangeEnd = 538807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSelectionPromptText(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionPromptRenderer.NativeMethodInfoPtr_SetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0008298C File Offset: 0x00080B8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 538831, RefRangeEnd = 538834, XrefRangeStart = 538807, XrefRangeEnd = 538831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setPromptText(LocalizableText locText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer.NativeMethodInfoPtr_setPromptText_Protected_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000829D0 File Offset: 0x00080BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538834, XrefRangeEnd = 538839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisplayTextSequentially()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer.NativeMethodInfoPtr_DisplayTextSequentially_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00082A10 File Offset: 0x00080C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538839, XrefRangeEnd = 538847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetSelectionPromptText(ISelectionNode _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionPromptRenderer.NativeMethodInfoPtr_ResetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00082A60 File Offset: 0x00080C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538847, XrefRangeEnd = 538863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionPromptRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000FF87 File Offset: 0x0000E187
		public SelectionPromptRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00082A9C File Offset: 0x00080C9C
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000FF90 File Offset: 0x0000E190
		public unsafe float ANIMATION_DURATION
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_ANIMATION_DURATION);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_ANIMATION_DURATION)) = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00082AC4 File Offset: 0x00080CC4
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000FFAB File Offset: 0x0000E1AB
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00082AF4 File Offset: 0x00080CF4
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000FFCA File Offset: 0x0000E1CA
		public unsafe TMP_Text promptText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_promptText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_promptText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00082B24 File Offset: 0x00080D24
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0000FFE9 File Offset: 0x0000E1E9
		public unsafe string selectionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_selectionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_selectionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00082B4C File Offset: 0x00080D4C
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00010008 File Offset: 0x0000E208
		public unsafe Selection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00082B7C File Offset: 0x00080D7C
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00010027 File Offset: 0x0000E227
		public unsafe int showHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_showHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_showHash)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00082BA4 File Offset: 0x00080DA4
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00010042 File Offset: 0x0000E242
		public unsafe bool runningTextSequentially
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_runningTextSequentially);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_runningTextSequentially)) = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00082BCC File Offset: 0x00080DCC
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0001005D File Offset: 0x0000E25D
		public unsafe List<string> promptTexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_promptTexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_promptTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00082BFC File Offset: 0x00080DFC
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0001007C File Offset: 0x0000E27C
		public unsafe bool showOpponentActivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_showOpponentActivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_showOpponentActivity)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00082C24 File Offset: 0x00080E24
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x00010097 File Offset: 0x0000E297
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00082C54 File Offset: 0x00080E54
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x000100B6 File Offset: 0x0000E2B6
		public unsafe ILocalizationSubstitutor locSubstitutor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_locSubstitutor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILocalizationSubstitutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer.NativeFieldInfoPtr_locSubstitutor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_ANIMATION_DURATION;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_promptText;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_selectionString;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_showHash;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_runningTextSequentially;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_promptTexts;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeFieldInfoPtr_showOpponentActivity;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_locSubstitutor;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_setPromptText_Protected_Void_LocalizableText_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTextSequentially_Public_IEnumerator_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_ResetSelectionPromptText_Public_Virtual_New_Void_ISelectionNode_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000479 RID: 1145
		[ObfuscatedName("boardgames.match.behaviours.SelectionPromptRenderer+<DisplayTextSequentially>d__15")]
		public sealed class _DisplayTextSequentially_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06003623 RID: 13859 RVA: 0x000CA2F8 File Offset: 0x000C84F8
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayTextSequentially_d__15()
			{
				Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionPromptRenderer>.NativeClassPtr, "<DisplayTextSequentially>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, "<>1__state");
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, "<>2__current");
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, "<>4__this");
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668275);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668276);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668277);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668278);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668279);
				SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr, 100668280);
			}

			// Token: 0x06003624 RID: 13860 RVA: 0x000CA3D8 File Offset: 0x000C85D8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisplayTextSequentially_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionPromptRenderer._DisplayTextSequentially_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003625 RID: 13861 RVA: 0x000CA420 File Offset: 0x000C8620
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003626 RID: 13862 RVA: 0x000CA454 File Offset: 0x000C8654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538743, XrefRangeEnd = 538764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06003627 RID: 13863 RVA: 0x000CA490 File Offset: 0x000C8690
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003628 RID: 13864 RVA: 0x000CA4D0 File Offset: 0x000C86D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538764, XrefRangeEnd = 538769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06003629 RID: 13865 RVA: 0x000CA504 File Offset: 0x000C8704
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600362A RID: 13866 RVA: 0x0001BE4D File Offset: 0x0001A04D
			public _DisplayTextSequentially_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE3 RID: 4067
			// (get) Token: 0x0600362B RID: 13867 RVA: 0x000CA544 File Offset: 0x000C8744
			// (set) Token: 0x0600362C RID: 13868 RVA: 0x0001BE56 File Offset: 0x0001A056
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FE4 RID: 4068
			// (get) Token: 0x0600362D RID: 13869 RVA: 0x000CA56C File Offset: 0x000C876C
			// (set) Token: 0x0600362E RID: 13870 RVA: 0x0001BE71 File Offset: 0x0001A071
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE5 RID: 4069
			// (get) Token: 0x0600362F RID: 13871 RVA: 0x000CA59C File Offset: 0x000C879C
			// (set) Token: 0x06003630 RID: 13872 RVA: 0x0001BE90 File Offset: 0x0001A090
			public unsafe SelectionPromptRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionPromptRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionPromptRenderer._DisplayTextSequentially_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002151 RID: 8529
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002152 RID: 8530
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002153 RID: 8531
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002154 RID: 8532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002155 RID: 8533
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002156 RID: 8534
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002157 RID: 8535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002158 RID: 8536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002159 RID: 8537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
