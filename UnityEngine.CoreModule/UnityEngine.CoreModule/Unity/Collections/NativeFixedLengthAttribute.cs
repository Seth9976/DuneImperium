using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000036 RID: 54
	public sealed class NativeFixedLengthAttribute : Attribute
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00003076 File Offset: 0x00001276
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFixedLengthAttribute()
		{
			Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeFixedLengthAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000309B File Offset: 0x0000129B
		public NativeFixedLengthAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
