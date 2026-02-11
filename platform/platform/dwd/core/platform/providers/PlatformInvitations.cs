using System;
using Canis.utils.ids;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.platform.providers
{
	// Token: 0x02000049 RID: 73
	public class PlatformInvitations : PlatformData
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformInvitations()
		{
			Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.providers", "PlatformInvitations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr);
			PlatformInvitations.NativeFieldInfoPtr_invitations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, "invitations");
			PlatformInvitations.NativeFieldInfoPtr_checkIfBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, "checkIfBlocked");
			PlatformInvitations.NativeFieldInfoPtr__All_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, "<All>k__BackingField");
			PlatformInvitations.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663678);
			PlatformInvitations.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663679);
			PlatformInvitations.NativeMethodInfoPtr_get_ReceivedInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663680);
			PlatformInvitations.NativeMethodInfoPtr_get_SentInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663681);
			PlatformInvitations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663682);
			PlatformInvitations.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663683);
			PlatformInvitations.NativeMethodInfoPtr_GetInvitationByID_Public_InvitationEntry_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663684);
			PlatformInvitations.NativeMethodInfoPtr_UpdateInvitations_Public_Void_Invitations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663685);
			PlatformInvitations.NativeMethodInfoPtr_UpdateInvitations_Public_Void_Il2CppReferenceArray_1_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663686);
			PlatformInvitations.NativeMethodInfoPtr_AddInvitation_Public_Void_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663687);
			PlatformInvitations.NativeMethodInfoPtr_SetIsBlocked_Public_Void_Func_2_AccountID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663688);
			PlatformInvitations.NativeMethodInfoPtr_RemoveInvitation_Public_Void_InvitationRemoval_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663689);
			PlatformInvitations.NativeMethodInfoPtr_RemoveInvitation_Public_Void_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663690);
			PlatformInvitations.NativeMethodInfoPtr__UpdateInvitations_b__14_0_Private_Boolean_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, 100663691);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000D934 File Offset: 0x0000BB34
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000D974 File Offset: 0x0000BB74
		public unsafe ReadOnlyCollection<InvitationEntry> All
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InvitationEntry>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		public unsafe Il2CppReferenceArray<InvitationEntry> ReceivedInvitations
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1168427, RefRangeEnd = 1168432, XrefRangeStart = 1168406, XrefRangeEnd = 1168427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_get_ReceivedInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public unsafe Il2CppReferenceArray<InvitationEntry> SentInvitations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1168453, RefRangeEnd = 1168455, XrefRangeStart = 1168432, XrefRangeEnd = 1168453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_get_SentInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000DA38 File Offset: 0x0000BC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168455, XrefRangeEnd = 1168468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformInvitations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000DA74 File Offset: 0x0000BC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168468, XrefRangeEnd = 1168470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1168482, RefRangeEnd = 1168486, XrefRangeStart = 1168470, XrefRangeEnd = 1168482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvitationEntry GetInvitationByID(string fromAccountID, string toAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fromAccountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toAccountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_GetInvitationByID_Public_InvitationEntry_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvitationEntry>(intPtr3) : null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168508, RefRangeEnd = 1168509, XrefRangeStart = 1168486, XrefRangeEnd = 1168508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInvitations(Invitations msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_UpdateInvitations_Public_Void_Invitations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000DB50 File Offset: 0x0000BD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168509, XrefRangeEnd = 1168526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInvitations(Il2CppReferenceArray<InvitationEntry> invitationList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitationList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_UpdateInvitations_Public_Void_Il2CppReferenceArray_1_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000DB94 File Offset: 0x0000BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168526, XrefRangeEnd = 1168554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInvitation(InvitationEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_AddInvitation_Public_Void_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsBlocked(Func<AccountID, bool> checkIsBlockedFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(checkIsBlockedFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_SetIsBlocked_Public_Void_Func_2_AccountID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168554, XrefRangeEnd = 1168563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInvitation(InvitationRemoval removal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(removal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_RemoveInvitation_Public_Void_InvitationRemoval_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000DC60 File Offset: 0x0000BE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168563, XrefRangeEnd = 1168576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInvitation(RosterEntry friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr_RemoveInvitation_Public_Void_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168576, XrefRangeEnd = 1168580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateInvitations_b__14_0(InvitationEntry invite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.NativeMethodInfoPtr__UpdateInvitations_b__14_0_Private_Boolean_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000347A File Offset: 0x0000167A
		public PlatformInvitations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003483 File Offset: 0x00001683
		public unsafe List<InvitationEntry> invitations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr_invitations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr_invitations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000DD24 File Offset: 0x0000BF24
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000034A2 File Offset: 0x000016A2
		public unsafe Func<AccountID, bool> checkIfBlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr_checkIfBlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr_checkIfBlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000DD54 File Offset: 0x0000BF54
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000034C1 File Offset: 0x000016C1
		public unsafe ReadOnlyCollection<InvitationEntry> _All_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr__All_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformInvitations.NativeFieldInfoPtr__All_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_invitations;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_checkIfBlocked;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr__All_k__BackingField;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_InvitationEntry_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_InvitationEntry_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceivedInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_SentInvitations_Public_get_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_GetInvitationByID_Public_InvitationEntry_String_String_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvitations_Public_Void_Invitations_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvitations_Public_Void_Il2CppReferenceArray_1_InvitationEntry_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_AddInvitation_Public_Void_InvitationEntry_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetIsBlocked_Public_Void_Func_2_AccountID_Boolean_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInvitation_Public_Void_InvitationRemoval_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInvitation_Public_Void_RosterEntry_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr__UpdateInvitations_b__14_0_Private_Boolean_InvitationEntry_0;

		// Token: 0x0200007C RID: 124
		[ObfuscatedName("dwd.core.platform.providers.PlatformInvitations+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000491 RID: 1169 RVA: 0x0001422C File Offset: 0x0001242C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformInvitations>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr);
				PlatformInvitations.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, "<>9");
				PlatformInvitations.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, "<>9__7_0");
				PlatformInvitations.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, "<>9__9_0");
				PlatformInvitations.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, 100663693);
				PlatformInvitations.__c.NativeMethodInfoPtr__get_ReceivedInvitations_b__7_0_Internal_Boolean_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, 100663694);
				PlatformInvitations.__c.NativeMethodInfoPtr__get_SentInvitations_b__9_0_Internal_Boolean_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr, 100663695);
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x000142D0 File Offset: 0x000124D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInvitations.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x0001430C File Offset: 0x0001250C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168392, XrefRangeEnd = 1168399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ReceivedInvitations_b__7_0(InvitationEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.__c.NativeMethodInfoPtr__get_ReceivedInvitations_b__7_0_Internal_Boolean_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x0001435C File Offset: 0x0001255C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168399, XrefRangeEnd = 1168406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_SentInvitations_b__9_0(InvitationEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInvitations.__c.NativeMethodInfoPtr__get_SentInvitations_b__9_0_Internal_Boolean_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00004363 File Offset: 0x00002563
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x000143AC File Offset: 0x000125AC
			// (set) Token: 0x06000497 RID: 1175 RVA: 0x0000436C File Offset: 0x0000256C
			public unsafe static PlatformInvitations.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformInvitations.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInvitations.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformInvitations.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x000143D4 File Offset: 0x000125D4
			// (set) Token: 0x06000499 RID: 1177 RVA: 0x0000437E File Offset: 0x0000257E
			public unsafe static Func<InvitationEntry, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformInvitations.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InvitationEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformInvitations.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x000143FC File Offset: 0x000125FC
			// (set) Token: 0x0600049B RID: 1179 RVA: 0x00004390 File Offset: 0x00002590
			public unsafe static Func<InvitationEntry, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformInvitations.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InvitationEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformInvitations.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeMethodInfoPtr__get_ReceivedInvitations_b__7_0_Internal_Boolean_InvitationEntry_0;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeMethodInfoPtr__get_SentInvitations_b__9_0_Internal_Boolean_InvitationEntry_0;
		}
	}
}
