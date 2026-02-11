using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000016 RID: 22
	public class DismissablePrompt : BasePrompt
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00006D8C File Offset: 0x00004F8C
		// Note: this type is marked as 'beforefieldinit'.
		static DismissablePrompt()
		{
			Il2CppClassPointerStore<DismissablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "DismissablePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismissablePrompt>.NativeClassPtr);
			DismissablePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissablePrompt>.NativeClassPtr, 100663386);
			DismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissablePrompt>.NativeClassPtr, 100663387);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissablePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006E18 File Offset: 0x00005018
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520201, XrefRangeEnd = 520229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DismissablePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DismissablePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000028C9 File Offset: 0x00000AC9
		public DismissablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
