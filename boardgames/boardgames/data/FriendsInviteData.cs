using System;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x0200013D RID: 317
	public class FriendsInviteData : VersionedDataComponent
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x000438B4 File Offset: 0x00041AB4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsInviteData()
		{
			Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "FriendsInviteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr);
			FriendsInviteData.NativeFieldInfoPtr__InvitesSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, "<InvitesSent>k__BackingField");
			FriendsInviteData.NativeFieldInfoPtr__InvitesReceived_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, "<InvitesReceived>k__BackingField");
			FriendsInviteData.NativeMethodInfoPtr_get_InvitesSent_Public_get_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665706);
			FriendsInviteData.NativeMethodInfoPtr_set_InvitesSent_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665707);
			FriendsInviteData.NativeMethodInfoPtr_get_InvitesReceived_Public_get_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665708);
			FriendsInviteData.NativeMethodInfoPtr_set_InvitesReceived_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665709);
			FriendsInviteData.NativeMethodInfoPtr_UpdateInvites_Public_Void_Il2CppReferenceArray_1_InvitationEntry_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665710);
			FriendsInviteData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665711);
			FriendsInviteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr, 100665712);
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00043998 File Offset: 0x00041B98
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000439D8 File Offset: 0x00041BD8
		public unsafe Il2CppReferenceArray<InvitationEntry> InvitesSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr_get_InvitesSent_Public_get_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr_set_InvitesSent_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00043A1C File Offset: 0x00041C1C
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00043A5C File Offset: 0x00041C5C
		public unsafe Il2CppReferenceArray<InvitationEntry> InvitesReceived
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr_get_InvitesReceived_Public_get_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr_set_InvitesReceived_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00043AA0 File Offset: 0x00041CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514318, RefRangeEnd = 514319, XrefRangeStart = 514318, XrefRangeEnd = 514319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInvites(Il2CppReferenceArray<InvitationEntry> invitesSent, Il2CppReferenceArray<InvitationEntry> invitesReceived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitesSent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invitesReceived);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr_UpdateInvites_Public_Void_Il2CppReferenceArray_1_InvitationEntry_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00043AF4 File Offset: 0x00041CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999326, XrefRangeEnd = 999333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsInviteData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00043B38 File Offset: 0x00041D38
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 499944, RefRangeEnd = 499953, XrefRangeStart = 499944, XrefRangeEnd = 499953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsInviteData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsInviteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsInviteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000099FF File Offset: 0x00007BFF
		public FriendsInviteData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00043B74 File Offset: 0x00041D74
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x00009A08 File Offset: 0x00007C08
		public unsafe Il2CppReferenceArray<InvitationEntry> _InvitesSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsInviteData.NativeFieldInfoPtr__InvitesSent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsInviteData.NativeFieldInfoPtr__InvitesSent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00043BA4 File Offset: 0x00041DA4
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x00009A27 File Offset: 0x00007C27
		public unsafe Il2CppReferenceArray<InvitationEntry> _InvitesReceived_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsInviteData.NativeFieldInfoPtr__InvitesReceived_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsInviteData.NativeFieldInfoPtr__InvitesReceived_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr__InvitesSent_k__BackingField;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr__InvitesReceived_k__BackingField;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_InvitesSent_Public_get_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_set_InvitesSent_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_get_InvitesReceived_Public_get_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_set_InvitesReceived_Private_set_Void_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvites_Public_Void_Il2CppReferenceArray_1_InvitationEntry_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
