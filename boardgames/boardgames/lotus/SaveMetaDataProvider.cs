using System;
using boardgames.data;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus.enums;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000BD RID: 189
	public class SaveMetaDataProvider : MonoBehaviour
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x0002F16C File Offset: 0x0002D36C
		// Note: this type is marked as 'beforefieldinit'.
		static SaveMetaDataProvider()
		{
			Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "SaveMetaDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr);
			SaveMetaDataProvider.NativeFieldInfoPtr_saveFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "saveFolder");
			SaveMetaDataProvider.NativeFieldInfoPtr_metaDataFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "metaDataFilePath");
			SaveMetaDataProvider.NativeFieldInfoPtr_saveFileNamePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "saveFileNamePattern");
			SaveMetaDataProvider.NativeFieldInfoPtr__GameData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<GameData>k__BackingField");
			SaveMetaDataProvider.NativeFieldInfoPtr_saveLocalFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "saveLocalFile");
			SaveMetaDataProvider.NativeFieldInfoPtr_currentSaveOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "currentSaveOperation");
			SaveMetaDataProvider.NativeFieldInfoPtr_dataToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "dataToSave");
			SaveMetaDataProvider.NativeFieldInfoPtr_optionsToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "optionsToSave");
			SaveMetaDataProvider.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "version");
			SaveMetaDataProvider.NativeFieldInfoPtr_writtenVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "writtenVersion");
			SaveMetaDataProvider.NativeMethodInfoPtr_get_GameData_Public_get_GameMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664783);
			SaveMetaDataProvider.NativeMethodInfoPtr_set_GameData_Private_set_Void_GameMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664784);
			SaveMetaDataProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664785);
			SaveMetaDataProvider.NativeMethodInfoPtr_Init_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664786);
			SaveMetaDataProvider.NativeMethodInfoPtr_SaveGame_Public_IEnumerator_SaveData_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664787);
			SaveMetaDataProvider.NativeMethodInfoPtr_SaveGameInternal_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664788);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetFirstMatchOfType_Public_SaveMetaData_MatchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664789);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetMetaDataForScenarioKey_Public_SaveMetaData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664790);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetMetaDataForScenarioKeyAndMatchType_Public_SaveMetaData_String_MatchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664791);
			SaveMetaDataProvider.NativeMethodInfoPtr_HasGameContainingScenarioKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664792);
			SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSave_Public_IEnumerator_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664793);
			SaveMetaDataProvider.NativeMethodInfoPtr_getMetaDataFilePath_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664794);
			SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664795);
			SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664796);
			SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664797);
			SaveMetaDataProvider.NativeMethodInfoPtr_LoadDataFromMeta_Public_LoadReference_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664798);
			SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664799);
			SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664800);
			SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Private_IEnumerator_String_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664801);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetSaveForGame_Public_SaveMetaData_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664802);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetGames_Public_List_1_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664803);
			SaveMetaDataProvider.NativeMethodInfoPtr_GetOfflineGuid_Public_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664804);
			SaveMetaDataProvider.NativeMethodInfoPtr_UpdateMetaData_Public_Void_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664805);
			SaveMetaDataProvider.NativeMethodInfoPtr_RemoveMetaData_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664806);
			SaveMetaDataProvider.NativeMethodInfoPtr_LogSaveError_Private_Static_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664807);
			SaveMetaDataProvider.NativeMethodInfoPtr_HandleLoadError_Private_IEnumerator_SaveMetaData_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664808);
			SaveMetaDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, 100664809);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002F480 File Offset: 0x0002D680
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		public unsafe GameMetaData GameData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_get_GameData_Public_get_GameMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameMetaData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_set_GameData_Private_set_Void_GameMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002F504 File Offset: 0x0002D704
		public unsafe bool Initialized
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002F540 File Offset: 0x0002D740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992960, XrefRangeEnd = 992965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_Init_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002F580 File Offset: 0x0002D780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992972, RefRangeEnd = 992973, XrefRangeStart = 992965, XrefRangeEnd = 992972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SaveGame(SaveData saveData, Dictionary<string, string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_SaveGame_Public_IEnumerator_SaveData_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992973, XrefRangeEnd = 992978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SaveGameInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_SaveGameInternal_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002F624 File Offset: 0x0002D824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992978, XrefRangeEnd = 993001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData GetFirstMatchOfType(MatchType matchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref matchType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetFirstMatchOfType_Public_SaveMetaData_MatchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr3) : null;
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002F670 File Offset: 0x0002D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993001, XrefRangeEnd = 993022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData GetMetaDataForScenarioKey(string scenarioKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetMetaDataForScenarioKey_Public_SaveMetaData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr3) : null;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002F6C0 File Offset: 0x0002D8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993022, XrefRangeEnd = 993046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData GetMetaDataForScenarioKeyAndMatchType(string scenarioKey, MatchType matchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetMetaDataForScenarioKeyAndMatchType_Public_SaveMetaData_String_MatchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr3) : null;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002F720 File Offset: 0x0002D920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993067, RefRangeEnd = 993068, XrefRangeStart = 993046, XrefRangeEnd = 993067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasGameContainingScenarioKey(string scenarioKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_HasGameContainingScenarioKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002F770 File Offset: 0x0002D970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 993074, RefRangeEnd = 993076, XrefRangeStart = 993068, XrefRangeEnd = 993074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeleteSave(SaveMetaData metaData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSave_Public_IEnumerator_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993076, XrefRangeEnd = 993079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getMetaDataFilePath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_getMetaDataFilePath_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002F7EC File Offset: 0x0002D9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993079, XrefRangeEnd = 993082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getSaveFilePath(SaveMetaData metaData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveMetaData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002F828 File Offset: 0x0002DA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getSaveFilePath(SaveData saveData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002F864 File Offset: 0x0002DA64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 993089, RefRangeEnd = 993097, XrefRangeStart = 993082, XrefRangeEnd = 993089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getSaveFilePath(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_getSaveFilePath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0002F8A0 File Offset: 0x0002DAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993125, RefRangeEnd = 993126, XrefRangeStart = 993097, XrefRangeEnd = 993125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaDataProvider.LoadReference LoadDataFromMeta(SaveMetaData svd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_LoadDataFromMeta_Public_LoadReference_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider.LoadReference>(intPtr3) : null;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 993132, RefRangeEnd = 993134, XrefRangeStart = 993126, XrefRangeEnd = 993132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeleteSaveGame(SaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002F940 File Offset: 0x0002DB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993137, RefRangeEnd = 993138, XrefRangeStart = 993134, XrefRangeEnd = 993137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeleteSaveGame(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002F990 File Offset: 0x0002DB90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 993145, RefRangeEnd = 993147, XrefRangeStart = 993138, XrefRangeEnd = 993145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeleteSaveGame(string saveGameFileName, GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(saveGameFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_DeleteSaveGame_Private_IEnumerator_String_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 993150, RefRangeEnd = 993159, XrefRangeStart = 993147, XrefRangeEnd = 993150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaData GetSaveForGame(GameID pGame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pGame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetSaveForGame_Public_SaveMetaData_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr3) : null;
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002FA44 File Offset: 0x0002DC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993159, XrefRangeEnd = 993166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SaveMetaData> GetGames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetGames_Public_List_1_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SaveMetaData>>(intPtr3) : null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002FA84 File Offset: 0x0002DC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993166, XrefRangeEnd = 993174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid GetOfflineGuid(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_GetOfflineGuid_Public_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993174, XrefRangeEnd = 993178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMetaData(SaveMetaData pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_UpdateMetaData_Public_Void_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0002FB14 File Offset: 0x0002DD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993178, XrefRangeEnd = 993182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMetaData(GameID pID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_RemoveMetaData_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002FB58 File Offset: 0x0002DD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993182, XrefRangeEnd = 993192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogSaveError(ErrorInfo error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_LogSaveError_Private_Static_Void_ErrorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0002FB94 File Offset: 0x0002DD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993192, XrefRangeEnd = 993199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HandleLoadError(SaveMetaData saveMetaData, ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveMetaData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr_HandleLoadError_Private_IEnumerator_SaveMetaData_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002FBFC File Offset: 0x0002DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993199, XrefRangeEnd = 993200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveMetaDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000064E3 File Offset: 0x000046E3
		public SaveMetaDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002FC38 File Offset: 0x0002DE38
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000064EC File Offset: 0x000046EC
		public unsafe static string saveFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.NativeFieldInfoPtr_saveFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.NativeFieldInfoPtr_saveFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002FC58 File Offset: 0x0002DE58
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000064FE File Offset: 0x000046FE
		public unsafe static string metaDataFilePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.NativeFieldInfoPtr_metaDataFilePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.NativeFieldInfoPtr_metaDataFilePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002FC78 File Offset: 0x0002DE78
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006510 File Offset: 0x00004710
		public unsafe static string saveFileNamePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.NativeFieldInfoPtr_saveFileNamePattern, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.NativeFieldInfoPtr_saveFileNamePattern, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002FC98 File Offset: 0x0002DE98
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006522 File Offset: 0x00004722
		public unsafe GameMetaData _GameData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr__GameData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameMetaData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr__GameData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0002FCC8 File Offset: 0x0002DEC8
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00006541 File Offset: 0x00004741
		public unsafe bool saveLocalFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_saveLocalFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_saveLocalFile)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002FCF0 File Offset: 0x0002DEF0
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0000655C File Offset: 0x0000475C
		public unsafe IEnumerator currentSaveOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_currentSaveOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_currentSaveOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002FD20 File Offset: 0x0002DF20
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0000657B File Offset: 0x0000477B
		public unsafe SaveData dataToSave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_dataToSave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_dataToSave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002FD50 File Offset: 0x0002DF50
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0000659A File Offset: 0x0000479A
		public unsafe Dictionary<string, string> optionsToSave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_optionsToSave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_optionsToSave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0002FD80 File Offset: 0x0002DF80
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x000065B9 File Offset: 0x000047B9
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x000065D4 File Offset: 0x000047D4
		public unsafe ulong writtenVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_writtenVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.NativeFieldInfoPtr_writtenVersion)) = value;
			}
		}

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_saveFolder;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_metaDataFilePath;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_saveFileNamePattern;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr__GameData_k__BackingField;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_saveLocalFile;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_currentSaveOperation;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_dataToSave;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_optionsToSave;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_writtenVersion;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_GameData_Public_get_GameMetaData_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_set_GameData_Private_set_Void_GameMetaData_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_IEnumerator_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_SaveGame_Public_IEnumerator_SaveData_Dictionary_2_String_String_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_SaveGameInternal_Private_IEnumerator_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstMatchOfType_Public_SaveMetaData_MatchType_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaDataForScenarioKey_Public_SaveMetaData_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaDataForScenarioKeyAndMatchType_Public_SaveMetaData_String_MatchType_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_HasGameContainingScenarioKey_Public_Boolean_String_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSave_Public_IEnumerator_SaveMetaData_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_getMetaDataFilePath_Private_Static_String_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveMetaData_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_getSaveFilePath_Private_Static_String_SaveData_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_getSaveFilePath_Public_Static_String_String_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_LoadDataFromMeta_Public_LoadReference_SaveMetaData_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_SaveData_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Public_IEnumerator_GameID_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSaveGame_Private_IEnumerator_String_GameID_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveForGame_Public_SaveMetaData_GameID_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_GetGames_Public_List_1_SaveMetaData_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_GetOfflineGuid_Public_Guid_Int32_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMetaData_Public_Void_SaveMetaData_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetaData_Public_Void_GameID_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_LogSaveError_Private_Static_Void_ErrorInfo_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_HandleLoadError_Private_IEnumerator_SaveMetaData_ErrorInfo_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000225 RID: 549
		public class LoadReference : global::Il2CppSystem.Object
		{
			// Token: 0x06001943 RID: 6467 RVA: 0x0005F59C File Offset: 0x0005D79C
			// Note: this type is marked as 'beforefieldinit'.
			static LoadReference()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "LoadReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr);
				SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_loadCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, "loadCommand");
				SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_fullCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, "fullCommand");
				SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_Func_2_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, 100664810);
				SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_Result_Public_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, 100664811);
				SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, 100664812);
				SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, 100664813);
				SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr, 100664814);
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0005F654 File Offset: 0x0005D854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992638, XrefRangeEnd = 992652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadReference(SaveMetaData saveMetaData, Func<ErrorInfo, IEnumerator> onError)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.LoadReference>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveMetaData);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onError);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_Func_2_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 992658, RefRangeEnd = 992660, XrefRangeStart = 992652, XrefRangeEnd = 992658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SaveData Result()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_Result_Public_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
			}

			// Token: 0x06001946 RID: 6470 RVA: 0x0005F6F4 File Offset: 0x0005D8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992660, XrefRangeEnd = 992664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001947 RID: 6471 RVA: 0x0005F730 File Offset: 0x0005D930
			public unsafe virtual global::Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992664, XrefRangeEnd = 992668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001948 RID: 6472 RVA: 0x0005F770 File Offset: 0x0005D970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992668, XrefRangeEnd = 992672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.LoadReference.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001949 RID: 6473 RVA: 0x0000DC57 File Offset: 0x0000BE57
			public LoadReference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x0600194A RID: 6474 RVA: 0x0005F7A4 File Offset: 0x0005D9A4
			// (set) Token: 0x0600194B RID: 6475 RVA: 0x0000DC60 File Offset: 0x0000BE60
			public unsafe ILoadDataCommand loadCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_loadCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoadDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_loadCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x0600194C RID: 6476 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
			// (set) Token: 0x0600194D RID: 6477 RVA: 0x0000DC7F File Offset: 0x0000BE7F
			public unsafe IEnumerator fullCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_fullCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.LoadReference.NativeFieldInfoPtr_fullCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F4D RID: 3917
			private static readonly IntPtr NativeFieldInfoPtr_loadCommand;

			// Token: 0x04000F4E RID: 3918
			private static readonly IntPtr NativeFieldInfoPtr_fullCommand;

			// Token: 0x04000F4F RID: 3919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SaveMetaData_Func_2_ErrorInfo_IEnumerator_0;

			// Token: 0x04000F50 RID: 3920
			private static readonly IntPtr NativeMethodInfoPtr_Result_Public_SaveData_0;

			// Token: 0x04000F51 RID: 3921
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F52 RID: 3922
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F53 RID: 3923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000226 RID: 550
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x0600194E RID: 6478 RVA: 0x0000DC9E File Offset: 0x0000BE9E
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__O>.NativeClassPtr);
				SaveMetaDataProvider.__O.NativeFieldInfoPtr__0___LogSaveError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__O>.NativeClassPtr, "<0>__LogSaveError");
			}

			// Token: 0x0600194F RID: 6479 RVA: 0x0000DCD2 File Offset: 0x0000BED2
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001950 RID: 6480 RVA: 0x0005F804 File Offset: 0x0005DA04
			// (set) Token: 0x06001951 RID: 6481 RVA: 0x0000DCDB File Offset: 0x0000BEDB
			public unsafe static Action<ErrorInfo> _0___LogSaveError
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.__O.NativeFieldInfoPtr__0___LogSaveError, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.__O.NativeFieldInfoPtr__0___LogSaveError, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F54 RID: 3924
			private static readonly IntPtr NativeFieldInfoPtr__0___LogSaveError;
		}

		// Token: 0x02000227 RID: 551
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001952 RID: 6482 RVA: 0x0005F82C File Offset: 0x0005DA2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr);
				SaveMetaDataProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr, "<>9");
				SaveMetaDataProvider.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr, "<>9__17_0");
				SaveMetaDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr, 100664816);
				SaveMetaDataProvider.__c.NativeMethodInfoPtr__SaveGameInternal_b__17_0_Internal_AccountIDUsernameMetadata_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr, 100664817);
			}

			// Token: 0x06001953 RID: 6483 RVA: 0x0005F8A8 File Offset: 0x0005DAA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001954 RID: 6484 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992672, XrefRangeEnd = 992685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountIDUsernameMetadata _SaveGameInternal_b__17_0(PlayerInfoSaveData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c.NativeMethodInfoPtr__SaveGameInternal_b__17_0_Internal_AccountIDUsernameMetadata_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr3) : null;
				}
			}

			// Token: 0x06001955 RID: 6485 RVA: 0x0000DCED File Offset: 0x0000BEED
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06001956 RID: 6486 RVA: 0x0005F934 File Offset: 0x0005DB34
			// (set) Token: 0x06001957 RID: 6487 RVA: 0x0000DCF6 File Offset: 0x0000BEF6
			public unsafe static SaveMetaDataProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001958 RID: 6488 RVA: 0x0005F95C File Offset: 0x0005DB5C
			// (set) Token: 0x06001959 RID: 6489 RVA: 0x0000DD08 File Offset: 0x0000BF08
			public unsafe static Func<PlayerInfoSaveData, AccountIDUsernameMetadata> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveMetaDataProvider.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerInfoSaveData, AccountIDUsernameMetadata>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveMetaDataProvider.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F55 RID: 3925
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000F56 RID: 3926
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04000F57 RID: 3927
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F58 RID: 3928
			private static readonly IntPtr NativeMethodInfoPtr__SaveGameInternal_b__17_0_Internal_AccountIDUsernameMetadata_PlayerInfoSaveData_0;
		}

		// Token: 0x02000228 RID: 552
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600195A RID: 6490 RVA: 0x0005F984 File Offset: 0x0005DB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr);
				SaveMetaDataProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_matchTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr, "matchTypeString");
				SaveMetaDataProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr, 100664818);
				SaveMetaDataProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstMatchOfType_b__0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr, 100664819);
			}

			// Token: 0x0600195B RID: 6491 RVA: 0x0005F9EC File Offset: 0x0005DBEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600195C RID: 6492 RVA: 0x0005FA28 File Offset: 0x0005DC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992685, XrefRangeEnd = 992687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFirstMatchOfType_b__0(SaveMetaData g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstMatchOfType_b__0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600195D RID: 6493 RVA: 0x0000DD1A File Offset: 0x0000BF1A
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x0005FA78 File Offset: 0x0005DC78
			// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000DD23 File Offset: 0x0000BF23
			public unsafe string matchTypeString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_matchTypeString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass18_0.NativeFieldInfoPtr_matchTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000F59 RID: 3929
			private static readonly IntPtr NativeFieldInfoPtr_matchTypeString;

			// Token: 0x04000F5A RID: 3930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F5B RID: 3931
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstMatchOfType_b__0_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x02000229 RID: 553
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001960 RID: 6496 RVA: 0x0005FAA0 File Offset: 0x0005DCA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr);
				SaveMetaDataProvider.__c__DisplayClass19_0.NativeFieldInfoPtr_scenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr, "scenarioKey");
				SaveMetaDataProvider.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr, 100664820);
				SaveMetaDataProvider.__c__DisplayClass19_0.NativeMethodInfoPtr__GetMetaDataForScenarioKey_b__0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr, 100664821);
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x0005FB08 File Offset: 0x0005DD08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001962 RID: 6498 RVA: 0x0005FB44 File Offset: 0x0005DD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992687, XrefRangeEnd = 992689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMetaDataForScenarioKey_b__0(SaveMetaData g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass19_0.NativeMethodInfoPtr__GetMetaDataForScenarioKey_b__0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001963 RID: 6499 RVA: 0x0000DD42 File Offset: 0x0000BF42
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001964 RID: 6500 RVA: 0x0005FB94 File Offset: 0x0005DD94
			// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000DD4B File Offset: 0x0000BF4B
			public unsafe string scenarioKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass19_0.NativeFieldInfoPtr_scenarioKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass19_0.NativeFieldInfoPtr_scenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000F5C RID: 3932
			private static readonly IntPtr NativeFieldInfoPtr_scenarioKey;

			// Token: 0x04000F5D RID: 3933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F5E RID: 3934
			private static readonly IntPtr NativeMethodInfoPtr__GetMetaDataForScenarioKey_b__0_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x0200022A RID: 554
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001966 RID: 6502 RVA: 0x0005FBBC File Offset: 0x0005DDBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr);
				SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_scenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr, "scenarioKey");
				SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_matchTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr, "matchTypeString");
				SaveMetaDataProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr, 100664822);
				SaveMetaDataProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__GetMetaDataForScenarioKeyAndMatchType_b__0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr, 100664823);
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x0005FC38 File Offset: 0x0005DE38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001968 RID: 6504 RVA: 0x0005FC74 File Offset: 0x0005DE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992689, XrefRangeEnd = 992690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMetaDataForScenarioKeyAndMatchType_b__0(SaveMetaData g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass20_0.NativeMethodInfoPtr__GetMetaDataForScenarioKeyAndMatchType_b__0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x0000DD6A File Offset: 0x0000BF6A
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x0600196A RID: 6506 RVA: 0x0005FCC4 File Offset: 0x0005DEC4
			// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000DD73 File Offset: 0x0000BF73
			public unsafe string scenarioKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_scenarioKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_scenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600196C RID: 6508 RVA: 0x0005FCEC File Offset: 0x0005DEEC
			// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000DD92 File Offset: 0x0000BF92
			public unsafe string matchTypeString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_matchTypeString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass20_0.NativeFieldInfoPtr_matchTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000F5F RID: 3935
			private static readonly IntPtr NativeFieldInfoPtr_scenarioKey;

			// Token: 0x04000F60 RID: 3936
			private static readonly IntPtr NativeFieldInfoPtr_matchTypeString;

			// Token: 0x04000F61 RID: 3937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F62 RID: 3938
			private static readonly IntPtr NativeMethodInfoPtr__GetMetaDataForScenarioKeyAndMatchType_b__0_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x0200022B RID: 555
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600196E RID: 6510 RVA: 0x0005FD14 File Offset: 0x0005DF14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr);
				SaveMetaDataProvider.__c__DisplayClass21_0.NativeFieldInfoPtr_scenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr, "scenarioKey");
				SaveMetaDataProvider.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr, 100664824);
				SaveMetaDataProvider.__c__DisplayClass21_0.NativeMethodInfoPtr__HasGameContainingScenarioKey_b__0_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr, 100664825);
			}

			// Token: 0x0600196F RID: 6511 RVA: 0x0005FD7C File Offset: 0x0005DF7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001970 RID: 6512 RVA: 0x0005FDB8 File Offset: 0x0005DFB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasGameContainingScenarioKey_b__0(SaveMetaData g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass21_0.NativeMethodInfoPtr__HasGameContainingScenarioKey_b__0_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001971 RID: 6513 RVA: 0x0000DDB1 File Offset: 0x0000BFB1
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06001972 RID: 6514 RVA: 0x0005FE08 File Offset: 0x0005E008
			// (set) Token: 0x06001973 RID: 6515 RVA: 0x0000DDBA File Offset: 0x0000BFBA
			public unsafe string scenarioKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass21_0.NativeFieldInfoPtr_scenarioKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass21_0.NativeFieldInfoPtr_scenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000F63 RID: 3939
			private static readonly IntPtr NativeFieldInfoPtr_scenarioKey;

			// Token: 0x04000F64 RID: 3940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F65 RID: 3941
			private static readonly IntPtr NativeMethodInfoPtr__HasGameContainingScenarioKey_b__0_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x0200022C RID: 556
		[ObfuscatedName("lotus.SaveMetaDataProvider+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001974 RID: 6516 RVA: 0x0005FE30 File Offset: 0x0005E030
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr);
				SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr_svd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr, "svd");
				SaveMetaDataProvider.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr, 100664826);
				SaveMetaDataProvider.__c__DisplayClass27_0.NativeMethodInfoPtr__LoadDataFromMeta_b__0_Internal_IEnumerator_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr, 100664827);
			}

			// Token: 0x06001975 RID: 6517 RVA: 0x0005FEAC File Offset: 0x0005E0AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x0005FEE8 File Offset: 0x0005E0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992690, XrefRangeEnd = 992697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _LoadDataFromMeta_b__0(ErrorInfo error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider.__c__DisplayClass27_0.NativeMethodInfoPtr__LoadDataFromMeta_b__0_Internal_IEnumerator_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001977 RID: 6519 RVA: 0x0000DDD9 File Offset: 0x0000BFD9
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06001978 RID: 6520 RVA: 0x0005FF40 File Offset: 0x0005E140
			// (set) Token: 0x06001979 RID: 6521 RVA: 0x0000DDE2 File Offset: 0x0000BFE2
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x0600197A RID: 6522 RVA: 0x0005FF70 File Offset: 0x0005E170
			// (set) Token: 0x0600197B RID: 6523 RVA: 0x0000DE01 File Offset: 0x0000C001
			public unsafe SaveMetaData svd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr_svd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider.__c__DisplayClass27_0.NativeFieldInfoPtr_svd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F66 RID: 3942
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F67 RID: 3943
			private static readonly IntPtr NativeFieldInfoPtr_svd;

			// Token: 0x04000F68 RID: 3944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F69 RID: 3945
			private static readonly IntPtr NativeMethodInfoPtr__LoadDataFromMeta_b__0_Internal_IEnumerator_ErrorInfo_0;
		}

		// Token: 0x0200022D RID: 557
		[ObfuscatedName("lotus.SaveMetaDataProvider+<DeleteSave>d__22")]
		public sealed class _DeleteSave_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x0600197C RID: 6524 RVA: 0x0005FFA0 File Offset: 0x0005E1A0
			// Note: this type is marked as 'beforefieldinit'.
			static _DeleteSave_d__22()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<DeleteSave>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr);
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr_metaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "metaData");
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__saveFilePath_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "<saveFilePath>5__2");
				SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__command_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, "<command>5__3");
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664828);
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664829);
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664830);
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664831);
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664832);
				SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr, 100664833);
			}

			// Token: 0x0600197D RID: 6525 RVA: 0x000600BC File Offset: 0x0005E2BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeleteSave_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSave_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600197E RID: 6526 RVA: 0x00060104 File Offset: 0x0005E304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197F RID: 6527 RVA: 0x00060138 File Offset: 0x0005E338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992697, XrefRangeEnd = 992707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06001980 RID: 6528 RVA: 0x00060174 File Offset: 0x0005E374
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001981 RID: 6529 RVA: 0x000601B4 File Offset: 0x0005E3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992707, XrefRangeEnd = 992712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06001982 RID: 6530 RVA: 0x000601E8 File Offset: 0x0005E3E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSave_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001983 RID: 6531 RVA: 0x0000DE20 File Offset: 0x0000C020
			public _DeleteSave_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06001984 RID: 6532 RVA: 0x00060228 File Offset: 0x0005E428
			// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000DE29 File Offset: 0x0000C029
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06001986 RID: 6534 RVA: 0x00060250 File Offset: 0x0005E450
			// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000DE44 File Offset: 0x0000C044
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06001988 RID: 6536 RVA: 0x00060280 File Offset: 0x0005E480
			// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000DE63 File Offset: 0x0000C063
			public unsafe SaveMetaData metaData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr_metaData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr_metaData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x0600198A RID: 6538 RVA: 0x000602B0 File Offset: 0x0005E4B0
			// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000DE82 File Offset: 0x0000C082
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x0600198C RID: 6540 RVA: 0x000602E0 File Offset: 0x0005E4E0
			// (set) Token: 0x0600198D RID: 6541 RVA: 0x0000DEA1 File Offset: 0x0000C0A1
			public unsafe string _saveFilePath_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__saveFilePath_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__saveFilePath_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600198E RID: 6542 RVA: 0x00060308 File Offset: 0x0005E508
			// (set) Token: 0x0600198F RID: 6543 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
			public unsafe IDeleteDataCommand _command_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__command_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDeleteDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSave_d__22.NativeFieldInfoPtr__command_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F6A RID: 3946
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F6B RID: 3947
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F6C RID: 3948
			private static readonly IntPtr NativeFieldInfoPtr_metaData;

			// Token: 0x04000F6D RID: 3949
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F6E RID: 3950
			private static readonly IntPtr NativeFieldInfoPtr__saveFilePath_5__2;

			// Token: 0x04000F6F RID: 3951
			private static readonly IntPtr NativeFieldInfoPtr__command_5__3;

			// Token: 0x04000F70 RID: 3952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F71 RID: 3953
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F72 RID: 3954
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F73 RID: 3955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F74 RID: 3956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F75 RID: 3957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200022E RID: 558
		[ObfuscatedName("lotus.SaveMetaDataProvider+<DeleteSaveGame>d__28")]
		public sealed class _DeleteSaveGame_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06001990 RID: 6544 RVA: 0x00060338 File Offset: 0x0005E538
			// Note: this type is marked as 'beforefieldinit'.
			static _DeleteSaveGame_d__28()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<DeleteSaveGame>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, "saveData");
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664834);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664835);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664836);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664837);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664838);
				SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr, 100664839);
			}

			// Token: 0x06001991 RID: 6545 RVA: 0x0006042C File Offset: 0x0005E62C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeleteSaveGame_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001992 RID: 6546 RVA: 0x00060474 File Offset: 0x0005E674
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001993 RID: 6547 RVA: 0x000604A8 File Offset: 0x0005E6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992712, XrefRangeEnd = 992716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06001994 RID: 6548 RVA: 0x000604E4 File Offset: 0x0005E6E4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001995 RID: 6549 RVA: 0x00060524 File Offset: 0x0005E724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992716, XrefRangeEnd = 992721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06001996 RID: 6550 RVA: 0x00060558 File Offset: 0x0005E758
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001997 RID: 6551 RVA: 0x0000DEDF File Offset: 0x0000C0DF
			public _DeleteSaveGame_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06001998 RID: 6552 RVA: 0x00060598 File Offset: 0x0005E798
			// (set) Token: 0x06001999 RID: 6553 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x0600199A RID: 6554 RVA: 0x000605C0 File Offset: 0x0005E7C0
			// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000DF03 File Offset: 0x0000C103
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x0600199C RID: 6556 RVA: 0x000605F0 File Offset: 0x0005E7F0
			// (set) Token: 0x0600199D RID: 6557 RVA: 0x0000DF22 File Offset: 0x0000C122
			public unsafe SaveData saveData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr_saveData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x0600199E RID: 6558 RVA: 0x00060620 File Offset: 0x0005E820
			// (set) Token: 0x0600199F RID: 6559 RVA: 0x0000DF41 File Offset: 0x0000C141
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F76 RID: 3958
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F77 RID: 3959
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F78 RID: 3960
			private static readonly IntPtr NativeFieldInfoPtr_saveData;

			// Token: 0x04000F79 RID: 3961
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F7A RID: 3962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F7B RID: 3963
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F7C RID: 3964
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F7D RID: 3965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F7E RID: 3966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F7F RID: 3967
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200022F RID: 559
		[ObfuscatedName("lotus.SaveMetaDataProvider+<DeleteSaveGame>d__30")]
		public sealed class _DeleteSaveGame_d__30 : global::Il2CppSystem.Object
		{
			// Token: 0x060019A0 RID: 6560 RVA: 0x00060650 File Offset: 0x0005E850
			// Note: this type is marked as 'beforefieldinit'.
			static _DeleteSaveGame_d__30()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<DeleteSaveGame>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_saveGameFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "saveGameFileName");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "gameID");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr__deleteCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, "<deleteCommand>5__2");
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664840);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664841);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664842);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664843);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664844);
				SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr, 100664845);
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x0006076C File Offset: 0x0005E96C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeleteSaveGame_d__30(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._DeleteSaveGame_d__30>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x000607B4 File Offset: 0x0005E9B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x000607E8 File Offset: 0x0005E9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992721, XrefRangeEnd = 992730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00060824 File Offset: 0x0005EA24
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019A5 RID: 6565 RVA: 0x00060864 File Offset: 0x0005EA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992730, XrefRangeEnd = 992735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00060898 File Offset: 0x0005EA98
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x0000DF60 File Offset: 0x0000C160
			public _DeleteSaveGame_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x060019A8 RID: 6568 RVA: 0x000608D8 File Offset: 0x0005EAD8
			// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000DF69 File Offset: 0x0000C169
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x00060900 File Offset: 0x0005EB00
			// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000DF84 File Offset: 0x0000C184
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x060019AC RID: 6572 RVA: 0x00060930 File Offset: 0x0005EB30
			// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000DFA3 File Offset: 0x0000C1A3
			public unsafe string saveGameFileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_saveGameFileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_saveGameFileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x060019AE RID: 6574 RVA: 0x00060958 File Offset: 0x0005EB58
			// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000DFC2 File Offset: 0x0000C1C2
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00060988 File Offset: 0x0005EB88
			// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000DFE1 File Offset: 0x0000C1E1
			public unsafe GameID gameID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_gameID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000609B8 File Offset: 0x0005EBB8
			// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0000E000 File Offset: 0x0000C200
			public unsafe IDeleteDataCommand _deleteCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr__deleteCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDeleteDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._DeleteSaveGame_d__30.NativeFieldInfoPtr__deleteCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F80 RID: 3968
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F81 RID: 3969
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F82 RID: 3970
			private static readonly IntPtr NativeFieldInfoPtr_saveGameFileName;

			// Token: 0x04000F83 RID: 3971
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F84 RID: 3972
			private static readonly IntPtr NativeFieldInfoPtr_gameID;

			// Token: 0x04000F85 RID: 3973
			private static readonly IntPtr NativeFieldInfoPtr__deleteCommand_5__2;

			// Token: 0x04000F86 RID: 3974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F87 RID: 3975
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F88 RID: 3976
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F89 RID: 3977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F8A RID: 3978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F8B RID: 3979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000230 RID: 560
		[ObfuscatedName("lotus.SaveMetaDataProvider+<HandleLoadError>d__37")]
		public sealed class _HandleLoadError_d__37 : global::Il2CppSystem.Object
		{
			// Token: 0x060019B4 RID: 6580 RVA: 0x000609E8 File Offset: 0x0005EBE8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleLoadError_d__37()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<HandleLoadError>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_saveMetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, "saveMetaData");
				SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, "error");
				SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664846);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664847);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664848);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664849);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664850);
				SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr, 100664851);
			}

			// Token: 0x060019B5 RID: 6581 RVA: 0x00060AF0 File Offset: 0x0005ECF0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleLoadError_d__37(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._HandleLoadError_d__37>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B6 RID: 6582 RVA: 0x00060B38 File Offset: 0x0005ED38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B7 RID: 6583 RVA: 0x00060B6C File Offset: 0x0005ED6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992735, XrefRangeEnd = 992749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00060BA8 File Offset: 0x0005EDA8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019B9 RID: 6585 RVA: 0x00060BE8 File Offset: 0x0005EDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992749, XrefRangeEnd = 992754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060019BA RID: 6586 RVA: 0x00060C1C File Offset: 0x0005EE1C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._HandleLoadError_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x0000E01F File Offset: 0x0000C21F
			public _HandleLoadError_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x060019BC RID: 6588 RVA: 0x00060C5C File Offset: 0x0005EE5C
			// (set) Token: 0x060019BD RID: 6589 RVA: 0x0000E028 File Offset: 0x0000C228
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x060019BE RID: 6590 RVA: 0x00060C84 File Offset: 0x0005EE84
			// (set) Token: 0x060019BF RID: 6591 RVA: 0x0000E043 File Offset: 0x0000C243
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00060CB4 File Offset: 0x0005EEB4
			// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000E062 File Offset: 0x0000C262
			public unsafe SaveMetaData saveMetaData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_saveMetaData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_saveMetaData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00060CE4 File Offset: 0x0005EEE4
			// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000E081 File Offset: 0x0000C281
			public ErrorInfo error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_error);
					return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00060D14 File Offset: 0x0005EF14
			// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000E0AF File Offset: 0x0000C2AF
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._HandleLoadError_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F8C RID: 3980
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F8D RID: 3981
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F8E RID: 3982
			private static readonly IntPtr NativeFieldInfoPtr_saveMetaData;

			// Token: 0x04000F8F RID: 3983
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04000F90 RID: 3984
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F91 RID: 3985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F92 RID: 3986
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F93 RID: 3987
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F94 RID: 3988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F95 RID: 3989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F96 RID: 3990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000231 RID: 561
		[ObfuscatedName("lotus.SaveMetaDataProvider+<Init>d__15")]
		public sealed class _Init_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x060019C6 RID: 6598 RVA: 0x00060D44 File Offset: 0x0005EF44
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__15()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<Init>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr);
				SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__gameDataLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, "<gameDataLoad>5__2");
				SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__loadedGameData_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, "<loadedGameData>5__3");
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664852);
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664853);
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664854);
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664855);
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664856);
				SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr, 100664857);
			}

			// Token: 0x060019C7 RID: 6599 RVA: 0x00060E4C File Offset: 0x0005F04C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._Init_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019C8 RID: 6600 RVA: 0x00060E94 File Offset: 0x0005F094
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C9 RID: 6601 RVA: 0x00060EC8 File Offset: 0x0005F0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992754, XrefRangeEnd = 992833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x060019CA RID: 6602 RVA: 0x00060F04 File Offset: 0x0005F104
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019CB RID: 6603 RVA: 0x00060F44 File Offset: 0x0005F144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992833, XrefRangeEnd = 992838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x060019CC RID: 6604 RVA: 0x00060F78 File Offset: 0x0005F178
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._Init_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019CD RID: 6605 RVA: 0x0000E0CE File Offset: 0x0000C2CE
			public _Init_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x060019CE RID: 6606 RVA: 0x00060FB8 File Offset: 0x0005F1B8
			// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00060FE0 File Offset: 0x0005F1E0
			// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000E0F2 File Offset: 0x0000C2F2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00061010 File Offset: 0x0005F210
			// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0000E111 File Offset: 0x0000C311
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00061040 File Offset: 0x0005F240
			// (set) Token: 0x060019D5 RID: 6613 RVA: 0x0000E130 File Offset: 0x0000C330
			public unsafe ILoadDataCommand _gameDataLoad_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__gameDataLoad_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILoadDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__gameDataLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00061070 File Offset: 0x0005F270
			// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000E14F File Offset: 0x0000C34F
			public unsafe GameMetaData _loadedGameData_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__loadedGameData_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._Init_d__15.NativeFieldInfoPtr__loadedGameData_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F97 RID: 3991
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F98 RID: 3992
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F99 RID: 3993
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F9A RID: 3994
			private static readonly IntPtr NativeFieldInfoPtr__gameDataLoad_5__2;

			// Token: 0x04000F9B RID: 3995
			private static readonly IntPtr NativeFieldInfoPtr__loadedGameData_5__3;

			// Token: 0x04000F9C RID: 3996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F9D RID: 3997
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F9E RID: 3998
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F9F RID: 3999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FA0 RID: 4000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FA1 RID: 4001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000232 RID: 562
		[ObfuscatedName("lotus.SaveMetaDataProvider+<SaveGame>d__16")]
		public sealed class _SaveGame_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060019D8 RID: 6616 RVA: 0x000610A0 File Offset: 0x0005F2A0
			// Note: this type is marked as 'beforefieldinit'.
			static _SaveGame_d__16()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<SaveGame>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr);
				SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, "saveData");
				SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, "options");
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664858);
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664859);
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664860);
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664861);
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664862);
				SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr, 100664863);
			}

			// Token: 0x060019D9 RID: 6617 RVA: 0x000611A8 File Offset: 0x0005F3A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SaveGame_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGame_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019DA RID: 6618 RVA: 0x000611F0 File Offset: 0x0005F3F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019DB RID: 6619 RVA: 0x00061224 File Offset: 0x0005F424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992838, XrefRangeEnd = 992855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x060019DC RID: 6620 RVA: 0x00061260 File Offset: 0x0005F460
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019DD RID: 6621 RVA: 0x000612A0 File Offset: 0x0005F4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992855, XrefRangeEnd = 992860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x060019DE RID: 6622 RVA: 0x000612D4 File Offset: 0x0005F4D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019DF RID: 6623 RVA: 0x0000E16E File Offset: 0x0000C36E
			public _SaveGame_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00061314 File Offset: 0x0005F514
			// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000E177 File Offset: 0x0000C377
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0006133C File Offset: 0x0005F53C
			// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0000E192 File Offset: 0x0000C392
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0006136C File Offset: 0x0005F56C
			// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0000E1B1 File Offset: 0x0000C3B1
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0006139C File Offset: 0x0005F59C
			// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
			public unsafe SaveData saveData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_saveData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000613CC File Offset: 0x0005F5CC
			// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000E1EF File Offset: 0x0000C3EF
			public unsafe Dictionary<string, string> options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGame_d__16.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FA2 RID: 4002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FA3 RID: 4003
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FA4 RID: 4004
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FA5 RID: 4005
			private static readonly IntPtr NativeFieldInfoPtr_saveData;

			// Token: 0x04000FA6 RID: 4006
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04000FA7 RID: 4007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FA8 RID: 4008
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FA9 RID: 4009
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FAA RID: 4010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FAB RID: 4011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FAC RID: 4012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000233 RID: 563
		[ObfuscatedName("lotus.SaveMetaDataProvider+<SaveGameInternal>d__17")]
		public sealed class _SaveGameInternal_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x060019EA RID: 6634 RVA: 0x000613FC File Offset: 0x0005F5FC
			// Note: this type is marked as 'beforefieldinit'.
			static _SaveGameInternal_d__17()
			{
				Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveMetaDataProvider>.NativeClassPtr, "<SaveGameInternal>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, "<>1__state");
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, "<>2__current");
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, "<>4__this");
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__saveData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, "<saveData>5__2");
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__options_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, "<options>5__3");
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664864);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664865);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664866);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664867);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664868);
				SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr, 100664869);
			}

			// Token: 0x060019EB RID: 6635 RVA: 0x00061504 File Offset: 0x0005F704
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SaveGameInternal_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveMetaDataProvider._SaveGameInternal_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019EC RID: 6636 RVA: 0x0006154C File Offset: 0x0005F74C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019ED RID: 6637 RVA: 0x00061580 File Offset: 0x0005F780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992860, XrefRangeEnd = 992955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x060019EE RID: 6638 RVA: 0x000615BC File Offset: 0x0005F7BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019EF RID: 6639 RVA: 0x000615FC File Offset: 0x0005F7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992955, XrefRangeEnd = 992960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00061630 File Offset: 0x0005F830
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveMetaDataProvider._SaveGameInternal_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019F1 RID: 6641 RVA: 0x0000E20E File Offset: 0x0000C40E
			public _SaveGameInternal_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00061670 File Offset: 0x0005F870
			// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000E217 File Offset: 0x0000C417
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00061698 File Offset: 0x0005F898
			// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000E232 File Offset: 0x0000C432
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x060019F6 RID: 6646 RVA: 0x000616C8 File Offset: 0x0005F8C8
			// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000E251 File Offset: 0x0000C451
			public unsafe SaveMetaDataProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x060019F8 RID: 6648 RVA: 0x000616F8 File Offset: 0x0005F8F8
			// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000E270 File Offset: 0x0000C470
			public unsafe SaveData _saveData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__saveData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__saveData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x060019FA RID: 6650 RVA: 0x00061728 File Offset: 0x0005F928
			// (set) Token: 0x060019FB RID: 6651 RVA: 0x0000E28F File Offset: 0x0000C48F
			public unsafe Dictionary<string, string> _options_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__options_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveMetaDataProvider._SaveGameInternal_d__17.NativeFieldInfoPtr__options_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FAD RID: 4013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FAE RID: 4014
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FAF RID: 4015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FB0 RID: 4016
			private static readonly IntPtr NativeFieldInfoPtr__saveData_5__2;

			// Token: 0x04000FB1 RID: 4017
			private static readonly IntPtr NativeFieldInfoPtr__options_5__3;

			// Token: 0x04000FB2 RID: 4018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FB3 RID: 4019
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FB4 RID: 4020
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FB5 RID: 4021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FB6 RID: 4022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FB7 RID: 4023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
