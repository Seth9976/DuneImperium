using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003F RID: 63
	public class RequestToJoinFriendGameDeclined : TypedMessage
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000C070 File Offset: 0x0000A270
		// Note: this type is marked as 'beforefieldinit'.
		static RequestToJoinFriendGameDeclined()
		{
			Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "RequestToJoinFriendGameDeclined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr);
			RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_fromAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr, "fromAccount");
			RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr, "gameID");
			RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr, "created");
			RequestToJoinFriendGameDeclined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr, 100663625);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestToJoinFriendGameDeclined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestToJoinFriendGameDeclined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestToJoinFriendGameDeclined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00003177 File Offset: 0x00001377
		public RequestToJoinFriendGameDeclined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000C12C File Offset: 0x0000A32C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00003180 File Offset: 0x00001380
		public unsafe AccountIDUsernameMetadata fromAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_fromAccount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_fromAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000C15C File Offset: 0x0000A35C
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000319F File Offset: 0x0000139F
		public unsafe string gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_gameID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_gameID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000C184 File Offset: 0x0000A384
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000031BE File Offset: 0x000013BE
		public unsafe long created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestToJoinFriendGameDeclined.NativeFieldInfoPtr_created)) = value;
			}
		}

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_fromAccount;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_created;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
