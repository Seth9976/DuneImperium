using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200001F RID: 31
	public class AddFriendChat : OutgoingWebSocketMessage
	{
		// Token: 0x06000178 RID: 376 RVA: 0x000028E9 File Offset: 0x00000AE9
		// Note: this type is marked as 'beforefieldinit'.
		static AddFriendChat()
		{
			Il2CppClassPointerStore<AddFriendChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "AddFriendChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendChat>.NativeClassPtr);
			AddFriendChat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendChat>.NativeClassPtr, 100663583);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000A80C File Offset: 0x00008A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167757, XrefRangeEnd = 1167770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFriendChat(string accountID, string msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendChat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendChat.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002922 File Offset: 0x00000B22
		public AddFriendChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
