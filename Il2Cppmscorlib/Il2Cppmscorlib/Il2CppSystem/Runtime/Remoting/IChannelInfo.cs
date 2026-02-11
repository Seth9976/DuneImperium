using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000293 RID: 659
	public class IChannelInfo : Il2CppObjectBase
	{
		// Token: 0x06002A31 RID: 10801 RVA: 0x0000E00E File Offset: 0x0000C20E
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelInfo()
		{
			Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IChannelInfo");
			IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelInfo>.NativeClassPtr, 100670173);
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000E0A98 File Offset: 0x000DEC98
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0000E03D File Offset: 0x0000C23D
		public IChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
