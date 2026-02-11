using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x020003A0 RID: 928
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		// Token: 0x06003897 RID: 14487 RVA: 0x00014BBB File Offset: 0x00012DBB
		// Note: this type is marked as 'beforefieldinit'.
		static FirstChanceExceptionEventArgs()
		{
			Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "FirstChanceExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr);
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00014BE0 File Offset: 0x00012DE0
		public FirstChanceExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
