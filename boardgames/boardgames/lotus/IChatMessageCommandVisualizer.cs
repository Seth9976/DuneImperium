using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000B9 RID: 185
	public class IChatMessageCommandVisualizer : Il2CppObjectBase
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x0002EAA4 File Offset: 0x0002CCA4
		// Note: this type is marked as 'beforefieldinit'.
		static IChatMessageCommandVisualizer()
		{
			Il2CppClassPointerStore<IChatMessageCommandVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IChatMessageCommandVisualizer");
			IChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageCommandVisualizer>.NativeClassPtr, 100664766);
			IChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleLocalChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageCommandVisualizer>.NativeClassPtr, 100664767);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
		[CallerCount(0)]
		public unsafe virtual void HandleIncomingChatMessage(ClientChatMessage clientChatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientChatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002EB44 File Offset: 0x0002CD44
		[CallerCount(0)]
		public unsafe virtual void HandleLocalChatMessage(ClientChatMessage clientChatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientChatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleLocalChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00006471 File Offset: 0x00004671
		public IChatMessageCommandVisualizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_HandleLocalChatMessage_Public_Abstract_Virtual_New_Void_ClientChatMessage_0;
	}
}
