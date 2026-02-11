using System;
using Canis;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000191 RID: 401
	public class ReconnectableGameData : VersionedDataComponent
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x00055E20 File Offset: 0x00054020
		// Note: this type is marked as 'beforefieldinit'.
		static ReconnectableGameData()
		{
			Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ReconnectableGameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr);
			ReconnectableGameData.NativeFieldInfoPtr__ActivePlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<ActivePlayer>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__SelectionPlayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<SelectionPlayers>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__TurnNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<TurnNumber>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__CreatedAt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<CreatedAt>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__LastMove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<LastMove>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__LastPlayed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<LastPlayed>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__ScenarioKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<ScenarioKey>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__GameName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<GameName>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__GameState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<GameState>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr__MatchType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "<MatchType>k__BackingField");
			ReconnectableGameData.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "Players");
			ReconnectableGameData.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, "players");
			ReconnectableGameData.NativeMethodInfoPtr_get_ActivePlayer_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665779);
			ReconnectableGameData.NativeMethodInfoPtr_set_ActivePlayer_Private_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665780);
			ReconnectableGameData.NativeMethodInfoPtr_get_SelectionPlayers_Public_get_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665781);
			ReconnectableGameData.NativeMethodInfoPtr_set_SelectionPlayers_Private_set_Void_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665782);
			ReconnectableGameData.NativeMethodInfoPtr_get_TurnNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665783);
			ReconnectableGameData.NativeMethodInfoPtr_set_TurnNumber_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665784);
			ReconnectableGameData.NativeMethodInfoPtr_get_CreatedAt_Public_get_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665785);
			ReconnectableGameData.NativeMethodInfoPtr_set_CreatedAt_Private_set_Void_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665786);
			ReconnectableGameData.NativeMethodInfoPtr_get_LastMove_Public_get_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665787);
			ReconnectableGameData.NativeMethodInfoPtr_set_LastMove_Private_set_Void_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665788);
			ReconnectableGameData.NativeMethodInfoPtr_get_LastPlayed_Public_get_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665789);
			ReconnectableGameData.NativeMethodInfoPtr_set_LastPlayed_Private_set_Void_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665790);
			ReconnectableGameData.NativeMethodInfoPtr_get_ScenarioKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665791);
			ReconnectableGameData.NativeMethodInfoPtr_set_ScenarioKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665792);
			ReconnectableGameData.NativeMethodInfoPtr_get_GameName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665793);
			ReconnectableGameData.NativeMethodInfoPtr_set_GameName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665794);
			ReconnectableGameData.NativeMethodInfoPtr_get_GameState_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665795);
			ReconnectableGameData.NativeMethodInfoPtr_set_GameState_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665796);
			ReconnectableGameData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665797);
			ReconnectableGameData.NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665798);
			ReconnectableGameData.NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665799);
			ReconnectableGameData.NativeMethodInfoPtr_UpdateWith_Public_Void_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665800);
			ReconnectableGameData.NativeMethodInfoPtr_MarkCompleted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665801);
			ReconnectableGameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr, 100665802);
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00056120 File Offset: 0x00054320
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00056160 File Offset: 0x00054360
		public unsafe AccountID ActivePlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_ActivePlayer_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_ActivePlayer_Private_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000561A4 File Offset: 0x000543A4
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x000561E4 File Offset: 0x000543E4
		public unsafe List<AccountID> SelectionPlayers
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_SelectionPlayers_Public_get_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_SelectionPlayers_Private_set_Void_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00056228 File Offset: 0x00054428
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x00056264 File Offset: 0x00054464
		public unsafe int TurnNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_TurnNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_TurnNumber_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000562A4 File Offset: 0x000544A4
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x000562DC File Offset: 0x000544DC
		public unsafe WargTime CreatedAt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_CreatedAt_Public_get_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_CreatedAt_Private_set_Void_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00056324 File Offset: 0x00054524
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0005635C File Offset: 0x0005455C
		public unsafe WargTime LastMove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_LastMove_Public_get_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_LastMove_Private_set_Void_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000563A4 File Offset: 0x000545A4
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x000563DC File Offset: 0x000545DC
		public unsafe WargTime LastPlayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_LastPlayed_Public_get_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_LastPlayed_Private_set_Void_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00056424 File Offset: 0x00054624
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0005645C File Offset: 0x0005465C
		public unsafe string ScenarioKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_ScenarioKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_ScenarioKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000564A0 File Offset: 0x000546A0
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x000564D8 File Offset: 0x000546D8
		public unsafe string GameName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_GameName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_GameName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0005651C File Offset: 0x0005471C
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x00056554 File Offset: 0x00054754
		public unsafe string GameState
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_GameState_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_GameState_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00056598 File Offset: 0x00054798
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x000565D0 File Offset: 0x000547D0
		public unsafe string MatchType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00056614 File Offset: 0x00054814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515195, RefRangeEnd = 515196, XrefRangeStart = 515179, XrefRangeEnd = 515195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReconnectableGameData(SaveMetaData saveData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReconnectableGameData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00056660 File Offset: 0x00054860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 515312, RefRangeEnd = 515314, XrefRangeStart = 515196, XrefRangeEnd = 515312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWith(SaveMetaData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_UpdateWith_Public_Void_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x000566A4 File Offset: 0x000548A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515318, RefRangeEnd = 515319, XrefRangeStart = 515314, XrefRangeEnd = 515318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGameData.NativeMethodInfoPtr_MarkCompleted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000566D8 File Offset: 0x000548D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515319, XrefRangeEnd = 515381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReconnectableGameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0000A771 File Offset: 0x00008971
		public ReconnectableGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0005671C File Offset: 0x0005491C
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000A77A File Offset: 0x0000897A
		public unsafe AccountID _ActivePlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__ActivePlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__ActivePlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0005674C File Offset: 0x0005494C
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000A799 File Offset: 0x00008999
		public unsafe List<AccountID> _SelectionPlayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__SelectionPlayers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__SelectionPlayers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0005677C File Offset: 0x0005497C
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0000A7B8 File Offset: 0x000089B8
		public unsafe int _TurnNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__TurnNumber_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__TurnNumber_k__BackingField)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000567A4 File Offset: 0x000549A4
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0000A7D3 File Offset: 0x000089D3
		public WargTime _CreatedAt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__CreatedAt_k__BackingField);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__CreatedAt_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000567D4 File Offset: 0x000549D4
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x0000A801 File Offset: 0x00008A01
		public WargTime _LastMove_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__LastMove_k__BackingField);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__LastMove_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00056804 File Offset: 0x00054A04
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x0000A82F File Offset: 0x00008A2F
		public WargTime _LastPlayed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__LastPlayed_k__BackingField);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__LastPlayed_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00056834 File Offset: 0x00054A34
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0000A85D File Offset: 0x00008A5D
		public unsafe string _ScenarioKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__ScenarioKey_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__ScenarioKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0005685C File Offset: 0x00054A5C
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0000A87C File Offset: 0x00008A7C
		public unsafe string _GameName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__GameName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__GameName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00056884 File Offset: 0x00054A84
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0000A89B File Offset: 0x00008A9B
		public unsafe string _GameState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__GameState_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__GameState_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000568AC File Offset: 0x00054AAC
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0000A8BA File Offset: 0x00008ABA
		public unsafe string _MatchType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__MatchType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr__MatchType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000568D4 File Offset: 0x00054AD4
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0000A8D9 File Offset: 0x00008AD9
		public unsafe ReadOnlyList<DataComposition> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00056904 File Offset: 0x00054B04
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		public unsafe List<DataComposition> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGameData.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr__ActivePlayer_k__BackingField;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr__SelectionPlayers_k__BackingField;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr__TurnNumber_k__BackingField;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr__CreatedAt_k__BackingField;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr__LastMove_k__BackingField;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr__LastPlayed_k__BackingField;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr__ScenarioKey_k__BackingField;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr__GameName_k__BackingField;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr__GameState_k__BackingField;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr__MatchType_k__BackingField;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivePlayer_Public_get_AccountID_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivePlayer_Private_set_Void_AccountID_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPlayers_Public_get_List_1_AccountID_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionPlayers_Private_set_Void_List_1_AccountID_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnNumber_Public_get_Int32_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_set_TurnNumber_Private_set_Void_Int32_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatedAt_Public_get_WargTime_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_set_CreatedAt_Private_set_Void_WargTime_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_get_LastMove_Public_get_WargTime_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_set_LastMove_Private_set_Void_WargTime_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_get_LastPlayed_Public_get_WargTime_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_set_LastPlayed_Private_set_Void_WargTime_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_get_ScenarioKey_Public_get_String_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_set_ScenarioKey_Private_set_Void_String_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_get_GameName_Public_get_String_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_set_GameName_Private_set_Void_String_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_get_GameState_Public_get_String_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_set_GameState_Private_set_Void_String_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_String_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWith_Public_Void_SaveMetaData_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_MarkCompleted_Public_Void_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
