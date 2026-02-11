using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200001F RID: 31
	public class IPrefabPrompt : Il2CppObjectBase
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002A42 File Offset: 0x00000C42
		// Note: this type is marked as 'beforefieldinit'.
		static IPrefabPrompt()
		{
			Il2CppClassPointerStore<IPrefabPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IPrefabPrompt");
			IPrefabPrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrefabPrompt>.NativeClassPtr, 100663415);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00007DCC File Offset: 0x00005FCC
		public unsafe virtual IEnumerable<string> PrefabLookupTags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrefabPrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002A71 File Offset: 0x00000C71
		public IPrefabPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabLookupTags_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0;
	}
}
