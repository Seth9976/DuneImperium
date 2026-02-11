using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000017 RID: 23
	public class ISteamInput : SteamInterface
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0001FF18 File Offset: 0x0001E118
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamInput()
		{
			Il2CppClassPointerStore<ISteamInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr);
			ISteamInput.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664007);
			ISteamInput.NativeMethodInfoPtr_SteamAPI_SteamInput_v006_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664008);
			ISteamInput.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664009);
			ISteamInput.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664010);
			ISteamInput.NativeMethodInfoPtr_Init_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664011);
			ISteamInput.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664012);
			ISteamInput.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664013);
			ISteamInput.NativeMethodInfoPtr__SetInputActionManifestFilePath_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664014);
			ISteamInput.NativeMethodInfoPtr_SetInputActionManifestFilePath_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664015);
			ISteamInput.NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664016);
			ISteamInput.NativeMethodInfoPtr_RunFrame_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664017);
			ISteamInput.NativeMethodInfoPtr__BWaitForData_Private_Static_Boolean_IntPtr_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664018);
			ISteamInput.NativeMethodInfoPtr_BWaitForData_Internal_Boolean_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664019);
			ISteamInput.NativeMethodInfoPtr__BNewDataAvailable_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664020);
			ISteamInput.NativeMethodInfoPtr_BNewDataAvailable_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664021);
			ISteamInput.NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664022);
			ISteamInput.NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664023);
			ISteamInput.NativeMethodInfoPtr__EnableDeviceCallbacks_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664024);
			ISteamInput.NativeMethodInfoPtr_EnableDeviceCallbacks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664025);
			ISteamInput.NativeMethodInfoPtr__GetActionSetHandle_Private_Static_InputActionSetHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664026);
			ISteamInput.NativeMethodInfoPtr_GetActionSetHandle_Internal_InputActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664027);
			ISteamInput.NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664028);
			ISteamInput.NativeMethodInfoPtr_ActivateActionSet_Internal_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664029);
			ISteamInput.NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_InputActionSetHandle_t_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664030);
			ISteamInput.NativeMethodInfoPtr_GetCurrentActionSet_Internal_InputActionSetHandle_t_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664031);
			ISteamInput.NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664032);
			ISteamInput.NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664033);
			ISteamInput.NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664034);
			ISteamInput.NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664035);
			ISteamInput.NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664036);
			ISteamInput.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664037);
			ISteamInput.NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664038);
			ISteamInput.NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664039);
			ISteamInput.NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_InputDigitalActionHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664040);
			ISteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_InputDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664041);
			ISteamInput.NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_InputHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664042);
			ISteamInput.NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_InputHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664043);
			ISteamInput.NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664044);
			ISteamInput.NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664045);
			ISteamInput.NativeMethodInfoPtr__GetStringForDigitalActionName_Private_Static_Utf8StringPointer_IntPtr_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664046);
			ISteamInput.NativeMethodInfoPtr_GetStringForDigitalActionName_Internal_String_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664047);
			ISteamInput.NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_InputAnalogActionHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664048);
			ISteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_InputAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664049);
			ISteamInput.NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664050);
			ISteamInput.NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664051);
			ISteamInput.NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664052);
			ISteamInput.NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664053);
			ISteamInput.NativeMethodInfoPtr__GetGlyphPNGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_GlyphSize_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664054);
			ISteamInput.NativeMethodInfoPtr_GetGlyphPNGForActionOrigin_Internal_String_InputActionOrigin_GlyphSize_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664055);
			ISteamInput.NativeMethodInfoPtr__GetGlyphSVGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664056);
			ISteamInput.NativeMethodInfoPtr_GetGlyphSVGForActionOrigin_Internal_String_InputActionOrigin_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664057);
			ISteamInput.NativeMethodInfoPtr__GetGlyphForActionOrigin_Legacy_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664058);
			ISteamInput.NativeMethodInfoPtr_GetGlyphForActionOrigin_Legacy_Internal_String_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664059);
			ISteamInput.NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664060);
			ISteamInput.NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664061);
			ISteamInput.NativeMethodInfoPtr__GetStringForAnalogActionName_Private_Static_Utf8StringPointer_IntPtr_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664062);
			ISteamInput.NativeMethodInfoPtr_GetStringForAnalogActionName_Internal_String_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664063);
			ISteamInput.NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664064);
			ISteamInput.NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664065);
			ISteamInput.NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664066);
			ISteamInput.NativeMethodInfoPtr_GetMotionData_Internal_MotionState_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664067);
			ISteamInput.NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664068);
			ISteamInput.NativeMethodInfoPtr_TriggerVibration_Internal_Void_InputHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664069);
			ISteamInput.NativeMethodInfoPtr__TriggerVibrationExtended_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664070);
			ISteamInput.NativeMethodInfoPtr_TriggerVibrationExtended_Internal_Void_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664071);
			ISteamInput.NativeMethodInfoPtr__TriggerSimpleHapticEvent_Private_Static_Void_IntPtr_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664072);
			ISteamInput.NativeMethodInfoPtr_TriggerSimpleHapticEvent_Internal_Void_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664073);
			ISteamInput.NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_InputHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664074);
			ISteamInput.NativeMethodInfoPtr_SetLEDColor_Internal_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664075);
			ISteamInput.NativeMethodInfoPtr__Legacy_TriggerHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664076);
			ISteamInput.NativeMethodInfoPtr_Legacy_TriggerHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664077);
			ISteamInput.NativeMethodInfoPtr__Legacy_TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664078);
			ISteamInput.NativeMethodInfoPtr_Legacy_TriggerRepeatedHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664079);
			ISteamInput.NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664080);
			ISteamInput.NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664081);
			ISteamInput.NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664082);
			ISteamInput.NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664083);
			ISteamInput.NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_InputHandle_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664084);
			ISteamInput.NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_InputHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664085);
			ISteamInput.NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664086);
			ISteamInput.NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664087);
			ISteamInput.NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664088);
			ISteamInput.NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664089);
			ISteamInput.NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664090);
			ISteamInput.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664091);
			ISteamInput.NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_InputActionOrigin_IntPtr_InputHandle_t_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664092);
			ISteamInput.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_InputActionOrigin_InputHandle_t_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664093);
			ISteamInput.NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_InputActionOrigin_IntPtr_InputType_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664094);
			ISteamInput.NativeMethodInfoPtr_TranslateActionOrigin_Internal_InputActionOrigin_InputType_InputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664095);
			ISteamInput.NativeMethodInfoPtr__GetDeviceBindingRevision_Private_Static_Boolean_IntPtr_InputHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664096);
			ISteamInput.NativeMethodInfoPtr_GetDeviceBindingRevision_Internal_Boolean_InputHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664097);
			ISteamInput.NativeMethodInfoPtr__GetRemotePlaySessionID_Private_Static_UInt32_IntPtr_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664098);
			ISteamInput.NativeMethodInfoPtr_GetRemotePlaySessionID_Internal_UInt32_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664099);
			ISteamInput.NativeMethodInfoPtr__GetSessionInputConfigurationSettings_Private_Static_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664100);
			ISteamInput.NativeMethodInfoPtr_GetSessionInputConfigurationSettings_Internal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr, 100664101);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000206B4 File Offset: 0x0001E8B4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamInput(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamInput>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000206FC File Offset: 0x0001E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932761, XrefRangeEnd = 932763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamInput_v006()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_SteamAPI_SteamInput_v006_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0002072C File Offset: 0x0001E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamInput.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00020774 File Offset: 0x0001E974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932763, XrefRangeEnd = 932765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Init(IntPtr self, bool bExplicitlyCallRunFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bExplicitlyCallRunFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000207C0 File Offset: 0x0001E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932765, XrefRangeEnd = 932767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Init(bool bExplicitlyCallRunFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bExplicitlyCallRunFrame;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_Init_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0002080C File Offset: 0x0001EA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932767, XrefRangeEnd = 932769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Shutdown(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0002084C File Offset: 0x0001EA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932769, XrefRangeEnd = 932771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00020888 File Offset: 0x0001EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932771, XrefRangeEnd = 932774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetInputActionManifestFilePath(IntPtr self, string pchInputActionManifestAbsolutePath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchInputActionManifestAbsolutePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__SetInputActionManifestFilePath_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000208D8 File Offset: 0x0001EAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932774, XrefRangeEnd = 932777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchInputActionManifestAbsolutePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_SetInputActionManifestFilePath_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00020928 File Offset: 0x0001EB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932777, XrefRangeEnd = 932779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RunFrame(IntPtr self, bool bReservedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReservedValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00020968 File Offset: 0x0001EB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932781, RefRangeEnd = 932782, XrefRangeStart = 932779, XrefRangeEnd = 932781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunFrame(bool bReservedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bReservedValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_RunFrame_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000209A8 File Offset: 0x0001EBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932782, XrefRangeEnd = 932784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BWaitForData(IntPtr self, bool bWaitForever, uint unTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWaitForever;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__BWaitForData_Private_Static_Boolean_IntPtr_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00020A04 File Offset: 0x0001EC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932784, XrefRangeEnd = 932786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BWaitForData(bool bWaitForever, uint unTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bWaitForever;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_BWaitForData_Internal_Boolean_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00020A5C File Offset: 0x0001EC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932786, XrefRangeEnd = 932788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BNewDataAvailable(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__BNewDataAvailable_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00020A9C File Offset: 0x0001EC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932788, XrefRangeEnd = 932790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BNewDataAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_BNewDataAvailable_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932790, XrefRangeEnd = 932792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetConnectedControllers(IntPtr self, [In] [Out] Il2CppStructArray<InputHandle_t> handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_InputHandle_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<InputHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00020B38 File Offset: 0x0001ED38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932794, RefRangeEnd = 932795, XrefRangeStart = 932792, XrefRangeEnd = 932794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetConnectedControllers([In] [Out] Il2CppStructArray<InputHandle_t> handlesOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<InputHandle_t>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00020B98 File Offset: 0x0001ED98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932795, XrefRangeEnd = 932797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _EnableDeviceCallbacks(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__EnableDeviceCallbacks_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00020BCC File Offset: 0x0001EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932797, XrefRangeEnd = 932799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableDeviceCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_EnableDeviceCallbacks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00020C00 File Offset: 0x0001EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932799, XrefRangeEnd = 932802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionSetHandle_t _GetActionSetHandle(IntPtr self, string pszActionSetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetActionSetHandle_Private_Static_InputActionSetHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00020C50 File Offset: 0x0001EE50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 932805, RefRangeEnd = 932809, XrefRangeStart = 932802, XrefRangeEnd = 932805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetActionSetHandle_Internal_InputActionSetHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932809, XrefRangeEnd = 932811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateActionSet(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00020CF0 File Offset: 0x0001EEF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932813, RefRangeEnd = 932814, XrefRangeStart = 932811, XrefRangeEnd = 932813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_ActivateActionSet_Internal_Void_InputHandle_t_InputActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00020D3C File Offset: 0x0001EF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932814, XrefRangeEnd = 932816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionSetHandle_t _GetCurrentActionSet(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_InputActionSetHandle_t_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00020D88 File Offset: 0x0001EF88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 932818, RefRangeEnd = 932821, XrefRangeStart = 932816, XrefRangeEnd = 932818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetCurrentActionSet_Internal_InputActionSetHandle_t_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00020DD4 File Offset: 0x0001EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932821, XrefRangeEnd = 932823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateActionSetLayer(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00020E24 File Offset: 0x0001F024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932825, RefRangeEnd = 932826, XrefRangeStart = 932823, XrefRangeEnd = 932825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00020E70 File Offset: 0x0001F070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932826, XrefRangeEnd = 932828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DeactivateActionSetLayer(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00020EC0 File Offset: 0x0001F0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932830, RefRangeEnd = 932831, XrefRangeStart = 932828, XrefRangeEnd = 932830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00020F0C File Offset: 0x0001F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932831, XrefRangeEnd = 932833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DeactivateAllActionSetLayers(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00020F4C File Offset: 0x0001F14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932835, RefRangeEnd = 932836, XrefRangeStart = 932833, XrefRangeEnd = 932835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00020F8C File Offset: 0x0001F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932836, XrefRangeEnd = 932838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetActiveActionSetLayers(IntPtr self, InputHandle_t inputHandle, [In] [Out] Il2CppStructArray<InputActionSetHandle_t> handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<InputActionSetHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00020FFC File Offset: 0x0001F1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932838, XrefRangeEnd = 932840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActiveActionSetLayers(InputHandle_t inputHandle, [In] [Out] Il2CppStructArray<InputActionSetHandle_t> handlesOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<InputActionSetHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00021068 File Offset: 0x0001F268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932840, XrefRangeEnd = 932843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDigitalActionHandle_t _GetDigitalActionHandle(IntPtr self, string pszActionName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_InputDigitalActionHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000210B8 File Offset: 0x0001F2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932846, RefRangeEnd = 932847, XrefRangeStart = 932843, XrefRangeEnd = 932846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_InputDigitalActionHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00021108 File Offset: 0x0001F308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932847, XrefRangeEnd = 932849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DigitalState _GetDigitalActionData(IntPtr self, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_InputHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00021164 File Offset: 0x0001F364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932851, RefRangeEnd = 932852, XrefRangeStart = 932849, XrefRangeEnd = 932851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalState GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_InputHandle_t_InputDigitalActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000211BC File Offset: 0x0001F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932852, XrefRangeEnd = 932854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetDigitalActionOrigins(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00021234 File Offset: 0x0001F434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 932856, RefRangeEnd = 932859, XrefRangeStart = 932854, XrefRangeEnd = 932856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin originsOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000212A8 File Offset: 0x0001F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932859, XrefRangeEnd = 932861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetStringForDigitalActionName(IntPtr self, InputDigitalActionHandle_t eActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetStringForDigitalActionName_Private_Static_Utf8StringPointer_IntPtr_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000212F4 File Offset: 0x0001F4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932861, XrefRangeEnd = 932864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eActionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetStringForDigitalActionName_Internal_String_InputDigitalActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00021338 File Offset: 0x0001F538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932864, XrefRangeEnd = 932867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputAnalogActionHandle_t _GetAnalogActionHandle(IntPtr self, string pszActionName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_InputAnalogActionHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00021388 File Offset: 0x0001F588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932870, RefRangeEnd = 932871, XrefRangeStart = 932867, XrefRangeEnd = 932870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_InputAnalogActionHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000213D8 File Offset: 0x0001F5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932871, XrefRangeEnd = 932873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalogState _GetAnalogActionData(IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00021434 File Offset: 0x0001F634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932875, RefRangeEnd = 932876, XrefRangeStart = 932873, XrefRangeEnd = 932875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogState GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_InputHandle_t_InputAnalogActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0002148C File Offset: 0x0001F68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932876, XrefRangeEnd = 932878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetAnalogActionOrigins(IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00021504 File Offset: 0x0001F704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932878, XrefRangeEnd = 932880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00021578 File Offset: 0x0001F778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932880, XrefRangeEnd = 932882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetGlyphPNGForActionOrigin(IntPtr self, InputActionOrigin eOrigin, GlyphSize eSize, uint unFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetGlyphPNGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_GlyphSize_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000215E0 File Offset: 0x0001F7E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932885, RefRangeEnd = 932886, XrefRangeStart = 932882, XrefRangeEnd = 932885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, GlyphSize eSize, uint unFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetGlyphPNGForActionOrigin_Internal_String_InputActionOrigin_GlyphSize_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00021640 File Offset: 0x0001F840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932886, XrefRangeEnd = 932888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetGlyphSVGForActionOrigin(IntPtr self, InputActionOrigin eOrigin, uint unFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetGlyphSVGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0002169C File Offset: 0x0001F89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932891, RefRangeEnd = 932892, XrefRangeStart = 932888, XrefRangeEnd = 932891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetGlyphSVGForActionOrigin_Internal_String_InputActionOrigin_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000216F0 File Offset: 0x0001F8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932892, XrefRangeEnd = 932894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetGlyphForActionOrigin_Legacy(IntPtr self, InputActionOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetGlyphForActionOrigin_Legacy_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0002173C File Offset: 0x0001F93C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 932897, RefRangeEnd = 932898, XrefRangeStart = 932894, XrefRangeEnd = 932897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetGlyphForActionOrigin_Legacy_Internal_String_InputActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00021780 File Offset: 0x0001F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932898, XrefRangeEnd = 932900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetStringForActionOrigin(IntPtr self, InputActionOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000217CC File Offset: 0x0001F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932900, XrefRangeEnd = 932903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForActionOrigin(InputActionOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_InputActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00021810 File Offset: 0x0001FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932903, XrefRangeEnd = 932905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetStringForAnalogActionName(IntPtr self, InputAnalogActionHandle_t eActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetStringForAnalogActionName_Private_Static_Utf8StringPointer_IntPtr_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0002185C File Offset: 0x0001FA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932905, XrefRangeEnd = 932908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eActionHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetStringForAnalogActionName_Internal_String_InputAnalogActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000218A0 File Offset: 0x0001FAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932908, XrefRangeEnd = 932910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StopAnalogActionMomentum(IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000218F0 File Offset: 0x0001FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932910, XrefRangeEnd = 932912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_InputHandle_t_InputAnalogActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0002193C File Offset: 0x0001FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932912, XrefRangeEnd = 932914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MotionState _GetMotionData(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00021988 File Offset: 0x0001FB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932914, XrefRangeEnd = 932916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionState GetMotionData(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetMotionData_Internal_MotionState_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000219D4 File Offset: 0x0001FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932916, XrefRangeEnd = 932918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerVibration(IntPtr self, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00021A30 File Offset: 0x0001FC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932918, XrefRangeEnd = 932920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_TriggerVibration_Internal_Void_InputHandle_t_UInt16_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00021A8C File Offset: 0x0001FC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932920, XrefRangeEnd = 932922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerVibrationExtended(IntPtr self, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftTriggerSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightTriggerSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__TriggerVibrationExtended_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00021B04 File Offset: 0x0001FD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932922, XrefRangeEnd = 932924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftTriggerSpeed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightTriggerSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_TriggerVibrationExtended_Internal_Void_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00021B7C File Offset: 0x0001FD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932924, XrefRangeEnd = 932926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerSimpleHapticEvent(IntPtr self, InputHandle_t inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHapticLocation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIntensity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nGainDB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOtherIntensity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOtherGainDB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__TriggerSimpleHapticEvent_Private_Static_Void_IntPtr_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00021C04 File Offset: 0x0001FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932926, XrefRangeEnd = 932928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSimpleHapticEvent(InputHandle_t inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHapticLocation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIntensity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nGainDB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOtherIntensity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOtherGainDB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_TriggerSimpleHapticEvent_Internal_Void_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00021C88 File Offset: 0x0001FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932928, XrefRangeEnd = 932930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetLEDColor(IntPtr self, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_InputHandle_t_Byte_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00021D00 File Offset: 0x0001FF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932930, XrefRangeEnd = 932932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_SetLEDColor_Internal_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00021D78 File Offset: 0x0001FF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932932, XrefRangeEnd = 932934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Legacy_TriggerHapticPulse(IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__Legacy_TriggerHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00021DD4 File Offset: 0x0001FFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932934, XrefRangeEnd = 932936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_Legacy_TriggerHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00021E30 File Offset: 0x00020030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932936, XrefRangeEnd = 932938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Legacy_TriggerRepeatedHapticPulse(IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__Legacy_TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00021EB8 File Offset: 0x000200B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932938, XrefRangeEnd = 932940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_Legacy_TriggerRepeatedHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00021F3C File Offset: 0x0002013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932940, XrefRangeEnd = 932942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ShowBindingPanel(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00021F88 File Offset: 0x00020188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932942, XrefRangeEnd = 932944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowBindingPanel(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00021FD4 File Offset: 0x000201D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932944, XrefRangeEnd = 932946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputType _GetInputTypeForHandle(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00022020 File Offset: 0x00020220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 932948, RefRangeEnd = 932950, XrefRangeStart = 932946, XrefRangeEnd = 932948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0002206C File Offset: 0x0002026C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932950, XrefRangeEnd = 932952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputHandle_t _GetControllerForGamepadIndex(IntPtr self, int nIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_InputHandle_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000220B8 File Offset: 0x000202B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932952, XrefRangeEnd = 932954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_InputHandle_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00022104 File Offset: 0x00020304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932954, XrefRangeEnd = 932956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetGamepadIndexForController(IntPtr self, InputHandle_t ulinputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulinputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00022150 File Offset: 0x00020350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932956, XrefRangeEnd = 932958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGamepadIndexForController(InputHandle_t ulinputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulinputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0002219C File Offset: 0x0002039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932958, XrefRangeEnd = 932960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetStringForXboxOrigin(IntPtr self, XboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000221E8 File Offset: 0x000203E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932960, XrefRangeEnd = 932963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForXboxOrigin(XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0002222C File Offset: 0x0002042C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932963, XrefRangeEnd = 932965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetGlyphForXboxOrigin(IntPtr self, XboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00022278 File Offset: 0x00020478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932965, XrefRangeEnd = 932968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphForXboxOrigin(XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000222BC File Offset: 0x000204BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932968, XrefRangeEnd = 932970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionOrigin _GetActionOriginFromXboxOrigin(IntPtr self, InputHandle_t inputHandle, XboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_InputActionOrigin_IntPtr_InputHandle_t_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00022318 File Offset: 0x00020518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932970, XrefRangeEnd = 932972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_InputActionOrigin_InputHandle_t_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00022370 File Offset: 0x00020570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932972, XrefRangeEnd = 932974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionOrigin _TranslateActionOrigin(IntPtr self, InputType eDestinationInputType, InputActionOrigin eSourceOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eDestinationInputType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSourceOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_InputActionOrigin_IntPtr_InputType_InputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000223CC File Offset: 0x000205CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932974, XrefRangeEnd = 932976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionOrigin TranslateActionOrigin(InputType eDestinationInputType, InputActionOrigin eSourceOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eDestinationInputType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSourceOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_TranslateActionOrigin_Internal_InputActionOrigin_InputType_InputActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00022424 File Offset: 0x00020624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932976, XrefRangeEnd = 932978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetDeviceBindingRevision(IntPtr self, InputHandle_t inputHandle, ref int pMajor, ref int pMinor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetDeviceBindingRevision_Private_Static_Boolean_IntPtr_InputHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0002248C File Offset: 0x0002068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932978, XrefRangeEnd = 932980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDeviceBindingRevision(InputHandle_t inputHandle, ref int pMajor, ref int pMinor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetDeviceBindingRevision_Internal_Boolean_InputHandle_t_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000224F4 File Offset: 0x000206F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932980, XrefRangeEnd = 932982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetRemotePlaySessionID(IntPtr self, InputHandle_t inputHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetRemotePlaySessionID_Private_Static_UInt32_IntPtr_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00022540 File Offset: 0x00020740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932982, XrefRangeEnd = 932984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetRemotePlaySessionID(InputHandle_t inputHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetRemotePlaySessionID_Internal_UInt32_InputHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0002258C File Offset: 0x0002078C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932984, XrefRangeEnd = 932986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort _GetSessionInputConfigurationSettings(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr__GetSessionInputConfigurationSettings_Private_Static_UInt16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000225CC File Offset: 0x000207CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932986, XrefRangeEnd = 932988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetSessionInputConfigurationSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamInput.NativeMethodInfoPtr_GetSessionInputConfigurationSettings_Internal_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000232D File Offset: 0x0000052D
		public ISteamInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamInput_v006_Internal_Static_IntPtr_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_Boolean_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Boolean_Boolean_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Boolean_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr__SetInputActionManifestFilePath_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_SetInputActionManifestFilePath_Internal_Boolean_String_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Internal_Void_Boolean_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__BWaitForData_Private_Static_Boolean_IntPtr_Boolean_UInt32_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_BWaitForData_Internal_Boolean_Boolean_UInt32_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr__BNewDataAvailable_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_BNewDataAvailable_Internal_Boolean_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_InputHandle_t_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_InputHandle_t_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr__EnableDeviceCallbacks_Private_Static_Void_IntPtr_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_EnableDeviceCallbacks_Internal_Void_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr__GetActionSetHandle_Private_Static_InputActionSetHandle_t_IntPtr_String_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Internal_InputActionSetHandle_t_String_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSet_Internal_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_InputActionSetHandle_t_IntPtr_InputHandle_t_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActionSet_Internal_InputActionSetHandle_t_InputHandle_t_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_InputHandle_t_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_InputHandle_t_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_InputDigitalActionHandle_t_IntPtr_String_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Internal_InputDigitalActionHandle_t_String_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_InputHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_InputHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_byref_InputActionOrigin_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForDigitalActionName_Private_Static_Utf8StringPointer_IntPtr_InputDigitalActionHandle_t_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForDigitalActionName_Internal_String_InputDigitalActionHandle_t_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_InputAnalogActionHandle_t_IntPtr_String_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Internal_InputAnalogActionHandle_t_String_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_byref_InputActionOrigin_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphPNGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_GlyphSize_UInt32_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPNGForActionOrigin_Internal_String_InputActionOrigin_GlyphSize_UInt32_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphSVGForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_UInt32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphSVGForActionOrigin_Internal_String_InputActionOrigin_UInt32_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphForActionOrigin_Legacy_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForActionOrigin_Legacy_Internal_String_InputActionOrigin_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_InputActionOrigin_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_InputActionOrigin_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForAnalogActionName_Private_Static_Utf8StringPointer_IntPtr_InputAnalogActionHandle_t_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForAnalogActionName_Internal_String_InputAnalogActionHandle_t_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_InputHandle_t_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_GetMotionData_Internal_MotionState_InputHandle_t_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibration_Internal_Void_InputHandle_t_UInt16_UInt16_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr__TriggerVibrationExtended_Private_Static_Void_IntPtr_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibrationExtended_Internal_Void_InputHandle_t_UInt16_UInt16_UInt16_UInt16_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr__TriggerSimpleHapticEvent_Private_Static_Void_IntPtr_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSimpleHapticEvent_Internal_Void_InputHandle_t_ControllerHapticLocation_Byte_Char_Byte_Char_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_InputHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDColor_Internal_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr__Legacy_TriggerHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_Legacy_TriggerHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr__Legacy_TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_Legacy_TriggerRepeatedHapticPulse_Internal_Void_InputHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_InputHandle_t_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_InputHandle_t_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_InputHandle_t_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_InputHandle_t_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_InputHandle_t_IntPtr_Int32_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_InputHandle_t_Int32_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_InputHandle_t_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_InputHandle_t_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_InputActionOrigin_IntPtr_InputHandle_t_XboxOrigin_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_InputActionOrigin_InputHandle_t_XboxOrigin_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_InputActionOrigin_IntPtr_InputType_InputActionOrigin_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_TranslateActionOrigin_Internal_InputActionOrigin_InputType_InputActionOrigin_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr__GetDeviceBindingRevision_Private_Static_Boolean_IntPtr_InputHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceBindingRevision_Internal_Boolean_InputHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr__GetRemotePlaySessionID_Private_Static_UInt32_IntPtr_InputHandle_t_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_GetRemotePlaySessionID_Internal_UInt32_InputHandle_t_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr__GetSessionInputConfigurationSettings_Private_Static_UInt16_IntPtr_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionInputConfigurationSettings_Internal_UInt16_0;
	}
}
