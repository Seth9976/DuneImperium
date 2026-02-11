using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002FB RID: 763
	public class IMessage : Il2CppObjectBase
	{
		// Token: 0x06002F14 RID: 12052 RVA: 0x00010046 File Offset: 0x0000E246
		// Note: this type is marked as 'beforefieldinit'.
		static IMessage()
		{
			Il2CppClassPointerStore<IMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMessage");
			IMessage.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessage>.NativeClassPtr, 100670769);
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000F2454 File Offset: 0x000F0654
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessage.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00010075 File Offset: 0x0000E275
		public IMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_IDictionary_0;
	}
}
