using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200002E RID: 46
	public class ISteamUtils : SteamInterface
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x0003E578 File Offset: 0x0003C778
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamUtils()
		{
			Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr);
			ISteamUtils.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665134);
			ISteamUtils.NativeMethodInfoPtr_SteamAPI_SteamUtils_v010_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665135);
			ISteamUtils.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665136);
			ISteamUtils.NativeMethodInfoPtr_SteamAPI_SteamGameServerUtils_v010_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665137);
			ISteamUtils.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665138);
			ISteamUtils.NativeMethodInfoPtr__GetSecondsSinceAppActive_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665139);
			ISteamUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665140);
			ISteamUtils.NativeMethodInfoPtr__GetSecondsSinceComputerActive_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665141);
			ISteamUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665142);
			ISteamUtils.NativeMethodInfoPtr__GetConnectedUniverse_Private_Static_Universe_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665143);
			ISteamUtils.NativeMethodInfoPtr_GetConnectedUniverse_Internal_Universe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665144);
			ISteamUtils.NativeMethodInfoPtr__GetServerRealTime_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665145);
			ISteamUtils.NativeMethodInfoPtr_GetServerRealTime_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665146);
			ISteamUtils.NativeMethodInfoPtr__GetIPCountry_Private_Static_Utf8StringPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665147);
			ISteamUtils.NativeMethodInfoPtr_GetIPCountry_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665148);
			ISteamUtils.NativeMethodInfoPtr__GetImageSize_Private_Static_Boolean_IntPtr_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665149);
			ISteamUtils.NativeMethodInfoPtr_GetImageSize_Internal_Boolean_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665150);
			ISteamUtils.NativeMethodInfoPtr__GetImageRGBA_Private_Static_Boolean_IntPtr_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665151);
			ISteamUtils.NativeMethodInfoPtr_GetImageRGBA_Internal_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665152);
			ISteamUtils.NativeMethodInfoPtr__GetCurrentBatteryPower_Private_Static_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665153);
			ISteamUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665154);
			ISteamUtils.NativeMethodInfoPtr__GetAppID_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665155);
			ISteamUtils.NativeMethodInfoPtr_GetAppID_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665156);
			ISteamUtils.NativeMethodInfoPtr__SetOverlayNotificationPosition_Private_Static_Void_IntPtr_NotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665157);
			ISteamUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Internal_Void_NotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665158);
			ISteamUtils.NativeMethodInfoPtr__IsAPICallCompleted_Private_Static_Boolean_IntPtr_SteamAPICall_t_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665159);
			ISteamUtils.NativeMethodInfoPtr_IsAPICallCompleted_Internal_Boolean_SteamAPICall_t_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665160);
			ISteamUtils.NativeMethodInfoPtr__GetAPICallFailureReason_Private_Static_SteamAPICallFailure_IntPtr_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665161);
			ISteamUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Internal_SteamAPICallFailure_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665162);
			ISteamUtils.NativeMethodInfoPtr__GetAPICallResult_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665163);
			ISteamUtils.NativeMethodInfoPtr_GetAPICallResult_Internal_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665164);
			ISteamUtils.NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665165);
			ISteamUtils.NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665166);
			ISteamUtils.NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665167);
			ISteamUtils.NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665168);
			ISteamUtils.NativeMethodInfoPtr__IsOverlayEnabled_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665169);
			ISteamUtils.NativeMethodInfoPtr_IsOverlayEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665170);
			ISteamUtils.NativeMethodInfoPtr__BOverlayNeedsPresent_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665171);
			ISteamUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665172);
			ISteamUtils.NativeMethodInfoPtr__CheckFileSignature_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665173);
			ISteamUtils.NativeMethodInfoPtr_CheckFileSignature_Internal_CallResult_1_CheckFileSignature_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665174);
			ISteamUtils.NativeMethodInfoPtr__ShowGamepadTextInput_Private_Static_Boolean_IntPtr_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665175);
			ISteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Internal_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665176);
			ISteamUtils.NativeMethodInfoPtr__GetEnteredGamepadTextLength_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665177);
			ISteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665178);
			ISteamUtils.NativeMethodInfoPtr__GetEnteredGamepadTextInput_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665179);
			ISteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Internal_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665180);
			ISteamUtils.NativeMethodInfoPtr__GetSteamUILanguage_Private_Static_Utf8StringPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665181);
			ISteamUtils.NativeMethodInfoPtr_GetSteamUILanguage_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665182);
			ISteamUtils.NativeMethodInfoPtr__IsSteamRunningInVR_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665183);
			ISteamUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665184);
			ISteamUtils.NativeMethodInfoPtr__SetOverlayNotificationInset_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665185);
			ISteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665186);
			ISteamUtils.NativeMethodInfoPtr__IsSteamInBigPictureMode_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665187);
			ISteamUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665188);
			ISteamUtils.NativeMethodInfoPtr__StartVRDashboard_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665189);
			ISteamUtils.NativeMethodInfoPtr_StartVRDashboard_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665190);
			ISteamUtils.NativeMethodInfoPtr__IsVRHeadsetStreamingEnabled_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665191);
			ISteamUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665192);
			ISteamUtils.NativeMethodInfoPtr__SetVRHeadsetStreamingEnabled_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665193);
			ISteamUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665194);
			ISteamUtils.NativeMethodInfoPtr__IsSteamChinaLauncher_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665195);
			ISteamUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665196);
			ISteamUtils.NativeMethodInfoPtr__InitFilterText_Private_Static_Boolean_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665197);
			ISteamUtils.NativeMethodInfoPtr_InitFilterText_Internal_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665198);
			ISteamUtils.NativeMethodInfoPtr__FilterText_Private_Static_Int32_IntPtr_TextFilteringContext_SteamId_String_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665199);
			ISteamUtils.NativeMethodInfoPtr_FilterText_Internal_Int32_TextFilteringContext_SteamId_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665200);
			ISteamUtils.NativeMethodInfoPtr__GetIPv6ConnectivityState_Private_Static_SteamIPv6ConnectivityState_IntPtr_SteamIPv6ConnectivityProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665201);
			ISteamUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Internal_SteamIPv6ConnectivityState_SteamIPv6ConnectivityProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665202);
			ISteamUtils.NativeMethodInfoPtr__IsSteamRunningOnSteamDeck_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665203);
			ISteamUtils.NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665204);
			ISteamUtils.NativeMethodInfoPtr__ShowFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_TextInputMode_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665205);
			ISteamUtils.NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Internal_Boolean_TextInputMode_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665206);
			ISteamUtils.NativeMethodInfoPtr__SetGameLauncherMode_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665207);
			ISteamUtils.NativeMethodInfoPtr_SetGameLauncherMode_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665208);
			ISteamUtils.NativeMethodInfoPtr__DismissFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665209);
			ISteamUtils.NativeMethodInfoPtr_DismissFloatingGamepadTextInput_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr, 100665210);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0003EBAC File Offset: 0x0003CDAC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamUtils(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamUtils>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0003EBF4 File Offset: 0x0003CDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936412, XrefRangeEnd = 936414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamUtils_v010()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SteamAPI_SteamUtils_v010_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0003EC24 File Offset: 0x0003CE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamUtils.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0003EC6C File Offset: 0x0003CE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936414, XrefRangeEnd = 936416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerUtils_v010()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SteamAPI_SteamGameServerUtils_v010_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamUtils.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0003ECE4 File Offset: 0x0003CEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936416, XrefRangeEnd = 936418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetSecondsSinceAppActive(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetSecondsSinceAppActive_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0003ED24 File Offset: 0x0003CF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936420, RefRangeEnd = 936421, XrefRangeStart = 936418, XrefRangeEnd = 936420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetSecondsSinceAppActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0003ED60 File Offset: 0x0003CF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936421, XrefRangeEnd = 936423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetSecondsSinceComputerActive(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetSecondsSinceComputerActive_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0003EDA0 File Offset: 0x0003CFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936425, RefRangeEnd = 936426, XrefRangeStart = 936423, XrefRangeEnd = 936425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetSecondsSinceComputerActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0003EDDC File Offset: 0x0003CFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936426, XrefRangeEnd = 936428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Universe _GetConnectedUniverse(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetConnectedUniverse_Private_Static_Universe_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0003EE1C File Offset: 0x0003D01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936430, RefRangeEnd = 936431, XrefRangeStart = 936428, XrefRangeEnd = 936430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Universe GetConnectedUniverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetConnectedUniverse_Internal_Universe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0003EE58 File Offset: 0x0003D058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936431, XrefRangeEnd = 936433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetServerRealTime(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetServerRealTime_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0003EE98 File Offset: 0x0003D098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936435, RefRangeEnd = 936436, XrefRangeStart = 936433, XrefRangeEnd = 936435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetServerRealTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetServerRealTime_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0003EED4 File Offset: 0x0003D0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936436, XrefRangeEnd = 936438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetIPCountry(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetIPCountry_Private_Static_Utf8StringPointer_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0003EF14 File Offset: 0x0003D114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936441, RefRangeEnd = 936442, XrefRangeStart = 936438, XrefRangeEnd = 936441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetIPCountry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetIPCountry_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0003EF4C File Offset: 0x0003D14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936442, XrefRangeEnd = 936444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iImage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetImageSize_Private_Static_Boolean_IntPtr_Int32_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0003EFB4 File Offset: 0x0003D1B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936446, RefRangeEnd = 936448, XrefRangeStart = 936444, XrefRangeEnd = 936446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iImage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetImageSize_Internal_Boolean_Int32_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0003F01C File Offset: 0x0003D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936448, XrefRangeEnd = 936450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] Il2CppStructArray<byte> pubDest, int nDestBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iImage;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDestBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetImageRGBA_Private_Static_Boolean_IntPtr_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubDest = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0003F098 File Offset: 0x0003D298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936452, RefRangeEnd = 936453, XrefRangeStart = 936450, XrefRangeEnd = 936452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetImageRGBA(int iImage, [In] [Out] Il2CppStructArray<byte> pubDest, int nDestBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iImage;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDestBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetImageRGBA_Internal_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubDest = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0003F114 File Offset: 0x0003D314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936453, XrefRangeEnd = 936455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte _GetCurrentBatteryPower(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetCurrentBatteryPower_Private_Static_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0003F154 File Offset: 0x0003D354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936457, RefRangeEnd = 936459, XrefRangeStart = 936455, XrefRangeEnd = 936457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte GetCurrentBatteryPower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0003F190 File Offset: 0x0003D390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936459, XrefRangeEnd = 936461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetAppID(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetAppID_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0003F1D0 File Offset: 0x0003D3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936461, XrefRangeEnd = 936463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAppID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetAppID_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0003F20C File Offset: 0x0003D40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936463, XrefRangeEnd = 936465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetOverlayNotificationPosition(IntPtr self, NotificationPosition eNotificationPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eNotificationPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__SetOverlayNotificationPosition_Private_Static_Void_IntPtr_NotificationPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0003F24C File Offset: 0x0003D44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936467, RefRangeEnd = 936468, XrefRangeStart = 936465, XrefRangeEnd = 936467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eNotificationPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Internal_Void_NotificationPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0003F28C File Offset: 0x0003D48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936468, XrefRangeEnd = 936470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsAPICallCompleted_Private_Static_Boolean_IntPtr_SteamAPICall_t_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0003F2E8 File Offset: 0x0003D4E8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 936472, RefRangeEnd = 936486, XrefRangeStart = 936470, XrefRangeEnd = 936472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsAPICallCompleted_Internal_Boolean_SteamAPICall_t_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0003F340 File Offset: 0x0003D540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936486, XrefRangeEnd = 936488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICallFailure _GetAPICallFailureReason(IntPtr self, SteamAPICall_t hSteamAPICall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetAPICallFailureReason_Private_Static_SteamAPICallFailure_IntPtr_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0003F38C File Offset: 0x0003D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936488, XrefRangeEnd = 936490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Internal_SteamAPICallFailure_SteamAPICall_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936490, XrefRangeEnd = 936492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubCallback;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iCallbackExpected;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetAPICallResult_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0003F45C File Offset: 0x0003D65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936494, RefRangeEnd = 936495, XrefRangeStart = 936492, XrefRangeEnd = 936494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCallback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iCallbackExpected;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetAPICallResult_Internal_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936495, XrefRangeEnd = 936497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetIPCCallCount(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0003F520 File Offset: 0x0003D720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936497, XrefRangeEnd = 936499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIPCCallCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0003F55C File Offset: 0x0003D75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936499, XrefRangeEnd = 936501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetWarningMessageHook(IntPtr self, IntPtr pFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0003F59C File Offset: 0x0003D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936501, XrefRangeEnd = 936503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWarningMessageHook(IntPtr pFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pFunction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0003F5DC File Offset: 0x0003D7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936503, XrefRangeEnd = 936505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsOverlayEnabled(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsOverlayEnabled_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0003F61C File Offset: 0x0003D81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936507, RefRangeEnd = 936508, XrefRangeStart = 936505, XrefRangeEnd = 936507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOverlayEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsOverlayEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003F658 File Offset: 0x0003D858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936508, XrefRangeEnd = 936510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BOverlayNeedsPresent(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__BOverlayNeedsPresent_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003F698 File Offset: 0x0003D898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936512, RefRangeEnd = 936513, XrefRangeStart = 936510, XrefRangeEnd = 936512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BOverlayNeedsPresent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0003F6D4 File Offset: 0x0003D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936513, XrefRangeEnd = 936516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _CheckFileSignature(IntPtr self, string szFileName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(szFileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__CheckFileSignature_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0003F724 File Offset: 0x0003D924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936522, RefRangeEnd = 936523, XrefRangeStart = 936516, XrefRangeEnd = 936522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<CheckFileSignature_t> CheckFileSignature(string szFileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(szFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_CheckFileSignature_Internal_CallResult_1_CheckFileSignature_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<CheckFileSignature_t>(intPtr);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0003F76C File Offset: 0x0003D96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936523, XrefRangeEnd = 936528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ShowGamepadTextInput(IntPtr self, GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eInputMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLineInputMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCharMax;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExistingText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__ShowGamepadTextInput_Private_Static_Boolean_IntPtr_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0003F7F8 File Offset: 0x0003D9F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936533, RefRangeEnd = 936534, XrefRangeStart = 936528, XrefRangeEnd = 936533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eInputMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLineInputMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCharMax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExistingText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Internal_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0003F884 File Offset: 0x0003DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936534, XrefRangeEnd = 936536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetEnteredGamepadTextLength(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetEnteredGamepadTextLength_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003F8C4 File Offset: 0x0003DAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936538, RefRangeEnd = 936539, XrefRangeStart = 936536, XrefRangeEnd = 936538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetEnteredGamepadTextLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0003F900 File Offset: 0x0003DB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936539, XrefRangeEnd = 936541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetEnteredGamepadTextInput(IntPtr self, IntPtr pchText, uint cchText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchText;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchText;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetEnteredGamepadTextInput_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0003F95C File Offset: 0x0003DB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936563, RefRangeEnd = 936564, XrefRangeStart = 936541, XrefRangeEnd = 936563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetEnteredGamepadTextInput(out string pchText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Internal_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				pchText = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936564, XrefRangeEnd = 936566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetSteamUILanguage(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetSteamUILanguage_Private_Static_Utf8StringPointer_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003F9F4 File Offset: 0x0003DBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936569, RefRangeEnd = 936570, XrefRangeStart = 936566, XrefRangeEnd = 936569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSteamUILanguage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetSteamUILanguage_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936570, XrefRangeEnd = 936572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsSteamRunningInVR(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsSteamRunningInVR_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0003FA6C File Offset: 0x0003DC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936574, RefRangeEnd = 936575, XrefRangeStart = 936572, XrefRangeEnd = 936574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSteamRunningInVR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0003FAA8 File Offset: 0x0003DCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936575, XrefRangeEnd = 936577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetOverlayNotificationInset(IntPtr self, int nHorizontalInset, int nVerticalInset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHorizontalInset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nVerticalInset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__SetOverlayNotificationInset_Private_Static_Void_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936579, RefRangeEnd = 936580, XrefRangeStart = 936577, XrefRangeEnd = 936579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nHorizontalInset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nVerticalInset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0003FB44 File Offset: 0x0003DD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936580, XrefRangeEnd = 936582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsSteamInBigPictureMode(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsSteamInBigPictureMode_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0003FB84 File Offset: 0x0003DD84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936584, RefRangeEnd = 936585, XrefRangeStart = 936582, XrefRangeEnd = 936584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSteamInBigPictureMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0003FBC0 File Offset: 0x0003DDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936585, XrefRangeEnd = 936587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StartVRDashboard(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__StartVRDashboard_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003FBF4 File Offset: 0x0003DDF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936589, RefRangeEnd = 936590, XrefRangeStart = 936587, XrefRangeEnd = 936589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartVRDashboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_StartVRDashboard_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0003FC28 File Offset: 0x0003DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936590, XrefRangeEnd = 936592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsVRHeadsetStreamingEnabled(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsVRHeadsetStreamingEnabled_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003FC68 File Offset: 0x0003DE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936594, RefRangeEnd = 936595, XrefRangeStart = 936592, XrefRangeEnd = 936594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsVRHeadsetStreamingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0003FCA4 File Offset: 0x0003DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936595, XrefRangeEnd = 936597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetVRHeadsetStreamingEnabled(IntPtr self, bool bEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__SetVRHeadsetStreamingEnabled_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936599, RefRangeEnd = 936600, XrefRangeStart = 936597, XrefRangeEnd = 936599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003FD24 File Offset: 0x0003DF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936600, XrefRangeEnd = 936602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsSteamChinaLauncher(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsSteamChinaLauncher_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003FD64 File Offset: 0x0003DF64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936604, RefRangeEnd = 936605, XrefRangeStart = 936602, XrefRangeEnd = 936604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSteamChinaLauncher()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0003FDA0 File Offset: 0x0003DFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936605, XrefRangeEnd = 936607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _InitFilterText(IntPtr self, uint unFilterOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFilterOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__InitFilterText_Private_Static_Boolean_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0003FDEC File Offset: 0x0003DFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936609, RefRangeEnd = 936610, XrefRangeStart = 936607, XrefRangeEnd = 936609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InitFilterText(uint unFilterOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unFilterOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_InitFilterText_Internal_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0003FE38 File Offset: 0x0003E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936610, XrefRangeEnd = 936613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceSteamID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchInputMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchOutFilteredText;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nByteSizeOutFilteredText;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__FilterText_Private_Static_Int32_IntPtr_TextFilteringContext_SteamId_String_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936636, RefRangeEnd = 936637, XrefRangeStart = 936613, XrefRangeEnd = 936636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceSteamID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchInputMessage);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_FilterText_Internal_Int32_TextFilteringContext_SteamId_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchOutFilteredText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0003FF48 File Offset: 0x0003E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936637, XrefRangeEnd = 936639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamIPv6ConnectivityState _GetIPv6ConnectivityState(IntPtr self, SteamIPv6ConnectivityProtocol eProtocol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eProtocol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__GetIPv6ConnectivityState_Private_Static_SteamIPv6ConnectivityState_IntPtr_SteamIPv6ConnectivityProtocol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0003FF94 File Offset: 0x0003E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936639, XrefRangeEnd = 936641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eProtocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Internal_SteamIPv6ConnectivityState_SteamIPv6ConnectivityProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0003FFE0 File Offset: 0x0003E1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936641, XrefRangeEnd = 936643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsSteamRunningOnSteamDeck(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__IsSteamRunningOnSteamDeck_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00040020 File Offset: 0x0003E220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936645, RefRangeEnd = 936646, XrefRangeStart = 936643, XrefRangeEnd = 936645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSteamRunningOnSteamDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0004005C File Offset: 0x0003E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936646, XrefRangeEnd = 936648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ShowFloatingGamepadTextInput(IntPtr self, TextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eKeyboardMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldXPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldYPosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__ShowFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_TextInputMode_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000400E0 File Offset: 0x0003E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936648, XrefRangeEnd = 936650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowFloatingGamepadTextInput(TextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eKeyboardMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldXPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldYPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nTextFieldHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Internal_Boolean_TextInputMode_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00040164 File Offset: 0x0003E364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936650, XrefRangeEnd = 936652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetGameLauncherMode(IntPtr self, bool bLauncherMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLauncherMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__SetGameLauncherMode_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x000401A4 File Offset: 0x0003E3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936654, RefRangeEnd = 936655, XrefRangeStart = 936652, XrefRangeEnd = 936654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameLauncherMode(bool bLauncherMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bLauncherMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_SetGameLauncherMode_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000401E4 File Offset: 0x0003E3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936655, XrefRangeEnd = 936657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DismissFloatingGamepadTextInput(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr__DismissFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00040224 File Offset: 0x0003E424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936657, XrefRangeEnd = 936659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DismissFloatingGamepadTextInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUtils.NativeMethodInfoPtr_DismissFloatingGamepadTextInput_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000023FC File Offset: 0x000005FC
		public ISteamUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamUtils_v010_Internal_Static_IntPtr_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerUtils_v010_Internal_Static_IntPtr_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr__GetSecondsSinceAppActive_Private_Static_UInt32_IntPtr_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceAppActive_Internal_UInt32_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr__GetSecondsSinceComputerActive_Private_Static_UInt32_IntPtr_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceComputerActive_Internal_UInt32_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectedUniverse_Private_Static_Universe_IntPtr_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedUniverse_Internal_Universe_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr__GetServerRealTime_Private_Static_UInt32_IntPtr_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetServerRealTime_Internal_UInt32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr__GetIPCountry_Private_Static_Utf8StringPointer_IntPtr_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCountry_Internal_String_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr__GetImageSize_Private_Static_Boolean_IntPtr_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_GetImageSize_Internal_Boolean_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr__GetImageRGBA_Private_Static_Boolean_IntPtr_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_GetImageRGBA_Internal_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentBatteryPower_Private_Static_Byte_IntPtr_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBatteryPower_Internal_Byte_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr__GetAppID_Private_Static_UInt32_IntPtr_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_GetAppID_Internal_UInt32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr__SetOverlayNotificationPosition_Private_Static_Void_IntPtr_NotificationPosition_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationPosition_Internal_Void_NotificationPosition_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr__IsAPICallCompleted_Private_Static_Boolean_IntPtr_SteamAPICall_t_byref_Boolean_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_IsAPICallCompleted_Internal_Boolean_SteamAPICall_t_byref_Boolean_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__GetAPICallFailureReason_Private_Static_SteamAPICallFailure_IntPtr_SteamAPICall_t_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallFailureReason_Internal_SteamAPICallFailure_SteamAPICall_t_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr__GetAPICallResult_Private_Static_Boolean_IntPtr_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallResult_Internal_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr__GetIPCCallCount_Private_Static_UInt32_IntPtr_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Internal_UInt32_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr__SetWarningMessageHook_Private_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Internal_Void_IntPtr_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr__IsOverlayEnabled_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_IsOverlayEnabled_Internal_Boolean_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr__BOverlayNeedsPresent_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_BOverlayNeedsPresent_Internal_Boolean_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr__CheckFileSignature_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_CheckFileSignature_Internal_CallResult_1_CheckFileSignature_t_String_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr__ShowGamepadTextInput_Private_Static_Boolean_IntPtr_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_ShowGamepadTextInput_Internal_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_UInt32_String_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr__GetEnteredGamepadTextLength_Private_Static_UInt32_IntPtr_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextLength_Internal_UInt32_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr__GetEnteredGamepadTextInput_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextInput_Internal_Boolean_byref_String_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr__GetSteamUILanguage_Private_Static_Utf8StringPointer_IntPtr_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUILanguage_Internal_String_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr__IsSteamRunningInVR_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamRunningInVR_Internal_Boolean_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr__SetOverlayNotificationInset_Private_Static_Void_IntPtr_Int32_Int32_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationInset_Internal_Void_Int32_Int32_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr__IsSteamInBigPictureMode_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamInBigPictureMode_Internal_Boolean_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr__StartVRDashboard_Private_Static_Void_IntPtr_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_StartVRDashboard_Internal_Void_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr__IsVRHeadsetStreamingEnabled_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Internal_Boolean_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr__SetVRHeadsetStreamingEnabled_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Internal_Void_Boolean_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr__IsSteamChinaLauncher_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamChinaLauncher_Internal_Boolean_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr__InitFilterText_Private_Static_Boolean_IntPtr_UInt32_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_InitFilterText_Internal_Boolean_UInt32_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr__FilterText_Private_Static_Int32_IntPtr_TextFilteringContext_SteamId_String_IntPtr_UInt32_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_FilterText_Internal_Int32_TextFilteringContext_SteamId_String_byref_String_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr__GetIPv6ConnectivityState_Private_Static_SteamIPv6ConnectivityState_IntPtr_SteamIPv6ConnectivityProtocol_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_GetIPv6ConnectivityState_Internal_SteamIPv6ConnectivityState_SteamIPv6ConnectivityProtocol_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr__IsSteamRunningOnSteamDeck_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Internal_Boolean_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr__ShowFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_TextInputMode_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Internal_Boolean_TextInputMode_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr__SetGameLauncherMode_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_SetGameLauncherMode_Internal_Void_Boolean_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr__DismissFloatingGamepadTextInput_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_DismissFloatingGamepadTextInput_Internal_Boolean_0;
	}
}
