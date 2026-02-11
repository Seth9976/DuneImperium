using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.data
{
	// Token: 0x0200004E RID: 78
	public class FriendChatMessage : Object
	{
		// Token: 0x0600031B RID: 795 RVA: 0x0000FB20 File Offset: 0x0000DD20
		// Note: this type is marked as 'beforefieldinit'.
		static FriendChatMessage()
		{
			Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.data", "FriendChatMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr);
			FriendChatMessage.NativeFieldInfoPtr_ChannelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "ChannelID");
			FriendChatMessage.NativeFieldInfoPtr_ChatID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "ChatID");
			FriendChatMessage.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "Created");
			FriendChatMessage.NativeFieldInfoPtr_FromAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "FromAccount");
			FriendChatMessage.NativeFieldInfoPtr_ToAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "ToAccount");
			FriendChatMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, "Message");
			FriendChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, 100663795);
			FriendChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr, 100663796);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169853, XrefRangeEnd = 1169874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000FC34 File Offset: 0x0000DE34
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendChatMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000036CB File Offset: 0x000018CB
		public FriendChatMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000FC70 File Offset: 0x0000DE70
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000036D4 File Offset: 0x000018D4
		public unsafe string ChannelID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ChannelID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ChannelID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000FC98 File Offset: 0x0000DE98
		// (set) Token: 0x06000322 RID: 802 RVA: 0x000036F3 File Offset: 0x000018F3
		public unsafe string ChatID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ChatID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ChatID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00003712 File Offset: 0x00001912
		public unsafe long Created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_Created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_Created)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000372D File Offset: 0x0000192D
		public unsafe AccountIDUsername FromAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_FromAccount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsername>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_FromAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000FD18 File Offset: 0x0000DF18
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000374C File Offset: 0x0000194C
		public unsafe AccountIDUsername ToAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ToAccount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsername>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_ToAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000FD48 File Offset: 0x0000DF48
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000376B File Offset: 0x0000196B
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatMessage.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_ChannelID;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_ChatID;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_Created;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_FromAccount;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_ToAccount;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
