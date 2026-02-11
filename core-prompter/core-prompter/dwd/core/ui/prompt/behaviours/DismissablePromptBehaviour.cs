using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000037 RID: 55
	public sealed class DismissablePromptBehaviour : PromptBehaviour<IDismissablePrompt>
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0000A7A8 File Offset: 0x000089A8
		// Note: this type is marked as 'beforefieldinit'.
		static DismissablePromptBehaviour()
		{
			Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "DismissablePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr);
			DismissablePromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr, 100663529);
			DismissablePromptBehaviour.NativeMethodInfoPtr_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr, 100663530);
			DismissablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr, 100663531);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A814 File Offset: 0x00008A14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1214384, RefRangeEnd = 1214389, XrefRangeStart = 1214377, XrefRangeEnd = 1214384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissablePromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A848 File Offset: 0x00008A48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1214384, RefRangeEnd = 1214389, XrefRangeStart = 1214384, XrefRangeEnd = 1214389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissablePromptBehaviour.NativeMethodInfoPtr_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000A87C File Offset: 0x00008A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214389, XrefRangeEnd = 1214392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DismissablePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DismissablePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissablePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000030C7 File Offset: 0x000012C7
		public DismissablePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
