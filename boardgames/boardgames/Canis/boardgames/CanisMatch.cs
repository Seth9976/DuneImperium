using System;
using Canis.entities;
using Canis.json.events;
using Canis.utils.ids;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace Canis.boardgames
{
	// Token: 0x0200002E RID: 46
	public class CanisMatch : MonoBehaviour
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0001606C File Offset: 0x0001426C
		// Note: this type is marked as 'beforefieldinit'.
		static CanisMatch()
		{
			Il2CppClassPointerStore<CanisMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "Canis.boardgames", "CanisMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr);
			CanisMatch.NativeFieldInfoPtr__IsLive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "<IsLive>k__BackingField");
			CanisMatch.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "match");
			CanisMatch.NativeFieldInfoPtr_localAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "localAccountID");
			CanisMatch.NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "session");
			CanisMatch.NativeFieldInfoPtr_sessionGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "sessionGameID");
			CanisMatch.NativeFieldInfoPtr_SaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "SaveData");
			CanisMatch.NativeFieldInfoPtr_Saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "Saved");
			CanisMatch.NativeFieldInfoPtr_saveHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "saveHotkeys");
			CanisMatch.NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663617);
			CanisMatch.NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663618);
			CanisMatch.NativeMethodInfoPtr_set_IsLive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663619);
			CanisMatch.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663620);
			CanisMatch.NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663621);
			CanisMatch.NativeMethodInfoPtr_get_Match_Public_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663622);
			CanisMatch.NativeMethodInfoPtr_Configure_Public_Void_Match_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663623);
			CanisMatch.NativeMethodInfoPtr_SetSaveData_Protected_Task_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663624);
			CanisMatch.NativeMethodInfoPtr_UpdateSaveData_Protected_Void_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663625);
			CanisMatch.NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663626);
			CanisMatch.NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663627);
			CanisMatch.NativeMethodInfoPtr_Resign_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663628);
			CanisMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663629);
			CanisMatch.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663630);
			CanisMatch.NativeMethodInfoPtr_isKeyComboActive_Private_Static_Boolean_Il2CppStructArray_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663631);
			CanisMatch.NativeMethodInfoPtr_MessageDispatcher_Public_Void_AccountID_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663632);
			CanisMatch.NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663633);
			CanisMatch.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663634);
			CanisMatch.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_New_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663635);
			CanisMatch.NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663636);
			CanisMatch.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663637);
			CanisMatch.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663638);
			CanisMatch.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663639);
			CanisMatch.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663640);
			CanisMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663641);
			CanisMatch.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, 100663642);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00016344 File Offset: 0x00014544
		public unsafe bool Logging
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984230, XrefRangeEnd = 984237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00016380 File Offset: 0x00014580
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000163BC File Offset: 0x000145BC
		public unsafe bool IsLive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_set_IsLive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000163FC File Offset: 0x000145FC
		public unsafe GameID GameID
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 984237, RefRangeEnd = 984245, XrefRangeStart = 984237, XrefRangeEnd = 984237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0001643C File Offset: 0x0001463C
		public unsafe GameID AnalyticsGameID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 984246, RefRangeEnd = 984247, XrefRangeStart = 984245, XrefRangeEnd = 984246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001647C File Offset: 0x0001467C
		public unsafe Match Match
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_get_Match_Public_get_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000164BC File Offset: 0x000146BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984275, RefRangeEnd = 984276, XrefRangeStart = 984247, XrefRangeEnd = 984275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(Match match, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_Configure_Public_Void_Match_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00016510 File Offset: 0x00014710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984276, XrefRangeEnd = 984284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SetSaveData(SaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_SetSaveData_Protected_Task_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00016560 File Offset: 0x00014760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984284, XrefRangeEnd = 984285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSaveData(SaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_UpdateSaveData_Protected_Void_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000165A4 File Offset: 0x000147A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984285, XrefRangeEnd = 984290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator LeavePlaymatWithoutResigning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000165F0 File Offset: 0x000147F0
		[CallerCount(0)]
		public unsafe virtual void SaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001662C File Offset: 0x0001482C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984292, RefRangeEnd = 984293, XrefRangeStart = 984290, XrefRangeEnd = 984292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_Resign_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00016660 File Offset: 0x00014860
		[CallerCount(0)]
		public unsafe virtual void DeleteSaveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_DeleteSaveGame_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001669C File Offset: 0x0001489C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000166D8 File Offset: 0x000148D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984293, XrefRangeEnd = 984295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isKeyComboActive(Il2CppStructArray<KeyCode> keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_isKeyComboActive_Private_Static_Boolean_Il2CppStructArray_1_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001671C File Offset: 0x0001491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984295, XrefRangeEnd = 984387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MessageDispatcher(AccountID accountID, DWDEvent message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_MessageDispatcher_Public_Void_AccountID_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00016770 File Offset: 0x00014970
		[CallerCount(0)]
		public unsafe virtual void Write(global::Il2CppSystem.Object message, AccountID accountID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000167D0 File Offset: 0x000149D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984387, XrefRangeEnd = 984401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(global::Il2CppSystem.Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00016820 File Offset: 0x00014A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984401, XrefRangeEnd = 984432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteFromAccount(global::Il2CppSystem.Object message, AccountID accountID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisMatch.NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_New_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00016880 File Offset: 0x00014A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984432, XrefRangeEnd = 984459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteSimpleMessage(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000168C4 File Offset: 0x00014AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984459, XrefRangeEnd = 984462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00016908 File Offset: 0x00014B08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 984465, RefRangeEnd = 984468, XrefRangeStart = 984462, XrefRangeEnd = 984465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001694C File Offset: 0x00014B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984468, XrefRangeEnd = 984474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00016990 File Offset: 0x00014B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 984477, RefRangeEnd = 984480, XrefRangeStart = 984474, XrefRangeEnd = 984477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000169D4 File Offset: 0x00014BD4
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00016A08 File Offset: 0x00014C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984487, RefRangeEnd = 984488, XrefRangeStart = 984480, XrefRangeEnd = 984487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public CanisMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00016A44 File Offset: 0x00014C44
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe bool _IsLive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr__IsLive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr__IsLive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00016A6C File Offset: 0x00014C6C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00016A9C File Offset: 0x00014C9C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public unsafe AccountID localAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_localAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_localAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00016ACC File Offset: 0x00014CCC
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D13 File Offset: 0x00000F13
		public unsafe SessionProvider session
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_session);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_session), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00016AFC File Offset: 0x00014CFC
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002D32 File Offset: 0x00000F32
		public unsafe GameID sessionGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_sessionGameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_sessionGameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00016B2C File Offset: 0x00014D2C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002D51 File Offset: 0x00000F51
		public unsafe SaveData SaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_SaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_SaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00016B5C File Offset: 0x00014D5C
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002D70 File Offset: 0x00000F70
		public unsafe bool Saved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_Saved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_Saved)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00016B84 File Offset: 0x00014D84
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002D8B File Offset: 0x00000F8B
		public unsafe Il2CppStructArray<KeyCode> saveHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_saveHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.NativeFieldInfoPtr_saveHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr__IsLive_k__BackingField;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_localAccountID;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_session;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_sessionGameID;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_SaveData;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_Saved;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_saveHotkeys;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLive_Public_get_Boolean_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLive_Protected_set_Void_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_Match_Public_get_Match_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Match_AccountID_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_SetSaveData_Protected_Task_SaveData_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSaveData_Protected_Void_SaveData_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_LeavePlaymatWithoutResigning_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Resign_Public_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_isKeyComboActive_Private_Static_Boolean_Il2CppStructArray_1_KeyCode_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_MessageDispatcher_Public_Void_AccountID_DWDEvent_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_Object_AccountID_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_WriteFromAccount_Public_Virtual_New_Void_Object_AccountID_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_WriteSimpleMessage_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001A9 RID: 425
		[ObfuscatedName("Canis.boardgames.CanisMatch+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060014B7 RID: 5303 RVA: 0x00050E74 File Offset: 0x0004F074
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr);
				CanisMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr, "<>9");
				CanisMatch.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr, "<>9__28_0");
				CanisMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr, 100663644);
				CanisMatch.__c.NativeMethodInfoPtr__MessageDispatcher_b__28_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr, 100663645);
			}

			// Token: 0x060014B8 RID: 5304 RVA: 0x00050EF0 File Offset: 0x0004F0F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014B9 RID: 5305 RVA: 0x00050F2C File Offset: 0x0004F12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984216, XrefRangeEnd = 984220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MessageDispatcher_b__28_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.__c.NativeMethodInfoPtr__MessageDispatcher_b__28_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014BA RID: 5306 RVA: 0x0000BB63 File Offset: 0x00009D63
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x060014BB RID: 5307 RVA: 0x00050F7C File Offset: 0x0004F17C
			// (set) Token: 0x060014BC RID: 5308 RVA: 0x0000BB6C File Offset: 0x00009D6C
			public unsafe static CanisMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x060014BD RID: 5309 RVA: 0x00050FA4 File Offset: 0x0004F1A4
			// (set) Token: 0x060014BE RID: 5310 RVA: 0x0000BB7E File Offset: 0x00009D7E
			public unsafe static Func<PlayerEntity, bool> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisMatch.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisMatch.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C8E RID: 3214
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C8F RID: 3215
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04000C90 RID: 3216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C91 RID: 3217
			private static readonly IntPtr NativeMethodInfoPtr__MessageDispatcher_b__28_0_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x020001AA RID: 426
		[ObfuscatedName("Canis.boardgames.CanisMatch+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060014BF RID: 5311 RVA: 0x00050FCC File Offset: 0x0004F1CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr);
				CanisMatch.__c__DisplayClass28_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr, "accountID");
				CanisMatch.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr, 100663646);
				CanisMatch.__c__DisplayClass28_0.NativeMethodInfoPtr__MessageDispatcher_b__1_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr, 100663647);
			}

			// Token: 0x060014C0 RID: 5312 RVA: 0x00051034 File Offset: 0x0004F234
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisMatch.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014C1 RID: 5313 RVA: 0x00051070 File Offset: 0x0004F270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984220, XrefRangeEnd = 984225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MessageDispatcher_b__1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch.__c__DisplayClass28_0.NativeMethodInfoPtr__MessageDispatcher_b__1_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014C2 RID: 5314 RVA: 0x0000BB90 File Offset: 0x00009D90
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x060014C3 RID: 5315 RVA: 0x000510C0 File Offset: 0x0004F2C0
			// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0000BB99 File Offset: 0x00009D99
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.__c__DisplayClass28_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch.__c__DisplayClass28_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C92 RID: 3218
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04000C93 RID: 3219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C94 RID: 3220
			private static readonly IntPtr NativeMethodInfoPtr__MessageDispatcher_b__1_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x020001AB RID: 427
		[ObfuscatedName("Canis.boardgames.CanisMatch+<LeavePlaymatWithoutResigning>d__22")]
		public sealed class _LeavePlaymatWithoutResigning_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x060014C5 RID: 5317 RVA: 0x000510F0 File Offset: 0x0004F2F0
			// Note: this type is marked as 'beforefieldinit'.
			static _LeavePlaymatWithoutResigning_d__22()
			{
				Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisMatch>.NativeClassPtr, "<LeavePlaymatWithoutResigning>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, "<>1__state");
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, "<>2__current");
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, "<>4__this");
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663648);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663649);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663650);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663651);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663652);
				CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr, 100663653);
			}

			// Token: 0x060014C6 RID: 5318 RVA: 0x000511D0 File Offset: 0x0004F3D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LeavePlaymatWithoutResigning_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisMatch._LeavePlaymatWithoutResigning_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014C7 RID: 5319 RVA: 0x00051218 File Offset: 0x0004F418
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014C8 RID: 5320 RVA: 0x0005124C File Offset: 0x0004F44C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00051288 File Offset: 0x0004F488
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014CA RID: 5322 RVA: 0x000512C8 File Offset: 0x0004F4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984225, XrefRangeEnd = 984230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060014CB RID: 5323 RVA: 0x000512FC File Offset: 0x0004F4FC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014CC RID: 5324 RVA: 0x0000BBB8 File Offset: 0x00009DB8
			public _LeavePlaymatWithoutResigning_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060014CD RID: 5325 RVA: 0x0005133C File Offset: 0x0004F53C
			// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000BBC1 File Offset: 0x00009DC1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060014CF RID: 5327 RVA: 0x00051364 File Offset: 0x0004F564
			// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000BBDC File Offset: 0x00009DDC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00051394 File Offset: 0x0004F594
			// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000BBFB File Offset: 0x00009DFB
			public unsafe CanisMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisMatch._LeavePlaymatWithoutResigning_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C95 RID: 3221
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C96 RID: 3222
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C97 RID: 3223
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C98 RID: 3224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C99 RID: 3225
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C9A RID: 3226
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C9B RID: 3227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C9C RID: 3228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C9D RID: 3229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001AC RID: 428
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_0<T>
		{
			// Token: 0x04000C9E RID: 3230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisMatch.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0, Il2CppClassPointerStore<CanisMatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AD RID: 429
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>
		{
			// Token: 0x04000C9F RID: 3231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisMatch.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0, Il2CppClassPointerStore<CanisMatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AE RID: 430
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_0<T>
		{
			// Token: 0x04000CA0 RID: 3232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisMatch.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0, Il2CppClassPointerStore<CanisMatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AF RID: 431
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0<T>
		{
			// Token: 0x04000CA1 RID: 3233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisMatch.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0, Il2CppClassPointerStore<CanisMatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
