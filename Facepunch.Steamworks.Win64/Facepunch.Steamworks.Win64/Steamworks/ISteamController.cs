using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000010 RID: 16
	public class ISteamController : SteamInterface
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00013898 File Offset: 0x00011A98
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamController()
		{
			Il2CppClassPointerStore<ISteamController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamController>.NativeClassPtr);
			ISteamController.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663510);
			ISteamController.NativeMethodInfoPtr_SteamAPI_SteamController_v008_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663511);
			ISteamController.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663512);
			ISteamController.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663513);
			ISteamController.NativeMethodInfoPtr_Init_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663514);
			ISteamController.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663515);
			ISteamController.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663516);
			ISteamController.NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663517);
			ISteamController.NativeMethodInfoPtr_RunFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663518);
			ISteamController.NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663519);
			ISteamController.NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663520);
			ISteamController.NativeMethodInfoPtr__GetActionSetHandle_Private_Static_ControllerActionSetHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663521);
			ISteamController.NativeMethodInfoPtr_GetActionSetHandle_Internal_ControllerActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663522);
			ISteamController.NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663523);
			ISteamController.NativeMethodInfoPtr_ActivateActionSet_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663524);
			ISteamController.NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_ControllerActionSetHandle_t_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663525);
			ISteamController.NativeMethodInfoPtr_GetCurrentActionSet_Internal_ControllerActionSetHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663526);
			ISteamController.NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663527);
			ISteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663528);
			ISteamController.NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663529);
			ISteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663530);
			ISteamController.NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663531);
			ISteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663532);
			ISteamController.NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663533);
			ISteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663534);
			ISteamController.NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_ControllerDigitalActionHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663535);
			ISteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_ControllerDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663536);
			ISteamController.NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_ControllerHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663537);
			ISteamController.NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_ControllerHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663538);
			ISteamController.NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663539);
			ISteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663540);
			ISteamController.NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_ControllerAnalogActionHandle_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663541);
			ISteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_ControllerAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663542);
			ISteamController.NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663543);
			ISteamController.NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663544);
			ISteamController.NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663545);
			ISteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663546);
			ISteamController.NativeMethodInfoPtr__GetGlyphForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663547);
			ISteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Internal_String_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663548);
			ISteamController.NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663549);
			ISteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663550);
			ISteamController.NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663551);
			ISteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663552);
			ISteamController.NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663553);
			ISteamController.NativeMethodInfoPtr_GetMotionData_Internal_MotionState_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663554);
			ISteamController.NativeMethodInfoPtr__TriggerHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663555);
			ISteamController.NativeMethodInfoPtr_TriggerHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663556);
			ISteamController.NativeMethodInfoPtr__TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663557);
			ISteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663558);
			ISteamController.NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_ControllerHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663559);
			ISteamController.NativeMethodInfoPtr_TriggerVibration_Internal_Void_ControllerHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663560);
			ISteamController.NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_ControllerHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663561);
			ISteamController.NativeMethodInfoPtr_SetLEDColor_Internal_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663562);
			ISteamController.NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663563);
			ISteamController.NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663564);
			ISteamController.NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663565);
			ISteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663566);
			ISteamController.NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_ControllerHandle_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663567);
			ISteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_ControllerHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663568);
			ISteamController.NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663569);
			ISteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663570);
			ISteamController.NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663571);
			ISteamController.NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663572);
			ISteamController.NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663573);
			ISteamController.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663574);
			ISteamController.NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_ControllerActionOrigin_IntPtr_ControllerHandle_t_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663575);
			ISteamController.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_ControllerActionOrigin_ControllerHandle_t_XboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663576);
			ISteamController.NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_ControllerActionOrigin_IntPtr_InputType_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663577);
			ISteamController.NativeMethodInfoPtr_TranslateActionOrigin_Internal_ControllerActionOrigin_InputType_ControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663578);
			ISteamController.NativeMethodInfoPtr__GetControllerBindingRevision_Private_Static_Boolean_IntPtr_ControllerHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663579);
			ISteamController.NativeMethodInfoPtr_GetControllerBindingRevision_Internal_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamController>.NativeClassPtr, 100663580);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00013E54 File Offset: 0x00012054
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamController(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00013E9C File Offset: 0x0001209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931461, XrefRangeEnd = 931463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamController_v008()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_SteamAPI_SteamController_v008_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00013ECC File Offset: 0x000120CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamController.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00013F14 File Offset: 0x00012114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931463, XrefRangeEnd = 931465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Init(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00013F54 File Offset: 0x00012154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931465, XrefRangeEnd = 931467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_Init_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00013F90 File Offset: 0x00012190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931467, XrefRangeEnd = 931469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _Shutdown(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00013FD0 File Offset: 0x000121D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931469, XrefRangeEnd = 931471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_Shutdown_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001400C File Offset: 0x0001220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931471, XrefRangeEnd = 931473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RunFrame(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00014040 File Offset: 0x00012240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931473, XrefRangeEnd = 931475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_RunFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00014074 File Offset: 0x00012274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931475, XrefRangeEnd = 931477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetConnectedControllers(IntPtr self, [In] [Out] Il2CppStructArray<ControllerHandle_t> handlesOut)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<ControllerHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000140D4 File Offset: 0x000122D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931477, XrefRangeEnd = 931479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetConnectedControllers([In] [Out] Il2CppStructArray<ControllerHandle_t> handlesOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<ControllerHandle_t>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00014134 File Offset: 0x00012334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931479, XrefRangeEnd = 931482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t _GetActionSetHandle(IntPtr self, string pszActionSetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetActionSetHandle_Private_Static_ControllerActionSetHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00014184 File Offset: 0x00012384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931482, XrefRangeEnd = 931485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetActionSetHandle_Internal_ControllerActionSetHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000141D4 File Offset: 0x000123D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931485, XrefRangeEnd = 931487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateActionSet(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00014224 File Offset: 0x00012424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931487, XrefRangeEnd = 931489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_ActivateActionSet_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00014270 File Offset: 0x00012470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931489, XrefRangeEnd = 931491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t _GetCurrentActionSet(IntPtr self, ControllerHandle_t controllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_ControllerActionSetHandle_t_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000142BC File Offset: 0x000124BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931491, XrefRangeEnd = 931493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetCurrentActionSet_Internal_ControllerActionSetHandle_t_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00014308 File Offset: 0x00012508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931493, XrefRangeEnd = 931495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ActivateActionSetLayer(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00014358 File Offset: 0x00012558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931495, XrefRangeEnd = 931497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000143A4 File Offset: 0x000125A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931497, XrefRangeEnd = 931499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DeactivateActionSetLayer(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000143F4 File Offset: 0x000125F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931499, XrefRangeEnd = 931501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00014440 File Offset: 0x00012640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931501, XrefRangeEnd = 931503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _DeactivateAllActionSetLayers(IntPtr self, ControllerHandle_t controllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00014480 File Offset: 0x00012680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931503, XrefRangeEnd = 931505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000144C0 File Offset: 0x000126C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931505, XrefRangeEnd = 931507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetActiveActionSetLayers(IntPtr self, ControllerHandle_t controllerHandle, [In] [Out] Il2CppStructArray<ControllerActionSetHandle_t> handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<ControllerActionSetHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00014530 File Offset: 0x00012730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931507, XrefRangeEnd = 931509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, [In] [Out] Il2CppStructArray<ControllerActionSetHandle_t> handlesOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*handlesOut = ((intPtr4 == 0) ? null : new Il2CppStructArray<ControllerActionSetHandle_t>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001459C File Offset: 0x0001279C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931509, XrefRangeEnd = 931512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerDigitalActionHandle_t _GetDigitalActionHandle(IntPtr self, string pszActionName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_ControllerDigitalActionHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000145EC File Offset: 0x000127EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931512, XrefRangeEnd = 931515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_ControllerDigitalActionHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001463C File Offset: 0x0001283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931515, XrefRangeEnd = 931517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DigitalState _GetDigitalActionData(IntPtr self, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_ControllerHandle_t_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014698 File Offset: 0x00012898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931517, XrefRangeEnd = 931519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalState GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_ControllerHandle_t_ControllerDigitalActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000146F0 File Offset: 0x000128F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931519, XrefRangeEnd = 931521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetDigitalActionOrigins(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, ref ControllerActionOrigin originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00014768 File Offset: 0x00012968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931521, XrefRangeEnd = 931523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, ref ControllerActionOrigin originsOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000147DC File Offset: 0x000129DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931523, XrefRangeEnd = 931526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerAnalogActionHandle_t _GetAnalogActionHandle(IntPtr self, string pszActionName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_ControllerAnalogActionHandle_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001482C File Offset: 0x00012A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931526, XrefRangeEnd = 931529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_ControllerAnalogActionHandle_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001487C File Offset: 0x00012A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931529, XrefRangeEnd = 931531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalogState _GetAnalogActionData(IntPtr self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000148D8 File Offset: 0x00012AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931531, XrefRangeEnd = 931533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogState GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_ControllerHandle_t_ControllerAnalogActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00014930 File Offset: 0x00012B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931533, XrefRangeEnd = 931535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetAnalogActionOrigins(IntPtr self, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, ref ControllerActionOrigin originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000149A8 File Offset: 0x00012BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931535, XrefRangeEnd = 931537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, ref ControllerActionOrigin originsOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originsOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00014A1C File Offset: 0x00012C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931537, XrefRangeEnd = 931539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetGlyphForActionOrigin(IntPtr self, ControllerActionOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetGlyphForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014A68 File Offset: 0x00012C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931539, XrefRangeEnd = 931542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphForActionOrigin(ControllerActionOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Internal_String_ControllerActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00014AAC File Offset: 0x00012CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931542, XrefRangeEnd = 931544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetStringForActionOrigin(IntPtr self, ControllerActionOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00014AF8 File Offset: 0x00012CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931544, XrefRangeEnd = 931547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForActionOrigin(ControllerActionOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_ControllerActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00014B3C File Offset: 0x00012D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931547, XrefRangeEnd = 931549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _StopAnalogActionMomentum(IntPtr self, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014B8C File Offset: 0x00012D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931549, XrefRangeEnd = 931551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00014BD8 File Offset: 0x00012DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931551, XrefRangeEnd = 931553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MotionState _GetMotionData(IntPtr self, ControllerHandle_t controllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00014C24 File Offset: 0x00012E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931553, XrefRangeEnd = 931555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionState GetMotionData(ControllerHandle_t controllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetMotionData_Internal_MotionState_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014C70 File Offset: 0x00012E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931555, XrefRangeEnd = 931557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerHapticPulse(IntPtr self, ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__TriggerHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014CCC File Offset: 0x00012ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931557, XrefRangeEnd = 931559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerHapticPulse(ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_TriggerHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00014D28 File Offset: 0x00012F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931559, XrefRangeEnd = 931561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerRepeatedHapticPulse(IntPtr self, ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00014DB0 File Offset: 0x00012FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931561, XrefRangeEnd = 931563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00014E34 File Offset: 0x00013034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931563, XrefRangeEnd = 931565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerVibration(IntPtr self, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_ControllerHandle_t_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00014E90 File Offset: 0x00013090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931565, XrefRangeEnd = 931567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_TriggerVibration_Internal_Void_ControllerHandle_t_UInt16_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00014EEC File Offset: 0x000130EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931567, XrefRangeEnd = 931569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetLEDColor(IntPtr self, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_ControllerHandle_t_Byte_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00014F64 File Offset: 0x00013164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931569, XrefRangeEnd = 931571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_SetLEDColor_Internal_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00014FDC File Offset: 0x000131DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931571, XrefRangeEnd = 931573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ShowBindingPanel(IntPtr self, ControllerHandle_t controllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00015028 File Offset: 0x00013228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931573, XrefRangeEnd = 931575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00015074 File Offset: 0x00013274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931575, XrefRangeEnd = 931577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputType _GetInputTypeForHandle(IntPtr self, ControllerHandle_t controllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000150C0 File Offset: 0x000132C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931577, XrefRangeEnd = 931579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputType GetInputTypeForHandle(ControllerHandle_t controllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001510C File Offset: 0x0001330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931579, XrefRangeEnd = 931581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerHandle_t _GetControllerForGamepadIndex(IntPtr self, int nIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_ControllerHandle_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00015158 File Offset: 0x00013358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931581, XrefRangeEnd = 931583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_ControllerHandle_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000151A4 File Offset: 0x000133A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931583, XrefRangeEnd = 931585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetGamepadIndexForController(IntPtr self, ControllerHandle_t ulControllerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulControllerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000151F0 File Offset: 0x000133F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931585, XrefRangeEnd = 931587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulControllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_ControllerHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001523C File Offset: 0x0001343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931587, XrefRangeEnd = 931589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00015288 File Offset: 0x00013488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931589, XrefRangeEnd = 931592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringForXboxOrigin(XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000152CC File Offset: 0x000134CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931592, XrefRangeEnd = 931594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00015318 File Offset: 0x00013518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931594, XrefRangeEnd = 931597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGlyphForXboxOrigin(XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001535C File Offset: 0x0001355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931597, XrefRangeEnd = 931599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionOrigin _GetActionOriginFromXboxOrigin(IntPtr self, ControllerHandle_t controllerHandle, XboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_ControllerActionOrigin_IntPtr_ControllerHandle_t_XboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000153B8 File Offset: 0x000135B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931599, XrefRangeEnd = 931601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle_t controllerHandle, XboxOrigin eOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_ControllerActionOrigin_ControllerHandle_t_XboxOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00015410 File Offset: 0x00013610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931601, XrefRangeEnd = 931603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionOrigin _TranslateActionOrigin(IntPtr self, InputType eDestinationInputType, ControllerActionOrigin eSourceOrigin)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_ControllerActionOrigin_IntPtr_InputType_ControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001546C File Offset: 0x0001366C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931603, XrefRangeEnd = 931605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerActionOrigin TranslateActionOrigin(InputType eDestinationInputType, ControllerActionOrigin eSourceOrigin)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_TranslateActionOrigin_Internal_ControllerActionOrigin_InputType_ControllerActionOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000154C4 File Offset: 0x000136C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931605, XrefRangeEnd = 931607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetControllerBindingRevision(IntPtr self, ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr__GetControllerBindingRevision_Private_Static_Boolean_IntPtr_ControllerHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001552C File Offset: 0x0001372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931607, XrefRangeEnd = 931609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetControllerBindingRevision(ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamController.NativeMethodInfoPtr_GetControllerBindingRevision_Internal_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000022EE File Offset: 0x000004EE
		public ISteamController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamController_v008_Internal_Static_IntPtr_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__Init_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr__Shutdown_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Boolean_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr__RunFrame_Private_Static_Void_IntPtr_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Internal_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__GetConnectedControllers_Private_Static_Int32_IntPtr_Il2CppStructArray_1_ControllerHandle_t_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedControllers_Internal_Int32_Il2CppStructArray_1_ControllerHandle_t_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr__GetActionSetHandle_Private_Static_ControllerActionSetHandle_t_IntPtr_String_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Internal_ControllerActionSetHandle_t_String_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr__ActivateActionSet_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSet_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentActionSet_Private_Static_ControllerActionSetHandle_t_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActionSet_Internal_ControllerActionSetHandle_t_ControllerHandle_t_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ActivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__DeactivateActionSetLayer_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateActionSetLayer_Internal_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr__DeactivateAllActionSetLayers_Private_Static_Void_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllActionSetLayers_Internal_Void_ControllerHandle_t_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr__GetActiveActionSetLayers_Private_Static_Int32_IntPtr_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetLayers_Internal_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionHandle_Private_Static_ControllerDigitalActionHandle_t_IntPtr_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Internal_ControllerDigitalActionHandle_t_String_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionData_Private_Static_DigitalState_IntPtr_ControllerHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionData_Internal_DigitalState_ControllerHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr__GetDigitalActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_byref_ControllerActionOrigin_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionHandle_Private_Static_ControllerAnalogActionHandle_t_IntPtr_String_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Internal_ControllerAnalogActionHandle_t_String_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionData_Private_Static_AnalogState_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionData_Internal_AnalogState_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr__GetAnalogActionOrigins_Private_Static_Int32_IntPtr_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Internal_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_byref_ControllerActionOrigin_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForActionOrigin_Internal_String_ControllerActionOrigin_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForActionOrigin_Private_Static_Utf8StringPointer_IntPtr_ControllerActionOrigin_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForActionOrigin_Internal_String_ControllerActionOrigin_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr__StopAnalogActionMomentum_Private_Static_Void_IntPtr_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_StopAnalogActionMomentum_Internal_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr__GetMotionData_Private_Static_MotionState_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_GetMotionData_Internal_MotionState_ControllerHandle_t_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr__TriggerHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_TriggerHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr__TriggerRepeatedHapticPulse_Private_Static_Void_IntPtr_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Internal_Void_ControllerHandle_t_SteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr__TriggerVibration_Private_Static_Void_IntPtr_ControllerHandle_t_UInt16_UInt16_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibration_Internal_Void_ControllerHandle_t_UInt16_UInt16_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr__SetLEDColor_Private_Static_Void_IntPtr_ControllerHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDColor_Internal_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ShowBindingPanel_Private_Static_Boolean_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Internal_Boolean_ControllerHandle_t_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr__GetInputTypeForHandle_Private_Static_InputType_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTypeForHandle_Internal_InputType_ControllerHandle_t_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr__GetControllerForGamepadIndex_Private_Static_ControllerHandle_t_IntPtr_Int32_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerForGamepadIndex_Internal_ControllerHandle_t_Int32_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr__GetGamepadIndexForController_Private_Static_Int32_IntPtr_ControllerHandle_t_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_GetGamepadIndexForController_Internal_Int32_ControllerHandle_t_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr__GetStringForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForXboxOrigin_Internal_String_XboxOrigin_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__GetGlyphForXboxOrigin_Private_Static_Utf8StringPointer_IntPtr_XboxOrigin_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForXboxOrigin_Internal_String_XboxOrigin_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr__GetActionOriginFromXboxOrigin_Private_Static_ControllerActionOrigin_IntPtr_ControllerHandle_t_XboxOrigin_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Internal_ControllerActionOrigin_ControllerHandle_t_XboxOrigin_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__TranslateActionOrigin_Private_Static_ControllerActionOrigin_IntPtr_InputType_ControllerActionOrigin_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_TranslateActionOrigin_Internal_ControllerActionOrigin_InputType_ControllerActionOrigin_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr__GetControllerBindingRevision_Private_Static_Boolean_IntPtr_ControllerHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerBindingRevision_Internal_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0;
	}
}
