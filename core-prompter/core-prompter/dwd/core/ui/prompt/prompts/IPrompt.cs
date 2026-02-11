using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000020 RID: 32
	public class IPrompt : Il2CppObjectBase
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00002A7A File Offset: 0x00000C7A
		// Note: this type is marked as 'beforefieldinit'.
		static IPrompt()
		{
			Il2CppClassPointerStore<IPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IPrompt");
			IPrompt.NativeMethodInfoPtr_get_Resolved_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrompt>.NativeClassPtr, 100663416);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00007E18 File Offset: 0x00006018
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrompt.NativeMethodInfoPtr_get_Resolved_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002AA9 File Offset: 0x00000CA9
		public IPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
