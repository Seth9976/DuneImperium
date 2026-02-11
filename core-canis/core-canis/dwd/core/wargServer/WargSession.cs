using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.wargServer
{
	// Token: 0x02000122 RID: 290
	public static class WargSession : Object
	{
		// Token: 0x0600103F RID: 4159 RVA: 0x000079D1 File Offset: 0x00005BD1
		// Note: this type is marked as 'beforefieldinit'.
		static WargSession()
		{
			Il2CppClassPointerStore<WargSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.wargServer", "WargSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WargSession>.NativeClassPtr);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000079F6 File Offset: 0x00005BF6
		public WargSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020002C9 RID: 713
		public enum DisconnectReasons
		{
			// Token: 0x04001715 RID: 5909
			UNKNOWN,
			// Token: 0x04001716 RID: 5910
			Error,
			// Token: 0x04001717 RID: 5911
			Logout,
			// Token: 0x04001718 RID: 5912
			DuplicateLogin,
			// Token: 0x04001719 RID: 5913
			Timeout,
			// Token: 0x0400171A RID: 5914
			DataError,
			// Token: 0x0400171B RID: 5915
			ReadNull
		}
	}
}
