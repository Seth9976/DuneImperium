using System;
using Canis.boardgames;
using Canis.game.messages.chat;
using Canis.utils.ids;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x020000B8 RID: 184
	public class GameChatProvider : ChatProvider
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0002E48C File Offset: 0x0002C68C
		// Note: this type is marked as 'beforefieldinit'.
		static GameChatProvider()
		{
			Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "GameChatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr);
			GameChatProvider.NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, "session");
			GameChatProvider.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, "match");
			GameChatProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664742);
			GameChatProvider.NativeMethodInfoPtr_chatAvailable_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664743);
			GameChatProvider.NativeMethodInfoPtr_ShowChatUI_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664744);
			GameChatProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664745);
			GameChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664746);
			GameChatProvider.NativeMethodInfoPtr_handleChatMessages_Private_Void_GameChatMessages_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664747);
			GameChatProvider.NativeMethodInfoPtr_handleChatAdded_Private_Void_GameChatAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664748);
			GameChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664749);
			GameChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664750);
			GameChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664751);
			GameChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664752);
			GameChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664753);
			GameChatProvider.NativeMethodInfoPtr_TryGetRecentGameChatTimestamp_Public_Static_Boolean_GameID_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664754);
			GameChatProvider.NativeMethodInfoPtr_StoreRecentGameChatTimestamp_Public_Static_Void_GameID_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664755);
			GameChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, 100664756);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002E610 File Offset: 0x0002C810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992346, XrefRangeEnd = 992351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002E650 File Offset: 0x0002C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992351, XrefRangeEnd = 992360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool chatAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_chatAvailable_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002E698 File Offset: 0x0002C898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992360, RefRangeEnd = 992361, XrefRangeStart = 992360, XrefRangeEnd = 992360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowChatUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_ShowChatUI_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992361, XrefRangeEnd = 992380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002E714 File Offset: 0x0002C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992380, XrefRangeEnd = 992403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void getInitialChatMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002E750 File Offset: 0x0002C950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992403, XrefRangeEnd = 992418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleChatMessages(GameChatMessages messages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_handleChatMessages_Private_Void_GameChatMessages_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002E794 File Offset: 0x0002C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992418, XrefRangeEnd = 992419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleChatAdded(GameChatAdded message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_handleChatAdded_Private_Void_GameChatAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992419, XrefRangeEnd = 992430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ClientChatMessage convertToClientChatMessage(Object incomingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002E834 File Offset: 0x0002CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992430, XrefRangeEnd = 992438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object convertToOutgoingChatMessage(ClientChatMessage clientMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0002E890 File Offset: 0x0002CA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992438, XrefRangeEnd = 992450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addChatMessage(Object outgoingMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outgoingMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992450, XrefRangeEnd = 992453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long getTimestamp(Object timestampedMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timestampedMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0002E938 File Offset: 0x0002CB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992453, XrefRangeEnd = 992456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StoreMostRecentTimestamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameChatProvider.NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0002E974 File Offset: 0x0002CB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992470, RefRangeEnd = 992471, XrefRangeStart = 992456, XrefRangeEnd = 992470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetRecentGameChatTimestamp(GameID gameID, out long mostRecentTimestamp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mostRecentTimestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_TryGetRecentGameChatTimestamp_Public_Static_Boolean_GameID_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0002E9C4 File Offset: 0x0002CBC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 992546, RefRangeEnd = 992548, XrefRangeStart = 992471, XrefRangeEnd = 992546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StoreRecentGameChatTimestamp(GameID gameID, long mostRecentTimestamp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mostRecentTimestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr_StoreRecentGameChatTimestamp_Public_Static_Void_GameID_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002EA08 File Offset: 0x0002CC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992552, RefRangeEnd = 992553, XrefRangeStart = 992548, XrefRangeEnd = 992552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameChatProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000642A File Offset: 0x0000462A
		public GameChatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002EA44 File Offset: 0x0002CC44
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00006433 File Offset: 0x00004633
		public unsafe SessionProvider session
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider.NativeFieldInfoPtr_session);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider.NativeFieldInfoPtr_session), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002EA74 File Offset: 0x0002CC74
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00006452 File Offset: 0x00004652
		public unsafe CanisMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_session;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_chatAvailable_Protected_Virtual_New_Boolean_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_ShowChatUI_Public_Virtual_Boolean_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_getInitialChatMessages_Protected_Virtual_Void_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_handleChatMessages_Private_Void_GameChatMessages_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_handleChatAdded_Private_Void_GameChatAdded_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_convertToClientChatMessage_Protected_Virtual_ClientChatMessage_Object_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_convertToOutgoingChatMessage_Protected_Virtual_Object_ClientChatMessage_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_addChatMessage_Protected_Virtual_Void_Object_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_getTimestamp_Protected_Virtual_Int64_Object_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_StoreMostRecentTimestamp_Public_Virtual_Void_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_TryGetRecentGameChatTimestamp_Public_Static_Boolean_GameID_byref_Int64_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_StoreRecentGameChatTimestamp_Public_Static_Void_GameID_Int64_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000223 RID: 547
		[ObfuscatedName("lotus.GameChatProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600192D RID: 6445 RVA: 0x0005F16C File Offset: 0x0005D36C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr);
				GameChatProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr, "<>9");
				GameChatProvider.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr, "<>9__15_0");
				GameChatProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr, 100664758);
				GameChatProvider.__c.NativeMethodInfoPtr__StoreRecentGameChatTimestamp_b__15_0_Internal_Int64_KeyValuePair_2_GameID_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr, 100664759);
			}

			// Token: 0x0600192E RID: 6446 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600192F RID: 6447 RVA: 0x0005F224 File Offset: 0x0005D424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992311, XrefRangeEnd = 992312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _StoreRecentGameChatTimestamp_b__15_0(KeyValuePair<GameID, long> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(t));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider.__c.NativeMethodInfoPtr__StoreRecentGameChatTimestamp_b__15_0_Internal_Int64_KeyValuePair_2_GameID_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001930 RID: 6448 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06001931 RID: 6449 RVA: 0x0005F278 File Offset: 0x0005D478
			// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000DBD1 File Offset: 0x0000BDD1
			public unsafe static GameChatProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameChatProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameChatProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameChatProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06001933 RID: 6451 RVA: 0x0005F2A0 File Offset: 0x0005D4A0
			// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000DBE3 File Offset: 0x0000BDE3
			public unsafe static Func<KeyValuePair<GameID, long>, long> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameChatProvider.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<GameID, long>, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameChatProvider.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F40 RID: 3904
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000F41 RID: 3905
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04000F42 RID: 3906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F43 RID: 3907
			private static readonly IntPtr NativeMethodInfoPtr__StoreRecentGameChatTimestamp_b__15_0_Internal_Int64_KeyValuePair_2_GameID_Int64_0;
		}

		// Token: 0x02000224 RID: 548
		[ObfuscatedName("lotus.GameChatProvider+<Start>d__2")]
		public sealed class _Start_d__2 : Object
		{
			// Token: 0x06001935 RID: 6453 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameChatProvider>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr);
				GameChatProvider._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, "<>1__state");
				GameChatProvider._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, "<>2__current");
				GameChatProvider._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, "<>4__this");
				GameChatProvider._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664760);
				GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664761);
				GameChatProvider._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664762);
				GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664763);
				GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664764);
				GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr, 100664765);
			}

			// Token: 0x06001936 RID: 6454 RVA: 0x0005F3A8 File Offset: 0x0005D5A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatProvider._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001937 RID: 6455 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001938 RID: 6456 RVA: 0x0005F424 File Offset: 0x0005D624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992312, XrefRangeEnd = 992341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06001939 RID: 6457 RVA: 0x0005F460 File Offset: 0x0005D660
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600193A RID: 6458 RVA: 0x0005F4A0 File Offset: 0x0005D6A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992341, XrefRangeEnd = 992346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x0600193B RID: 6459 RVA: 0x0005F4D4 File Offset: 0x0005D6D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatProvider._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600193C RID: 6460 RVA: 0x0000DBF5 File Offset: 0x0000BDF5
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x0600193D RID: 6461 RVA: 0x0005F514 File Offset: 0x0005D714
			// (set) Token: 0x0600193E RID: 6462 RVA: 0x0000DBFE File Offset: 0x0000BDFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x0600193F RID: 6463 RVA: 0x0005F53C File Offset: 0x0005D73C
			// (set) Token: 0x06001940 RID: 6464 RVA: 0x0000DC19 File Offset: 0x0000BE19
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06001941 RID: 6465 RVA: 0x0005F56C File Offset: 0x0005D76C
			// (set) Token: 0x06001942 RID: 6466 RVA: 0x0000DC38 File Offset: 0x0000BE38
			public unsafe GameChatProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameChatProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatProvider._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F44 RID: 3908
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F45 RID: 3909
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F46 RID: 3910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F47 RID: 3911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F48 RID: 3912
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F49 RID: 3913
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F4A RID: 3914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F4B RID: 3915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F4C RID: 3916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
