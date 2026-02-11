using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000BA RID: 186
	public class IChatMessageFilter : Il2CppObjectBase
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x0000647A File Offset: 0x0000467A
		// Note: this type is marked as 'beforefieldinit'.
		static IChatMessageFilter()
		{
			Il2CppClassPointerStore<IChatMessageFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IChatMessageFilter");
			IChatMessageFilter.NativeMethodInfoPtr_IsValidMessage_Public_Abstract_Virtual_New_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageFilter>.NativeClassPtr, 100664768);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0002EB94 File Offset: 0x0002CD94
		[CallerCount(0)]
		public unsafe virtual bool IsValidMessage(ClientChatMessage chatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageFilter.NativeMethodInfoPtr_IsValidMessage_Public_Abstract_Virtual_New_Boolean_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000064A9 File Offset: 0x000046A9
		public IChatMessageFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMessage_Public_Abstract_Virtual_New_Boolean_ClientChatMessage_0;
	}
}
