using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000B2 RID: 178
	public class SteamUtils : SteamSharedClass<SteamUtils>
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0004EB64 File Offset: 0x0004CD64
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUtils()
		{
			Il2CppClassPointerStore<SteamUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr);
			SteamUtils.NativeFieldInfoPtr_OnIpCountryChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "OnIpCountryChanged");
			SteamUtils.NativeFieldInfoPtr_OnLowBatteryPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "OnLowBatteryPower");
			SteamUtils.NativeFieldInfoPtr_OnSteamShutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "OnSteamShutdown");
			SteamUtils.NativeFieldInfoPtr_OnGamepadTextInputDismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "OnGamepadTextInputDismissed");
			SteamUtils.NativeFieldInfoPtr_overlayNotificationPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "overlayNotificationPosition");
			SteamUtils.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666123);
			SteamUtils.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666124);
			SteamUtils.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666125);
			SteamUtils.NativeMethodInfoPtr_SteamClosed_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666126);
			SteamUtils.NativeMethodInfoPtr_add_OnIpCountryChanged_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666127);
			SteamUtils.NativeMethodInfoPtr_remove_OnIpCountryChanged_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666128);
			SteamUtils.NativeMethodInfoPtr_add_OnLowBatteryPower_Public_Static_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666129);
			SteamUtils.NativeMethodInfoPtr_remove_OnLowBatteryPower_Public_Static_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666130);
			SteamUtils.NativeMethodInfoPtr_add_OnSteamShutdown_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666131);
			SteamUtils.NativeMethodInfoPtr_remove_OnSteamShutdown_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666132);
			SteamUtils.NativeMethodInfoPtr_add_OnGamepadTextInputDismissed_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666133);
			SteamUtils.NativeMethodInfoPtr_remove_OnGamepadTextInputDismissed_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666134);
			SteamUtils.NativeMethodInfoPtr_get_SecondsSinceAppActive_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666135);
			SteamUtils.NativeMethodInfoPtr_get_SecondsSinceComputerActive_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666136);
			SteamUtils.NativeMethodInfoPtr_get_ConnectedUniverse_Public_Static_get_Universe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666137);
			SteamUtils.NativeMethodInfoPtr_get_SteamServerTime_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666138);
			SteamUtils.NativeMethodInfoPtr_get_IpCountry_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666139);
			SteamUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666140);
			SteamUtils.NativeMethodInfoPtr_GetImage_Public_Static_Nullable_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666141);
			SteamUtils.NativeMethodInfoPtr_get_UsingBatteryPower_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666142);
			SteamUtils.NativeMethodInfoPtr_get_CurrentBatteryPower_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666143);
			SteamUtils.NativeMethodInfoPtr_get_OverlayNotificationPosition_Public_Static_get_NotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666144);
			SteamUtils.NativeMethodInfoPtr_set_OverlayNotificationPosition_Public_Static_set_Void_NotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666145);
			SteamUtils.NativeMethodInfoPtr_get_IsOverlayEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666146);
			SteamUtils.NativeMethodInfoPtr_get_DoesOverlayNeedPresent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666147);
			SteamUtils.NativeMethodInfoPtr_CheckFileSignatureAsync_Public_Static_Task_1_CheckFileSignature_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666148);
			SteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666149);
			SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666150);
			SteamUtils.NativeMethodInfoPtr_get_SteamUILanguage_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666151);
			SteamUtils.NativeMethodInfoPtr_get_IsSteamRunningInVR_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666152);
			SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666153);
			SteamUtils.NativeMethodInfoPtr_get_IsSteamInBigPictureMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666154);
			SteamUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666155);
			SteamUtils.NativeMethodInfoPtr_get_VrHeadsetStreaming_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666156);
			SteamUtils.NativeMethodInfoPtr_set_VrHeadsetStreaming_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666157);
			SteamUtils.NativeMethodInfoPtr_IsCallComplete_Internal_Static_Boolean_SteamAPICall_t_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666158);
			SteamUtils.NativeMethodInfoPtr_get_IsSteamChinaLauncher_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666159);
			SteamUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666160);
			SteamUtils.NativeMethodInfoPtr_FilterText_Public_Static_String_TextFilteringContext_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666161);
			SteamUtils.NativeMethodInfoPtr_get_IsRunningOnSteamDeck_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666162);
			SteamUtils.NativeMethodInfoPtr_SetGameLauncherMode_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666163);
			SteamUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100666164);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0004EF40 File Offset: 0x0004D140
		public unsafe static ISteamUtils Internal
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 945625, RefRangeEnd = 945655, XrefRangeStart = 945621, XrefRangeEnd = 945625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUtils_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamUtils>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0004EF74 File Offset: 0x0004D174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945655, XrefRangeEnd = 945663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamUtils.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945741, RefRangeEnd = 945742, XrefRangeStart = 945663, XrefRangeEnd = 945741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945742, XrefRangeEnd = 945750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SteamClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SteamClosed_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0004F01C File Offset: 0x0004D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945750, XrefRangeEnd = 945761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnIpCountryChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_add_OnIpCountryChanged_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0004F054 File Offset: 0x0004D254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945761, XrefRangeEnd = 945772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnIpCountryChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_remove_OnIpCountryChanged_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0004F08C File Offset: 0x0004D28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945772, XrefRangeEnd = 945785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLowBatteryPower(Action<int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_add_OnLowBatteryPower_Public_Static_add_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0004F0C4 File Offset: 0x0004D2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945785, XrefRangeEnd = 945798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLowBatteryPower(Action<int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_remove_OnLowBatteryPower_Public_Static_rem_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0004F0FC File Offset: 0x0004D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945798, XrefRangeEnd = 945809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSteamShutdown(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_add_OnSteamShutdown_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0004F134 File Offset: 0x0004D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945809, XrefRangeEnd = 945820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSteamShutdown(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_remove_OnSteamShutdown_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0004F16C File Offset: 0x0004D36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945833, RefRangeEnd = 945834, XrefRangeStart = 945820, XrefRangeEnd = 945833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGamepadTextInputDismissed(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_add_OnGamepadTextInputDismissed_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0004F1A4 File Offset: 0x0004D3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945847, RefRangeEnd = 945848, XrefRangeStart = 945834, XrefRangeEnd = 945847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGamepadTextInputDismissed(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_remove_OnGamepadTextInputDismissed_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0004F1DC File Offset: 0x0004D3DC
		public unsafe static uint SecondsSinceAppActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945848, XrefRangeEnd = 945854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_SecondsSinceAppActive_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0004F20C File Offset: 0x0004D40C
		public unsafe static uint SecondsSinceComputerActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945854, XrefRangeEnd = 945860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_SecondsSinceComputerActive_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0004F23C File Offset: 0x0004D43C
		public unsafe static Universe ConnectedUniverse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945860, XrefRangeEnd = 945866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_ConnectedUniverse_Public_Static_get_Universe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0004F26C File Offset: 0x0004D46C
		public unsafe static DateTime SteamServerTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945866, XrefRangeEnd = 945879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_SteamServerTime_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0004F29C File Offset: 0x0004D49C
		public unsafe static string IpCountry
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 945885, RefRangeEnd = 945886, XrefRangeStart = 945879, XrefRangeEnd = 945885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IpCountry_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945886, XrefRangeEnd = 945891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetImageSize(int image, out uint width, out uint height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0004F324 File Offset: 0x0004D524
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 945916, RefRangeEnd = 945922, XrefRangeStart = 945891, XrefRangeEnd = 945916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<Image> GetImage(int image)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetImage_Public_Static_Nullable_1_Image_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Image>(intPtr);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0004F35C File Offset: 0x0004D55C
		public unsafe static bool UsingBatteryPower
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945922, XrefRangeEnd = 945927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_UsingBatteryPower_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0004F38C File Offset: 0x0004D58C
		public unsafe static float CurrentBatteryPower
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945927, XrefRangeEnd = 945937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_CurrentBatteryPower_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0004F3EC File Offset: 0x0004D5EC
		public unsafe static NotificationPosition OverlayNotificationPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945937, XrefRangeEnd = 945941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_OverlayNotificationPosition_Public_Static_get_NotificationPosition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945941, XrefRangeEnd = 945948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_set_OverlayNotificationPosition_Public_Static_set_Void_NotificationPosition_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0004F420 File Offset: 0x0004D620
		public unsafe static bool IsOverlayEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 945954, RefRangeEnd = 945955, XrefRangeStart = 945948, XrefRangeEnd = 945954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IsOverlayEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0004F450 File Offset: 0x0004D650
		public unsafe static bool DoesOverlayNeedPresent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945955, XrefRangeEnd = 945961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_DoesOverlayNeedPresent_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0004F480 File Offset: 0x0004D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945961, XrefRangeEnd = 945975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<CheckFileSignature> CheckFileSignatureAsync(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_CheckFileSignatureAsync_Public_Static_Task_1_CheckFileSignature_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<CheckFileSignature>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945980, RefRangeEnd = 945981, XrefRangeStart = 945975, XrefRangeEnd = 945980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowGamepadTextInput(GamepadTextInputMode inputMode, GamepadTextInputLineMode lineInputMode, string description, int maxChars, string existingText = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineInputMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxChars;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(existingText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0004F544 File Offset: 0x0004D744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945991, RefRangeEnd = 945992, XrefRangeStart = 945981, XrefRangeEnd = 945991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnteredGamepadText()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadText_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0004F570 File Offset: 0x0004D770
		public unsafe static string SteamUILanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945992, XrefRangeEnd = 945998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_SteamUILanguage_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0004F59C File Offset: 0x0004D79C
		public unsafe static bool IsSteamRunningInVR
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945998, XrefRangeEnd = 946004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IsSteamRunningInVR_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0004F5CC File Offset: 0x0004D7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946004, XrefRangeEnd = 946010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOverlayNotificationInset(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0004F60C File Offset: 0x0004D80C
		public unsafe static bool IsSteamInBigPictureMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946010, XrefRangeEnd = 946016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IsSteamInBigPictureMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0004F63C File Offset: 0x0004D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946016, XrefRangeEnd = 946022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartVRDashboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0004F664 File Offset: 0x0004D864
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0004F694 File Offset: 0x0004D894
		public unsafe static bool VrHeadsetStreaming
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946022, XrefRangeEnd = 946028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_VrHeadsetStreaming_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946028, XrefRangeEnd = 946034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_set_VrHeadsetStreaming_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946034, XrefRangeEnd = 946040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCallComplete(SteamAPICall_t call, out bool failed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref call;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsCallComplete_Internal_Static_Boolean_SteamAPICall_t_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0004F714 File Offset: 0x0004D914
		public unsafe static bool IsSteamChinaLauncher
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946040, XrefRangeEnd = 946046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IsSteamChinaLauncher_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0004F744 File Offset: 0x0004D944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946046, XrefRangeEnd = 946052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitFilterText()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004F774 File Offset: 0x0004D974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946052, XrefRangeEnd = 946057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceSteamID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inputMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_FilterText_Public_Static_String_TextFilteringContext_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		public unsafe static bool IsRunningOnSteamDeck
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 946063, RefRangeEnd = 946069, XrefRangeStart = 946057, XrefRangeEnd = 946063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_get_IsRunningOnSteamDeck_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0004F7FC File Offset: 0x0004D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946069, XrefRangeEnd = 946075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameLauncherMode(bool mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetGameLauncherMode_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0004F830 File Offset: 0x0004DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946075, XrefRangeEnd = 946078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002E1F File Offset: 0x0000101F
		public SteamUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0004F86C File Offset: 0x0004DA6C
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00002E28 File Offset: 0x00001028
		public unsafe static Action OnIpCountryChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUtils.NativeFieldInfoPtr_OnIpCountryChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUtils.NativeFieldInfoPtr_OnIpCountryChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0004F894 File Offset: 0x0004DA94
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00002E3A File Offset: 0x0000103A
		public unsafe static Action<int> OnLowBatteryPower
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUtils.NativeFieldInfoPtr_OnLowBatteryPower, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUtils.NativeFieldInfoPtr_OnLowBatteryPower, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0004F8BC File Offset: 0x0004DABC
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00002E4C File Offset: 0x0000104C
		public unsafe static Action OnSteamShutdown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUtils.NativeFieldInfoPtr_OnSteamShutdown, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUtils.NativeFieldInfoPtr_OnSteamShutdown, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00002E5E File Offset: 0x0000105E
		public unsafe static Action<bool> OnGamepadTextInputDismissed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUtils.NativeFieldInfoPtr_OnGamepadTextInputDismissed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUtils.NativeFieldInfoPtr_OnGamepadTextInputDismissed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0004F90C File Offset: 0x0004DB0C
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00002E70 File Offset: 0x00001070
		public unsafe static NotificationPosition overlayNotificationPosition
		{
			get
			{
				NotificationPosition notificationPosition;
				IL2CPP.il2cpp_field_static_get_value(SteamUtils.NativeFieldInfoPtr_overlayNotificationPosition, (void*)(&notificationPosition));
				return notificationPosition;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUtils.NativeFieldInfoPtr_overlayNotificationPosition, (void*)(&value));
			}
		}

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_OnIpCountryChanged;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_OnLowBatteryPower;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_OnSteamShutdown;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr_OnGamepadTextInputDismissed;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr_overlayNotificationPosition;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUtils_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_SteamClosed_Private_Static_Void_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_add_OnIpCountryChanged_Public_Static_add_Void_Action_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnIpCountryChanged_Public_Static_rem_Void_Action_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLowBatteryPower_Public_Static_add_Void_Action_1_Int32_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLowBatteryPower_Public_Static_rem_Void_Action_1_Int32_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSteamShutdown_Public_Static_add_Void_Action_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSteamShutdown_Public_Static_rem_Void_Action_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGamepadTextInputDismissed_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGamepadTextInputDismissed_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondsSinceAppActive_Public_Static_get_UInt32_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondsSinceComputerActive_Public_Static_get_UInt32_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectedUniverse_Public_Static_get_Universe_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamServerTime_Public_Static_get_DateTime_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_get_IpCountry_Public_Static_get_String_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_GetImage_Public_Static_Nullable_1_Image_Int32_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_get_UsingBatteryPower_Public_Static_get_Boolean_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBatteryPower_Public_Static_get_Single_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_get_OverlayNotificationPosition_Public_Static_get_NotificationPosition_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_set_OverlayNotificationPosition_Public_Static_set_Void_NotificationPosition_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOverlayEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_get_DoesOverlayNeedPresent_Public_Static_get_Boolean_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_CheckFileSignatureAsync_Public_Static_Task_1_CheckFileSignature_String_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_GamepadTextInputMode_GamepadTextInputLineMode_String_Int32_String_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadText_Public_Static_String_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamUILanguage_Public_Static_get_String_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteamRunningInVR_Public_Static_get_Boolean_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteamInBigPictureMode_Public_Static_get_Boolean_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_get_VrHeadsetStreaming_Public_Static_get_Boolean_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_set_VrHeadsetStreaming_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_IsCallComplete_Internal_Static_Boolean_SteamAPICall_t_byref_Boolean_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSteamChinaLauncher_Public_Static_get_Boolean_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_FilterText_Public_Static_String_TextFilteringContext_SteamId_String_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnSteamDeck_Public_Static_get_Boolean_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_SetGameLauncherMode_Public_Static_Void_Boolean_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200026C RID: 620
		[ObfuscatedName("Steamworks.SteamUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F67 RID: 8039 RVA: 0x0008C4A0 File Offset: 0x0008A6A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr);
				SteamUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, "<>9");
				SteamUtils.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, "<>9__3_0");
				SteamUtils.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, "<>9__3_1");
				SteamUtils.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, "<>9__3_2");
				SteamUtils.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, "<>9__3_3");
				SteamUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, 100666167);
				SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_IPCountry_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, 100666168);
				SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_LowBatteryPower_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, 100666169);
				SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_SteamShutdown_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, 100666170);
				SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_GamepadTextInputDismissed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr, 100666171);
			}

			// Token: 0x06001F68 RID: 8040 RVA: 0x0008C594 File Offset: 0x0008A794
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F69 RID: 8041 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945566, XrefRangeEnd = 945570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(IPCountry_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_IPCountry_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F6A RID: 8042 RVA: 0x0008C610 File Offset: 0x0008A810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945570, XrefRangeEnd = 945574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(LowBatteryPower_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_LowBatteryPower_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F6B RID: 8043 RVA: 0x0008C650 File Offset: 0x0008A850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945574, XrefRangeEnd = 945585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_2(SteamShutdown_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_SteamShutdown_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F6C RID: 8044 RVA: 0x0008C690 File Offset: 0x0008A890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945585, XrefRangeEnd = 945589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_3(GamepadTextInputDismissed_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.__c.NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_GamepadTextInputDismissed_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F6D RID: 8045 RVA: 0x0000BAE6 File Offset: 0x00009CE6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
			// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000BAEF File Offset: 0x00009CEF
			public unsafe static SteamUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06001F70 RID: 8048 RVA: 0x0008C6F8 File Offset: 0x0008A8F8
			// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000BB01 File Offset: 0x00009D01
			public unsafe static Action<IPCountry_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IPCountry_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0008C720 File Offset: 0x0008A920
			// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000BB13 File Offset: 0x00009D13
			public unsafe static Action<LowBatteryPower_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LowBatteryPower_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0008C748 File Offset: 0x0008A948
			// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000BB25 File Offset: 0x00009D25
			public unsafe static Action<SteamShutdown_t> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamShutdown_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000808 RID: 2056
			// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0008C770 File Offset: 0x0008A970
			// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000BB37 File Offset: 0x00009D37
			public unsafe static Action<GamepadTextInputDismissed_t> __9__3_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GamepadTextInputDismissed_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUtils.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002235 RID: 8757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002236 RID: 8758
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002237 RID: 8759
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04002238 RID: 8760
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x04002239 RID: 8761
			private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

			// Token: 0x0400223A RID: 8762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400223B RID: 8763
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_IPCountry_t_0;

			// Token: 0x0400223C RID: 8764
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_LowBatteryPower_t_0;

			// Token: 0x0400223D RID: 8765
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_SteamShutdown_t_0;

			// Token: 0x0400223E RID: 8766
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_GamepadTextInputDismissed_t_0;
		}

		// Token: 0x0200026D RID: 621
		[ObfuscatedName("Steamworks.SteamUtils+<CheckFileSignatureAsync>d__41")]
		public sealed class _CheckFileSignatureAsync_d__41 : ValueType
		{
			// Token: 0x06001F78 RID: 8056 RVA: 0x0008C798 File Offset: 0x0008A998
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckFileSignatureAsync_d__41()
			{
				Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, "<CheckFileSignatureAsync>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr);
				SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, "<>1__state");
				SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, "<>t__builder");
				SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, "filename");
				SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, "<>u__1");
				SteamUtils._CheckFileSignatureAsync_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, 100666172);
				SteamUtils._CheckFileSignatureAsync_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr, 100666173);
			}

			// Token: 0x06001F79 RID: 8057 RVA: 0x0008C83C File Offset: 0x0008AA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945589, XrefRangeEnd = 945615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils._CheckFileSignatureAsync_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F7A RID: 8058 RVA: 0x0008C874 File Offset: 0x0008AA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945615, XrefRangeEnd = 945621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils._CheckFileSignatureAsync_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F7B RID: 8059 RVA: 0x0000BB49 File Offset: 0x00009D49
			public _CheckFileSignatureAsync_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x0000BB52 File Offset: 0x00009D52
			public _CheckFileSignatureAsync_d__41()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUtils._CheckFileSignatureAsync_d__41>.NativeClassPtr))
			{
			}

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0008C8BC File Offset: 0x0008AABC
			// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0000BB64 File Offset: 0x00009D64
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0008C8E4 File Offset: 0x0008AAE4
			// (set) Token: 0x06001F80 RID: 8064 RVA: 0x0000BB7F File Offset: 0x00009D7F
			public AsyncTaskMethodBuilder<CheckFileSignature> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<CheckFileSignature>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<CheckFileSignature>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<CheckFileSignature>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0008C914 File Offset: 0x0008AB14
			// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0000BBAD File Offset: 0x00009DAD
			public unsafe string filename
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr_filename);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0008C93C File Offset: 0x0008AB3C
			// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0000BBCC File Offset: 0x00009DCC
			public CallResult<CheckFileSignature_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___u__1);
					return new CallResult<CheckFileSignature_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<CheckFileSignature_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUtils._CheckFileSignatureAsync_d__41.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<CheckFileSignature_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400223F RID: 8767
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002240 RID: 8768
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002241 RID: 8769
			private static readonly IntPtr NativeFieldInfoPtr_filename;

			// Token: 0x04002242 RID: 8770
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002243 RID: 8771
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002244 RID: 8772
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
