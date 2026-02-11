using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.client
{
	// Token: 0x020001ED RID: 493
	public class IBlockingApplicationQuitHandler : Il2CppObjectBase
	{
		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000B895 File Offset: 0x00009A95
		// Note: this type is marked as 'beforefieldinit'.
		static IBlockingApplicationQuitHandler()
		{
			Il2CppClassPointerStore<IBlockingApplicationQuitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.client", "IBlockingApplicationQuitHandler");
			IBlockingApplicationQuitHandler.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlockingApplicationQuitHandler>.NativeClassPtr, 100667576);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0007E8F8 File Offset: 0x0007CAF8
		[CallerCount(0)]
		public unsafe virtual Command HandleBlockingApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBlockingApplicationQuitHandler.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		public IBlockingApplicationQuitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Abstract_Virtual_New_Command_0;
	}
}
