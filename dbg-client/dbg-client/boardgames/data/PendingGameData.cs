using System;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game;

namespace boardgames.data
{
	// Token: 0x02000188 RID: 392
	public class PendingGameData : VersionedDataComponent
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00053B70 File Offset: 0x00051D70
		// Note: this type is marked as 'beforefieldinit'.
		static PendingGameData()
		{
			Il2CppClassPointerStore<PendingGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PendingGameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr);
			PendingGameData.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<Name>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<GameID>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__CreatorID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<CreatorID>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__MaxPlayerSessionCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<MaxPlayerSessionCount>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__CurrentPlayerSessionCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<CurrentPlayerSessionCount>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__AIPlayerCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<AIPlayerCount>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__AlreadyInGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<AlreadyInGame>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__HasPassword_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<HasPassword>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__MatchType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<MatchType>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__MatchIsEmpty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<MatchIsEmpty>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__MatchInitData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<MatchInitData>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<Options>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__Password_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<Password>k__BackingField");
			PendingGameData.NativeFieldInfoPtr__PlayersInGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<PlayersInGame>k__BackingField");
			PendingGameData.NativeFieldInfoPtr_playerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "playerData");
			PendingGameData.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665684);
			PendingGameData.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665685);
			PendingGameData.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665686);
			PendingGameData.NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665687);
			PendingGameData.NativeMethodInfoPtr_get_CreatorID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665688);
			PendingGameData.NativeMethodInfoPtr_set_CreatorID_Private_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665689);
			PendingGameData.NativeMethodInfoPtr_get_MaxPlayerSessionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665690);
			PendingGameData.NativeMethodInfoPtr_set_MaxPlayerSessionCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665691);
			PendingGameData.NativeMethodInfoPtr_get_CurrentPlayerSessionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665692);
			PendingGameData.NativeMethodInfoPtr_set_CurrentPlayerSessionCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665693);
			PendingGameData.NativeMethodInfoPtr_get_AIPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665694);
			PendingGameData.NativeMethodInfoPtr_set_AIPlayerCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665695);
			PendingGameData.NativeMethodInfoPtr_get_AlreadyInGame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665696);
			PendingGameData.NativeMethodInfoPtr_set_AlreadyInGame_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665697);
			PendingGameData.NativeMethodInfoPtr_get_HasPassword_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665698);
			PendingGameData.NativeMethodInfoPtr_set_HasPassword_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665699);
			PendingGameData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665700);
			PendingGameData.NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665701);
			PendingGameData.NativeMethodInfoPtr_get_MatchIsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665702);
			PendingGameData.NativeMethodInfoPtr_set_MatchIsEmpty_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665703);
			PendingGameData.NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665704);
			PendingGameData.NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665705);
			PendingGameData.NativeMethodInfoPtr_get_Options_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665706);
			PendingGameData.NativeMethodInfoPtr_set_Options_Private_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665707);
			PendingGameData.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665708);
			PendingGameData.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665709);
			PendingGameData.NativeMethodInfoPtr_get_PlayersInGame_Public_get_List_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665710);
			PendingGameData.NativeMethodInfoPtr_set_PlayersInGame_Private_set_Void_List_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665711);
			PendingGameData.NativeMethodInfoPtr_get_PlayerData_Public_get_IReadOnlyList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665712);
			PendingGameData.NativeMethodInfoPtr_get_ShowPlayerNameBeforeJoining_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665713);
			PendingGameData.NativeMethodInfoPtr_get_DontShowPlayerNameBeforeJoiningLocString_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665714);
			PendingGameData.NativeMethodInfoPtr_get_IsXboxOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665715);
			PendingGameData.NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665716);
			PendingGameData.NativeMethodInfoPtr_UpdateWith_Public_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665717);
			PendingGameData.NativeMethodInfoPtr_UpdatePlayerMetadata_Public_Void_AccountID_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665718);
			PendingGameData.NativeMethodInfoPtr_GetFriends_Public_List_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665719);
			PendingGameData.NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_New_IEnumerable_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665720);
			PendingGameData.NativeMethodInfoPtr_updateWith_Protected_Virtual_New_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665721);
			PendingGameData.NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_New_Void_AccountID_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665722);
			PendingGameData.NativeMethodInfoPtr_getDefaultAIAvatar_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665723);
			PendingGameData.NativeMethodInfoPtr_deserializeMatchInitData_Protected_Abstract_Virtual_New_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, 100665724);
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00054000 File Offset: 0x00052200
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00054038 File Offset: 0x00052238
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0005407C File Offset: 0x0005227C
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x000540BC File Offset: 0x000522BC
		public unsafe GameID GameID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00054100 File Offset: 0x00052300
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x00054140 File Offset: 0x00052340
		public unsafe AccountID CreatorID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_CreatorID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_CreatorID_Private_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00054184 File Offset: 0x00052384
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x000541C0 File Offset: 0x000523C0
		public unsafe int MaxPlayerSessionCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_MaxPlayerSessionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_MaxPlayerSessionCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00054200 File Offset: 0x00052400
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x0005423C File Offset: 0x0005243C
		public unsafe int CurrentPlayerSessionCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_CurrentPlayerSessionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_CurrentPlayerSessionCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0005427C File Offset: 0x0005247C
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x000542B8 File Offset: 0x000524B8
		public unsafe int AIPlayerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_AIPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_AIPlayerCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x000542F8 File Offset: 0x000524F8
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00054334 File Offset: 0x00052534
		public unsafe bool AlreadyInGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_AlreadyInGame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_AlreadyInGame_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00054374 File Offset: 0x00052574
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x000543B0 File Offset: 0x000525B0
		public unsafe bool HasPassword
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_HasPassword_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_HasPassword_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x000543F0 File Offset: 0x000525F0
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x00054428 File Offset: 0x00052628
		public unsafe string MatchType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0005446C File Offset: 0x0005266C
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x000544A8 File Offset: 0x000526A8
		public unsafe bool MatchIsEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_MatchIsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_MatchIsEmpty_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x000544E8 File Offset: 0x000526E8
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00054528 File Offset: 0x00052728
		public unsafe MatchInitData MatchInitData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0005456C File Offset: 0x0005276C
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x000545AC File Offset: 0x000527AC
		public unsafe Dictionary<string, string> Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_Options_Public_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_Options_Private_set_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000545F0 File Offset: 0x000527F0
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00054628 File Offset: 0x00052828
		public unsafe string Password
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0005466C File Offset: 0x0005286C
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x000546AC File Offset: 0x000528AC
		public unsafe List<AccountIDUsernameMetadata> PlayersInGame
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_PlayersInGame_Public_get_List_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_set_PlayersInGame_Private_set_Void_List_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000546F0 File Offset: 0x000528F0
		public unsafe IReadOnlyList<DataComposition> PlayerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_PlayerData_Public_get_IReadOnlyList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00054730 File Offset: 0x00052930
		public unsafe virtual bool ShowPlayerNameBeforeJoining
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_get_ShowPlayerNameBeforeJoining_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00054778 File Offset: 0x00052978
		public unsafe virtual string DontShowPlayerNameBeforeJoiningLocString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514569, XrefRangeEnd = 514571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_get_DontShowPlayerNameBeforeJoiningLocString_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x000547BC File Offset: 0x000529BC
		public unsafe bool IsXboxOnly
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 514580, RefRangeEnd = 514583, XrefRangeStart = 514571, XrefRangeEnd = 514580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_get_IsXboxOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000547F8 File Offset: 0x000529F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514592, RefRangeEnd = 514593, XrefRangeStart = 514583, XrefRangeEnd = 514592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingGameData(DWDPendingGameMetadata gameMetadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00054844 File Offset: 0x00052A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514970, RefRangeEnd = 514971, XrefRangeStart = 514593, XrefRangeEnd = 514970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWith(DWDPendingGameMetadata gameMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_UpdateWith_Public_Void_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00054888 File Offset: 0x00052A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515034, RefRangeEnd = 515035, XrefRangeStart = 514971, XrefRangeEnd = 515034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerMetadata(AccountID accountID, Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_UpdatePlayerMetadata_Public_Void_AccountID_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000548DC File Offset: 0x00052ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515046, RefRangeEnd = 515047, XrefRangeStart = 515035, XrefRangeEnd = 515046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<AccountIDUsernameMetadata> GetFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.NativeMethodInfoPtr_GetFriends_Public_List_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr3) : null;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005491C File Offset: 0x00052B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515047, XrefRangeEnd = 515052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<DataComponent> additionalComponentsForPlayerComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_New_IEnumerable_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00054968 File Offset: 0x00052B68
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void updateWith(DWDPendingGameMetadata gameMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_updateWith_Protected_Virtual_New_Void_DWDPendingGameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x000549B8 File Offset: 0x00052BB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void updatePlayerMetadata(AccountID accountID, Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_New_Void_AccountID_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00054A18 File Offset: 0x00052C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515052, XrefRangeEnd = 515054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string getDefaultAIAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_getDefaultAIAvatar_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00054A5C File Offset: 0x00052C5C
		[CallerCount(0)]
		public unsafe virtual MatchInitData deserializeMatchInitData(string matchInitDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(matchInitDataString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGameData.NativeMethodInfoPtr_deserializeMatchInitData_Protected_Abstract_Virtual_New_MatchInitData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0000A40B File Offset: 0x0000860B
		public PendingGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00054AB8 File Offset: 0x00052CB8
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0000A414 File Offset: 0x00008614
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00054AE0 File Offset: 0x00052CE0
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0000A433 File Offset: 0x00008633
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00054B10 File Offset: 0x00052D10
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0000A452 File Offset: 0x00008652
		public unsafe AccountID _CreatorID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__CreatorID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__CreatorID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00054B40 File Offset: 0x00052D40
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0000A471 File Offset: 0x00008671
		public unsafe int _MaxPlayerSessionCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MaxPlayerSessionCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MaxPlayerSessionCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00054B68 File Offset: 0x00052D68
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0000A48C File Offset: 0x0000868C
		public unsafe int _CurrentPlayerSessionCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__CurrentPlayerSessionCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__CurrentPlayerSessionCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00054B90 File Offset: 0x00052D90
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0000A4A7 File Offset: 0x000086A7
		public unsafe int _AIPlayerCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__AIPlayerCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__AIPlayerCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00054BB8 File Offset: 0x00052DB8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0000A4C2 File Offset: 0x000086C2
		public unsafe bool _AlreadyInGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__AlreadyInGame_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__AlreadyInGame_k__BackingField)) = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00054BE0 File Offset: 0x00052DE0
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0000A4DD File Offset: 0x000086DD
		public unsafe bool _HasPassword_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__HasPassword_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__HasPassword_k__BackingField)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00054C08 File Offset: 0x00052E08
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public unsafe string _MatchType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00054C30 File Offset: 0x00052E30
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0000A517 File Offset: 0x00008717
		public unsafe bool _MatchIsEmpty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchIsEmpty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchIsEmpty_k__BackingField)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00054C58 File Offset: 0x00052E58
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0000A532 File Offset: 0x00008732
		public unsafe MatchInitData _MatchInitData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchInitData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__MatchInitData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00054C88 File Offset: 0x00052E88
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0000A551 File Offset: 0x00008751
		public unsafe Dictionary<string, string> _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00054CB8 File Offset: 0x00052EB8
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0000A570 File Offset: 0x00008770
		public unsafe string _Password_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Password_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__Password_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00054CE0 File Offset: 0x00052EE0
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x0000A58F File Offset: 0x0000878F
		public unsafe List<AccountIDUsernameMetadata> _PlayersInGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__PlayersInGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr__PlayersInGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00054D10 File Offset: 0x00052F10
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0000A5AE File Offset: 0x000087AE
		public unsafe List<DataComposition> playerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr_playerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.NativeFieldInfoPtr_playerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeFieldInfoPtr__CreatorID_k__BackingField;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeFieldInfoPtr__MaxPlayerSessionCount_k__BackingField;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerSessionCount_k__BackingField;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeFieldInfoPtr__AIPlayerCount_k__BackingField;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr__AlreadyInGame_k__BackingField;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr__HasPassword_k__BackingField;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr__MatchType_k__BackingField;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr__MatchIsEmpty_k__BackingField;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr__MatchInitData_k__BackingField;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr__Password_k__BackingField;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr__PlayersInGame_k__BackingField;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_playerData;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatorID_Public_get_AccountID_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_set_CreatorID_Private_set_Void_AccountID_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxPlayerSessionCount_Public_get_Int32_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxPlayerSessionCount_Private_set_Void_Int32_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerSessionCount_Public_get_Int32_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerSessionCount_Private_set_Void_Int32_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_AIPlayerCount_Public_get_Int32_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_set_AIPlayerCount_Private_set_Void_Int32_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_get_AlreadyInGame_Public_get_Boolean_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_set_AlreadyInGame_Private_set_Void_Boolean_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPassword_Public_get_Boolean_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_set_HasPassword_Private_set_Void_Boolean_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_String_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchType_Private_set_Void_String_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchIsEmpty_Public_get_Boolean_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchIsEmpty_Private_set_Void_Boolean_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchInitData_Private_set_Void_MatchInitData_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_Dictionary_2_String_String_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_set_Options_Private_set_Void_Dictionary_2_String_String_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Private_set_Void_String_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersInGame_Public_get_List_1_AccountIDUsernameMetadata_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayersInGame_Private_set_Void_List_1_AccountIDUsernameMetadata_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerData_Public_get_IReadOnlyList_1_DataComposition_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowPlayerNameBeforeJoining_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_DontShowPlayerNameBeforeJoiningLocString_Protected_Virtual_New_get_String_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXboxOnly_Public_get_Boolean_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWith_Public_Void_DWDPendingGameMetadata_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerMetadata_Public_Void_AccountID_Dictionary_2_String_String_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetFriends_Public_List_1_AccountIDUsernameMetadata_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_New_IEnumerable_1_DataComponent_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_updateWith_Protected_Virtual_New_Void_DWDPendingGameMetadata_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_New_Void_AccountID_Dictionary_2_String_String_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_getDefaultAIAvatar_Protected_Virtual_New_String_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_deserializeMatchInitData_Protected_Abstract_Virtual_New_MatchInitData_String_0;

		// Token: 0x02000375 RID: 885
		[ObfuscatedName("boardgames.data.PendingGameData+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Object
		{
			// Token: 0x0600299D RID: 10653 RVA: 0x000A4EFC File Offset: 0x000A30FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr);
				PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr_myAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, "myAccountID");
				PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, 100665725);
				PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, 100665726);
				PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, 100665727);
				PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__2_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr, 100665728);
			}

			// Token: 0x0600299E RID: 10654 RVA: 0x000A4FA0 File Offset: 0x000A31A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600299F RID: 10655 RVA: 0x000A4FDC File Offset: 0x000A31DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514444, XrefRangeEnd = 514449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029A0 RID: 10656 RVA: 0x000A502C File Offset: 0x000A322C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514449, XrefRangeEnd = 514454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__1(AccountIDUsernameMetadata player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029A1 RID: 10657 RVA: 0x000A507C File Offset: 0x000A327C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514454, XrefRangeEnd = 514466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__2(AccountIDUsernameMetadata f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdateWith_b__2_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029A2 RID: 10658 RVA: 0x000157BB File Offset: 0x000139BB
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000A50CC File Offset: 0x000A32CC
			// (set) Token: 0x060029A4 RID: 10660 RVA: 0x000157C4 File Offset: 0x000139C4
			public unsafe AccountID myAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr_myAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr_myAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000A50FC File Offset: 0x000A32FC
			// (set) Token: 0x060029A6 RID: 10662 RVA: 0x000157E3 File Offset: 0x000139E3
			public unsafe PendingGameData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingGameData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019F9 RID: 6649
			private static readonly IntPtr NativeFieldInfoPtr_myAccountID;

			// Token: 0x040019FA RID: 6650
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019FB RID: 6651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019FC RID: 6652
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;

			// Token: 0x040019FD RID: 6653
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__1_Internal_Boolean_AccountIDUsernameMetadata_0;

			// Token: 0x040019FE RID: 6654
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__2_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000376 RID: 886
		[ObfuscatedName("boardgames.data.PendingGameData+<>c__DisplayClass66_1")]
		public sealed class __c__DisplayClass66_1 : Object
		{
			// Token: 0x060029A7 RID: 10663 RVA: 0x000A512C File Offset: 0x000A332C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_1()
			{
				Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<>c__DisplayClass66_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr);
				PendingGameData.__c__DisplayClass66_1.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr, "f");
				PendingGameData.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr, 100665729);
				PendingGameData.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdateWith_b__3_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr, 100665730);
			}

			// Token: 0x060029A8 RID: 10664 RVA: 0x000A5194 File Offset: 0x000A3394
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A9 RID: 10665 RVA: 0x000A51D0 File Offset: 0x000A33D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514466, XrefRangeEnd = 514471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__3(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdateWith_b__3_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029AA RID: 10666 RVA: 0x00015802 File Offset: 0x00013A02
			public __c__DisplayClass66_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x060029AB RID: 10667 RVA: 0x000A5220 File Offset: 0x000A3420
			// (set) Token: 0x060029AC RID: 10668 RVA: 0x0001580B File Offset: 0x00013A0B
			public unsafe AccountIDUsernameMetadata f
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_1.NativeFieldInfoPtr_f);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_1.NativeFieldInfoPtr_f), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019FF RID: 6655
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04001A00 RID: 6656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A01 RID: 6657
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__3_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000377 RID: 887
		[ObfuscatedName("boardgames.data.PendingGameData+<>c__DisplayClass66_2")]
		public sealed class __c__DisplayClass66_2 : Object
		{
			// Token: 0x060029AD RID: 10669 RVA: 0x000A5250 File Offset: 0x000A3450
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_2()
			{
				Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<>c__DisplayClass66_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr);
				PendingGameData.__c__DisplayClass66_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr, "data");
				PendingGameData.__c__DisplayClass66_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr, 100665731);
				PendingGameData.__c__DisplayClass66_2.NativeMethodInfoPtr__UpdateWith_b__4_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr, 100665732);
			}

			// Token: 0x060029AE RID: 10670 RVA: 0x000A52B8 File Offset: 0x000A34B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass66_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029AF RID: 10671 RVA: 0x000A52F4 File Offset: 0x000A34F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514471, XrefRangeEnd = 514479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__4(AccountIDUsernameMetadata x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass66_2.NativeMethodInfoPtr__UpdateWith_b__4_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029B0 RID: 10672 RVA: 0x0001582A File Offset: 0x00013A2A
			public __c__DisplayClass66_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000A5344 File Offset: 0x000A3544
			// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00015833 File Offset: 0x00013A33
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass66_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A02 RID: 6658
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001A03 RID: 6659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A04 RID: 6660
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__4_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000378 RID: 888
		[ObfuscatedName("boardgames.data.PendingGameData+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Object
		{
			// Token: 0x060029B3 RID: 10675 RVA: 0x000A5374 File Offset: 0x000A3574
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr);
				PendingGameData.__c__DisplayClass67_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr, "accountID");
				PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr, 100665733);
				PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__UpdatePlayerMetadata_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr, 100665734);
				PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__UpdatePlayerMetadata_b__1_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr, 100665735);
			}

			// Token: 0x060029B4 RID: 10676 RVA: 0x000A53F0 File Offset: 0x000A35F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029B5 RID: 10677 RVA: 0x000A542C File Offset: 0x000A362C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514479, XrefRangeEnd = 514484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdatePlayerMetadata_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__UpdatePlayerMetadata_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029B6 RID: 10678 RVA: 0x000A547C File Offset: 0x000A367C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514484, XrefRangeEnd = 514562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdatePlayerMetadata_b__1(DataComposition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData.__c__DisplayClass67_0.NativeMethodInfoPtr__UpdatePlayerMetadata_b__1_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029B7 RID: 10679 RVA: 0x00015852 File Offset: 0x00013A52
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000A54CC File Offset: 0x000A36CC
			// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0001585B File Offset: 0x00013A5B
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass67_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData.__c__DisplayClass67_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A05 RID: 6661
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001A06 RID: 6662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A07 RID: 6663
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePlayerMetadata_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;

			// Token: 0x04001A08 RID: 6664
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePlayerMetadata_b__1_Internal_Boolean_DataComposition_0;
		}

		// Token: 0x02000379 RID: 889
		[ObfuscatedName("boardgames.data.PendingGameData+<additionalComponentsForPlayerComposition>d__69")]
		public sealed class _additionalComponentsForPlayerComposition_d__69 : Object
		{
			// Token: 0x060029BA RID: 10682 RVA: 0x000A54FC File Offset: 0x000A36FC
			// Note: this type is marked as 'beforefieldinit'.
			static _additionalComponentsForPlayerComposition_d__69()
			{
				Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PendingGameData>.NativeClassPtr, "<additionalComponentsForPlayerComposition>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, "<>1__state");
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, "<>2__current");
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, "<>l__initialThreadId");
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665736);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665737);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665738);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665739);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665740);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665741);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665742);
				PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr, 100665743);
			}

			// Token: 0x060029BB RID: 10683 RVA: 0x000A5604 File Offset: 0x000A3804
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _additionalComponentsForPlayerComposition_d__69(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData._additionalComponentsForPlayerComposition_d__69>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029BC RID: 10684 RVA: 0x000A564C File Offset: 0x000A384C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029BD RID: 10685 RVA: 0x000A5680 File Offset: 0x000A3880
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x060029BE RID: 10686 RVA: 0x000A56BC File Offset: 0x000A38BC
			public unsafe DataComponent System.Collections.Generic.IEnumerator<dwd.core.data.composition.DataComponent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
				}
			}

			// Token: 0x060029BF RID: 10687 RVA: 0x000A56FC File Offset: 0x000A38FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514562, XrefRangeEnd = 514567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000A5730 File Offset: 0x000A3930
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029C1 RID: 10689 RVA: 0x000A5770 File Offset: 0x000A3970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514567, XrefRangeEnd = 514569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<DataComponent> System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DataComponent>>(intPtr3) : null;
			}

			// Token: 0x060029C2 RID: 10690 RVA: 0x000A57B0 File Offset: 0x000A39B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060029C3 RID: 10691 RVA: 0x0001587A File Offset: 0x00013A7A
			public _additionalComponentsForPlayerComposition_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000A57F0 File Offset: 0x000A39F0
			// (set) Token: 0x060029C5 RID: 10693 RVA: 0x00015883 File Offset: 0x00013A83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000A5818 File Offset: 0x000A3A18
			// (set) Token: 0x060029C7 RID: 10695 RVA: 0x0001589E File Offset: 0x00013A9E
			public unsafe DataComponent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000A5848 File Offset: 0x000A3A48
			// (set) Token: 0x060029C9 RID: 10697 RVA: 0x000158BD File Offset: 0x00013ABD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGameData._additionalComponentsForPlayerComposition_d__69.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04001A09 RID: 6665
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A0A RID: 6666
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A0B RID: 6667
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001A0C RID: 6668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A0D RID: 6669
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A0E RID: 6670
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A0F RID: 6671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0;

			// Token: 0x04001A10 RID: 6672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A11 RID: 6673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A12 RID: 6674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0;

			// Token: 0x04001A13 RID: 6675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
