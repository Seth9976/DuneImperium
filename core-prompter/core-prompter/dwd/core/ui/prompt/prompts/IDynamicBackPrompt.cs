using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200001D RID: 29
	public class IDynamicBackPrompt : Il2CppObjectBase
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002A01 File Offset: 0x00000C01
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicBackPrompt()
		{
			Il2CppClassPointerStore<IDynamicBackPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IDynamicBackPrompt");
			IDynamicBackPrompt.NativeMethodInfoPtr_CanBack_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicBackPrompt>.NativeClassPtr, 100663412);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007CA0 File Offset: 0x00005EA0
		[CallerCount(0)]
		public unsafe virtual bool CanBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicBackPrompt.NativeMethodInfoPtr_CanBack_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002A30 File Offset: 0x00000C30
		public IDynamicBackPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_CanBack_Public_Abstract_Virtual_New_Boolean_0;
	}
}
