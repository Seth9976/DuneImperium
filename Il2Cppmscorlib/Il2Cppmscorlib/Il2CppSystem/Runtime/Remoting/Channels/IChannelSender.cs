using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002D0 RID: 720
	public class IChannelSender : Il2CppObjectBase
	{
		// Token: 0x06002D44 RID: 11588 RVA: 0x0000F2DF File Offset: 0x0000D4DF
		// Note: this type is marked as 'beforefieldinit'.
		static IChannelSender()
		{
			Il2CppClassPointerStore<IChannelSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "IChannelSender");
			IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChannelSender>.NativeClassPtr, 100670570);
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000EC128 File Offset: 0x000EA328
		[CallerCount(0)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object remoteChannelData, out string objectURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChannelSender.NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectURI = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x0000F30E File Offset: 0x0000D50E
		public IChannelSender(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Abstract_Virtual_New_IMessageSink_String_Object_byref_String_0;
	}
}
