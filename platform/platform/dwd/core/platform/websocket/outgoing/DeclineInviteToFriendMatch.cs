using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000025 RID: 37
	public class DeclineInviteToFriendMatch : OutgoingWebSocketMessage
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00002A3C File Offset: 0x00000C3C
		// Note: this type is marked as 'beforefieldinit'.
		static DeclineInviteToFriendMatch()
		{
			Il2CppClassPointerStore<DeclineInviteToFriendMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "DeclineInviteToFriendMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclineInviteToFriendMatch>.NativeClassPtr);
			DeclineInviteToFriendMatch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclineInviteToFriendMatch>.NativeClassPtr, 100663590);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000AA9C File Offset: 0x00008C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167819, XrefRangeEnd = 1167832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeclineInviteToFriendMatch(string accountID, string gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclineInviteToFriendMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeclineInviteToFriendMatch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002A75 File Offset: 0x00000C75
		public DeclineInviteToFriendMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
