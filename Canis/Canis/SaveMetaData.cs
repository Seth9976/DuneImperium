using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x0200002C RID: 44
	public class SaveMetaData : Object
	{
		// Token: 0x060002FE RID: 766 RVA: 0x00025688 File Offset: 0x00023888
		// Note: this type is marked as 'beforefieldinit'.
		static SaveMetaData()
		{
			Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "SaveMetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr);
			SaveMetaData.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "gameID");
			SaveMetaData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "options");
			SaveMetaData.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "names");
			SaveMetaData.NativeFieldInfoPtr_activePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "activePlayer");
			SaveMetaData.NativeFieldInfoPtr_selectionPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "selectionPlayers");
			SaveMetaData.NativeFieldInfoPtr_turnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "turnNumber");
			SaveMetaData.NativeFieldInfoPtr_createdAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "createdAt");
			SaveMetaData.NativeFieldInfoPtr_lastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "lastMove");
			SaveMetaData.NativeFieldInfoPtr_lastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "lastPlayed");
			SaveMetaData.NativeFieldInfoPtr_scenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "scenarioKey");
			SaveMetaData.NativeFieldInfoPtr_gameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "gameName");
			SaveMetaData.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "gameState");
			SaveMetaData.NativeFieldInfoPtr_matchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, "matchType");
			SaveMetaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663949);
			SaveMetaData.NativeMethodInfoPtr_NameForAccountID_Public_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663950);
			SaveMetaData.NativeMethodInfoPtr_GetSaveFileName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663951);
			SaveMetaData.NativeMethodInfoPtr_GetLegacySaveFileName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663952);
			SaveMetaData.NativeMethodInfoPtr__ctor_Public_Void_GameID_List_1_AccountIDUsernameMetadata_AccountID_Int32_Int64_Int64_Int64_String_String_String_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663953);
			SaveMetaData.NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663954);
			SaveMetaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr, 100663955);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00025848 File Offset: 0x00023A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549370, RefRangeEnd = 549371, XrefRangeStart = 549362, XrefRangeEnd = 549370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00025884 File Offset: 0x00023A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549371, XrefRangeEnd = 549386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NameForAccountID(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr_NameForAccountID_Public_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000258CC File Offset: 0x00023ACC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549125, XrefRangeEnd = 549132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSaveFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr_GetSaveFileName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00025904 File Offset: 0x00023B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549386, XrefRangeEnd = 549394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLegacySaveFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr_GetLegacySaveFileName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0002593C File Offset: 0x00023B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549394, XrefRangeEnd = 549413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData(GameID pID, List<AccountIDUsernameMetadata> pNames, AccountID pActivePlayer, int pTurnNum, long pCreatedAt, long pLastMove, long pLastPlayed, string pScenarioKey, string gName, string mType, List<AccountID> playersMakingCurrentSelection = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pActivePlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pTurnNum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCreatedAt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pLastMove;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pLastPlayed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pScenarioKey);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gName);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mType);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersMakingCurrentSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr__ctor_Public_Void_GameID_List_1_AccountIDUsernameMetadata_AccountID_Int32_Int64_Int64_Int64_String_String_String_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00025A34 File Offset: 0x00023C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 549417, RefRangeEnd = 549419, XrefRangeStart = 549413, XrefRangeEnd = 549417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool myTurn(AccountID myAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaData.NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00025A84 File Offset: 0x00023C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549419, XrefRangeEnd = 549457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveMetaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003529 File Offset: 0x00001729
		public SaveMetaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00025AC8 File Offset: 0x00023CC8
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003532 File Offset: 0x00001732
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00025AF8 File Offset: 0x00023CF8
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003551 File Offset: 0x00001751
		public unsafe Dictionary<string, string> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00025B28 File Offset: 0x00023D28
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00003570 File Offset: 0x00001770
		public unsafe List<AccountIDUsernameMetadata> names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00025B58 File Offset: 0x00023D58
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000358F File Offset: 0x0000178F
		public unsafe AccountID activePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_activePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_activePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00025B88 File Offset: 0x00023D88
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000035AE File Offset: 0x000017AE
		public unsafe List<AccountID> selectionPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_selectionPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_selectionPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00025BB8 File Offset: 0x00023DB8
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000035CD File Offset: 0x000017CD
		public unsafe int turnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_turnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_turnNumber)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00025BE0 File Offset: 0x00023DE0
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe long createdAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_createdAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_createdAt)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00025C08 File Offset: 0x00023E08
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003603 File Offset: 0x00001803
		public unsafe long lastMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_lastMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_lastMove)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00025C30 File Offset: 0x00023E30
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000361E File Offset: 0x0000181E
		public unsafe long lastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_lastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_lastPlayed)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00025C58 File Offset: 0x00023E58
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003639 File Offset: 0x00001839
		public unsafe string scenarioKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_scenarioKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_scenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00025C80 File Offset: 0x00023E80
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003658 File Offset: 0x00001858
		public unsafe string gameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00025CA8 File Offset: 0x00023EA8
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003677 File Offset: 0x00001877
		public unsafe string gameState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_gameState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00025CD0 File Offset: 0x00023ED0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003696 File Offset: 0x00001896
		public unsafe string matchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_matchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaData.NativeFieldInfoPtr_matchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_activePlayer;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_selectionPlayers;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_turnNumber;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_createdAt;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_lastMove;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_lastPlayed;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_scenarioKey;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_gameName;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_gameState;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_matchType;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_NameForAccountID_Public_String_AccountID_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveFileName_Public_String_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacySaveFileName_Public_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_List_1_AccountIDUsernameMetadata_AccountID_Int32_Int64_Int64_Int64_String_String_String_List_1_AccountID_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_myTurn_Public_Boolean_AccountID_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
