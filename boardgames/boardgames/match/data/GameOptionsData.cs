using System;
using Canis;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x0200012E RID: 302
	public class GameOptionsData : DataComponent
	{
		// Token: 0x06000FB4 RID: 4020 RVA: 0x00040F8C File Offset: 0x0003F18C
		// Note: this type is marked as 'beforefieldinit'.
		static GameOptionsData()
		{
			Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.data", "GameOptionsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr);
			GameOptionsData.NativeFieldInfoPtr__MatchInitData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<MatchInitData>k__BackingField");
			GameOptionsData.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "Options");
			GameOptionsData.NativeFieldInfoPtr__IsResume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<IsResume>k__BackingField");
			GameOptionsData.NativeFieldInfoPtr__Resigned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<Resigned>k__BackingField");
			GameOptionsData.NativeFieldInfoPtr__MatchType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<MatchType>k__BackingField");
			GameOptionsData.NativeFieldInfoPtr__ObservedPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<ObservedPlayerID>k__BackingField");
			GameOptionsData.NativeFieldInfoPtr__GameCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<GameCompleted>k__BackingField");
			GameOptionsData.NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665544);
			GameOptionsData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665545);
			GameOptionsData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665546);
			GameOptionsData.NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665547);
			GameOptionsData.NativeMethodInfoPtr_set_IsResume_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665548);
			GameOptionsData.NativeMethodInfoPtr_get_Resigned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665549);
			GameOptionsData.NativeMethodInfoPtr_set_Resigned_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665550);
			GameOptionsData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665551);
			GameOptionsData.NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665552);
			GameOptionsData.NativeMethodInfoPtr_get_ObservedPlayerID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665553);
			GameOptionsData.NativeMethodInfoPtr_set_ObservedPlayerID_Public_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665554);
			GameOptionsData.NativeMethodInfoPtr_get_GameCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665555);
			GameOptionsData.NativeMethodInfoPtr_set_GameCompleted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665556);
			GameOptionsData.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665557);
			GameOptionsData.NativeMethodInfoPtr_get_IsChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665558);
			GameOptionsData.NativeMethodInfoPtr_get_IsSoloScenario_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665559);
			GameOptionsData.NativeMethodInfoPtr_get_IsSolo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665560);
			GameOptionsData.NativeMethodInfoPtr_get_IsPassAndPlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665561);
			GameOptionsData.NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665562);
			GameOptionsData.NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665563);
			GameOptionsData.NativeMethodInfoPtr_get_IsCasual_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665564);
			GameOptionsData.NativeMethodInfoPtr_get_IsDailyChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665565);
			GameOptionsData.NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665566);
			GameOptionsData.NativeMethodInfoPtr_get_IsObserver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665567);
			GameOptionsData.NativeMethodInfoPtr_get_IsOfflineMatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665568);
			GameOptionsData.NativeMethodInfoPtr_get_IsViewingOnlineGameResults_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665569);
			GameOptionsData.NativeMethodInfoPtr_get_ShouldCreateSave_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665570);
			GameOptionsData.NativeMethodInfoPtr_get_MaySaveAndExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665571);
			GameOptionsData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, 100665572);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0004128C File Offset: 0x0003F48C
		public unsafe MatchInitData MatchInitData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000412CC File Offset: 0x0003F4CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 998169, RefRangeEnd = 998175, XrefRangeStart = 998145, XrefRangeEnd = 998169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameOptionsData(Dictionary<string, string> options = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00041318 File Offset: 0x0003F518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 998186, RefRangeEnd = 998188, XrefRangeStart = 998175, XrefRangeEnd = 998186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameOptionsData(MatchInitData matchInitData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00041364 File Offset: 0x0003F564
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x000413A0 File Offset: 0x0003F5A0
		public unsafe bool IsResume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_set_IsResume_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x000413E0 File Offset: 0x0003F5E0
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0004141C File Offset: 0x0003F61C
		public unsafe bool Resigned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_Resigned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_set_Resigned_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004145C File Offset: 0x0003F65C
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00041494 File Offset: 0x0003F694
		public unsafe string MatchType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000414D8 File Offset: 0x0003F6D8
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00041518 File Offset: 0x0003F718
		public unsafe AccountID ObservedPlayerID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_ObservedPlayerID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_set_ObservedPlayerID_Public_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0004155C File Offset: 0x0003F75C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00041598 File Offset: 0x0003F798
		public unsafe bool GameCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_GameCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_set_GameCompleted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000415D8 File Offset: 0x0003F7D8
		public unsafe bool IsTutorial
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 998192, RefRangeEnd = 998203, XrefRangeStart = 998188, XrefRangeEnd = 998192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00041614 File Offset: 0x0003F814
		public unsafe bool IsChallenge
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 998206, RefRangeEnd = 998218, XrefRangeStart = 998203, XrefRangeEnd = 998206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00041650 File Offset: 0x0003F850
		public unsafe bool IsSoloScenario
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998221, RefRangeEnd = 998222, XrefRangeStart = 998218, XrefRangeEnd = 998221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsSoloScenario_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0004168C File Offset: 0x0003F88C
		public unsafe bool IsSolo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998222, XrefRangeEnd = 998225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsSolo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x000416C8 File Offset: 0x0003F8C8
		public unsafe bool IsPassAndPlay
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 998228, RefRangeEnd = 998232, XrefRangeStart = 998225, XrefRangeEnd = 998228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsPassAndPlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00041704 File Offset: 0x0003F904
		public unsafe bool IsSimultaneousSolo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998232, XrefRangeEnd = 998235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00041740 File Offset: 0x0003F940
		public unsafe bool IsLive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998238, RefRangeEnd = 998239, XrefRangeStart = 998235, XrefRangeEnd = 998238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0004177C File Offset: 0x0003F97C
		public unsafe bool IsCasual
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998242, RefRangeEnd = 998243, XrefRangeStart = 998239, XrefRangeEnd = 998242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsCasual_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000417B8 File Offset: 0x0003F9B8
		public unsafe bool IsDailyChallenge
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 998246, RefRangeEnd = 998251, XrefRangeStart = 998243, XrefRangeEnd = 998246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsDailyChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000417F4 File Offset: 0x0003F9F4
		public unsafe bool IsFriend
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998258, RefRangeEnd = 998259, XrefRangeStart = 998251, XrefRangeEnd = 998258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00041830 File Offset: 0x0003FA30
		public unsafe bool IsObserver
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 998262, RefRangeEnd = 998268, XrefRangeStart = 998259, XrefRangeEnd = 998262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsObserver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0004186C File Offset: 0x0003FA6C
		public unsafe bool IsOfflineMatch
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 998289, RefRangeEnd = 998301, XrefRangeStart = 998268, XrefRangeEnd = 998289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsOfflineMatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000418A8 File Offset: 0x0003FAA8
		public unsafe bool IsViewingOnlineGameResults
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 998307, RefRangeEnd = 998309, XrefRangeStart = 998301, XrefRangeEnd = 998307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_IsViewingOnlineGameResults_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000418E4 File Offset: 0x0003FAE4
		public unsafe bool ShouldCreateSave
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998313, RefRangeEnd = 998314, XrefRangeStart = 998309, XrefRangeEnd = 998313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_ShouldCreateSave_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00041920 File Offset: 0x0003FB20
		public unsafe bool MaySaveAndExit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 998320, RefRangeEnd = 998321, XrefRangeStart = 998314, XrefRangeEnd = 998320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.NativeMethodInfoPtr_get_MaySaveAndExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004195C File Offset: 0x0003FB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998321, XrefRangeEnd = 998349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameOptionsData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000094E1 File Offset: 0x000076E1
		public GameOptionsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000419A0 File Offset: 0x0003FBA0
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000094EA File Offset: 0x000076EA
		public unsafe MatchInitData _MatchInitData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__MatchInitData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__MatchInitData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000419D0 File Offset: 0x0003FBD0
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00009509 File Offset: 0x00007709
		public unsafe ReadOnlyDictionary<string, string> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00041A00 File Offset: 0x0003FC00
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00009528 File Offset: 0x00007728
		public unsafe bool _IsResume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__IsResume_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__IsResume_k__BackingField)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00041A28 File Offset: 0x0003FC28
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00009543 File Offset: 0x00007743
		public unsafe bool _Resigned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__Resigned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__Resigned_k__BackingField)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00041A50 File Offset: 0x0003FC50
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x0000955E File Offset: 0x0000775E
		public unsafe string _MatchType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__MatchType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__MatchType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00041A78 File Offset: 0x0003FC78
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0000957D File Offset: 0x0000777D
		public unsafe AccountID _ObservedPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__ObservedPlayerID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__ObservedPlayerID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0000959C File Offset: 0x0000779C
		public unsafe bool _GameCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__GameCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionsData.NativeFieldInfoPtr__GameCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr__MatchInitData_k__BackingField;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr__IsResume_k__BackingField;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr__Resigned_k__BackingField;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr__MatchType_k__BackingField;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr__ObservedPlayerID_k__BackingField;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr__GameCompleted_k__BackingField;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchInitData_Public_get_MatchInitData_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResume_Public_get_Boolean_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_set_IsResume_Public_set_Void_Boolean_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_get_Resigned_Public_get_Boolean_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_set_Resigned_Public_set_Void_Boolean_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_String_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_get_ObservedPlayerID_Public_get_AccountID_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_set_ObservedPlayerID_Public_set_Void_AccountID_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_get_GameCompleted_Public_get_Boolean_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_set_GameCompleted_Public_set_Void_Boolean_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChallenge_Public_get_Boolean_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSoloScenario_Public_get_Boolean_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSolo_Public_get_Boolean_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPassAndPlay_Public_get_Boolean_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_get_Boolean_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCasual_Public_get_Boolean_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDailyChallenge_Public_get_Boolean_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_get_IsObserver_Public_get_Boolean_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOfflineMatch_Public_get_Boolean_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_IsViewingOnlineGameResults_Public_get_Boolean_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldCreateSave_Public_get_Boolean_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_get_MaySaveAndExit_Public_get_Boolean_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000265 RID: 613
		[ObfuscatedName("boardgames.match.data.GameOptionsData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C18 RID: 7192 RVA: 0x00067B4C File Offset: 0x00065D4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameOptionsData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr);
				GameOptionsData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr, "<>9");
				GameOptionsData.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr, "<>9__56_0");
				GameOptionsData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr, 100665574);
				GameOptionsData.__c.NativeMethodInfoPtr__ToString_b__56_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr, 100665575);
			}

			// Token: 0x06001C19 RID: 7193 RVA: 0x00067BC8 File Offset: 0x00065DC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionsData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C1A RID: 7194 RVA: 0x00067C04 File Offset: 0x00065E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998140, XrefRangeEnd = 998145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__56_0(KeyValuePair<string, string> o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(o));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionsData.__c.NativeMethodInfoPtr__ToString_b__56_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001C1B RID: 7195 RVA: 0x0000F2E2 File Offset: 0x0000D4E2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00067C54 File Offset: 0x00065E54
			// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0000F2EB File Offset: 0x0000D4EB
			public unsafe static GameOptionsData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameOptionsData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameOptionsData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00067C7C File Offset: 0x00065E7C
			// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000F2FD File Offset: 0x0000D4FD
			public unsafe static Func<KeyValuePair<string, string>, string> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameOptionsData.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameOptionsData.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001114 RID: 4372
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001115 RID: 4373
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x04001116 RID: 4374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001117 RID: 4375
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__56_0_Internal_String_KeyValuePair_2_String_String_0;
		}
	}
}
