using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CE RID: 462
	public class CreateAccountPromptBehaviour : PromptBehaviour<CreateAccountPrompt>
	{
		// Token: 0x06001509 RID: 5385 RVA: 0x00061C84 File Offset: 0x0005FE84
		// Note: this type is marked as 'beforefieldinit'.
		static CreateAccountPromptBehaviour()
		{
			Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "CreateAccountPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr);
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_emailField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "emailField");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_screenNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "screenNameField");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_passwordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "passwordField");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_retypePasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "retypePasswordField");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_registerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "registerButton");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidEmailIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "invalidEmailIcon");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidScreenNameIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "invalidScreenNameIcon");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "invalidPasswordIcon");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "mismatchedPasswordIcon");
			CreateAccountPromptBehaviour.NativeFieldInfoPtr_errorField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, "errorField");
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666404);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isPasswordValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666405);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isScreenNameValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666406);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isRegisterValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666407);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666408);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666409);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr_Event_CreateAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666410);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666411);
			CreateAccountPromptBehaviour.NativeMethodInfoPtr__get_isPasswordValid_b__13_0_Private_Boolean_Regex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr, 100666412);
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00061E30 File Offset: 0x00060030
		public unsafe bool isEmailValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 521991, RefRangeEnd = 521993, XrefRangeStart = 521985, XrefRangeEnd = 521991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00061E6C File Offset: 0x0006006C
		public unsafe bool isPasswordValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 521997, RefRangeEnd = 521999, XrefRangeStart = 521993, XrefRangeEnd = 521997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isPasswordValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x00061EA8 File Offset: 0x000600A8
		public unsafe bool isScreenNameValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isScreenNameValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00061EE4 File Offset: 0x000600E4
		public unsafe bool isRegisterValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 522006, RefRangeEnd = 522008, XrefRangeStart = 521999, XrefRangeEnd = 522006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_get_isRegisterValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00061F20 File Offset: 0x00060120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522008, XrefRangeEnd = 522041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateAccountPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00061F5C File Offset: 0x0006015C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522077, RefRangeEnd = 522078, XrefRangeStart = 522041, XrefRangeEnd = 522077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate_Fields(string _ = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00061FA0 File Offset: 0x000601A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522078, XrefRangeEnd = 522085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_CreateAccount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr_Event_CreateAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00061FD4 File Offset: 0x000601D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522085, XrefRangeEnd = 522088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateAccountPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAccountPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00062010 File Offset: 0x00060210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522088, XrefRangeEnd = 522090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_isPasswordValid_b__13_0(Regex regex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAccountPromptBehaviour.NativeMethodInfoPtr__get_isPasswordValid_b__13_0_Private_Boolean_Regex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public CreateAccountPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x00062060 File Offset: 0x00060260
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0000BDED File Offset: 0x00009FED
		public unsafe TMP_InputField emailField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_emailField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_emailField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00062090 File Offset: 0x00060290
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public unsafe TMP_InputField screenNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_screenNameField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_screenNameField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x000620C0 File Offset: 0x000602C0
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x0000BE2B File Offset: 0x0000A02B
		public unsafe TMP_InputField passwordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_passwordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_passwordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x000620F0 File Offset: 0x000602F0
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0000BE4A File Offset: 0x0000A04A
		public unsafe TMP_InputField retypePasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_retypePasswordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_retypePasswordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00062120 File Offset: 0x00060320
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x0000BE69 File Offset: 0x0000A069
		public unsafe Button registerButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_registerButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_registerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00062150 File Offset: 0x00060350
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x0000BE88 File Offset: 0x0000A088
		public unsafe GameObject invalidEmailIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidEmailIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidEmailIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x00062180 File Offset: 0x00060380
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x0000BEA7 File Offset: 0x0000A0A7
		public unsafe GameObject invalidScreenNameIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidScreenNameIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidScreenNameIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000621B0 File Offset: 0x000603B0
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x0000BEC6 File Offset: 0x0000A0C6
		public unsafe GameObject invalidPasswordIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x000621E0 File Offset: 0x000603E0
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x0000BEE5 File Offset: 0x0000A0E5
		public unsafe GameObject mismatchedPasswordIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00062210 File Offset: 0x00060410
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x0000BF04 File Offset: 0x0000A104
		public unsafe TMP_Text errorField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_errorField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAccountPromptBehaviour.NativeFieldInfoPtr_errorField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr_emailField;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr_screenNameField;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_passwordField;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_retypePasswordField;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_registerButton;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr_invalidEmailIcon;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_invalidScreenNameIcon;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_invalidPasswordIcon;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_mismatchedPasswordIcon;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_errorField;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmailValid_Private_get_Boolean_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_isPasswordValid_Private_get_Boolean_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_isScreenNameValid_Private_get_Boolean_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_isRegisterValid_Private_get_Boolean_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_Event_CreateAccount_Public_Void_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr__get_isPasswordValid_b__13_0_Private_Boolean_Regex_0;
	}
}
