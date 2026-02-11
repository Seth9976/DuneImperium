using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D0 RID: 464
	public class ForgotPasswordPromptBehaviour : PromptBehaviour<ForgotPasswordPrompt>
	{
		// Token: 0x06001537 RID: 5431 RVA: 0x00062504 File Offset: 0x00060704
		// Note: this type is marked as 'beforefieldinit'.
		static ForgotPasswordPromptBehaviour()
		{
			Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ForgotPasswordPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr);
			ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_emailField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, "emailField");
			ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_badEmailIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, "badEmailIcon");
			ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_submitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, "submitButton");
			ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_errorField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, "errorField");
			ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, 100666418);
			ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, 100666419);
			ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_Validate_Email_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, 100666420);
			ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_Event_SendReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, 100666421);
			ForgotPasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr, 100666422);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000625E8 File Offset: 0x000607E8
		public unsafe bool IsEmailValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522146, XrefRangeEnd = 522151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00062624 File Offset: 0x00060824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522151, XrefRangeEnd = 522166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00062660 File Offset: 0x00060860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522189, RefRangeEnd = 522190, XrefRangeStart = 522166, XrefRangeEnd = 522189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate_Email(string _ = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_Validate_Email_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000626A4 File Offset: 0x000608A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522190, XrefRangeEnd = 522194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPromptBehaviour.NativeMethodInfoPtr_Event_SendReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000626D8 File Offset: 0x000608D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522194, XrefRangeEnd = 522197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForgotPasswordPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgotPasswordPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		public ForgotPasswordPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x00062714 File Offset: 0x00060914
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000BFB1 File Offset: 0x0000A1B1
		public unsafe TMP_InputField emailField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_emailField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_emailField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00062744 File Offset: 0x00060944
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		public unsafe GameObject badEmailIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_badEmailIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_badEmailIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00062774 File Offset: 0x00060974
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000BFEF File Offset: 0x0000A1EF
		public unsafe Selectable submitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_submitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_submitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000627A4 File Offset: 0x000609A4
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000C00E File Offset: 0x0000A20E
		public unsafe TMP_Text errorField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_errorField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPromptBehaviour.NativeFieldInfoPtr_errorField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_emailField;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_badEmailIcon;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_submitButton;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_errorField;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Email_Private_Void_String_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendReset_Public_Void_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
