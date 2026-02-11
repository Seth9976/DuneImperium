using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.UI;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public sealed class TextPromptBehaviour : PromptBehaviour<TextPrompt>
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000BD3C File Offset: 0x00009F3C
		// Note: this type is marked as 'beforefieldinit'.
		static TextPromptBehaviour()
		{
			Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "TextPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr);
			TextPromptBehaviour.NativeFieldInfoPtr_textInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, "textInputField");
			TextPromptBehaviour.NativeFieldInfoPtr_onEnteredTextValidityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, "onEnteredTextValidityChange");
			TextPromptBehaviour.NativeMethodInfoPtr_get_OnEnteredTextValidityChange_Public_get_UnityEventForTextValidityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663597);
			TextPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663598);
			TextPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663599);
			TextPromptBehaviour.NativeMethodInfoPtr_Event_AttemptResolveWithEnteredText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663600);
			TextPromptBehaviour.NativeMethodInfoPtr_onCurrentEnteredTextChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663601);
			TextPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, 100663602);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public unsafe TextPromptBehaviour.UnityEventForTextValidityState OnEnteredTextValidityChange
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr_get_OnEnteredTextValidityChange_Public_get_UnityEventForTextValidityState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextPromptBehaviour.UnityEventForTextValidityState>(intPtr3) : null;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000BE4C File Offset: 0x0000A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214895, XrefRangeEnd = 1214930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000BE80 File Offset: 0x0000A080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214930, XrefRangeEnd = 1214946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214946, XrefRangeEnd = 1214958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AttemptResolveWithEnteredText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr_Event_AttemptResolveWithEnteredText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214958, XrefRangeEnd = 1214965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onCurrentEnteredTextChanged(string currentText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(currentText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr_onCurrentEnteredTextChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000BF2C File Offset: 0x0000A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214965, XrefRangeEnd = 1214975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000033BA File Offset: 0x000015BA
		public TextPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000BF68 File Offset: 0x0000A168
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000033C3 File Offset: 0x000015C3
		public unsafe InputField textInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPromptBehaviour.NativeFieldInfoPtr_textInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPromptBehaviour.NativeFieldInfoPtr_textInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000BF98 File Offset: 0x0000A198
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000033E2 File Offset: 0x000015E2
		public unsafe TextPromptBehaviour.UnityEventForTextValidityState onEnteredTextValidityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPromptBehaviour.NativeFieldInfoPtr_onEnteredTextValidityChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextPromptBehaviour.UnityEventForTextValidityState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPromptBehaviour.NativeFieldInfoPtr_onEnteredTextValidityChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_textInputField;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_onEnteredTextValidityChange;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_OnEnteredTextValidityChange_Public_get_UnityEventForTextValidityState_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Event_AttemptResolveWithEnteredText_Public_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_onCurrentEnteredTextChanged_Private_Void_String_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200005D RID: 93
		[Serializable]
		public class UnityEventForTextValidityState : UnityEvent<bool>
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x00003DCA File Offset: 0x00001FCA
			// Note: this type is marked as 'beforefieldinit'.
			static UnityEventForTextValidityState()
			{
				Il2CppClassPointerStore<TextPromptBehaviour.UnityEventForTextValidityState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextPromptBehaviour>.NativeClassPtr, "UnityEventForTextValidityState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextPromptBehaviour.UnityEventForTextValidityState>.NativeClassPtr);
				TextPromptBehaviour.UnityEventForTextValidityState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPromptBehaviour.UnityEventForTextValidityState>.NativeClassPtr, 100663603);
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000FA80 File Offset: 0x0000DC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214892, XrefRangeEnd = 1214895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnityEventForTextValidityState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextPromptBehaviour.UnityEventForTextValidityState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPromptBehaviour.UnityEventForTextValidityState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00003DFE File Offset: 0x00001FFE
			public UnityEventForTextValidityState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
