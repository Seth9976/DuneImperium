using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace InControl
{
	// Token: 0x02000041 RID: 65
	public static class InputManager : Object
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x0001C834 File Offset: 0x0001AA34
		// Note: this type is marked as 'beforefieldinit'.
		static InputManager()
		{
			Il2CppClassPointerStore<InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager>.NativeClassPtr);
			InputManager.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "Version");
			InputManager.NativeFieldInfoPtr_OnSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnSetup");
			InputManager.NativeFieldInfoPtr_OnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnUpdate");
			InputManager.NativeFieldInfoPtr_OnReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnReset");
			InputManager.NativeFieldInfoPtr_OnDeviceAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnDeviceAttached");
			InputManager.NativeFieldInfoPtr_OnDeviceDetached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnDeviceDetached");
			InputManager.NativeFieldInfoPtr_OnActiveDeviceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnActiveDeviceChanged");
			InputManager.NativeFieldInfoPtr_OnUpdateDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnUpdateDevices");
			InputManager.NativeFieldInfoPtr_OnCommitDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "OnCommitDevices");
			InputManager.NativeFieldInfoPtr_deviceManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "deviceManagers");
			InputManager.NativeFieldInfoPtr_deviceManagerTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "deviceManagerTable");
			InputManager.NativeFieldInfoPtr_devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "devices");
			InputManager.NativeFieldInfoPtr_activeDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "activeDevice");
			InputManager.NativeFieldInfoPtr_activeDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "activeDevices");
			InputManager.NativeFieldInfoPtr_playerActionSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "playerActionSets");
			InputManager.NativeFieldInfoPtr_Devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "Devices");
			InputManager.NativeFieldInfoPtr_ActiveDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "ActiveDevices");
			InputManager.NativeFieldInfoPtr__CommandWasPressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<CommandWasPressed>k__BackingField");
			InputManager.NativeFieldInfoPtr__InvertYAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<InvertYAxis>k__BackingField");
			InputManager.NativeFieldInfoPtr__IsSetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<IsSetup>k__BackingField");
			InputManager.NativeFieldInfoPtr__MouseProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<MouseProvider>k__BackingField");
			InputManager.NativeFieldInfoPtr__KeyboardProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<KeyboardProvider>k__BackingField");
			InputManager.NativeFieldInfoPtr__Platform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<Platform>k__BackingField");
			InputManager.NativeFieldInfoPtr_applicationIsFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "applicationIsFocused");
			InputManager.NativeFieldInfoPtr_initialTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "initialTime");
			InputManager.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "currentTime");
			InputManager.NativeFieldInfoPtr_lastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "lastUpdateTime");
			InputManager.NativeFieldInfoPtr_currentTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "currentTick");
			InputManager.NativeFieldInfoPtr_unityVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "unityVersion");
			InputManager.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "enabled");
			InputManager.NativeFieldInfoPtr__SuspendInBackground_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<SuspendInBackground>k__BackingField");
			InputManager.NativeFieldInfoPtr__EnableNativeInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<EnableNativeInput>k__BackingField");
			InputManager.NativeFieldInfoPtr__EnableXInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<EnableXInput>k__BackingField");
			InputManager.NativeFieldInfoPtr__XInputUpdateRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<XInputUpdateRate>k__BackingField");
			InputManager.NativeFieldInfoPtr__XInputBufferSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<XInputBufferSize>k__BackingField");
			InputManager.NativeFieldInfoPtr__NativeInputEnableXInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<NativeInputEnableXInput>k__BackingField");
			InputManager.NativeFieldInfoPtr__NativeInputEnableMFi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<NativeInputEnableMFi>k__BackingField");
			InputManager.NativeFieldInfoPtr__NativeInputPreventSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<NativeInputPreventSleep>k__BackingField");
			InputManager.NativeFieldInfoPtr__NativeInputUpdateRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<NativeInputUpdateRate>k__BackingField");
			InputManager.NativeFieldInfoPtr__EnableICade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<EnableICade>k__BackingField");
			InputManager.NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664061);
			InputManager.NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664062);
			InputManager.NativeMethodInfoPtr_add_OnUpdate_Public_Static_add_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664063);
			InputManager.NativeMethodInfoPtr_remove_OnUpdate_Public_Static_rem_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664064);
			InputManager.NativeMethodInfoPtr_add_OnReset_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664065);
			InputManager.NativeMethodInfoPtr_remove_OnReset_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664066);
			InputManager.NativeMethodInfoPtr_add_OnDeviceAttached_Public_Static_add_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664067);
			InputManager.NativeMethodInfoPtr_remove_OnDeviceAttached_Public_Static_rem_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664068);
			InputManager.NativeMethodInfoPtr_add_OnDeviceDetached_Public_Static_add_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664069);
			InputManager.NativeMethodInfoPtr_remove_OnDeviceDetached_Public_Static_rem_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664070);
			InputManager.NativeMethodInfoPtr_add_OnActiveDeviceChanged_Public_Static_add_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664071);
			InputManager.NativeMethodInfoPtr_remove_OnActiveDeviceChanged_Public_Static_rem_Void_Action_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664072);
			InputManager.NativeMethodInfoPtr_add_OnUpdateDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664073);
			InputManager.NativeMethodInfoPtr_remove_OnUpdateDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664074);
			InputManager.NativeMethodInfoPtr_add_OnCommitDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664075);
			InputManager.NativeMethodInfoPtr_remove_OnCommitDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664076);
			InputManager.NativeMethodInfoPtr_get_CommandWasPressed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664077);
			InputManager.NativeMethodInfoPtr_set_CommandWasPressed_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664078);
			InputManager.NativeMethodInfoPtr_get_InvertYAxis_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664079);
			InputManager.NativeMethodInfoPtr_set_InvertYAxis_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664080);
			InputManager.NativeMethodInfoPtr_get_IsSetup_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664081);
			InputManager.NativeMethodInfoPtr_set_IsSetup_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664082);
			InputManager.NativeMethodInfoPtr_get_MouseProvider_Public_Static_get_IMouseProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664083);
			InputManager.NativeMethodInfoPtr_set_MouseProvider_Private_Static_set_Void_IMouseProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664084);
			InputManager.NativeMethodInfoPtr_get_KeyboardProvider_Public_Static_get_IKeyboardProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664085);
			InputManager.NativeMethodInfoPtr_set_KeyboardProvider_Private_Static_set_Void_IKeyboardProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664086);
			InputManager.NativeMethodInfoPtr_get_Platform_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664087);
			InputManager.NativeMethodInfoPtr_set_Platform_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664088);
			InputManager.NativeMethodInfoPtr_get_MenuWasPressed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664089);
			InputManager.NativeMethodInfoPtr_SetupInternal_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664090);
			InputManager.NativeMethodInfoPtr_ResetInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664091);
			InputManager.NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664092);
			InputManager.NativeMethodInfoPtr_UpdateInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664093);
			InputManager.NativeMethodInfoPtr_Reload_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664094);
			InputManager.NativeMethodInfoPtr_AssertIsSetup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664095);
			InputManager.NativeMethodInfoPtr_SetZeroTickOnAllControls_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664096);
			InputManager.NativeMethodInfoPtr_ClearInputState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664097);
			InputManager.NativeMethodInfoPtr_OnApplicationFocus_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664098);
			InputManager.NativeMethodInfoPtr_OnApplicationPause_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664099);
			InputManager.NativeMethodInfoPtr_OnApplicationQuit_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664100);
			InputManager.NativeMethodInfoPtr_OnLevelWasLoaded_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664101);
			InputManager.NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_InputDeviceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664102);
			InputManager.NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664103);
			InputManager.NativeMethodInfoPtr_GetDeviceManager_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664104);
			InputManager.NativeMethodInfoPtr_HasDeviceManager_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664105);
			InputManager.NativeMethodInfoPtr_UpdateCurrentTime_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664106);
			InputManager.NativeMethodInfoPtr_UpdateDeviceManagers_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664107);
			InputManager.NativeMethodInfoPtr_DestroyDeviceManagers_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664108);
			InputManager.NativeMethodInfoPtr_DestroyDevices_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664109);
			InputManager.NativeMethodInfoPtr_UpdateDevices_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664110);
			InputManager.NativeMethodInfoPtr_CommitDevices_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664111);
			InputManager.NativeMethodInfoPtr_UpdateActiveDevice_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664112);
			InputManager.NativeMethodInfoPtr_AttachDevice_Public_Static_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664113);
			InputManager.NativeMethodInfoPtr_DetachDevice_Public_Static_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664114);
			InputManager.NativeMethodInfoPtr_HideDevicesWithProfile_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664115);
			InputManager.NativeMethodInfoPtr_AttachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664116);
			InputManager.NativeMethodInfoPtr_DetachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664117);
			InputManager.NativeMethodInfoPtr_UpdatePlayerActionSets_Internal_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664118);
			InputManager.NativeMethodInfoPtr_get_AnyKeyIsPressed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664119);
			InputManager.NativeMethodInfoPtr_get_ActiveDevice_Public_Static_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664120);
			InputManager.NativeMethodInfoPtr_set_ActiveDevice_Private_Static_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664121);
			InputManager.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664122);
			InputManager.NativeMethodInfoPtr_set_Enabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664123);
			InputManager.NativeMethodInfoPtr_get_SuspendInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664124);
			InputManager.NativeMethodInfoPtr_set_SuspendInBackground_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664125);
			InputManager.NativeMethodInfoPtr_get_EnableNativeInput_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664126);
			InputManager.NativeMethodInfoPtr_set_EnableNativeInput_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664127);
			InputManager.NativeMethodInfoPtr_get_EnableXInput_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664128);
			InputManager.NativeMethodInfoPtr_set_EnableXInput_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664129);
			InputManager.NativeMethodInfoPtr_get_XInputUpdateRate_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664130);
			InputManager.NativeMethodInfoPtr_set_XInputUpdateRate_Internal_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664131);
			InputManager.NativeMethodInfoPtr_get_XInputBufferSize_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664132);
			InputManager.NativeMethodInfoPtr_set_XInputBufferSize_Internal_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664133);
			InputManager.NativeMethodInfoPtr_get_NativeInputEnableXInput_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664134);
			InputManager.NativeMethodInfoPtr_set_NativeInputEnableXInput_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664135);
			InputManager.NativeMethodInfoPtr_get_NativeInputEnableMFi_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664136);
			InputManager.NativeMethodInfoPtr_set_NativeInputEnableMFi_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664137);
			InputManager.NativeMethodInfoPtr_get_NativeInputPreventSleep_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664138);
			InputManager.NativeMethodInfoPtr_set_NativeInputPreventSleep_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664139);
			InputManager.NativeMethodInfoPtr_get_NativeInputUpdateRate_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664140);
			InputManager.NativeMethodInfoPtr_set_NativeInputUpdateRate_Internal_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664141);
			InputManager.NativeMethodInfoPtr_get_EnableICade_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664142);
			InputManager.NativeMethodInfoPtr_set_EnableICade_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664143);
			InputManager.NativeMethodInfoPtr_get_UnityVersion_Internal_Static_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664144);
			InputManager.NativeMethodInfoPtr_get_CurrentTick_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664145);
			InputManager.NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100664146);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001D23C File Offset: 0x0001B43C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 781962, RefRangeEnd = 781964, XrefRangeStart = 781951, XrefRangeEnd = 781962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSetup(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001D274 File Offset: 0x0001B474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781975, RefRangeEnd = 781976, XrefRangeStart = 781964, XrefRangeEnd = 781975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSetup(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 781989, RefRangeEnd = 781990, XrefRangeStart = 781976, XrefRangeEnd = 781989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnUpdate(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnUpdate_Public_Static_add_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781990, XrefRangeEnd = 782003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnUpdate(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnUpdate_Public_Static_rem_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001D31C File Offset: 0x0001B51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782014, RefRangeEnd = 782015, XrefRangeStart = 782003, XrefRangeEnd = 782014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnReset(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnReset_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001D354 File Offset: 0x0001B554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782026, RefRangeEnd = 782027, XrefRangeStart = 782015, XrefRangeEnd = 782026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnReset(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnReset_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001D38C File Offset: 0x0001B58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782040, RefRangeEnd = 782041, XrefRangeStart = 782027, XrefRangeEnd = 782040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDeviceAttached(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnDeviceAttached_Public_Static_add_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782041, XrefRangeEnd = 782054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDeviceAttached(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnDeviceAttached_Public_Static_rem_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001D3FC File Offset: 0x0001B5FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 782067, RefRangeEnd = 782070, XrefRangeStart = 782054, XrefRangeEnd = 782067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDeviceDetached(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnDeviceDetached_Public_Static_add_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001D434 File Offset: 0x0001B634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782083, RefRangeEnd = 782084, XrefRangeStart = 782070, XrefRangeEnd = 782083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDeviceDetached(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnDeviceDetached_Public_Static_rem_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001D46C File Offset: 0x0001B66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782097, RefRangeEnd = 782098, XrefRangeStart = 782084, XrefRangeEnd = 782097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnActiveDeviceChanged(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnActiveDeviceChanged_Public_Static_add_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782098, XrefRangeEnd = 782111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnActiveDeviceChanged(Action<InputDevice> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnActiveDeviceChanged_Public_Static_rem_Void_Action_1_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001D4DC File Offset: 0x0001B6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782111, XrefRangeEnd = 782124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnUpdateDevices(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnUpdateDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001D514 File Offset: 0x0001B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782124, XrefRangeEnd = 782137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnUpdateDevices(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnUpdateDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001D54C File Offset: 0x0001B74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782137, XrefRangeEnd = 782150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnCommitDevices(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_add_OnCommitDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001D584 File Offset: 0x0001B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782150, XrefRangeEnd = 782163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnCommitDevices(Action<ulong, float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_remove_OnCommitDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001D5BC File Offset: 0x0001B7BC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		public unsafe static bool CommandWasPressed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782163, XrefRangeEnd = 782167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_CommandWasPressed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782167, XrefRangeEnd = 782171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_CommandWasPressed_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001D620 File Offset: 0x0001B820
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0001D650 File Offset: 0x0001B850
		public unsafe static bool InvertYAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782171, XrefRangeEnd = 782175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_InvertYAxis_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782175, XrefRangeEnd = 782179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_InvertYAxis_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001D684 File Offset: 0x0001B884
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		public unsafe static bool IsSetup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782179, XrefRangeEnd = 782183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_IsSetup_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782183, XrefRangeEnd = 782187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_IsSetup_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0001D71C File Offset: 0x0001B91C
		public unsafe static IMouseProvider MouseProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782187, XrefRangeEnd = 782191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_MouseProvider_Public_Static_get_IMouseProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMouseProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782191, XrefRangeEnd = 782197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_MouseProvider_Private_Static_set_Void_IMouseProvider_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001D754 File Offset: 0x0001B954
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0001D788 File Offset: 0x0001B988
		public unsafe static IKeyboardProvider KeyboardProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782197, XrefRangeEnd = 782201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_KeyboardProvider_Public_Static_get_IKeyboardProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyboardProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782201, XrefRangeEnd = 782207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_KeyboardProvider_Private_Static_set_Void_IKeyboardProvider_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0001D7EC File Offset: 0x0001B9EC
		public unsafe static string Platform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782207, XrefRangeEnd = 782211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_Platform_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782211, XrefRangeEnd = 782217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_Platform_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001D824 File Offset: 0x0001BA24
		public unsafe static bool MenuWasPressed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782217, XrefRangeEnd = 782225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_MenuWasPressed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001D854 File Offset: 0x0001BA54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 782372, RefRangeEnd = 782374, XrefRangeStart = 782225, XrefRangeEnd = 782372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetupInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_SetupInternal_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001D884 File Offset: 0x0001BA84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 782469, RefRangeEnd = 782472, XrefRangeStart = 782374, XrefRangeEnd = 782469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_ResetInternal_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001D8AC File Offset: 0x0001BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782472, XrefRangeEnd = 782529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Update_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001D8D4 File Offset: 0x0001BAD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 782664, RefRangeEnd = 782669, XrefRangeStart = 782529, XrefRangeEnd = 782664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdateInternal_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001D8FC File Offset: 0x0001BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782669, XrefRangeEnd = 782674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reload()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_Reload_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001D924 File Offset: 0x0001BB24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 782681, RefRangeEnd = 782684, XrefRangeStart = 782674, XrefRangeEnd = 782681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssertIsSetup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_AssertIsSetup_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001D94C File Offset: 0x0001BB4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 782703, RefRangeEnd = 782707, XrefRangeStart = 782684, XrefRangeEnd = 782703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZeroTickOnAllControls()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_SetZeroTickOnAllControls_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001D974 File Offset: 0x0001BB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 782740, RefRangeEnd = 782742, XrefRangeStart = 782707, XrefRangeEnd = 782740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearInputState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_ClearInputState_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001D99C File Offset: 0x0001BB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782758, RefRangeEnd = 782759, XrefRangeStart = 782742, XrefRangeEnd = 782758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnApplicationFocus(bool focusState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focusState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnApplicationFocus_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnApplicationPause(bool pauseState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnApplicationPause_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001DA04 File Offset: 0x0001BC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782763, RefRangeEnd = 782764, XrefRangeStart = 782759, XrefRangeEnd = 782763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnApplicationQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnApplicationQuit_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001DA2C File Offset: 0x0001BC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782769, RefRangeEnd = 782770, XrefRangeStart = 782764, XrefRangeEnd = 782769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnLevelWasLoaded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnLevelWasLoaded_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0001DA54 File Offset: 0x0001BC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782800, RefRangeEnd = 782801, XrefRangeStart = 782770, XrefRangeEnd = 782800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddDeviceManager(InputDeviceManager deviceManager)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deviceManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_InputDeviceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 782807, RefRangeEnd = 782809, XrefRangeStart = 782801, XrefRangeEnd = 782807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddDeviceManager<T>() where T : InputDeviceManager, new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.MethodInfoStoreGeneric_AddDeviceManager_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782809, XrefRangeEnd = 782821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetDeviceManager<T>() where T : InputDeviceManager
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.MethodInfoStoreGeneric_GetDeviceManager_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782821, XrefRangeEnd = 782834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasDeviceManager<T>() where T : InputDeviceManager
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.MethodInfoStoreGeneric_HasDeviceManager_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001DB14 File Offset: 0x0001BD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782834, XrefRangeEnd = 782846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCurrentTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdateCurrentTime_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001DB3C File Offset: 0x0001BD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782846, XrefRangeEnd = 782859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateDeviceManagers(float deltaTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdateDeviceManagers_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001DB70 File Offset: 0x0001BD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782859, XrefRangeEnd = 782879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyDeviceManagers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_DestroyDeviceManagers_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001DB98 File Offset: 0x0001BD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782879, XrefRangeEnd = 782903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyDevices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_DestroyDevices_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001DBC0 File Offset: 0x0001BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782903, XrefRangeEnd = 782919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateDevices(float deltaTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdateDevices_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782919, XrefRangeEnd = 782940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CommitDevices(float deltaTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_CommitDevices_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 782973, RefRangeEnd = 782974, XrefRangeStart = 782940, XrefRangeEnd = 782973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateActiveDevice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdateActiveDevice_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001DC50 File Offset: 0x0001BE50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 783015, RefRangeEnd = 783021, XrefRangeStart = 782974, XrefRangeEnd = 783015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AttachDevice(InputDevice inputDevice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_AttachDevice_Public_Static_Void_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 783048, RefRangeEnd = 783051, XrefRangeStart = 783021, XrefRangeEnd = 783048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DetachDevice(InputDevice inputDevice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_DetachDevice_Public_Static_Void_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 783061, RefRangeEnd = 783068, XrefRangeStart = 783051, XrefRangeEnd = 783061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HideDevicesWithProfile(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_HideDevicesWithProfile_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 783081, RefRangeEnd = 783082, XrefRangeStart = 783068, XrefRangeEnd = 783081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AttachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerActionSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_AttachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 783090, RefRangeEnd = 783091, XrefRangeStart = 783082, XrefRangeEnd = 783090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DetachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerActionSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_DetachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001DD68 File Offset: 0x0001BF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783091, XrefRangeEnd = 783105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdatePlayerActionSets(float deltaTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UpdatePlayerActionSets_Internal_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001DD9C File Offset: 0x0001BF9C
		public unsafe static bool AnyKeyIsPressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 783109, RefRangeEnd = 783110, XrefRangeStart = 783105, XrefRangeEnd = 783109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_AnyKeyIsPressed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0001DE00 File Offset: 0x0001C000
		public unsafe static InputDevice ActiveDevice
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 783118, RefRangeEnd = 783143, XrefRangeStart = 783110, XrefRangeEnd = 783118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_ActiveDevice_Public_Static_get_InputDevice_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 783153, RefRangeEnd = 783156, XrefRangeStart = 783143, XrefRangeEnd = 783153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_ActiveDevice_Private_Static_set_Void_InputDevice_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001DE38 File Offset: 0x0001C038
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0001DE68 File Offset: 0x0001C068
		public unsafe static bool Enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783156, XrefRangeEnd = 783160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 783174, RefRangeEnd = 783175, XrefRangeStart = 783160, XrefRangeEnd = 783174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_Enabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001DE9C File Offset: 0x0001C09C
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0001DECC File Offset: 0x0001C0CC
		public unsafe static bool SuspendInBackground
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783175, XrefRangeEnd = 783179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_SuspendInBackground_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783179, XrefRangeEnd = 783183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_SuspendInBackground_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001DF00 File Offset: 0x0001C100
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0001DF30 File Offset: 0x0001C130
		public unsafe static bool EnableNativeInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783183, XrefRangeEnd = 783187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_EnableNativeInput_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783187, XrefRangeEnd = 783191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_EnableNativeInput_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001DF64 File Offset: 0x0001C164
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0001DF94 File Offset: 0x0001C194
		public unsafe static bool EnableXInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783191, XrefRangeEnd = 783195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_EnableXInput_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783195, XrefRangeEnd = 783199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_EnableXInput_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
		public unsafe static uint XInputUpdateRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783199, XrefRangeEnd = 783203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_XInputUpdateRate_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783203, XrefRangeEnd = 783207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_XInputUpdateRate_Internal_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001E02C File Offset: 0x0001C22C
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0001E05C File Offset: 0x0001C25C
		public unsafe static uint XInputBufferSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783207, XrefRangeEnd = 783211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_XInputBufferSize_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783211, XrefRangeEnd = 783215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_XInputBufferSize_Internal_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001E090 File Offset: 0x0001C290
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		public unsafe static bool NativeInputEnableXInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783215, XrefRangeEnd = 783219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_NativeInputEnableXInput_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783219, XrefRangeEnd = 783223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_NativeInputEnableXInput_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0001E124 File Offset: 0x0001C324
		public unsafe static bool NativeInputEnableMFi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783223, XrefRangeEnd = 783227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_NativeInputEnableMFi_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783227, XrefRangeEnd = 783231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_NativeInputEnableMFi_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001E158 File Offset: 0x0001C358
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0001E188 File Offset: 0x0001C388
		public unsafe static bool NativeInputPreventSleep
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783231, XrefRangeEnd = 783235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_NativeInputPreventSleep_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783235, XrefRangeEnd = 783239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_NativeInputPreventSleep_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		public unsafe static uint NativeInputUpdateRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783239, XrefRangeEnd = 783243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_NativeInputUpdateRate_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783243, XrefRangeEnd = 783247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_NativeInputUpdateRate_Internal_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001E220 File Offset: 0x0001C420
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x0001E250 File Offset: 0x0001C450
		public unsafe static bool EnableICade
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783247, XrefRangeEnd = 783251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_EnableICade_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783251, XrefRangeEnd = 783255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_set_EnableICade_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001E284 File Offset: 0x0001C484
		public unsafe static VersionInfo UnityVersion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 783273, RefRangeEnd = 783275, XrefRangeStart = 783255, XrefRangeEnd = 783273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_UnityVersion_Internal_Static_get_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001E2B4 File Offset: 0x0001C4B4
		public unsafe static ulong CurrentTick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783275, XrefRangeEnd = 783279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_CurrentTick_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		public unsafe static float CurrentTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783279, XrefRangeEnd = 783283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000043BD File Offset: 0x000025BD
		public InputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001E314 File Offset: 0x0001C514
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x000043C6 File Offset: 0x000025C6
		public unsafe static VersionInfo Version
		{
			get
			{
				VersionInfo versionInfo;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_Version, (void*)(&versionInfo));
				return versionInfo;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_Version, (void*)(&value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001E330 File Offset: 0x0001C530
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000043D4 File Offset: 0x000025D4
		public unsafe static Action OnSetup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnSetup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnSetup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001E358 File Offset: 0x0001C558
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x000043E6 File Offset: 0x000025E6
		public unsafe static Action<ulong, float> OnUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ulong, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001E380 File Offset: 0x0001C580
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000043F8 File Offset: 0x000025F8
		public unsafe static Action OnReset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnReset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnReset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0000440A File Offset: 0x0000260A
		public unsafe static Action<InputDevice> OnDeviceAttached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnDeviceAttached, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnDeviceAttached, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001E3D0 File Offset: 0x0001C5D0
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0000441C File Offset: 0x0000261C
		public unsafe static Action<InputDevice> OnDeviceDetached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnDeviceDetached, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnDeviceDetached, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0000442E File Offset: 0x0000262E
		public unsafe static Action<InputDevice> OnActiveDeviceChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnActiveDeviceChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnActiveDeviceChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001E420 File Offset: 0x0001C620
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00004440 File Offset: 0x00002640
		public unsafe static Action<ulong, float> OnUpdateDevices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnUpdateDevices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ulong, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnUpdateDevices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001E448 File Offset: 0x0001C648
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00004452 File Offset: 0x00002652
		public unsafe static Action<ulong, float> OnCommitDevices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_OnCommitDevices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ulong, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_OnCommitDevices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001E470 File Offset: 0x0001C670
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00004464 File Offset: 0x00002664
		public unsafe static List<InputDeviceManager> deviceManagers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_deviceManagers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDeviceManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_deviceManagers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001E498 File Offset: 0x0001C698
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00004476 File Offset: 0x00002676
		public unsafe static Dictionary<Type, InputDeviceManager> deviceManagerTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_deviceManagerTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, InputDeviceManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_deviceManagerTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001E4C0 File Offset: 0x0001C6C0
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00004488 File Offset: 0x00002688
		public unsafe static List<InputDevice> devices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_devices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_devices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001E4E8 File Offset: 0x0001C6E8
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0000449A File Offset: 0x0000269A
		public unsafe static InputDevice activeDevice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_activeDevice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_activeDevice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001E510 File Offset: 0x0001C710
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x000044AC File Offset: 0x000026AC
		public unsafe static List<InputDevice> activeDevices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_activeDevices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_activeDevices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001E538 File Offset: 0x0001C738
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x000044BE File Offset: 0x000026BE
		public unsafe static List<PlayerActionSet> playerActionSets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_playerActionSets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerActionSet>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_playerActionSets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001E560 File Offset: 0x0001C760
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x000044D0 File Offset: 0x000026D0
		public unsafe static ReadOnlyCollection<InputDevice> Devices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_Devices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_Devices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001E588 File Offset: 0x0001C788
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000044E2 File Offset: 0x000026E2
		public unsafe static ReadOnlyCollection<InputDevice> ActiveDevices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_ActiveDevices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_ActiveDevices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001E5B0 File Offset: 0x0001C7B0
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x000044F4 File Offset: 0x000026F4
		public unsafe static bool _CommandWasPressed_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__CommandWasPressed_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__CommandWasPressed_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001E5CC File Offset: 0x0001C7CC
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00004502 File Offset: 0x00002702
		public unsafe static bool _InvertYAxis_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__InvertYAxis_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__InvertYAxis_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00004510 File Offset: 0x00002710
		public unsafe static bool _IsSetup_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__IsSetup_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__IsSetup_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0001E604 File Offset: 0x0001C804
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0000451E File Offset: 0x0000271E
		public unsafe static IMouseProvider _MouseProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__MouseProvider_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMouseProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__MouseProvider_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001E62C File Offset: 0x0001C82C
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00004530 File Offset: 0x00002730
		public unsafe static IKeyboardProvider _KeyboardProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__KeyboardProvider_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IKeyboardProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__KeyboardProvider_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001E654 File Offset: 0x0001C854
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00004542 File Offset: 0x00002742
		public unsafe static string _Platform_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__Platform_k__BackingField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__Platform_k__BackingField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0001E674 File Offset: 0x0001C874
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00004554 File Offset: 0x00002754
		public unsafe static bool applicationIsFocused
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_applicationIsFocused, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_applicationIsFocused, (void*)(&value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001E690 File Offset: 0x0001C890
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00004562 File Offset: 0x00002762
		public unsafe static float initialTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_initialTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_initialTime, (void*)(&value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001E6AC File Offset: 0x0001C8AC
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00004570 File Offset: 0x00002770
		public unsafe static float currentTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_currentTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_currentTime, (void*)(&value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001E6C8 File Offset: 0x0001C8C8
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0000457E File Offset: 0x0000277E
		public unsafe static float lastUpdateTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_lastUpdateTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_lastUpdateTime, (void*)(&value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x0000458C File Offset: 0x0000278C
		public unsafe static ulong currentTick
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_currentTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_currentTick, (void*)(&value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001E700 File Offset: 0x0001C900
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x0000459A File Offset: 0x0000279A
		public unsafe static Nullable<VersionInfo> unityVersion
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<VersionInfo>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_unityVersion, intPtr);
				return new Nullable<VersionInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<VersionInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_unityVersion, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001E73C File Offset: 0x0001C93C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000045B1 File Offset: 0x000027B1
		public unsafe static bool enabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr_enabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr_enabled, (void*)(&value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001E758 File Offset: 0x0001C958
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x000045BF File Offset: 0x000027BF
		public unsafe static bool _SuspendInBackground_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__SuspendInBackground_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__SuspendInBackground_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001E774 File Offset: 0x0001C974
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000045CD File Offset: 0x000027CD
		public unsafe static bool _EnableNativeInput_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__EnableNativeInput_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__EnableNativeInput_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001E790 File Offset: 0x0001C990
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x000045DB File Offset: 0x000027DB
		public unsafe static bool _EnableXInput_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__EnableXInput_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__EnableXInput_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001E7AC File Offset: 0x0001C9AC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x000045E9 File Offset: 0x000027E9
		public unsafe static uint _XInputUpdateRate_k__BackingField
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__XInputUpdateRate_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__XInputUpdateRate_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x000045F7 File Offset: 0x000027F7
		public unsafe static uint _XInputBufferSize_k__BackingField
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__XInputBufferSize_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__XInputBufferSize_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00004605 File Offset: 0x00002805
		public unsafe static bool _NativeInputEnableXInput_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__NativeInputEnableXInput_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__NativeInputEnableXInput_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001E800 File Offset: 0x0001CA00
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004613 File Offset: 0x00002813
		public unsafe static bool _NativeInputEnableMFi_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__NativeInputEnableMFi_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__NativeInputEnableMFi_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001E81C File Offset: 0x0001CA1C
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00004621 File Offset: 0x00002821
		public unsafe static bool _NativeInputPreventSleep_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__NativeInputPreventSleep_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__NativeInputPreventSleep_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001E838 File Offset: 0x0001CA38
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0000462F File Offset: 0x0000282F
		public unsafe static uint _NativeInputUpdateRate_k__BackingField
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__NativeInputUpdateRate_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__NativeInputUpdateRate_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001E854 File Offset: 0x0001CA54
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0000463D File Offset: 0x0000283D
		public unsafe static bool _EnableICade_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputManager.NativeFieldInfoPtr__EnableICade_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputManager.NativeFieldInfoPtr__EnableICade_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_OnSetup;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_OnUpdate;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_OnReset;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_OnDeviceAttached;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_OnDeviceDetached;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_OnActiveDeviceChanged;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_OnUpdateDevices;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_OnCommitDevices;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_deviceManagers;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_deviceManagerTable;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_devices;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_activeDevice;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_activeDevices;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_playerActionSets;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_Devices;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDevices;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr__CommandWasPressed_k__BackingField;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr__InvertYAxis_k__BackingField;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr__IsSetup_k__BackingField;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr__MouseProvider_k__BackingField;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr__KeyboardProvider_k__BackingField;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr__Platform_k__BackingField;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_applicationIsFocused;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_initialTime;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_currentTime;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_lastUpdateTime;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_currentTick;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_unityVersion;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr__SuspendInBackground_k__BackingField;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr__EnableNativeInput_k__BackingField;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr__EnableXInput_k__BackingField;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr__XInputUpdateRate_k__BackingField;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr__XInputBufferSize_k__BackingField;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr__NativeInputEnableXInput_k__BackingField;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr__NativeInputEnableMFi_k__BackingField;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr__NativeInputPreventSleep_k__BackingField;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr__NativeInputUpdateRate_k__BackingField;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr__EnableICade_k__BackingField;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSetup_Public_Static_add_Void_Action_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSetup_Public_Static_rem_Void_Action_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUpdate_Public_Static_add_Void_Action_2_UInt64_Single_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpdate_Public_Static_rem_Void_Action_2_UInt64_Single_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_add_OnReset_Public_Static_add_Void_Action_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnReset_Public_Static_rem_Void_Action_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDeviceAttached_Public_Static_add_Void_Action_1_InputDevice_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeviceAttached_Public_Static_rem_Void_Action_1_InputDevice_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDeviceDetached_Public_Static_add_Void_Action_1_InputDevice_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeviceDetached_Public_Static_rem_Void_Action_1_InputDevice_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActiveDeviceChanged_Public_Static_add_Void_Action_1_InputDevice_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActiveDeviceChanged_Public_Static_rem_Void_Action_1_InputDevice_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUpdateDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpdateDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCommitDevices_Internal_Static_add_Void_Action_2_UInt64_Single_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCommitDevices_Internal_Static_rem_Void_Action_2_UInt64_Single_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandWasPressed_Public_Static_get_Boolean_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_set_CommandWasPressed_Private_Static_set_Void_Boolean_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertYAxis_Public_Static_get_Boolean_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertYAxis_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSetup_Public_Static_get_Boolean_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSetup_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseProvider_Public_Static_get_IMouseProvider_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_set_MouseProvider_Private_Static_set_Void_IMouseProvider_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyboardProvider_Public_Static_get_IKeyboardProvider_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyboardProvider_Private_Static_set_Void_IKeyboardProvider_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Internal_Static_get_String_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_set_Platform_Private_Static_set_Void_String_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuWasPressed_Public_Static_get_Boolean_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_SetupInternal_Internal_Static_Boolean_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_ResetInternal_Internal_Static_Void_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInternal_Internal_Static_Void_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Static_Void_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_AssertIsSetup_Private_Static_Void_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_SetZeroTickOnAllControls_Private_Static_Void_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Static_Void_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Internal_Static_Void_Boolean_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Internal_Static_Void_Boolean_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Internal_Static_Void_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_OnLevelWasLoaded_Internal_Static_Void_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_InputDeviceManager_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceManager_Public_Static_T_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_HasDeviceManager_Public_Static_Boolean_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentTime_Private_Static_Void_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeviceManagers_Private_Static_Void_Single_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDeviceManagers_Private_Static_Void_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDevices_Private_Static_Void_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDevices_Private_Static_Void_Single_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_CommitDevices_Private_Static_Void_Single_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveDevice_Private_Static_Void_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_AttachDevice_Public_Static_Void_InputDevice_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_DetachDevice_Public_Static_Void_InputDevice_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_HideDevicesWithProfile_Public_Static_Void_Type_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_AttachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_DetachPlayerActionSet_Internal_Static_Void_PlayerActionSet_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerActionSets_Internal_Static_Void_Single_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyKeyIsPressed_Public_Static_get_Boolean_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDevice_Public_Static_get_InputDevice_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDevice_Private_Static_set_Void_InputDevice_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_SuspendInBackground_Public_Static_get_Boolean_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_set_SuspendInBackground_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableNativeInput_Public_Static_get_Boolean_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableNativeInput_Internal_Static_set_Void_Boolean_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableXInput_Public_Static_get_Boolean_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableXInput_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_get_XInputUpdateRate_Public_Static_get_UInt32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_set_XInputUpdateRate_Internal_Static_set_Void_UInt32_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_get_XInputBufferSize_Public_Static_get_UInt32_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_set_XInputBufferSize_Internal_Static_set_Void_UInt32_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInputEnableXInput_Public_Static_get_Boolean_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_set_NativeInputEnableXInput_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInputEnableMFi_Public_Static_get_Boolean_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_set_NativeInputEnableMFi_Internal_Static_set_Void_Boolean_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInputPreventSleep_Public_Static_get_Boolean_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_set_NativeInputPreventSleep_Internal_Static_set_Void_Boolean_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInputUpdateRate_Public_Static_get_UInt32_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_set_NativeInputUpdateRate_Internal_Static_set_Void_UInt32_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableICade_Public_Static_get_Boolean_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableICade_Internal_Static_set_Void_Boolean_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityVersion_Internal_Static_get_VersionInfo_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTick_Public_Static_get_UInt64_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0;

		// Token: 0x02000213 RID: 531
		[ObfuscatedName("InControl.InputManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001180 RID: 4480 RVA: 0x00044C88 File Offset: 0x00042E88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr);
				InputManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr, "<>9");
				InputManager.__c.NativeFieldInfoPtr___9__88_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr, "<>9__88_0");
				InputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr, 100664149);
				InputManager.__c.NativeMethodInfoPtr__AttachDevice_b__88_0_Internal_Int32_InputDevice_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr, 100664150);
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x00044D04 File Offset: 0x00042F04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001182 RID: 4482 RVA: 0x00044D40 File Offset: 0x00042F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 781950, XrefRangeEnd = 781951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AttachDevice_b__88_0(InputDevice d1, InputDevice d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputManager.__c.NativeMethodInfoPtr__AttachDevice_b__88_0_Internal_Int32_InputDevice_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001183 RID: 4483 RVA: 0x0000708E File Offset: 0x0000528E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06001184 RID: 4484 RVA: 0x00044DA0 File Offset: 0x00042FA0
			// (set) Token: 0x06001185 RID: 4485 RVA: 0x00007097 File Offset: 0x00005297
			public unsafe static InputManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06001186 RID: 4486 RVA: 0x00044DC8 File Offset: 0x00042FC8
			// (set) Token: 0x06001187 RID: 4487 RVA: 0x000070A9 File Offset: 0x000052A9
			public unsafe static Comparison<InputDevice> __9__88_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputManager.__c.NativeFieldInfoPtr___9__88_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<InputDevice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputManager.__c.NativeFieldInfoPtr___9__88_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D94 RID: 3476
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000D95 RID: 3477
			private static readonly IntPtr NativeFieldInfoPtr___9__88_0;

			// Token: 0x04000D96 RID: 3478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000D97 RID: 3479
			private static readonly IntPtr NativeMethodInfoPtr__AttachDevice_b__88_0_Internal_Int32_InputDevice_InputDevice_0;
		}

		// Token: 0x02000214 RID: 532
		private sealed class MethodInfoStoreGeneric_AddDeviceManager_Public_Static_Void_0<T>
		{
			// Token: 0x04000D98 RID: 3480
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputManager.NativeMethodInfoPtr_AddDeviceManager_Public_Static_Void_0, Il2CppClassPointerStore<InputManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000215 RID: 533
		private sealed class MethodInfoStoreGeneric_GetDeviceManager_Public_Static_T_0<T>
		{
			// Token: 0x04000D99 RID: 3481
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputManager.NativeMethodInfoPtr_GetDeviceManager_Public_Static_T_0, Il2CppClassPointerStore<InputManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000216 RID: 534
		private sealed class MethodInfoStoreGeneric_HasDeviceManager_Public_Static_Boolean_0<T>
		{
			// Token: 0x04000D9A RID: 3482
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputManager.NativeMethodInfoPtr_HasDeviceManager_Public_Static_Boolean_0, Il2CppClassPointerStore<InputManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
