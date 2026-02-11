using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.commands
{
	// Token: 0x0200001F RID: 31
	public class IReceivesInterrupt : Il2CppObjectBase
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002762 File Offset: 0x00000962
		// Note: this type is marked as 'beforefieldinit'.
		static IReceivesInterrupt()
		{
			Il2CppClassPointerStore<IReceivesInterrupt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "IReceivesInterrupt");
			IReceivesInterrupt.NativeMethodInfoPtr_Interrupted_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReceivesInterrupt>.NativeClassPtr, 100663679);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000A210 File Offset: 0x00008410
		[CallerCount(0)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReceivesInterrupt.NativeMethodInfoPtr_Interrupted_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002791 File Offset: 0x00000991
		public IReceivesInterrupt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Abstract_Virtual_New_Void_0;
	}
}
