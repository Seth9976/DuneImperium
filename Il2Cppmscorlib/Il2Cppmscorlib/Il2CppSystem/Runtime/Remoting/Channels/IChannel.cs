using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002CD RID: 717
	public class IChannel : Il2CppObjectBase
	{
		// Token: 0x06002D3A RID: 11578 RVA: 0x000EBF60 File Offset: 0x000EA160
		// Note: this type is marked as 'beforefieldinit'.
		static IChannel()
		{
			Il2CppClassPointerStore<IChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannel");
			IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100670566);
			IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannel>.NativeClassPtr, 100670567);
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000EBFB0 File Offset: 0x000EA1B0
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000EBFF4 File Offset: 0x000EA1F4
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
		public IChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
