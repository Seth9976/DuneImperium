using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class Input : Object
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002E18 File Offset: 0x00001018
		// Note: this type is marked as 'beforefieldinit'.
		static Input()
		{
			Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Input");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
			Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663318);
			Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663319);
			Input.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663320);
			Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663321);
			Input.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663322);
			Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663323);
			Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663324);
			Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663325);
			Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663326);
			Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663327);
			Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663328);
			Input.NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663329);
			Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663330);
			Input.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663331);
			Input.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663332);
			Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663333);
			Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663334);
			Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663335);
			Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663336);
			Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663337);
			Input.NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663338);
			Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663339);
			Input.NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663340);
			Input.NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663341);
			Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663342);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663343);
			Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663344);
			Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663345);
			Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663346);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663347);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663348);
			Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663349);
			Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663350);
			Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663351);
			Input.NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663352);
			Input.NativeMethodInfoPtr_get_deviceOrientation_Public_Static_get_DeviceOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663353);
			Input.NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663354);
			Input.NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663355);
			Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663356);
			Input.NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663357);
			Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663358);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663359);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663360);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663361);
			Input.ResetInputAxesDelegateField = IL2CPP.ResolveICall<Input.ResetInputAxesDelegate>("UnityEngine.Input::ResetInputAxes");
			Input.ResetPenEventsDelegateField = IL2CPP.ResolveICall<Input.ResetPenEventsDelegate>("UnityEngine.Input::ResetPenEvents");
			Input.get_anyKeyDownDelegateField = IL2CPP.ResolveICall<Input.get_anyKeyDownDelegate>("UnityEngine.Input::get_anyKeyDown");
			Input.get_imeIsSelectedDelegateField = IL2CPP.ResolveICall<Input.get_imeIsSelectedDelegate>("UnityEngine.Input::get_imeIsSelected");
			Input.get_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.get_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::get_eatKeyPressOnTextFieldFocus");
			Input.set_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.set_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::set_eatKeyPressOnTextFieldFocus");
			Input.get_penEventCountDelegateField = IL2CPP.ResolveICall<Input.get_penEventCountDelegate>("UnityEngine.Input::get_penEventCount");
			Input.get_touchPressureSupportedDelegateField = IL2CPP.ResolveICall<Input.get_touchPressureSupportedDelegate>("UnityEngine.Input::get_touchPressureSupported");
			Input.get_stylusTouchSupportedDelegateField = IL2CPP.ResolveICall<Input.get_stylusTouchSupportedDelegate>("UnityEngine.Input::get_stylusTouchSupported");
			Input.get_multiTouchEnabledDelegateField = IL2CPP.ResolveICall<Input.get_multiTouchEnabledDelegate>("UnityEngine.Input::get_multiTouchEnabled");
			Input.get_isGyroAvailableDelegateField = IL2CPP.ResolveICall<Input.get_isGyroAvailableDelegate>("UnityEngine.Input::get_isGyroAvailable");
			Input.get_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.get_compensateSensorsDelegate>("UnityEngine.Input::get_compensateSensors");
			Input.set_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.set_compensateSensorsDelegate>("UnityEngine.Input::set_compensateSensors");
			Input.get_accelerationEventCountDelegateField = IL2CPP.ResolveICall<Input.get_accelerationEventCountDelegate>("UnityEngine.Input::get_accelerationEventCount");
			Input.get_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.get_backButtonLeavesAppDelegate>("UnityEngine.Input::get_backButtonLeavesApp");
			Input.set_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.set_backButtonLeavesAppDelegate>("UnityEngine.Input::set_backButtonLeavesApp");
			Input.GetGyroInternalDelegateField = IL2CPP.ResolveICall<Input.GetGyroInternalDelegate>("UnityEngine.Input::GetGyroInternal");
			Input.GetPenEvent_InjectedDelegateField = IL2CPP.ResolveICall<Input.GetPenEvent_InjectedDelegate>("UnityEngine.Input::GetPenEvent_Injected");
			Input.SimulateTouchInternal_InjectedDelegateField = IL2CPP.ResolveICall<Input.SimulateTouchInternal_InjectedDelegate>("UnityEngine.Input::SimulateTouchInternal_Injected");
			Input.get_acceleration_InjectedDelegateField = IL2CPP.ResolveICall<Input.get_acceleration_InjectedDelegate>("UnityEngine.Input::get_acceleration_Injected");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000032E4 File Offset: 0x000014E4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1266767, RefRangeEnd = 1266782, XrefRangeStart = 1266765, XrefRangeEnd = 1266767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003328 File Offset: 0x00001528
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1266784, RefRangeEnd = 1266798, XrefRangeStart = 1266782, XrefRangeEnd = 1266784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000336C File Offset: 0x0000156C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266800, RefRangeEnd = 1266802, XrefRangeStart = 1266798, XrefRangeEnd = 1266800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000033B0 File Offset: 0x000015B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1266804, RefRangeEnd = 1266807, XrefRangeStart = 1266802, XrefRangeEnd = 1266804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000033F4 File Offset: 0x000015F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266809, RefRangeEnd = 1266811, XrefRangeStart = 1266807, XrefRangeEnd = 1266809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003438 File Offset: 0x00001638
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 1266813, RefRangeEnd = 1266865, XrefRangeStart = 1266811, XrefRangeEnd = 1266813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003478 File Offset: 0x00001678
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1266867, RefRangeEnd = 1266872, XrefRangeStart = 1266865, XrefRangeEnd = 1266867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUpInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000034B8 File Offset: 0x000016B8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1266874, RefRangeEnd = 1266897, XrefRangeStart = 1266872, XrefRangeEnd = 1266874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDownInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000034F8 File Offset: 0x000016F8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1266899, RefRangeEnd = 1266914, XrefRangeStart = 1266897, XrefRangeEnd = 1266899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003538 File Offset: 0x00001738
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1266916, RefRangeEnd = 1266930, XrefRangeStart = 1266914, XrefRangeEnd = 1266916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonDown(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003578 File Offset: 0x00001778
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1266932, RefRangeEnd = 1266944, XrefRangeStart = 1266930, XrefRangeEnd = 1266932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonUp(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000035B8 File Offset: 0x000017B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266946, RefRangeEnd = 1266948, XrefRangeStart = 1266944, XrefRangeEnd = 1266946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetJoystickNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000035EC File Offset: 0x000017EC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1266950, RefRangeEnd = 1266964, XrefRangeStart = 1266948, XrefRangeEnd = 1266950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Touch GetTouch(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000362C File Offset: 0x0000182C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266966, RefRangeEnd = 1266967, XrefRangeStart = 1266964, XrefRangeEnd = 1266966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PenData GetLastPenContactEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000365C File Offset: 0x0000185C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266969, RefRangeEnd = 1266970, XrefRangeStart = 1266967, XrefRangeEnd = 1266969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearLastPenContactEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003684 File Offset: 0x00001884
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 1266813, RefRangeEnd = 1266865, XrefRangeStart = 1266813, XrefRangeEnd = 1266865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000036C4 File Offset: 0x000018C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266972, RefRangeEnd = 1266973, XrefRangeStart = 1266970, XrefRangeEnd = 1266972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003708 File Offset: 0x00001908
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1266867, RefRangeEnd = 1266872, XrefRangeStart = 1266867, XrefRangeEnd = 1266872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUp(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003748 File Offset: 0x00001948
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1266874, RefRangeEnd = 1266897, XrefRangeStart = 1266874, XrefRangeEnd = 1266897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003788 File Offset: 0x00001988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266975, RefRangeEnd = 1266977, XrefRangeStart = 1266973, XrefRangeEnd = 1266975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000037CC File Offset: 0x000019CC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000037FC File Offset: 0x000019FC
		public unsafe static bool simulateMouseWithTouches
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1266979, RefRangeEnd = 1266981, XrefRangeStart = 1266977, XrefRangeEnd = 1266979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1266983, RefRangeEnd = 1266984, XrefRangeStart = 1266981, XrefRangeEnd = 1266983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003830 File Offset: 0x00001A30
		public unsafe static bool anyKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1266986, RefRangeEnd = 1266989, XrefRangeStart = 1266984, XrefRangeEnd = 1266986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003860 File Offset: 0x00001A60
		public unsafe static string inputString
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1266991, RefRangeEnd = 1266993, XrefRangeStart = 1266989, XrefRangeEnd = 1266991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000388C File Offset: 0x00001A8C
		public unsafe static Vector3 mousePosition
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1266995, RefRangeEnd = 1267012, XrefRangeStart = 1266993, XrefRangeEnd = 1266995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000038BC File Offset: 0x00001ABC
		public unsafe static Vector2 mouseScrollDelta
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1267014, RefRangeEnd = 1267021, XrefRangeStart = 1267012, XrefRangeEnd = 1267014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000038EC File Offset: 0x00001AEC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000391C File Offset: 0x00001B1C
		public unsafe static IMECompositionMode imeCompositionMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1267023, RefRangeEnd = 1267024, XrefRangeStart = 1267021, XrefRangeEnd = 1267023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1267026, RefRangeEnd = 1267027, XrefRangeStart = 1267024, XrefRangeEnd = 1267026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003950 File Offset: 0x00001B50
		public unsafe static string compositionString
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1267029, RefRangeEnd = 1267032, XrefRangeStart = 1267027, XrefRangeEnd = 1267029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000397C File Offset: 0x00001B7C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000039AC File Offset: 0x00001BAC
		public unsafe static Vector2 compositionCursorPos
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1267034, RefRangeEnd = 1267035, XrefRangeStart = 1267032, XrefRangeEnd = 1267034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1267037, RefRangeEnd = 1267038, XrefRangeStart = 1267035, XrefRangeEnd = 1267037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000039E0 File Offset: 0x00001BE0
		public unsafe static bool mousePresent
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1267040, RefRangeEnd = 1267046, XrefRangeStart = 1267038, XrefRangeEnd = 1267040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003A10 File Offset: 0x00001C10
		public unsafe static int touchCount
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1267048, RefRangeEnd = 1267086, XrefRangeStart = 1267046, XrefRangeEnd = 1267048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003A40 File Offset: 0x00001C40
		public unsafe static bool touchSupported
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1267088, RefRangeEnd = 1267092, XrefRangeStart = 1267086, XrefRangeEnd = 1267088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000217E File Offset: 0x0000037E
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00003A70 File Offset: 0x00001C70
		public unsafe static bool multiTouchEnabled
		{
			get
			{
				return Input.get_multiTouchEnabledDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1267094, RefRangeEnd = 1267096, XrefRangeStart = 1267092, XrefRangeEnd = 1267094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public unsafe static DeviceOrientation deviceOrientation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1267098, RefRangeEnd = 1267100, XrefRangeStart = 1267096, XrefRangeEnd = 1267098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_deviceOrientation_Public_Static_get_DeviceOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public unsafe static Il2CppStructArray<Touch> touches
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1267107, RefRangeEnd = 1267111, XrefRangeStart = 1267100, XrefRangeEnd = 1267107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Touch>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003B08 File Offset: 0x00001D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267111, XrefRangeEnd = 1267113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckDisabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003B38 File Offset: 0x00001D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267113, XrefRangeEnd = 1267115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTouch_Injected(int index, out Touch ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003B78 File Offset: 0x00001D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267115, XrefRangeEnd = 1267117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLastPenContactEvent_Injected(out PenData ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003BAC File Offset: 0x00001DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267117, XrefRangeEnd = 1267119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mousePosition_Injected(out Vector3 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003BE0 File Offset: 0x00001DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267119, XrefRangeEnd = 1267121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mouseScrollDelta_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003C14 File Offset: 0x00001E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267121, XrefRangeEnd = 1267123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003C48 File Offset: 0x00001E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267123, XrefRangeEnd = 1267125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000020EB File Offset: 0x000002EB
		public Input(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000020F4 File Offset: 0x000002F4
		public static void ResetInputAxes()
		{
			Input.ResetInputAxesDelegateField();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002100 File Offset: 0x00000300
		public static bool IsJoystickPreconfigured(string joystickName)
		{
			return InputUnsafeUtility.IsJoystickPreconfigured(joystickName);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003C7C File Offset: 0x00001E7C
		public static PenData GetPenEvent(int index)
		{
			PenData penData;
			Input.GetPenEvent_Injected(index, out penData);
			return penData;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002108 File Offset: 0x00000308
		public static void ResetPenEvents()
		{
			Input.ResetPenEventsDelegateField();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002114 File Offset: 0x00000314
		public static bool GetKeyUp(string name)
		{
			return InputUnsafeUtility.GetKeyUpString(name);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000211C File Offset: 0x0000031C
		public static void SimulateTouch(Touch touch)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000211F File Offset: 0x0000031F
		public static void SimulateTouchInternal(Touch touch, long timestamp)
		{
			Input.SimulateTouchInternal_Injected(ref touch, timestamp);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002129 File Offset: 0x00000329
		public static bool anyKeyDown
		{
			get
			{
				return Input.get_anyKeyDownDelegateField();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002135 File Offset: 0x00000335
		public static bool imeIsSelected
		{
			get
			{
				return Input.get_imeIsSelectedDelegateField();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002141 File Offset: 0x00000341
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000214D File Offset: 0x0000034D
		public static bool eatKeyPressOnTextFieldFocus
		{
			get
			{
				return Input.get_eatKeyPressOnTextFieldFocusDelegateField();
			}
			set
			{
				Input.set_eatKeyPressOnTextFieldFocusDelegateField(value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000215A File Offset: 0x0000035A
		public static int penEventCount
		{
			get
			{
				return Input.get_penEventCountDelegateField();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002166 File Offset: 0x00000366
		public static bool touchPressureSupported
		{
			get
			{
				return Input.get_touchPressureSupportedDelegateField();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002172 File Offset: 0x00000372
		public static bool stylusTouchSupported
		{
			get
			{
				return Input.get_stylusTouchSupportedDelegateField();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000218A File Offset: 0x0000038A
		public static bool isGyroAvailable
		{
			get
			{
				return Input.get_isGyroAvailableDelegateField();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003C94 File Offset: 0x00001E94
		public static Vector3 acceleration
		{
			get
			{
				Vector3 vector;
				Input.get_acceleration_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002196 File Offset: 0x00000396
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000021A2 File Offset: 0x000003A2
		public static bool compensateSensors
		{
			get
			{
				return Input.get_compensateSensorsDelegateField();
			}
			set
			{
				Input.set_compensateSensorsDelegateField(value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000021AF File Offset: 0x000003AF
		public static int accelerationEventCount
		{
			get
			{
				return Input.get_accelerationEventCountDelegateField();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000021BB File Offset: 0x000003BB
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021C7 File Offset: 0x000003C7
		public static bool backButtonLeavesApp
		{
			get
			{
				return Input.get_backButtonLeavesAppDelegateField();
			}
			set
			{
				Input.set_backButtonLeavesAppDelegateField(value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000021D4 File Offset: 0x000003D4
		public static LocationService location
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000021E1 File Offset: 0x000003E1
		public static Compass compass
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000021EE File Offset: 0x000003EE
		public static int GetGyroInternal()
		{
			return Input.GetGyroInternalDelegateField();
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000021FA File Offset: 0x000003FA
		public static Gyroscope gyro
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002207 File Offset: 0x00000407
		public static void GetPenEvent_Injected(int index, out PenData ret)
		{
			Input.GetPenEvent_InjectedDelegateField(index, out ret);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002215 File Offset: 0x00000415
		public static void SimulateTouchInternal_Injected(ref Touch touch, long timestamp)
		{
			Input.SimulateTouchInternal_InjectedDelegateField(ref touch, timestamp);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002223 File Offset: 0x00000423
		public static void get_acceleration_Injected(out Vector3 ret)
		{
			Input.get_acceleration_InjectedDelegateField(out ret);
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickNames_Public_Static_Il2CppStringArray_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_simulateMouseWithTouches_Public_Static_get_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_inputString_Public_Static_get_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceOrientation_Public_Static_get_DeviceOrientation_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x0400008C RID: 140
		private static readonly Input.ResetInputAxesDelegate ResetInputAxesDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Input.ResetPenEventsDelegate ResetPenEventsDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Input.get_anyKeyDownDelegate get_anyKeyDownDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Input.get_imeIsSelectedDelegate get_imeIsSelectedDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Input.get_eatKeyPressOnTextFieldFocusDelegate get_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly Input.set_eatKeyPressOnTextFieldFocusDelegate set_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly Input.get_penEventCountDelegate get_penEventCountDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Input.get_touchPressureSupportedDelegate get_touchPressureSupportedDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Input.get_stylusTouchSupportedDelegate get_stylusTouchSupportedDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Input.get_multiTouchEnabledDelegate get_multiTouchEnabledDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Input.get_isGyroAvailableDelegate get_isGyroAvailableDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Input.get_compensateSensorsDelegate get_compensateSensorsDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Input.set_compensateSensorsDelegate set_compensateSensorsDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Input.get_accelerationEventCountDelegate get_accelerationEventCountDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Input.get_backButtonLeavesAppDelegate get_backButtonLeavesAppDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Input.set_backButtonLeavesAppDelegate set_backButtonLeavesAppDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly Input.GetGyroInternalDelegate GetGyroInternalDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly Input.GetPenEvent_InjectedDelegate GetPenEvent_InjectedDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly Input.SimulateTouchInternal_InjectedDelegate SimulateTouchInternal_InjectedDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly Input.get_acceleration_InjectedDelegate get_acceleration_InjectedDelegateField;

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000CD RID: 205
		private delegate void ResetInputAxesDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000CF RID: 207
		private delegate void ResetPenEventsDelegate();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000D1 RID: 209
		private delegate bool get_anyKeyDownDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000D3 RID: 211
		private delegate bool get_imeIsSelectedDelegate();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000D5 RID: 213
		private delegate bool get_eatKeyPressOnTextFieldFocusDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000D7 RID: 215
		private delegate void set_eatKeyPressOnTextFieldFocusDelegate(bool value);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000D9 RID: 217
		private delegate int get_penEventCountDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000DB RID: 219
		private delegate bool get_touchPressureSupportedDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000DD RID: 221
		private delegate bool get_stylusTouchSupportedDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000DF RID: 223
		private delegate bool get_multiTouchEnabledDelegate();

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000E1 RID: 225
		private delegate bool get_isGyroAvailableDelegate();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000E3 RID: 227
		private delegate bool get_compensateSensorsDelegate();

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000E5 RID: 229
		private delegate void set_compensateSensorsDelegate(bool value);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000E7 RID: 231
		private delegate int get_accelerationEventCountDelegate();

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000E9 RID: 233
		private delegate bool get_backButtonLeavesAppDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000EB RID: 235
		private delegate void set_backButtonLeavesAppDelegate(bool value);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000ED RID: 237
		private delegate int GetGyroInternalDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000EF RID: 239
		private delegate void GetPenEvent_InjectedDelegate(int index, [Out] IntPtr ret);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000F1 RID: 241
		private delegate void SimulateTouchInternal_InjectedDelegate(IntPtr touch, long timestamp);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000F3 RID: 243
		private delegate void get_acceleration_InjectedDelegate([Out] IntPtr ret);
	}
}
