using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using NativeWebSocket;
using Networking.service;
using platform.websocket;
using UnityEngine;
using zen.src.menus;

namespace boardgames.match
{
	// Token: 0x02000128 RID: 296
	public sealed class CanisNetworkState : global::Il2CppSystem.Object
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
		// Note: this type is marked as 'beforefieldinit'.
		static CanisNetworkState()
		{
			Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match", "CanisNetworkState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr);
			CanisNetworkState.NativeFieldInfoPtr_OnErrorDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "OnErrorDisconnect");
			CanisNetworkState.NativeFieldInfoPtr_MAX_RECONNECT_MILLISECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "MAX_RECONNECT_MILLISECONDS");
			CanisNetworkState.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "socket");
			CanisNetworkState.NativeFieldInfoPtr_messagesToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "messagesToProcess");
			CanisNetworkState.NativeFieldInfoPtr_websocketMessageQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "websocketMessageQueue");
			CanisNetworkState.NativeFieldInfoPtr_makeJoinGameMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "makeJoinGameMessage");
			CanisNetworkState.NativeFieldInfoPtr_makeReconnectMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "makeReconnectMessage");
			CanisNetworkState.NativeFieldInfoPtr__ServerTimeOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<ServerTimeOffset>k__BackingField");
			CanisNetworkState.NativeFieldInfoPtr__socketErrorLeavePlaymat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<socketErrorLeavePlaymat>k__BackingField");
			CanisNetworkState.NativeFieldInfoPtr__ConnectivityIcon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<ConnectivityIcon>k__BackingField");
			CanisNetworkState.NativeFieldInfoPtr_startReconnectTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "startReconnectTime");
			CanisNetworkState.NativeFieldInfoPtr__runRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "_runRoutine");
			CanisNetworkState.NativeFieldInfoPtr__gameErrorMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<gameErrorMessage>k__BackingField");
			CanisNetworkState.NativeFieldInfoPtr__GameServerClosed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<GameServerClosed>k__BackingField");
			CanisNetworkState.NativeFieldInfoPtr_minimumNetworkLostTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "minimumNetworkLostTimeout");
			CanisNetworkState.NativeFieldInfoPtr_PING_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "PING_MESSAGE");
			CanisNetworkState.NativeFieldInfoPtr_PING_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "PING_DELAY");
			CanisNetworkState.NativeFieldInfoPtr_RECONNECT_LATENCY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "RECONNECT_LATENCY_THRESHOLD");
			CanisNetworkState.NativeFieldInfoPtr_reconnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "reconnecting");
			CanisNetworkState.NativeFieldInfoPtr_currentCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "currentCounter");
			CanisNetworkState.NativeFieldInfoPtr_outOfOrderMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "outOfOrderMessages");
			CanisNetworkState.NativeFieldInfoPtr_ackMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "ackMsg");
			CanisNetworkState.NativeFieldInfoPtr_clientCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "clientCounter");
			CanisNetworkState.NativeFieldInfoPtr_socketMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "socketMonitor");
			CanisNetworkState.NativeFieldInfoPtr_reconnectMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "reconnectMonitor");
			CanisNetworkState.NativeFieldInfoPtr_startReconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "startReconnect");
			CanisNetworkState.NativeFieldInfoPtr_lastServerMessageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "lastServerMessageTime");
			CanisNetworkState.NativeFieldInfoPtr_waitingForPong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "waitingForPong");
			CanisNetworkState.NativeFieldInfoPtr_reconnectsWithoutSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "reconnectsWithoutSuccess");
			CanisNetworkState.NativeFieldInfoPtr__stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "_stopped");
			CanisNetworkState.NativeMethodInfoPtr_add_OnErrorDisconnect_Public_add_Void_Action_1_ReconnectBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665462);
			CanisNetworkState.NativeMethodInfoPtr_remove_OnErrorDisconnect_Public_rem_Void_Action_1_ReconnectBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665463);
			CanisNetworkState.NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665464);
			CanisNetworkState.NativeMethodInfoPtr_set_ServerTimeOffset_Private_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665465);
			CanisNetworkState.NativeMethodInfoPtr_get_socketErrorLeavePlaymat_Public_get_ReconnectBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665466);
			CanisNetworkState.NativeMethodInfoPtr_set_socketErrorLeavePlaymat_Private_set_Void_ReconnectBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665467);
			CanisNetworkState.NativeMethodInfoPtr_get_ConnectivityIcon_Public_get_ConnectivityIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665468);
			CanisNetworkState.NativeMethodInfoPtr_set_ConnectivityIcon_Public_set_Void_ConnectivityIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665469);
			CanisNetworkState.NativeMethodInfoPtr_get_gameErrorMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665470);
			CanisNetworkState.NativeMethodInfoPtr_set_gameErrorMessage_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665471);
			CanisNetworkState.NativeMethodInfoPtr_get_Stopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665472);
			CanisNetworkState.NativeMethodInfoPtr_get_GameServerClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665473);
			CanisNetworkState.NativeMethodInfoPtr_set_GameServerClosed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665474);
			CanisNetworkState.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Dictionary_2_String_String_Object_Func_2_Dictionary_2_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665475);
			CanisNetworkState.NativeMethodInfoPtr_PeekMessage_Public_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665476);
			CanisNetworkState.NativeMethodInfoPtr_HasQueuedMessage_Public_Boolean_Func_2_DWDEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665477);
			CanisNetworkState.NativeMethodInfoPtr_GetPendingMessages_Public_Void_List_1_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665478);
			CanisNetworkState.NativeMethodInfoPtr_WriteUsingCounter_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665479);
			CanisNetworkState.NativeMethodInfoPtr_Write_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665480);
			CanisNetworkState.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665481);
			CanisNetworkState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665482);
			CanisNetworkState.NativeMethodInfoPtr_run_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665483);
			CanisNetworkState.NativeMethodInfoPtr_socketErrorRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665484);
			CanisNetworkState.NativeMethodInfoPtr_socketErrorHasOccurred_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665485);
			CanisNetworkState.NativeMethodInfoPtr_ReconnectRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665486);
			CanisNetworkState.NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665487);
			CanisNetworkState.NativeMethodInfoPtr_InitializeReconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665488);
			CanisNetworkState.NativeMethodInfoPtr_initializeReconnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665489);
			CanisNetworkState.NativeMethodInfoPtr_reconnectHasTimedOut_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665490);
			CanisNetworkState.NativeMethodInfoPtr_RequiresAck_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665491);
			CanisNetworkState.NativeMethodInfoPtr_addAckMessage_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665492);
			CanisNetworkState.NativeMethodInfoPtr_AckMessage_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665493);
			CanisNetworkState.NativeMethodInfoPtr_GetUnackedMessages_Private_IEnumerable_1_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665494);
			CanisNetworkState.NativeMethodInfoPtr_GetNextCounter_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665495);
			CanisNetworkState.NativeMethodInfoPtr_handleOpen_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665496);
			CanisNetworkState.NativeMethodInfoPtr_createSessionMetaData_Private_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665497);
			CanisNetworkState.NativeMethodInfoPtr_configureSessionMetaData_Private_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665498);
			CanisNetworkState.NativeMethodInfoPtr_handleMessage_Private_Void_ValueTuple_2_String_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665499);
			CanisNetworkState.NativeMethodInfoPtr_toggleApplicationState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665500);
			CanisNetworkState.NativeMethodInfoPtr_AskForServerTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665501);
			CanisNetworkState.NativeMethodInfoPtr__ReconnectRoutine_b__44_0_Private_ConfiguredTaskAwaitable_1_WebSocketCloseCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, 100665503);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0003FA80 File Offset: 0x0003DC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997254, RefRangeEnd = 997255, XrefRangeStart = 997249, XrefRangeEnd = 997254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnErrorDisconnect(Action<ReconnectBehaviour> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_add_OnErrorDisconnect_Public_add_Void_Action_1_ReconnectBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0003FAC4 File Offset: 0x0003DCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997255, XrefRangeEnd = 997260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnErrorDisconnect(Action<ReconnectBehaviour> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_remove_OnErrorDisconnect_Public_rem_Void_Action_1_ReconnectBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0003FB08 File Offset: 0x0003DD08
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x0003FB44 File Offset: 0x0003DD44
		public unsafe TimeSpan ServerTimeOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_set_ServerTimeOffset_Private_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0003FB84 File Offset: 0x0003DD84
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0003FBC0 File Offset: 0x0003DDC0
		public unsafe ReconnectBehaviour socketErrorLeavePlaymat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_socketErrorLeavePlaymat_Public_get_ReconnectBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_set_socketErrorLeavePlaymat_Private_set_Void_ReconnectBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0003FC00 File Offset: 0x0003DE00
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0003FC40 File Offset: 0x0003DE40
		public unsafe ConnectivityIcon ConnectivityIcon
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_ConnectivityIcon_Public_get_ConnectivityIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConnectivityIcon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_set_ConnectivityIcon_Public_set_Void_ConnectivityIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0003FC84 File Offset: 0x0003DE84
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0003FCBC File Offset: 0x0003DEBC
		public unsafe string gameErrorMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_gameErrorMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_set_gameErrorMessage_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0003FD00 File Offset: 0x0003DF00
		public unsafe bool Stopped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_Stopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x0003FD78 File Offset: 0x0003DF78
		public unsafe bool GameServerClosed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_get_GameServerClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_set_GameServerClosed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0003FDB8 File Offset: 0x0003DFB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 997351, RefRangeEnd = 997353, XrefRangeStart = 997260, XrefRangeEnd = 997351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisNetworkState(string serverUri, Func<Dictionary<string, string>, global::Il2CppSystem.Object> makeJoinGame, Func<Dictionary<string, string>, global::Il2CppSystem.Object> makeReconnect)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serverUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(makeJoinGame);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(makeReconnect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Dictionary_2_String_String_Object_Func_2_Dictionary_2_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0003FE28 File Offset: 0x0003E028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997358, RefRangeEnd = 997359, XrefRangeStart = 997353, XrefRangeEnd = 997358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDEvent PeekMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_PeekMessage_Public_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DWDEvent>(intPtr3) : null;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0003FE68 File Offset: 0x0003E068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997363, RefRangeEnd = 997364, XrefRangeStart = 997359, XrefRangeEnd = 997363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasQueuedMessage(Func<DWDEvent, bool> matcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_HasQueuedMessage_Public_Boolean_Func_2_DWDEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997372, RefRangeEnd = 997373, XrefRangeStart = 997364, XrefRangeEnd = 997372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPendingMessages(List<DWDEvent> messages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_GetPendingMessages_Public_Void_List_1_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0003FEFC File Offset: 0x0003E0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997382, RefRangeEnd = 997383, XrefRangeStart = 997373, XrefRangeEnd = 997382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUsingCounter(string counter, global::Il2CppSystem.Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(counter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_WriteUsingCounter_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0003FF50 File Offset: 0x0003E150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 997405, RefRangeEnd = 997408, XrefRangeStart = 997383, XrefRangeEnd = 997405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(global::Il2CppSystem.Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_Write_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0003FF94 File Offset: 0x0003E194
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 997415, RefRangeEnd = 997422, XrefRangeStart = 997408, XrefRangeEnd = 997415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0003FFC8 File Offset: 0x0003E1C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 997500, RefRangeEnd = 997503, XrefRangeStart = 997422, XrefRangeEnd = 997500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997503, XrefRangeEnd = 997508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_run_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004003C File Offset: 0x0003E23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997508, XrefRangeEnd = 997513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator socketErrorRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_socketErrorRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004007C File Offset: 0x0003E27C
		[CallerCount(0)]
		public unsafe bool socketErrorHasOccurred()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_socketErrorHasOccurred_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000400B8 File Offset: 0x0003E2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997513, XrefRangeEnd = 997518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ReconnectRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_ReconnectRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000400F8 File Offset: 0x0003E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997518, XrefRangeEnd = 997535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleClose(global::Il2CppSystem.Object sender, int code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00040148 File Offset: 0x0003E348
		[CallerCount(0)]
		public unsafe void InitializeReconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_InitializeReconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004017C File Offset: 0x0003E37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997535, XrefRangeEnd = 997559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializeReconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_initializeReconnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000401B0 File Offset: 0x0003E3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997559, XrefRangeEnd = 997560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool reconnectHasTimedOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_reconnectHasTimedOut_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000401EC File Offset: 0x0003E3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997586, RefRangeEnd = 997587, XrefRangeStart = 997560, XrefRangeEnd = 997586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequiresAck(global::Il2CppSystem.Object msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_RequiresAck_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00040230 File Offset: 0x0003E430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997587, XrefRangeEnd = 997591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addAckMessage(string counter, global::Il2CppSystem.Object msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(counter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_addAckMessage_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00040284 File Offset: 0x0003E484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997591, XrefRangeEnd = 997595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AckMessage(string counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(counter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_AckMessage_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000402C8 File Offset: 0x0003E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997595, XrefRangeEnd = 997616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, global::Il2CppSystem.Object>> GetUnackedMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_GetUnackedMessages_Private_IEnumerable_1_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, global::Il2CppSystem.Object>>>(intPtr3) : null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00040308 File Offset: 0x0003E508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997616, XrefRangeEnd = 997619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNextCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_GetNextCounter_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00040340 File Offset: 0x0003E540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997619, XrefRangeEnd = 997632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleOpen(global::Il2CppSystem.Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_handleOpen_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00040394 File Offset: 0x0003E594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997632, XrefRangeEnd = 997643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> createSessionMetaData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_createSessionMetaData_Private_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000403D4 File Offset: 0x0003E5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997700, RefRangeEnd = 997701, XrefRangeStart = 997643, XrefRangeEnd = 997700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void configureSessionMetaData(Dictionary<string, string> metaData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_configureSessionMetaData_Private_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00040418 File Offset: 0x0003E618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997918, RefRangeEnd = 997919, XrefRangeStart = 997701, XrefRangeEnd = 997918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleMessage(ValueTuple<string, DWDEvent> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(message));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_handleMessage_Private_Void_ValueTuple_2_String_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00040460 File Offset: 0x0003E660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997919, XrefRangeEnd = 997922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void toggleApplicationState(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_toggleApplicationState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000404A0 File Offset: 0x0003E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997922, XrefRangeEnd = 997927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AskForServerTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr_AskForServerTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000404D4 File Offset: 0x0003E6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997927, XrefRangeEnd = 997933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable<WebSocketCloseCode> _ReconnectRoutine_b__44_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.NativeMethodInfoPtr__ReconnectRoutine_b__44_0_Private_ConfiguredTaskAwaitable_1_WebSocketCloseCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable<WebSocketCloseCode>(intPtr);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00009173 File Offset: 0x00007373
		public CanisNetworkState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004050C File Offset: 0x0003E70C
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0000917C File Offset: 0x0000737C
		public unsafe Action<ReconnectBehaviour> OnErrorDisconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_OnErrorDisconnect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReconnectBehaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_OnErrorDisconnect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004053C File Offset: 0x0003E73C
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0000919B File Offset: 0x0000739B
		public unsafe static int MAX_RECONNECT_MILLISECONDS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.NativeFieldInfoPtr_MAX_RECONNECT_MILLISECONDS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.NativeFieldInfoPtr_MAX_RECONNECT_MILLISECONDS, (void*)(&value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00040558 File Offset: 0x0003E758
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000091A9 File Offset: 0x000073A9
		public unsafe DWDWebSocket<ValueTuple<string, DWDEvent>> socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDWebSocket<ValueTuple<string, DWDEvent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00040588 File Offset: 0x0003E788
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000091C8 File Offset: 0x000073C8
		public unsafe List<ValueTuple<string, DWDEvent>> messagesToProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_messagesToProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, DWDEvent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_messagesToProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000405B8 File Offset: 0x0003E7B8
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000091E7 File Offset: 0x000073E7
		public unsafe Queue<DWDEvent> websocketMessageQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_websocketMessageQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_websocketMessageQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000405E8 File Offset: 0x0003E7E8
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00009206 File Offset: 0x00007406
		public unsafe Func<Dictionary<string, string>, global::Il2CppSystem.Object> makeJoinGameMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_makeJoinGameMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<string, string>, global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_makeJoinGameMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00040618 File Offset: 0x0003E818
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00009225 File Offset: 0x00007425
		public unsafe Func<Dictionary<string, string>, global::Il2CppSystem.Object> makeReconnectMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_makeReconnectMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<string, string>, global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_makeReconnectMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00040648 File Offset: 0x0003E848
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00009244 File Offset: 0x00007444
		public unsafe TimeSpan _ServerTimeOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__ServerTimeOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__ServerTimeOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00040670 File Offset: 0x0003E870
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000925F File Offset: 0x0000745F
		public unsafe ReconnectBehaviour _socketErrorLeavePlaymat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__socketErrorLeavePlaymat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__socketErrorLeavePlaymat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00040698 File Offset: 0x0003E898
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0000927A File Offset: 0x0000747A
		public unsafe ConnectivityIcon _ConnectivityIcon_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__ConnectivityIcon_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectivityIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__ConnectivityIcon_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x000406C8 File Offset: 0x0003E8C8
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00009299 File Offset: 0x00007499
		public unsafe int startReconnectTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_startReconnectTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_startReconnectTime)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000406F0 File Offset: 0x0003E8F0
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x000092B4 File Offset: 0x000074B4
		public unsafe Coroutine _runRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__runRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__runRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00040720 File Offset: 0x0003E920
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x000092D3 File Offset: 0x000074D3
		public unsafe string _gameErrorMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__gameErrorMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__gameErrorMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00040748 File Offset: 0x0003E948
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x000092F2 File Offset: 0x000074F2
		public unsafe bool _GameServerClosed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__GameServerClosed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__GameServerClosed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00040770 File Offset: 0x0003E970
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0000930D File Offset: 0x0000750D
		public unsafe static float minimumNetworkLostTimeout
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.NativeFieldInfoPtr_minimumNetworkLostTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.NativeFieldInfoPtr_minimumNetworkLostTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0004078C File Offset: 0x0003E98C
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0000931B File Offset: 0x0000751B
		public unsafe static PingMsg PING_MESSAGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.NativeFieldInfoPtr_PING_MESSAGE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PingMsg>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.NativeFieldInfoPtr_PING_MESSAGE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000407B4 File Offset: 0x0003E9B4
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0000932D File Offset: 0x0000752D
		public unsafe static int PING_DELAY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.NativeFieldInfoPtr_PING_DELAY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.NativeFieldInfoPtr_PING_DELAY, (void*)(&value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x000407D0 File Offset: 0x0003E9D0
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0000933B File Offset: 0x0000753B
		public unsafe static int RECONNECT_LATENCY_THRESHOLD
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.NativeFieldInfoPtr_RECONNECT_LATENCY_THRESHOLD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.NativeFieldInfoPtr_RECONNECT_LATENCY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000407EC File Offset: 0x0003E9EC
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00009349 File Offset: 0x00007549
		public unsafe bool reconnecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnecting)) = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00040814 File Offset: 0x0003EA14
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00009364 File Offset: 0x00007564
		public unsafe int currentCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_currentCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_currentCounter)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004083C File Offset: 0x0003EA3C
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x0000937F File Offset: 0x0000757F
		public unsafe ConcurrentDictionary<int, DWDEvent> outOfOrderMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_outOfOrderMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<int, DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_outOfOrderMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004086C File Offset: 0x0003EA6C
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0000939E File Offset: 0x0000759E
		public unsafe Dictionary<string, global::Il2CppSystem.Object> ackMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_ackMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_ackMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004089C File Offset: 0x0003EA9C
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x000093BD File Offset: 0x000075BD
		public unsafe int clientCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_clientCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_clientCounter)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x000408C4 File Offset: 0x0003EAC4
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x000093D8 File Offset: 0x000075D8
		public unsafe IEnumerator socketMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_socketMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_socketMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x000408F4 File Offset: 0x0003EAF4
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x000093F7 File Offset: 0x000075F7
		public unsafe IEnumerator reconnectMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnectMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnectMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00040924 File Offset: 0x0003EB24
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00009416 File Offset: 0x00007616
		public unsafe bool startReconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_startReconnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_startReconnect)) = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0004094C File Offset: 0x0003EB4C
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00009431 File Offset: 0x00007631
		public unsafe int lastServerMessageTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_lastServerMessageTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_lastServerMessageTime)) = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00040974 File Offset: 0x0003EB74
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0000944C File Offset: 0x0000764C
		public unsafe bool waitingForPong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_waitingForPong);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_waitingForPong)) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0004099C File Offset: 0x0003EB9C
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x00009467 File Offset: 0x00007667
		public unsafe int reconnectsWithoutSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnectsWithoutSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr_reconnectsWithoutSuccess)) = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x000409C4 File Offset: 0x0003EBC4
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00009482 File Offset: 0x00007682
		public unsafe bool _stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__stopped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState.NativeFieldInfoPtr__stopped)) = value;
			}
		}

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_OnErrorDisconnect;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_MAX_RECONNECT_MILLISECONDS;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_messagesToProcess;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_websocketMessageQueue;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_makeJoinGameMessage;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_makeReconnectMessage;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr__ServerTimeOffset_k__BackingField;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr__socketErrorLeavePlaymat_k__BackingField;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr__ConnectivityIcon_k__BackingField;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_startReconnectTime;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr__runRoutine;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr__gameErrorMessage_k__BackingField;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr__GameServerClosed_k__BackingField;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_minimumNetworkLostTimeout;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_PING_MESSAGE;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_PING_DELAY;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_RECONNECT_LATENCY_THRESHOLD;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_reconnecting;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_currentCounter;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_outOfOrderMessages;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_ackMsg;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_clientCounter;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_socketMonitor;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_reconnectMonitor;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_startReconnect;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_lastServerMessageTime;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr_waitingForPong;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_reconnectsWithoutSuccess;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr__stopped;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_add_OnErrorDisconnect_Public_add_Void_Action_1_ReconnectBehaviour_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnErrorDisconnect_Public_rem_Void_Action_1_ReconnectBehaviour_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerTimeOffset_Private_set_Void_TimeSpan_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_get_socketErrorLeavePlaymat_Public_get_ReconnectBehaviour_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_set_socketErrorLeavePlaymat_Private_set_Void_ReconnectBehaviour_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectivityIcon_Public_get_ConnectivityIcon_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectivityIcon_Public_set_Void_ConnectivityIcon_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_gameErrorMessage_Public_get_String_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_set_gameErrorMessage_Private_set_Void_String_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_get_Stopped_Public_get_Boolean_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_get_GameServerClosed_Public_get_Boolean_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_set_GameServerClosed_Public_set_Void_Boolean_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_Dictionary_2_String_String_Object_Func_2_Dictionary_2_String_String_Object_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_PeekMessage_Public_DWDEvent_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_HasQueuedMessage_Public_Boolean_Func_2_DWDEvent_Boolean_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_GetPendingMessages_Public_Void_List_1_DWDEvent_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_WriteUsingCounter_Private_Void_String_Object_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Object_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_run_Private_IEnumerator_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_socketErrorRoutine_Private_IEnumerator_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_socketErrorHasOccurred_Private_Boolean_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_ReconnectRoutine_Private_IEnumerator_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_handleClose_Private_Void_Object_Int32_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReconnect_Public_Void_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_initializeReconnect_Private_Void_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_reconnectHasTimedOut_Private_Boolean_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_RequiresAck_Public_Static_Boolean_Object_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_addAckMessage_Private_Void_String_Object_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_AckMessage_Private_Void_String_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_GetUnackedMessages_Private_IEnumerable_1_KeyValuePair_2_String_Object_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_GetNextCounter_Private_String_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_handleOpen_Private_Void_Object_EventArgs_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_createSessionMetaData_Private_Dictionary_2_String_String_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_configureSessionMetaData_Private_Void_Dictionary_2_String_String_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_handleMessage_Private_Void_ValueTuple_2_String_DWDEvent_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_toggleApplicationState_Public_Void_Boolean_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_AskForServerTime_Private_Void_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr__ReconnectRoutine_b__44_0_Private_ConfiguredTaskAwaitable_1_WebSocketCloseCode_0;

		// Token: 0x0200025F RID: 607
		[ObfuscatedName("boardgames.match.CanisNetworkState+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06001BD4 RID: 7124 RVA: 0x0000F0DE File Offset: 0x0000D2DE
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<CanisNetworkState.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState.__O>.NativeClassPtr);
				CanisNetworkState.__O.NativeFieldInfoPtr__0___DeserializeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState.__O>.NativeClassPtr, "<0>__DeserializeMessage");
			}

			// Token: 0x06001BD5 RID: 7125 RVA: 0x0000F112 File Offset: 0x0000D312
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00066E78 File Offset: 0x00065078
			// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000F11B File Offset: 0x0000D31B
			public unsafe static Func<Il2CppStructArray<byte>, ValueTuple<string, DWDEvent>> _0___DeserializeMessage
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.__O.NativeFieldInfoPtr__0___DeserializeMessage, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<byte>, ValueTuple<string, DWDEvent>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.__O.NativeFieldInfoPtr__0___DeserializeMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010EB RID: 4331
			private static readonly IntPtr NativeFieldInfoPtr__0___DeserializeMessage;
		}

		// Token: 0x02000260 RID: 608
		[ObfuscatedName("boardgames.match.CanisNetworkState+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001BD8 RID: 7128 RVA: 0x00066EA0 File Offset: 0x000650A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr);
				CanisNetworkState.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr, "<>9");
				CanisNetworkState.__c.NativeFieldInfoPtr___9__68_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr, "<>9__68_0");
				CanisNetworkState.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr, 100665505);
				CanisNetworkState.__c.NativeMethodInfoPtr__GetUnackedMessages_b__68_0_Internal_Int32_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr, 100665506);
			}

			// Token: 0x06001BD9 RID: 7129 RVA: 0x00066F1C File Offset: 0x0006511C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisNetworkState.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BDA RID: 7130 RVA: 0x00066F58 File Offset: 0x00065158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997157, XrefRangeEnd = 997159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnackedMessages_b__68_0(KeyValuePair<string, global::Il2CppSystem.Object> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState.__c.NativeMethodInfoPtr__GetUnackedMessages_b__68_0_Internal_Int32_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BDB RID: 7131 RVA: 0x0000F12D File Offset: 0x0000D32D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00066FAC File Offset: 0x000651AC
			// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0000F136 File Offset: 0x0000D336
			public unsafe static CanisNetworkState.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06001BDE RID: 7134 RVA: 0x00066FD4 File Offset: 0x000651D4
			// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0000F148 File Offset: 0x0000D348
			public unsafe static Func<KeyValuePair<string, global::Il2CppSystem.Object>, int> __9__68_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisNetworkState.__c.NativeFieldInfoPtr___9__68_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, global::Il2CppSystem.Object>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisNetworkState.__c.NativeFieldInfoPtr___9__68_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010EC RID: 4332
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010ED RID: 4333
			private static readonly IntPtr NativeFieldInfoPtr___9__68_0;

			// Token: 0x040010EE RID: 4334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010EF RID: 4335
			private static readonly IntPtr NativeMethodInfoPtr__GetUnackedMessages_b__68_0_Internal_Int32_KeyValuePair_2_String_Object_0;
		}

		// Token: 0x02000261 RID: 609
		[ObfuscatedName("boardgames.match.CanisNetworkState+<ReconnectRoutine>d__44")]
		public sealed class _ReconnectRoutine_d__44 : global::Il2CppSystem.Object
		{
			// Token: 0x06001BE0 RID: 7136 RVA: 0x00066FFC File Offset: 0x000651FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReconnectRoutine_d__44()
			{
				Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<ReconnectRoutine>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr);
				CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, "<>1__state");
				CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, "<>2__current");
				CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, "<>4__this");
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665507);
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665508);
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665509);
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665510);
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665511);
				CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr, 100665512);
			}

			// Token: 0x06001BE1 RID: 7137 RVA: 0x000670DC File Offset: 0x000652DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReconnectRoutine_d__44(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisNetworkState._ReconnectRoutine_d__44>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x00067124 File Offset: 0x00065324
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE3 RID: 7139 RVA: 0x00067158 File Offset: 0x00065358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997159, XrefRangeEnd = 997226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00067194 File Offset: 0x00065394
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x000671D4 File Offset: 0x000653D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997226, XrefRangeEnd = 997231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00067208 File Offset: 0x00065408
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._ReconnectRoutine_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BE7 RID: 7143 RVA: 0x0000F15A File Offset: 0x0000D35A
			public _ReconnectRoutine_d__44(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00067248 File Offset: 0x00065448
			// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000F163 File Offset: 0x0000D363
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00067270 File Offset: 0x00065470
			// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000F17E File Offset: 0x0000D37E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000672A0 File Offset: 0x000654A0
			// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000F19D File Offset: 0x0000D39D
			public unsafe CanisNetworkState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._ReconnectRoutine_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010F0 RID: 4336
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010F1 RID: 4337
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010F2 RID: 4338
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010F3 RID: 4339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010F4 RID: 4340
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010F5 RID: 4341
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010F6 RID: 4342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010F7 RID: 4343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010F8 RID: 4344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000262 RID: 610
		[ObfuscatedName("boardgames.match.CanisNetworkState+<run>d__41")]
		public sealed class _run_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x06001BEE RID: 7150 RVA: 0x000672D0 File Offset: 0x000654D0
			// Note: this type is marked as 'beforefieldinit'.
			static _run_d__41()
			{
				Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<run>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr);
				CanisNetworkState._run_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, "<>1__state");
				CanisNetworkState._run_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, "<>2__current");
				CanisNetworkState._run_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, "<>4__this");
				CanisNetworkState._run_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665513);
				CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665514);
				CanisNetworkState._run_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665515);
				CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665516);
				CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665517);
				CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr, 100665518);
			}

			// Token: 0x06001BEF RID: 7151 RVA: 0x000673B0 File Offset: 0x000655B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _run_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisNetworkState._run_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF0 RID: 7152 RVA: 0x000673F8 File Offset: 0x000655F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x0006742C File Offset: 0x0006562C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997231, XrefRangeEnd = 997238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00067468 File Offset: 0x00065668
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF3 RID: 7155 RVA: 0x000674A8 File Offset: 0x000656A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997238, XrefRangeEnd = 997243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000674DC File Offset: 0x000656DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._run_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x0000F1BC File Offset: 0x0000D3BC
			public _run_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x0006751C File Offset: 0x0006571C
			// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000F1C5 File Offset: 0x0000D3C5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00067544 File Offset: 0x00065744
			// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00067574 File Offset: 0x00065774
			// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0000F1FF File Offset: 0x0000D3FF
			public unsafe CanisNetworkState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._run_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010F9 RID: 4345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010FA RID: 4346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010FB RID: 4347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010FC RID: 4348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010FD RID: 4349
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010FE RID: 4350
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010FF RID: 4351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001100 RID: 4352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000263 RID: 611
		[ObfuscatedName("boardgames.match.CanisNetworkState+<socketErrorRoutine>d__42")]
		public sealed class _socketErrorRoutine_d__42 : global::Il2CppSystem.Object
		{
			// Token: 0x06001BFC RID: 7164 RVA: 0x000675A4 File Offset: 0x000657A4
			// Note: this type is marked as 'beforefieldinit'.
			static _socketErrorRoutine_d__42()
			{
				Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisNetworkState>.NativeClassPtr, "<socketErrorRoutine>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr);
				CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, "<>1__state");
				CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, "<>2__current");
				CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, "<>4__this");
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665519);
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665520);
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665521);
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665522);
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665523);
				CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr, 100665524);
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x00067684 File Offset: 0x00065884
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _socketErrorRoutine_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisNetworkState._socketErrorRoutine_d__42>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BFE RID: 7166 RVA: 0x000676CC File Offset: 0x000658CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BFF RID: 7167 RVA: 0x00067700 File Offset: 0x00065900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997243, XrefRangeEnd = 997244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0006773C File Offset: 0x0006593C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C01 RID: 7169 RVA: 0x0006777C File Offset: 0x0006597C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997244, XrefRangeEnd = 997249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000677B0 File Offset: 0x000659B0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisNetworkState._socketErrorRoutine_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C03 RID: 7171 RVA: 0x0000F21E File Offset: 0x0000D41E
			public _socketErrorRoutine_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000677F0 File Offset: 0x000659F0
			// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000F227 File Offset: 0x0000D427
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00067818 File Offset: 0x00065A18
			// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0000F242 File Offset: 0x0000D442
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00067848 File Offset: 0x00065A48
			// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000F261 File Offset: 0x0000D461
			public unsafe CanisNetworkState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisNetworkState._socketErrorRoutine_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
