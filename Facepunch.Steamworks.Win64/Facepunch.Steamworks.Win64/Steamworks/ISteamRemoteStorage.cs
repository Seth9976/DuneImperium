using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000029 RID: 41
	public class ISteamRemoteStorage : SteamInterface
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x00032A10 File Offset: 0x00030C10
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamRemoteStorage()
		{
			Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamRemoteStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr);
			ISteamRemoteStorage.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664705);
			ISteamRemoteStorage.NativeMethodInfoPtr_SteamAPI_SteamRemoteStorage_v016_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664706);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664707);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWrite_Private_Static_Boolean_IntPtr_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664708);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Internal_Boolean_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664709);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileRead_Private_Static_Int32_IntPtr_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664710);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileRead_Internal_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664711);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteAsync_Private_Static_SteamAPICall_t_IntPtr_String_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664712);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteAsync_Internal_CallResult_1_RemoteStorageFileWriteAsyncComplete_t_String_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664713);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileReadAsync_Private_Static_SteamAPICall_t_IntPtr_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664714);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileReadAsync_Internal_CallResult_1_RemoteStorageFileReadAsyncComplete_t_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664715);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileReadAsyncComplete_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664716);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileReadAsyncComplete_Internal_Boolean_SteamAPICall_t_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664717);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileForget_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664718);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileForget_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664719);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileDelete_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664720);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664721);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileShare_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664722);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileShare_Internal_CallResult_1_RemoteStorageFileShareResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664723);
			ISteamRemoteStorage.NativeMethodInfoPtr__SetSyncPlatforms_Private_Static_Boolean_IntPtr_String_RemoteStoragePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664724);
			ISteamRemoteStorage.NativeMethodInfoPtr_SetSyncPlatforms_Internal_Boolean_String_RemoteStoragePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664725);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamOpen_Private_Static_UGCFileWriteStreamHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664726);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamOpen_Internal_UGCFileWriteStreamHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664727);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamWriteChunk_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664728);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamWriteChunk_Internal_Boolean_UGCFileWriteStreamHandle_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664729);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamClose_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664730);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamClose_Internal_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664731);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamCancel_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664732);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamCancel_Internal_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664733);
			ISteamRemoteStorage.NativeMethodInfoPtr__FileExists_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664734);
			ISteamRemoteStorage.NativeMethodInfoPtr_FileExists_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664735);
			ISteamRemoteStorage.NativeMethodInfoPtr__FilePersisted_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664736);
			ISteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664737);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetFileSize_Private_Static_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664738);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetFileSize_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664739);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetFileTimestamp_Private_Static_Int64_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664740);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetFileTimestamp_Internal_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664741);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetSyncPlatforms_Private_Static_RemoteStoragePlatform_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664742);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetSyncPlatforms_Internal_RemoteStoragePlatform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664743);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetFileCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664744);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetFileCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664745);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetFileNameAndSize_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664746);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetFileNameAndSize_Internal_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664747);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetQuota_Private_Static_Boolean_IntPtr_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664748);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetQuota_Internal_Boolean_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664749);
			ISteamRemoteStorage.NativeMethodInfoPtr__IsCloudEnabledForAccount_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664750);
			ISteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForAccount_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664751);
			ISteamRemoteStorage.NativeMethodInfoPtr__IsCloudEnabledForApp_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664752);
			ISteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForApp_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664753);
			ISteamRemoteStorage.NativeMethodInfoPtr__SetCloudEnabledForApp_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664754);
			ISteamRemoteStorage.NativeMethodInfoPtr_SetCloudEnabledForApp_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664755);
			ISteamRemoteStorage.NativeMethodInfoPtr__UGCDownload_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664756);
			ISteamRemoteStorage.NativeMethodInfoPtr_UGCDownload_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664757);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetUGCDownloadProgress_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664758);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetUGCDownloadProgress_Internal_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664759);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetUGCDetails_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664760);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetUGCDetails_Internal_Boolean_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664761);
			ISteamRemoteStorage.NativeMethodInfoPtr__UGCRead_Private_Static_Int32_IntPtr_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664762);
			ISteamRemoteStorage.NativeMethodInfoPtr_UGCRead_Internal_Int32_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664763);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetCachedUGCCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664764);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664765);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetCachedUGCHandle_Private_Static_UGCHandle_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664766);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCHandle_Internal_UGCHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664767);
			ISteamRemoteStorage.NativeMethodInfoPtr__UGCDownloadToLocation_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664768);
			ISteamRemoteStorage.NativeMethodInfoPtr_UGCDownloadToLocation_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664769);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetLocalFileChangeCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664770);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetLocalFileChangeCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664771);
			ISteamRemoteStorage.NativeMethodInfoPtr__GetLocalFileChange_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664772);
			ISteamRemoteStorage.NativeMethodInfoPtr_GetLocalFileChange_Internal_String_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664773);
			ISteamRemoteStorage.NativeMethodInfoPtr__BeginFileWriteBatch_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664774);
			ISteamRemoteStorage.NativeMethodInfoPtr_BeginFileWriteBatch_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664775);
			ISteamRemoteStorage.NativeMethodInfoPtr__EndFileWriteBatch_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664776);
			ISteamRemoteStorage.NativeMethodInfoPtr_EndFileWriteBatch_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr, 100664777);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00032FF4 File Offset: 0x000311F4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamRemoteStorage(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamRemoteStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0003303C File Offset: 0x0003123C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934849, XrefRangeEnd = 934851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamRemoteStorage_v016()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_SteamAPI_SteamRemoteStorage_v016_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0003306C File Offset: 0x0003126C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamRemoteStorage.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000330B4 File Offset: 0x000312B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934851, XrefRangeEnd = 934854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileWrite(IntPtr self, string pchFile, IntPtr pvData, int cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWrite_Private_Static_Boolean_IntPtr_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00033120 File Offset: 0x00031320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934857, RefRangeEnd = 934858, XrefRangeStart = 934854, XrefRangeEnd = 934857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileWrite(string pchFile, IntPtr pvData, int cubData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Internal_Boolean_String_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0003318C File Offset: 0x0003138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934858, XrefRangeEnd = 934861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _FileRead(IntPtr self, string pchFile, IntPtr pvData, int cubDataToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileRead_Private_Static_Int32_IntPtr_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000331F8 File Offset: 0x000313F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934864, RefRangeEnd = 934865, XrefRangeStart = 934861, XrefRangeEnd = 934864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FileRead(string pchFile, IntPtr pvData, int cubDataToRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileRead_Internal_Int32_String_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00033264 File Offset: 0x00031464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934865, XrefRangeEnd = 934868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _FileWriteAsync(IntPtr self, string pchFile, IntPtr pvData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteAsync_Private_Static_SteamAPICall_t_IntPtr_String_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000332D0 File Offset: 0x000314D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934868, XrefRangeEnd = 934874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<RemoteStorageFileWriteAsyncComplete_t> FileWriteAsync(string pchFile, IntPtr pvData, uint cubData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteAsync_Internal_CallResult_1_RemoteStorageFileWriteAsyncComplete_t_String_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<RemoteStorageFileWriteAsyncComplete_t>(intPtr);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00033334 File Offset: 0x00031534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934874, XrefRangeEnd = 934877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _FileReadAsync(IntPtr self, string pchFile, uint nOffset, uint cubToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileReadAsync_Private_Static_SteamAPICall_t_IntPtr_String_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000333A0 File Offset: 0x000315A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934877, XrefRangeEnd = 934883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<RemoteStorageFileReadAsyncComplete_t> FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileReadAsync_Internal_CallResult_1_RemoteStorageFileReadAsyncComplete_t_String_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<RemoteStorageFileReadAsyncComplete_t>(intPtr);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00033404 File Offset: 0x00031604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934883, XrefRangeEnd = 934885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileReadAsyncComplete(IntPtr self, SteamAPICall_t hReadCall, IntPtr pvBuffer, uint cubToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hReadCall;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileReadAsyncComplete_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0003346C File Offset: 0x0003166C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934885, XrefRangeEnd = 934887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileReadAsyncComplete(SteamAPICall_t hReadCall, IntPtr pvBuffer, uint cubToRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hReadCall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileReadAsyncComplete_Internal_Boolean_SteamAPICall_t_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000334D4 File Offset: 0x000316D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934887, XrefRangeEnd = 934890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileForget(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileForget_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00033524 File Offset: 0x00031724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934893, RefRangeEnd = 934894, XrefRangeStart = 934890, XrefRangeEnd = 934893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileForget(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileForget_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00033574 File Offset: 0x00031774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934894, XrefRangeEnd = 934897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileDelete(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileDelete_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000335C4 File Offset: 0x000317C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934900, RefRangeEnd = 934901, XrefRangeStart = 934897, XrefRangeEnd = 934900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileDelete(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00033614 File Offset: 0x00031814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934901, XrefRangeEnd = 934904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _FileShare(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileShare_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00033664 File Offset: 0x00031864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934904, XrefRangeEnd = 934910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<RemoteStorageFileShareResult_t> FileShare(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileShare_Internal_CallResult_1_RemoteStorageFileShareResult_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<RemoteStorageFileShareResult_t>(intPtr);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000336AC File Offset: 0x000318AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934910, XrefRangeEnd = 934913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetSyncPlatforms(IntPtr self, string pchFile, RemoteStoragePlatform eRemoteStoragePlatform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eRemoteStoragePlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__SetSyncPlatforms_Private_Static_Boolean_IntPtr_String_RemoteStoragePlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0003370C File Offset: 0x0003190C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934913, XrefRangeEnd = 934916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetSyncPlatforms(string pchFile, RemoteStoragePlatform eRemoteStoragePlatform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eRemoteStoragePlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_SetSyncPlatforms_Internal_Boolean_String_RemoteStoragePlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00033768 File Offset: 0x00031968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934916, XrefRangeEnd = 934919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCFileWriteStreamHandle_t _FileWriteStreamOpen(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamOpen_Private_Static_UGCFileWriteStreamHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000337B8 File Offset: 0x000319B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934919, XrefRangeEnd = 934922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamOpen_Internal_UGCFileWriteStreamHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00033808 File Offset: 0x00031A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934922, XrefRangeEnd = 934924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileWriteStreamWriteChunk(IntPtr self, UGCFileWriteStreamHandle_t writeHandle, IntPtr pvData, int cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamWriteChunk_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00033870 File Offset: 0x00031A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934924, XrefRangeEnd = 934926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, IntPtr pvData, int cubData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamWriteChunk_Internal_Boolean_UGCFileWriteStreamHandle_t_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000338D8 File Offset: 0x00031AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934926, XrefRangeEnd = 934928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileWriteStreamClose(IntPtr self, UGCFileWriteStreamHandle_t writeHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamClose_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00033924 File Offset: 0x00031B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934928, XrefRangeEnd = 934930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamClose_Internal_Boolean_UGCFileWriteStreamHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00033970 File Offset: 0x00031B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934930, XrefRangeEnd = 934932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileWriteStreamCancel(IntPtr self, UGCFileWriteStreamHandle_t writeHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileWriteStreamCancel_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000339BC File Offset: 0x00031BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934932, XrefRangeEnd = 934934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamCancel_Internal_Boolean_UGCFileWriteStreamHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00033A08 File Offset: 0x00031C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934934, XrefRangeEnd = 934937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FileExists(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FileExists_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00033A58 File Offset: 0x00031C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934940, RefRangeEnd = 934941, XrefRangeStart = 934937, XrefRangeEnd = 934940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileExists(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FileExists_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00033AA8 File Offset: 0x00031CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934941, XrefRangeEnd = 934944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _FilePersisted(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__FilePersisted_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00033AF8 File Offset: 0x00031CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934947, RefRangeEnd = 934948, XrefRangeStart = 934944, XrefRangeEnd = 934947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FilePersisted(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00033B48 File Offset: 0x00031D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934948, XrefRangeEnd = 934951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFileSize(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetFileSize_Private_Static_Int32_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00033B98 File Offset: 0x00031D98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934954, RefRangeEnd = 934956, XrefRangeStart = 934951, XrefRangeEnd = 934954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFileSize(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetFileSize_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00033BE8 File Offset: 0x00031DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934956, XrefRangeEnd = 934959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long _GetFileTimestamp(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetFileTimestamp_Private_Static_Int64_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00033C38 File Offset: 0x00031E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934962, RefRangeEnd = 934963, XrefRangeStart = 934959, XrefRangeEnd = 934962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetFileTimestamp(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetFileTimestamp_Internal_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00033C88 File Offset: 0x00031E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934963, XrefRangeEnd = 934966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemoteStoragePlatform _GetSyncPlatforms(IntPtr self, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetSyncPlatforms_Private_Static_RemoteStoragePlatform_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00033CD8 File Offset: 0x00031ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934966, XrefRangeEnd = 934969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetSyncPlatforms_Internal_RemoteStoragePlatform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00033D28 File Offset: 0x00031F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934969, XrefRangeEnd = 934971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetFileCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetFileCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00033D68 File Offset: 0x00031F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934973, RefRangeEnd = 934975, XrefRangeStart = 934971, XrefRangeEnd = 934973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFileCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetFileCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00033DA4 File Offset: 0x00031FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934975, XrefRangeEnd = 934977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetFileNameAndSize(IntPtr self, int iFile, ref int pnFileSizeInBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFile;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetFileNameAndSize_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00033E00 File Offset: 0x00032000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934980, RefRangeEnd = 934981, XrefRangeStart = 934977, XrefRangeEnd = 934980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFileNameAndSize(int iFile, ref int pnFileSizeInBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFile;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetFileNameAndSize_Internal_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00033E54 File Offset: 0x00032054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934981, XrefRangeEnd = 934983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetQuota(IntPtr self, ref ulong pnTotalBytes, ref ulong puAvailableBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnTotalBytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &puAvailableBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetQuota_Private_Static_Boolean_IntPtr_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00033EB0 File Offset: 0x000320B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 934985, RefRangeEnd = 934988, XrefRangeStart = 934983, XrefRangeEnd = 934985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetQuota(ref ulong pnTotalBytes, ref ulong puAvailableBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pnTotalBytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &puAvailableBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetQuota_Internal_Boolean_byref_UInt64_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00033F08 File Offset: 0x00032108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934988, XrefRangeEnd = 934990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsCloudEnabledForAccount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__IsCloudEnabledForAccount_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00033F48 File Offset: 0x00032148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 934992, RefRangeEnd = 934994, XrefRangeStart = 934990, XrefRangeEnd = 934992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCloudEnabledForAccount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForAccount_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00033F84 File Offset: 0x00032184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934994, XrefRangeEnd = 934996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsCloudEnabledForApp(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__IsCloudEnabledForApp_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00033FC4 File Offset: 0x000321C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934998, RefRangeEnd = 934999, XrefRangeStart = 934996, XrefRangeEnd = 934998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCloudEnabledForApp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForApp_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00034000 File Offset: 0x00032200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934999, XrefRangeEnd = 935001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetCloudEnabledForApp(IntPtr self, bool bEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__SetCloudEnabledForApp_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00034040 File Offset: 0x00032240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935003, RefRangeEnd = 935004, XrefRangeStart = 935001, XrefRangeEnd = 935003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCloudEnabledForApp(bool bEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_SetCloudEnabledForApp_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00034080 File Offset: 0x00032280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935004, XrefRangeEnd = 935006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _UGCDownload(IntPtr self, UGCHandle_t hContent, uint unPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hContent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__UGCDownload_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000340DC File Offset: 0x000322DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935006, XrefRangeEnd = 935011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<RemoteStorageDownloadUGCResult_t> UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_UGCDownload_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<RemoteStorageDownloadUGCResult_t>(intPtr);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00034130 File Offset: 0x00032330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935011, XrefRangeEnd = 935013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUGCDownloadProgress(IntPtr self, UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hContent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetUGCDownloadProgress_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00034198 File Offset: 0x00032398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935013, XrefRangeEnd = 935015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUGCDownloadProgress(UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetUGCDownloadProgress_Internal_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00034200 File Offset: 0x00032400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935015, XrefRangeEnd = 935022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUGCDetails(IntPtr self, UGCHandle_t hContent, ref AppId pnAppID, [In] [Out] ref Il2CppStructArray<char> ppchName, ref int pnFileSizeInBytes, ref SteamId pSteamIDOwner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hContent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDOwner;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetUGCDetails_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchName = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0003429C File Offset: 0x0003249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935022, XrefRangeEnd = 935029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUGCDetails(UGCHandle_t hContent, ref AppId pnAppID, [In] [Out] ref Il2CppStructArray<char> ppchName, ref int pnFileSizeInBytes, ref SteamId pSteamIDOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDOwner;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetUGCDetails_Internal_Boolean_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ppchName = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00034334 File Offset: 0x00032534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935029, XrefRangeEnd = 935031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _UGCRead(IntPtr self, UGCHandle_t hContent, IntPtr pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hContent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__UGCRead_Private_Static_Int32_IntPtr_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000343B8 File Offset: 0x000325B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935031, XrefRangeEnd = 935033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UGCRead(UGCHandle_t hContent, IntPtr pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_UGCRead_Internal_Int32_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0003443C File Offset: 0x0003263C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935033, XrefRangeEnd = 935035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetCachedUGCCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetCachedUGCCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0003447C File Offset: 0x0003267C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935035, XrefRangeEnd = 935037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCachedUGCCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000344B8 File Offset: 0x000326B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935037, XrefRangeEnd = 935039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCHandle_t _GetCachedUGCHandle(IntPtr self, int iCachedContent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iCachedContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetCachedUGCHandle_Private_Static_UGCHandle_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00034504 File Offset: 0x00032704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935039, XrefRangeEnd = 935041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCachedContent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCHandle_Internal_UGCHandle_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00034550 File Offset: 0x00032750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935041, XrefRangeEnd = 935044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _UGCDownloadToLocation(IntPtr self, UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hContent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__UGCDownloadToLocation_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000345BC File Offset: 0x000327BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935044, XrefRangeEnd = 935050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<RemoteStorageDownloadUGCResult_t> UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_UGCDownloadToLocation_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<RemoteStorageDownloadUGCResult_t>(intPtr);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00034620 File Offset: 0x00032820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935050, XrefRangeEnd = 935052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLocalFileChangeCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetLocalFileChangeCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00034660 File Offset: 0x00032860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935052, XrefRangeEnd = 935054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLocalFileChangeCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetLocalFileChangeCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0003469C File Offset: 0x0003289C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935054, XrefRangeEnd = 935056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetLocalFileChange(IntPtr self, int iFile, ref RemoteStorageLocalFileChange pEChangeType, ref RemoteStorageFilePathType pEFilePathType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFile;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pEChangeType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pEFilePathType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__GetLocalFileChange_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00034704 File Offset: 0x00032904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935056, XrefRangeEnd = 935059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalFileChange(int iFile, ref RemoteStorageLocalFileChange pEChangeType, ref RemoteStorageFilePathType pEFilePathType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFile;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pEChangeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pEFilePathType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_GetLocalFileChange_Internal_String_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00034764 File Offset: 0x00032964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935059, XrefRangeEnd = 935061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BeginFileWriteBatch(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__BeginFileWriteBatch_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000347A4 File Offset: 0x000329A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935061, XrefRangeEnd = 935063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BeginFileWriteBatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_BeginFileWriteBatch_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000347E0 File Offset: 0x000329E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935063, XrefRangeEnd = 935065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _EndFileWriteBatch(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr__EndFileWriteBatch_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00034820 File Offset: 0x00032A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935065, XrefRangeEnd = 935067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndFileWriteBatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamRemoteStorage.NativeMethodInfoPtr_EndFileWriteBatch_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000023CF File Offset: 0x000005CF
		public ISteamRemoteStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamRemoteStorage_v016_Internal_Static_IntPtr_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr__FileWrite_Private_Static_Boolean_IntPtr_String_IntPtr_Int32_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_FileWrite_Internal_Boolean_String_IntPtr_Int32_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr__FileRead_Private_Static_Int32_IntPtr_String_IntPtr_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_FileRead_Internal_Int32_String_IntPtr_Int32_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr__FileWriteAsync_Private_Static_SteamAPICall_t_IntPtr_String_IntPtr_UInt32_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteAsync_Internal_CallResult_1_RemoteStorageFileWriteAsyncComplete_t_String_IntPtr_UInt32_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr__FileReadAsync_Private_Static_SteamAPICall_t_IntPtr_String_UInt32_UInt32_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_FileReadAsync_Internal_CallResult_1_RemoteStorageFileReadAsyncComplete_t_String_UInt32_UInt32_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr__FileReadAsyncComplete_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_UInt32_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_FileReadAsyncComplete_Internal_Boolean_SteamAPICall_t_IntPtr_UInt32_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr__FileForget_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_FileForget_Internal_Boolean_String_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr__FileDelete_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_FileDelete_Internal_Boolean_String_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr__FileShare_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_FileShare_Internal_CallResult_1_RemoteStorageFileShareResult_t_String_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr__SetSyncPlatforms_Private_Static_Boolean_IntPtr_String_RemoteStoragePlatform_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_SetSyncPlatforms_Internal_Boolean_String_RemoteStoragePlatform_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr__FileWriteStreamOpen_Private_Static_UGCFileWriteStreamHandle_t_IntPtr_String_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamOpen_Internal_UGCFileWriteStreamHandle_t_String_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr__FileWriteStreamWriteChunk_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_IntPtr_Int32_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamWriteChunk_Internal_Boolean_UGCFileWriteStreamHandle_t_IntPtr_Int32_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr__FileWriteStreamClose_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamClose_Internal_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr__FileWriteStreamCancel_Private_Static_Boolean_IntPtr_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamCancel_Internal_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr__FileExists_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_FileExists_Internal_Boolean_String_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr__FilePersisted_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_FilePersisted_Internal_Boolean_String_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr__GetFileSize_Private_Static_Int32_IntPtr_String_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_GetFileSize_Internal_Int32_String_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr__GetFileTimestamp_Private_Static_Int64_IntPtr_String_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_GetFileTimestamp_Internal_Int64_String_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr__GetSyncPlatforms_Private_Static_RemoteStoragePlatform_IntPtr_String_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_GetSyncPlatforms_Internal_RemoteStoragePlatform_String_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr__GetFileCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_GetFileCount_Internal_Int32_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr__GetFileNameAndSize_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_Int32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_GetFileNameAndSize_Internal_String_Int32_byref_Int32_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr__GetQuota_Private_Static_Boolean_IntPtr_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_GetQuota_Internal_Boolean_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr__IsCloudEnabledForAccount_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudEnabledForAccount_Internal_Boolean_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr__IsCloudEnabledForApp_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudEnabledForApp_Internal_Boolean_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr__SetCloudEnabledForApp_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_SetCloudEnabledForApp_Internal_Void_Boolean_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr__UGCDownload_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_UInt32_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_UGCDownload_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_UInt32_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr__GetUGCDownloadProgress_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_GetUGCDownloadProgress_Internal_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr__GetUGCDetails_Private_Static_Boolean_IntPtr_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_GetUGCDetails_Internal_Boolean_UGCHandle_t_byref_AppId_byref_Il2CppStructArray_1_Char_byref_Int32_byref_SteamId_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr__UGCRead_Private_Static_Int32_IntPtr_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_UGCRead_Internal_Int32_UGCHandle_t_IntPtr_Int32_UInt32_UGCReadAction_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr__GetCachedUGCCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedUGCCount_Internal_Int32_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr__GetCachedUGCHandle_Private_Static_UGCHandle_t_IntPtr_Int32_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedUGCHandle_Internal_UGCHandle_t_Int32_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr__UGCDownloadToLocation_Private_Static_SteamAPICall_t_IntPtr_UGCHandle_t_String_UInt32_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_UGCDownloadToLocation_Internal_CallResult_1_RemoteStorageDownloadUGCResult_t_UGCHandle_t_String_UInt32_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr__GetLocalFileChangeCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalFileChangeCount_Internal_Int32_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr__GetLocalFileChange_Private_Static_Utf8StringPointer_IntPtr_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalFileChange_Internal_String_Int32_byref_RemoteStorageLocalFileChange_byref_RemoteStorageFilePathType_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr__BeginFileWriteBatch_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_BeginFileWriteBatch_Internal_Boolean_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr__EndFileWriteBatch_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_EndFileWriteBatch_Internal_Boolean_0;
	}
}
