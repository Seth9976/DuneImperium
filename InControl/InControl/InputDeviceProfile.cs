using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace InControl
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	public class InputDeviceProfile : Object
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x0001984C File Offset: 0x00017A4C
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceProfile()
		{
			Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDeviceProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr);
			InputDeviceProfile.NativeFieldInfoPtr_hiddenProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "hiddenProfiles");
			InputDeviceProfile.NativeFieldInfoPtr_profileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "profileType");
			InputDeviceProfile.NativeFieldInfoPtr_deviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "deviceName");
			InputDeviceProfile.NativeFieldInfoPtr_deviceNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "deviceNotes");
			InputDeviceProfile.NativeFieldInfoPtr_deviceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "deviceClass");
			InputDeviceProfile.NativeFieldInfoPtr_deviceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "deviceStyle");
			InputDeviceProfile.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "sensitivity");
			InputDeviceProfile.NativeFieldInfoPtr_lowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "lowerDeadZone");
			InputDeviceProfile.NativeFieldInfoPtr_upperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "upperDeadZone");
			InputDeviceProfile.NativeFieldInfoPtr_includePlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "includePlatforms");
			InputDeviceProfile.NativeFieldInfoPtr_excludePlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "excludePlatforms");
			InputDeviceProfile.NativeFieldInfoPtr_minSystemBuildNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "minSystemBuildNumber");
			InputDeviceProfile.NativeFieldInfoPtr_maxSystemBuildNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "maxSystemBuildNumber");
			InputDeviceProfile.NativeFieldInfoPtr_minUnityVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "minUnityVersion");
			InputDeviceProfile.NativeFieldInfoPtr_maxUnityVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "maxUnityVersion");
			InputDeviceProfile.NativeFieldInfoPtr_matchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "matchers");
			InputDeviceProfile.NativeFieldInfoPtr_lastResortMatchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "lastResortMatchers");
			InputDeviceProfile.NativeFieldInfoPtr_analogMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "analogMappings");
			InputDeviceProfile.NativeFieldInfoPtr_buttonMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "buttonMappings");
			InputDeviceProfile.NativeFieldInfoPtr_MenuKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "MenuKey");
			InputDeviceProfile.NativeFieldInfoPtr_EscapeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, "EscapeKey");
			InputDeviceProfile.NativeMethodInfoPtr_get_ProfileType_Public_get_InputDeviceProfileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663950);
			InputDeviceProfile.NativeMethodInfoPtr_set_ProfileType_Protected_set_Void_InputDeviceProfileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663951);
			InputDeviceProfile.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663952);
			InputDeviceProfile.NativeMethodInfoPtr_set_DeviceName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663953);
			InputDeviceProfile.NativeMethodInfoPtr_get_DeviceNotes_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663954);
			InputDeviceProfile.NativeMethodInfoPtr_set_DeviceNotes_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663955);
			InputDeviceProfile.NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663956);
			InputDeviceProfile.NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663957);
			InputDeviceProfile.NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663958);
			InputDeviceProfile.NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663959);
			InputDeviceProfile.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663960);
			InputDeviceProfile.NativeMethodInfoPtr_set_Sensitivity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663961);
			InputDeviceProfile.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663962);
			InputDeviceProfile.NativeMethodInfoPtr_set_LowerDeadZone_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663963);
			InputDeviceProfile.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663964);
			InputDeviceProfile.NativeMethodInfoPtr_set_UpperDeadZone_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663965);
			InputDeviceProfile.NativeMethodInfoPtr_get_AnalogMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663966);
			InputDeviceProfile.NativeMethodInfoPtr_set_AnalogMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663967);
			InputDeviceProfile.NativeMethodInfoPtr_get_ButtonMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663968);
			InputDeviceProfile.NativeMethodInfoPtr_set_ButtonMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663969);
			InputDeviceProfile.NativeMethodInfoPtr_get_IncludePlatforms_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663970);
			InputDeviceProfile.NativeMethodInfoPtr_set_IncludePlatforms_Protected_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663971);
			InputDeviceProfile.NativeMethodInfoPtr_get_ExcludePlatforms_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663972);
			InputDeviceProfile.NativeMethodInfoPtr_set_ExcludePlatforms_Protected_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663973);
			InputDeviceProfile.NativeMethodInfoPtr_get_MinSystemBuildNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663974);
			InputDeviceProfile.NativeMethodInfoPtr_set_MinSystemBuildNumber_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663975);
			InputDeviceProfile.NativeMethodInfoPtr_get_MaxSystemBuildNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663976);
			InputDeviceProfile.NativeMethodInfoPtr_set_MaxSystemBuildNumber_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663977);
			InputDeviceProfile.NativeMethodInfoPtr_get_MinUnityVersion_Public_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663978);
			InputDeviceProfile.NativeMethodInfoPtr_set_MinUnityVersion_Protected_set_Void_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663979);
			InputDeviceProfile.NativeMethodInfoPtr_get_MaxUnityVersion_Public_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663980);
			InputDeviceProfile.NativeMethodInfoPtr_set_MaxUnityVersion_Protected_set_Void_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663981);
			InputDeviceProfile.NativeMethodInfoPtr_get_Matchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663982);
			InputDeviceProfile.NativeMethodInfoPtr_set_Matchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663983);
			InputDeviceProfile.NativeMethodInfoPtr_get_LastResortMatchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663984);
			InputDeviceProfile.NativeMethodInfoPtr_set_LastResortMatchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663985);
			InputDeviceProfile.NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663986);
			InputDeviceProfile.NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663987);
			InputDeviceProfile.NativeMethodInfoPtr_Define_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663988);
			InputDeviceProfile.NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663989);
			InputDeviceProfile.NativeMethodInfoPtr_LastResortMatches_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663990);
			InputDeviceProfile.NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_Il2CppReferenceArray_1_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663991);
			InputDeviceProfile.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663992);
			InputDeviceProfile.NativeMethodInfoPtr_Hide_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663993);
			InputDeviceProfile.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663994);
			InputDeviceProfile.NativeMethodInfoPtr_get_IsNotHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663995);
			InputDeviceProfile.NativeMethodInfoPtr_get_AnalogCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663996);
			InputDeviceProfile.NativeMethodInfoPtr_get_ButtonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663997);
			InputDeviceProfile.NativeMethodInfoPtr_Button_Protected_Static_InputControlSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663998);
			InputDeviceProfile.NativeMethodInfoPtr_Analog_Protected_Static_InputControlSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100663999);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664000);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664001);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664002);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664003);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickUpMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664004);
			InputDeviceProfile.NativeMethodInfoPtr_LeftStickDownMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664005);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664006);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664007);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664008);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664009);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickUpMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664010);
			InputDeviceProfile.NativeMethodInfoPtr_RightStickDownMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664011);
			InputDeviceProfile.NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664012);
			InputDeviceProfile.NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664013);
			InputDeviceProfile.NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664014);
			InputDeviceProfile.NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664015);
			InputDeviceProfile.NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664016);
			InputDeviceProfile.NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664017);
			InputDeviceProfile.NativeMethodInfoPtr_DPadUpMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664018);
			InputDeviceProfile.NativeMethodInfoPtr_DPadDownMapping2_Protected_Static_InputControlMapping_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664019);
			InputDeviceProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr, 100664020);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00019FAC File Offset: 0x000181AC
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00019FE8 File Offset: 0x000181E8
		public unsafe InputDeviceProfileType ProfileType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_ProfileType_Public_get_InputDeviceProfileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_ProfileType_Protected_set_Void_InputDeviceProfileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001A028 File Offset: 0x00018228
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0001A060 File Offset: 0x00018260
		public unsafe string DeviceName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_DeviceName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001A0A4 File Offset: 0x000182A4
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0001A0DC File Offset: 0x000182DC
		public unsafe string DeviceNotes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_DeviceNotes_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_DeviceNotes_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001A120 File Offset: 0x00018320
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0001A15C File Offset: 0x0001835C
		public unsafe InputDeviceClass DeviceClass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0001A19C File Offset: 0x0001839C
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0001A1D8 File Offset: 0x000183D8
		public unsafe InputDeviceStyle DeviceStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001A218 File Offset: 0x00018418
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0001A254 File Offset: 0x00018454
		public unsafe float Sensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_Sensitivity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001A294 File Offset: 0x00018494
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0001A2D0 File Offset: 0x000184D0
		public unsafe float LowerDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 774918, RefRangeEnd = 774921, XrefRangeStart = 774918, XrefRangeEnd = 774918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_LowerDeadZone_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001A310 File Offset: 0x00018510
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0001A34C File Offset: 0x0001854C
		public unsafe float UpperDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 774921, RefRangeEnd = 774928, XrefRangeStart = 774921, XrefRangeEnd = 774921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_UpperDeadZone_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001A38C File Offset: 0x0001858C
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0001A3CC File Offset: 0x000185CC
		public unsafe Il2CppReferenceArray<InputControlMapping> AnalogMappings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_AnalogMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControlMapping>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_AnalogMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001A410 File Offset: 0x00018610
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0001A450 File Offset: 0x00018650
		public unsafe Il2CppReferenceArray<InputControlMapping> ButtonMappings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_ButtonMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControlMapping>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_ButtonMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001A494 File Offset: 0x00018694
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0001A4D4 File Offset: 0x000186D4
		public unsafe Il2CppStringArray IncludePlatforms
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_IncludePlatforms_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_IncludePlatforms_Protected_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001A518 File Offset: 0x00018718
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x0001A558 File Offset: 0x00018758
		public unsafe Il2CppStringArray ExcludePlatforms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_ExcludePlatforms_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_ExcludePlatforms_Protected_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001A59C File Offset: 0x0001879C
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0001A5D8 File Offset: 0x000187D8
		public unsafe int MinSystemBuildNumber
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_MinSystemBuildNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_MinSystemBuildNumber_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001A618 File Offset: 0x00018818
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0001A654 File Offset: 0x00018854
		public unsafe int MaxSystemBuildNumber
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_MaxSystemBuildNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_MaxSystemBuildNumber_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0001A694 File Offset: 0x00018894
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0001A6D0 File Offset: 0x000188D0
		public unsafe VersionInfo MinUnityVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_MinUnityVersion_Public_get_VersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_MinUnityVersion_Protected_set_Void_VersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001A710 File Offset: 0x00018910
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0001A74C File Offset: 0x0001894C
		public unsafe VersionInfo MaxUnityVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_MaxUnityVersion_Public_get_VersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_MaxUnityVersion_Protected_set_Void_VersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0001A78C File Offset: 0x0001898C
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0001A7CC File Offset: 0x000189CC
		public unsafe Il2CppReferenceArray<InputDeviceMatcher> Matchers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_Matchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDeviceMatcher>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_Matchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0001A810 File Offset: 0x00018A10
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0001A850 File Offset: 0x00018A50
		public unsafe Il2CppReferenceArray<InputDeviceMatcher> LastResortMatchers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_LastResortMatchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDeviceMatcher>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_set_LastResortMatchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001A894 File Offset: 0x00018A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774928, XrefRangeEnd = 774931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDeviceProfile CreateInstanceOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 774948, RefRangeEnd = 774952, XrefRangeStart = 774931, XrefRangeEnd = 774948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDeviceProfile CreateInstanceOfType(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001A91C File Offset: 0x00018B1C
		[CallerCount(251)]
		[CachedScanResults(RefRangeStart = 774959, RefRangeEnd = 775210, XrefRangeStart = 774952, XrefRangeEnd = 774959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceProfile.NativeMethodInfoPtr_Define_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001A958 File Offset: 0x00018B58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 775211, RefRangeEnd = 775215, XrefRangeStart = 775210, XrefRangeEnd = 775211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001A9AC File Offset: 0x00018BAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 775216, RefRangeEnd = 775220, XrefRangeStart = 775215, XrefRangeEnd = 775216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LastResortMatches(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LastResortMatches_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001AA00 File Offset: 0x00018C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775220, XrefRangeEnd = 775221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(InputDeviceInfo deviceInfo, Il2CppReferenceArray<InputDeviceMatcher> matchers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_Il2CppReferenceArray_1_InputDeviceMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001AA64 File Offset: 0x00018C64
		public unsafe bool IsSupportedOnThisPlatform
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 775245, RefRangeEnd = 775251, XrefRangeStart = 775221, XrefRangeEnd = 775245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 775259, RefRangeEnd = 775260, XrefRangeStart = 775251, XrefRangeEnd = 775259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hide(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_Hide_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		public unsafe bool IsHidden
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 775269, RefRangeEnd = 775270, XrefRangeStart = 775260, XrefRangeEnd = 775269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001AB14 File Offset: 0x00018D14
		public unsafe bool IsNotHidden
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 775278, RefRangeEnd = 775279, XrefRangeStart = 775270, XrefRangeEnd = 775278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_IsNotHidden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001AB50 File Offset: 0x00018D50
		public unsafe int AnalogCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 775279, RefRangeEnd = 775281, XrefRangeStart = 775279, XrefRangeEnd = 775279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_AnalogCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001AB8C File Offset: 0x00018D8C
		public unsafe int ButtonCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 775281, RefRangeEnd = 775283, XrefRangeStart = 775281, XrefRangeEnd = 775281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_get_ButtonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[CallerCount(2774)]
		[CachedScanResults(RefRangeStart = 775283, RefRangeEnd = 778057, XrefRangeStart = 775283, XrefRangeEnd = 775283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlSource Button(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_Button_Protected_Static_InputControlSource_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001AC08 File Offset: 0x00018E08
		[CallerCount(1009)]
		[CachedScanResults(RefRangeStart = 778057, RefRangeEnd = 779066, XrefRangeStart = 778057, XrefRangeEnd = 778057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlSource Analog(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_Analog_Protected_Static_InputControlSource_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001AC48 File Offset: 0x00018E48
		[CallerCount(157)]
		[CachedScanResults(RefRangeStart = 779076, RefRangeEnd = 779233, XrefRangeStart = 779066, XrefRangeEnd = 779076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickLeftMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001AC88 File Offset: 0x00018E88
		[CallerCount(157)]
		[CachedScanResults(RefRangeStart = 779243, RefRangeEnd = 779400, XrefRangeStart = 779233, XrefRangeEnd = 779243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickRightMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		[CallerCount(150)]
		[CachedScanResults(RefRangeStart = 779410, RefRangeEnd = 779560, XrefRangeStart = 779400, XrefRangeEnd = 779410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickUpMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001AD08 File Offset: 0x00018F08
		[CallerCount(150)]
		[CachedScanResults(RefRangeStart = 779570, RefRangeEnd = 779720, XrefRangeStart = 779560, XrefRangeEnd = 779570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickDownMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001AD48 File Offset: 0x00018F48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 779730, RefRangeEnd = 779737, XrefRangeStart = 779720, XrefRangeEnd = 779730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickUpMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickUpMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001AD88 File Offset: 0x00018F88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 779747, RefRangeEnd = 779754, XrefRangeStart = 779737, XrefRangeEnd = 779747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickDownMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftStickDownMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		[CallerCount(156)]
		[CachedScanResults(RefRangeStart = 779764, RefRangeEnd = 779920, XrefRangeStart = 779754, XrefRangeEnd = 779764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickLeftMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001AE08 File Offset: 0x00019008
		[CallerCount(156)]
		[CachedScanResults(RefRangeStart = 779930, RefRangeEnd = 780086, XrefRangeStart = 779920, XrefRangeEnd = 779930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickRightMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001AE48 File Offset: 0x00019048
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 780096, RefRangeEnd = 780244, XrefRangeStart = 780086, XrefRangeEnd = 780096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickUpMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001AE88 File Offset: 0x00019088
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 780254, RefRangeEnd = 780402, XrefRangeStart = 780244, XrefRangeEnd = 780254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickDownMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001AEC8 File Offset: 0x000190C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 780412, RefRangeEnd = 780419, XrefRangeStart = 780402, XrefRangeEnd = 780412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickUpMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickUpMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001AF08 File Offset: 0x00019108
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 780429, RefRangeEnd = 780436, XrefRangeStart = 780419, XrefRangeEnd = 780429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickDownMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightStickDownMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001AF48 File Offset: 0x00019148
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 780444, RefRangeEnd = 780460, XrefRangeStart = 780436, XrefRangeEnd = 780444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftTriggerMapping(int analog, string name = "Left Trigger")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001AF9C File Offset: 0x0001919C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 780468, RefRangeEnd = 780484, XrefRangeStart = 780460, XrefRangeEnd = 780468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightTriggerMapping(int analog, string name = "Right Trigger")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001AFF0 File Offset: 0x000191F0
		[CallerCount(130)]
		[CachedScanResults(RefRangeStart = 780494, RefRangeEnd = 780624, XrefRangeStart = 780484, XrefRangeEnd = 780494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadLeftMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001B030 File Offset: 0x00019230
		[CallerCount(130)]
		[CachedScanResults(RefRangeStart = 780634, RefRangeEnd = 780764, XrefRangeStart = 780624, XrefRangeEnd = 780634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadRightMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001B070 File Offset: 0x00019270
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 780774, RefRangeEnd = 780879, XrefRangeStart = 780764, XrefRangeEnd = 780774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadUpMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001B0B0 File Offset: 0x000192B0
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 780889, RefRangeEnd = 780994, XrefRangeStart = 780879, XrefRangeEnd = 780889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadDownMapping(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 781004, RefRangeEnd = 781029, XrefRangeStart = 780994, XrefRangeEnd = 781004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadUpMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadUpMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001B130 File Offset: 0x00019330
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 781039, RefRangeEnd = 781064, XrefRangeStart = 781029, XrefRangeEnd = 781039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadDownMapping2(int analog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref analog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr_DPadDownMapping2_Protected_Static_InputControlMapping_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001B170 File Offset: 0x00019370
		[CallerCount(263)]
		[CachedScanResults(RefRangeStart = 781095, RefRangeEnd = 781358, XrefRangeStart = 781064, XrefRangeEnd = 781095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00003EB6 File Offset: 0x000020B6
		public InputDeviceProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001B1AC File Offset: 0x000193AC
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003EBF File Offset: 0x000020BF
		public unsafe static HashSet<Type> hiddenProfiles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputDeviceProfile.NativeFieldInfoPtr_hiddenProfiles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDeviceProfile.NativeFieldInfoPtr_hiddenProfiles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001B1D4 File Offset: 0x000193D4
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00003ED1 File Offset: 0x000020D1
		public unsafe InputDeviceProfileType profileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_profileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_profileType)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001B1FC File Offset: 0x000193FC
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00003EEC File Offset: 0x000020EC
		public unsafe string deviceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001B224 File Offset: 0x00019424
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00003F0B File Offset: 0x0000210B
		public unsafe string deviceNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceNotes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceNotes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0001B24C File Offset: 0x0001944C
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003F2A File Offset: 0x0000212A
		public unsafe InputDeviceClass deviceClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceClass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceClass)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001B274 File Offset: 0x00019474
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00003F45 File Offset: 0x00002145
		public unsafe InputDeviceStyle deviceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_deviceStyle)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001B29C File Offset: 0x0001949C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003F60 File Offset: 0x00002160
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001B2C4 File Offset: 0x000194C4
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003F7B File Offset: 0x0000217B
		public unsafe float lowerDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_lowerDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_lowerDeadZone)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001B2EC File Offset: 0x000194EC
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003F96 File Offset: 0x00002196
		public unsafe float upperDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_upperDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_upperDeadZone)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001B314 File Offset: 0x00019514
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003FB1 File Offset: 0x000021B1
		public unsafe Il2CppStringArray includePlatforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_includePlatforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_includePlatforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001B344 File Offset: 0x00019544
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003FD0 File Offset: 0x000021D0
		public unsafe Il2CppStringArray excludePlatforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_excludePlatforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_excludePlatforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001B374 File Offset: 0x00019574
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003FEF File Offset: 0x000021EF
		public unsafe int minSystemBuildNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_minSystemBuildNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_minSystemBuildNumber)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001B39C File Offset: 0x0001959C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0000400A File Offset: 0x0000220A
		public unsafe int maxSystemBuildNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_maxSystemBuildNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_maxSystemBuildNumber)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001B3C4 File Offset: 0x000195C4
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00004025 File Offset: 0x00002225
		public unsafe VersionInfo minUnityVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_minUnityVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_minUnityVersion)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001B3EC File Offset: 0x000195EC
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004040 File Offset: 0x00002240
		public unsafe VersionInfo maxUnityVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_maxUnityVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_maxUnityVersion)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001B414 File Offset: 0x00019614
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000405B File Offset: 0x0000225B
		public unsafe Il2CppReferenceArray<InputDeviceMatcher> matchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_matchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDeviceMatcher>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_matchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001B444 File Offset: 0x00019644
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000407A File Offset: 0x0000227A
		public unsafe Il2CppReferenceArray<InputDeviceMatcher> lastResortMatchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_lastResortMatchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDeviceMatcher>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_lastResortMatchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001B474 File Offset: 0x00019674
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004099 File Offset: 0x00002299
		public unsafe Il2CppReferenceArray<InputControlMapping> analogMappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_analogMappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControlMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_analogMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001B4A4 File Offset: 0x000196A4
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x000040B8 File Offset: 0x000022B8
		public unsafe Il2CppReferenceArray<InputControlMapping> buttonMappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_buttonMappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControlMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceProfile.NativeFieldInfoPtr_buttonMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001B4D4 File Offset: 0x000196D4
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x000040D7 File Offset: 0x000022D7
		public unsafe static InputControlSource MenuKey
		{
			get
			{
				InputControlSource inputControlSource;
				IL2CPP.il2cpp_field_static_get_value(InputDeviceProfile.NativeFieldInfoPtr_MenuKey, (void*)(&inputControlSource));
				return inputControlSource;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDeviceProfile.NativeFieldInfoPtr_MenuKey, (void*)(&value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001B4F0 File Offset: 0x000196F0
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000040E5 File Offset: 0x000022E5
		public unsafe static InputControlSource EscapeKey
		{
			get
			{
				InputControlSource inputControlSource;
				IL2CPP.il2cpp_field_static_get_value(InputDeviceProfile.NativeFieldInfoPtr_EscapeKey, (void*)(&inputControlSource));
				return inputControlSource;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDeviceProfile.NativeFieldInfoPtr_EscapeKey, (void*)(&value));
			}
		}

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_hiddenProfiles;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_profileType;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_deviceName;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_deviceNotes;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_deviceClass;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_deviceStyle;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_lowerDeadZone;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_upperDeadZone;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_includePlatforms;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_excludePlatforms;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_minSystemBuildNumber;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_maxSystemBuildNumber;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_minUnityVersion;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_maxUnityVersion;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_matchers;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_lastResortMatchers;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_analogMappings;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_buttonMappings;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_MenuKey;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_EscapeKey;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_get_ProfileType_Public_get_InputDeviceProfileType_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_set_ProfileType_Protected_set_Void_InputDeviceProfileType_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_get_String_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceName_Protected_set_Void_String_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceNotes_Public_get_String_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceNotes_Protected_set_Void_String_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_get_InputDeviceClass_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceClass_Protected_set_Void_InputDeviceClass_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_get_InputDeviceStyle_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceStyle_Protected_set_Void_InputDeviceStyle_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Protected_set_Void_Single_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Protected_set_Void_Single_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Protected_set_Void_Single_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_get_AnalogMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_set_AnalogMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonMappings_Public_get_Il2CppReferenceArray_1_InputControlMapping_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_set_ButtonMappings_Protected_set_Void_Il2CppReferenceArray_1_InputControlMapping_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludePlatforms_Public_get_Il2CppStringArray_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludePlatforms_Protected_set_Void_Il2CppStringArray_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludePlatforms_Public_get_Il2CppStringArray_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_set_ExcludePlatforms_Protected_set_Void_Il2CppStringArray_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSystemBuildNumber_Public_get_Int32_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_set_MinSystemBuildNumber_Protected_set_Void_Int32_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSystemBuildNumber_Public_get_Int32_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxSystemBuildNumber_Protected_set_Void_Int32_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_MinUnityVersion_Public_get_VersionInfo_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_set_MinUnityVersion_Protected_set_Void_VersionInfo_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxUnityVersion_Public_get_VersionInfo_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxUnityVersion_Protected_set_Void_VersionInfo_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_Matchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_set_Matchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_LastResortMatchers_Public_get_Il2CppReferenceArray_1_InputDeviceMatcher_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_set_LastResortMatchers_Protected_set_Void_Il2CppReferenceArray_1_InputDeviceMatcher_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_Type_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceOfType_Public_Static_InputDeviceProfile_String_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_New_Void_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_LastResortMatches_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_InputDeviceInfo_Il2CppReferenceArray_1_InputDeviceMatcher_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_get_Boolean_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Static_Void_Type_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotHidden_Public_get_Boolean_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_get_AnalogCount_Public_get_Int32_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonCount_Public_get_Int32_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_Button_Protected_Static_InputControlSource_Int32_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_Analog_Protected_Static_InputControlSource_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickUpMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickDownMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_RightStickUpMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_RightStickDownMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_Int32_String_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_DPadUpMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_DPadDownMapping2_Protected_Static_InputControlMapping_Int32_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
