using System;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x02000029 RID: 41
	public class SaveData : Object
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00024D04 File Offset: 0x00022F04
		// Note: this type is marked as 'beforefieldinit'.
		static SaveData()
		{
			Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "SaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
			SaveData.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "gameID");
			SaveData.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "currentState");
			SaveData.NativeFieldInfoPtr_activePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "activePlayer");
			SaveData.NativeFieldInfoPtr_selectionPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "selectionPlayers");
			SaveData.NativeFieldInfoPtr_playerStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "playerStates");
			SaveData.NativeFieldInfoPtr_turnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "turnNumber");
			SaveData.NativeFieldInfoPtr_lastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "lastPlayed");
			SaveData.NativeFieldInfoPtr_createdAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "createdAt");
			SaveData.NativeFieldInfoPtr_orderedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "orderedPlayers");
			SaveData.NativeFieldInfoPtr_scenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "scenarioKey");
			SaveData.NativeFieldInfoPtr_matchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "matchType");
			SaveData.NativeFieldInfoPtr_eventReactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "eventReactor");
			SaveData.NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663931);
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663932);
			SaveData.NativeMethodInfoPtr_GetSaveFileName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663933);
			SaveData.NativeMethodInfoPtr_GetLegacyFilename_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663934);
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_GameID_SerializedGameState_AccountID_List_1_AccountID_Int32_Int64_Int64_List_1_PlayerInfoSaveData_String_String_List_1_AccountID_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663935);
			SaveData.NativeMethodInfoPtr_DeepCopy_Public_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100663936);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00024E9C File Offset: 0x0002309C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549112, XrefRangeEnd = 549116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool myTurn(AccountID myAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00024EEC File Offset: 0x000230EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549116, XrefRangeEnd = 549124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00024F28 File Offset: 0x00023128
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549124, XrefRangeEnd = 549125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSaveFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr_GetSaveFileName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00024F60 File Offset: 0x00023160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549132, XrefRangeEnd = 549140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLegacyFilename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr_GetLegacyFilename_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00024F98 File Offset: 0x00023198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549232, RefRangeEnd = 549233, XrefRangeStart = 549140, XrefRangeEnd = 549232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData(GameID gameId, SerializedGameState startState, AccountID firstPlayer, List<AccountID> accountIDs, int turn, long started, long now, List<PlayerInfoSaveData> players, string scenarioKey, string matchType, List<AccountID> playersMakingCurrentSelection = null, SerializedEventReactor serializedEventReactor = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountIDs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref started;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref now;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(players);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scenarioKey);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchType);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersMakingCurrentSelection);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializedEventReactor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_GameID_SerializedGameState_AccountID_List_1_AccountID_Int32_Int64_Int64_List_1_PlayerInfoSaveData_String_String_List_1_AccountID_SerializedEventReactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000250A8 File Offset: 0x000232A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549233, XrefRangeEnd = 549294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData DeepCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr_DeepCopy_Public_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000032F4 File Offset: 0x000014F4
		public SaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000250E8 File Offset: 0x000232E8
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000032FD File Offset: 0x000014FD
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00025118 File Offset: 0x00023318
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000331C File Offset: 0x0000151C
		public unsafe SerializedGameState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_currentState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_currentState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00025148 File Offset: 0x00023348
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000333B File Offset: 0x0000153B
		public unsafe AccountID activePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_activePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_activePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00025178 File Offset: 0x00023378
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000335A File Offset: 0x0000155A
		public unsafe List<AccountID> selectionPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_selectionPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_selectionPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000251A8 File Offset: 0x000233A8
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00003379 File Offset: 0x00001579
		public unsafe Dictionary<AccountID, PlayerSaveData> playerStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_playerStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, PlayerSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_playerStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000251D8 File Offset: 0x000233D8
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003398 File Offset: 0x00001598
		public unsafe int turnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_turnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_turnNumber)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00025200 File Offset: 0x00023400
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000033B3 File Offset: 0x000015B3
		public unsafe long lastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_lastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_lastPlayed)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00025228 File Offset: 0x00023428
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000033CE File Offset: 0x000015CE
		public unsafe long createdAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_createdAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_createdAt)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00025250 File Offset: 0x00023450
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000033E9 File Offset: 0x000015E9
		public unsafe List<PlayerInfoSaveData> orderedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_orderedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInfoSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_orderedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00025280 File Offset: 0x00023480
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003408 File Offset: 0x00001608
		public unsafe string scenarioKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_scenarioKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_scenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000252A8 File Offset: 0x000234A8
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003427 File Offset: 0x00001627
		public unsafe string matchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_matchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_matchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000252D0 File Offset: 0x000234D0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003446 File Offset: 0x00001646
		public unsafe SerializedEventReactor eventReactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_eventReactor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEventReactor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_eventReactor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_activePlayer;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_selectionPlayers;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_playerStates;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_turnNumber;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_lastPlayed;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_createdAt;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_orderedPlayers;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_scenarioKey;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_matchType;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_eventReactor;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveFileName_Public_String_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyFilename_Public_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_SerializedGameState_AccountID_List_1_AccountID_Int32_Int64_Int64_List_1_PlayerInfoSaveData_String_String_List_1_AccountID_SerializedEventReactor_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_DeepCopy_Public_SaveData_0;

		// Token: 0x0200027C RID: 636
		[ObfuscatedName("Canis.SaveData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AE9 RID: 6889 RVA: 0x00082950 File Offset: 0x00080B50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr);
				SaveData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, "<>9");
				SaveData.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, "<>9__17_0");
				SaveData.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, "<>9__17_1");
				SaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, 100663938);
				SaveData.__c.NativeMethodInfoPtr__DeepCopy_b__17_0_Internal_AccountID_KeyValuePair_2_AccountID_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, 100663939);
				SaveData.__c.NativeMethodInfoPtr__DeepCopy_b__17_1_Internal_PlayerSaveData_KeyValuePair_2_AccountID_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr, 100663940);
			}

			// Token: 0x06001AEA RID: 6890 RVA: 0x000829F4 File Offset: 0x00080BF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AEB RID: 6891 RVA: 0x00082A30 File Offset: 0x00080C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549098, XrefRangeEnd = 549099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _DeepCopy_b__17_0(KeyValuePair<AccountID, PlayerSaveData> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.__c.NativeMethodInfoPtr__DeepCopy_b__17_0_Internal_AccountID_KeyValuePair_2_AccountID_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06001AEC RID: 6892 RVA: 0x00082A88 File Offset: 0x00080C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549099, XrefRangeEnd = 549112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveData _DeepCopy_b__17_1(KeyValuePair<AccountID, PlayerSaveData> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.__c.NativeMethodInfoPtr__DeepCopy_b__17_1_Internal_PlayerSaveData_KeyValuePair_2_AccountID_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerSaveData>(intPtr3) : null;
				}
			}

			// Token: 0x06001AED RID: 6893 RVA: 0x0000CD92 File Offset: 0x0000AF92
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06001AEE RID: 6894 RVA: 0x00082AE0 File Offset: 0x00080CE0
			// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000CD9B File Offset: 0x0000AF9B
			public unsafe static SaveData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00082B08 File Offset: 0x00080D08
			// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0000CDAD File Offset: 0x0000AFAD
			public unsafe static Func<KeyValuePair<AccountID, PlayerSaveData>, AccountID> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveData.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, PlayerSaveData>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveData.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00082B30 File Offset: 0x00080D30
			// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000CDBF File Offset: 0x0000AFBF
			public unsafe static Func<KeyValuePair<AccountID, PlayerSaveData>, PlayerSaveData> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveData.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, PlayerSaveData>, PlayerSaveData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveData.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400112A RID: 4394
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400112B RID: 4395
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400112C RID: 4396
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x0400112D RID: 4397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400112E RID: 4398
			private static readonly IntPtr NativeMethodInfoPtr__DeepCopy_b__17_0_Internal_AccountID_KeyValuePair_2_AccountID_PlayerSaveData_0;

			// Token: 0x0400112F RID: 4399
			private static readonly IntPtr NativeMethodInfoPtr__DeepCopy_b__17_1_Internal_PlayerSaveData_KeyValuePair_2_AccountID_PlayerSaveData_0;
		}
	}
}
