using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using platform.websocket;

namespace boardgames.menus
{
	// Token: 0x0200014B RID: 331
	public class GameLobbyChatProvider : ChatProvider
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x00045020 File Offset: 0x00043220
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyChatProvider()
		{
			Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus", "GameLobbyChatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr);
			GameLobbyChatProvider.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, "gameID");
			GameLobbyChatProvider.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, "socket");
			GameLobbyChatProvider.NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665774);
			GameLobbyChatProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665775);
			GameLobbyChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665776);
			GameLobbyChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665777);
			GameLobbyChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665778);
			GameLobbyChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665779);
			GameLobbyChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665780);
			GameLobbyChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665781);
			GameLobbyChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr, 100665782);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0004512C File Offset: 0x0004332C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 999561, RefRangeEnd = 999562, XrefRangeStart = 999557, XrefRangeEnd = 999561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(DWDWebSocket<NetworkMessageEvent> socket, GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyChatProvider.NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00045180 File Offset: 0x00043380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyChatProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000451B4 File Offset: 0x000433B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void getInitialChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000451F0 File Offset: 0x000433F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999562, XrefRangeEnd = 999582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ClientChatMessage convertToClientChatMessage(Object incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0004524C File Offset: 0x0004344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999582, XrefRangeEnd = 999595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object convertToOutgoingChatMessage(ClientChatMessage clientMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x000452A8 File Offset: 0x000434A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999595, XrefRangeEnd = 999609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addChatMessage(Object outgoingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outgoingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000452F8 File Offset: 0x000434F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999609, XrefRangeEnd = 999613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long getTimestamp(Object timestampedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timestampedMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999613, XrefRangeEnd = 999614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StoreMostRecentTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLobbyChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0004538C File Offset: 0x0004358C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999614, XrefRangeEnd = 999618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLobbyChatProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbyChatProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00009DC5 File Offset: 0x00007FC5
		public GameLobbyChatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000453C8 File Offset: 0x000435C8
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00009DCE File Offset: 0x00007FCE
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatProvider.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatProvider.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x000453F8 File Offset: 0x000435F8
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x00009DED File Offset: 0x00007FED
		public unsafe DWDWebSocket<NetworkMessageEvent> socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatProvider.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLobbyChatProvider.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_GameID_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
