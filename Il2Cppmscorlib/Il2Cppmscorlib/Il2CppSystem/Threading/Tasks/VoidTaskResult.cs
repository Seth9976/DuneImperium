using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DA RID: 474
	[StructLayout(2)]
	public struct VoidTaskResult
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x0000A2B9 File Offset: 0x000084B9
		// Note: this type is marked as 'beforefieldinit'.
		static VoidTaskResult()
		{
			Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "VoidTaskResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0000A2DE File Offset: 0x000084DE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr, ref this));
		}
	}
}
