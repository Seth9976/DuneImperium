using System;
using boardgames.match.behaviours;
using Canis;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using offlineChallenges;
using UnityEngine.Events;

namespace zen.src.challenges
{
	// Token: 0x02000081 RID: 129
	public class Challenges : OfflineChallenges
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x00024FE4 File Offset: 0x000231E4
		// Note: this type is marked as 'beforefieldinit'.
		static Challenges()
		{
			Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges", "Challenges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr);
			zen.src.challenges.Challenges.NativeFieldInfoPtr_matchHub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "matchHub");
			zen.src.challenges.Challenges.NativeMethodInfoPtr_InitialComplexEvents_Protected_Virtual_IEnumerable_1_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664320);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664321);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664322);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_SetHumanName_Protected_Virtual_New_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664323);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_get_SwitchedDevices_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664324);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ChallengeCompleted_Public_Virtual_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664325);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664326);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ActiveChallenges_Public_Virtual_get_IEnumerable_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664327);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_GetServerLevel_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664328);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_GetLevel_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664329);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ChallengesActive_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664330);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_CheatChallengeToActive_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664331);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_CheatResetChallenges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664332);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_ResetChallenges_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664333);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Virtual_IEnumerator_Dictionary_2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664334);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Virtual_Void_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664335);
			zen.src.challenges.Challenges.NativeMethodInfoPtr_SaveCurrentChallengeData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664336);
			zen.src.challenges.Challenges.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, 100664337);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00025190 File Offset: 0x00023390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988852, XrefRangeEnd = 988857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<OfflineChallenges.ComplexEvent> InitialComplexEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_InitialComplexEvents_Protected_Virtual_IEnumerable_1_ComplexEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<OfflineChallenges.ComplexEvent>>(intPtr3) : null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000251DC File Offset: 0x000233DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988857, XrefRangeEnd = 988862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ChallengeDefinition> Queue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ChallengeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00025228 File Offset: 0x00023428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984543, RefRangeEnd = 984544, XrefRangeStart = 984543, XrefRangeEnd = 984544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigureMatchData(MatchInitData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00025278 File Offset: 0x00023478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988862, XrefRangeEnd = 988892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetHumanName(MatchInitData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_SetHumanName_Protected_Virtual_New_Boolean_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000252D0 File Offset: 0x000234D0
		public unsafe bool SwitchedDevices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 988904, RefRangeEnd = 988905, XrefRangeStart = 988892, XrefRangeEnd = 988904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr_get_SwitchedDevices_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002530C File Offset: 0x0002350C
		public unsafe override UnityEvent ChallengeCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ChallengeCompleted_Public_Virtual_get_UnityEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00025358 File Offset: 0x00023558
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int NumberOfChallengesActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000253A0 File Offset: 0x000235A0
		public unsafe override IEnumerable<ChallengeDefinition> ActiveChallenges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988905, XrefRangeEnd = 988911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ActiveChallenges_Public_Virtual_get_IEnumerable_1_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ChallengeDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000253EC File Offset: 0x000235EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988911, XrefRangeEnd = 988925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetServerLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_GetServerLevel_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00025434 File Offset: 0x00023634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988925, XrefRangeEnd = 988931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_GetLevel_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0002547C File Offset: 0x0002367C
		public unsafe override bool ChallengesActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988931, XrefRangeEnd = 988946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_get_ChallengesActive_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000254C4 File Offset: 0x000236C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988946, XrefRangeEnd = 988980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheatChallengeToActive(int targetChallengeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetChallengeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr_CheatChallengeToActive_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00025504 File Offset: 0x00023704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988980, XrefRangeEnd = 988986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheatResetChallenges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr_CheatResetChallenges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00025538 File Offset: 0x00023738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988986, XrefRangeEnd = 988991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator ResetChallenges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr_ResetChallenges_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00025578 File Offset: 0x00023778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988991, XrefRangeEnd = 988997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SendSyncChallengesToServer(Dictionary<int, int> challengeDeltas, int level)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Virtual_IEnumerator_Dictionary_2_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000255E4 File Offset: 0x000237E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988997, XrefRangeEnd = 988998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AttemptAchievementCompletion(ChallengeDefinition challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), zen.src.challenges.Challenges.NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Virtual_Void_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00025634 File Offset: 0x00023834
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 989083, RefRangeEnd = 989088, XrefRangeStart = 988998, XrefRangeEnd = 989083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveCurrentChallengeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr_SaveCurrentChallengeData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00025668 File Offset: 0x00023868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989089, RefRangeEnd = 989090, XrefRangeStart = 989088, XrefRangeEnd = 989089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Challenges()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004F25 File Offset: 0x00003125
		public Challenges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000256A4 File Offset: 0x000238A4
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004F2E File Offset: 0x0000312E
		public unsafe DBGMatchHub matchHub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges.NativeFieldInfoPtr_matchHub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges.NativeFieldInfoPtr_matchHub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_matchHub;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_InitialComplexEvents_Protected_Virtual_IEnumerable_1_ComplexEvent_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_New_Void_MatchInitData_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_SetHumanName_Protected_Virtual_New_Boolean_MatchInitData_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchedDevices_Private_get_Boolean_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengeCompleted_Public_Virtual_get_UnityEvent_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveChallenges_Public_Virtual_get_IEnumerable_1_ChallengeDefinition_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_GetServerLevel_Protected_Virtual_Int32_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel_Protected_Virtual_Int32_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengesActive_Protected_Virtual_get_Boolean_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_CheatChallengeToActive_Public_Void_Int32_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_CheatResetChallenges_Public_Void_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_ResetChallenges_Private_IEnumerator_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_SendSyncChallengesToServer_Protected_Virtual_IEnumerator_Dictionary_2_Int32_Int32_Int32_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_AttemptAchievementCompletion_Protected_Virtual_Void_ChallengeDefinition_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_SaveCurrentChallengeData_Public_Void_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000208 RID: 520
		[ObfuscatedName("zen.src.challenges.Challenges+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060017C1 RID: 6081 RVA: 0x0005AC84 File Offset: 0x00058E84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr);
				zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, "<>9");
				zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, "<>9__4_0");
				zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, "<>9__21_0");
				zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, 100664339);
				zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__SetHumanName_b__4_0_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, 100664340);
				zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__SaveCurrentChallengeData_b__21_0_Internal_Boolean_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr, 100664341);
			}

			// Token: 0x060017C2 RID: 6082 RVA: 0x0005AD28 File Offset: 0x00058F28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017C3 RID: 6083 RVA: 0x0005AD64 File Offset: 0x00058F64
			[CallerCount(0)]
			public unsafe bool _SetHumanName_b__4_0(PlayerMatchInitData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__SetHumanName_b__4_0_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017C4 RID: 6084 RVA: 0x0005ADB4 File Offset: 0x00058FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988653, XrefRangeEnd = 988654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SaveCurrentChallengeData_b__21_0(ChallengeDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges.__c.NativeMethodInfoPtr__SaveCurrentChallengeData_b__21_0_Internal_Boolean_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017C5 RID: 6085 RVA: 0x0000D08D File Offset: 0x0000B28D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0005AE04 File Offset: 0x00059004
			// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000D096 File Offset: 0x0000B296
			public unsafe static Challenges.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Challenges.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0005AE2C File Offset: 0x0005902C
			// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
			public unsafe static Func<PlayerMatchInitData, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x060017CA RID: 6090 RVA: 0x0005AE54 File Offset: 0x00059054
			// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000D0BA File Offset: 0x0000B2BA
			public unsafe static Func<ChallengeDefinition, bool> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ChallengeDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(zen.src.challenges.Challenges.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E64 RID: 3684
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000E65 RID: 3685
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04000E66 RID: 3686
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04000E67 RID: 3687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E68 RID: 3688
			private static readonly IntPtr NativeMethodInfoPtr__SetHumanName_b__4_0_Internal_Boolean_PlayerMatchInitData_0;

			// Token: 0x04000E69 RID: 3689
			private static readonly IntPtr NativeMethodInfoPtr__SaveCurrentChallengeData_b__21_0_Internal_Boolean_ChallengeDefinition_0;
		}

		// Token: 0x02000209 RID: 521
		[ObfuscatedName("zen.src.challenges.Challenges+<InitialComplexEvents>d__1")]
		public sealed class _InitialComplexEvents_d__1 : Object
		{
			// Token: 0x060017CC RID: 6092 RVA: 0x0005AE7C File Offset: 0x0005907C
			// Note: this type is marked as 'beforefieldinit'.
			static _InitialComplexEvents_d__1()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<InitialComplexEvents>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, "<>1__state");
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, "<>2__current");
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, "<>l__initialThreadId");
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664342);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664343);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664344);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_OfflineChallenges_ComplexEvent__get_Current_Private_Virtual_Final_New_get_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664345);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664346);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664347);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_OfflineChallenges_ComplexEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ComplexEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664348);
				zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr, 100664349);
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x0005AF84 File Offset: 0x00059184
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitialComplexEvents_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges._InitialComplexEvents_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017CE RID: 6094 RVA: 0x0005AFCC File Offset: 0x000591CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017CF RID: 6095 RVA: 0x0005B000 File Offset: 0x00059200
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0005B03C File Offset: 0x0005923C
			public unsafe OfflineChallenges.ComplexEvent System.Collections.Generic.IEnumerator<offlineChallenges.OfflineChallenges.ComplexEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_OfflineChallenges_ComplexEvent__get_Current_Private_Virtual_Final_New_get_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<OfflineChallenges.ComplexEvent>(intPtr3) : null;
				}
			}

			// Token: 0x060017D1 RID: 6097 RVA: 0x0005B07C File Offset: 0x0005927C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988654, XrefRangeEnd = 988659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0005B0B0 File Offset: 0x000592B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017D3 RID: 6099 RVA: 0x0005B0F0 File Offset: 0x000592F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988659, XrefRangeEnd = 988661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<OfflineChallenges.ComplexEvent> System_Collections_Generic_IEnumerable_offlineChallenges_OfflineChallenges_ComplexEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_OfflineChallenges_ComplexEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ComplexEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<OfflineChallenges.ComplexEvent>>(intPtr3) : null;
			}

			// Token: 0x060017D4 RID: 6100 RVA: 0x0005B130 File Offset: 0x00059330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017D5 RID: 6101 RVA: 0x0000D0CC File Offset: 0x0000B2CC
			public _InitialComplexEvents_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0005B170 File Offset: 0x00059370
			// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0000D0D5 File Offset: 0x0000B2D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0005B198 File Offset: 0x00059398
			// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
			public unsafe OfflineChallenges.ComplexEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineChallenges.ComplexEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x060017DA RID: 6106 RVA: 0x0005B1C8 File Offset: 0x000593C8
			// (set) Token: 0x060017DB RID: 6107 RVA: 0x0000D10F File Offset: 0x0000B30F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._InitialComplexEvents_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04000E6A RID: 3690
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E6B RID: 3691
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E6C RID: 3692
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E6D RID: 3693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E6E RID: 3694
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E6F RID: 3695
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E70 RID: 3696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_OfflineChallenges_ComplexEvent__get_Current_Private_Virtual_Final_New_get_ComplexEvent_0;

			// Token: 0x04000E71 RID: 3697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E72 RID: 3698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E73 RID: 3699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_OfflineChallenges_ComplexEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ComplexEvent_0;

			// Token: 0x04000E74 RID: 3700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020A RID: 522
		[ObfuscatedName("zen.src.challenges.Challenges+<Queue>d__2")]
		public sealed class _Queue_d__2 : Object
		{
			// Token: 0x060017DC RID: 6108 RVA: 0x0005B1F0 File Offset: 0x000593F0
			// Note: this type is marked as 'beforefieldinit'.
			static _Queue_d__2()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<Queue>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr);
				zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, "<>1__state");
				zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, "<>2__current");
				zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, "<>l__initialThreadId");
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664350);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664351);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664352);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664353);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664354);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664355);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664356);
				zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr, 100664357);
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x0005B2F8 File Offset: 0x000594F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Queue_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges._Queue_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x0005B340 File Offset: 0x00059540
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017DF RID: 6111 RVA: 0x0005B374 File Offset: 0x00059574
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0005B3B0 File Offset: 0x000595B0
			public unsafe ChallengeDefinition System.Collections.Generic.IEnumerator<offlineChallenges.ChallengeDefinition>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChallengeDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x060017E1 RID: 6113 RVA: 0x0005B3F0 File Offset: 0x000595F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988661, XrefRangeEnd = 988666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0005B424 File Offset: 0x00059624
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x0005B464 File Offset: 0x00059664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988666, XrefRangeEnd = 988668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ChallengeDefinition> System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ChallengeDefinition>>(intPtr3) : null;
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x0005B4A4 File Offset: 0x000596A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._Queue_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0000D12A File Offset: 0x0000B32A
			public _Queue_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0005B4E4 File Offset: 0x000596E4
			// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000D133 File Offset: 0x0000B333
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0005B50C File Offset: 0x0005970C
			// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000D14E File Offset: 0x0000B34E
			public unsafe ChallengeDefinition __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x060017EA RID: 6122 RVA: 0x0005B53C File Offset: 0x0005973C
			// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000D16D File Offset: 0x0000B36D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._Queue_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04000E75 RID: 3701
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E76 RID: 3702
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E77 RID: 3703
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E78 RID: 3704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E79 RID: 3705
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E7A RID: 3706
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E7B RID: 3707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0;

			// Token: 0x04000E7C RID: 3708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E7D RID: 3709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E7E RID: 3710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0;

			// Token: 0x04000E7F RID: 3711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020B RID: 523
		[ObfuscatedName("zen.src.challenges.Challenges+<ResetChallenges>d__18")]
		public sealed class _ResetChallenges_d__18 : Object
		{
			// Token: 0x060017EC RID: 6124 RVA: 0x0005B564 File Offset: 0x00059764
			// Note: this type is marked as 'beforefieldinit'.
			static _ResetChallenges_d__18()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<ResetChallenges>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, "<>1__state");
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, "<>2__current");
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, "<>4__this");
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr__submitCmd_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, "<submitCmd>5__2");
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664358);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664359);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664360);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664361);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664362);
				zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr, 100664363);
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x0005B658 File Offset: 0x00059858
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResetChallenges_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges._ResetChallenges_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x0005B6A0 File Offset: 0x000598A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EF RID: 6127 RVA: 0x0005B6D4 File Offset: 0x000598D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988668, XrefRangeEnd = 988743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0005B710 File Offset: 0x00059910
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017F1 RID: 6129 RVA: 0x0005B750 File Offset: 0x00059950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988743, XrefRangeEnd = 988748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0005B784 File Offset: 0x00059984
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x0000D188 File Offset: 0x0000B388
			public _ResetChallenges_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0005B7C4 File Offset: 0x000599C4
			// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000D191 File Offset: 0x0000B391
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0005B7EC File Offset: 0x000599EC
			// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000D1AC File Offset: 0x0000B3AC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0005B81C File Offset: 0x00059A1C
			// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000D1CB File Offset: 0x0000B3CB
			public unsafe Challenges __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Challenges>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x060017FA RID: 6138 RVA: 0x0005B84C File Offset: 0x00059A4C
			// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000D1EA File Offset: 0x0000B3EA
			public unsafe SubmitWWWPostingJSON _submitCmd_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr__submitCmd_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmitWWWPostingJSON>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._ResetChallenges_d__18.NativeFieldInfoPtr__submitCmd_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E80 RID: 3712
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E81 RID: 3713
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E82 RID: 3714
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E83 RID: 3715
			private static readonly IntPtr NativeFieldInfoPtr__submitCmd_5__2;

			// Token: 0x04000E84 RID: 3716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E85 RID: 3717
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E86 RID: 3718
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E87 RID: 3719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E88 RID: 3720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E89 RID: 3721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("zen.src.challenges.Challenges+<SendSyncChallengesToServer>d__19")]
		public sealed class _SendSyncChallengesToServer_d__19 : Object
		{
			// Token: 0x060017FC RID: 6140 RVA: 0x0005B87C File Offset: 0x00059A7C
			// Note: this type is marked as 'beforefieldinit'.
			static _SendSyncChallengesToServer_d__19()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<SendSyncChallengesToServer>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, "<>1__state");
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, "<>2__current");
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr_challengeDeltas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, "challengeDeltas");
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, "<>4__this");
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr__submitCmd_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, "<submitCmd>5__2");
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664364);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664365);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664366);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664367);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664368);
				zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr, 100664369);
			}

			// Token: 0x060017FD RID: 6141 RVA: 0x0005B984 File Offset: 0x00059B84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendSyncChallengesToServer_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017FE RID: 6142 RVA: 0x0005B9CC File Offset: 0x00059BCC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017FF RID: 6143 RVA: 0x0005BA00 File Offset: 0x00059C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988748, XrefRangeEnd = 988806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001800 RID: 6144 RVA: 0x0005BA3C File Offset: 0x00059C3C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001801 RID: 6145 RVA: 0x0005BA7C File Offset: 0x00059C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988806, XrefRangeEnd = 988811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001802 RID: 6146 RVA: 0x0005BAB0 File Offset: 0x00059CB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001803 RID: 6147 RVA: 0x0000D209 File Offset: 0x0000B409
			public _SendSyncChallengesToServer_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06001804 RID: 6148 RVA: 0x0005BAF0 File Offset: 0x00059CF0
			// (set) Token: 0x06001805 RID: 6149 RVA: 0x0000D212 File Offset: 0x0000B412
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001806 RID: 6150 RVA: 0x0005BB18 File Offset: 0x00059D18
			// (set) Token: 0x06001807 RID: 6151 RVA: 0x0000D22D File Offset: 0x0000B42D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001808 RID: 6152 RVA: 0x0005BB48 File Offset: 0x00059D48
			// (set) Token: 0x06001809 RID: 6153 RVA: 0x0000D24C File Offset: 0x0000B44C
			public unsafe Dictionary<int, int> challengeDeltas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr_challengeDeltas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr_challengeDeltas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x0600180A RID: 6154 RVA: 0x0005BB78 File Offset: 0x00059D78
			// (set) Token: 0x0600180B RID: 6155 RVA: 0x0000D26B File Offset: 0x0000B46B
			public unsafe Challenges __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Challenges>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x0600180C RID: 6156 RVA: 0x0005BBA8 File Offset: 0x00059DA8
			// (set) Token: 0x0600180D RID: 6157 RVA: 0x0000D28A File Offset: 0x0000B48A
			public unsafe SubmitWWWPostingJSON _submitCmd_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr__submitCmd_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmitWWWPostingJSON>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._SendSyncChallengesToServer_d__19.NativeFieldInfoPtr__submitCmd_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E8A RID: 3722
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E8B RID: 3723
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E8C RID: 3724
			private static readonly IntPtr NativeFieldInfoPtr_challengeDeltas;

			// Token: 0x04000E8D RID: 3725
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E8E RID: 3726
			private static readonly IntPtr NativeFieldInfoPtr__submitCmd_5__2;

			// Token: 0x04000E8F RID: 3727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E90 RID: 3728
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E91 RID: 3729
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E92 RID: 3730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E93 RID: 3731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E94 RID: 3732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("zen.src.challenges.Challenges+<get_ActiveChallenges>d__11")]
		public sealed class _get_ActiveChallenges_d__11 : Object
		{
			// Token: 0x0600180E RID: 6158 RVA: 0x0005BBD8 File Offset: 0x00059DD8
			// Note: this type is marked as 'beforefieldinit'.
			static _get_ActiveChallenges_d__11()
			{
				Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.challenges.Challenges>.NativeClassPtr, "<get_ActiveChallenges>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<>1__state");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<>2__current");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<>l__initialThreadId");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<>4__this");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__seenSpecial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<seenSpecial>5__2");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__count_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<count>5__3");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, "<>7__wrap3");
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664370);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664371);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664372);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664373);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664374);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664375);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664376);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664377);
				zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr, 100664378);
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x0005BD44 File Offset: 0x00059F44
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_ActiveChallenges_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.challenges.Challenges._get_ActiveChallenges_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001810 RID: 6160 RVA: 0x0005BD8C File Offset: 0x00059F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988811, XrefRangeEnd = 988816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001811 RID: 6161 RVA: 0x0005BDC0 File Offset: 0x00059FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988816, XrefRangeEnd = 988842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x0005BDFC File Offset: 0x00059FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988842, XrefRangeEnd = 988845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001813 RID: 6163 RVA: 0x0005BE30 File Offset: 0x0005A030
			public unsafe ChallengeDefinition System.Collections.Generic.IEnumerator<offlineChallenges.ChallengeDefinition>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChallengeDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x0005BE70 File Offset: 0x0005A070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988845, XrefRangeEnd = 988850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001815 RID: 6165 RVA: 0x0005BEA4 File Offset: 0x0005A0A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x0005BEE4 File Offset: 0x0005A0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988850, XrefRangeEnd = 988852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ChallengeDefinition> System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ChallengeDefinition>>(intPtr3) : null;
			}

			// Token: 0x06001817 RID: 6167 RVA: 0x0005BF24 File Offset: 0x0005A124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x0000D2A9 File Offset: 0x0000B4A9
			public _get_ActiveChallenges_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001819 RID: 6169 RVA: 0x0005BF64 File Offset: 0x0005A164
			// (set) Token: 0x0600181A RID: 6170 RVA: 0x0000D2B2 File Offset: 0x0000B4B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x0600181B RID: 6171 RVA: 0x0005BF8C File Offset: 0x0005A18C
			// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000D2CD File Offset: 0x0000B4CD
			public unsafe ChallengeDefinition __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x0005BFBC File Offset: 0x0005A1BC
			// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000D2EC File Offset: 0x0000B4EC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x0005BFE4 File Offset: 0x0005A1E4
			// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000D307 File Offset: 0x0000B507
			public unsafe Challenges __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Challenges>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x0005C014 File Offset: 0x0005A214
			// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000D326 File Offset: 0x0000B526
			public unsafe bool _seenSpecial_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__seenSpecial_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__seenSpecial_5__2)) = value;
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x0005C03C File Offset: 0x0005A23C
			// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000D341 File Offset: 0x0000B541
			public unsafe int _count_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__count_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr__count_5__3)) = value;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06001825 RID: 6181 RVA: 0x0005C064 File Offset: 0x0005A264
			// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000D35C File Offset: 0x0000B55C
			public List<ChallengeDefinition>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___7__wrap3);
					return new List<ChallengeDefinition>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ChallengeDefinition>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.challenges.Challenges._get_ActiveChallenges_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ChallengeDefinition>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000E95 RID: 3733
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E96 RID: 3734
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E97 RID: 3735
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E98 RID: 3736
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E99 RID: 3737
			private static readonly IntPtr NativeFieldInfoPtr__seenSpecial_5__2;

			// Token: 0x04000E9A RID: 3738
			private static readonly IntPtr NativeFieldInfoPtr__count_5__3;

			// Token: 0x04000E9B RID: 3739
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000E9C RID: 3740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E9D RID: 3741
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E9E RID: 3742
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E9F RID: 3743
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000EA0 RID: 3744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_offlineChallenges_ChallengeDefinition__get_Current_Private_Virtual_Final_New_get_ChallengeDefinition_0;

			// Token: 0x04000EA1 RID: 3745
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EA2 RID: 3746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EA3 RID: 3747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_offlineChallenges_ChallengeDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ChallengeDefinition_0;

			// Token: 0x04000EA4 RID: 3748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
