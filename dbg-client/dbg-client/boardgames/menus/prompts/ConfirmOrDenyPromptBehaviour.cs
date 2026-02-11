using System;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CB RID: 459
	public class ConfirmOrDenyPromptBehaviour : PromptBehaviour<ConfirmOrDenyPrompt>
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x00061340 File Offset: 0x0005F540
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOrDenyPromptBehaviour()
		{
			Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfirmOrDenyPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr);
			ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_confirmText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr, "confirmText");
			ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_cancelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr, "cancelText");
			ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100666370);
			ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100666371);
			ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100666372);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000613D4 File Offset: 0x0005F5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521521, XrefRangeEnd = 521540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00061410 File Offset: 0x0005F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521540, XrefRangeEnd = 521547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resolve(bool choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00061450 File Offset: 0x0005F650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521547, XrefRangeEnd = 521550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrDenyPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrDenyPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0000BC5D File Offset: 0x00009E5D
		public ConfirmOrDenyPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0006148C File Offset: 0x0005F68C
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000BC66 File Offset: 0x00009E66
		public unsafe TMP_Text confirmText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_confirmText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_confirmText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000614BC File Offset: 0x0005F6BC
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000BC85 File Offset: 0x00009E85
		public unsafe TMP_Text cancelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_cancelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_cancelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_confirmText;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_cancelText;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resolve_Public_Void_Boolean_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
