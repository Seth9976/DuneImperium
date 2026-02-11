using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000026 RID: 38
	public class IReturnablePrompt : Il2CppObjectBase
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00002B3D File Offset: 0x00000D3D
		// Note: this type is marked as 'beforefieldinit'.
		static IReturnablePrompt()
		{
			Il2CppClassPointerStore<IReturnablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IReturnablePrompt");
			IReturnablePrompt.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReturnablePrompt>.NativeClassPtr, 100663424);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000081F0 File Offset: 0x000063F0
		[CallerCount(0)]
		public unsafe virtual IReturnablePrompt Return()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReturnablePrompt.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_IReturnablePrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReturnablePrompt>(intPtr3) : null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002B6C File Offset: 0x00000D6C
		public IReturnablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_IReturnablePrompt_0;
	}
}
