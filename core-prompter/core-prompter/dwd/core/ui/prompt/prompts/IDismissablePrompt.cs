using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000021 RID: 33
	public class IDismissablePrompt : Il2CppObjectBase
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002AB2 File Offset: 0x00000CB2
		// Note: this type is marked as 'beforefieldinit'.
		static IDismissablePrompt()
		{
			Il2CppClassPointerStore<IDismissablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IDismissablePrompt");
			IDismissablePrompt.NativeMethodInfoPtr_Dismiss_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDismissablePrompt>.NativeClassPtr, 100663417);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007E60 File Offset: 0x00006060
		[CallerCount(0)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDismissablePrompt.NativeMethodInfoPtr_Dismiss_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public IDismissablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Abstract_Virtual_New_Void_0;
	}
}
