using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D6 RID: 214
	[StructLayout(2)]
	public struct UserItemVote
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00059E4C File Offset: 0x0005804C
		// Note: this type is marked as 'beforefieldinit'.
		static UserItemVote()
		{
			Il2CppClassPointerStore<UserItemVote>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "UserItemVote");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr);
			UserItemVote.NativeFieldInfoPtr_VotedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr, "VotedUp");
			UserItemVote.NativeFieldInfoPtr_VotedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr, "VotedDown");
			UserItemVote.NativeFieldInfoPtr_VoteSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr, "VoteSkipped");
			UserItemVote.NativeMethodInfoPtr_From_Internal_Static_Nullable_1_UserItemVote_GetUserItemVoteResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr, 100666685);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00059ECC File Offset: 0x000580CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949718, XrefRangeEnd = 949721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<UserItemVote> From(GetUserItemVoteResult_t result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserItemVote.NativeMethodInfoPtr_From_Internal_Static_Nullable_1_UserItemVote_GetUserItemVoteResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<UserItemVote>(intPtr);
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00003D57 File Offset: 0x00001F57
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserItemVote>.NativeClassPtr, ref this));
		}

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_VotedUp;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeFieldInfoPtr_VotedDown;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeFieldInfoPtr_VoteSkipped;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_Nullable_1_UserItemVote_GetUserItemVoteResult_t_0;

		// Token: 0x04001486 RID: 5254
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool VotedUp;

		// Token: 0x04001487 RID: 5255
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool VotedDown;

		// Token: 0x04001488 RID: 5256
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool VoteSkipped;
	}
}
