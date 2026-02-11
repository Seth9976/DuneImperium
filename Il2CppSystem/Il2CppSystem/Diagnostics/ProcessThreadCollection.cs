using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A1 RID: 161
	[DefaultMember("Item")]
	public class ProcessThreadCollection : ReadOnlyCollectionBase
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x000067E0 File Offset: 0x000049E0
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessThreadCollection()
		{
			Il2CppClassPointerStore<ProcessThreadCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "ProcessThreadCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessThreadCollection>.NativeClassPtr);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00006805 File Offset: 0x00004A05
		public ProcessThreadCollection(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
