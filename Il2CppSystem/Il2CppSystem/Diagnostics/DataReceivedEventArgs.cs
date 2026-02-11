using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A3 RID: 163
	public class DataReceivedEventArgs : EventArgs
	{
		// Token: 0x06000C28 RID: 3112 RVA: 0x00006850 File Offset: 0x00004A50
		// Note: this type is marked as 'beforefieldinit'.
		static DataReceivedEventArgs()
		{
			Il2CppClassPointerStore<DataReceivedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "DataReceivedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataReceivedEventArgs>.NativeClassPtr);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00006875 File Offset: 0x00004A75
		public DataReceivedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
