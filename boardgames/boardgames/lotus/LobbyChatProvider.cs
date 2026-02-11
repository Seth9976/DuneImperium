using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using platform.websocket;

namespace lotus
{
	// Token: 0x020000BC RID: 188
	public class LobbyChatProvider : ChatProvider
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x0002ED28 File Offset: 0x0002CF28
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatProvider()
		{
			Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "LobbyChatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr);
			LobbyChatProvider.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, "socket");
			LobbyChatProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664772);
			LobbyChatProvider.NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664773);
			LobbyChatProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664774);
			LobbyChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664775);
			LobbyChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664776);
			LobbyChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664777);
			LobbyChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664778);
			LobbyChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664779);
			LobbyChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664780);
			LobbyChatProvider.NativeMethodInfoPtr_retrieveMostRecentTimestamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664781);
			LobbyChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr, 100664782);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0002EE48 File Offset: 0x0002D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992553, XrefRangeEnd = 992560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002EE7C File Offset: 0x0002D07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992562, RefRangeEnd = 992563, XrefRangeStart = 992560, XrefRangeEnd = 992562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(DWDWebSocket<NetworkMessageEvent> socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatProvider.NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992563, XrefRangeEnd = 992573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void getInitialChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0002EF30 File Offset: 0x0002D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992573, XrefRangeEnd = 992593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ClientChatMessage convertToClientChatMessage(Object incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002EF8C File Offset: 0x0002D18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992593, XrefRangeEnd = 992606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object convertToOutgoingChatMessage(ClientChatMessage clientMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992606, XrefRangeEnd = 992620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addChatMessage(Object outgoingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outgoingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0002F038 File Offset: 0x0002D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992620, XrefRangeEnd = 992626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long getTimestamp(Object timestampedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timestampedMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0002F090 File Offset: 0x0002D290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992626, XrefRangeEnd = 992634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StoreMostRecentTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void retrieveMostRecentTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatProvider.NativeMethodInfoPtr_retrieveMostRecentTimestamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002F100 File Offset: 0x0002D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992634, XrefRangeEnd = 992638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyChatProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyChatProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000064BB File Offset: 0x000046BB
		public LobbyChatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0002F13C File Offset: 0x0002D33C
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000064C4 File Offset: 0x000046C4
		public unsafe DWDWebSocket<NetworkMessageEvent> socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatProvider.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<NetworkMessageEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyChatProvider.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_DWDWebSocket_1_NetworkMessageEvent_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_retrieveMostRecentTimestamp_Private_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
