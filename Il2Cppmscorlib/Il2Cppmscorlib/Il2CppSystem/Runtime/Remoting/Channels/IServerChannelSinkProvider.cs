using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002D3 RID: 723
	public class IServerChannelSinkProvider : Il2CppObjectBase
	{
		// Token: 0x06002D4D RID: 11597 RVA: 0x0000F387 File Offset: 0x0000D587
		// Note: this type is marked as 'beforefieldinit'.
		static IServerChannelSinkProvider()
		{
			Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IServerChannelSinkProvider");
			IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServerChannelSinkProvider>.NativeClassPtr, 100670573);
		}

		// Token: 0x170009A7 RID: 2471
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x000EC24C File Offset: 0x000EA44C
		public unsafe virtual IServerChannelSinkProvider Next
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServerChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x0000F3B6 File Offset: 0x0000D5B6
		public IServerChannelSinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IServerChannelSinkProvider_0;
	}
}
