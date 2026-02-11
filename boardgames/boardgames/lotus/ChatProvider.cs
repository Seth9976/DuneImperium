using System;
using Canis.game.messages.chat;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lobbychat.data;
using Networking.lobby.chat.responses;
using UnityEngine;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x020000AC RID: 172
	public class ChatProvider : MonoBehaviour
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x0002AEA4 File Offset: 0x000290A4
		// Note: this type is marked as 'beforefieldinit'.
		static ChatProvider()
		{
			Il2CppClassPointerStore<ChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr);
			ChatProvider.NativeFieldInfoPtr_chatProvidersRegistrar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "chatProvidersRegistrar");
			ChatProvider.NativeFieldInfoPtr_OnChatMessageAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "OnChatMessageAdded");
			ChatProvider.NativeFieldInfoPtr__Messages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "<Messages>k__BackingField");
			ChatProvider.NativeFieldInfoPtr_preInitMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "preInitMessages");
			ChatProvider.NativeFieldInfoPtr__account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "_account");
			ChatProvider.NativeFieldInfoPtr__MostRecentTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "<MostRecentTimestamp>k__BackingField");
			ChatProvider.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "<Initialized>k__BackingField");
			ChatProvider.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, "<Version>k__BackingField");
			ChatProvider.NativeMethodInfoPtr_get_Messages_Public_get_VersionedList_1_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664589);
			ChatProvider.NativeMethodInfoPtr_get_account_Protected_get_AccountProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664590);
			ChatProvider.NativeMethodInfoPtr_get_MostRecentTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664591);
			ChatProvider.NativeMethodInfoPtr_set_MostRecentTimestamp_Protected_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664592);
			ChatProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664593);
			ChatProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664594);
			ChatProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664595);
			ChatProvider.NativeMethodInfoPtr_set_Version_Protected_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664596);
			ChatProvider.NativeMethodInfoPtr_Init_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664597);
			ChatProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664598);
			ChatProvider.NativeMethodInfoPtr_GetChatMessages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664599);
			ChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664600);
			ChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664601);
			ChatProvider.NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_LobbyChatMessages_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664602);
			ChatProvider.NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_GameLobbyChatMessages_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664603);
			ChatProvider.NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_LobbyChatMessageAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664604);
			ChatProvider.NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_GameLobbyChatMessageAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664605);
			ChatProvider.NativeMethodInfoPtr_ChatMessageAdded_Public_Void_GameChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664606);
			ChatProvider.NativeMethodInfoPtr_ChatMessageAdded_Public_Void_ChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664607);
			ChatProvider.NativeMethodInfoPtr_IncrementVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664608);
			ChatProvider.NativeMethodInfoPtr_UpdateChatProviderRegistrarVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664609);
			ChatProvider.NativeMethodInfoPtr_ClientChatMessageAdded_Public_Virtual_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664610);
			ChatProvider.NativeMethodInfoPtr_ShowChatUI_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664611);
			ChatProvider.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664612);
			ChatProvider.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664613);
			ChatProvider.NativeMethodInfoPtr_chatMessageAdded_Protected_Virtual_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664614);
			ChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664615);
			ChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Abstract_Virtual_New_ClientChatMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664616);
			ChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Abstract_Virtual_New_Object_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664617);
			ChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664618);
			ChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Abstract_Virtual_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664619);
			ChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664620);
			ChatProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr, 100664621);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002B208 File Offset: 0x00029408
		public unsafe VersionedList<ClientChatMessage> Messages
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_get_Messages_Public_get_VersionedList_1_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionedList<ClientChatMessage>>(intPtr3) : null;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0002B248 File Offset: 0x00029448
		public unsafe AccountProvider account
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 991436, RefRangeEnd = 991437, XrefRangeStart = 991430, XrefRangeEnd = 991436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_get_account_Protected_get_AccountProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002B288 File Offset: 0x00029488
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0002B2C4 File Offset: 0x000294C4
		public unsafe long MostRecentTimestamp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_get_MostRecentTimestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_set_MostRecentTimestamp_Protected_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002B304 File Offset: 0x00029504
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0002B340 File Offset: 0x00029540
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002B380 File Offset: 0x00029580
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0002B3BC File Offset: 0x000295BC
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_set_Version_Protected_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0002B3FC File Offset: 0x000295FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 991463, RefRangeEnd = 991467, XrefRangeStart = 991437, XrefRangeEnd = 991463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_Init_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0002B430 File Offset: 0x00029630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991474, RefRangeEnd = 991476, XrefRangeStart = 991467, XrefRangeEnd = 991474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0002B464 File Offset: 0x00029664
		[CallerCount(0)]
		public unsafe void GetChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_GetChatMessages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0002B498 File Offset: 0x00029698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991516, RefRangeEnd = 991517, XrefRangeStart = 991476, XrefRangeEnd = 991516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChatMessage(string rawMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0002B4DC File Offset: 0x000296DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991517, RefRangeEnd = 991519, XrefRangeStart = 991517, XrefRangeEnd = 991517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChatMessage(ClientChatMessage clientMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_AddChatMessage_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0002B520 File Offset: 0x00029720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991519, XrefRangeEnd = 991520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChatMessagesAdded(LobbyChatMessages lobbyChatMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lobbyChatMessages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_LobbyChatMessages_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0002B564 File Offset: 0x00029764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChatMessagesAdded(GameLobbyChatMessages lobbyChatMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lobbyChatMessages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_GameLobbyChatMessages_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991520, XrefRangeEnd = 991527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyChatMessageAdded(LobbyChatMessageAdded incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_LobbyChatMessageAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002B5EC File Offset: 0x000297EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991527, XrefRangeEnd = 991534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyChatMessageAdded(GameLobbyChatMessageAdded incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_GameLobbyChatMessageAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0002B630 File Offset: 0x00029830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991534, RefRangeEnd = 991536, XrefRangeStart = 991534, XrefRangeEnd = 991534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChatMessageAdded(GameChatMessage gameMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_ChatMessageAdded_Public_Void_GameChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0002B674 File Offset: 0x00029874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991534, RefRangeEnd = 991536, XrefRangeStart = 991534, XrefRangeEnd = 991536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChatMessageAdded(ChatMessage incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_ChatMessageAdded_Public_Void_ChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0002B6B8 File Offset: 0x000298B8
		[CallerCount(0)]
		public unsafe void IncrementVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_IncrementVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0002B6EC File Offset: 0x000298EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991554, RefRangeEnd = 991555, XrefRangeStart = 991536, XrefRangeEnd = 991554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChatProviderRegistrarVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_UpdateChatProviderRegistrarVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0002B720 File Offset: 0x00029920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991555, XrefRangeEnd = 991571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClientChatMessageAdded(ClientChatMessage incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_ClientChatMessageAdded_Public_Virtual_New_Void_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0002B770 File Offset: 0x00029970
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowChatUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_ShowChatUI_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0002B7B8 File Offset: 0x000299B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 991474, RefRangeEnd = 991476, XrefRangeStart = 991474, XrefRangeEnd = 991476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0002B7EC File Offset: 0x000299EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0002B828 File Offset: 0x00029A28
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void chatMessageAdded(ClientChatMessage incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_chatMessageAdded_Protected_Virtual_New_Void_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0002B878 File Offset: 0x00029A78
		[CallerCount(0)]
		public unsafe virtual void getInitialChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0002B8B4 File Offset: 0x00029AB4
		[CallerCount(0)]
		public unsafe virtual ClientChatMessage convertToClientChatMessage(global::Il2CppSystem.Object incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Abstract_Virtual_New_ClientChatMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0002B910 File Offset: 0x00029B10
		[CallerCount(0)]
		public unsafe virtual global::Il2CppSystem.Object convertToOutgoingChatMessage(ClientChatMessage clientMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Abstract_Virtual_New_Object_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0002B96C File Offset: 0x00029B6C
		[CallerCount(0)]
		public unsafe virtual void addChatMessage(global::Il2CppSystem.Object outgoingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outgoingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0002B9BC File Offset: 0x00029BBC
		[CallerCount(0)]
		public unsafe virtual long getTimestamp(global::Il2CppSystem.Object timestampedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timestampedMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Abstract_Virtual_New_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0002BA14 File Offset: 0x00029C14
		[CallerCount(0)]
		public unsafe virtual void StoreMostRecentTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0002BA50 File Offset: 0x00029C50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 991591, RefRangeEnd = 991595, XrefRangeStart = 991571, XrefRangeEnd = 991591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00005C04 File Offset: 0x00003E04
		public ChatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0002BA8C File Offset: 0x00029C8C
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00005C0D File Offset: 0x00003E0D
		public unsafe static List<ChatProvider> chatProvidersRegistrar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChatProvider.NativeFieldInfoPtr_chatProvidersRegistrar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChatProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatProvider.NativeFieldInfoPtr_chatProvidersRegistrar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00005C1F File Offset: 0x00003E1F
		public unsafe UnityEvent<ClientChatMessage> OnChatMessageAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr_OnChatMessageAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr_OnChatMessageAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0002BAE4 File Offset: 0x00029CE4
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00005C3E File Offset: 0x00003E3E
		public unsafe VersionedList<ClientChatMessage> _Messages_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Messages_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Messages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0002BB14 File Offset: 0x00029D14
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00005C5D File Offset: 0x00003E5D
		public unsafe VersionedList<ClientChatMessage> preInitMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr_preInitMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr_preInitMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002BB44 File Offset: 0x00029D44
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00005C7C File Offset: 0x00003E7C
		public unsafe AccountProvider _account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__account);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__account), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0002BB74 File Offset: 0x00029D74
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00005C9B File Offset: 0x00003E9B
		public unsafe long _MostRecentTimestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__MostRecentTimestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__MostRecentTimestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002BB9C File Offset: 0x00029D9C
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00005CB6 File Offset: 0x00003EB6
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00005CD1 File Offset: 0x00003ED1
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatProvider.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_chatProvidersRegistrar;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_OnChatMessageAdded;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr__Messages_k__BackingField;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_preInitMessages;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr__account;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr__MostRecentTimestamp_k__BackingField;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_get_Messages_Public_get_VersionedList_1_ClientChatMessage_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_account_Protected_get_AccountProvider_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_MostRecentTimestamp_Public_get_Int64_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_set_MostRecentTimestamp_Protected_set_Void_Int64_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Protected_set_Void_UInt64_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_GetChatMessages_Private_Void_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_AddChatMessage_Public_Void_String_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_AddChatMessage_Public_Void_ClientChatMessage_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_LobbyChatMessages_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_ChatMessagesAdded_Public_Void_GameLobbyChatMessages_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_LobbyChatMessageAdded_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_LobbyChatMessageAdded_Public_Void_GameLobbyChatMessageAdded_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_ChatMessageAdded_Public_Void_GameChatMessage_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_ChatMessageAdded_Public_Void_ChatMessage_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_IncrementVersion_Public_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChatProviderRegistrarVersion_Public_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_ClientChatMessageAdded_Public_Virtual_New_Void_ClientChatMessage_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_ShowChatUI_Public_Virtual_New_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_chatMessageAdded_Protected_Virtual_New_Void_ClientChatMessage_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_getInitialChatMessages_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_convertToClientChatMessage_Protected_Abstract_Virtual_New_ClientChatMessage_Object_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Abstract_Virtual_New_Object_ClientChatMessage_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_addChatMessage_Protected_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_getTimestamp_Protected_Abstract_Virtual_New_Int64_Object_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
