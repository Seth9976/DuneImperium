using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BE RID: 446
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x06001D13 RID: 7443 RVA: 0x000094F0 File Offset: 0x000076F0
		// Note: this type is marked as 'beforefieldinit'.
		static Mutex()
		{
			Il2CppClassPointerStore<Mutex>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Mutex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutex>.NativeClassPtr);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00009515 File Offset: 0x00007715
		public Mutex(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
