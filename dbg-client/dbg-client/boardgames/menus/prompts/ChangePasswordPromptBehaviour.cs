using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C7 RID: 455
	public class ChangePasswordPromptBehaviour : PromptBehaviour<ChangePasswordPrompt>
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x0005FF3C File Offset: 0x0005E13C
		// Note: this type is marked as 'beforefieldinit'.
		static ChangePasswordPromptBehaviour()
		{
			Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ChangePasswordPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr);
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_oldPasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "oldPasswordField");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "passwordField");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_retypePasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "retypePasswordField");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidOldPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "invalidOldPasswordIcon");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "invalidPasswordIcon");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "mismatchedPasswordIcon");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_submitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "submitButton");
			ChangePasswordPromptBehaviour.NativeFieldInfoPtr_errorField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "errorField");
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr_isPasswordValid_Private_Static_Boolean_TMP_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666311);
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr_get_SubmitValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666312);
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666313);
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666314);
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666315);
			ChangePasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, 100666316);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00060084 File Offset: 0x0005E284
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 520768, RefRangeEnd = 520772, XrefRangeStart = 520750, XrefRangeEnd = 520768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isPasswordValid(TMP_InputField inputField)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.NativeMethodInfoPtr_isPasswordValid_Private_Static_Boolean_TMP_InputField_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000600C8 File Offset: 0x0005E2C8
		public unsafe bool SubmitValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 520786, RefRangeEnd = 520789, XrefRangeStart = 520772, XrefRangeEnd = 520786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.NativeMethodInfoPtr_get_SubmitValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00060104 File Offset: 0x0005E304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520789, XrefRangeEnd = 520812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangePasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00060140 File Offset: 0x0005E340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520848, RefRangeEnd = 520849, XrefRangeStart = 520812, XrefRangeEnd = 520848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate_Fields(string _ = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00060184 File Offset: 0x0005E384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520849, XrefRangeEnd = 520854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000601B8 File Offset: 0x0005E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520854, XrefRangeEnd = 520857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangePasswordPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0000BA49 File Offset: 0x00009C49
		public ChangePasswordPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x000601F4 File Offset: 0x0005E3F4
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0000BA52 File Offset: 0x00009C52
		public unsafe TMP_InputField oldPasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_oldPasswordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_oldPasswordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00060224 File Offset: 0x0005E424
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0000BA71 File Offset: 0x00009C71
		public unsafe TMP_InputField passwordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00060254 File Offset: 0x0005E454
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0000BA90 File Offset: 0x00009C90
		public unsafe TMP_InputField retypePasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_retypePasswordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_retypePasswordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00060284 File Offset: 0x0005E484
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0000BAAF File Offset: 0x00009CAF
		public unsafe GameObject invalidOldPasswordIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidOldPasswordIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidOldPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x000602B4 File Offset: 0x0005E4B4
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x0000BACE File Offset: 0x00009CCE
		public unsafe GameObject invalidPasswordIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_invalidPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x000602E4 File Offset: 0x0005E4E4
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x0000BAED File Offset: 0x00009CED
		public unsafe GameObject mismatchedPasswordIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_mismatchedPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00060314 File Offset: 0x0005E514
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0000BB0C File Offset: 0x00009D0C
		public unsafe Button submitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_submitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_submitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x00060344 File Offset: 0x0005E544
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000BB2B File Offset: 0x00009D2B
		public unsafe TMP_Text errorField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_errorField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.NativeFieldInfoPtr_errorField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_oldPasswordField;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_passwordField;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_retypePasswordField;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_invalidOldPasswordIcon;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_invalidPasswordIcon;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_mismatchedPasswordIcon;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_submitButton;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_errorField;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_isPasswordValid_Private_Static_Boolean_TMP_InputField_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitValid_Private_get_Boolean_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Fields_Private_Void_String_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_Event_Submit_Public_Void_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B3 RID: 947
		[ObfuscatedName("boardgames.menus.prompts.ChangePasswordPromptBehaviour+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C48 RID: 11336 RVA: 0x000ACD84 File Offset: 0x000AAF84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangePasswordPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr);
				ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, "inputField");
				ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100666317);
				ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__isPasswordValid_b__0_Internal_Boolean_Regex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100666318);
			}

			// Token: 0x06002C49 RID: 11337 RVA: 0x000ACDEC File Offset: 0x000AAFEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangePasswordPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C4A RID: 11338 RVA: 0x000ACE28 File Offset: 0x000AB028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520748, XrefRangeEnd = 520750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _isPasswordValid_b__0(Regex regex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__isPasswordValid_b__0_Internal_Boolean_Regex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C4B RID: 11339 RVA: 0x00016EA6 File Offset: 0x000150A6
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06002C4C RID: 11340 RVA: 0x000ACE78 File Offset: 0x000AB078
			// (set) Token: 0x06002C4D RID: 11341 RVA: 0x00016EAF File Offset: 0x000150AF
			public unsafe TMP_InputField inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B89 RID: 7049
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04001B8A RID: 7050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B8B RID: 7051
			private static readonly IntPtr NativeMethodInfoPtr__isPasswordValid_b__0_Internal_Boolean_Regex_0;
		}
	}
}
