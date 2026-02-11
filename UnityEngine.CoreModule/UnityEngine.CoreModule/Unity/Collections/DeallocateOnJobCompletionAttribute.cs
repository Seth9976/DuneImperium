using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000035 RID: 53
	public sealed class DeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00003048 File Offset: 0x00001248
		// Note: this type is marked as 'beforefieldinit'.
		static DeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "DeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000306D File Offset: 0x0000126D
		public DeallocateOnJobCompletionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
