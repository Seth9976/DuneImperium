using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200009D RID: 157
	public class SteamApps : SteamSharedClass<SteamApps>
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00042F48 File Offset: 0x00041148
		// Note: this type is marked as 'beforefieldinit'.
		static SteamApps()
		{
			Il2CppClassPointerStore<SteamApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamApps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps>.NativeClassPtr);
			SteamApps.NativeFieldInfoPtr_OnDlcInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "OnDlcInstalled");
			SteamApps.NativeFieldInfoPtr_OnNewLaunchParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "OnNewLaunchParameters");
			SteamApps.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamApps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665315);
			SteamApps.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665316);
			SteamApps.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665317);
			SteamApps.NativeMethodInfoPtr_add_OnDlcInstalled_Public_Static_add_Void_Action_1_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665318);
			SteamApps.NativeMethodInfoPtr_remove_OnDlcInstalled_Public_Static_rem_Void_Action_1_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665319);
			SteamApps.NativeMethodInfoPtr_add_OnNewLaunchParameters_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665320);
			SteamApps.NativeMethodInfoPtr_remove_OnNewLaunchParameters_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665321);
			SteamApps.NativeMethodInfoPtr_get_IsSubscribed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665322);
			SteamApps.NativeMethodInfoPtr_get_IsSubscribedFromFamilySharing_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665323);
			SteamApps.NativeMethodInfoPtr_get_IsLowViolence_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665324);
			SteamApps.NativeMethodInfoPtr_get_IsCybercafe_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665325);
			SteamApps.NativeMethodInfoPtr_get_IsVACBanned_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665326);
			SteamApps.NativeMethodInfoPtr_get_GameLanguage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665327);
			SteamApps.NativeMethodInfoPtr_get_AvailableLanguages_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665328);
			SteamApps.NativeMethodInfoPtr_IsSubscribedToApp_Public_Static_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665329);
			SteamApps.NativeMethodInfoPtr_IsDlcInstalled_Public_Static_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665330);
			SteamApps.NativeMethodInfoPtr_PurchaseTime_Public_Static_DateTime_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665331);
			SteamApps.NativeMethodInfoPtr_get_IsSubscribedFromFreeWeekend_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665332);
			SteamApps.NativeMethodInfoPtr_DlcInformation_Public_Static_IEnumerable_1_DlcInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665333);
			SteamApps.NativeMethodInfoPtr_InstallDlc_Public_Static_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665334);
			SteamApps.NativeMethodInfoPtr_UninstallDlc_Public_Static_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665335);
			SteamApps.NativeMethodInfoPtr_get_CurrentBetaName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665336);
			SteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665337);
			SteamApps.NativeMethodInfoPtr_InstalledDepots_Public_Static_IEnumerable_1_DepotId_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665338);
			SteamApps.NativeMethodInfoPtr_AppInstallDir_Public_Static_String_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665339);
			SteamApps.NativeMethodInfoPtr_IsAppInstalled_Public_Static_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665340);
			SteamApps.NativeMethodInfoPtr_get_AppOwner_Public_Static_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665341);
			SteamApps.NativeMethodInfoPtr_GetLaunchParam_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665342);
			SteamApps.NativeMethodInfoPtr_DlcDownloadProgress_Public_Static_DownloadProgress_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665343);
			SteamApps.NativeMethodInfoPtr_get_BuildId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665344);
			SteamApps.NativeMethodInfoPtr_GetFileDetailsAsync_Public_Static_Task_1_Nullable_1_FileDetails_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665345);
			SteamApps.NativeMethodInfoPtr_get_CommandLine_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665346);
			SteamApps.NativeMethodInfoPtr_IsTimedTrial_Public_Static_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665347);
			SteamApps.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100665348);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00043248 File Offset: 0x00041448
		public unsafe static ISteamApps Internal
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 937208, RefRangeEnd = 937235, XrefRangeStart = 937204, XrefRangeEnd = 937208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamApps_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamApps>(intPtr3) : null;
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0004327C File Offset: 0x0004147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937235, XrefRangeEnd = 937239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamApps.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000432C8 File Offset: 0x000414C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937239, XrefRangeEnd = 937279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000432F0 File Offset: 0x000414F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937279, XrefRangeEnd = 937288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDlcInstalled(Action<AppId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_add_OnDlcInstalled_Public_Static_add_Void_Action_1_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00043328 File Offset: 0x00041528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937288, XrefRangeEnd = 937297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDlcInstalled(Action<AppId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_remove_OnDlcInstalled_Public_Static_rem_Void_Action_1_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00043360 File Offset: 0x00041560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937297, XrefRangeEnd = 937304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnNewLaunchParameters(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_add_OnNewLaunchParameters_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00043398 File Offset: 0x00041598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937304, XrefRangeEnd = 937311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnNewLaunchParameters(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_remove_OnNewLaunchParameters_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000433D0 File Offset: 0x000415D0
		public unsafe static bool IsSubscribed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937311, XrefRangeEnd = 937314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsSubscribed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00043400 File Offset: 0x00041600
		public unsafe static bool IsSubscribedFromFamilySharing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937314, XrefRangeEnd = 937317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsSubscribedFromFamilySharing_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00043430 File Offset: 0x00041630
		public unsafe static bool IsLowViolence
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937317, XrefRangeEnd = 937320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsLowViolence_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00043460 File Offset: 0x00041660
		public unsafe static bool IsCybercafe
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937320, XrefRangeEnd = 937323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsCybercafe_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00043490 File Offset: 0x00041690
		public unsafe static bool IsVACBanned
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937323, XrefRangeEnd = 937326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsVACBanned_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000434C0 File Offset: 0x000416C0
		public unsafe static string GameLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937326, XrefRangeEnd = 937329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_GameLanguage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x000434EC File Offset: 0x000416EC
		public unsafe static Il2CppStringArray AvailableLanguages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937329, XrefRangeEnd = 937337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_AvailableLanguages_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00043520 File Offset: 0x00041720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937337, XrefRangeEnd = 937341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubscribedToApp(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_IsSubscribedToApp_Public_Static_Boolean_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00043560 File Offset: 0x00041760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 937345, RefRangeEnd = 937347, XrefRangeStart = 937341, XrefRangeEnd = 937345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDlcInstalled(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_IsDlcInstalled_Public_Static_Boolean_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000435A0 File Offset: 0x000417A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937347, XrefRangeEnd = 937365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime PurchaseTime(AppId appid = default(AppId))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_PurchaseTime_Public_Static_DateTime_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000435E0 File Offset: 0x000417E0
		public unsafe static bool IsSubscribedFromFreeWeekend
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937365, XrefRangeEnd = 937368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_IsSubscribedFromFreeWeekend_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00043610 File Offset: 0x00041810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937368, XrefRangeEnd = 937373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<DlcInformation> DlcInformation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_DlcInformation_Public_Static_IEnumerable_1_DlcInformation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DlcInformation>>(intPtr3) : null;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00043644 File Offset: 0x00041844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937373, XrefRangeEnd = 937377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallDlc(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_InstallDlc_Public_Static_Void_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00043678 File Offset: 0x00041878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937377, XrefRangeEnd = 937381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UninstallDlc(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_UninstallDlc_Public_Static_Void_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000436AC File Offset: 0x000418AC
		public unsafe static string CurrentBetaName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937381, XrefRangeEnd = 937383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_CurrentBetaName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000436D8 File Offset: 0x000418D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937383, XrefRangeEnd = 937386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkContentCorrupt(bool missingFilesOnly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref missingFilesOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0004370C File Offset: 0x0004190C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937386, XrefRangeEnd = 937391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<DepotId> InstalledDepots(AppId appid = default(AppId))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_InstalledDepots_Public_Static_IEnumerable_1_DepotId_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DepotId>>(intPtr3) : null;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0004374C File Offset: 0x0004194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937391, XrefRangeEnd = 937401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AppInstallDir(AppId appid = default(AppId))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_AppInstallDir_Public_Static_String_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00043784 File Offset: 0x00041984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937405, RefRangeEnd = 937406, XrefRangeStart = 937401, XrefRangeEnd = 937405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAppInstalled(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_IsAppInstalled_Public_Static_Boolean_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000437C4 File Offset: 0x000419C4
		public unsafe static SteamId AppOwner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937406, XrefRangeEnd = 937410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_AppOwner_Public_Static_get_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000437F4 File Offset: 0x000419F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937410, XrefRangeEnd = 937413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLaunchParam(string param)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetLaunchParam_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00043830 File Offset: 0x00041A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937413, XrefRangeEnd = 937416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DownloadProgress DlcDownloadProgress(AppId appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_DlcDownloadProgress_Public_Static_DownloadProgress_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00043870 File Offset: 0x00041A70
		public unsafe static int BuildId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937416, XrefRangeEnd = 937419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_BuildId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000438A0 File Offset: 0x00041AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937419, XrefRangeEnd = 937433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<FileDetails>> GetFileDetailsAsync(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetFileDetailsAsync_Public_Static_Task_1_Nullable_1_FileDetails_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<FileDetails>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000438E4 File Offset: 0x00041AE4
		public unsafe static string CommandLine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937433, XrefRangeEnd = 937435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_get_CommandLine_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00043910 File Offset: 0x00041B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937435, XrefRangeEnd = 937437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTimedTrial(out int secondsAllowed, out int secondsPlayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &secondsAllowed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &secondsPlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_IsTimedTrial_Public_Static_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0004395C File Offset: 0x00041B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937437, XrefRangeEnd = 937440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamApps()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamApps>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0000267C File Offset: 0x0000087C
		public SteamApps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00043998 File Offset: 0x00041B98
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00002685 File Offset: 0x00000885
		public unsafe static Action<AppId> OnDlcInstalled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamApps.NativeFieldInfoPtr_OnDlcInstalled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AppId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamApps.NativeFieldInfoPtr_OnDlcInstalled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x000439C0 File Offset: 0x00041BC0
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00002697 File Offset: 0x00000897
		public unsafe static Action OnNewLaunchParameters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamApps.NativeFieldInfoPtr_OnNewLaunchParameters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamApps.NativeFieldInfoPtr_OnNewLaunchParameters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_OnDlcInstalled;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_OnNewLaunchParameters;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamApps_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDlcInstalled_Public_Static_add_Void_Action_1_AppId_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDlcInstalled_Public_Static_rem_Void_Action_1_AppId_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNewLaunchParameters_Public_Static_add_Void_Action_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNewLaunchParameters_Public_Static_rem_Void_Action_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubscribed_Public_Static_get_Boolean_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubscribedFromFamilySharing_Public_Static_get_Boolean_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLowViolence_Public_Static_get_Boolean_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCybercafe_Public_Static_get_Boolean_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVACBanned_Public_Static_get_Boolean_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_get_GameLanguage_Public_Static_get_String_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableLanguages_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_IsSubscribedToApp_Public_Static_Boolean_AppId_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_IsDlcInstalled_Public_Static_Boolean_AppId_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseTime_Public_Static_DateTime_AppId_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubscribedFromFreeWeekend_Public_Static_get_Boolean_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_DlcInformation_Public_Static_IEnumerable_1_DlcInformation_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_InstallDlc_Public_Static_Void_AppId_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_UninstallDlc_Public_Static_Void_AppId_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBetaName_Public_Static_get_String_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Void_Boolean_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_InstalledDepots_Public_Static_IEnumerable_1_DepotId_AppId_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_AppInstallDir_Public_Static_String_AppId_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_IsAppInstalled_Public_Static_Boolean_AppId_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_get_AppOwner_Public_Static_get_SteamId_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchParam_Public_Static_String_String_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_DlcDownloadProgress_Public_Static_DownloadProgress_AppId_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildId_Public_Static_get_Int32_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_GetFileDetailsAsync_Public_Static_Task_1_Nullable_1_FileDetails_String_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandLine_Public_Static_get_String_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_IsTimedTrial_Public_Static_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021D RID: 541
		[ObfuscatedName("Steamworks.SteamApps+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B1C RID: 6940 RVA: 0x000811CC File Offset: 0x0007F3CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr);
				SteamApps.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, "<>9");
				SteamApps.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, "<>9__3_0");
				SteamApps.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, "<>9__3_1");
				SteamApps.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, "<>9__44_0");
				SteamApps.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, 100665350);
				SteamApps.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DlcInstalled_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, 100665351);
				SteamApps.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_NewUrlLaunchParameters_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, 100665352);
				SteamApps.__c.NativeMethodInfoPtr__GetFileDetailsAsync_b__44_0_Internal_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr, 100665353);
			}

			// Token: 0x06001B1D RID: 6941 RVA: 0x00081298 File Offset: 0x0007F498
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamApps.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1E RID: 6942 RVA: 0x000812D4 File Offset: 0x0007F4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937082, XrefRangeEnd = 937084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(DlcInstalled_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DlcInstalled_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1F RID: 6943 RVA: 0x00081314 File Offset: 0x0007F514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937084, XrefRangeEnd = 937086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(NewUrlLaunchParameters_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_NewUrlLaunchParameters_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B20 RID: 6944 RVA: 0x00081354 File Offset: 0x0007F554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937086, XrefRangeEnd = 937089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetFileDetailsAsync_b__44_0(byte x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.__c.NativeMethodInfoPtr__GetFileDetailsAsync_b__44_0_Internal_String_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001B21 RID: 6945 RVA: 0x00008F37 File Offset: 0x00007137
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06001B22 RID: 6946 RVA: 0x00081398 File Offset: 0x0007F598
			// (set) Token: 0x06001B23 RID: 6947 RVA: 0x00008F40 File Offset: 0x00007140
			public unsafe static SteamApps.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamApps.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamApps.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamApps.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001B24 RID: 6948 RVA: 0x000813C0 File Offset: 0x0007F5C0
			// (set) Token: 0x06001B25 RID: 6949 RVA: 0x00008F52 File Offset: 0x00007152
			public unsafe static Action<DlcInstalled_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamApps.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DlcInstalled_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamApps.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000813E8 File Offset: 0x0007F5E8
			// (set) Token: 0x06001B27 RID: 6951 RVA: 0x00008F64 File Offset: 0x00007164
			public unsafe static Action<NewUrlLaunchParameters_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamApps.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NewUrlLaunchParameters_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamApps.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00081410 File Offset: 0x0007F610
			// (set) Token: 0x06001B29 RID: 6953 RVA: 0x00008F76 File Offset: 0x00007176
			public unsafe static Func<byte, string> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamApps.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<byte, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamApps.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FE6 RID: 8166
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FE7 RID: 8167
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001FE8 RID: 8168
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001FE9 RID: 8169
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x04001FEA RID: 8170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FEB RID: 8171
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DlcInstalled_t_0;

			// Token: 0x04001FEC RID: 8172
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_NewUrlLaunchParameters_t_0;

			// Token: 0x04001FED RID: 8173
			private static readonly IntPtr NativeMethodInfoPtr__GetFileDetailsAsync_b__44_0_Internal_String_Byte_0;
		}

		// Token: 0x0200021E RID: 542
		[ObfuscatedName("Steamworks.SteamApps+<DlcInformation>d__29")]
		public sealed class _DlcInformation_d__29 : Object
		{
			// Token: 0x06001B2A RID: 6954 RVA: 0x00081438 File Offset: 0x0007F638
			// Note: this type is marked as 'beforefieldinit'.
			static _DlcInformation_d__29()
			{
				Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "<DlcInformation>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr);
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<>1__state");
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<>2__current");
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<>l__initialThreadId");
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__appid_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<appid>5__2");
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__available_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<available>5__3");
				SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, "<i>5__4");
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665354);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665355);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665356);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DlcInformation__get_Current_Private_Virtual_Final_New_get_DlcInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665357);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665358);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665359);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DlcInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DlcInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665360);
				SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr, 100665361);
			}

			// Token: 0x06001B2B RID: 6955 RVA: 0x0008157C File Offset: 0x0007F77C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937091, RefRangeEnd = 937095, XrefRangeStart = 937089, XrefRangeEnd = 937091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DlcInformation_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamApps._DlcInformation_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B2C RID: 6956 RVA: 0x000815C4 File Offset: 0x0007F7C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2D RID: 6957 RVA: 0x000815F8 File Offset: 0x0007F7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937095, XrefRangeEnd = 937103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00081634 File Offset: 0x0007F834
			public unsafe DlcInformation System.Collections.Generic.IEnumerator<Steamworks.Data.DlcInformation>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DlcInformation__get_Current_Private_Virtual_Final_New_get_DlcInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DlcInformation(intPtr);
				}
			}

			// Token: 0x06001B2F RID: 6959 RVA: 0x0008166C File Offset: 0x0007F86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937103, XrefRangeEnd = 937108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06001B30 RID: 6960 RVA: 0x000816A0 File Offset: 0x0007F8A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937108, XrefRangeEnd = 937111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B31 RID: 6961 RVA: 0x000816E0 File Offset: 0x0007F8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937111, XrefRangeEnd = 937113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<DlcInformation> System_Collections_Generic_IEnumerable_Steamworks_Data_DlcInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DlcInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DlcInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DlcInformation>>(intPtr3) : null;
			}

			// Token: 0x06001B32 RID: 6962 RVA: 0x00081720 File Offset: 0x0007F920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._DlcInformation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001B33 RID: 6963 RVA: 0x00008F88 File Offset: 0x00007188
			public _DlcInformation_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06001B34 RID: 6964 RVA: 0x00081760 File Offset: 0x0007F960
			// (set) Token: 0x06001B35 RID: 6965 RVA: 0x00008F91 File Offset: 0x00007191
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00081788 File Offset: 0x0007F988
			// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00008FAC File Offset: 0x000071AC
			public DlcInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___2__current);
					return new DlcInformation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Steamworks.Data.DlcInformation>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Steamworks.Data.DlcInformation>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000817B8 File Offset: 0x0007F9B8
			// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00008FDA File Offset: 0x000071DA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000817E0 File Offset: 0x0007F9E0
			// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00008FF5 File Offset: 0x000071F5
			public unsafe AppId _appid_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__appid_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__appid_5__2)) = value;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00081808 File Offset: 0x0007FA08
			// (set) Token: 0x06001B3D RID: 6973 RVA: 0x00009010 File Offset: 0x00007210
			public unsafe bool _available_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__available_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__available_5__3)) = value;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00081830 File Offset: 0x0007FA30
			// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0000902B File Offset: 0x0000722B
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._DlcInformation_d__29.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04001FEE RID: 8174
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FEF RID: 8175
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FF0 RID: 8176
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001FF1 RID: 8177
			private static readonly IntPtr NativeFieldInfoPtr__appid_5__2;

			// Token: 0x04001FF2 RID: 8178
			private static readonly IntPtr NativeFieldInfoPtr__available_5__3;

			// Token: 0x04001FF3 RID: 8179
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04001FF4 RID: 8180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FF5 RID: 8181
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FF6 RID: 8182
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FF7 RID: 8183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DlcInformation__get_Current_Private_Virtual_Final_New_get_DlcInformation_0;

			// Token: 0x04001FF8 RID: 8184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FF9 RID: 8185
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FFA RID: 8186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DlcInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DlcInformation_0;

			// Token: 0x04001FFB RID: 8187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200021F RID: 543
		[ObfuscatedName("Steamworks.SteamApps+<GetFileDetailsAsync>d__44")]
		public sealed class _GetFileDetailsAsync_d__44 : ValueType
		{
			// Token: 0x06001B40 RID: 6976 RVA: 0x00081858 File Offset: 0x0007FA58
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFileDetailsAsync_d__44()
			{
				Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "<GetFileDetailsAsync>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr);
				SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, "<>1__state");
				SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, "<>t__builder");
				SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, "filename");
				SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, "<>u__1");
				SteamApps._GetFileDetailsAsync_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, 100665362);
				SteamApps._GetFileDetailsAsync_d__44.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr, 100665363);
			}

			// Token: 0x06001B41 RID: 6977 RVA: 0x000818FC File Offset: 0x0007FAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937113, XrefRangeEnd = 937168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._GetFileDetailsAsync_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x00081934 File Offset: 0x0007FB34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937168, XrefRangeEnd = 937174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._GetFileDetailsAsync_d__44.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x00009046 File Offset: 0x00007246
			public _GetFileDetailsAsync_d__44(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B44 RID: 6980 RVA: 0x0000904F File Offset: 0x0000724F
			public _GetFileDetailsAsync_d__44()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamApps._GetFileDetailsAsync_d__44>.NativeClassPtr))
			{
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0008197C File Offset: 0x0007FB7C
			// (set) Token: 0x06001B46 RID: 6982 RVA: 0x00009061 File Offset: 0x00007261
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000819A4 File Offset: 0x0007FBA4
			// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000907C File Offset: 0x0000727C
			public AsyncTaskMethodBuilder<Nullable<FileDetails>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<FileDetails>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<FileDetails>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<FileDetails>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000819D4 File Offset: 0x0007FBD4
			// (set) Token: 0x06001B4A RID: 6986 RVA: 0x000090AA File Offset: 0x000072AA
			public unsafe string filename
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr_filename);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06001B4B RID: 6987 RVA: 0x000819FC File Offset: 0x0007FBFC
			// (set) Token: 0x06001B4C RID: 6988 RVA: 0x000090C9 File Offset: 0x000072C9
			public CallResult<FileDetailsResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___u__1);
					return new CallResult<FileDetailsResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<FileDetailsResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._GetFileDetailsAsync_d__44.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<FileDetailsResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001FFC RID: 8188
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FFD RID: 8189
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001FFE RID: 8190
			private static readonly IntPtr NativeFieldInfoPtr_filename;

			// Token: 0x04001FFF RID: 8191
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002000 RID: 8192
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002001 RID: 8193
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000220 RID: 544
		[ObfuscatedName("Steamworks.SteamApps+<InstalledDepots>d__35")]
		public sealed class _InstalledDepots_d__35 : Object
		{
			// Token: 0x06001B4D RID: 6989 RVA: 0x00081A2C File Offset: 0x0007FC2C
			// Note: this type is marked as 'beforefieldinit'.
			static _InstalledDepots_d__35()
			{
				Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, "<InstalledDepots>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr);
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<>1__state");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<>2__current");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<>l__initialThreadId");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr_appid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "appid");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___3__appid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<>3__appid");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__depots_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<depots>5__2");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__count_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<count>5__3");
				SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, "<i>5__4");
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665364);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665365);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665366);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DepotId__get_Current_Private_Virtual_Final_New_get_DepotId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665367);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665368);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665369);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DepotId__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DepotId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665370);
				SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr, 100665371);
			}

			// Token: 0x06001B4E RID: 6990 RVA: 0x00081B98 File Offset: 0x0007FD98
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstalledDepots_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamApps._InstalledDepots_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x00081BE0 File Offset: 0x0007FDE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x00081C14 File Offset: 0x0007FE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937174, XrefRangeEnd = 937189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00081C50 File Offset: 0x0007FE50
			public unsafe DepotId System.Collections.Generic.IEnumerator<Steamworks.Data.DepotId>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DepotId__get_Current_Private_Virtual_Final_New_get_DepotId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x00081C8C File Offset: 0x0007FE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937189, XrefRangeEnd = 937194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00081CC0 File Offset: 0x0007FEC0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937194, XrefRangeEnd = 937197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x00081D00 File Offset: 0x0007FF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937197, XrefRangeEnd = 937204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<DepotId> System_Collections_Generic_IEnumerable_Steamworks_Data_DepotId__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DepotId__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DepotId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DepotId>>(intPtr3) : null;
			}

			// Token: 0x06001B55 RID: 6997 RVA: 0x00081D40 File Offset: 0x0007FF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps._InstalledDepots_d__35.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001B56 RID: 6998 RVA: 0x000090F7 File Offset: 0x000072F7
			public _InstalledDepots_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00081D80 File Offset: 0x0007FF80
			// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00009100 File Offset: 0x00007300
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00081DA8 File Offset: 0x0007FFA8
			// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000911B File Offset: 0x0000731B
			public unsafe DepotId __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00081DD0 File Offset: 0x0007FFD0
			// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00009136 File Offset: 0x00007336
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00081DF8 File Offset: 0x0007FFF8
			// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00009151 File Offset: 0x00007351
			public unsafe AppId appid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr_appid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr_appid)) = value;
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00081E20 File Offset: 0x00080020
			// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0000916C File Offset: 0x0000736C
			public unsafe AppId __3__appid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___3__appid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr___3__appid)) = value;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00081E48 File Offset: 0x00080048
			// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00009187 File Offset: 0x00007387
			public unsafe Il2CppStructArray<DepotId_t> _depots_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__depots_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DepotId_t>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__depots_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00081E78 File Offset: 0x00080078
			// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000091A6 File Offset: 0x000073A6
			public unsafe uint _count_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__count_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__count_5__3)) = value;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00081EA0 File Offset: 0x000800A0
			// (set) Token: 0x06001B66 RID: 7014 RVA: 0x000091C1 File Offset: 0x000073C1
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamApps._InstalledDepots_d__35.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04002002 RID: 8194
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002003 RID: 8195
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002004 RID: 8196
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002005 RID: 8197
			private static readonly IntPtr NativeFieldInfoPtr_appid;

			// Token: 0x04002006 RID: 8198
			private static readonly IntPtr NativeFieldInfoPtr___3__appid;

			// Token: 0x04002007 RID: 8199
			private static readonly IntPtr NativeFieldInfoPtr__depots_5__2;

			// Token: 0x04002008 RID: 8200
			private static readonly IntPtr NativeFieldInfoPtr__count_5__3;

			// Token: 0x04002009 RID: 8201
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400200A RID: 8202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400200B RID: 8203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400200C RID: 8204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400200D RID: 8205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_DepotId__get_Current_Private_Virtual_Final_New_get_DepotId_0;

			// Token: 0x0400200E RID: 8206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400200F RID: 8207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002010 RID: 8208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_DepotId__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DepotId_0;

			// Token: 0x04002011 RID: 8209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
