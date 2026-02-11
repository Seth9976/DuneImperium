using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004C RID: 76
	public sealed class NativeSetThreadIndexAttribute : Attribute
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000351C File Offset: 0x0000171C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSetThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSetThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003541 File Offset: 0x00001741
		public NativeSetThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
