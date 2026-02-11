using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002FD RID: 765
	public class IMessageSink : Il2CppObjectBase
	{
		// Token: 0x06002F19 RID: 12057 RVA: 0x000F24A0 File Offset: 0x000F06A0
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageSink()
		{
			Il2CppClassPointerStore<IMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMessageSink");
			IMessageSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageSink>.NativeClassPtr, 100670770);
			IMessageSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageSink>.NativeClassPtr, 100670771);
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000F24F0 File Offset: 0x000F06F0
		[CallerCount(0)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000F254C File Offset: 0x000F074C
		[CallerCount(0)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000100A2 File Offset: 0x0000E2A2
		public IMessageSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
