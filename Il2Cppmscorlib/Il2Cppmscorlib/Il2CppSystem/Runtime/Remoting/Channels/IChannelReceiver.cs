using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002CF RID: 719
	public class IChannelReceiver : Il2CppObjectBase
	{
		// Token: 0x06002D40 RID: 11584 RVA: 0x000EC03C File Offset: 0x000EA23C
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelReceiver()
		{
			Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelReceiver");
			IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100670568);
			IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelReceiver>.NativeClassPtr, 100670569);
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000EC08C File Offset: 0x000EA28C
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000EC0D8 File Offset: 0x000EA2D8
		[CallerCount(0)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelReceiver.NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x0000F2D6 File Offset: 0x0000D4D6
		public IChannelReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
