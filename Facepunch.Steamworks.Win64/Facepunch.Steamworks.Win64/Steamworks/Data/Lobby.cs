using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x02000203 RID: 515
	[StructLayout(2)]
	public struct Lobby
	{
		// Token: 0x060019A1 RID: 6561 RVA: 0x0007BDB8 File Offset: 0x00079FB8
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<Id>k__BackingField");
			Lobby.NativeMethodInfoPtr_get_Id_Public_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667966);
			Lobby.NativeMethodInfoPtr_set_Id_Internal_set_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667967);
			Lobby.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667968);
			Lobby.NativeMethodInfoPtr_Join_Public_Task_1_RoomEnter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667969);
			Lobby.NativeMethodInfoPtr_Leave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667970);
			Lobby.NativeMethodInfoPtr_InviteFriend_Public_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667971);
			Lobby.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667972);
			Lobby.NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667973);
			Lobby.NativeMethodInfoPtr_GetData_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667974);
			Lobby.NativeMethodInfoPtr_SetData_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667975);
			Lobby.NativeMethodInfoPtr_DeleteData_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667976);
			Lobby.NativeMethodInfoPtr_get_Data_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667977);
			Lobby.NativeMethodInfoPtr_GetMemberData_Public_String_Friend_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667978);
			Lobby.NativeMethodInfoPtr_SetMemberData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667979);
			Lobby.NativeMethodInfoPtr_SendChatString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667980);
			Lobby.NativeMethodInfoPtr_SendChatBytes_Public_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667981);
			Lobby.NativeMethodInfoPtr_SendChatBytesUnsafe_Public_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667982);
			Lobby.NativeMethodInfoPtr_Refresh_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667983);
			Lobby.NativeMethodInfoPtr_get_MaxMembers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667984);
			Lobby.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667985);
			Lobby.NativeMethodInfoPtr_SetPublic_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667986);
			Lobby.NativeMethodInfoPtr_SetPrivate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667987);
			Lobby.NativeMethodInfoPtr_SetInvisible_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667988);
			Lobby.NativeMethodInfoPtr_SetFriendsOnly_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667989);
			Lobby.NativeMethodInfoPtr_SetJoinable_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667990);
			Lobby.NativeMethodInfoPtr_SetGameServer_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667991);
			Lobby.NativeMethodInfoPtr_SetGameServer_Public_Void_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667992);
			Lobby.NativeMethodInfoPtr_GetGameServer_Public_Boolean_byref_UInt32_byref_UInt16_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667993);
			Lobby.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667994);
			Lobby.NativeMethodInfoPtr_set_Owner_Public_set_Void_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667995);
			Lobby.NativeMethodInfoPtr_IsOwnedBy_Public_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100667996);
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0007C068 File Offset: 0x0007A268
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0007C098 File Offset: 0x0007A298
		public unsafe SteamId Id
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_Id_Public_get_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_Id_Internal_set_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0007C0CC File Offset: 0x0007A2CC
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby(SteamId id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0007C100 File Offset: 0x0007A300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952471, XrefRangeEnd = 952484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<RoomEnter> Join()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_Join_Public_Task_1_RoomEnter_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<RoomEnter>>(intPtr3) : null;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0007C134 File Offset: 0x0007A334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952484, XrefRangeEnd = 952487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Leave()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_Leave_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0007C15C File Offset: 0x0007A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952487, XrefRangeEnd = 952490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InviteFriend(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_InviteFriend_Public_Boolean_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0007C19C File Offset: 0x0007A39C
		public unsafe int MemberCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952490, XrefRangeEnd = 952493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0007C1CC File Offset: 0x0007A3CC
		public unsafe IEnumerable<Friend> Members
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952493, XrefRangeEnd = 952498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_Friend_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0007C200 File Offset: 0x0007A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952498, XrefRangeEnd = 952501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetData(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetData_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0007C23C File Offset: 0x0007A43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952501, XrefRangeEnd = 952503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetData(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetData_Public_Boolean_String_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0007C290 File Offset: 0x0007A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952503, XrefRangeEnd = 952506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteData(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_DeleteData_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0007C2D4 File Offset: 0x0007A4D4
		public unsafe IEnumerable<KeyValuePair<string, string>> Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952506, XrefRangeEnd = 952511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_Data_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0007C308 File Offset: 0x0007A508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952511, XrefRangeEnd = 952513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMemberData(Friend member, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref member;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetMemberData_Public_String_Friend_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0007C354 File Offset: 0x0007A554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952513, XrefRangeEnd = 952515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMemberData(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetMemberData_Public_Void_String_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0007C39C File Offset: 0x0007A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952515, XrefRangeEnd = 952523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendChatString(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendChatString_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0007C3E0 File Offset: 0x0007A5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952523, XrefRangeEnd = 952527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendChatBytes(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendChatBytes_Public_Boolean_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0007C424 File Offset: 0x0007A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952527, XrefRangeEnd = 952530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendChatBytesUnsafe(byte* ptr, int length)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendChatBytesUnsafe_Public_Boolean_ptr_Byte_Int32_0, ref this, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0007C470 File Offset: 0x0007A670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952530, XrefRangeEnd = 952533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refresh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_Refresh_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0007C4A0 File Offset: 0x0007A6A0
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0007C4D0 File Offset: 0x0007A6D0
		public unsafe int MaxMembers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952533, XrefRangeEnd = 952536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_MaxMembers_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952536, XrefRangeEnd = 952539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0007C504 File Offset: 0x0007A704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952539, XrefRangeEnd = 952542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPublic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetPublic_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0007C534 File Offset: 0x0007A734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952542, XrefRangeEnd = 952545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPrivate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetPrivate_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0007C564 File Offset: 0x0007A764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952545, XrefRangeEnd = 952548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetInvisible()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetInvisible_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0007C594 File Offset: 0x0007A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952548, XrefRangeEnd = 952551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetFriendsOnly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetFriendsOnly_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0007C5C4 File Offset: 0x0007A7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952551, XrefRangeEnd = 952554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetJoinable(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetJoinable_Public_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0007C604 File Offset: 0x0007A804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952554, XrefRangeEnd = 952557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameServer(SteamId steamServer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetGameServer_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0007C638 File Offset: 0x0007A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952557, XrefRangeEnd = 952567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameServer(string ip, ushort port)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetGameServer_Public_Void_String_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0007C67C File Offset: 0x0007A87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952567, XrefRangeEnd = 952569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetGameServer(ref uint ip, ref ushort port, ref SteamId serverId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &serverId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetGameServer_Public_Boolean_byref_UInt32_byref_UInt16_byref_SteamId_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0007C6D8 File Offset: 0x0007A8D8
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0007C708 File Offset: 0x0007A908
		public unsafe Friend Owner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952569, XrefRangeEnd = 952572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952572, XrefRangeEnd = 952575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_Owner_Public_set_Void_Friend_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0007C73C File Offset: 0x0007A93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952575, XrefRangeEnd = 952577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOwnedBy(SteamId k)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref k;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_IsOwnedBy_Public_Boolean_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00008590 File Offset: 0x00006790
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Lobby>.NativeClassPtr, ref this));
		}

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_SteamId_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Internal_set_Void_SteamId_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamId_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Task_1_RoomEnter_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_Leave_Public_Void_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_InviteFriend_Public_Boolean_SteamId_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_Friend_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_String_String_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Boolean_String_String_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_DeleteData_Public_Boolean_String_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberData_Public_String_Friend_String_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_SetMemberData_Public_Void_String_String_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_SendChatString_Public_Boolean_String_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_SendChatBytes_Public_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_SendChatBytesUnsafe_Public_Boolean_ptr_Byte_Int32_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Boolean_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxMembers_Public_get_Int32_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_Int32_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_SetPublic_Public_Boolean_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_SetPrivate_Public_Boolean_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Boolean_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_SetFriendsOnly_Public_Boolean_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_SetJoinable_Public_Boolean_Boolean_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_SetGameServer_Public_Void_SteamId_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_SetGameServer_Public_Void_String_UInt16_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_GetGameServer_Public_Boolean_byref_UInt32_byref_UInt16_byref_SteamId_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Friend_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Public_set_Void_Friend_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_IsOwnedBy_Public_Boolean_SteamId_0;

		// Token: 0x04001EFA RID: 7930
		[FieldOffset(0)]
		public SteamId _Id_k__BackingField;

		// Token: 0x020002AB RID: 683
		[ObfuscatedName("Steamworks.Data.Lobby+<Join>d__5")]
		public sealed class _Join_d__5 : ValueType
		{
			// Token: 0x060022B1 RID: 8881 RVA: 0x00094268 File Offset: 0x00092468
			// Note: this type is marked as 'beforefieldinit'.
			static _Join_d__5()
			{
				Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<Join>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr);
				Lobby._Join_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, "<>1__state");
				Lobby._Join_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, "<>t__builder");
				Lobby._Join_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, "<>4__this");
				Lobby._Join_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, "<>u__1");
				Lobby._Join_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, 100667997);
				Lobby._Join_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr, 100667998);
			}

			// Token: 0x060022B2 RID: 8882 RVA: 0x0009430C File Offset: 0x0009250C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952397, XrefRangeEnd = 952421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._Join_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B3 RID: 8883 RVA: 0x00094344 File Offset: 0x00092544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952421, XrefRangeEnd = 952427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._Join_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022B4 RID: 8884 RVA: 0x0000E4AE File Offset: 0x0000C6AE
			public _Join_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022B5 RID: 8885 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
			public _Join_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby._Join_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0009438C File Offset: 0x0009258C
			// (set) Token: 0x060022B7 RID: 8887 RVA: 0x0000E4C9 File Offset: 0x0000C6C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000943B4 File Offset: 0x000925B4
			// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
			public AsyncTaskMethodBuilder<RoomEnter> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<RoomEnter>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<RoomEnter>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<RoomEnter>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x060022BA RID: 8890 RVA: 0x000943E4 File Offset: 0x000925E4
			// (set) Token: 0x060022BB RID: 8891 RVA: 0x0000E512 File Offset: 0x0000C712
			public unsafe Lobby __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x060022BC RID: 8892 RVA: 0x0009440C File Offset: 0x0009260C
			// (set) Token: 0x060022BD RID: 8893 RVA: 0x0000E52D File Offset: 0x0000C72D
			public CallResult<LobbyEnter_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___u__1);
					return new CallResult<LobbyEnter_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LobbyEnter_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._Join_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LobbyEnter_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023FD RID: 9213
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023FE RID: 9214
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023FF RID: 9215
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002400 RID: 9216
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002401 RID: 9217
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002402 RID: 9218
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002AC RID: 684
		[ObfuscatedName("Steamworks.Data.Lobby+<get_Data>d__16")]
		public sealed class _get_Data_d__16 : Object
		{
			// Token: 0x060022BE RID: 8894 RVA: 0x0009443C File Offset: 0x0009263C
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Data_d__16()
			{
				Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<get_Data>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr);
				Lobby._get_Data_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<>1__state");
				Lobby._get_Data_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<>2__current");
				Lobby._get_Data_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<>l__initialThreadId");
				Lobby._get_Data_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<>4__this");
				Lobby._get_Data_d__16.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<>3__<>4__this");
				Lobby._get_Data_d__16.NativeFieldInfoPtr__cnt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<cnt>5__2");
				Lobby._get_Data_d__16.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, "<i>5__3");
				Lobby._get_Data_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100667999);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668000);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668001);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668002);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668003);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668004);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668005);
				Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr, 100668006);
			}

			// Token: 0x060022BF RID: 8895 RVA: 0x00094594 File Offset: 0x00092794
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Data_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby._get_Data_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022C0 RID: 8896 RVA: 0x000945DC File Offset: 0x000927DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C1 RID: 8897 RVA: 0x00094610 File Offset: 0x00092810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952427, XrefRangeEnd = 952436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0009464C File Offset: 0x0009284C
			public unsafe KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, string>(intPtr);
				}
			}

			// Token: 0x060022C3 RID: 8899 RVA: 0x00094684 File Offset: 0x00092884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952436, XrefRangeEnd = 952441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x060022C4 RID: 8900 RVA: 0x000946B8 File Offset: 0x000928B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952441, XrefRangeEnd = 952444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x000946F8 File Offset: 0x000928F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952444, XrefRangeEnd = 952451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
			}

			// Token: 0x060022C6 RID: 8902 RVA: 0x00094738 File Offset: 0x00092938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Data_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060022C7 RID: 8903 RVA: 0x0000E55B File Offset: 0x0000C75B
			public _get_Data_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00094778 File Offset: 0x00092978
			// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0000E564 File Offset: 0x0000C764
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x060022CA RID: 8906 RVA: 0x000947A0 File Offset: 0x000929A0
			// (set) Token: 0x060022CB RID: 8907 RVA: 0x0000E57F File Offset: 0x0000C77F
			public KeyValuePair<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x060022CC RID: 8908 RVA: 0x000947D0 File Offset: 0x000929D0
			// (set) Token: 0x060022CD RID: 8909 RVA: 0x0000E5AD File Offset: 0x0000C7AD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x060022CE RID: 8910 RVA: 0x000947F8 File Offset: 0x000929F8
			// (set) Token: 0x060022CF RID: 8911 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
			public unsafe Lobby __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00094820 File Offset: 0x00092A20
			// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0000E5E3 File Offset: 0x0000C7E3
			public unsafe Lobby __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___3____4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr___3____4__this)) = value;
				}
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00094848 File Offset: 0x00092A48
			// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0000E5FE File Offset: 0x0000C7FE
			public unsafe int _cnt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr__cnt_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr__cnt_5__2)) = value;
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00094870 File Offset: 0x00092A70
			// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0000E619 File Offset: 0x0000C819
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Data_d__16.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04002403 RID: 9219
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002404 RID: 9220
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002405 RID: 9221
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002406 RID: 9222
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002407 RID: 9223
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x04002408 RID: 9224
			private static readonly IntPtr NativeFieldInfoPtr__cnt_5__2;

			// Token: 0x04002409 RID: 9225
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400240A RID: 9226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400240B RID: 9227
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400240C RID: 9228
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400240D RID: 9229
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0;

			// Token: 0x0400240E RID: 9230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400240F RID: 9231
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002410 RID: 9232
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

			// Token: 0x04002411 RID: 9233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020002AD RID: 685
		[ObfuscatedName("Steamworks.Data.Lobby+<get_Members>d__11")]
		public sealed class _get_Members_d__11 : Object
		{
			// Token: 0x060022D6 RID: 8918 RVA: 0x00094898 File Offset: 0x00092A98
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Members_d__11()
			{
				Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<get_Members>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr);
				Lobby._get_Members_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<>1__state");
				Lobby._get_Members_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<>2__current");
				Lobby._get_Members_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<>l__initialThreadId");
				Lobby._get_Members_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<>4__this");
				Lobby._get_Members_d__11.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<>3__<>4__this");
				Lobby._get_Members_d__11.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, "<i>5__2");
				Lobby._get_Members_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668007);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668008);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668009);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668010);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668011);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668012);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668013);
				Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr, 100668014);
			}

			// Token: 0x060022D7 RID: 8919 RVA: 0x000949DC File Offset: 0x00092BDC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Members_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby._get_Members_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022D8 RID: 8920 RVA: 0x00094A24 File Offset: 0x00092C24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D9 RID: 8921 RVA: 0x00094A58 File Offset: 0x00092C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952451, XrefRangeEnd = 952456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x060022DA RID: 8922 RVA: 0x00094A94 File Offset: 0x00092C94
			public unsafe Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022DB RID: 8923 RVA: 0x00094AD0 File Offset: 0x00092CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952456, XrefRangeEnd = 952461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x060022DC RID: 8924 RVA: 0x00094B04 File Offset: 0x00092D04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952461, XrefRangeEnd = 952464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022DD RID: 8925 RVA: 0x00094B44 File Offset: 0x00092D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952464, XrefRangeEnd = 952471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Friend> System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Friend>>(intPtr3) : null;
			}

			// Token: 0x060022DE RID: 8926 RVA: 0x00094B84 File Offset: 0x00092D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby._get_Members_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060022DF RID: 8927 RVA: 0x0000E634 File Offset: 0x0000C834
			public _get_Members_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x060022E0 RID: 8928 RVA: 0x00094BC4 File Offset: 0x00092DC4
			// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0000E63D File Offset: 0x0000C83D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x060022E2 RID: 8930 RVA: 0x00094BEC File Offset: 0x00092DEC
			// (set) Token: 0x060022E3 RID: 8931 RVA: 0x0000E658 File Offset: 0x0000C858
			public unsafe Friend __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00094C14 File Offset: 0x00092E14
			// (set) Token: 0x060022E5 RID: 8933 RVA: 0x0000E673 File Offset: 0x0000C873
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x060022E6 RID: 8934 RVA: 0x00094C3C File Offset: 0x00092E3C
			// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0000E68E File Offset: 0x0000C88E
			public unsafe Lobby __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00094C64 File Offset: 0x00092E64
			// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
			public unsafe Lobby __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___3____4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr___3____4__this)) = value;
				}
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x060022EA RID: 8938 RVA: 0x00094C8C File Offset: 0x00092E8C
			// (set) Token: 0x060022EB RID: 8939 RVA: 0x0000E6C4 File Offset: 0x0000C8C4
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby._get_Members_d__11.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002412 RID: 9234
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002413 RID: 9235
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002414 RID: 9236
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002415 RID: 9237
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002416 RID: 9238
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x04002417 RID: 9239
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002418 RID: 9240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002419 RID: 9241
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400241A RID: 9242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400241B RID: 9243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0;

			// Token: 0x0400241C RID: 9244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400241D RID: 9245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400241E RID: 9246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0;

			// Token: 0x0400241F RID: 9247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
