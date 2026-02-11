using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002D1 RID: 721
	public class IClientChannelSinkProvider : Il2CppObjectBase
	{
		// Token: 0x06002D47 RID: 11591 RVA: 0x0000F317 File Offset: 0x0000D517
		// Note: this type is marked as 'beforefieldinit'.
		static IClientChannelSinkProvider()
		{
			Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IClientChannelSinkProvider");
			IClientChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientChannelSinkProvider>.NativeClassPtr, 100670571);
		}

		// Token: 0x170009A5 RID: 2469
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x000EC1B0 File Offset: 0x000EA3B0
		public unsafe virtual IClientChannelSinkProvider Next
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientChannelSinkProvider.NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0000F346 File Offset: 0x0000D546
		public IClientChannelSinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_Abstract_Virtual_New_set_Void_IClientChannelSinkProvider_0;
	}
}
