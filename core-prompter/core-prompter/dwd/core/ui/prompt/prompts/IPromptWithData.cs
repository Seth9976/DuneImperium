using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000025 RID: 37
	public class IPromptWithData : Il2CppObjectBase
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00002B05 File Offset: 0x00000D05
		// Note: this type is marked as 'beforefieldinit'.
		static IPromptWithData()
		{
			Il2CppClassPointerStore<IPromptWithData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IPromptWithData");
			IPromptWithData.NativeMethodInfoPtr_get_PromptData_Public_Abstract_Virtual_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPromptWithData>.NativeClassPtr, 100663423);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000081A4 File Offset: 0x000063A4
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPromptWithData.NativeMethodInfoPtr_get_PromptData_Public_Abstract_Virtual_New_get_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002B34 File Offset: 0x00000D34
		public IPromptWithData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Abstract_Virtual_New_get_DataComposition_0;
	}
}
