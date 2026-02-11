using System;
using Canis.utils.ids;
using dwd.core.platform.data;
using dwd.core.platform.providers;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

// Token: 0x0200000B RID: 11
public class FriendChatProvider : ChatProvider
{
	// Token: 0x06000057 RID: 87 RVA: 0x00011700 File Offset: 0x0000F900
	// Note: this type is marked as 'beforefieldinit'.
	static FriendChatProvider()
	{
		Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "FriendChatProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr);
		FriendChatProvider.NativeFieldInfoPtr_chats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "chats");
		FriendChatProvider.NativeFieldInfoPtr_platformProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "platformProvider");
		FriendChatProvider.NativeMethodInfoPtr_get_Chats_Public_get_IReadOnlyCollection_1_FriendChatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663345);
		FriendChatProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663346);
		FriendChatProvider.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663347);
		FriendChatProvider.NativeMethodInfoPtr_Init_Provider_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663348);
		FriendChatProvider.NativeMethodInfoPtr_PopulateAllChats_Private_Void_AllFriendChat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663349);
		FriendChatProvider.NativeMethodInfoPtr_HandleIncomingChat_Private_Void_ChatReceived_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663350);
		FriendChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663351);
		FriendChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663352);
		FriendChatProvider.NativeMethodInfoPtr_FriendToClientChatMessage_Private_Static_ClientChatMessage_FriendChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663353);
		FriendChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663354);
		FriendChatProvider.NativeMethodInfoPtr_TryGetMessages_Public_Boolean_AccountID_byref_IReadOnlyList_1_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663355);
		FriendChatProvider.NativeMethodInfoPtr_TryGetLastViewedTimestamp_Public_Boolean_AccountID_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663356);
		FriendChatProvider.NativeMethodInfoPtr_SetLastViewedTimestamp_Public_Void_AccountID_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663357);
		FriendChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663358);
		FriendChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663359);
		FriendChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663360);
		FriendChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663361);
		FriendChatProvider.NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663362);
		FriendChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, 100663363);
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000058 RID: 88 RVA: 0x000118D4 File Offset: 0x0000FAD4
	public unsafe IReadOnlyCollection<FriendChatProvider.FriendChatInfo> Chats
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982402, RefRangeEnd = 982403, XrefRangeStart = 982398, XrefRangeEnd = 982402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_get_Chats_Public_get_IReadOnlyCollection_1_FriendChatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<FriendChatProvider.FriendChatInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00011914 File Offset: 0x0000FB14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982409, RefRangeEnd = 982410, XrefRangeStart = 982403, XrefRangeEnd = 982409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00011948 File Offset: 0x0000FB48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982409, RefRangeEnd = 982410, XrefRangeStart = 982409, XrefRangeEnd = 982410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0001197C File Offset: 0x0000FB7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982410, XrefRangeEnd = 982415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Init_Provider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_Init_Provider_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000119BC File Offset: 0x0000FBBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982415, XrefRangeEnd = 982484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateAllChats(AllFriendChat chat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_PopulateAllChats_Private_Void_AllFriendChat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00011A00 File Offset: 0x0000FC00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982484, XrefRangeEnd = 982504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleIncomingChat(ChatReceived chat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_HandleIncomingChat_Private_Void_ChatReceived_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00011A44 File Offset: 0x0000FC44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982504, XrefRangeEnd = 982506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void getInitialChatMessages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00011A80 File Offset: 0x0000FC80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982506, XrefRangeEnd = 982510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ClientChatMessage convertToClientChatMessage(Object incomingMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00011ADC File Offset: 0x0000FCDC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 982524, RefRangeEnd = 982526, XrefRangeStart = 982510, XrefRangeEnd = 982524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ClientChatMessage FriendToClientChatMessage(FriendChatMessage friendChatMessage)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendChatMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_FriendToClientChatMessage_Private_Static_ClientChatMessage_FriendChatMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00011B20 File Offset: 0x0000FD20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982560, RefRangeEnd = 982561, XrefRangeStart = 982526, XrefRangeEnd = 982560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChatMessage(string rawMessage, AccountID toID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rawMessage);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toID);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00011B74 File Offset: 0x0000FD74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982561, XrefRangeEnd = 982565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetMessages(AccountID friendID, out IReadOnlyList<ClientChatMessage> messages)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendID);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_TryGetMessages_Public_Boolean_AccountID_byref_IReadOnlyList_1_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		messages = ((intPtr4 == 0) ? null : new IReadOnlyList<ClientChatMessage>(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00011BE4 File Offset: 0x0000FDE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982565, XrefRangeEnd = 982568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetLastViewedTimestamp(AccountID friendID, out long lastViewedTimestamp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastViewedTimestamp;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_TryGetLastViewedTimestamp_Public_Boolean_AccountID_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00011C40 File Offset: 0x0000FE40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982568, XrefRangeEnd = 982578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLastViewedTimestamp(AccountID friendID, long lastViewedTimestamp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastViewedTimestamp;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr_SetLastViewedTimestamp_Public_Void_AccountID_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00011C90 File Offset: 0x0000FE90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982578, XrefRangeEnd = 982601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Object convertToOutgoingChatMessage(ClientChatMessage clientMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00011CEC File Offset: 0x0000FEEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982601, XrefRangeEnd = 982606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void addChatMessage(Object outgoingMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outgoingMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00011D3C File Offset: 0x0000FF3C
	[CallerCount(0)]
	public unsafe override long getTimestamp(Object timestampedMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(timestampedMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00011D94 File Offset: 0x0000FF94
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void StoreMostRecentTimestamp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00011DD0 File Offset: 0x0000FFD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982606, XrefRangeEnd = 982631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatProvider.NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00011E0C File Offset: 0x0001000C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982631, XrefRangeEnd = 982642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendChatProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000022D0 File Offset: 0x000004D0
	public FriendChatProvider(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00011E48 File Offset: 0x00010048
	// (set) Token: 0x0600006D RID: 109 RVA: 0x000022D9 File Offset: 0x000004D9
	public unsafe VersionedMap<string, FriendChatProvider.FriendChatInfo> chats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.NativeFieldInfoPtr_chats);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<string, FriendChatProvider.FriendChatInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.NativeFieldInfoPtr_chats), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00011E78 File Offset: 0x00010078
	// (set) Token: 0x0600006F RID: 111 RVA: 0x000022F8 File Offset: 0x000004F8
	public unsafe PlatformProvider platformProvider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.NativeFieldInfoPtr_platformProvider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.NativeFieldInfoPtr_platformProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeFieldInfoPtr_chats;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeFieldInfoPtr_platformProvider;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_get_Chats_Public_get_IReadOnlyCollection_1_FriendChatInfo_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_Init_Provider_Private_IEnumerator_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_PopulateAllChats_Private_Void_AllFriendChat_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingChat_Private_Void_ChatReceived_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_FriendToClientChatMessage_Private_Static_ClientChatMessage_FriendChatMessage_0;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr_AddChatMessage_Public_Void_String_AccountID_0;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeMethodInfoPtr_TryGetMessages_Public_Boolean_AccountID_byref_IReadOnlyList_1_ClientChatMessage_0;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeMethodInfoPtr_TryGetLastViewedTimestamp_Public_Boolean_AccountID_byref_Int64_0;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_SetLastViewedTimestamp_Public_Void_AccountID_Int64_0;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018C RID: 396
	public class FriendChatInfo : Object
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0004CE4C File Offset: 0x0004B04C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendChatInfo()
		{
			Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "FriendChatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr);
			FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr, "messages");
			FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_lastViewedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr, "lastViewedTimestamp");
			FriendChatProvider.FriendChatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr, 100663364);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 982360, RefRangeEnd = 982364, XrefRangeStart = 982352, XrefRangeEnd = 982360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendChatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatProvider.FriendChatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.FriendChatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0000B086 File Offset: 0x00009286
		public FriendChatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0000B08F File Offset: 0x0000928F
		public unsafe List<ClientChatMessage> messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0004CF20 File Offset: 0x0004B120
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000B0AE File Offset: 0x000092AE
		public unsafe long lastViewedTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_lastViewedTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider.FriendChatInfo.NativeFieldInfoPtr_lastViewedTimestamp)) = value;
			}
		}

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_messages;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_lastViewedTimestamp;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x0200018D RID: 397
	[ObfuscatedName("FriendChatProvider+<>O")]
	public static class __O : Object
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x0000B0C9 File Offset: 0x000092C9
		// Note: this type is marked as 'beforefieldinit'.
		static __O()
		{
			Il2CppClassPointerStore<FriendChatProvider.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "<>O");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatProvider.__O>.NativeClassPtr);
			FriendChatProvider.__O.NativeFieldInfoPtr__0___FriendToClientChatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider.__O>.NativeClassPtr, "<0>__FriendToClientChatMessage");
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0000B0FD File Offset: 0x000092FD
		public __O(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0004CF48 File Offset: 0x0004B148
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0000B106 File Offset: 0x00009306
		public unsafe static Func<FriendChatMessage, ClientChatMessage> _0___FriendToClientChatMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FriendChatProvider.__O.NativeFieldInfoPtr__0___FriendToClientChatMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FriendChatMessage, ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendChatProvider.__O.NativeFieldInfoPtr__0___FriendToClientChatMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr__0___FriendToClientChatMessage;
	}

	// Token: 0x0200018E RID: 398
	[ObfuscatedName("FriendChatProvider+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x0004CF70 File Offset: 0x0004B170
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr);
			FriendChatProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr, "<>9");
			FriendChatProvider.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr, "<>9__8_0");
			FriendChatProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr, 100663366);
			FriendChatProvider.__c.NativeMethodInfoPtr__PopulateAllChats_b__8_0_Internal_Int64_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr, 100663367);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0004CFEC File Offset: 0x0004B1EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatProvider.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0004D028 File Offset: 0x0004B228
		[CallerCount(0)]
		public unsafe long _PopulateAllChats_b__8_0(ClientChatMessage m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider.__c.NativeMethodInfoPtr__PopulateAllChats_b__8_0_Internal_Int64_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0000B118 File Offset: 0x00009318
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0004D078 File Offset: 0x0004B278
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000B121 File Offset: 0x00009321
		public unsafe static FriendChatProvider.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FriendChatProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatProvider.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendChatProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0004D0A0 File Offset: 0x0004B2A0
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000B133 File Offset: 0x00009333
		public unsafe static Func<ClientChatMessage, long> __9__8_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FriendChatProvider.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClientChatMessage, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendChatProvider.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr__PopulateAllChats_b__8_0_Internal_Int64_ClientChatMessage_0;
	}

	// Token: 0x0200018F RID: 399
	[ObfuscatedName("FriendChatProvider+<Init_Provider>d__7")]
	public sealed class _Init_Provider_d__7 : Object
	{
		// Token: 0x0600136E RID: 4974 RVA: 0x0004D0C8 File Offset: 0x0004B2C8
		// Note: this type is marked as 'beforefieldinit'.
		static _Init_Provider_d__7()
		{
			Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatProvider>.NativeClassPtr, "<Init_Provider>d__7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr);
			FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, "<>1__state");
			FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, "<>2__current");
			FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, "<>4__this");
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663368);
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663369);
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663370);
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663371);
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663372);
			FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0004D1A8 File Offset: 0x0004B3A8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Init_Provider_d__7(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatProvider._Init_Provider_d__7>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0004D224 File Offset: 0x0004B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982364, XrefRangeEnd = 982393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0004D260 File Offset: 0x0004B460
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0004D2A0 File Offset: 0x0004B4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982393, XrefRangeEnd = 982398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatProvider._Init_Provider_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0000B145 File Offset: 0x00009345
		public _Init_Provider_d__7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0004D314 File Offset: 0x0004B514
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000B14E File Offset: 0x0000934E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0004D33C File Offset: 0x0004B53C
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000B169 File Offset: 0x00009369
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0004D36C File Offset: 0x0004B56C
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0000B188 File Offset: 0x00009388
		public unsafe FriendChatProvider __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatProvider._Init_Provider_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
