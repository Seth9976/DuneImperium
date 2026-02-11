using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004D RID: 77
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000354A File Offset: 0x0000174A
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerNeedsThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerNeedsThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000356F File Offset: 0x0000176F
		public NativeContainerNeedsThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
