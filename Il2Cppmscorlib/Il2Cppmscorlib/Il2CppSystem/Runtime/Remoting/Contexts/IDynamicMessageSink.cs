using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C5 RID: 709
	public class IDynamicMessageSink : Il2CppObjectBase
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x000EAC30 File Offset: 0x000E8E30
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicMessageSink()
		{
			Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicMessageSink");
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100670524);
			IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100670525);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000EAC80 File Offset: 0x000E8E80
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replyMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000EACEC File Offset: 0x000E8EEC
		[CallerCount(0)]
		public unsafe virtual void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCliSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMessageSink.NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		public IDynamicMessageSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;
	}
}
