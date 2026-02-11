using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003E RID: 62
	public class RequestToJoinFriendGame : TypedMessage
	{
		// Token: 0x0600021A RID: 538 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		// Note: this type is marked as 'beforefieldinit'.
		static RequestToJoinFriendGame()
		{
			Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "RequestToJoinFriendGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr);
			RequestToJoinFriendGame.NativeFieldInfoPtr_fromAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr, "fromAccount");
			RequestToJoinFriendGame.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr, "gameID");
			RequestToJoinFriendGame.NativeFieldInfoPtr_created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr, "created");
			RequestToJoinFriendGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr, 100663623);
			RequestToJoinFriendGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr, 100663624);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000BF70 File Offset: 0x0000A170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167944, XrefRangeEnd = 1167950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestToJoinFriendGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestToJoinFriendGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestToJoinFriendGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestToJoinFriendGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003115 File Offset: 0x00001315
		public RequestToJoinFriendGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0000311E File Offset: 0x0000131E
		public unsafe AccountIDUsernameMetadata fromAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_fromAccount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_fromAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000C020 File Offset: 0x0000A220
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0000313D File Offset: 0x0000133D
		public unsafe string gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_gameID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_gameID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000C048 File Offset: 0x0000A248
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000315C File Offset: 0x0000135C
		public unsafe long created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGame.NativeFieldInfoPtr_created)) = value;
			}
		}

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_fromAccount;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_created;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
