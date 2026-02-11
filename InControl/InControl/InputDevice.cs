using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000034 RID: 52
	public class InputDevice : global::Il2CppSystem.Object
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00014FE0 File Offset: 0x000131E0
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevice()
		{
			Il2CppClassPointerStore<InputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice>.NativeClassPtr);
			InputDevice.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "Null");
			InputDevice.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<Name>k__BackingField");
			InputDevice.NativeFieldInfoPtr__Meta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<Meta>k__BackingField");
			InputDevice.NativeFieldInfoPtr__SortOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<SortOrder>k__BackingField");
			InputDevice.NativeFieldInfoPtr__DeviceClass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<DeviceClass>k__BackingField");
			InputDevice.NativeFieldInfoPtr__DeviceStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<DeviceStyle>k__BackingField");
			InputDevice.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<GUID>k__BackingField");
			InputDevice.NativeFieldInfoPtr__LastInputTick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<LastInputTick>k__BackingField");
			InputDevice.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<IsActive>k__BackingField");
			InputDevice.NativeFieldInfoPtr__IsAttached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<IsAttached>k__BackingField");
			InputDevice.NativeFieldInfoPtr__RawSticks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<RawSticks>k__BackingField");
			InputDevice.NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "controls");
			InputDevice.NativeFieldInfoPtr__Controls_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<Controls>k__BackingField");
			InputDevice.NativeFieldInfoPtr__ControlsByTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<ControlsByTarget>k__BackingField");
			InputDevice.NativeFieldInfoPtr__LeftStick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<LeftStick>k__BackingField");
			InputDevice.NativeFieldInfoPtr__RightStick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<RightStick>k__BackingField");
			InputDevice.NativeFieldInfoPtr__DPad_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<DPad>k__BackingField");
			InputDevice.NativeFieldInfoPtr_hasLeftCommandControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "hasLeftCommandControl");
			InputDevice.NativeFieldInfoPtr_leftCommandSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "leftCommandSource");
			InputDevice.NativeFieldInfoPtr__LeftCommandControl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<LeftCommandControl>k__BackingField");
			InputDevice.NativeFieldInfoPtr_hasRightCommandControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "hasRightCommandControl");
			InputDevice.NativeFieldInfoPtr_rightCommandSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "rightCommandSource");
			InputDevice.NativeFieldInfoPtr__RightCommandControl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<RightCommandControl>k__BackingField");
			InputDevice.NativeFieldInfoPtr_Passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "Passive");
			InputDevice.NativeFieldInfoPtr__AnalogSnapshot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "<AnalogSnapshot>k__BackingField");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickUp");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickDown");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickLeft");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickRight");
			InputDevice.NativeFieldInfoPtr_cachedRightStickUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickUp");
			InputDevice.NativeFieldInfoPtr_cachedRightStickDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickDown");
			InputDevice.NativeFieldInfoPtr_cachedRightStickLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickLeft");
			InputDevice.NativeFieldInfoPtr_cachedRightStickRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickRight");
			InputDevice.NativeFieldInfoPtr_cachedDPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadUp");
			InputDevice.NativeFieldInfoPtr_cachedDPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadDown");
			InputDevice.NativeFieldInfoPtr_cachedDPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadLeft");
			InputDevice.NativeFieldInfoPtr_cachedDPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadRight");
			InputDevice.NativeFieldInfoPtr_cachedAction1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedAction1");
			InputDevice.NativeFieldInfoPtr_cachedAction2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedAction2");
			InputDevice.NativeFieldInfoPtr_cachedAction3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedAction3");
			InputDevice.NativeFieldInfoPtr_cachedAction4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedAction4");
			InputDevice.NativeFieldInfoPtr_cachedLeftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftTrigger");
			InputDevice.NativeFieldInfoPtr_cachedRightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightTrigger");
			InputDevice.NativeFieldInfoPtr_cachedLeftBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftBumper");
			InputDevice.NativeFieldInfoPtr_cachedRightBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightBumper");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickButton");
			InputDevice.NativeFieldInfoPtr_cachedRightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickButton");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickX");
			InputDevice.NativeFieldInfoPtr_cachedLeftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftStickY");
			InputDevice.NativeFieldInfoPtr_cachedRightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickX");
			InputDevice.NativeFieldInfoPtr_cachedRightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightStickY");
			InputDevice.NativeFieldInfoPtr_cachedDPadX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadX");
			InputDevice.NativeFieldInfoPtr_cachedDPadY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedDPadY");
			InputDevice.NativeFieldInfoPtr_cachedCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedCommand");
			InputDevice.NativeFieldInfoPtr_cachedLeftCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedLeftCommand");
			InputDevice.NativeFieldInfoPtr_cachedRightCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "cachedRightCommand");
			InputDevice.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663794);
			InputDevice.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663795);
			InputDevice.NativeMethodInfoPtr_get_Meta_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663796);
			InputDevice.NativeMethodInfoPtr_set_Meta_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663797);
			InputDevice.NativeMethodInfoPtr_get_SortOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663798);
			InputDevice.NativeMethodInfoPtr_set_SortOrder_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663799);
			InputDevice.NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663800);
			InputDevice.NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663801);
			InputDevice.NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663802);
			InputDevice.NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663803);
			InputDevice.NativeMethodInfoPtr_get_GUID_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663804);
			InputDevice.NativeMethodInfoPtr_set_GUID_Private_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663805);
			InputDevice.NativeMethodInfoPtr_get_LastInputTick_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663806);
			InputDevice.NativeMethodInfoPtr_set_LastInputTick_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663807);
			InputDevice.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663808);
			InputDevice.NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663809);
			InputDevice.NativeMethodInfoPtr_get_IsAttached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663810);
			InputDevice.NativeMethodInfoPtr_set_IsAttached_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663811);
			InputDevice.NativeMethodInfoPtr_get_RawSticks_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663812);
			InputDevice.NativeMethodInfoPtr_set_RawSticks_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663813);
			InputDevice.NativeMethodInfoPtr_get_Controls_Public_get_ReadOnlyCollection_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663814);
			InputDevice.NativeMethodInfoPtr_set_Controls_Protected_set_Void_ReadOnlyCollection_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663815);
			InputDevice.NativeMethodInfoPtr_get_ControlsByTarget_Protected_get_Il2CppReferenceArray_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663816);
			InputDevice.NativeMethodInfoPtr_set_ControlsByTarget_Private_set_Void_Il2CppReferenceArray_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663817);
			InputDevice.NativeMethodInfoPtr_get_LeftStick_Public_get_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663818);
			InputDevice.NativeMethodInfoPtr_set_LeftStick_Private_set_Void_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663819);
			InputDevice.NativeMethodInfoPtr_get_RightStick_Public_get_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663820);
			InputDevice.NativeMethodInfoPtr_set_RightStick_Private_set_Void_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663821);
			InputDevice.NativeMethodInfoPtr_get_DPad_Public_get_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663822);
			InputDevice.NativeMethodInfoPtr_set_DPad_Private_set_Void_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663823);
			InputDevice.NativeMethodInfoPtr_get_LeftCommandControl_Public_get_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663824);
			InputDevice.NativeMethodInfoPtr_set_LeftCommandControl_Private_set_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663825);
			InputDevice.NativeMethodInfoPtr_get_RightCommandControl_Public_get_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663826);
			InputDevice.NativeMethodInfoPtr_set_RightCommandControl_Private_set_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663827);
			InputDevice.NativeMethodInfoPtr_get_AnalogSnapshot_Protected_get_Il2CppStructArray_1_AnalogSnapshotEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663828);
			InputDevice.NativeMethodInfoPtr_set_AnalogSnapshot_Protected_set_Void_Il2CppStructArray_1_AnalogSnapshotEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663829);
			InputDevice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663830);
			InputDevice.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663831);
			InputDevice.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663832);
			InputDevice.NativeMethodInfoPtr_OnAttached_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663833);
			InputDevice.NativeMethodInfoPtr_OnDetached_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663834);
			InputDevice.NativeMethodInfoPtr_AddAliasControls_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663835);
			InputDevice.NativeMethodInfoPtr_RemoveAliasControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663836);
			InputDevice.NativeMethodInfoPtr_ClearControls_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663837);
			InputDevice.NativeMethodInfoPtr_HasControl_Public_Boolean_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663838);
			InputDevice.NativeMethodInfoPtr_GetControl_Public_InputControl_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663839);
			InputDevice.NativeMethodInfoPtr_get_Item_Public_get_InputControl_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663840);
			InputDevice.NativeMethodInfoPtr_GetInputControlTypeByName_Public_Static_InputControlType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663841);
			InputDevice.NativeMethodInfoPtr_GetControlByName_Public_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663842);
			InputDevice.NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663843);
			InputDevice.NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663844);
			InputDevice.NativeMethodInfoPtr_RemoveControl_Private_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663845);
			InputDevice.NativeMethodInfoPtr_ClearInputState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663846);
			InputDevice.NativeMethodInfoPtr_UpdateWithState_Protected_Void_InputControlType_Boolean_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663847);
			InputDevice.NativeMethodInfoPtr_UpdateWithValue_Protected_Void_InputControlType_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663848);
			InputDevice.NativeMethodInfoPtr_UpdateWithRawValue_Protected_Void_InputControlType_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663849);
			InputDevice.NativeMethodInfoPtr_UpdateLeftStickWithValue_Public_Void_Vector2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663850);
			InputDevice.NativeMethodInfoPtr_UpdateLeftStickWithRawValue_Public_Void_Vector2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663851);
			InputDevice.NativeMethodInfoPtr_CommitLeftStick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663852);
			InputDevice.NativeMethodInfoPtr_UpdateRightStickWithValue_Public_Void_Vector2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663853);
			InputDevice.NativeMethodInfoPtr_UpdateRightStickWithRawValue_Public_Void_Vector2_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663854);
			InputDevice.NativeMethodInfoPtr_CommitRightStick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663855);
			InputDevice.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663856);
			InputDevice.NativeMethodInfoPtr_ProcessLeftStick_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663857);
			InputDevice.NativeMethodInfoPtr_ProcessRightStick_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663858);
			InputDevice.NativeMethodInfoPtr_ProcessDPad_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663859);
			InputDevice.NativeMethodInfoPtr_Commit_Public_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663860);
			InputDevice.NativeMethodInfoPtr_LastInputAfter_Public_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663861);
			InputDevice.NativeMethodInfoPtr_RequestActivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663862);
			InputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663863);
			InputDevice.NativeMethodInfoPtr_Vibrate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663864);
			InputDevice.NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663865);
			InputDevice.NativeMethodInfoPtr_StopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663866);
			InputDevice.NativeMethodInfoPtr_SetLightColor_Public_Virtual_New_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663867);
			InputDevice.NativeMethodInfoPtr_SetLightColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663868);
			InputDevice.NativeMethodInfoPtr_SetLightFlash_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663869);
			InputDevice.NativeMethodInfoPtr_StopLightFlash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663870);
			InputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663871);
			InputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663872);
			InputDevice.NativeMethodInfoPtr_get_IsUnknown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663873);
			InputDevice.NativeMethodInfoPtr_get_MenuIsPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663874);
			InputDevice.NativeMethodInfoPtr_get_MenuWasPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663875);
			InputDevice.NativeMethodInfoPtr_get_MenuWasReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663876);
			InputDevice.NativeMethodInfoPtr_get_CommandIsPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663877);
			InputDevice.NativeMethodInfoPtr_get_CommandWasPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663878);
			InputDevice.NativeMethodInfoPtr_get_CommandWasReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663879);
			InputDevice.NativeMethodInfoPtr_get_AnyButton_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663880);
			InputDevice.NativeMethodInfoPtr_get_AnyButtonIsPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663881);
			InputDevice.NativeMethodInfoPtr_get_AnyButtonWasPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663882);
			InputDevice.NativeMethodInfoPtr_get_AnyButtonWasReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663883);
			InputDevice.NativeMethodInfoPtr_get_Direction_Public_get_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663884);
			InputDevice.NativeMethodInfoPtr_get_LeftStickUp_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663885);
			InputDevice.NativeMethodInfoPtr_get_LeftStickDown_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663886);
			InputDevice.NativeMethodInfoPtr_get_LeftStickLeft_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663887);
			InputDevice.NativeMethodInfoPtr_get_LeftStickRight_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663888);
			InputDevice.NativeMethodInfoPtr_get_RightStickUp_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663889);
			InputDevice.NativeMethodInfoPtr_get_RightStickDown_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663890);
			InputDevice.NativeMethodInfoPtr_get_RightStickLeft_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663891);
			InputDevice.NativeMethodInfoPtr_get_RightStickRight_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663892);
			InputDevice.NativeMethodInfoPtr_get_DPadUp_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663893);
			InputDevice.NativeMethodInfoPtr_get_DPadDown_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663894);
			InputDevice.NativeMethodInfoPtr_get_DPadLeft_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663895);
			InputDevice.NativeMethodInfoPtr_get_DPadRight_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663896);
			InputDevice.NativeMethodInfoPtr_get_Action1_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663897);
			InputDevice.NativeMethodInfoPtr_get_Action2_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663898);
			InputDevice.NativeMethodInfoPtr_get_Action3_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663899);
			InputDevice.NativeMethodInfoPtr_get_Action4_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663900);
			InputDevice.NativeMethodInfoPtr_get_LeftTrigger_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663901);
			InputDevice.NativeMethodInfoPtr_get_RightTrigger_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663902);
			InputDevice.NativeMethodInfoPtr_get_LeftBumper_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663903);
			InputDevice.NativeMethodInfoPtr_get_RightBumper_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663904);
			InputDevice.NativeMethodInfoPtr_get_LeftStickButton_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663905);
			InputDevice.NativeMethodInfoPtr_get_RightStickButton_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663906);
			InputDevice.NativeMethodInfoPtr_get_LeftStickX_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663907);
			InputDevice.NativeMethodInfoPtr_get_LeftStickY_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663908);
			InputDevice.NativeMethodInfoPtr_get_RightStickX_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663909);
			InputDevice.NativeMethodInfoPtr_get_RightStickY_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663910);
			InputDevice.NativeMethodInfoPtr_get_DPadX_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663911);
			InputDevice.NativeMethodInfoPtr_get_DPadY_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663912);
			InputDevice.NativeMethodInfoPtr_get_Command_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663913);
			InputDevice.NativeMethodInfoPtr_get_LeftCommand_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663914);
			InputDevice.NativeMethodInfoPtr_get_RightCommand_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663915);
			InputDevice.NativeMethodInfoPtr_ExpireControlCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663916);
			InputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663917);
			InputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663918);
			InputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663919);
			InputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663920);
			InputDevice.NativeMethodInfoPtr_TakeSnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663921);
			InputDevice.NativeMethodInfoPtr_GetFirstPressedAnalog_Public_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663922);
			InputDevice.NativeMethodInfoPtr_GetFirstPressedButton_Public_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663923);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00015E98 File Offset: 0x00014098
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00015ED0 File Offset: 0x000140D0
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00015F14 File Offset: 0x00014114
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00015F4C File Offset: 0x0001414C
		public unsafe string Meta
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Meta_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_Meta_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00015F90 File Offset: 0x00014190
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00015FCC File Offset: 0x000141CC
		public unsafe int SortOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_SortOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_SortOrder_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0001600C File Offset: 0x0001420C
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00016048 File Offset: 0x00014248
		public unsafe InputDeviceClass DeviceClass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00016088 File Offset: 0x00014288
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000160C4 File Offset: 0x000142C4
		public unsafe InputDeviceStyle DeviceStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00016104 File Offset: 0x00014304
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00016140 File Offset: 0x00014340
		public unsafe Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_GUID_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_GUID_Private_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00016180 File Offset: 0x00014380
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000161BC File Offset: 0x000143BC
		public unsafe ulong LastInputTick
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LastInputTick_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_LastInputTick_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000161FC File Offset: 0x000143FC
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00016238 File Offset: 0x00014438
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00016278 File Offset: 0x00014478
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000162B4 File Offset: 0x000144B4
		public unsafe bool IsAttached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_IsAttached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_IsAttached_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060003BF RID: 959 RVA: 0x000162F4 File Offset: 0x000144F4
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00016330 File Offset: 0x00014530
		public unsafe bool RawSticks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RawSticks_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_RawSticks_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00016370 File Offset: 0x00014570
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x000163B0 File Offset: 0x000145B0
		public unsafe ReadOnlyCollection<InputControl> Controls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Controls_Public_get_ReadOnlyCollection_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InputControl>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_Controls_Protected_set_Void_ReadOnlyCollection_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000163F4 File Offset: 0x000145F4
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00016434 File Offset: 0x00014634
		public unsafe Il2CppReferenceArray<InputControl> ControlsByTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_ControlsByTarget_Protected_get_Il2CppReferenceArray_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_ControlsByTarget_Private_set_Void_Il2CppReferenceArray_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00016478 File Offset: 0x00014678
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x000164B8 File Offset: 0x000146B8
		public unsafe TwoAxisInputControl LeftStick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStick_Public_get_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_LeftStick_Private_set_Void_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000164FC File Offset: 0x000146FC
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0001653C File Offset: 0x0001473C
		public unsafe TwoAxisInputControl RightStick
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStick_Public_get_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_RightStick_Private_set_Void_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00016580 File Offset: 0x00014780
		// (set) Token: 0x060003CA RID: 970 RVA: 0x000165C0 File Offset: 0x000147C0
		public unsafe TwoAxisInputControl DPad
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPad_Public_get_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_DPad_Private_set_Void_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00016604 File Offset: 0x00014804
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00016640 File Offset: 0x00014840
		public unsafe InputControlType LeftCommandControl
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftCommandControl_Public_get_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_LeftCommandControl_Private_set_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00016680 File Offset: 0x00014880
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000166BC File Offset: 0x000148BC
		public unsafe InputControlType RightCommandControl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315963, RefRangeEnd = 315964, XrefRangeStart = 315963, XrefRangeEnd = 315964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightCommandControl_Public_get_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 315964, RefRangeEnd = 315969, XrefRangeStart = 315964, XrefRangeEnd = 315969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_RightCommandControl_Private_set_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000166FC File Offset: 0x000148FC
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0001673C File Offset: 0x0001493C
		public unsafe Il2CppStructArray<InputDevice.AnalogSnapshotEntry> AnalogSnapshot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_AnalogSnapshot_Protected_get_Il2CppStructArray_1_AnalogSnapshotEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputDevice.AnalogSnapshotEntry>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_set_AnalogSnapshot_Protected_set_Void_Il2CppStructArray_1_AnalogSnapshotEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00016780 File Offset: 0x00014980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 773729, RefRangeEnd = 773732, XrefRangeStart = 773726, XrefRangeEnd = 773729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000167BC File Offset: 0x000149BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 773757, RefRangeEnd = 773762, XrefRangeStart = 773732, XrefRangeEnd = 773757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevice(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00016808 File Offset: 0x00014A08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773787, RefRangeEnd = 773789, XrefRangeStart = 773762, XrefRangeEnd = 773787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevice(string name, bool rawSticks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawSticks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00016864 File Offset: 0x00014A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773790, RefRangeEnd = 773791, XrefRangeStart = 773789, XrefRangeEnd = 773790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_OnAttached_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00016898 File Offset: 0x00014A98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 773792, RefRangeEnd = 773796, XrefRangeStart = 773791, XrefRangeEnd = 773792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_OnDetached_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000168CC File Offset: 0x00014ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773857, RefRangeEnd = 773858, XrefRangeStart = 773796, XrefRangeEnd = 773857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAliasControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_AddAliasControls_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00016900 File Offset: 0x00014B00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 773879, RefRangeEnd = 773883, XrefRangeStart = 773858, XrefRangeEnd = 773879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAliasControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_RemoveAliasControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00016934 File Offset: 0x00014B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773888, RefRangeEnd = 773889, XrefRangeStart = 773883, XrefRangeEnd = 773888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ClearControls_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00016968 File Offset: 0x00014B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773889, RefRangeEnd = 773891, XrefRangeStart = 773889, XrefRangeEnd = 773889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasControl(InputControlType controlType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_HasControl_Public_Boolean_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000169B4 File Offset: 0x00014BB4
		[CallerCount(140)]
		[CachedScanResults(RefRangeStart = 773895, RefRangeEnd = 774035, XrefRangeStart = 773891, XrefRangeEnd = 773895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl GetControl(InputControlType controlType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetControl_Public_InputControl_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001A1 RID: 417
		public unsafe InputControl this[InputControlType controlType]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774035, XrefRangeEnd = 774036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref controlType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Item_Public_get_InputControl_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00016A4C File Offset: 0x00014C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774036, XrefRangeEnd = 774049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlType GetInputControlTypeByName(string inputControlName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputControlName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetInputControlTypeByName_Public_Static_InputControlType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00016A90 File Offset: 0x00014C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774049, XrefRangeEnd = 774068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl GetControlByName(string controlName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(controlName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetControlByName_Public_InputControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00016AE0 File Offset: 0x00014CE0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 774080, RefRangeEnd = 774147, XrefRangeStart = 774068, XrefRangeEnd = 774080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl AddControl(InputControlType controlType, string handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00016B40 File Offset: 0x00014D40
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 774149, RefRangeEnd = 774165, XrefRangeStart = 774147, XrefRangeEnd = 774149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(handle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00016BBC File Offset: 0x00014DBC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 774170, RefRangeEnd = 774179, XrefRangeStart = 774165, XrefRangeEnd = 774170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveControl(InputControlType controlType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_RemoveControl_Private_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00016BFC File Offset: 0x00014DFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774188, RefRangeEnd = 774190, XrefRangeStart = 774179, XrefRangeEnd = 774188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ClearInputState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00016C30 File Offset: 0x00014E30
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 774193, RefRangeEnd = 774214, XrefRangeStart = 774190, XrefRangeEnd = 774193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateWithState_Protected_Void_InputControlType_Boolean_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00016C98 File Offset: 0x00014E98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 774217, RefRangeEnd = 774221, XrefRangeStart = 774214, XrefRangeEnd = 774217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateWithValue_Protected_Void_InputControlType_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00016D00 File Offset: 0x00014F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774221, XrefRangeEnd = 774224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWithRawValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateWithRawValue_Protected_Void_InputControlType_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00016D68 File Offset: 0x00014F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774249, RefRangeEnd = 774252, XrefRangeStart = 774224, XrefRangeEnd = 774249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateLeftStickWithValue_Public_Void_Vector2_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00016DC4 File Offset: 0x00014FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774277, RefRangeEnd = 774279, XrefRangeStart = 774252, XrefRangeEnd = 774277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateLeftStickWithRawValue_Public_Void_Vector2_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00016E20 File Offset: 0x00015020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774292, RefRangeEnd = 774293, XrefRangeStart = 774279, XrefRangeEnd = 774292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitLeftStick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_CommitLeftStick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00016E54 File Offset: 0x00015054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774318, RefRangeEnd = 774320, XrefRangeStart = 774293, XrefRangeEnd = 774318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateRightStickWithValue_Public_Void_Vector2_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00016EB0 File Offset: 0x000150B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774345, RefRangeEnd = 774348, XrefRangeStart = 774320, XrefRangeEnd = 774345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_UpdateRightStickWithRawValue_Public_Void_Vector2_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00016F0C File Offset: 0x0001510C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774361, RefRangeEnd = 774362, XrefRangeStart = 774348, XrefRangeEnd = 774361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitRightStick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_CommitRightStick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00016F40 File Offset: 0x00015140
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00016F98 File Offset: 0x00015198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774433, RefRangeEnd = 774434, XrefRangeStart = 774362, XrefRangeEnd = 774433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessLeftStick(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ProcessLeftStick_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00016FE4 File Offset: 0x000151E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774505, RefRangeEnd = 774506, XrefRangeStart = 774434, XrefRangeEnd = 774505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRightStick(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ProcessRightStick_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00017030 File Offset: 0x00015230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774577, RefRangeEnd = 774578, XrefRangeStart = 774506, XrefRangeEnd = 774577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDPad(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ProcessDPad_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001707C File Offset: 0x0001527C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774611, RefRangeEnd = 774613, XrefRangeStart = 774578, XrefRangeEnd = 774611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_Commit_Public_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000170C8 File Offset: 0x000152C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774613, RefRangeEnd = 774614, XrefRangeStart = 774613, XrefRangeEnd = 774613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LastInputAfter(InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_LastInputAfter_Public_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00017118 File Offset: 0x00015318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774621, RefRangeEnd = 774623, XrefRangeStart = 774614, XrefRangeEnd = 774621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestActivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_RequestActivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001714C File Offset: 0x0001534C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Vibrate(float leftSpeed, float rightSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftSpeed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000171A4 File Offset: 0x000153A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774623, XrefRangeEnd = 774632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Vibrate(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intensity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_Vibrate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000171E4 File Offset: 0x000153E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VibrateTriggers(float leftTriggerSpeed, float rightTriggerSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftTriggerSpeed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightTriggerSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001723C File Offset: 0x0001543C
		[CallerCount(0)]
		public unsafe void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_StopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00017270 File Offset: 0x00015470
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLightColor(float red, float green, float blue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref red;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_SetLightColor_Public_Virtual_New_Void_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000172D8 File Offset: 0x000154D8
		[CallerCount(0)]
		public unsafe void SetLightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_SetLightColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00017318 File Offset: 0x00015518
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flashOnDuration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flashOffDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_SetLightFlash_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00017370 File Offset: 0x00015570
		[CallerCount(0)]
		public unsafe void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_StopLightFlash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000173A4 File Offset: 0x000155A4
		public unsafe virtual bool IsSupportedOnThisPlatform
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000173EC File Offset: 0x000155EC
		public unsafe virtual bool IsKnown
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00017434 File Offset: 0x00015634
		public unsafe bool IsUnknown
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774632, RefRangeEnd = 774634, XrefRangeStart = 774632, XrefRangeEnd = 774632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_IsUnknown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00017470 File Offset: 0x00015670
		public unsafe bool MenuIsPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_MenuIsPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000174AC File Offset: 0x000156AC
		public unsafe bool MenuWasPressed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774634, RefRangeEnd = 774636, XrefRangeStart = 774634, XrefRangeEnd = 774634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_MenuWasPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000174E8 File Offset: 0x000156E8
		public unsafe bool MenuWasReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_MenuWasReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00017524 File Offset: 0x00015724
		public unsafe bool CommandIsPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_CommandIsPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00017560 File Offset: 0x00015760
		public unsafe bool CommandWasPressed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774634, RefRangeEnd = 774636, XrefRangeStart = 774634, XrefRangeEnd = 774636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_CommandWasPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001759C File Offset: 0x0001579C
		public unsafe bool CommandWasReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_CommandWasReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000175D8 File Offset: 0x000157D8
		public unsafe InputControl AnyButton
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774646, RefRangeEnd = 774647, XrefRangeStart = 774636, XrefRangeEnd = 774646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_AnyButton_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00017618 File Offset: 0x00015818
		public unsafe bool AnyButtonIsPressed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774647, XrefRangeEnd = 774653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_AnyButtonIsPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00017654 File Offset: 0x00015854
		public unsafe bool AnyButtonWasPressed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774653, XrefRangeEnd = 774659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_AnyButtonWasPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00017690 File Offset: 0x00015890
		public unsafe bool AnyButtonWasReleased
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774659, XrefRangeEnd = 774665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_AnyButtonWasReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000176CC File Offset: 0x000158CC
		public unsafe TwoAxisInputControl Direction
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 774665, RefRangeEnd = 774672, XrefRangeStart = 774665, XrefRangeEnd = 774665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Direction_Public_get_TwoAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001770C File Offset: 0x0001590C
		public unsafe InputControl LeftStickUp
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774674, RefRangeEnd = 774677, XrefRangeStart = 774672, XrefRangeEnd = 774674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickUp_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001774C File Offset: 0x0001594C
		public unsafe InputControl LeftStickDown
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774679, RefRangeEnd = 774682, XrefRangeStart = 774677, XrefRangeEnd = 774679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickDown_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001778C File Offset: 0x0001598C
		public unsafe InputControl LeftStickLeft
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774684, RefRangeEnd = 774686, XrefRangeStart = 774682, XrefRangeEnd = 774684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickLeft_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000177CC File Offset: 0x000159CC
		public unsafe InputControl LeftStickRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774688, RefRangeEnd = 774690, XrefRangeStart = 774686, XrefRangeEnd = 774688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickRight_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001780C File Offset: 0x00015A0C
		public unsafe InputControl RightStickUp
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774692, RefRangeEnd = 774695, XrefRangeStart = 774690, XrefRangeEnd = 774692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickUp_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001784C File Offset: 0x00015A4C
		public unsafe InputControl RightStickDown
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774697, RefRangeEnd = 774700, XrefRangeStart = 774695, XrefRangeEnd = 774697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickDown_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001788C File Offset: 0x00015A8C
		public unsafe InputControl RightStickLeft
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774702, RefRangeEnd = 774704, XrefRangeStart = 774700, XrefRangeEnd = 774702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickLeft_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000178CC File Offset: 0x00015ACC
		public unsafe InputControl RightStickRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774706, RefRangeEnd = 774708, XrefRangeStart = 774704, XrefRangeEnd = 774706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickRight_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001790C File Offset: 0x00015B0C
		public unsafe InputControl DPadUp
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774710, RefRangeEnd = 774713, XrefRangeStart = 774708, XrefRangeEnd = 774710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadUp_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001794C File Offset: 0x00015B4C
		public unsafe InputControl DPadDown
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774715, RefRangeEnd = 774718, XrefRangeStart = 774713, XrefRangeEnd = 774715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadDown_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001798C File Offset: 0x00015B8C
		public unsafe InputControl DPadLeft
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774720, RefRangeEnd = 774722, XrefRangeStart = 774718, XrefRangeEnd = 774720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadLeft_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000179CC File Offset: 0x00015BCC
		public unsafe InputControl DPadRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774724, RefRangeEnd = 774726, XrefRangeStart = 774722, XrefRangeEnd = 774724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadRight_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00017A0C File Offset: 0x00015C0C
		public unsafe InputControl Action1
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 774728, RefRangeEnd = 774736, XrefRangeStart = 774726, XrefRangeEnd = 774728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Action1_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00017A4C File Offset: 0x00015C4C
		public unsafe InputControl Action2
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 774738, RefRangeEnd = 774746, XrefRangeStart = 774736, XrefRangeEnd = 774738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Action2_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00017A8C File Offset: 0x00015C8C
		public unsafe InputControl Action3
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 774748, RefRangeEnd = 774755, XrefRangeStart = 774746, XrefRangeEnd = 774748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Action3_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00017ACC File Offset: 0x00015CCC
		public unsafe InputControl Action4
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 774757, RefRangeEnd = 774764, XrefRangeStart = 774755, XrefRangeEnd = 774757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Action4_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00017B0C File Offset: 0x00015D0C
		public unsafe InputControl LeftTrigger
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774766, RefRangeEnd = 774768, XrefRangeStart = 774764, XrefRangeEnd = 774766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftTrigger_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00017B4C File Offset: 0x00015D4C
		public unsafe InputControl RightTrigger
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774770, RefRangeEnd = 774772, XrefRangeStart = 774768, XrefRangeEnd = 774770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightTrigger_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00017B8C File Offset: 0x00015D8C
		public unsafe InputControl LeftBumper
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774774, RefRangeEnd = 774775, XrefRangeStart = 774772, XrefRangeEnd = 774774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftBumper_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00017BCC File Offset: 0x00015DCC
		public unsafe InputControl RightBumper
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774777, RefRangeEnd = 774778, XrefRangeStart = 774775, XrefRangeEnd = 774777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightBumper_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00017C0C File Offset: 0x00015E0C
		public unsafe InputControl LeftStickButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774778, XrefRangeEnd = 774780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickButton_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00017C4C File Offset: 0x00015E4C
		public unsafe InputControl RightStickButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774780, XrefRangeEnd = 774782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickButton_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00017C8C File Offset: 0x00015E8C
		public unsafe InputControl LeftStickX
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774784, RefRangeEnd = 774787, XrefRangeStart = 774782, XrefRangeEnd = 774784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickX_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00017CCC File Offset: 0x00015ECC
		public unsafe InputControl LeftStickY
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774789, RefRangeEnd = 774792, XrefRangeStart = 774787, XrefRangeEnd = 774789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftStickY_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00017D0C File Offset: 0x00015F0C
		public unsafe InputControl RightStickX
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774794, RefRangeEnd = 774796, XrefRangeStart = 774792, XrefRangeEnd = 774794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickX_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00017D4C File Offset: 0x00015F4C
		public unsafe InputControl RightStickY
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 774798, RefRangeEnd = 774800, XrefRangeStart = 774796, XrefRangeEnd = 774798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightStickY_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00017D8C File Offset: 0x00015F8C
		public unsafe InputControl DPadX
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774802, RefRangeEnd = 774803, XrefRangeStart = 774800, XrefRangeEnd = 774802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadX_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00017DCC File Offset: 0x00015FCC
		public unsafe InputControl DPadY
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774805, RefRangeEnd = 774806, XrefRangeStart = 774803, XrefRangeEnd = 774805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_DPadY_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00017E0C File Offset: 0x0001600C
		public unsafe InputControl Command
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774808, RefRangeEnd = 774809, XrefRangeStart = 774806, XrefRangeEnd = 774808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_Command_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00017E4C File Offset: 0x0001604C
		public unsafe InputControl LeftCommand
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774811, RefRangeEnd = 774812, XrefRangeStart = 774809, XrefRangeEnd = 774811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_LeftCommand_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00017E8C File Offset: 0x0001608C
		public unsafe InputControl RightCommand
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 774814, RefRangeEnd = 774815, XrefRangeStart = 774812, XrefRangeEnd = 774814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_RightCommand_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr3) : null;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00017ECC File Offset: 0x000160CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 774846, RefRangeEnd = 774851, XrefRangeStart = 774815, XrefRangeEnd = 774846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpireControlCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_ExpireControlCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00017F00 File Offset: 0x00016100
		public unsafe virtual int NumUnknownAnalogs
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00017F48 File Offset: 0x00016148
		public unsafe virtual int NumUnknownButtons
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00017F90 File Offset: 0x00016190
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadRawButtonState(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00017FE4 File Offset: 0x000161E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ReadRawAnalogValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00018038 File Offset: 0x00016238
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774859, RefRangeEnd = 774862, XrefRangeStart = 774851, XrefRangeEnd = 774859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeSnapshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_TakeSnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001806C File Offset: 0x0001626C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 774870, RefRangeEnd = 774871, XrefRangeStart = 774862, XrefRangeEnd = 774870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceControl GetFirstPressedAnalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetFirstPressedAnalog_Public_UnknownDeviceControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000180A8 File Offset: 0x000162A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774871, XrefRangeEnd = 774875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceControl GetFirstPressedButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetFirstPressedButton_Public_UnknownDeviceControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000035A7 File Offset: 0x000017A7
		public InputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x000180E4 File Offset: 0x000162E4
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x000035B0 File Offset: 0x000017B0
		public unsafe static InputDevice Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputDevice.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDevice.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001810C File Offset: 0x0001630C
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x000035C2 File Offset: 0x000017C2
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00018134 File Offset: 0x00016334
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x000035E1 File Offset: 0x000017E1
		public unsafe string _Meta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Meta_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Meta_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001815C File Offset: 0x0001635C
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003600 File Offset: 0x00001800
		public unsafe int _SortOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__SortOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__SortOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00018184 File Offset: 0x00016384
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000361B File Offset: 0x0000181B
		public unsafe InputDeviceClass _DeviceClass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DeviceClass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DeviceClass_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000181AC File Offset: 0x000163AC
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003636 File Offset: 0x00001836
		public unsafe InputDeviceStyle _DeviceStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DeviceStyle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DeviceStyle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000181D4 File Offset: 0x000163D4
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003651 File Offset: 0x00001851
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000181FC File Offset: 0x000163FC
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0000366C File Offset: 0x0000186C
		public unsafe ulong _LastInputTick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LastInputTick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LastInputTick_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00018224 File Offset: 0x00016424
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003687 File Offset: 0x00001887
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001824C File Offset: 0x0001644C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000036A2 File Offset: 0x000018A2
		public unsafe bool _IsAttached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__IsAttached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__IsAttached_k__BackingField)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00018274 File Offset: 0x00016474
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000036BD File Offset: 0x000018BD
		public unsafe bool _RawSticks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RawSticks_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RawSticks_k__BackingField)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0001829C File Offset: 0x0001649C
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000036D8 File Offset: 0x000018D8
		public unsafe List<InputControl> controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x000182CC File Offset: 0x000164CC
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x000036F7 File Offset: 0x000018F7
		public unsafe ReadOnlyCollection<InputControl> _Controls_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Controls_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<InputControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__Controls_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000182FC File Offset: 0x000164FC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00003716 File Offset: 0x00001916
		public unsafe Il2CppReferenceArray<InputControl> _ControlsByTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__ControlsByTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__ControlsByTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001832C File Offset: 0x0001652C
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003735 File Offset: 0x00001935
		public unsafe TwoAxisInputControl _LeftStick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LeftStick_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LeftStick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0001835C File Offset: 0x0001655C
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00003754 File Offset: 0x00001954
		public unsafe TwoAxisInputControl _RightStick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RightStick_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RightStick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001838C File Offset: 0x0001658C
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003773 File Offset: 0x00001973
		public unsafe TwoAxisInputControl _DPad_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DPad_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__DPad_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x000183BC File Offset: 0x000165BC
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003792 File Offset: 0x00001992
		public unsafe bool hasLeftCommandControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_hasLeftCommandControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_hasLeftCommandControl)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x000183E4 File Offset: 0x000165E4
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x000037AD File Offset: 0x000019AD
		public unsafe InputControl leftCommandSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_leftCommandSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_leftCommandSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00018414 File Offset: 0x00016614
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000037CC File Offset: 0x000019CC
		public unsafe InputControlType _LeftCommandControl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LeftCommandControl_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__LeftCommandControl_k__BackingField)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001843C File Offset: 0x0001663C
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000037E7 File Offset: 0x000019E7
		public unsafe bool hasRightCommandControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_hasRightCommandControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_hasRightCommandControl)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00018464 File Offset: 0x00016664
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003802 File Offset: 0x00001A02
		public unsafe InputControl rightCommandSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_rightCommandSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_rightCommandSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00018494 File Offset: 0x00016694
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003821 File Offset: 0x00001A21
		public unsafe InputControlType _RightCommandControl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RightCommandControl_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__RightCommandControl_k__BackingField)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000184BC File Offset: 0x000166BC
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000383C File Offset: 0x00001A3C
		public unsafe bool Passive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_Passive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_Passive)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000184E4 File Offset: 0x000166E4
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003857 File Offset: 0x00001A57
		public unsafe Il2CppStructArray<InputDevice.AnalogSnapshotEntry> _AnalogSnapshot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__AnalogSnapshot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputDevice.AnalogSnapshotEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr__AnalogSnapshot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00018514 File Offset: 0x00016714
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003876 File Offset: 0x00001A76
		public unsafe InputControl cachedLeftStickUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00018544 File Offset: 0x00016744
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003895 File Offset: 0x00001A95
		public unsafe InputControl cachedLeftStickDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00018574 File Offset: 0x00016774
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x000038B4 File Offset: 0x00001AB4
		public unsafe InputControl cachedLeftStickLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000185A4 File Offset: 0x000167A4
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x000038D3 File Offset: 0x00001AD3
		public unsafe InputControl cachedLeftStickRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000185D4 File Offset: 0x000167D4
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000038F2 File Offset: 0x00001AF2
		public unsafe InputControl cachedRightStickUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00018604 File Offset: 0x00016804
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003911 File Offset: 0x00001B11
		public unsafe InputControl cachedRightStickDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00018634 File Offset: 0x00016834
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003930 File Offset: 0x00001B30
		public unsafe InputControl cachedRightStickLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00018664 File Offset: 0x00016864
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000394F File Offset: 0x00001B4F
		public unsafe InputControl cachedRightStickRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00018694 File Offset: 0x00016894
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000396E File Offset: 0x00001B6E
		public unsafe InputControl cachedDPadUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000186C4 File Offset: 0x000168C4
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000398D File Offset: 0x00001B8D
		public unsafe InputControl cachedDPadDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000186F4 File Offset: 0x000168F4
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000039AC File Offset: 0x00001BAC
		public unsafe InputControl cachedDPadLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00018724 File Offset: 0x00016924
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000039CB File Offset: 0x00001BCB
		public unsafe InputControl cachedDPadRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00018754 File Offset: 0x00016954
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000039EA File Offset: 0x00001BEA
		public unsafe InputControl cachedAction1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00018784 File Offset: 0x00016984
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003A09 File Offset: 0x00001C09
		public unsafe InputControl cachedAction2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000187B4 File Offset: 0x000169B4
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003A28 File Offset: 0x00001C28
		public unsafe InputControl cachedAction3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000187E4 File Offset: 0x000169E4
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003A47 File Offset: 0x00001C47
		public unsafe InputControl cachedAction4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedAction4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00018814 File Offset: 0x00016A14
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003A66 File Offset: 0x00001C66
		public unsafe InputControl cachedLeftTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00018844 File Offset: 0x00016A44
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003A85 File Offset: 0x00001C85
		public unsafe InputControl cachedRightTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00018874 File Offset: 0x00016A74
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public unsafe InputControl cachedLeftBumper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftBumper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftBumper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000188A4 File Offset: 0x00016AA4
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003AC3 File Offset: 0x00001CC3
		public unsafe InputControl cachedRightBumper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightBumper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightBumper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000188D4 File Offset: 0x00016AD4
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003AE2 File Offset: 0x00001CE2
		public unsafe InputControl cachedLeftStickButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00018904 File Offset: 0x00016B04
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003B01 File Offset: 0x00001D01
		public unsafe InputControl cachedRightStickButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00018934 File Offset: 0x00016B34
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003B20 File Offset: 0x00001D20
		public unsafe InputControl cachedLeftStickX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00018964 File Offset: 0x00016B64
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00003B3F File Offset: 0x00001D3F
		public unsafe InputControl cachedLeftStickY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftStickY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00018994 File Offset: 0x00016B94
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00003B5E File Offset: 0x00001D5E
		public unsafe InputControl cachedRightStickX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000189C4 File Offset: 0x00016BC4
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00003B7D File Offset: 0x00001D7D
		public unsafe InputControl cachedRightStickY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightStickY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000189F4 File Offset: 0x00016BF4
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003B9C File Offset: 0x00001D9C
		public unsafe InputControl cachedDPadX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00018A24 File Offset: 0x00016C24
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00003BBB File Offset: 0x00001DBB
		public unsafe InputControl cachedDPadY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedDPadY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00018A54 File Offset: 0x00016C54
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003BDA File Offset: 0x00001DDA
		public unsafe InputControl cachedCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00018A84 File Offset: 0x00016C84
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003BF9 File Offset: 0x00001DF9
		public unsafe InputControl cachedLeftCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedLeftCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00018AB4 File Offset: 0x00016CB4
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003C18 File Offset: 0x00001E18
		public unsafe InputControl cachedRightCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevice.NativeFieldInfoPtr_cachedRightCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr__Meta_k__BackingField;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr__SortOrder_k__BackingField;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr__DeviceClass_k__BackingField;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr__DeviceStyle_k__BackingField;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr__LastInputTick_k__BackingField;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr__IsAttached_k__BackingField;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr__RawSticks_k__BackingField;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_controls;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr__Controls_k__BackingField;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr__ControlsByTarget_k__BackingField;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr__LeftStick_k__BackingField;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr__RightStick_k__BackingField;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr__DPad_k__BackingField;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_hasLeftCommandControl;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_leftCommandSource;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr__LeftCommandControl_k__BackingField;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_hasRightCommandControl;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_rightCommandSource;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr__RightCommandControl_k__BackingField;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_Passive;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr__AnalogSnapshot_k__BackingField;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickUp;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickDown;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickLeft;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickRight;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickUp;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickDown;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickLeft;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickRight;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadUp;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadDown;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadLeft;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadRight;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_cachedAction1;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_cachedAction2;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_cachedAction3;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_cachedAction4;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftTrigger;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightTrigger;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftBumper;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightBumper;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickButton;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickButton;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickX;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftStickY;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickX;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightStickY;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadX;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_cachedDPadY;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_cachedCommand;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_cachedLeftCommand;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_cachedRightCommand;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_get_Meta_Public_get_String_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_set_Meta_Protected_set_Void_String_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_get_SortOrder_Public_get_Int32_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_set_SortOrder_Protected_set_Void_Int32_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_get_Guid_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Private_set_Void_Guid_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_LastInputTick_Public_get_UInt64_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_set_LastInputTick_Private_set_Void_UInt64_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttached_Public_get_Boolean_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAttached_Private_set_Void_Boolean_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_RawSticks_Protected_get_Boolean_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_set_RawSticks_Private_set_Void_Boolean_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_Controls_Public_get_ReadOnlyCollection_1_InputControl_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_Controls_Protected_set_Void_ReadOnlyCollection_1_InputControl_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlsByTarget_Protected_get_Il2CppReferenceArray_1_InputControl_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_set_ControlsByTarget_Private_set_Void_Il2CppReferenceArray_1_InputControl_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStick_Public_get_TwoAxisInputControl_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftStick_Private_set_Void_TwoAxisInputControl_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStick_Public_get_TwoAxisInputControl_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_set_RightStick_Private_set_Void_TwoAxisInputControl_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_get_DPad_Public_get_TwoAxisInputControl_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_set_DPad_Private_set_Void_TwoAxisInputControl_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftCommandControl_Public_get_InputControlType_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftCommandControl_Private_set_Void_InputControlType_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_get_RightCommandControl_Public_get_InputControlType_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_set_RightCommandControl_Private_set_Void_InputControlType_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_AnalogSnapshot_Protected_get_Il2CppStructArray_1_AnalogSnapshotEntry_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_set_AnalogSnapshot_Protected_set_Void_Il2CppStructArray_1_AnalogSnapshotEntry_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Internal_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Internal_Void_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_AddAliasControls_Protected_Void_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAliasControls_Private_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_ClearControls_Protected_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_HasControl_Public_Boolean_InputControlType_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_GetControl_Public_InputControl_InputControlType_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_InputControl_InputControlType_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_GetInputControlTypeByName_Public_Static_InputControlType_String_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_GetControlByName_Public_InputControl_String_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_AddControl_Public_InputControl_InputControlType_String_Single_Single_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_RemoveControl_Private_Void_InputControlType_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithState_Protected_Void_InputControlType_Boolean_UInt64_Single_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithValue_Protected_Void_InputControlType_Single_UInt64_Single_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithRawValue_Protected_Void_InputControlType_Single_UInt64_Single_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLeftStickWithValue_Public_Void_Vector2_UInt64_Single_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLeftStickWithRawValue_Public_Void_Vector2_UInt64_Single_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_CommitLeftStick_Public_Void_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRightStickWithValue_Public_Void_Vector2_UInt64_Single_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRightStickWithRawValue_Public_Void_Vector2_UInt64_Single_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_CommitRightStick_Public_Void_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_UInt64_Single_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLeftStick_Private_Void_UInt64_Single_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRightStick_Private_Void_UInt64_Single_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDPad_Private_Void_UInt64_Single_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_UInt64_Single_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_LastInputAfter_Public_Boolean_InputDevice_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_RequestActivation_Public_Void_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_Vibrate_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_Vibrate_Public_Void_Single_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Void_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_New_Void_Single_Single_Single_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Void_Color_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_SetLightFlash_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Void_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnown_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnknown_Public_get_Boolean_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuIsPressed_Public_get_Boolean_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuWasPressed_Public_get_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuWasReleased_Public_get_Boolean_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandIsPressed_Public_get_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandWasPressed_Public_get_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_CommandWasReleased_Public_get_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyButton_Public_get_InputControl_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyButtonIsPressed_Public_get_Boolean_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyButtonWasPressed_Public_get_Boolean_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyButtonWasReleased_Public_get_Boolean_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_TwoAxisInputControl_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickUp_Public_get_InputControl_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickDown_Public_get_InputControl_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickLeft_Public_get_InputControl_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickRight_Public_get_InputControl_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickUp_Public_get_InputControl_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickDown_Public_get_InputControl_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickLeft_Public_get_InputControl_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickRight_Public_get_InputControl_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadUp_Public_get_InputControl_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadDown_Public_get_InputControl_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadLeft_Public_get_InputControl_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadRight_Public_get_InputControl_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_get_Action1_Public_get_InputControl_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_get_Action2_Public_get_InputControl_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_get_Action3_Public_get_InputControl_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_Action4_Public_get_InputControl_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftTrigger_Public_get_InputControl_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_RightTrigger_Public_get_InputControl_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftBumper_Public_get_InputControl_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_RightBumper_Public_get_InputControl_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickButton_Public_get_InputControl_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickButton_Public_get_InputControl_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickX_Public_get_InputControl_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStickY_Public_get_InputControl_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickX_Public_get_InputControl_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStickY_Public_get_InputControl_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadX_Public_get_InputControl_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_get_DPadY_Public_get_InputControl_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_get_Command_Public_get_InputControl_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftCommand_Public_get_InputControl_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_get_RightCommand_Public_get_InputControl_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_ExpireControlCache_Private_Void_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_New_Single_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_TakeSnapshot_Public_Void_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstPressedAnalog_Public_UnknownDeviceControl_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstPressedButton_Public_UnknownDeviceControl_0;

		// Token: 0x02000211 RID: 529
		[StructLayout(2)]
		public struct AnalogSnapshotEntry
		{
			// Token: 0x0600117D RID: 4477 RVA: 0x00044BD8 File Offset: 0x00042DD8
			// Note: this type is marked as 'beforefieldinit'.
			static AnalogSnapshotEntry()
			{
				Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "AnalogSnapshotEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr);
				InputDevice.AnalogSnapshotEntry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr, "value");
				InputDevice.AnalogSnapshotEntry.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr, "maxValue");
				InputDevice.AnalogSnapshotEntry.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr, "minValue");
				InputDevice.AnalogSnapshotEntry.NativeMethodInfoPtr_TrackMinMaxValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr, 100663925);
			}

			// Token: 0x0600117E RID: 4478 RVA: 0x00044C54 File Offset: 0x00042E54
			[CallerCount(0)]
			public unsafe void TrackMinMaxValue(float currentValue)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref currentValue;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.AnalogSnapshotEntry.NativeMethodInfoPtr_TrackMinMaxValue_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x0000707C File Offset: 0x0000527C
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDevice.AnalogSnapshotEntry>.NativeClassPtr, ref this));
			}

			// Token: 0x04000D88 RID: 3464
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000D89 RID: 3465
			private static readonly IntPtr NativeFieldInfoPtr_maxValue;

			// Token: 0x04000D8A RID: 3466
			private static readonly IntPtr NativeFieldInfoPtr_minValue;

			// Token: 0x04000D8B RID: 3467
			private static readonly IntPtr NativeMethodInfoPtr_TrackMinMaxValue_Public_Void_Single_0;

			// Token: 0x04000D8C RID: 3468
			[FieldOffset(0)]
			public float value;

			// Token: 0x04000D8D RID: 3469
			[FieldOffset(4)]
			public float maxValue;

			// Token: 0x04000D8E RID: 3470
			[FieldOffset(8)]
			public float minValue;
		}
	}
}
