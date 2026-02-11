using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace lib.canis.input
{
	// Token: 0x0200002C RID: 44
	public class SteamdeckKeyboardInputReader : MonoBehaviour
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00022F50 File Offset: 0x00021150
		// Note: this type is marked as 'beforefieldinit'.
		static SteamdeckKeyboardInputReader()
		{
			Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "SteamdeckKeyboardInputReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr);
			SteamdeckKeyboardInputReader.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, "inputField");
			SteamdeckKeyboardInputReader.NativeFieldInfoPtr_OnDismiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, "OnDismiss");
			SteamdeckKeyboardInputReader.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, "parent");
			SteamdeckKeyboardInputReader.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, 100663587);
			SteamdeckKeyboardInputReader.NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, 100663588);
			SteamdeckKeyboardInputReader.NativeMethodInfoPtr_dismissGamepadTextInput_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, 100663589);
			SteamdeckKeyboardInputReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr, 100663590);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002300C File Offset: 0x0002120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497755, XrefRangeEnd = 497759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamdeckKeyboardInputReader.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00023040 File Offset: 0x00021240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497759, XrefRangeEnd = 497831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectInputField(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamdeckKeyboardInputReader.NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00023084 File Offset: 0x00021284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497831, XrefRangeEnd = 497848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dismissGamepadTextInput(bool submitted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref submitted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamdeckKeyboardInputReader.NativeMethodInfoPtr_dismissGamepadTextInput_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000230C4 File Offset: 0x000212C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497848, XrefRangeEnd = 497854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamdeckKeyboardInputReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamdeckKeyboardInputReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamdeckKeyboardInputReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public SteamdeckKeyboardInputReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00023100 File Offset: 0x00021300
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002ADE File Offset: 0x00000CDE
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00023130 File Offset: 0x00021330
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002AFD File Offset: 0x00000CFD
		public unsafe UnityEvent OnDismiss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_OnDismiss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_OnDismiss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00023160 File Offset: 0x00021360
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002B1C File Offset: 0x00000D1C
		public unsafe PromptBehaviour parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamdeckKeyboardInputReader.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_OnDismiss;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectInputField_Public_Void_String_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_dismissGamepadTextInput_Private_Void_Boolean_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
