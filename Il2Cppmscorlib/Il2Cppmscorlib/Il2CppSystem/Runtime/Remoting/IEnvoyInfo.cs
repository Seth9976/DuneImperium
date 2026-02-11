using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000294 RID: 660
	public class IEnvoyInfo : Il2CppObjectBase
	{
		// Token: 0x06002A34 RID: 10804 RVA: 0x0000E046 File Offset: 0x0000C246
		// Note: this type is marked as 'beforefieldinit'.
		static IEnvoyInfo()
		{
			Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IEnvoyInfo");
			IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnvoyInfo>.NativeClassPtr, 100670174);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000E0AE4 File Offset: 0x000DECE4
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0000E075 File Offset: 0x0000C275
		public IEnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Abstract_Virtual_New_get_IMessageSink_0;
	}
}
