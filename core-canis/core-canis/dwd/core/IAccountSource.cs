using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core
{
	// Token: 0x02000083 RID: 131
	public class IAccountSource : Il2CppObjectBase
	{
		// Token: 0x060009D1 RID: 2513 RVA: 0x00005716 File Offset: 0x00003916
		// Note: this type is marked as 'beforefieldinit'.
		static IAccountSource()
		{
			Il2CppClassPointerStore<IAccountSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core", "IAccountSource");
			IAccountSource.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccountSource>.NativeClassPtr, 100664663);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00039150 File Offset: 0x00037350
		[CallerCount(0)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccountSource.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00005745 File Offset: 0x00003945
		public IAccountSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0;
	}
}
