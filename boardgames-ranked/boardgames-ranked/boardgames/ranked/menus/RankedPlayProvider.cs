using System;
using boardgames.notifications;
using boardgames.ranked.networking.notifications;
using boardgames.ranked.networking.responses;
using dwd.core;
using dwd.core.data.providers;
using dwd.core.session;
using dwd.core.session.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.lobby.responses;

namespace boardgames.ranked.menus
{
	// Token: 0x02000025 RID: 37
	public class RankedPlayProvider : DataProvider
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00006764 File Offset: 0x00004964
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayProvider()
		{
			Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr);
			RankedPlayProvider.NativeFieldInfoPtr_matchStartSoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "matchStartSoundName");
			RankedPlayProvider.NativeFieldInfoPtr_playerRankedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "playerRankedData");
			RankedPlayProvider.NativeFieldInfoPtr__SeasonDefinition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<SeasonDefinition>k__BackingField");
			RankedPlayProvider.NativeFieldInfoPtr__Session_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<Session>k__BackingField");
			RankedPlayProvider.NativeFieldInfoPtr__QueueOpens_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<QueueOpens>k__BackingField");
			RankedPlayProvider.NativeFieldInfoPtr__QueueNextStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<QueueNextStart>k__BackingField");
			RankedPlayProvider.NativeFieldInfoPtr__SeasonEnds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<SeasonEnds>k__BackingField");
			RankedPlayProvider.NativeMethodInfoPtr_get_PlayerRankedData_Public_get_PlayerRankedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663376);
			RankedPlayProvider.NativeMethodInfoPtr_set_PlayerRankedData_Public_set_Void_PlayerRankedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663377);
			RankedPlayProvider.NativeMethodInfoPtr_get_SeasonDefinition_Public_get_RankedSeasonDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663378);
			RankedPlayProvider.NativeMethodInfoPtr_set_SeasonDefinition_Private_set_Void_RankedSeasonDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663379);
			RankedPlayProvider.NativeMethodInfoPtr_get_Session_Public_get_RankedSessionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663380);
			RankedPlayProvider.NativeMethodInfoPtr_set_Session_Private_set_Void_RankedSessionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663381);
			RankedPlayProvider.NativeMethodInfoPtr_get_QueueOpens_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663382);
			RankedPlayProvider.NativeMethodInfoPtr_set_QueueOpens_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663383);
			RankedPlayProvider.NativeMethodInfoPtr_get_QueueNextStart_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663384);
			RankedPlayProvider.NativeMethodInfoPtr_set_QueueNextStart_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663385);
			RankedPlayProvider.NativeMethodInfoPtr_get_SeasonEnds_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663386);
			RankedPlayProvider.NativeMethodInfoPtr_set_SeasonEnds_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663387);
			RankedPlayProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663388);
			RankedPlayProvider.NativeMethodInfoPtr_Queue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663389);
			RankedPlayProvider.NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_New_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663390);
			RankedPlayProvider.NativeMethodInfoPtr_LeaveQueue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663391);
			RankedPlayProvider.NativeMethodInfoPtr_UpdateInfo_Public_Void_RankedQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663392);
			RankedPlayProvider.NativeMethodInfoPtr_HandleRankedUserRegistered_Private_Void_RankedUserRegistered_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663393);
			RankedPlayProvider.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663394);
			RankedPlayProvider.NativeMethodInfoPtr_HandleUpdateRankedQueueInfo_Private_Void_UpdateRankedQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663395);
			RankedPlayProvider.NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663396);
			RankedPlayProvider.NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663397);
			RankedPlayProvider.NativeMethodInfoPtr_boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_Private_Virtual_Final_New_Void_INotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663398);
			RankedPlayProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, 100663399);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00006A00 File Offset: 0x00004C00
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00006A40 File Offset: 0x00004C40
		public unsafe PlayerRankedData PlayerRankedData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_PlayerRankedData_Public_get_PlayerRankedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerRankedData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225192, XrefRangeEnd = 1225194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_PlayerRankedData_Public_set_Void_PlayerRankedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006A84 File Offset: 0x00004C84
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public unsafe RankedSeasonDefinition SeasonDefinition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_SeasonDefinition_Public_get_RankedSeasonDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RankedSeasonDefinition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_SeasonDefinition_Private_set_Void_RankedSeasonDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00006B08 File Offset: 0x00004D08
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00006B48 File Offset: 0x00004D48
		public unsafe RankedSessionProvider Session
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_Session_Public_get_RankedSessionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RankedSessionProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_Session_Private_set_Void_RankedSessionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006B8C File Offset: 0x00004D8C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00006BC8 File Offset: 0x00004DC8
		public unsafe DateTime QueueOpens
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_QueueOpens_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_QueueOpens_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006C08 File Offset: 0x00004E08
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00006C44 File Offset: 0x00004E44
		public unsafe DateTime QueueNextStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_QueueNextStart_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_QueueNextStart_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00006C84 File Offset: 0x00004E84
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public unsafe DateTime SeasonEnds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_get_SeasonEnds_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_set_SeasonEnds_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006D00 File Offset: 0x00004F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225194, XrefRangeEnd = 1225235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006D34 File Offset: 0x00004F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225235, XrefRangeEnd = 1225252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<RankedQueueJoined> Queue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_Queue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<RankedQueueJoined>>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006D74 File Offset: 0x00004F74
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddQueueMetadata(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayProvider.NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_New_Void_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225252, XrefRangeEnd = 1225262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse<RankedQueueLeft> LeaveQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_LeaveQueue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<RankedQueueLeft>>(intPtr3) : null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006E04 File Offset: 0x00005004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225282, RefRangeEnd = 1225284, XrefRangeStart = 1225262, XrefRangeEnd = 1225282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInfo(RankedQueueInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_UpdateInfo_Public_Void_RankedQueueInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006E48 File Offset: 0x00005048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225284, XrefRangeEnd = 1225285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleRankedUserRegistered(RankedUserRegistered message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_HandleRankedUserRegistered_Private_Void_RankedUserRegistered_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006E8C File Offset: 0x0000508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225285, XrefRangeEnd = 1225320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLobbyGameStarted(LobbyGameStarted message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006ED0 File Offset: 0x000050D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225320, XrefRangeEnd = 1225338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleUpdateRankedQueueInfo(UpdateRankedQueueInfo message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_HandleUpdateRankedQueueInfo_Private_Void_UpdateRankedQueueInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006F14 File Offset: 0x00005114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225338, XrefRangeEnd = 1225372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleGameStartFailure(ErrorInfo errorInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006F50 File Offset: 0x00005150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225372, XrefRangeEnd = 1225393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDisconnected(SessionProvider.Disconnected message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006F94 File Offset: 0x00005194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225393, XrefRangeEnd = 1225433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers(INotifications notifications)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notifications);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr_boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_Private_Virtual_Final_New_Void_INotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006FD8 File Offset: 0x000051D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225437, RefRangeEnd = 1225438, XrefRangeStart = 1225433, XrefRangeEnd = 1225437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002C14 File Offset: 0x00000E14
		public RankedPlayProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00007014 File Offset: 0x00005214
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002C1D File Offset: 0x00000E1D
		public unsafe string matchStartSoundName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr_matchStartSoundName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr_matchStartSoundName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000703C File Offset: 0x0000523C
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002C3C File Offset: 0x00000E3C
		public unsafe PlayerRankedData playerRankedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr_playerRankedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerRankedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr_playerRankedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000706C File Offset: 0x0000526C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002C5B File Offset: 0x00000E5B
		public unsafe RankedSeasonDefinition _SeasonDefinition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__SeasonDefinition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedSeasonDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__SeasonDefinition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000709C File Offset: 0x0000529C
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002C7A File Offset: 0x00000E7A
		public unsafe RankedSessionProvider _Session_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__Session_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedSessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__Session_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000070CC File Offset: 0x000052CC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002C99 File Offset: 0x00000E99
		public unsafe DateTime _QueueOpens_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__QueueOpens_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__QueueOpens_k__BackingField)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public unsafe DateTime _QueueNextStart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__QueueNextStart_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__QueueNextStart_k__BackingField)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000711C File Offset: 0x0000531C
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002CCF File Offset: 0x00000ECF
		public unsafe DateTime _SeasonEnds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__SeasonEnds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayProvider.NativeFieldInfoPtr__SeasonEnds_k__BackingField)) = value;
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_matchStartSoundName;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_playerRankedData;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr__SeasonDefinition_k__BackingField;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr__Session_k__BackingField;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr__QueueOpens_k__BackingField;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr__QueueNextStart_k__BackingField;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr__SeasonEnds_k__BackingField;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerRankedData_Public_get_PlayerRankedData_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerRankedData_Public_set_Void_PlayerRankedData_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_SeasonDefinition_Public_get_RankedSeasonDefinition_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_set_SeasonDefinition_Private_set_Void_RankedSeasonDefinition_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_Session_Public_get_RankedSessionProvider_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_set_Session_Private_set_Void_RankedSessionProvider_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_QueueOpens_Public_get_DateTime_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_set_QueueOpens_Private_set_Void_DateTime_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_QueueNextStart_Public_get_DateTime_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_QueueNextStart_Private_set_Void_DateTime_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_SeasonEnds_Public_get_DateTime_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_set_SeasonEnds_Private_set_Void_DateTime_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Queue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueJoined_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_AddQueueMetadata_Protected_Virtual_New_Void_Dictionary_2_String_String_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_LeaveQueue_Public_WriteToSessionAndAwaitResponse_1_RankedQueueLeft_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInfo_Public_Void_RankedQueueInfo_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_HandleRankedUserRegistered_Private_Void_RankedUserRegistered_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_LobbyGameStarted_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_HandleUpdateRankedQueueInfo_Private_Void_UpdateRankedQueueInfo_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_HandleGameStartFailure_Private_Static_Void_ErrorInfo_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_HandleDisconnected_Private_Void_Disconnected_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_Private_Virtual_Final_New_Void_INotifications_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("boardgames.ranked.menus.RankedPlayProvider+<>O")]
		public static class __O : Object
		{
			// Token: 0x0600021F RID: 543 RVA: 0x000032D3 File Offset: 0x000014D3
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<RankedPlayProvider.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayProvider.__O>.NativeClassPtr);
				RankedPlayProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider.__O>.NativeClassPtr, "<0>__HandleGameStartFailure");
			}

			// Token: 0x06000220 RID: 544 RVA: 0x00003307 File Offset: 0x00001507
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000221 RID: 545 RVA: 0x0000970C File Offset: 0x0000790C
			// (set) Token: 0x06000222 RID: 546 RVA: 0x00003310 File Offset: 0x00001510
			public unsafe static Action<ErrorInfo> _0___HandleGameStartFailure
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayProvider.__O.NativeFieldInfoPtr__0___HandleGameStartFailure, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeFieldInfoPtr__0___HandleGameStartFailure;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("boardgames.ranked.menus.RankedPlayProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000223 RID: 547 RVA: 0x00009734 File Offset: 0x00007934
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedPlayProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr);
				RankedPlayProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, "<>9");
				RankedPlayProvider.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, "<>9__33_0");
				RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, "<>9__35_0");
				RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, "<>9__35_1");
				RankedPlayProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, 100663401);
				RankedPlayProvider.__c.NativeMethodInfoPtr__HandleGameStartFailure_b__33_0_Internal_IEnumerator_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, 100663402);
				RankedPlayProvider.__c.NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_0_Internal_IEnumerator_RankedDataUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, 100663403);
				RankedPlayProvider.__c.NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_1_Internal_IEnumerator_RankedSeasonEnded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr, 100663404);
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00009800 File Offset: 0x00007A00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000983C File Offset: 0x00007A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225178, XrefRangeEnd = 1225182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _HandleGameStartFailure_b__33_0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.__c.NativeMethodInfoPtr__HandleGameStartFailure_b__33_0_Internal_IEnumerator_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06000226 RID: 550 RVA: 0x00009894 File Offset: 0x00007A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225182, XrefRangeEnd = 1225187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_0(RankedDataUpdated message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.__c.NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_0_Internal_IEnumerator_RankedDataUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06000227 RID: 551 RVA: 0x000098E4 File Offset: 0x00007AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225187, XrefRangeEnd = 1225192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_1(RankedSeasonEnded message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayProvider.__c.NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_1_Internal_IEnumerator_RankedSeasonEnded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x00003322 File Offset: 0x00001522
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000229 RID: 553 RVA: 0x00009934 File Offset: 0x00007B34
			// (set) Token: 0x0600022A RID: 554 RVA: 0x0000332B File Offset: 0x0000152B
			public unsafe static RankedPlayProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedPlayProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600022B RID: 555 RVA: 0x0000995C File Offset: 0x00007B5C
			// (set) Token: 0x0600022C RID: 556 RVA: 0x0000333D File Offset: 0x0000153D
			public unsafe static Func<ErrorInfo, IEnumerator> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600022D RID: 557 RVA: 0x00009984 File Offset: 0x00007B84
			// (set) Token: 0x0600022E RID: 558 RVA: 0x0000334F File Offset: 0x0000154F
			public unsafe static Func<RankedDataUpdated, IEnumerator> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RankedDataUpdated, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600022F RID: 559 RVA: 0x000099AC File Offset: 0x00007BAC
			// (set) Token: 0x06000230 RID: 560 RVA: 0x00003361 File Offset: 0x00001561
			public unsafe static Func<RankedSeasonEnded, IEnumerator> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RankedSeasonEnded, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayProvider.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr__HandleGameStartFailure_b__33_0_Internal_IEnumerator_ErrorInfo_0;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_0_Internal_IEnumerator_RankedDataUpdated_0;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr__boardgames_notifications_INotificationsMessagesHandler_AddMessageHandlers_b__35_1_Internal_IEnumerator_RankedSeasonEnded_0;
		}
	}
}
