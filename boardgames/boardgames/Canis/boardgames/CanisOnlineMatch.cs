using System;
using boardgames.match;
using Canis.json.events;
using Canis.messages.sequence;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using zen.src.menus;

namespace Canis.boardgames
{
	// Token: 0x0200002F RID: 47
	public class CanisOnlineMatch : CanisMatch
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00016BB4 File Offset: 0x00014DB4
		// Note: this type is marked as 'beforefieldinit'.
		static CanisOnlineMatch()
		{
			Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "Canis.boardgames", "CanisOnlineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr);
			CanisOnlineMatch.NativeFieldInfoPtr_connectivityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "connectivityIcon");
			CanisOnlineMatch.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "disposed");
			CanisOnlineMatch.NativeFieldInfoPtr_clientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "clientID");
			CanisOnlineMatch.NativeFieldInfoPtr_gameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "gameOver");
			CanisOnlineMatch.NativeFieldInfoPtr__network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "_network");
			CanisOnlineMatch.NativeFieldInfoPtr__messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "_messages");
			CanisOnlineMatch.NativeMethodInfoPtr_get_gameErrorMessage_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663654);
			CanisOnlineMatch.NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663655);
			CanisOnlineMatch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663656);
			CanisOnlineMatch.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_GameID_AccountID_CanisNetworkState_SequenceMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663657);
			CanisOnlineMatch.NativeMethodInfoPtr_ErrorDisconnected_Private_Void_ReconnectBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663658);
			CanisOnlineMatch.NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663659);
			CanisOnlineMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663660);
			CanisOnlineMatch.NativeMethodInfoPtr_GameEnded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663661);
			CanisOnlineMatch.NativeMethodInfoPtr_RequestCheats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663662);
			CanisOnlineMatch.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663663);
			CanisOnlineMatch.NativeMethodInfoPtr_leaveMatchDueToError_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663664);
			CanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663665);
			CanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663666);
			CanisOnlineMatch.NativeMethodInfoPtr_reloadMatch_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663667);
			CanisOnlineMatch.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663668);
			CanisOnlineMatch.NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663669);
			CanisOnlineMatch.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663670);
			CanisOnlineMatch.NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663671);
			CanisOnlineMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663672);
			CanisOnlineMatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663673);
			CanisOnlineMatch.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663674);
			CanisOnlineMatch.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663675);
			CanisOnlineMatch.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663676);
			CanisOnlineMatch.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, 100663677);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00016E3C File Offset: 0x0001503C
		public unsafe string gameErrorMessage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 984500, RefRangeEnd = 984501, XrefRangeStart = 984498, XrefRangeEnd = 984500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_get_gameErrorMessage_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00016E74 File Offset: 0x00015074
		public unsafe TimeSpan ServerTimeOffset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 984502, RefRangeEnd = 984503, XrefRangeStart = 984501, XrefRangeEnd = 984502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00016EB0 File Offset: 0x000150B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984503, XrefRangeEnd = 984507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00016EE4 File Offset: 0x000150E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984507, XrefRangeEnd = 984524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(GameID gameID, AccountID accountID, CanisNetworkState networkState, SequenceMessage sgs, bool isLive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(networkState);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sgs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_GameID_AccountID_CanisNetworkState_SequenceMessage_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00016F78 File Offset: 0x00015178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984524, XrefRangeEnd = 984542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ErrorDisconnected(ReconnectBehaviour socketErrorLeavePlaymat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socketErrorLeavePlaymat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_ErrorDisconnected_Private_Void_ReconnectBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00016FB8 File Offset: 0x000151B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00016FF4 File Offset: 0x000151F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeleteSaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00017030 File Offset: 0x00015230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984542, RefRangeEnd = 984543, XrefRangeStart = 984542, XrefRangeEnd = 984542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_GameEnded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00017064 File Offset: 0x00015264
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCheats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_RequestCheats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00017098 File Offset: 0x00015298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984543, RefRangeEnd = 984544, XrefRangeStart = 984543, XrefRangeEnd = 984543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFromAccount(Object message, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000170F8 File Offset: 0x000152F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984544, XrefRangeEnd = 984545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void leaveMatchDueToError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_leaveMatchDueToError_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00017134 File Offset: 0x00015334
		[CallerCount(0)]
		public unsafe virtual Command GetLeaveMatchDueToError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00017180 File Offset: 0x00015380
		[CallerCount(0)]
		public unsafe virtual Command GetLeaveMatchDueToIdleTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000171CC File Offset: 0x000153CC
		[CallerCount(0)]
		public unsafe virtual void reloadMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_reloadMatch_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00017208 File Offset: 0x00015408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984545, XrefRangeEnd = 984563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00017244 File Offset: 0x00015444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984563, XrefRangeEnd = 984568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator LeavePlaymatWithoutResigning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00017290 File Offset: 0x00015490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984568, XrefRangeEnd = 984576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000172E0 File Offset: 0x000154E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984543, RefRangeEnd = 984544, XrefRangeStart = 984543, XrefRangeEnd = 984544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Object message, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisOnlineMatch.NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00017340 File Offset: 0x00015540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984576, XrefRangeEnd = 984578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00017374 File Offset: 0x00015574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000173A8 File Offset: 0x000155A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool isPaused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPaused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000173E8 File Offset: 0x000155E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool isFocused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isFocused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00017428 File Offset: 0x00015628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001745C File Offset: 0x0001565C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984596, RefRangeEnd = 984597, XrefRangeStart = 984578, XrefRangeEnd = 984596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisOnlineMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002DAA File Offset: 0x00000FAA
		public CanisOnlineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00017498 File Offset: 0x00015698
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002DB3 File Offset: 0x00000FB3
		public unsafe ConnectivityIcon connectivityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_connectivityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectivityIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_connectivityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000174C8 File Offset: 0x000156C8
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002DD2 File Offset: 0x00000FD2
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000174F0 File Offset: 0x000156F0
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002DED File Offset: 0x00000FED
		public unsafe string clientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_clientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_clientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00017518 File Offset: 0x00015718
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002E0C File Offset: 0x0000100C
		public unsafe bool gameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_gameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr_gameOver)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00017540 File Offset: 0x00015740
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002E27 File Offset: 0x00001027
		public unsafe CanisNetworkState _network
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr__network);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisNetworkState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr__network), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00017570 File Offset: 0x00015770
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002E46 File Offset: 0x00001046
		public unsafe List<DWDEvent> _messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr__messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch.NativeFieldInfoPtr__messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_connectivityIcon;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_clientID;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_gameOver;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr__network;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr__messages;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_gameErrorMessage_Protected_get_String_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerTimeOffset_Public_get_TimeSpan_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_GameID_AccountID_CanisNetworkState_SequenceMessage_Boolean_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_ErrorDisconnected_Private_Void_ReconnectBehaviour_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_SaveGame_Public_Virtual_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Public_Virtual_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_GameEnded_Public_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_RequestCheats_Private_Void_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_Void_Object_AccountID_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_leaveMatchDueToError_Protected_Virtual_New_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Abstract_Virtual_New_Command_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Abstract_Virtual_New_Command_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_reloadMatch_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_IEnumerator_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001B0 RID: 432
		[ObfuscatedName("Canis.boardgames.CanisOnlineMatch+<LeavePlaymatWithoutResigning>d__23")]
		public sealed class _LeavePlaymatWithoutResigning_d__23 : Object
		{
			// Token: 0x060014D7 RID: 5335 RVA: 0x00051514 File Offset: 0x0004F714
			// Note: this type is marked as 'beforefieldinit'.
			static _LeavePlaymatWithoutResigning_d__23()
			{
				Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisOnlineMatch>.NativeClassPtr, "<LeavePlaymatWithoutResigning>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, "<>1__state");
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, "<>2__current");
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, "<>4__this");
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663678);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663679);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663680);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663681);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663682);
				CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr, 100663683);
			}

			// Token: 0x060014D8 RID: 5336 RVA: 0x000515F4 File Offset: 0x0004F7F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LeavePlaymatWithoutResigning_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014D9 RID: 5337 RVA: 0x0005163C File Offset: 0x0004F83C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014DA RID: 5338 RVA: 0x00051670 File Offset: 0x0004F870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984488, XrefRangeEnd = 984493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060014DB RID: 5339 RVA: 0x000516AC File Offset: 0x0004F8AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014DC RID: 5340 RVA: 0x000516EC File Offset: 0x0004F8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984493, XrefRangeEnd = 984498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x060014DD RID: 5341 RVA: 0x00051720 File Offset: 0x0004F920
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014DE RID: 5342 RVA: 0x0000BC1A File Offset: 0x00009E1A
			public _LeavePlaymatWithoutResigning_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060014DF RID: 5343 RVA: 0x00051760 File Offset: 0x0004F960
			// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000BC23 File Offset: 0x00009E23
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00051788 File Offset: 0x0004F988
			// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000BC3E File Offset: 0x00009E3E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000517B8 File Offset: 0x0004F9B8
			// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0000BC5D File Offset: 0x00009E5D
			public unsafe CanisOnlineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisOnlineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisOnlineMatch._LeavePlaymatWithoutResigning_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CA2 RID: 3234
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CA3 RID: 3235
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CA4 RID: 3236
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CA5 RID: 3237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CA6 RID: 3238
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CA7 RID: 3239
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CA8 RID: 3240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CA9 RID: 3241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CAA RID: 3242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
