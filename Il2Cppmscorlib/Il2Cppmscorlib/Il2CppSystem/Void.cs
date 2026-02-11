using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010E RID: 270
	[StructLayout(2)]
	public struct Void
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x00006039 File Offset: 0x00004239
		// Note: this type is marked as 'beforefieldinit'.
		static Void()
		{
			Il2CppClassPointerStore<Void>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Void");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Void>.NativeClassPtr);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0000605E File Offset: 0x0000425E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Void>.NativeClassPtr, ref this));
		}
	}
}
