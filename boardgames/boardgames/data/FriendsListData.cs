using System;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x0200013E RID: 318
	public class FriendsListData : VersionedDataComponent
	{
		// Token: 0x0600107D RID: 4221 RVA: 0x00043BD4 File Offset: 0x00041DD4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListData()
		{
			Il2CppClassPointerStore<FriendsListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "FriendsListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr);
			FriendsListData.NativeFieldInfoPtr__Friends_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, "<Friends>k__BackingField");
			FriendsListData.NativeMethodInfoPtr_get_Friends_Public_get_List_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, 100665713);
			FriendsListData.NativeMethodInfoPtr_set_Friends_Private_set_Void_List_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, 100665714);
			FriendsListData.NativeMethodInfoPtr_UpdateFriends_Public_Void_List_1_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, 100665715);
			FriendsListData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, 100665716);
			FriendsListData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr, 100665717);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00043C7C File Offset: 0x00041E7C
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00043CBC File Offset: 0x00041EBC
		public unsafe List<RosterEntry> Friends
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListData.NativeMethodInfoPtr_get_Friends_Public_get_List_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RosterEntry>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListData.NativeMethodInfoPtr_set_Friends_Private_set_Void_List_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00043D00 File Offset: 0x00041F00
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514283, XrefRangeEnd = 514296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFriends(List<RosterEntry> newFriendsList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFriendsList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListData.NativeMethodInfoPtr_UpdateFriends_Public_Void_List_1_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00043D44 File Offset: 0x00041F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999333, XrefRangeEnd = 999338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00043D88 File Offset: 0x00041F88
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 499944, RefRangeEnd = 499953, XrefRangeStart = 499944, XrefRangeEnd = 499953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00009A46 File Offset: 0x00007C46
		public FriendsListData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00043DC4 File Offset: 0x00041FC4
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00009A4F File Offset: 0x00007C4F
		public unsafe List<RosterEntry> _Friends_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListData.NativeFieldInfoPtr__Friends_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListData.NativeFieldInfoPtr__Friends_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr__Friends_k__BackingField;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_get_Friends_Public_get_List_1_RosterEntry_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_set_Friends_Private_set_Void_List_1_RosterEntry_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFriends_Public_Void_List_1_RosterEntry_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
