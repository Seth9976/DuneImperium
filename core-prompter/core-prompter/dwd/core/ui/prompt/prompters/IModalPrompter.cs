using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.prompt.prompters
{
	// Token: 0x0200000C RID: 12
	public class IModalPrompter : Il2CppObjectBase
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000578C File Offset: 0x0000398C
		// Note: this type is marked as 'beforefieldinit'.
		static IModalPrompter()
		{
			Il2CppClassPointerStore<IModalPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompters", "IModalPrompter");
			IModalPrompter.NativeMethodInfoPtr_get_IsPrompting_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModalPrompter>.NativeClassPtr, 100663358);
			IModalPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModalPrompter>.NativeClassPtr, 100663359);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000057DC File Offset: 0x000039DC
		public unsafe virtual bool IsPrompting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModalPrompter.NativeMethodInfoPtr_get_IsPrompting_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005824 File Offset: 0x00003A24
		public unsafe virtual IPrompt CurrentPrompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModalPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr3) : null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000023A3 File Offset: 0x000005A3
		public IModalPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrompting_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0;
	}
}
