using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200002B RID: 43
	public class InviteFriendToMatch : OutgoingWebSocketMessage
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// Note: this type is marked as 'beforefieldinit'.
		static InviteFriendToMatch()
		{
			Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "InviteFriendToMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr);
			InviteFriendToMatch.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, 100663596);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000AC28 File Offset: 0x00008E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167847, XrefRangeEnd = 1167868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InviteFriendToMatch(string accountIDToSendTo, string username, string gameID, string matchInitData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountIDToSendTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchInitData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002C01 File Offset: 0x00000E01
		public InviteFriendToMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0;
	}
}
