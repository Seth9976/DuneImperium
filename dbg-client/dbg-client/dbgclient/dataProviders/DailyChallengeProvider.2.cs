using System;
using Canis.skirmishScripts;
using dwd.core;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dbgclient.dataProviders
{
	// Token: 0x020000C3 RID: 195
	public class DailyChallengeProvider : MonoBehaviour
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x00036714 File Offset: 0x00034914
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeProvider()
		{
			Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataProviders", "DailyChallengeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr);
			DailyChallengeProvider.NativeFieldInfoPtr_scoreMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "scoreMap");
			DailyChallengeProvider.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<Version>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__CanPlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<CanPlay>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__SeasonOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<SeasonOpen>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__HasSavedGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<HasSavedGame>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__Season_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<Season>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__Game_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<Game>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__GameKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<GameKey>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__SavedGameKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<SavedGameKey>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__AttemptsMade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<AttemptsMade>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__MaxAttempts_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<MaxAttempts>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__StartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<StartTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__CloseTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<CloseTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__EndTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<EndTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__SeasonStartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<SeasonStartTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__SeasonEndTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<SeasonEndTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__NextStartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<NextStartTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__SaveStartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<SaveStartTime>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr_remainingCachedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "remainingCachedTimestamp");
			DailyChallengeProvider.NativeFieldInfoPtr_remainingOpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "remainingOpenTime");
			DailyChallengeProvider.NativeFieldInfoPtr_remainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "remainingTime");
			DailyChallengeProvider.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<Initialized>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__RequestError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<RequestError>k__BackingField");
			DailyChallengeProvider.NativeFieldInfoPtr__Requesting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, "<Requesting>k__BackingField");
			DailyChallengeProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664483);
			DailyChallengeProvider.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664484);
			DailyChallengeProvider.NativeMethodInfoPtr_get_CanPlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664485);
			DailyChallengeProvider.NativeMethodInfoPtr_set_CanPlay_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664486);
			DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664487);
			DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664488);
			DailyChallengeProvider.NativeMethodInfoPtr_get_HasSavedGame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664489);
			DailyChallengeProvider.NativeMethodInfoPtr_set_HasSavedGame_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664490);
			DailyChallengeProvider.NativeMethodInfoPtr_get_Season_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664491);
			DailyChallengeProvider.NativeMethodInfoPtr_set_Season_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664492);
			DailyChallengeProvider.NativeMethodInfoPtr_get_Game_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664493);
			DailyChallengeProvider.NativeMethodInfoPtr_set_Game_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664494);
			DailyChallengeProvider.NativeMethodInfoPtr_get_GameKey_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664495);
			DailyChallengeProvider.NativeMethodInfoPtr_set_GameKey_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664496);
			DailyChallengeProvider.NativeMethodInfoPtr_get_SavedGameKey_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664497);
			DailyChallengeProvider.NativeMethodInfoPtr_set_SavedGameKey_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664498);
			DailyChallengeProvider.NativeMethodInfoPtr_get_AttemptsMade_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664499);
			DailyChallengeProvider.NativeMethodInfoPtr_set_AttemptsMade_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664500);
			DailyChallengeProvider.NativeMethodInfoPtr_get_MaxAttempts_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664501);
			DailyChallengeProvider.NativeMethodInfoPtr_set_MaxAttempts_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664502);
			DailyChallengeProvider.NativeMethodInfoPtr_get_StartTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664503);
			DailyChallengeProvider.NativeMethodInfoPtr_set_StartTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664504);
			DailyChallengeProvider.NativeMethodInfoPtr_get_CloseTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664505);
			DailyChallengeProvider.NativeMethodInfoPtr_set_CloseTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664506);
			DailyChallengeProvider.NativeMethodInfoPtr_get_EndTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664507);
			DailyChallengeProvider.NativeMethodInfoPtr_set_EndTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664508);
			DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonStartTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664509);
			DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonStartTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664510);
			DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonEndTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664511);
			DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonEndTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664512);
			DailyChallengeProvider.NativeMethodInfoPtr_get_NextStartTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664513);
			DailyChallengeProvider.NativeMethodInfoPtr_set_NextStartTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664514);
			DailyChallengeProvider.NativeMethodInfoPtr_get_SaveStartTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664515);
			DailyChallengeProvider.NativeMethodInfoPtr_set_SaveStartTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664516);
			DailyChallengeProvider.NativeMethodInfoPtr_Initialize_Protected_Void_SkirmishInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664517);
			DailyChallengeProvider.NativeMethodInfoPtr_RemainingOpenTime_Public_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664518);
			DailyChallengeProvider.NativeMethodInfoPtr_GetPromptData_Public_Abstract_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664519);
			DailyChallengeProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664520);
			DailyChallengeProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664521);
			DailyChallengeProvider.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664522);
			DailyChallengeProvider.NativeMethodInfoPtr_set_RequestError_Protected_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664523);
			DailyChallengeProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664524);
			DailyChallengeProvider.NativeMethodInfoPtr_get_Requesting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664525);
			DailyChallengeProvider.NativeMethodInfoPtr_set_Requesting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664526);
			DailyChallengeProvider.NativeMethodInfoPtr_RequestInfo_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664527);
			DailyChallengeProvider.NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664528);
			DailyChallengeProvider.NativeMethodInfoPtr_TryGetScoreForAttempt_Public_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664529);
			DailyChallengeProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr, 100664530);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00036CE4 File Offset: 0x00034EE4
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00036D20 File Offset: 0x00034F20
		public unsafe virtual ulong Version
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00036D60 File Offset: 0x00034F60
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00036D9C File Offset: 0x00034F9C
		public unsafe bool CanPlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_CanPlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_CanPlay_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00036DDC File Offset: 0x00034FDC
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00036E18 File Offset: 0x00035018
		public unsafe bool SeasonOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483221, RefRangeEnd = 483222, XrefRangeStart = 483221, XrefRangeEnd = 483222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00036E58 File Offset: 0x00035058
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00036E94 File Offset: 0x00035094
		public unsafe bool HasSavedGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_HasSavedGame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_HasSavedGame_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00036ED4 File Offset: 0x000350D4
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00036F10 File Offset: 0x00035110
		public unsafe int Season
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_Season_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_Season_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00036F50 File Offset: 0x00035150
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00036F8C File Offset: 0x0003518C
		public unsafe int Game
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_Game_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_Game_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00036FCC File Offset: 0x000351CC
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00037008 File Offset: 0x00035208
		public unsafe int GameKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_GameKey_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_GameKey_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00037048 File Offset: 0x00035248
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00037084 File Offset: 0x00035284
		public unsafe int SavedGameKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_SavedGameKey_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_SavedGameKey_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000370C4 File Offset: 0x000352C4
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00037100 File Offset: 0x00035300
		public unsafe int AttemptsMade
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_AttemptsMade_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_AttemptsMade_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00037140 File Offset: 0x00035340
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x0003717C File Offset: 0x0003537C
		public unsafe int MaxAttempts
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_MaxAttempts_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_MaxAttempts_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000371BC File Offset: 0x000353BC
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000371F8 File Offset: 0x000353F8
		public unsafe DateTime StartTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_StartTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_StartTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00037238 File Offset: 0x00035438
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00037274 File Offset: 0x00035474
		public unsafe DateTime CloseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_CloseTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_CloseTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000372B4 File Offset: 0x000354B4
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000372F0 File Offset: 0x000354F0
		public unsafe DateTime EndTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_EndTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_EndTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00037330 File Offset: 0x00035530
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0003736C File Offset: 0x0003556C
		public unsafe DateTime SeasonStartTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonStartTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonStartTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000373AC File Offset: 0x000355AC
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000373E8 File Offset: 0x000355E8
		public unsafe DateTime SeasonEndTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_SeasonEndTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_SeasonEndTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00037428 File Offset: 0x00035628
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00037464 File Offset: 0x00035664
		public unsafe DateTime NextStartTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_NextStartTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_NextStartTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000374A4 File Offset: 0x000356A4
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000374E0 File Offset: 0x000356E0
		public unsafe DateTime SaveStartTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_SaveStartTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_SaveStartTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00037520 File Offset: 0x00035720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504705, RefRangeEnd = 504706, XrefRangeStart = 504684, XrefRangeEnd = 504705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(SkirmishInfo skirmishInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skirmishInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_Initialize_Protected_Void_SkirmishInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00037564 File Offset: 0x00035764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 504715, RefRangeEnd = 504719, XrefRangeStart = 504706, XrefRangeEnd = 504715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan RemainingOpenTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_RemainingOpenTime_Public_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000375A0 File Offset: 0x000357A0
		[CallerCount(0)]
		public unsafe virtual DataComposition GetPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeProvider.NativeMethodInfoPtr_GetPromptData_Public_Abstract_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000375EC File Offset: 0x000357EC
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00037628 File Offset: 0x00035828
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00037668 File Offset: 0x00035868
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x000376A0 File Offset: 0x000358A0
		public unsafe virtual ErrorInfo RequestError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504719, XrefRangeEnd = 504720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_RequestError_Protected_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000376E8 File Offset: 0x000358E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504720, XrefRangeEnd = 504721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0003771C File Offset: 0x0003591C
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00037758 File Offset: 0x00035958
		public unsafe bool Requesting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_get_Requesting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_set_Requesting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00037798 File Offset: 0x00035998
		[CallerCount(0)]
		public unsafe virtual IEnumerator RequestInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeProvider.NativeMethodInfoPtr_RequestInfo_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000377E4 File Offset: 0x000359E4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, string> MakeInitialPlayerMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeProvider.NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00037830 File Offset: 0x00035A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504725, RefRangeEnd = 504726, XrefRangeStart = 504721, XrefRangeEnd = 504725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetScoreForAttempt(int attempt, out int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attempt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr_TryGetScoreForAttempt_Public_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00037888 File Offset: 0x00035A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504732, RefRangeEnd = 504733, XrefRangeStart = 504726, XrefRangeEnd = 504732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005AF2 File Offset: 0x00003CF2
		public DailyChallengeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000378C4 File Offset: 0x00035AC4
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005AFB File Offset: 0x00003CFB
		public unsafe IReadOnlyDictionary<string, int> scoreMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_scoreMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_scoreMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000378F4 File Offset: 0x00035AF4
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00005B1A File Offset: 0x00003D1A
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0003791C File Offset: 0x00035B1C
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00005B35 File Offset: 0x00003D35
		public unsafe bool _CanPlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__CanPlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__CanPlay_k__BackingField)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00037944 File Offset: 0x00035B44
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00005B50 File Offset: 0x00003D50
		public unsafe bool _SeasonOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0003796C File Offset: 0x00035B6C
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005B6B File Offset: 0x00003D6B
		public unsafe bool _HasSavedGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__HasSavedGame_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__HasSavedGame_k__BackingField)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00037994 File Offset: 0x00035B94
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005B86 File Offset: 0x00003D86
		public unsafe int _Season_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Season_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Season_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000379BC File Offset: 0x00035BBC
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00005BA1 File Offset: 0x00003DA1
		public unsafe int _Game_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Game_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Game_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000379E4 File Offset: 0x00035BE4
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00005BBC File Offset: 0x00003DBC
		public unsafe int _GameKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__GameKey_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__GameKey_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00037A0C File Offset: 0x00035C0C
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00005BD7 File Offset: 0x00003DD7
		public unsafe int _SavedGameKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SavedGameKey_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SavedGameKey_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00037A34 File Offset: 0x00035C34
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00005BF2 File Offset: 0x00003DF2
		public unsafe int _AttemptsMade_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__AttemptsMade_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__AttemptsMade_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00037A5C File Offset: 0x00035C5C
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00005C0D File Offset: 0x00003E0D
		public unsafe int _MaxAttempts_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__MaxAttempts_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__MaxAttempts_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00037A84 File Offset: 0x00035C84
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00005C28 File Offset: 0x00003E28
		public unsafe DateTime _StartTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__StartTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__StartTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00037AAC File Offset: 0x00035CAC
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00005C43 File Offset: 0x00003E43
		public unsafe DateTime _CloseTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__CloseTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__CloseTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00037AD4 File Offset: 0x00035CD4
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00005C5E File Offset: 0x00003E5E
		public unsafe DateTime _EndTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__EndTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__EndTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00037AFC File Offset: 0x00035CFC
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00005C79 File Offset: 0x00003E79
		public unsafe DateTime _SeasonStartTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonStartTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonStartTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00037B24 File Offset: 0x00035D24
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00005C94 File Offset: 0x00003E94
		public unsafe DateTime _SeasonEndTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonEndTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SeasonEndTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00037B4C File Offset: 0x00035D4C
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00005CAF File Offset: 0x00003EAF
		public unsafe DateTime _NextStartTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__NextStartTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__NextStartTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00037B74 File Offset: 0x00035D74
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00005CCA File Offset: 0x00003ECA
		public unsafe DateTime _SaveStartTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SaveStartTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__SaveStartTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00037B9C File Offset: 0x00035D9C
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00005CE5 File Offset: 0x00003EE5
		public unsafe DateTime remainingCachedTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingCachedTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingCachedTimestamp)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00037BC4 File Offset: 0x00035DC4
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00005D00 File Offset: 0x00003F00
		public unsafe TimeSpan remainingOpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingOpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingOpenTime)) = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00037BEC File Offset: 0x00035DEC
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00005D1B File Offset: 0x00003F1B
		public unsafe TimeSpan remainingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr_remainingTime)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00037C14 File Offset: 0x00035E14
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x00005D36 File Offset: 0x00003F36
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00037C3C File Offset: 0x00035E3C
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00005D51 File Offset: 0x00003F51
		public ErrorInfo _RequestError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__RequestError_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__RequestError_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00037C6C File Offset: 0x00035E6C
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00005D7F File Offset: 0x00003F7F
		public unsafe bool _Requesting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Requesting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeProvider.NativeFieldInfoPtr__Requesting_k__BackingField)) = value;
			}
		}

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_scoreMap;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr__CanPlay_k__BackingField;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr__SeasonOpen_k__BackingField;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr__HasSavedGame_k__BackingField;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr__Season_k__BackingField;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr__Game_k__BackingField;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr__GameKey_k__BackingField;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr__SavedGameKey_k__BackingField;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr__AttemptsMade_k__BackingField;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr__MaxAttempts_k__BackingField;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr__StartTime_k__BackingField;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr__CloseTime_k__BackingField;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr__EndTime_k__BackingField;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr__SeasonStartTime_k__BackingField;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr__SeasonEndTime_k__BackingField;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr__NextStartTime_k__BackingField;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr__SaveStartTime_k__BackingField;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_remainingCachedTimestamp;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_remainingOpenTime;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_remainingTime;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr__RequestError_k__BackingField;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr__Requesting_k__BackingField;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_CanPlay_Public_get_Boolean_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_set_CanPlay_Private_set_Void_Boolean_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_SeasonOpen_Public_get_Boolean_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_SeasonOpen_Private_set_Void_Boolean_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSavedGame_Public_get_Boolean_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_HasSavedGame_Private_set_Void_Boolean_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_get_Season_Public_get_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_set_Season_Private_set_Void_Int32_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_Game_Public_get_Int32_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_set_Game_Private_set_Void_Int32_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_get_GameKey_Public_get_Int32_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_set_GameKey_Private_set_Void_Int32_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_SavedGameKey_Public_get_Int32_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_set_SavedGameKey_Private_set_Void_Int32_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_AttemptsMade_Public_get_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_set_AttemptsMade_Private_set_Void_Int32_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxAttempts_Public_get_Int32_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxAttempts_Private_set_Void_Int32_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_DateTime_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_set_StartTime_Private_set_Void_DateTime_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseTime_Public_get_DateTime_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseTime_Private_set_Void_DateTime_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_DateTime_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_set_EndTime_Private_set_Void_DateTime_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_get_SeasonStartTime_Public_get_DateTime_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_set_SeasonStartTime_Private_set_Void_DateTime_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_SeasonEndTime_Public_get_DateTime_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_set_SeasonEndTime_Private_set_Void_DateTime_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_NextStartTime_Public_get_DateTime_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_set_NextStartTime_Private_set_Void_DateTime_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveStartTime_Public_get_DateTime_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveStartTime_Private_set_Void_DateTime_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_SkirmishInfo_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_RemainingOpenTime_Public_TimeSpan_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Public_Abstract_Virtual_New_DataComposition_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_Final_New_get_ErrorInfo_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestError_Protected_set_Void_ErrorInfo_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_Requesting_Public_get_Boolean_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_set_Requesting_Protected_set_Void_Boolean_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_RequestInfo_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScoreForAttempt_Public_Boolean_Int32_byref_Int32_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
