using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.client
{
	// Token: 0x020001EC RID: 492
	public class IApplicationQuitHandler : Il2CppObjectBase
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0000B85D File Offset: 0x00009A5D
		// Note: this type is marked as 'beforefieldinit'.
		static IApplicationQuitHandler()
		{
			Il2CppClassPointerStore<IApplicationQuitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.client", "IApplicationQuitHandler");
			IApplicationQuitHandler.NativeMethodInfoPtr_HandleApplicationQuit_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IApplicationQuitHandler>.NativeClassPtr, 100667575);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0007E8BC File Offset: 0x0007CABC
		[CallerCount(0)]
		public unsafe virtual void HandleApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IApplicationQuitHandler.NativeMethodInfoPtr_HandleApplicationQuit_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0000B88C File Offset: 0x00009A8C
		public IApplicationQuitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_HandleApplicationQuit_Public_Abstract_Virtual_New_Void_0;
	}
}
