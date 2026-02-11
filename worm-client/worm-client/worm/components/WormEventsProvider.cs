using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.data.providers;
using dwd.core.session;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.lobby.responses;
using worm.networking.responses;

namespace worm.components
{
	// Token: 0x0200007B RID: 123
	public class WormEventsProvider : DataProvider
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x0002711C File Offset: 0x0002531C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsProvider()
		{
			Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.components", "WormEventsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr);
			WormEventsProvider.NativeFieldInfoPtr_matchStartSoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "matchStartSoundName");
			WormEventsProvider.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "events");
			WormEventsProvider.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "entries");
			WormEventsProvider.NativeFieldInfoPtr__Session_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<Session>k__BackingField");
			WormEventsProvider.NativeMethodInfoPtr_get_Session_Public_get_WormEventsSessionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663969);
			WormEventsProvider.NativeMethodInfoPtr_set_Session_Private_set_Void_WormEventsSessionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663970);
			WormEventsProvider.NativeMethodInfoPtr_get_Events_Public_get_IReadOnlyList_1_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663971);
			WormEventsProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663972);
			WormEventsProvider.NativeMethodInfoPtr_IsRegisteredForEvent_Public_Boolean_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663973);
			WormEventsProvider.NativeMethodInfoPtr_GetLatestEntry_Public_EventEntry_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663974);
			WormEventsProvider.NativeMethodInfoPtr_RegisterForEvent_Public_WriteToSessionAndAwaitResponse_2_EventJoined_EventError_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663975);
			WormEventsProvider.NativeMethodInfoPtr_QueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_2_EventQueueJoined_EventError_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663976);
			WormEventsProvider.NativeMethodInfoPtr_LeaveQueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_1_EventQueueLeft_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663977);
			WormEventsProvider.NativeMethodInfoPtr_ResignEvent_Public_WriteToSessionAndAwaitResponse_2_EventEntryEnded_EventError_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663978);
			WormEventsProvider.NativeMethodInfoPtr_GetLeaderboard_Public_WriteToSessionAndAwaitResponse_2_EventLeaderboard_EventError_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663979);
			WormEventsProvider.NativeMethodInfoPtr_HandleActiveEvents_Private_Void_ActiveEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663980);
			WormEventsProvider.NativeMethodInfoPtr_HandleEventVisible_Private_Void_EventVisible_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663981);
			WormEventsProvider.NativeMethodInfoPtr_HandleEventJoined_Private_Void_EventJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663982);
			WormEventsProvider.NativeMethodInfoPtr_HandleEventEntryEnded_Private_Void_EventEntryEnded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663983);
			WormEventsProvider.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663984);
			WormEventsProvider.NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663985);
			WormEventsProvider.NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663986);
			WormEventsProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663987);
			WormEventsProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, 100663988);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0002732C File Offset: 0x0002552C
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0002736C File Offset: 0x0002556C
		public unsafe WormEventsSessionProvider Session
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_get_Session_Public_get_WormEventsSessionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormEventsSessionProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_set_Session_Private_set_Void_WormEventsSessionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000273B0 File Offset: 0x000255B0
		public unsafe IReadOnlyList<EventDefinition> Events
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_get_Events_Public_get_IReadOnlyList_1_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EventDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000273F0 File Offset: 0x000255F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693927, XrefRangeEnd = 693986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00027424 File Offset: 0x00025624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 694001, RefRangeEnd = 694003, XrefRangeStart = 693986, XrefRangeEnd = 694001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRegisteredForEvent(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_IsRegisteredForEvent_Public_Boolean_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00027474 File Offset: 0x00025674
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 694021, RefRangeEnd = 694026, XrefRangeStart = 694003, XrefRangeEnd = 694021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntry GetLatestEntry(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_GetLatestEntry_Public_EventEntry_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000274C4 File Offset: 0x000256C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694037, RefRangeEnd = 694038, XrefRangeStart = 694026, XrefRangeEnd = 694037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<EventJoined, EventError> RegisterForEvent(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_RegisterForEvent_Public_WriteToSessionAndAwaitResponse_2_EventJoined_EventError_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventJoined, EventError>>(intPtr3) : null;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00027514 File Offset: 0x00025714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694038, XrefRangeEnd = 694064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<EventQueueJoined, EventError> QueueForAsyncMatch(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_QueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_2_EventQueueJoined_EventError_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventQueueJoined, EventError>>(intPtr3) : null;
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00027564 File Offset: 0x00025764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694064, XrefRangeEnd = 694075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<EventQueueLeft> LeaveQueueForAsyncMatch(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_LeaveQueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_1_EventQueueLeft_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventQueueLeft>>(intPtr3) : null;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000275B4 File Offset: 0x000257B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694101, RefRangeEnd = 694102, XrefRangeStart = 694075, XrefRangeEnd = 694101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<EventEntryEnded, EventError> ResignEvent(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_ResignEvent_Public_WriteToSessionAndAwaitResponse_2_EventEntryEnded_EventError_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventEntryEnded, EventError>>(intPtr3) : null;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00027604 File Offset: 0x00025804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694113, RefRangeEnd = 694114, XrefRangeStart = 694102, XrefRangeEnd = 694113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<EventLeaderboard, EventError> GetLeaderboard(EventID eventID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_GetLeaderboard_Public_WriteToSessionAndAwaitResponse_2_EventLeaderboard_EventError_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<EventLeaderboard, EventError>>(intPtr3) : null;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00027654 File Offset: 0x00025854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694114, XrefRangeEnd = 694124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleActiveEvents(ActiveEvents message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleActiveEvents_Private_Void_ActiveEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00027698 File Offset: 0x00025898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694124, XrefRangeEnd = 694150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventVisible(EventVisible message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleEventVisible_Private_Void_EventVisible_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000276DC File Offset: 0x000258DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694150, XrefRangeEnd = 694158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventJoined(EventJoined message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleEventJoined_Private_Void_EventJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00027720 File Offset: 0x00025920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694158, XrefRangeEnd = 694181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventEntryEnded(EventEntryEnded message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleEventEntryEnded_Private_Void_EventEntryEnded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00027764 File Offset: 0x00025964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694181, XrefRangeEnd = 694216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLobbyGameStarted(LobbyGameStarted message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000277A8 File Offset: 0x000259A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694216, XrefRangeEnd = 694234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleGameStartFailure(ErrorInfo errorInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000277E4 File Offset: 0x000259E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694234, XrefRangeEnd = 694261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDisconnected(SessionProvider.Disconnected message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00027828 File Offset: 0x00025A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694261, XrefRangeEnd = 694319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002785C File Offset: 0x00025A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694319, XrefRangeEnd = 694337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004563 File Offset: 0x00002763
		public WormEventsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00027898 File Offset: 0x00025A98
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x0000456C File Offset: 0x0000276C
		public unsafe string matchStartSoundName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_matchStartSoundName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_matchStartSoundName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000278C0 File Offset: 0x00025AC0
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000458B File Offset: 0x0000278B
		public unsafe List<EventDefinition> events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000278F0 File Offset: 0x00025AF0
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000045AA File Offset: 0x000027AA
		public unsafe List<EventEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00027920 File Offset: 0x00025B20
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000045C9 File Offset: 0x000027C9
		public unsafe WormEventsSessionProvider _Session_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr__Session_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsSessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.NativeFieldInfoPtr__Session_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_matchStartSoundName;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr__Session_k__BackingField;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_Session_Public_get_WormEventsSessionProvider_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_set_Session_Private_set_Void_WormEventsSessionProvider_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_Events_Public_get_IReadOnlyList_1_EventDefinition_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_IsRegisteredForEvent_Public_Boolean_EventID_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestEntry_Public_EventEntry_EventID_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForEvent_Public_WriteToSessionAndAwaitResponse_2_EventJoined_EventError_EventID_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_QueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_2_EventQueueJoined_EventError_EventID_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_LeaveQueueForAsyncMatch_Public_WriteToSessionAndAwaitResponse_1_EventQueueLeft_EventID_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_ResignEvent_Public_WriteToSessionAndAwaitResponse_2_EventEntryEnded_EventError_EventID_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboard_Public_WriteToSessionAndAwaitResponse_2_EventLeaderboard_EventError_EventID_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_HandleActiveEvents_Private_Void_ActiveEvents_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventVisible_Private_Void_EventVisible_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventJoined_Private_Void_EventJoined_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventEntryEnded_Private_Void_EventEntryEnded_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F0 RID: 752
		[ObfuscatedName("worm.components.WormEventsProvider+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001E8F RID: 7823 RVA: 0x0001153C File Offset: 0x0000F73C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormEventsProvider.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__O>.NativeClassPtr);
				WormEventsProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__O>.NativeClassPtr, "<0>__HandleGameStartFailure");
			}

			// Token: 0x06001E90 RID: 7824 RVA: 0x00011570 File Offset: 0x0000F770
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00075B74 File Offset: 0x00073D74
			// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00011579 File Offset: 0x0000F779
			public unsafe static Action<ErrorInfo> _0___HandleGameStartFailure
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B4 RID: 4532
			private static readonly IntPtr NativeFieldInfoPtr__0___HandleGameStartFailure;
		}

		// Token: 0x020002F1 RID: 753
		[ObfuscatedName("worm.components.WormEventsProvider+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001E93 RID: 7827 RVA: 0x00075B9C File Offset: 0x00073D9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr);
				WormEventsProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr, "eventID");
				WormEventsProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr, 100663989);
				WormEventsProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__IsRegisteredForEvent_b__0_Internal_Boolean_EventEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr, 100663990);
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x00075C04 File Offset: 0x00073E04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x00075C40 File Offset: 0x00073E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693905, XrefRangeEnd = 693909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsRegisteredForEvent_b__0(EventEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__IsRegisteredForEvent_b__0_Internal_Boolean_EventEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x0001158B File Offset: 0x0000F78B
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001E97 RID: 7831 RVA: 0x00075C90 File Offset: 0x00073E90
			// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00011594 File Offset: 0x0000F794
			public unsafe EventID eventID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_eventID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B5 RID: 4533
			private static readonly IntPtr NativeFieldInfoPtr_eventID;

			// Token: 0x040011B6 RID: 4534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011B7 RID: 4535
			private static readonly IntPtr NativeMethodInfoPtr__IsRegisteredForEvent_b__0_Internal_Boolean_EventEntry_0;
		}

		// Token: 0x020002F2 RID: 754
		[ObfuscatedName("worm.components.WormEventsProvider+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06001E99 RID: 7833 RVA: 0x00075CC0 File Offset: 0x00073EC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr);
				WormEventsProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr, "eventID");
				WormEventsProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr, 100663991);
				WormEventsProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__QueueForAsyncMatch_b__0_Internal_Boolean_EventEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr, 100663992);
			}

			// Token: 0x06001E9A RID: 7834 RVA: 0x00075D28 File Offset: 0x00073F28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E9B RID: 7835 RVA: 0x00075D64 File Offset: 0x00073F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693909, XrefRangeEnd = 693913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _QueueForAsyncMatch_b__0(EventEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass13_0.NativeMethodInfoPtr__QueueForAsyncMatch_b__0_Internal_Boolean_EventEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x000115B3 File Offset: 0x0000F7B3
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00075DB4 File Offset: 0x00073FB4
			// (set) Token: 0x06001E9E RID: 7838 RVA: 0x000115BC File Offset: 0x0000F7BC
			public unsafe EventID eventID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_eventID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass13_0.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B8 RID: 4536
			private static readonly IntPtr NativeFieldInfoPtr_eventID;

			// Token: 0x040011B9 RID: 4537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011BA RID: 4538
			private static readonly IntPtr NativeMethodInfoPtr__QueueForAsyncMatch_b__0_Internal_Boolean_EventEntry_0;
		}

		// Token: 0x020002F3 RID: 755
		[ObfuscatedName("worm.components.WormEventsProvider+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06001E9F RID: 7839 RVA: 0x00075DE4 File Offset: 0x00073FE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr);
				WormEventsProvider.__c__DisplayClass15_0.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr, "eventID");
				WormEventsProvider.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr, 100663993);
				WormEventsProvider.__c__DisplayClass15_0.NativeMethodInfoPtr__ResignEvent_b__0_Internal_Boolean_EventEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr, 100663994);
			}

			// Token: 0x06001EA0 RID: 7840 RVA: 0x00075E4C File Offset: 0x0007404C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA1 RID: 7841 RVA: 0x00075E88 File Offset: 0x00074088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693913, XrefRangeEnd = 693917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResignEvent_b__0(EventEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass15_0.NativeMethodInfoPtr__ResignEvent_b__0_Internal_Boolean_EventEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EA2 RID: 7842 RVA: 0x000115DB File Offset: 0x0000F7DB
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00075ED8 File Offset: 0x000740D8
			// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x000115E4 File Offset: 0x0000F7E4
			public unsafe EventID eventID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass15_0.NativeFieldInfoPtr_eventID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass15_0.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011BB RID: 4539
			private static readonly IntPtr NativeFieldInfoPtr_eventID;

			// Token: 0x040011BC RID: 4540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011BD RID: 4541
			private static readonly IntPtr NativeMethodInfoPtr__ResignEvent_b__0_Internal_Boolean_EventEntry_0;
		}

		// Token: 0x020002F4 RID: 756
		[ObfuscatedName("worm.components.WormEventsProvider+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x06001EA5 RID: 7845 RVA: 0x00075F08 File Offset: 0x00074108
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr);
				WormEventsProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr, "message");
				WormEventsProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr, 100663995);
				WormEventsProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__HandleEventVisible_b__0_Internal_Boolean_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr, 100663996);
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x00075F70 File Offset: 0x00074170
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x00075FAC File Offset: 0x000741AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693917, XrefRangeEnd = 693922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleEventVisible_b__0(EventDefinition e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__HandleEventVisible_b__0_Internal_Boolean_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x00011603 File Offset: 0x0000F803
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x00075FFC File Offset: 0x000741FC
			// (set) Token: 0x06001EAA RID: 7850 RVA: 0x0001160C File Offset: 0x0000F80C
			public unsafe EventVisible message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventVisible>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011BE RID: 4542
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x040011BF RID: 4543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011C0 RID: 4544
			private static readonly IntPtr NativeMethodInfoPtr__HandleEventVisible_b__0_Internal_Boolean_EventDefinition_0;
		}

		// Token: 0x020002F5 RID: 757
		[ObfuscatedName("worm.components.WormEventsProvider+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06001EAB RID: 7851 RVA: 0x0007602C File Offset: 0x0007422C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsProvider>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr);
				WormEventsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr, "message");
				WormEventsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr, 100663997);
				WormEventsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleEventEntryEnded_b__0_Internal_Boolean_EventEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr, 100663998);
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x00076094 File Offset: 0x00074294
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsProvider.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x000760D0 File Offset: 0x000742D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693922, XrefRangeEnd = 693927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleEventEntryEnded_b__0(EventEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleEventEntryEnded_b__0_Internal_Boolean_EventEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x0001162B File Offset: 0x0000F82B
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00076120 File Offset: 0x00074320
			// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00011634 File Offset: 0x0000F834
			public unsafe EventEntryEnded message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntryEnded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C1 RID: 4545
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x040011C2 RID: 4546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011C3 RID: 4547
			private static readonly IntPtr NativeMethodInfoPtr__HandleEventEntryEnded_b__0_Internal_Boolean_EventEntry_0;
		}
	}
}
