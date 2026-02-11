using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000047 RID: 71
	public class NativeInputDevice : InputDevice
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x0001FD20 File Offset: 0x0001DF20
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputDevice()
		{
			Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr);
			NativeInputDevice.NativeFieldInfoPtr_maxUnknownButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "maxUnknownButtons");
			NativeInputDevice.NativeFieldInfoPtr_maxUnknownAnalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "maxUnknownAnalogs");
			NativeInputDevice.NativeFieldInfoPtr__Handle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "<Handle>k__BackingField");
			NativeInputDevice.NativeFieldInfoPtr__Info_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "<Info>k__BackingField");
			NativeInputDevice.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "buttons");
			NativeInputDevice.NativeFieldInfoPtr_analogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "analogs");
			NativeInputDevice.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "profile");
			NativeInputDevice.NativeFieldInfoPtr_skipUpdateFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "skipUpdateFrames");
			NativeInputDevice.NativeFieldInfoPtr_numUnknownButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "numUnknownButtons");
			NativeInputDevice.NativeFieldInfoPtr_numUnknownAnalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "numUnknownAnalogs");
			NativeInputDevice.NativeFieldInfoPtr_controlSourceByTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "controlSourceByTarget");
			NativeInputDevice.NativeFieldInfoPtr_sendVibrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "sendVibrate");
			NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateWasSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lastTimeVibrateWasSent");
			NativeInputDevice.NativeFieldInfoPtr_vibrateToSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "vibrateToSend");
			NativeInputDevice.NativeFieldInfoPtr_sendVibrateTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "sendVibrateTriggers");
			NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateTriggersWasSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lastTimeVibrateTriggersWasSent");
			NativeInputDevice.NativeFieldInfoPtr_vibrateTriggersToSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "vibrateTriggersToSend");
			NativeInputDevice.NativeFieldInfoPtr_sendLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "sendLightColor");
			NativeInputDevice.NativeFieldInfoPtr_lastTimeLightColorWasSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lastTimeLightColorWasSent");
			NativeInputDevice.NativeFieldInfoPtr_lightColorToSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lightColorToSend");
			NativeInputDevice.NativeFieldInfoPtr_sendLightFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "sendLightFlash");
			NativeInputDevice.NativeFieldInfoPtr_lastTimeLightFlashWasSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lastTimeLightFlashWasSent");
			NativeInputDevice.NativeFieldInfoPtr_lightFlashToSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "lightFlashToSend");
			NativeInputDevice.NativeFieldInfoPtr_glyphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "glyphName");
			NativeInputDevice.NativeFieldInfoPtr_defaultGlyphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, "defaultGlyphName");
			NativeInputDevice.NativeMethodInfoPtr_get_Handle_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664209);
			NativeInputDevice.NativeMethodInfoPtr_set_Handle_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664210);
			NativeInputDevice.NativeMethodInfoPtr_get_Info_Public_get_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664211);
			NativeInputDevice.NativeMethodInfoPtr_set_Info_Private_set_Void_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664212);
			NativeInputDevice.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664213);
			NativeInputDevice.NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664214);
			NativeInputDevice.NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664215);
			NativeInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664216);
			NativeInputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664217);
			NativeInputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664218);
			NativeInputDevice.NativeMethodInfoPtr_FloatToByte_Private_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664219);
			NativeInputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664220);
			NativeInputDevice.NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664221);
			NativeInputDevice.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664222);
			NativeInputDevice.NativeMethodInfoPtr_SetLightFlash_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664223);
			NativeInputDevice.NativeMethodInfoPtr_SendStatusUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664224);
			NativeInputDevice.NativeMethodInfoPtr_GetAppleGlyphNameForControl_Public_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664225);
			NativeInputDevice.NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664226);
			NativeInputDevice.NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664227);
			NativeInputDevice.NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664228);
			NativeInputDevice.NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664229);
			NativeInputDevice.NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664230);
			NativeInputDevice.NativeMethodInfoPtr_get_ProfileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664231);
			NativeInputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664232);
			NativeInputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664233);
			NativeInputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664234);
			NativeInputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr, 100664235);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00020160 File Offset: 0x0001E360
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0002019C File Offset: 0x0001E39C
		public unsafe uint Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_get_Handle_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_set_Handle_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000201DC File Offset: 0x0001E3DC
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00020214 File Offset: 0x0001E414
		public unsafe InputDeviceInfo Info
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_get_Info_Public_get_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputDeviceInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784079, XrefRangeEnd = 784080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_set_Info_Private_set_Void_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0002025C File Offset: 0x0001E45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784080, XrefRangeEnd = 784089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00020298 File Offset: 0x0001E498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 784125, RefRangeEnd = 784127, XrefRangeStart = 784089, XrefRangeEnd = 784125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo, InputDeviceProfile deviceProfile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deviceProfile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00020300 File Offset: 0x0001E500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784127, XrefRangeEnd = 784128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00020358 File Offset: 0x0001E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784128, XrefRangeEnd = 784141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000203B0 File Offset: 0x0001E5B0
		[CallerCount(0)]
		public unsafe override bool ReadRawButtonState(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00020404 File Offset: 0x0001E604
		[CallerCount(0)]
		public unsafe override float ReadRawAnalogValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00020458 File Offset: 0x0001E658
		[CallerCount(0)]
		public unsafe static byte FloatToByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_FloatToByte_Private_Static_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00020498 File Offset: 0x0001E698
		[CallerCount(0)]
		public unsafe override void Vibrate(float leftSpeed, float rightSpeed)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000204F0 File Offset: 0x0001E6F0
		[CallerCount(0)]
		public unsafe override void VibrateTriggers(float leftTriggerSpeed, float rightTriggerSpeed)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00020548 File Offset: 0x0001E748
		[CallerCount(0)]
		public unsafe override void SetLightColor(float red, float green, float blue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Void_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[CallerCount(0)]
		public unsafe override void SetLightFlash(float flashOnDuration, float flashOffDuration)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_SetLightFlash_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00020608 File Offset: 0x0001E808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784203, RefRangeEnd = 784204, XrefRangeStart = 784141, XrefRangeEnd = 784203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStatusUpdates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_SendStatusUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0002063C File Offset: 0x0001E83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784216, RefRangeEnd = 784217, XrefRangeStart = 784204, XrefRangeEnd = 784216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAppleGlyphNameForControl(InputControlType controlType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_GetAppleGlyphNameForControl_Public_String_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00020680 File Offset: 0x0001E880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784217, XrefRangeEnd = 784218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000206D4 File Offset: 0x0001E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784218, XrefRangeEnd = 784219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00020728 File Offset: 0x0001E928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784219, XrefRangeEnd = 784220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0002077C File Offset: 0x0001E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784220, XrefRangeEnd = 784221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000207D0 File Offset: 0x0001E9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784221, XrefRangeEnd = 784222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00020824 File Offset: 0x0001EA24
		public unsafe string ProfileName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 784224, RefRangeEnd = 784225, XrefRangeStart = 784222, XrefRangeEnd = 784224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDevice.NativeMethodInfoPtr_get_ProfileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0002085C File Offset: 0x0001EA5C
		public unsafe override bool IsSupportedOnThisPlatform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public unsafe override bool IsKnown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000208EC File Offset: 0x0001EAEC
		public unsafe override int NumUnknownButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00020934 File Offset: 0x0001EB34
		public unsafe override int NumUnknownAnalogs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDevice.NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00004786 File Offset: 0x00002986
		public NativeInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002097C File Offset: 0x0001EB7C
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0000478F File Offset: 0x0000298F
		public unsafe static int maxUnknownButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NativeInputDevice.NativeFieldInfoPtr_maxUnknownButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputDevice.NativeFieldInfoPtr_maxUnknownButtons, (void*)(&value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00020998 File Offset: 0x0001EB98
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0000479D File Offset: 0x0000299D
		public unsafe static int maxUnknownAnalogs
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NativeInputDevice.NativeFieldInfoPtr_maxUnknownAnalogs, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputDevice.NativeFieldInfoPtr_maxUnknownAnalogs, (void*)(&value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000209B4 File Offset: 0x0001EBB4
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000047AB File Offset: 0x000029AB
		public unsafe uint _Handle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr__Handle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr__Handle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x000209DC File Offset: 0x0001EBDC
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000047C6 File Offset: 0x000029C6
		public InputDeviceInfo _Info_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr__Info_k__BackingField);
				return new InputDeviceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr__Info_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00020A0C File Offset: 0x0001EC0C
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000047F4 File Offset: 0x000029F4
		public unsafe Il2CppStructArray<short> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00020A3C File Offset: 0x0001EC3C
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00004813 File Offset: 0x00002A13
		public unsafe Il2CppStructArray<short> analogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_analogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_analogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00020A6C File Offset: 0x0001EC6C
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004832 File Offset: 0x00002A32
		public unsafe InputDeviceProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDeviceProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00020A9C File Offset: 0x0001EC9C
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004851 File Offset: 0x00002A51
		public unsafe int skipUpdateFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_skipUpdateFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_skipUpdateFrames)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00020AC4 File Offset: 0x0001ECC4
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x0000486C File Offset: 0x00002A6C
		public unsafe int numUnknownButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_numUnknownButtons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_numUnknownButtons)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00020AEC File Offset: 0x0001ECEC
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004887 File Offset: 0x00002A87
		public unsafe int numUnknownAnalogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_numUnknownAnalogs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_numUnknownAnalogs)) = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00020B14 File Offset: 0x0001ED14
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x000048A2 File Offset: 0x00002AA2
		public unsafe Il2CppStructArray<InputControlSource> controlSourceByTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_controlSourceByTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputControlSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_controlSourceByTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00020B44 File Offset: 0x0001ED44
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000048C1 File Offset: 0x00002AC1
		public unsafe bool sendVibrate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendVibrate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendVibrate)) = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00020B6C File Offset: 0x0001ED6C
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x000048DC File Offset: 0x00002ADC
		public unsafe float lastTimeVibrateWasSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateWasSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateWasSent)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00020B94 File Offset: 0x0001ED94
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x000048F7 File Offset: 0x00002AF7
		public unsafe Vector2 vibrateToSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_vibrateToSend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_vibrateToSend)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00020BBC File Offset: 0x0001EDBC
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00004912 File Offset: 0x00002B12
		public unsafe bool sendVibrateTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendVibrateTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendVibrateTriggers)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00020BE4 File Offset: 0x0001EDE4
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x0000492D File Offset: 0x00002B2D
		public unsafe float lastTimeVibrateTriggersWasSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateTriggersWasSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeVibrateTriggersWasSent)) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00020C0C File Offset: 0x0001EE0C
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00004948 File Offset: 0x00002B48
		public unsafe Vector2 vibrateTriggersToSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_vibrateTriggersToSend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_vibrateTriggersToSend)) = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00020C34 File Offset: 0x0001EE34
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00004963 File Offset: 0x00002B63
		public unsafe bool sendLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendLightColor)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00020C5C File Offset: 0x0001EE5C
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000497E File Offset: 0x00002B7E
		public unsafe float lastTimeLightColorWasSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeLightColorWasSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeLightColorWasSent)) = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00020C84 File Offset: 0x0001EE84
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00004999 File Offset: 0x00002B99
		public unsafe Vector3 lightColorToSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lightColorToSend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lightColorToSend)) = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00020CAC File Offset: 0x0001EEAC
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x000049B4 File Offset: 0x00002BB4
		public unsafe bool sendLightFlash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendLightFlash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_sendLightFlash)) = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00020CD4 File Offset: 0x0001EED4
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x000049CF File Offset: 0x00002BCF
		public unsafe float lastTimeLightFlashWasSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeLightFlashWasSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lastTimeLightFlashWasSent)) = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00020CFC File Offset: 0x0001EEFC
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x000049EA File Offset: 0x00002BEA
		public unsafe Vector2 lightFlashToSend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lightFlashToSend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_lightFlashToSend)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00020D24 File Offset: 0x0001EF24
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00004A05 File Offset: 0x00002C05
		public unsafe StringBuilder glyphName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_glyphName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDevice.NativeFieldInfoPtr_glyphName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00020D54 File Offset: 0x0001EF54
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004A24 File Offset: 0x00002C24
		public unsafe static string defaultGlyphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputDevice.NativeFieldInfoPtr_defaultGlyphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputDevice.NativeFieldInfoPtr_defaultGlyphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_maxUnknownButtons;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_maxUnknownAnalogs;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr__Handle_k__BackingField;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr__Info_k__BackingField;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_analogs;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_skipUpdateFrames;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_numUnknownButtons;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_numUnknownAnalogs;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_controlSourceByTarget;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_sendVibrate;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_lastTimeVibrateWasSent;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_vibrateToSend;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_sendVibrateTriggers;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_lastTimeVibrateTriggersWasSent;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_vibrateTriggersToSend;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_sendLightColor;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_lastTimeLightColorWasSent;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_lightColorToSend;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_sendLightFlash;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_lastTimeLightFlashWasSent;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_lightFlashToSend;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_glyphName;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_defaultGlyphName;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_UInt32_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Private_set_Void_UInt32_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_get_Info_Public_get_InputDeviceInfo_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_set_Info_Private_set_Void_InputDeviceInfo_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_InputDeviceProfile_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_UInt32_InputDeviceInfo_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawButtonState_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_ReadRawAnalogValue_Public_Virtual_Single_Int32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_FloatToByte_Private_Static_Byte_Single_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_VibrateTriggers_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Void_Single_Single_Single_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_SetLightFlash_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_SendStatusUpdates_Private_Void_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_GetAppleGlyphNameForControl_Public_String_InputControlType_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_ProfileName_Public_get_String_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupportedOnThisPlatform_Public_Virtual_get_Boolean_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnown_Public_Virtual_get_Boolean_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownButtons_Public_Virtual_get_Int32_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUnknownAnalogs_Public_Virtual_get_Int32_0;
	}
}
