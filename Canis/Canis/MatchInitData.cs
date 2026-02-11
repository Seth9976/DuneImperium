using System;
using Canis.data.matchinitdata;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x02000027 RID: 39
	public class MatchInitData : Object
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00023DA4 File Offset: 0x00021FA4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchInitData()
		{
			Il2CppClassPointerStore<MatchInitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "MatchInitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr);
			MatchInitData.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "gameID");
			MatchInitData.NativeFieldInfoPtr_currentTurnPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "currentTurnPlayer");
			MatchInitData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "options");
			MatchInitData.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "gameState");
			MatchInitData.NativeFieldInfoPtr_createdAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "createdAt");
			MatchInitData.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "saveData");
			MatchInitData.NativeFieldInfoPtr_scenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "scenarioName");
			MatchInitData.NativeFieldInfoPtr_gameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "gameType");
			MatchInitData.NativeFieldInfoPtr_clientMatchOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "clientMatchOptions");
			MatchInitData.NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "difficulty");
			MatchInitData.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "category");
			MatchInitData.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "description");
			MatchInitData.NativeFieldInfoPtr_flavorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "flavorText");
			MatchInitData.NativeFieldInfoPtr_SkirmishRuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "SkirmishRuleMods");
			MatchInitData.NativeFieldInfoPtr_SkirmishScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "SkirmishScoringMethods");
			MatchInitData.NativeFieldInfoPtr_requireOwnership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "requireOwnership");
			MatchInitData.NativeFieldInfoPtr_validAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "validAvatars");
			MatchInitData.NativeFieldInfoPtr_validColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "validColors");
			MatchInitData.NativeFieldInfoPtr_Ranked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "Ranked");
			MatchInitData.NativeFieldInfoPtr_randomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "randomSeed");
			MatchInitData.NativeFieldInfoPtr_deviceUniqueIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "deviceUniqueIdentifier");
			MatchInitData.NativeMethodInfoPtr_get_players_Public_Abstract_Virtual_New_get_List_1_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663903);
			MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663904);
			MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663905);
			MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663906);
			MatchInitData.NativeMethodInfoPtr_AddOption_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663907);
			MatchInitData.NativeMethodInfoPtr_ValueForOption_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663908);
			MatchInitData.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663909);
			MatchInitData.NativeMethodInfoPtr_AddEmptyPlayer_Public_Abstract_Virtual_New_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663910);
			MatchInitData.NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663911);
			MatchInitData.NativeMethodInfoPtr_RemovePlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663912);
			MatchInitData.NativeMethodInfoPtr_GetHumanAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663913);
			MatchInitData.NativeMethodInfoPtr_GetAIAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663914);
			MatchInitData.NativeMethodInfoPtr_getAccountIDs_Protected_Virtual_New_Il2CppReferenceArray_1_AccountID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, 100663915);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0002407C File Offset: 0x0002227C
		public unsafe virtual List<PlayerMatchInitData> players
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_get_players_Public_Abstract_Virtual_New_get_List_1_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerMatchInitData>>(intPtr3) : null;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000240C8 File Offset: 0x000222C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548769, RefRangeEnd = 548770, XrefRangeStart = 548760, XrefRangeEnd = 548769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchInitData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00024104 File Offset: 0x00022304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548780, RefRangeEnd = 548781, XrefRangeStart = 548770, XrefRangeEnd = 548780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchInitData(GameID gid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00024150 File Offset: 0x00022350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548871, RefRangeEnd = 548872, XrefRangeStart = 548781, XrefRangeEnd = 548871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchInitData(MatchInitData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002419C File Offset: 0x0002239C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 548883, RefRangeEnd = 548887, XrefRangeStart = 548872, XrefRangeEnd = 548883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(string key, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.NativeMethodInfoPtr_AddOption_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000241F0 File Offset: 0x000223F0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 548893, RefRangeEnd = 548910, XrefRangeStart = 548887, XrefRangeEnd = 548893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ValueForOption(string key, string defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.NativeMethodInfoPtr_ValueForOption_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0002424C File Offset: 0x0002244C
		[CallerCount(0)]
		public unsafe virtual MatchInitData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00024298 File Offset: 0x00022498
		[CallerCount(0)]
		public unsafe virtual PlayerMatchInitData AddEmptyPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_AddEmptyPlayer_Public_Abstract_Virtual_New_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000242E4 File Offset: 0x000224E4
		[CallerCount(0)]
		public unsafe virtual void AddPlayer(PlayerMatchInitData p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00024334 File Offset: 0x00022534
		[CallerCount(0)]
		public unsafe virtual void RemovePlayer(PlayerMatchInitData p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_RemovePlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00024384 File Offset: 0x00022584
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<AccountID> GetHumanAccountIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_GetHumanAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr3) : null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000243D0 File Offset: 0x000225D0
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<AccountID> GetAIAccountIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_GetAIAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr3) : null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0002441C File Offset: 0x0002261C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548910, XrefRangeEnd = 548945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<AccountID> getAccountIDs(bool isHuman)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHuman;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchInitData.NativeMethodInfoPtr_getAccountIDs_Protected_Virtual_New_Il2CppReferenceArray_1_AccountID_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr3) : null;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002FD0 File Offset: 0x000011D0
		public MatchInitData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00024474 File Offset: 0x00022674
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002FD9 File Offset: 0x000011D9
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000244A4 File Offset: 0x000226A4
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002FF8 File Offset: 0x000011F8
		public unsafe AccountID currentTurnPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_currentTurnPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_currentTurnPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000244D4 File Offset: 0x000226D4
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003017 File Offset: 0x00001217
		public unsafe Dictionary<string, string> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00024504 File Offset: 0x00022704
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003036 File Offset: 0x00001236
		public unsafe SerializedGameState gameState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00024534 File Offset: 0x00022734
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003055 File Offset: 0x00001255
		public unsafe long createdAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_createdAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_createdAt)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0002455C File Offset: 0x0002275C
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003070 File Offset: 0x00001270
		public unsafe SaveData saveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_saveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0002458C File Offset: 0x0002278C
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000308F File Offset: 0x0000128F
		public unsafe string scenarioName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_scenarioName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_scenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000245B4 File Offset: 0x000227B4
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000030AE File Offset: 0x000012AE
		public unsafe string gameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_gameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000245DC File Offset: 0x000227DC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000030CD File Offset: 0x000012CD
		public unsafe ClientMatchConfigData clientMatchOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_clientMatchOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientMatchConfigData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_clientMatchOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0002460C File Offset: 0x0002280C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000030EC File Offset: 0x000012EC
		public unsafe string difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_difficulty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_difficulty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00024634 File Offset: 0x00022834
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000310B File Offset: 0x0000130B
		public unsafe string category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0002465C File Offset: 0x0002285C
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000312A File Offset: 0x0000132A
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00024684 File Offset: 0x00022884
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003149 File Offset: 0x00001349
		public unsafe string flavorText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_flavorText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_flavorText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000246AC File Offset: 0x000228AC
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003168 File Offset: 0x00001368
		public unsafe List<int> SkirmishRuleMods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_SkirmishRuleMods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_SkirmishRuleMods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000246DC File Offset: 0x000228DC
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003187 File Offset: 0x00001387
		public unsafe List<int> SkirmishScoringMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_SkirmishScoringMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_SkirmishScoringMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0002470C File Offset: 0x0002290C
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000031A6 File Offset: 0x000013A6
		public unsafe List<string> requireOwnership
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_requireOwnership);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_requireOwnership), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0002473C File Offset: 0x0002293C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000031C5 File Offset: 0x000013C5
		public unsafe Il2CppStringArray validAvatars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_validAvatars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_validAvatars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0002476C File Offset: 0x0002296C
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000031E4 File Offset: 0x000013E4
		public unsafe Il2CppStringArray validColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_validColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_validColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0002479C File Offset: 0x0002299C
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003203 File Offset: 0x00001403
		public unsafe bool Ranked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_Ranked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_Ranked)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000247C4 File Offset: 0x000229C4
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000321E File Offset: 0x0000141E
		public unsafe int randomSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_randomSeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_randomSeed)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000247EC File Offset: 0x000229EC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00003239 File Offset: 0x00001439
		public unsafe string deviceUniqueIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_deviceUniqueIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.NativeFieldInfoPtr_deviceUniqueIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_currentTurnPlayer;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_gameState;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_createdAt;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_saveData;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_scenarioName;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_gameType;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_clientMatchOptions;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_difficulty;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_flavorText;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishRuleMods;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishScoringMethods;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_requireOwnership;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_validAvatars;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_validColors;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_Ranked;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_randomSeed;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_deviceUniqueIdentifier;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_players_Public_Abstract_Virtual_New_get_List_1_PlayerMatchInitData_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Public_Void_String_String_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_ValueForOption_Public_String_String_String_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_MatchInitData_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_AddEmptyPlayer_Public_Abstract_Virtual_New_PlayerMatchInitData_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Abstract_Virtual_New_Void_PlayerMatchInitData_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_GetAIAccountIDs_Public_Virtual_New_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_getAccountIDs_Protected_Virtual_New_Il2CppReferenceArray_1_AccountID_Boolean_0;

		// Token: 0x0200027A RID: 634
		[ObfuscatedName("Canis.MatchInitData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AD8 RID: 6872 RVA: 0x0008263C File Offset: 0x0008083C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr);
				MatchInitData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, "<>9");
				MatchInitData.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, "<>9__25_0");
				MatchInitData.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, "<>9__34_1");
				MatchInitData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, 100663917);
				MatchInitData.__c.NativeMethodInfoPtr___ctor_b__25_0_Internal_PlayerMatchInitData_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, 100663918);
				MatchInitData.__c.NativeMethodInfoPtr__getAccountIDs_b__34_1_Internal_IEnumerable_1_AccountID_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr, 100663919);
			}

			// Token: 0x06001AD9 RID: 6873 RVA: 0x000826E0 File Offset: 0x000808E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchInitData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ADA RID: 6874 RVA: 0x0008271C File Offset: 0x0008091C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548749, XrefRangeEnd = 548750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerMatchInitData __ctor_b__25_0(PlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.__c.NativeMethodInfoPtr___ctor_b__25_0_Internal_PlayerMatchInitData_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr3) : null;
				}
			}

			// Token: 0x06001ADB RID: 6875 RVA: 0x0008276C File Offset: 0x0008096C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548750, XrefRangeEnd = 548760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AccountID> _getAccountIDs_b__34_1(PlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.__c.NativeMethodInfoPtr__getAccountIDs_b__34_1_Internal_IEnumerable_1_AccountID_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AccountID>>(intPtr3) : null;
				}
			}

			// Token: 0x06001ADC RID: 6876 RVA: 0x0000CD2F File Offset: 0x0000AF2F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000827BC File Offset: 0x000809BC
			// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000CD38 File Offset: 0x0000AF38
			public unsafe static MatchInitData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchInitData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchInitData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000827E4 File Offset: 0x000809E4
			// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000CD4A File Offset: 0x0000AF4A
			public unsafe static Func<PlayerMatchInitData, PlayerMatchInitData> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchInitData.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, PlayerMatchInitData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchInitData.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0008280C File Offset: 0x00080A0C
			// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000CD5C File Offset: 0x0000AF5C
			public unsafe static Func<PlayerMatchInitData, IEnumerable<AccountID>> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchInitData.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, IEnumerable<AccountID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchInitData.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001121 RID: 4385
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001122 RID: 4386
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04001123 RID: 4387
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x04001124 RID: 4388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001125 RID: 4389
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__25_0_Internal_PlayerMatchInitData_PlayerMatchInitData_0;

			// Token: 0x04001126 RID: 4390
			private static readonly IntPtr NativeMethodInfoPtr__getAccountIDs_b__34_1_Internal_IEnumerable_1_AccountID_PlayerMatchInitData_0;
		}

		// Token: 0x0200027B RID: 635
		[ObfuscatedName("Canis.MatchInitData+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Object
		{
			// Token: 0x06001AE3 RID: 6883 RVA: 0x00082834 File Offset: 0x00080A34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchInitData>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr);
				MatchInitData.__c__DisplayClass34_0.NativeFieldInfoPtr_isHuman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr, "isHuman");
				MatchInitData.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr, 100663920);
				MatchInitData.__c__DisplayClass34_0.NativeMethodInfoPtr__getAccountIDs_b__0_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr, 100663921);
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x0008289C File Offset: 0x00080A9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchInitData.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x000828D8 File Offset: 0x00080AD8
			[CallerCount(0)]
			public unsafe bool _getAccountIDs_b__0(PlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchInitData.__c__DisplayClass34_0.NativeMethodInfoPtr__getAccountIDs_b__0_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AE6 RID: 6886 RVA: 0x0000CD6E File Offset: 0x0000AF6E
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00082928 File Offset: 0x00080B28
			// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0000CD77 File Offset: 0x0000AF77
			public unsafe bool isHuman
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.__c__DisplayClass34_0.NativeFieldInfoPtr_isHuman);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchInitData.__c__DisplayClass34_0.NativeFieldInfoPtr_isHuman)) = value;
				}
			}

			// Token: 0x04001127 RID: 4391
			private static readonly IntPtr NativeFieldInfoPtr_isHuman;

			// Token: 0x04001128 RID: 4392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001129 RID: 4393
			private static readonly IntPtr NativeMethodInfoPtr__getAccountIDs_b__0_Internal_Boolean_PlayerMatchInitData_0;
		}
	}
}
