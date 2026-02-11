using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200000E RID: 14
	public class ISteamApps : SteamInterface
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000FFE8 File Offset: 0x0000E1E8
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamApps()
		{
			Il2CppClassPointerStore<ISteamApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamApps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr);
			ISteamApps.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663376);
			ISteamApps.NativeMethodInfoPtr_SteamAPI_SteamApps_v008_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663377);
			ISteamApps.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663378);
			ISteamApps.NativeMethodInfoPtr__BIsSubscribed_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663379);
			ISteamApps.NativeMethodInfoPtr_BIsSubscribed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663380);
			ISteamApps.NativeMethodInfoPtr__BIsLowViolence_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663381);
			ISteamApps.NativeMethodInfoPtr_BIsLowViolence_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663382);
			ISteamApps.NativeMethodInfoPtr__BIsCybercafe_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663383);
			ISteamApps.NativeMethodInfoPtr_BIsCybercafe_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663384);
			ISteamApps.NativeMethodInfoPtr__BIsVACBanned_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663385);
			ISteamApps.NativeMethodInfoPtr_BIsVACBanned_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663386);
			ISteamApps.NativeMethodInfoPtr__GetCurrentGameLanguage_Private_Static_Utf8StringPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663387);
			ISteamApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663388);
			ISteamApps.NativeMethodInfoPtr__GetAvailableGameLanguages_Private_Static_Utf8StringPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663389);
			ISteamApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663390);
			ISteamApps.NativeMethodInfoPtr__BIsSubscribedApp_Private_Static_Boolean_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663391);
			ISteamApps.NativeMethodInfoPtr_BIsSubscribedApp_Internal_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663392);
			ISteamApps.NativeMethodInfoPtr__BIsDlcInstalled_Private_Static_Boolean_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663393);
			ISteamApps.NativeMethodInfoPtr_BIsDlcInstalled_Internal_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663394);
			ISteamApps.NativeMethodInfoPtr__GetEarliestPurchaseUnixTime_Private_Static_UInt32_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663395);
			ISteamApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Internal_UInt32_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663396);
			ISteamApps.NativeMethodInfoPtr__BIsSubscribedFromFreeWeekend_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663397);
			ISteamApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663398);
			ISteamApps.NativeMethodInfoPtr__GetDLCCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663399);
			ISteamApps.NativeMethodInfoPtr_GetDLCCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663400);
			ISteamApps.NativeMethodInfoPtr__BGetDLCDataByIndex_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663401);
			ISteamApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Internal_Boolean_Int32_byref_AppId_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663402);
			ISteamApps.NativeMethodInfoPtr__InstallDLC_Private_Static_Void_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663403);
			ISteamApps.NativeMethodInfoPtr_InstallDLC_Internal_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663404);
			ISteamApps.NativeMethodInfoPtr__UninstallDLC_Private_Static_Void_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663405);
			ISteamApps.NativeMethodInfoPtr_UninstallDLC_Internal_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663406);
			ISteamApps.NativeMethodInfoPtr__RequestAppProofOfPurchaseKey_Private_Static_Void_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663407);
			ISteamApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Internal_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663408);
			ISteamApps.NativeMethodInfoPtr__GetCurrentBetaName_Private_Static_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663409);
			ISteamApps.NativeMethodInfoPtr_GetCurrentBetaName_Internal_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663410);
			ISteamApps.NativeMethodInfoPtr__MarkContentCorrupt_Private_Static_Boolean_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663411);
			ISteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663412);
			ISteamApps.NativeMethodInfoPtr__GetInstalledDepots_Private_Static_UInt32_IntPtr_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663413);
			ISteamApps.NativeMethodInfoPtr_GetInstalledDepots_Internal_UInt32_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663414);
			ISteamApps.NativeMethodInfoPtr__GetAppInstallDir_Private_Static_UInt32_IntPtr_AppId_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663415);
			ISteamApps.NativeMethodInfoPtr_GetAppInstallDir_Internal_UInt32_AppId_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663416);
			ISteamApps.NativeMethodInfoPtr__BIsAppInstalled_Private_Static_Boolean_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663417);
			ISteamApps.NativeMethodInfoPtr_BIsAppInstalled_Internal_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663418);
			ISteamApps.NativeMethodInfoPtr__GetAppOwner_Private_Static_SteamId_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663419);
			ISteamApps.NativeMethodInfoPtr_GetAppOwner_Internal_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663420);
			ISteamApps.NativeMethodInfoPtr__GetLaunchQueryParam_Private_Static_Utf8StringPointer_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663421);
			ISteamApps.NativeMethodInfoPtr_GetLaunchQueryParam_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663422);
			ISteamApps.NativeMethodInfoPtr__GetDlcDownloadProgress_Private_Static_Boolean_IntPtr_AppId_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663423);
			ISteamApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Internal_Boolean_AppId_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663424);
			ISteamApps.NativeMethodInfoPtr__GetAppBuildId_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663425);
			ISteamApps.NativeMethodInfoPtr_GetAppBuildId_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663426);
			ISteamApps.NativeMethodInfoPtr__RequestAllProofOfPurchaseKeys_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663427);
			ISteamApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663428);
			ISteamApps.NativeMethodInfoPtr__GetFileDetails_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663429);
			ISteamApps.NativeMethodInfoPtr_GetFileDetails_Internal_CallResult_1_FileDetailsResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663430);
			ISteamApps.NativeMethodInfoPtr__GetLaunchCommandLine_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663431);
			ISteamApps.NativeMethodInfoPtr_GetLaunchCommandLine_Internal_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663432);
			ISteamApps.NativeMethodInfoPtr__BIsSubscribedFromFamilySharing_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663433);
			ISteamApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663434);
			ISteamApps.NativeMethodInfoPtr__BIsTimedTrial_Private_Static_Boolean_IntPtr_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663435);
			ISteamApps.NativeMethodInfoPtr_BIsTimedTrial_Internal_Boolean_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr, 100663436);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000104DC File Offset: 0x0000E6DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamApps(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamApps>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00010524 File Offset: 0x0000E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931028, XrefRangeEnd = 931030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamApps_v008()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_SteamAPI_SteamApps_v008_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00010554 File Offset: 0x0000E754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamApps.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0001059C File Offset: 0x0000E79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931030, XrefRangeEnd = 931032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsSubscribed(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsSubscribed_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000105DC File Offset: 0x0000E7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931034, RefRangeEnd = 931035, XrefRangeStart = 931032, XrefRangeEnd = 931034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsSubscribed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsSubscribed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00010618 File Offset: 0x0000E818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931035, XrefRangeEnd = 931037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsLowViolence(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsLowViolence_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00010658 File Offset: 0x0000E858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931039, RefRangeEnd = 931040, XrefRangeStart = 931037, XrefRangeEnd = 931039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsLowViolence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsLowViolence_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00010694 File Offset: 0x0000E894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931040, XrefRangeEnd = 931042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsCybercafe(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsCybercafe_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000106D4 File Offset: 0x0000E8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931044, RefRangeEnd = 931045, XrefRangeStart = 931042, XrefRangeEnd = 931044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsCybercafe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsCybercafe_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00010710 File Offset: 0x0000E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931045, XrefRangeEnd = 931047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsVACBanned(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsVACBanned_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00010750 File Offset: 0x0000E950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931049, RefRangeEnd = 931050, XrefRangeStart = 931047, XrefRangeEnd = 931049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsVACBanned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsVACBanned_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0001078C File Offset: 0x0000E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931050, XrefRangeEnd = 931052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetCurrentGameLanguage(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetCurrentGameLanguage_Private_Static_Utf8StringPointer_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000107CC File Offset: 0x0000E9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931055, RefRangeEnd = 931056, XrefRangeStart = 931052, XrefRangeEnd = 931055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCurrentGameLanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00010804 File Offset: 0x0000EA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931056, XrefRangeEnd = 931058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetAvailableGameLanguages(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetAvailableGameLanguages_Private_Static_Utf8StringPointer_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00010844 File Offset: 0x0000EA44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931061, RefRangeEnd = 931062, XrefRangeStart = 931058, XrefRangeEnd = 931061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAvailableGameLanguages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0001087C File Offset: 0x0000EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931062, XrefRangeEnd = 931064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsSubscribedApp(IntPtr self, AppId appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsSubscribedApp_Private_Static_Boolean_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000108C8 File Offset: 0x0000EAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931066, RefRangeEnd = 931067, XrefRangeStart = 931064, XrefRangeEnd = 931066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsSubscribedApp(AppId appID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsSubscribedApp_Internal_Boolean_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00010914 File Offset: 0x0000EB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931067, XrefRangeEnd = 931069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsDlcInstalled(IntPtr self, AppId appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsDlcInstalled_Private_Static_Boolean_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00010960 File Offset: 0x0000EB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931071, RefRangeEnd = 931072, XrefRangeStart = 931069, XrefRangeEnd = 931071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsDlcInstalled(AppId appID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsDlcInstalled_Internal_Boolean_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000109AC File Offset: 0x0000EBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931072, XrefRangeEnd = 931074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetEarliestPurchaseUnixTime(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetEarliestPurchaseUnixTime_Private_Static_UInt32_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931076, RefRangeEnd = 931077, XrefRangeStart = 931074, XrefRangeEnd = 931076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetEarliestPurchaseUnixTime(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Internal_UInt32_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00010A44 File Offset: 0x0000EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931077, XrefRangeEnd = 931079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsSubscribedFromFreeWeekend(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsSubscribedFromFreeWeekend_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00010A84 File Offset: 0x0000EC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931081, RefRangeEnd = 931082, XrefRangeStart = 931079, XrefRangeEnd = 931081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsSubscribedFromFreeWeekend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931082, XrefRangeEnd = 931084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetDLCCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetDLCCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00010B00 File Offset: 0x0000ED00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931086, RefRangeEnd = 931087, XrefRangeStart = 931084, XrefRangeEnd = 931086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDLCCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetDLCCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00010B3C File Offset: 0x0000ED3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931087, XrefRangeEnd = 931089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BGetDLCDataByIndex(IntPtr self, int iDLC, ref AppId pAppID, ref bool pbAvailable, IntPtr pchName, int cchNameBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iDLC;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pAppID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAvailable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BGetDLCDataByIndex_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_Boolean_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931111, RefRangeEnd = 931112, XrefRangeStart = 931089, XrefRangeEnd = 931111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BGetDLCDataByIndex(int iDLC, ref AppId pAppID, ref bool pbAvailable, out string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDLC;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAvailable;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Internal_Boolean_Int32_byref_AppId_byref_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00010C44 File Offset: 0x0000EE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931112, XrefRangeEnd = 931114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _InstallDLC(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__InstallDLC_Private_Static_Void_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00010C84 File Offset: 0x0000EE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931116, RefRangeEnd = 931117, XrefRangeStart = 931114, XrefRangeEnd = 931116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallDLC(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_InstallDLC_Internal_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931117, XrefRangeEnd = 931119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _UninstallDLC(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__UninstallDLC_Private_Static_Void_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00010D04 File Offset: 0x0000EF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931121, RefRangeEnd = 931122, XrefRangeStart = 931119, XrefRangeEnd = 931121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UninstallDLC(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_UninstallDLC_Internal_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00010D44 File Offset: 0x0000EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931122, XrefRangeEnd = 931124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RequestAppProofOfPurchaseKey(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__RequestAppProofOfPurchaseKey_Private_Static_Void_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00010D84 File Offset: 0x0000EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931124, XrefRangeEnd = 931126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAppProofOfPurchaseKey(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Internal_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931126, XrefRangeEnd = 931128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetCurrentBetaName_Private_Static_Boolean_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00010E20 File Offset: 0x0000F020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931150, RefRangeEnd = 931151, XrefRangeStart = 931128, XrefRangeEnd = 931150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCurrentBetaName(out string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetCurrentBetaName_Internal_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				pchName = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00010E78 File Offset: 0x0000F078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931151, XrefRangeEnd = 931153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _MarkContentCorrupt(IntPtr self, bool bMissingFilesOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bMissingFilesOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__MarkContentCorrupt_Private_Static_Boolean_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931155, RefRangeEnd = 931156, XrefRangeStart = 931153, XrefRangeEnd = 931155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bMissingFilesOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00010F10 File Offset: 0x0000F110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931156, XrefRangeEnd = 931158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetInstalledDepots(IntPtr self, AppId appID, [In] [Out] Il2CppStructArray<DepotId_t> pvecDepots, uint cMaxDepots)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxDepots;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetInstalledDepots_Private_Static_UInt32_IntPtr_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pvecDepots = ((intPtr4 == 0) ? null : new Il2CppStructArray<DepotId_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00010F8C File Offset: 0x0000F18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931160, RefRangeEnd = 931161, XrefRangeStart = 931158, XrefRangeEnd = 931160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetInstalledDepots(AppId appID, [In] [Out] Il2CppStructArray<DepotId_t> pvecDepots, uint cMaxDepots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxDepots;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetInstalledDepots_Internal_UInt32_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pvecDepots = ((intPtr4 == 0) ? null : new Il2CppStructArray<DepotId_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00011008 File Offset: 0x0000F208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931161, XrefRangeEnd = 931163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetAppInstallDir(IntPtr self, AppId appID, IntPtr pchFolder, uint cchFolderBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchFolder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchFolderBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetAppInstallDir_Private_Static_UInt32_IntPtr_AppId_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00011070 File Offset: 0x0000F270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931185, RefRangeEnd = 931186, XrefRangeStart = 931163, XrefRangeEnd = 931185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAppInstallDir(AppId appID, out string pchFolder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetAppInstallDir_Internal_UInt32_AppId_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchFolder = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000110D4 File Offset: 0x0000F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931186, XrefRangeEnd = 931188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsAppInstalled(IntPtr self, AppId appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsAppInstalled_Private_Static_Boolean_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00011120 File Offset: 0x0000F320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931190, RefRangeEnd = 931191, XrefRangeStart = 931188, XrefRangeEnd = 931190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsAppInstalled(AppId appID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsAppInstalled_Internal_Boolean_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001116C File Offset: 0x0000F36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931191, XrefRangeEnd = 931193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamId _GetAppOwner(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetAppOwner_Private_Static_SteamId_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000111AC File Offset: 0x0000F3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931195, RefRangeEnd = 931196, XrefRangeStart = 931193, XrefRangeEnd = 931195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamId GetAppOwner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetAppOwner_Internal_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000111E8 File Offset: 0x0000F3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931196, XrefRangeEnd = 931199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetLaunchQueryParam(IntPtr self, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetLaunchQueryParam_Private_Static_Utf8StringPointer_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00011238 File Offset: 0x0000F438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931203, RefRangeEnd = 931204, XrefRangeStart = 931199, XrefRangeEnd = 931203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLaunchQueryParam(string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetLaunchQueryParam_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00011280 File Offset: 0x0000F480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931204, XrefRangeEnd = 931206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetDlcDownloadProgress(IntPtr self, AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetDlcDownloadProgress_Private_Static_Boolean_IntPtr_AppId_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000112E8 File Offset: 0x0000F4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931208, RefRangeEnd = 931209, XrefRangeStart = 931206, XrefRangeEnd = 931208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDlcDownloadProgress(AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Internal_Boolean_AppId_byref_UInt64_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011350 File Offset: 0x0000F550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931209, XrefRangeEnd = 931211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetAppBuildId(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetAppBuildId_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011390 File Offset: 0x0000F590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931213, RefRangeEnd = 931214, XrefRangeStart = 931211, XrefRangeEnd = 931213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAppBuildId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetAppBuildId_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000113CC File Offset: 0x0000F5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931214, XrefRangeEnd = 931216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RequestAllProofOfPurchaseKeys(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__RequestAllProofOfPurchaseKeys_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011400 File Offset: 0x0000F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931216, XrefRangeEnd = 931218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAllProofOfPurchaseKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011434 File Offset: 0x0000F634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931218, XrefRangeEnd = 931221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetFileDetails(IntPtr self, string pszFileName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszFileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetFileDetails_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00011484 File Offset: 0x0000F684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931227, RefRangeEnd = 931228, XrefRangeStart = 931221, XrefRangeEnd = 931227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<FileDetailsResult_t> GetFileDetails(string pszFileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetFileDetails_Internal_CallResult_1_FileDetailsResult_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<FileDetailsResult_t>(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000114CC File Offset: 0x0000F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931228, XrefRangeEnd = 931230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLaunchCommandLine(IntPtr self, IntPtr pszCommandLine, int cubCommandLine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszCommandLine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubCommandLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__GetLaunchCommandLine_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011528 File Offset: 0x0000F728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931252, RefRangeEnd = 931253, XrefRangeStart = 931230, XrefRangeEnd = 931252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLaunchCommandLine(out string pszCommandLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_GetLaunchCommandLine_Internal_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				pszCommandLine = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00011580 File Offset: 0x0000F780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931253, XrefRangeEnd = 931255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsSubscribedFromFamilySharing(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsSubscribedFromFamilySharing_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000115C0 File Offset: 0x0000F7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931257, RefRangeEnd = 931258, XrefRangeStart = 931255, XrefRangeEnd = 931257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsSubscribedFromFamilySharing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000115FC File Offset: 0x0000F7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931258, XrefRangeEnd = 931260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsTimedTrial(IntPtr self, ref uint punSecondsAllowed, ref uint punSecondsPlayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punSecondsAllowed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punSecondsPlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr__BIsTimedTrial_Private_Static_Boolean_IntPtr_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00011658 File Offset: 0x0000F858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 931262, RefRangeEnd = 931263, XrefRangeStart = 931260, XrefRangeEnd = 931262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsTimedTrial(ref uint punSecondsAllowed, ref uint punSecondsPlayed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &punSecondsAllowed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punSecondsPlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamApps.NativeMethodInfoPtr_BIsTimedTrial_Internal_Boolean_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000022DC File Offset: 0x000004DC
		public ISteamApps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamApps_v008_Internal_Static_IntPtr_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr__BIsSubscribed_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribed_Internal_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__BIsLowViolence_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_BIsLowViolence_Internal_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr__BIsCybercafe_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_BIsCybercafe_Internal_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr__BIsVACBanned_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_BIsVACBanned_Internal_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentGameLanguage_Private_Static_Utf8StringPointer_IntPtr_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameLanguage_Internal_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__GetAvailableGameLanguages_Private_Static_Utf8StringPointer_IntPtr_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableGameLanguages_Internal_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr__BIsSubscribedApp_Private_Static_Boolean_IntPtr_AppId_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedApp_Internal_Boolean_AppId_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__BIsDlcInstalled_Private_Static_Boolean_IntPtr_AppId_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_BIsDlcInstalled_Internal_Boolean_AppId_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr__GetEarliestPurchaseUnixTime_Private_Static_UInt32_IntPtr_AppId_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Internal_UInt32_AppId_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr__BIsSubscribedFromFreeWeekend_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Internal_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__GetDLCCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetDLCCount_Internal_Int32_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__BGetDLCDataByIndex_Private_Static_Boolean_IntPtr_Int32_byref_AppId_byref_Boolean_IntPtr_Int32_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_BGetDLCDataByIndex_Internal_Boolean_Int32_byref_AppId_byref_Boolean_byref_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr__InstallDLC_Private_Static_Void_IntPtr_AppId_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_InstallDLC_Internal_Void_AppId_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr__UninstallDLC_Private_Static_Void_IntPtr_AppId_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_UninstallDLC_Internal_Void_AppId_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr__RequestAppProofOfPurchaseKey_Private_Static_Void_IntPtr_AppId_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Internal_Void_AppId_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentBetaName_Private_Static_Boolean_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBetaName_Internal_Boolean_byref_String_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr__MarkContentCorrupt_Private_Static_Boolean_IntPtr_Boolean_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_MarkContentCorrupt_Internal_Boolean_Boolean_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr__GetInstalledDepots_Private_Static_UInt32_IntPtr_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledDepots_Internal_UInt32_AppId_Il2CppStructArray_1_DepotId_t_UInt32_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr__GetAppInstallDir_Private_Static_UInt32_IntPtr_AppId_IntPtr_UInt32_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_GetAppInstallDir_Internal_UInt32_AppId_byref_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr__BIsAppInstalled_Private_Static_Boolean_IntPtr_AppId_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInstalled_Internal_Boolean_AppId_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr__GetAppOwner_Private_Static_SteamId_IntPtr_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GetAppOwner_Internal_SteamId_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr__GetLaunchQueryParam_Private_Static_Utf8StringPointer_IntPtr_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchQueryParam_Internal_String_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr__GetDlcDownloadProgress_Private_Static_Boolean_IntPtr_AppId_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetDlcDownloadProgress_Internal_Boolean_AppId_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr__GetAppBuildId_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_GetAppBuildId_Internal_Int32_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr__RequestAllProofOfPurchaseKeys_Private_Static_Void_IntPtr_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Internal_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__GetFileDetails_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_GetFileDetails_Internal_CallResult_1_FileDetailsResult_t_String_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__GetLaunchCommandLine_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchCommandLine_Internal_Int32_byref_String_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr__BIsSubscribedFromFamilySharing_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Internal_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__BIsTimedTrial_Private_Static_Boolean_IntPtr_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_BIsTimedTrial_Internal_Boolean_byref_UInt32_byref_UInt32_0;
	}
}
