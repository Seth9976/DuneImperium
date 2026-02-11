using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CF RID: 463
	public class EulaPromptBehaviour : PromptBehaviour<EulaPrompt>
	{
		// Token: 0x06001528 RID: 5416 RVA: 0x00062240 File Offset: 0x00060440
		// Note: this type is marked as 'beforefieldinit'.
		static EulaPromptBehaviour()
		{
			Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "EulaPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr);
			EulaPromptBehaviour.NativeFieldInfoPtr_proceedWithRequirementsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, "proceedWithRequirementsButton");
			EulaPromptBehaviour.NativeFieldInfoPtr_acceptTerms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, "acceptTerms");
			EulaPromptBehaviour.NativeFieldInfoPtr_requestMarketing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, "requestMarketing");
			EulaPromptBehaviour.NativeFieldInfoPtr_checkboxesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, "checkboxesContainer");
			EulaPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, 100666413);
			EulaPromptBehaviour.NativeMethodInfoPtr_Event_AcceptTerms_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, 100666414);
			EulaPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, 100666415);
			EulaPromptBehaviour.NativeMethodInfoPtr_ShowLoginRequirements_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, 100666416);
			EulaPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr, 100666417);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00062324 File Offset: 0x00060524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522090, XrefRangeEnd = 522095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EulaPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00062360 File Offset: 0x00060560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522095, XrefRangeEnd = 522113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AcceptTerms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPromptBehaviour.NativeMethodInfoPtr_Event_AcceptTerms_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00062394 File Offset: 0x00060594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522113, XrefRangeEnd = 522119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000623C8 File Offset: 0x000605C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522142, RefRangeEnd = 522143, XrefRangeStart = 522119, XrefRangeEnd = 522142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowLoginRequirements(bool show)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref show;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPromptBehaviour.NativeMethodInfoPtr_ShowLoginRequirements_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00062408 File Offset: 0x00060608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522143, XrefRangeEnd = 522146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EulaPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EulaPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000BF23 File Offset: 0x0000A123
		public EulaPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00062444 File Offset: 0x00060644
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public unsafe Button proceedWithRequirementsButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_proceedWithRequirementsButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_proceedWithRequirementsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x00062474 File Offset: 0x00060674
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000BF4B File Offset: 0x0000A14B
		public unsafe Toggle acceptTerms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_acceptTerms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_acceptTerms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x000624A4 File Offset: 0x000606A4
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x0000BF6A File Offset: 0x0000A16A
		public unsafe Toggle requestMarketing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_requestMarketing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_requestMarketing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x000624D4 File Offset: 0x000606D4
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x0000BF89 File Offset: 0x0000A189
		public unsafe GameObject checkboxesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_checkboxesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPromptBehaviour.NativeFieldInfoPtr_checkboxesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_proceedWithRequirementsButton;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_acceptTerms;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_requestMarketing;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_checkboxesContainer;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_Event_AcceptTerms_Public_Void_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_ShowLoginRequirements_Private_Void_Boolean_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
