using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.Metadata
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct __Il2CppFullySharedGenericType
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002116 File Offset: 0x00000316
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppFullySharedGenericType()
		{
			Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "Unity.IL2CPP.Metadata", "__Il2CppFullySharedGenericType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000213B File Offset: 0x0000033B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr, ref this));
		}
	}
}
