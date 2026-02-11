using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.tutorials
{
	// Token: 0x0200010F RID: 271
	public class ITutorialPrompter : Il2CppObjectBase
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x00008A99 File Offset: 0x00006C99
		// Note: this type is marked as 'beforefieldinit'.
		static ITutorialPrompter()
		{
			Il2CppClassPointerStore<ITutorialPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.tutorials", "ITutorialPrompter");
			ITutorialPrompter.NativeMethodInfoPtr_GetPersistentPrompts_Public_Abstract_Virtual_New_IEnumerable_1_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITutorialPrompter>.NativeClassPtr, 100665329);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003C5D8 File Offset: 0x0003A7D8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IPrompt> GetPersistentPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITutorialPrompter.NativeMethodInfoPtr_GetPersistentPrompts_Public_Abstract_Virtual_New_IEnumerable_1_IPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IPrompt>>(intPtr3) : null;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public ITutorialPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentPrompts_Public_Abstract_Virtual_New_IEnumerable_1_IPrompt_0;
	}
}
