using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.Metadata
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct __Il2CppFullySharedGenericStructType
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000214D File Offset: 0x0000034D
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppFullySharedGenericStructType()
		{
			Il2CppClassPointerStore<__Il2CppFullySharedGenericStructType>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "Unity.IL2CPP.Metadata", "__Il2CppFullySharedGenericStructType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppFullySharedGenericStructType>.NativeClassPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002172 File Offset: 0x00000372
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__Il2CppFullySharedGenericStructType>.NativeClassPtr, ref this));
		}
	}
}
