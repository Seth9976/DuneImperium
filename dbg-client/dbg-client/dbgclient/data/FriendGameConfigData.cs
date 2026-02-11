using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000CC RID: 204
	public class FriendGameConfigData : DataComponent
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x00038B00 File Offset: 0x00036D00
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameConfigData()
		{
			Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "FriendGameConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr);
			FriendGameConfigData.NativeFieldInfoPtr_invitedFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, "invitedFriends");
			FriendGameConfigData.NativeFieldInfoPtr__GameOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, "<GameOptions>k__BackingField");
			FriendGameConfigData.NativeMethodInfoPtr_get_InvitedFriends_Public_get_IReadOnlyList_1_FriendGameInviteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664553);
			FriendGameConfigData.NativeMethodInfoPtr_get_GameOptions_Public_get_VersionedMap_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664554);
			FriendGameConfigData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664555);
			FriendGameConfigData.NativeMethodInfoPtr_AddFriend_Public_Void_FriendGameInviteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664556);
			FriendGameConfigData.NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664557);
			FriendGameConfigData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664558);
			FriendGameConfigData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr, 100664559);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00038BE4 File Offset: 0x00036DE4
		public unsafe IReadOnlyList<FriendGameInviteData> InvitedFriends
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr_get_InvitedFriends_Public_get_IReadOnlyList_1_FriendGameInviteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FriendGameInviteData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00038C24 File Offset: 0x00036E24
		public unsafe VersionedMap<string, string> GameOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr_get_GameOptions_Public_get_VersionedMap_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionedMap<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00038C64 File Offset: 0x00036E64
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504808, XrefRangeEnd = 504811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00038CA0 File Offset: 0x00036EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504815, RefRangeEnd = 504816, XrefRangeStart = 504811, XrefRangeEnd = 504815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFriend(FriendGameInviteData friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr_AddFriend_Public_Void_FriendGameInviteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00038CE4 File Offset: 0x00036EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504817, RefRangeEnd = 504818, XrefRangeStart = 504816, XrefRangeEnd = 504817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFriend(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00038D24 File Offset: 0x00036F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504818, XrefRangeEnd = 504827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameConfigData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00038D68 File Offset: 0x00036F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504827, XrefRangeEnd = 504842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameConfigData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameConfigData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0000611D File Offset: 0x0000431D
		public FriendGameConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00038DA4 File Offset: 0x00036FA4
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00006126 File Offset: 0x00004326
		public unsafe VersionedList<FriendGameInviteData> invitedFriends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigData.NativeFieldInfoPtr_invitedFriends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<FriendGameInviteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigData.NativeFieldInfoPtr_invitedFriends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00038DD4 File Offset: 0x00036FD4
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00006145 File Offset: 0x00004345
		public unsafe VersionedMap<string, string> _GameOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigData.NativeFieldInfoPtr__GameOptions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigData.NativeFieldInfoPtr__GameOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_invitedFriends;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr__GameOptions_k__BackingField;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_get_InvitedFriends_Public_get_IReadOnlyList_1_FriendGameInviteData_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_GameOptions_Public_get_VersionedMap_2_String_String_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_AddFriend_Public_Void_FriendGameInviteData_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_Int32_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
