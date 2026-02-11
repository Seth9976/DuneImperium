using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using offlineChallenges.NetworkCommands;
using UnityEngine;
using UnityEngine.Events;

namespace offlineChallenges
{
	// Token: 0x02000007 RID: 7
	public class OfflineChallenges : MonoBehaviour
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000392C File Offset: 0x00001B2C
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineChallenges()
		{
			Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges", "OfflineChallenges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr);
			OfflineChallenges.NativeFieldInfoPtr_challengeCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "challengeCompleted");
			OfflineChallenges.NativeFieldInfoPtr_complexEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "complexEvents");
			OfflineChallenges.NativeFieldInfoPtr_ProgressPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "ProgressPrefKey");
			OfflineChallenges.NativeFieldInfoPtr_HighScoresPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "HighScoresPrefKey");
			OfflineChallenges.NativeFieldInfoPtr_LastAccountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "LastAccountKey");
			OfflineChallenges.NativeFieldInfoPtr_Special = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "Special");
			OfflineChallenges.NativeFieldInfoPtr_SteamAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "SteamAchievement");
			OfflineChallenges.NativeFieldInfoPtr__Challenges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "<Challenges>k__BackingField");
			OfflineChallenges.NativeFieldInfoPtr_ChallengesByID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "ChallengesByID");
			OfflineChallenges.NativeFieldInfoPtr_challengeHighScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "challengeHighScores");
			OfflineChallenges.NativeFieldInfoPtr_currentMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "currentMatch");
			OfflineChallenges.NativeFieldInfoPtr_challengesModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "challengesModel");
			OfflineChallenges.NativeFieldInfoPtr_challengeDeltas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "challengeDeltas");
			OfflineChallenges.NativeMethodInfoPtr_get_ChallengesActive_Protected_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663339);
			OfflineChallenges.NativeMethodInfoPtr_get_ChallengeCompleted_Public_Abstract_Virtual_New_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663340);
			OfflineChallenges.NativeMethodInfoPtr_InitialComplexEvents_Protected_Abstract_Virtual_New_IEnumerable_1_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663341);
			OfflineChallenges.NativeMethodInfoPtr_FireEvent_Private_Void_Event_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663342);
			OfflineChallenges.NativeMethodInfoPtr_AndroidAchievement_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663343);
			OfflineChallenges.NativeMethodInfoPtr_StaticAndroidAchievement_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663344);
			OfflineChallenges.NativeMethodInfoPtr_StaticXboxAchievement_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663345);
			OfflineChallenges.NativeMethodInfoPtr_get_Challenges_Public_get_List_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663346);
			OfflineChallenges.NativeMethodInfoPtr_set_Challenges_Private_set_Void_List_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663347);
			OfflineChallenges.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663348);
			OfflineChallenges.NativeMethodInfoPtr_Queue_Protected_Abstract_Virtual_New_IEnumerable_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663349);
			OfflineChallenges.NativeMethodInfoPtr_GetLevel_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663350);
			OfflineChallenges.NativeMethodInfoPtr_GetServerLevel_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663351);
			OfflineChallenges.NativeMethodInfoPtr_get_CompletedChallenges_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663352);
			OfflineChallenges.NativeMethodInfoPtr_IsChallengeComplete_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663353);
			OfflineChallenges.NativeMethodInfoPtr_GetChallengeHighScore_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663354);
			OfflineChallenges.NativeMethodInfoPtr_SetChallengeHighScore_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663355);
			OfflineChallenges.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663356);
			OfflineChallenges.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663357);
			OfflineChallenges.NativeMethodInfoPtr_ResetChallenges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663358);
			OfflineChallenges.NativeMethodInfoPtr_initModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663359);
			OfflineChallenges.NativeMethodInfoPtr_MatchStarted_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663360);
			OfflineChallenges.NativeMethodInfoPtr_SwitchToMatch_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663361);
			OfflineChallenges.NativeMethodInfoPtr_get_ActiveChallenges_Public_Abstract_Virtual_New_get_IEnumerable_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663362);
			OfflineChallenges.NativeMethodInfoPtr_SwitchAccount_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663363);
			OfflineChallenges.NativeMethodInfoPtr_WipeChallengeRelatedAccountIndependentPrefs_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663364);
			OfflineChallenges.NativeMethodInfoPtr_LoadComplexEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663365);
			OfflineChallenges.NativeMethodInfoPtr_LoadChallenges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663366);
			OfflineChallenges.NativeMethodInfoPtr_LoadChallengeHighScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663367);
			OfflineChallenges.NativeMethodInfoPtr_LoadProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663368);
			OfflineChallenges.NativeMethodInfoPtr_SaveProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663369);
			OfflineChallenges.NativeMethodInfoPtr_LoadFromDictionary_Public_Void_SyncChallenges_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663370);
			OfflineChallenges.NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Abstract_Virtual_New_Void_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663371);
			OfflineChallenges.NativeMethodInfoPtr_TryToSyncProgressWithServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663372);
			OfflineChallenges.NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Abstract_Virtual_New_IEnumerator_Dictionary_2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663373);
			OfflineChallenges.NativeMethodInfoPtr_SyncSucceeded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663374);
			OfflineChallenges.NativeMethodInfoPtr_MarkAllProgressAsChecked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663375);
			OfflineChallenges.NativeMethodInfoPtr_CheatChallengeProgress_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663376);
			OfflineChallenges.NativeMethodInfoPtr_CheatChallengeProgressOfID_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663377);
			OfflineChallenges.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, 100663378);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003D80 File Offset: 0x00001F80
		public unsafe virtual bool ChallengesActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_get_ChallengesActive_Protected_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public unsafe virtual UnityEvent ChallengeCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_get_ChallengeCompleted_Public_Abstract_Virtual_New_get_UnityEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003E14 File Offset: 0x00002014
		[CallerCount(0)]
		public unsafe virtual IEnumerable<OfflineChallenges.ComplexEvent> InitialComplexEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_InitialComplexEvents_Protected_Abstract_Virtual_New_IEnumerable_1_ComplexEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<OfflineChallenges.ComplexEvent>>(intPtr3) : null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003E60 File Offset: 0x00002060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1260414, RefRangeEnd = 1260417, XrefRangeStart = 1260366, XrefRangeEnd = 1260414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FireEvent(OfflineChallenges.Event evt, bool bypassCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_FireEvent_Private_Void_Event_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003EB0 File Offset: 0x000020B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260417, XrefRangeEnd = 1260420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AndroidAchievement(string googlePlayID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(googlePlayID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_AndroidAchievement_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003EF8 File Offset: 0x000020F8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1260423, RefRangeEnd = 1260466, XrefRangeStart = 1260420, XrefRangeEnd = 1260423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StaticAndroidAchievement(string googlePlayID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(googlePlayID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_StaticAndroidAchievement_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003F34 File Offset: 0x00002134
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1260469, RefRangeEnd = 1260512, XrefRangeStart = 1260466, XrefRangeEnd = 1260469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StaticXboxAchievement(string xbaid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xbaid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_StaticXboxAchievement_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003F70 File Offset: 0x00002170
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00003FB0 File Offset: 0x000021B0
		public unsafe List<ChallengeDefinition> Challenges
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_get_Challenges_Public_get_List_1_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ChallengeDefinition>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_set_Challenges_Private_set_Void_List_1_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003FF4 File Offset: 0x000021F4
		[CallerCount(0)]
		public unsafe virtual int NumberOfChallengesActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000403C File Offset: 0x0000223C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ChallengeDefinition> Queue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_Queue_Protected_Abstract_Virtual_New_IEnumerable_1_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ChallengeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004088 File Offset: 0x00002288
		[CallerCount(0)]
		public unsafe virtual int GetLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_GetLevel_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000040D0 File Offset: 0x000022D0
		[CallerCount(0)]
		public unsafe virtual int GetServerLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_GetServerLevel_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004118 File Offset: 0x00002318
		public unsafe int CompletedChallenges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260512, XrefRangeEnd = 1260530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_get_CompletedChallenges_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004154 File Offset: 0x00002354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260545, RefRangeEnd = 1260547, XrefRangeStart = 1260530, XrefRangeEnd = 1260545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChallengeComplete(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_IsChallengeComplete_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000041A4 File Offset: 0x000023A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260550, RefRangeEnd = 1260551, XrefRangeStart = 1260547, XrefRangeEnd = 1260550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChallengeHighScore(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_GetChallengeHighScore_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000041F4 File Offset: 0x000023F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260557, RefRangeEnd = 1260558, XrefRangeStart = 1260551, XrefRangeEnd = 1260557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChallengeHighScore(string name, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_SetChallengeHighScore_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004244 File Offset: 0x00002444
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004278 File Offset: 0x00002478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260558, XrefRangeEnd = 1260560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000042AC File Offset: 0x000024AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1260583, RefRangeEnd = 1260586, XrefRangeStart = 1260560, XrefRangeEnd = 1260583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetChallenges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_ResetChallenges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000042E0 File Offset: 0x000024E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260613, RefRangeEnd = 1260614, XrefRangeStart = 1260586, XrefRangeEnd = 1260613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_initModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004314 File Offset: 0x00002514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260653, RefRangeEnd = 1260654, XrefRangeStart = 1260614, XrefRangeEnd = 1260653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MatchStarted(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_MatchStarted_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004358 File Offset: 0x00002558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260654, XrefRangeEnd = 1260656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToMatch(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_SwitchToMatch_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000439C File Offset: 0x0000259C
		public unsafe virtual IEnumerable<ChallengeDefinition> ActiveChallenges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_get_ActiveChallenges_Public_Abstract_Virtual_New_get_IEnumerable_1_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ChallengeDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000043E8 File Offset: 0x000025E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260712, RefRangeEnd = 1260713, XrefRangeStart = 1260656, XrefRangeEnd = 1260712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchAccount(AccountID account)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_SwitchAccount_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000442C File Offset: 0x0000262C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WipeChallengeRelatedAccountIndependentPrefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_WipeChallengeRelatedAccountIndependentPrefs_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004468 File Offset: 0x00002668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260793, RefRangeEnd = 1260794, XrefRangeStart = 1260713, XrefRangeEnd = 1260793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadComplexEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_LoadComplexEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000449C File Offset: 0x0000269C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260821, RefRangeEnd = 1260822, XrefRangeStart = 1260794, XrefRangeEnd = 1260821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadChallenges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_LoadChallenges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000044D0 File Offset: 0x000026D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260822, XrefRangeEnd = 1260845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadChallengeHighScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_LoadChallengeHighScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004504 File Offset: 0x00002704
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1260870, RefRangeEnd = 1260875, XrefRangeStart = 1260845, XrefRangeEnd = 1260870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_LoadProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004538 File Offset: 0x00002738
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1260928, RefRangeEnd = 1260936, XrefRangeStart = 1260875, XrefRangeEnd = 1260928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_SaveProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000456C File Offset: 0x0000276C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1260954, RefRangeEnd = 1260957, XrefRangeStart = 1260936, XrefRangeEnd = 1260954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromDictionary(SyncChallenges dictionary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_LoadFromDictionary_Public_Void_SyncChallenges_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000045B0 File Offset: 0x000027B0
		[CallerCount(0)]
		public unsafe virtual void AttemptAchievementCompletion(ChallengeDefinition challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Abstract_Virtual_New_Void_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004600 File Offset: 0x00002800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1261016, RefRangeEnd = 1261020, XrefRangeStart = 1260957, XrefRangeEnd = 1261016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToSyncProgressWithServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_TryToSyncProgressWithServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004634 File Offset: 0x00002834
		[CallerCount(0)]
		public unsafe virtual IEnumerator SendSyncChallengesToServer(Dictionary<int, int> challengeDeltas, int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeDeltas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Abstract_Virtual_New_IEnumerator_Dictionary_2_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000046A0 File Offset: 0x000028A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261035, RefRangeEnd = 1261036, XrefRangeStart = 1261020, XrefRangeEnd = 1261035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSucceeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_SyncSucceeded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000046D4 File Offset: 0x000028D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1261051, RefRangeEnd = 1261054, XrefRangeStart = 1261036, XrefRangeEnd = 1261051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAllProgressAsChecked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_MarkAllProgressAsChecked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004708 File Offset: 0x00002908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261054, XrefRangeEnd = 1261066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheatChallengeProgress(int progress, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref progress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_CheatChallengeProgress_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004764 File Offset: 0x00002964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261066, XrefRangeEnd = 1261082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheatChallengeProgressOfID(int progress, int challengeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref progress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref challengeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr_CheatChallengeProgressOfID_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000047B0 File Offset: 0x000029B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261116, RefRangeEnd = 1261117, XrefRangeStart = 1261082, XrefRangeEnd = 1261116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineChallenges()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002196 File Offset: 0x00000396
		public OfflineChallenges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000047EC File Offset: 0x000029EC
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000219F File Offset: 0x0000039F
		public unsafe UnityEvent challengeCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000481C File Offset: 0x00002A1C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000021BE File Offset: 0x000003BE
		public unsafe Dictionary<GameID, Dictionary<int, OfflineChallenges.ComplexEvent>> complexEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_complexEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, Dictionary<int, OfflineChallenges.ComplexEvent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_complexEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000484C File Offset: 0x00002A4C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000021DD File Offset: 0x000003DD
		public unsafe static string ProgressPrefKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.NativeFieldInfoPtr_ProgressPrefKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.NativeFieldInfoPtr_ProgressPrefKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000486C File Offset: 0x00002A6C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe static string HighScoresPrefKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.NativeFieldInfoPtr_HighScoresPrefKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.NativeFieldInfoPtr_HighScoresPrefKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe static string LastAccountKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.NativeFieldInfoPtr_LastAccountKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.NativeFieldInfoPtr_LastAccountKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000048AC File Offset: 0x00002AAC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002213 File Offset: 0x00000413
		public unsafe static string Special
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.NativeFieldInfoPtr_Special, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.NativeFieldInfoPtr_Special, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000048CC File Offset: 0x00002ACC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002225 File Offset: 0x00000425
		public unsafe static string SteamAchievement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.NativeFieldInfoPtr_SteamAchievement, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.NativeFieldInfoPtr_SteamAchievement, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000048EC File Offset: 0x00002AEC
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002237 File Offset: 0x00000437
		public unsafe List<ChallengeDefinition> _Challenges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr__Challenges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChallengeDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr__Challenges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000491C File Offset: 0x00002B1C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe Dictionary<int, ChallengeDefinition> ChallengesByID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_ChallengesByID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ChallengeDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_ChallengesByID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe Dictionary<string, int> challengeHighScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeHighScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeHighScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000497C File Offset: 0x00002B7C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002294 File Offset: 0x00000494
		public unsafe GameID currentMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_currentMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_currentMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000049AC File Offset: 0x00002BAC
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000022B3 File Offset: 0x000004B3
		public unsafe ChallengesModel challengesModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengesModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengesModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengesModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000049DC File Offset: 0x00002BDC
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000022D2 File Offset: 0x000004D2
		public unsafe Dictionary<int, int> challengeDeltas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeDeltas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.NativeFieldInfoPtr_challengeDeltas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_challengeCompleted;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_complexEvents;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_ProgressPrefKey;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_HighScoresPrefKey;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_LastAccountKey;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_Special;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_SteamAchievement;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr__Challenges_k__BackingField;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_ChallengesByID;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_challengeHighScores;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_currentMatch;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_challengesModel;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_challengeDeltas;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengesActive_Protected_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengeCompleted_Public_Abstract_Virtual_New_get_UnityEvent_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_InitialComplexEvents_Protected_Abstract_Virtual_New_IEnumerable_1_ComplexEvent_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_FireEvent_Private_Void_Event_Boolean_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_AndroidAchievement_Public_String_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_StaticAndroidAchievement_Public_Static_String_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_StaticXboxAchievement_Public_Static_String_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_Challenges_Public_get_List_1_ChallengeDefinition_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenges_Private_set_Void_List_1_ChallengeDefinition_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Queue_Protected_Abstract_Virtual_New_IEnumerable_1_ChallengeDefinition_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetServerLevel_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedChallenges_Public_get_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_IsChallengeComplete_Public_Boolean_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_GetChallengeHighScore_Public_Int32_String_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_SetChallengeHighScore_Public_Void_String_Int32_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ResetChallenges_Private_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_initModel_Private_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_MatchStarted_Public_Void_GameID_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToMatch_Public_Void_GameID_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveChallenges_Public_Abstract_Virtual_New_get_IEnumerable_1_ChallengeDefinition_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_SwitchAccount_Public_Void_AccountID_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_WipeChallengeRelatedAccountIndependentPrefs_Protected_Virtual_New_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_LoadComplexEvents_Public_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_LoadChallenges_Public_Void_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_LoadChallengeHighScores_Private_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_LoadProgress_Public_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_SaveProgress_Public_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromDictionary_Public_Void_SyncChallenges_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Abstract_Virtual_New_Void_ChallengeDefinition_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_TryToSyncProgressWithServer_Public_Void_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Abstract_Virtual_New_IEnumerator_Dictionary_2_Int32_Int32_Int32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_SyncSucceeded_Public_Void_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_MarkAllProgressAsChecked_Public_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_CheatChallengeProgress_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_CheatChallengeProgressOfID_Public_Void_Int32_Int32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000017 RID: 23
		public class Event : global::Il2CppSystem.Object
		{
			// Token: 0x060000ED RID: 237 RVA: 0x00005938 File Offset: 0x00003B38
			// Note: this type is marked as 'beforefieldinit'.
			static Event()
			{
				Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "Event");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr);
				OfflineChallenges.Event.NativeMethodInfoPtr_Fire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr, 100663379);
				OfflineChallenges.Event.NativeMethodInfoPtr_FireWithoutCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr, 100663380);
				OfflineChallenges.Event.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr, 100663381);
			}

			// Token: 0x060000EE RID: 238 RVA: 0x000059A0 File Offset: 0x00003BA0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1260291, RefRangeEnd = 1260298, XrefRangeStart = 1260286, XrefRangeEnd = 1260291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Fire()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.Event.NativeMethodInfoPtr_Fire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x000059D4 File Offset: 0x00003BD4
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1260303, RefRangeEnd = 1260318, XrefRangeStart = 1260298, XrefRangeEnd = 1260303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FireWithoutCheck()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.Event.NativeMethodInfoPtr_FireWithoutCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00005A08 File Offset: 0x00003C08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Event()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges.Event>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.Event.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000026FC File Offset: 0x000008FC
			public Event(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Void_0;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeMethodInfoPtr_FireWithoutCheck_Public_Void_0;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x02000018 RID: 24
		[Serializable]
		public class ComplexEvent : OfflineChallenges.Event
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x00005A44 File Offset: 0x00003C44
			// Note: this type is marked as 'beforefieldinit'.
			static ComplexEvent()
			{
				Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "ComplexEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr);
				OfflineChallenges.ComplexEvent.NativeFieldInfoPtr__EventID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr, "<EventID>k__BackingField");
				OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_get_EventID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr, 100663382);
				OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_set_EventID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr, 100663383);
				OfflineChallenges.ComplexEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr, 100663384);
				OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr, 100663385);
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005AD4 File Offset: 0x00003CD4
			// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005B10 File Offset: 0x00003D10
			public unsafe int EventID
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_get_EventID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_set_EventID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00005B50 File Offset: 0x00003D50
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ComplexEvent(int eventID)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges.ComplexEvent>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref eventID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.ComplexEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00005B98 File Offset: 0x00003D98
			[CallerCount(0)]
			public unsafe virtual void Process(OfflineChallenges.Event evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineChallenges.ComplexEvent.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00002705 File Offset: 0x00000905
			public ComplexEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005BE8 File Offset: 0x00003DE8
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000270E File Offset: 0x0000090E
			public unsafe int _EventID_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.ComplexEvent.NativeFieldInfoPtr__EventID_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.ComplexEvent.NativeFieldInfoPtr__EventID_k__BackingField)) = value;
				}
			}

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeFieldInfoPtr__EventID_k__BackingField;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr_get_EventID_Public_get_Int32_0;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeMethodInfoPtr_set_EventID_Private_set_Void_Int32_0;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_Event_0;
		}

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("offlineChallenges.OfflineChallenges+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060000FA RID: 250 RVA: 0x00005C10 File Offset: 0x00003E10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr);
				OfflineChallenges.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__31_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__37_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__39_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__43_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__45_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__49_1");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__49_0");
				OfflineChallenges.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, "<>9__53_0");
				OfflineChallenges.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663387);
				OfflineChallenges.__c.NativeMethodInfoPtr__get_CompletedChallenges_b__31_0_Internal_Boolean_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663388);
				OfflineChallenges.__c.NativeMethodInfoPtr__ResetChallenges_b__37_0_Internal_Int32_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663389);
				OfflineChallenges.__c.NativeMethodInfoPtr__MatchStarted_b__39_0_Internal_Int32_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663390);
				OfflineChallenges.__c.NativeMethodInfoPtr__SwitchAccount_b__43_0_Internal_Int32_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663391);
				OfflineChallenges.__c.NativeMethodInfoPtr__LoadComplexEvents_b__45_0_Internal_Int32_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663392);
				OfflineChallenges.__c.NativeMethodInfoPtr__SaveProgress_b__49_0_Internal_String_KeyValuePair_2_GameID_Dictionary_2_Int32_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663393);
				OfflineChallenges.__c.NativeMethodInfoPtr__SaveProgress_b__49_1_Internal_String_KeyValuePair_2_Int32_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663394);
				OfflineChallenges.__c.NativeMethodInfoPtr__TryToSyncProgressWithServer_b__53_0_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr, 100663395);
			}

			// Token: 0x060000FB RID: 251 RVA: 0x00005DA4 File Offset: 0x00003FA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00005DE0 File Offset: 0x00003FE0
			[CallerCount(0)]
			public unsafe bool _get_CompletedChallenges_b__31_0(ChallengeDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__get_CompletedChallenges_b__31_0_Internal_Boolean_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00005E30 File Offset: 0x00004030
			[CallerCount(0)]
			public unsafe int _ResetChallenges_b__37_0(ChallengeDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__ResetChallenges_b__37_0_Internal_Int32_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00005E80 File Offset: 0x00004080
			[CallerCount(0)]
			public unsafe int _MatchStarted_b__39_0(OfflineChallenges.ComplexEvent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__MatchStarted_b__39_0_Internal_Int32_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00005ED0 File Offset: 0x000040D0
			[CallerCount(0)]
			public unsafe int _SwitchAccount_b__43_0(ChallengeDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__SwitchAccount_b__43_0_Internal_Int32_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00005F20 File Offset: 0x00004120
			[CallerCount(0)]
			public unsafe int _LoadComplexEvents_b__45_0(OfflineChallenges.ComplexEvent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__LoadComplexEvents_b__45_0_Internal_Int32_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00005F70 File Offset: 0x00004170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260318, XrefRangeEnd = 1260348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SaveProgress_b__49_0(KeyValuePair<GameID, Dictionary<int, OfflineChallenges.ComplexEvent>> game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(game));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__SaveProgress_b__49_0_Internal_String_KeyValuePair_2_GameID_Dictionary_2_Int32_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00005FC0 File Offset: 0x000041C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260348, XrefRangeEnd = 1260355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SaveProgress_b__49_1(KeyValuePair<int, OfflineChallenges.ComplexEvent> evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(evt));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__SaveProgress_b__49_1_Internal_String_KeyValuePair_2_Int32_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00006010 File Offset: 0x00004210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260355, XrefRangeEnd = 1260362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryToSyncProgressWithServer_b__53_0(KeyValuePair<int, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c.NativeMethodInfoPtr__TryToSyncProgressWithServer_b__53_0_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00002729 File Offset: 0x00000929
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000105 RID: 261 RVA: 0x00006060 File Offset: 0x00004260
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00002732 File Offset: 0x00000932
			public unsafe static OfflineChallenges.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineChallenges.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000107 RID: 263 RVA: 0x00006088 File Offset: 0x00004288
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00002744 File Offset: 0x00000944
			public unsafe static Func<ChallengeDefinition, bool> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChallengeDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000109 RID: 265 RVA: 0x000060B0 File Offset: 0x000042B0
			// (set) Token: 0x0600010A RID: 266 RVA: 0x00002756 File Offset: 0x00000956
			public unsafe static Func<ChallengeDefinition, int> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChallengeDefinition, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600010B RID: 267 RVA: 0x000060D8 File Offset: 0x000042D8
			// (set) Token: 0x0600010C RID: 268 RVA: 0x00002768 File Offset: 0x00000968
			public unsafe static Func<OfflineChallenges.ComplexEvent, int> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OfflineChallenges.ComplexEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00006100 File Offset: 0x00004300
			// (set) Token: 0x0600010E RID: 270 RVA: 0x0000277A File Offset: 0x0000097A
			public unsafe static Func<ChallengeDefinition, int> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChallengeDefinition, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00006128 File Offset: 0x00004328
			// (set) Token: 0x06000110 RID: 272 RVA: 0x0000278C File Offset: 0x0000098C
			public unsafe static Func<OfflineChallenges.ComplexEvent, int> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OfflineChallenges.ComplexEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000111 RID: 273 RVA: 0x00006150 File Offset: 0x00004350
			// (set) Token: 0x06000112 RID: 274 RVA: 0x0000279E File Offset: 0x0000099E
			public unsafe static Func<KeyValuePair<int, OfflineChallenges.ComplexEvent>, string> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, OfflineChallenges.ComplexEvent>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000113 RID: 275 RVA: 0x00006178 File Offset: 0x00004378
			// (set) Token: 0x06000114 RID: 276 RVA: 0x000027B0 File Offset: 0x000009B0
			public unsafe static Func<KeyValuePair<GameID, Dictionary<int, OfflineChallenges.ComplexEvent>>, string> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<GameID, Dictionary<int, OfflineChallenges.ComplexEvent>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000115 RID: 277 RVA: 0x000061A0 File Offset: 0x000043A0
			// (set) Token: 0x06000116 RID: 278 RVA: 0x000027C2 File Offset: 0x000009C2
			public unsafe static Func<KeyValuePair<int, int>, string> __9__53_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OfflineChallenges.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr__get_CompletedChallenges_b__31_0_Internal_Boolean_ChallengeDefinition_0;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeMethodInfoPtr__ResetChallenges_b__37_0_Internal_Int32_ChallengeDefinition_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr__MatchStarted_b__39_0_Internal_Int32_ComplexEvent_0;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr__SwitchAccount_b__43_0_Internal_Int32_ChallengeDefinition_0;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr__LoadComplexEvents_b__45_0_Internal_Int32_ComplexEvent_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr__SaveProgress_b__49_0_Internal_String_KeyValuePair_2_GameID_Dictionary_2_Int32_ComplexEvent_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr__SaveProgress_b__49_1_Internal_String_KeyValuePair_2_Int32_ComplexEvent_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr__TryToSyncProgressWithServer_b__53_0_Internal_String_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("offlineChallenges.OfflineChallenges+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000117 RID: 279 RVA: 0x000061C8 File Offset: 0x000043C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr);
				OfflineChallenges.__c__DisplayClass32_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr, "name");
				OfflineChallenges.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr, 100663396);
				OfflineChallenges.__c__DisplayClass32_0.NativeMethodInfoPtr__IsChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr, 100663397);
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00006230 File Offset: 0x00004430
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x0000626C File Offset: 0x0000446C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260362, XrefRangeEnd = 1260363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsChallengeComplete_b__0(ChallengeDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c__DisplayClass32_0.NativeMethodInfoPtr__IsChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600011A RID: 282 RVA: 0x000027D4 File Offset: 0x000009D4
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000062BC File Offset: 0x000044BC
			// (set) Token: 0x0600011C RID: 284 RVA: 0x000027DD File Offset: 0x000009DD
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.__c__DisplayClass32_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.__c__DisplayClass32_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeMethodInfoPtr__IsChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0;
		}

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("offlineChallenges.OfflineChallenges+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600011D RID: 285 RVA: 0x000062E4 File Offset: 0x000044E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineChallenges>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr);
				OfflineChallenges.__c__DisplayClass43_0.NativeFieldInfoPtr_oldChallengesByID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr, "oldChallengesByID");
				OfflineChallenges.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr, 100663398);
				OfflineChallenges.__c__DisplayClass43_0.NativeMethodInfoPtr__SwitchAccount_b__1_Internal_Void_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr, 100663399);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x0000634C File Offset: 0x0000454C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineChallenges.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00006388 File Offset: 0x00004588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260363, XrefRangeEnd = 1260366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SwitchAccount_b__1(ChallengeDefinition challenge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineChallenges.__c__DisplayClass43_0.NativeMethodInfoPtr__SwitchAccount_b__1_Internal_Void_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000120 RID: 288 RVA: 0x000027FC File Offset: 0x000009FC
			public __c__DisplayClass43_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000121 RID: 289 RVA: 0x000063CC File Offset: 0x000045CC
			// (set) Token: 0x06000122 RID: 290 RVA: 0x00002805 File Offset: 0x00000A05
			public unsafe Dictionary<int, ChallengeDefinition> oldChallengesByID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.__c__DisplayClass43_0.NativeFieldInfoPtr_oldChallengesByID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ChallengeDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineChallenges.__c__DisplayClass43_0.NativeFieldInfoPtr_oldChallengesByID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeFieldInfoPtr_oldChallengesByID;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr__SwitchAccount_b__1_Internal_Void_ChallengeDefinition_0;
		}
	}
}
