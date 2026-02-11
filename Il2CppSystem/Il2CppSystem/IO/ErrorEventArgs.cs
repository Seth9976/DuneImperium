using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017E RID: 382
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x0000A1B2 File Offset: 0x000083B2
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorEventArgs()
		{
			Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "ErrorEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0000A1D7 File Offset: 0x000083D7
		public ErrorEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
