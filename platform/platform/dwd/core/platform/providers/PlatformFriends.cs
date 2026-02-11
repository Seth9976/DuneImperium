using System;
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
	// Token: 0x02000048 RID: 72
	public class PlatformFriends : PlatformData
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformFriends()
		{
			Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.providers", "PlatformFriends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr);
			PlatformFriends.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, "<Initialized>k__BackingField");
			PlatformFriends.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, "friends");
			PlatformFriends.NativeFieldInfoPtr__All_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, "<All>k__BackingField");
			PlatformFriends.NativeFieldInfoPtr__OnlineFriends_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, "<OnlineFriends>k__BackingField");
			PlatformFriends.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663661);
			PlatformFriends.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663662);
			PlatformFriends.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663663);
			PlatformFriends.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663664);
			PlatformFriends.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663665);
			PlatformFriends.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663666);
			PlatformFriends.NativeMethodInfoPtr_get_OnlineFriends_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663667);
			PlatformFriends.NativeMethodInfoPtr_set_OnlineFriends_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663668);
			PlatformFriends.NativeMethodInfoPtr_updateOnline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663669);
			PlatformFriends.NativeMethodInfoPtr_GetEntryByID_Public_RosterEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663670);
			PlatformFriends.NativeMethodInfoPtr_UpdateRoster_Public_Void_Roster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663671);
			PlatformFriends.NativeMethodInfoPtr_UpdateFriends_Public_Void_Il2CppReferenceArray_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663672);
			PlatformFriends.NativeMethodInfoPtr_AddFriend_Public_Void_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663673);
			PlatformFriends.NativeMethodInfoPtr_RemoveFriend_Public_Void_RosterRemoval_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, 100663674);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000D380 File Offset: 0x0000B580
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe ReadOnlyCollection<RosterEntry> All
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<RosterEntry>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000D480 File Offset: 0x0000B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168309, XrefRangeEnd = 1168322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformFriends()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168322, XrefRangeEnd = 1168324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000D52C File Offset: 0x0000B72C
		public unsafe int OnlineFriends
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_get_OnlineFriends_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_set_OnlineFriends_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000D56C File Offset: 0x0000B76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168342, RefRangeEnd = 1168344, XrefRangeStart = 1168324, XrefRangeEnd = 1168342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateOnline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_updateOnline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168355, RefRangeEnd = 1168357, XrefRangeStart = 1168344, XrefRangeEnd = 1168355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RosterEntry GetEntryByID(string accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_GetEntryByID_Public_RosterEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168357, XrefRangeEnd = 1168359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRoster(Roster roster)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_UpdateRoster_Public_Void_Roster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000D634 File Offset: 0x0000B834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168368, RefRangeEnd = 1168370, XrefRangeStart = 1168359, XrefRangeEnd = 1168368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFriends(Il2CppReferenceArray<RosterEntry> friendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_UpdateFriends_Public_Void_Il2CppReferenceArray_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D678 File Offset: 0x0000B878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168370, XrefRangeEnd = 1168383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFriend(RosterEntry friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_AddFriend_Public_Void_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168383, XrefRangeEnd = 1168392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFriend(RosterRemoval removal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(removal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.NativeMethodInfoPtr_RemoveFriend_Public_Void_RosterRemoval_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000033FD File Offset: 0x000015FD
		public PlatformFriends(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000D700 File Offset: 0x0000B900
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003406 File Offset: 0x00001606
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000D728 File Offset: 0x0000B928
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003421 File Offset: 0x00001621
		public unsafe List<RosterEntry> friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr_friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D758 File Offset: 0x0000B958
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003440 File Offset: 0x00001640
		public unsafe ReadOnlyCollection<RosterEntry> _All_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__All_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__All_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D788 File Offset: 0x0000B988
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000345F File Offset: 0x0000165F
		public unsafe int _OnlineFriends_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__OnlineFriends_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriends.NativeFieldInfoPtr__OnlineFriends_k__BackingField)) = value;
			}
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_friends;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr__All_k__BackingField;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr__OnlineFriends_k__BackingField;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_get_ReadOnlyCollection_1_RosterEntry_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_set_All_Private_set_Void_ReadOnlyCollection_1_RosterEntry_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlineFriends_Public_get_Int32_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_set_OnlineFriends_Private_set_Void_Int32_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_updateOnline_Private_Void_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryByID_Public_RosterEntry_String_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoster_Public_Void_Roster_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFriends_Public_Void_Il2CppReferenceArray_1_RosterEntry_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_AddFriend_Public_Void_RosterEntry_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_RosterRemoval_0;

		// Token: 0x0200007B RID: 123
		[ObfuscatedName("dwd.core.platform.providers.PlatformFriends+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000489 RID: 1161 RVA: 0x000140D4 File Offset: 0x000122D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformFriends>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr);
				PlatformFriends.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr, "<>9");
				PlatformFriends.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr, "<>9__15_0");
				PlatformFriends.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr, 100663676);
				PlatformFriends.__c.NativeMethodInfoPtr__updateOnline_b__15_0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr, 100663677);
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00014150 File Offset: 0x00012350
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFriends.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x0001418C File Offset: 0x0001238C
			[CallerCount(0)]
			public unsafe bool _updateOnline_b__15_0(RosterEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriends.__c.NativeMethodInfoPtr__updateOnline_b__15_0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00004336 File Offset: 0x00002536
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600048D RID: 1165 RVA: 0x000141DC File Offset: 0x000123DC
			// (set) Token: 0x0600048E RID: 1166 RVA: 0x0000433F File Offset: 0x0000253F
			public unsafe static PlatformFriends.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformFriends.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformFriends.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformFriends.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600048F RID: 1167 RVA: 0x00014204 File Offset: 0x00012404
			// (set) Token: 0x06000490 RID: 1168 RVA: 0x00004351 File Offset: 0x00002551
			public unsafe static Func<RosterEntry, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformFriends.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformFriends.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr__updateOnline_b__15_0_Internal_Boolean_RosterEntry_0;
		}
	}
}
