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
	// Token: 0x020001D4 RID: 468
	public class LoginPromptBehaviour : PromptBehaviour<LoginPrompt>
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x00062D40 File Offset: 0x00060F40
		// Note: this type is marked as 'beforefieldinit'.
		static LoginPromptBehaviour()
		{
			Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "LoginPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr);
			LoginPromptBehaviour.NativeFieldInfoPtr_emailField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, "emailField");
			LoginPromptBehaviour.NativeFieldInfoPtr_passwordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, "passwordField");
			LoginPromptBehaviour.NativeFieldInfoPtr_loginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, "loginButton");
			LoginPromptBehaviour.NativeFieldInfoPtr_badEmailIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, "badEmailIcon");
			LoginPromptBehaviour.NativeFieldInfoPtr_errorField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, "errorField");
			LoginPromptBehaviour.NativeMethodInfoPtr_get_IsLoginValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666447);
			LoginPromptBehaviour.NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666448);
			LoginPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666449);
			LoginPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666450);
			LoginPromptBehaviour.NativeMethodInfoPtr_Event_ForgotPassword_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666451);
			LoginPromptBehaviour.NativeMethodInfoPtr_Event_NewAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666452);
			LoginPromptBehaviour.NativeMethodInfoPtr_Event_Login_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666453);
			LoginPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666454);
			LoginPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr, 100666455);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00062E88 File Offset: 0x00061088
		public unsafe bool IsLoginValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522374, XrefRangeEnd = 522375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_get_IsLoginValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00062EC4 File Offset: 0x000610C4
		public unsafe bool IsEmailValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522375, XrefRangeEnd = 522381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00062F00 File Offset: 0x00061100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522381, XrefRangeEnd = 522407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoginPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00062F3C File Offset: 0x0006113C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522431, RefRangeEnd = 522432, XrefRangeStart = 522407, XrefRangeEnd = 522431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate_Fields(string _ = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00062F80 File Offset: 0x00061180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522432, XrefRangeEnd = 522439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ForgotPassword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_Event_ForgotPassword_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00062FB4 File Offset: 0x000611B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522439, XrefRangeEnd = 522446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_NewAccount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_Event_NewAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00062FE8 File Offset: 0x000611E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522446, XrefRangeEnd = 522454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Login()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_Event_Login_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0006301C File Offset: 0x0006121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522454, XrefRangeEnd = 522461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00063050 File Offset: 0x00061250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522461, XrefRangeEnd = 522464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
		public LoginPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x0006308C File Offset: 0x0006128C
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		public unsafe TMP_InputField emailField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_emailField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_emailField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000630BC File Offset: 0x000612BC
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000C0DB File Offset: 0x0000A2DB
		public unsafe TMP_InputField passwordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_passwordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_passwordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000630EC File Offset: 0x000612EC
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000C0FA File Offset: 0x0000A2FA
		public unsafe Button loginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_loginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_loginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0006311C File Offset: 0x0006131C
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000C119 File Offset: 0x0000A319
		public unsafe GameObject badEmailIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_badEmailIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_badEmailIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0006314C File Offset: 0x0006134C
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000C138 File Offset: 0x0000A338
		public unsafe TMP_Text errorField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_errorField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPromptBehaviour.NativeFieldInfoPtr_errorField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr_emailField;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeFieldInfoPtr_passwordField;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr_loginButton;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr_badEmailIcon;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr_errorField;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoginValid_Private_get_Boolean_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmailValid_Private_get_Boolean_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_Event_ForgotPassword_Public_Void_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_Event_NewAccount_Public_Void_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_Event_Login_Public_Void_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
