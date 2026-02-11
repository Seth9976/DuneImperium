using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000124 RID: 292
	public class SDLControllerNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003811C File Offset: 0x0003631C
		// Note: this type is marked as 'beforefieldinit'.
		static SDLControllerNativeProfile()
		{
			Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLControllerNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665141);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Action1Mapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665142);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Action2Mapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665143);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Action3Mapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665144);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Action4Mapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665145);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665146);
			SDLControllerNativeProfile.NativeMethodInfoPtr_SystemMapping_Protected_Static_InputControlMapping_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665147);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665148);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickButtonMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665149);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickButtonMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665150);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftBumperMapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665151);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightBumperMapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665152);
			SDLControllerNativeProfile.NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665153);
			SDLControllerNativeProfile.NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665154);
			SDLControllerNativeProfile.NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665155);
			SDLControllerNativeProfile.NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665156);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Misc1Mapping_Protected_Static_InputControlMapping_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665157);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle1Mapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665158);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle2Mapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665159);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle3Mapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665160);
			SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle4Mapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665161);
			SDLControllerNativeProfile.NativeMethodInfoPtr_TouchPadButtonMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665162);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665163);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665164);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665165);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665166);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665167);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665168);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665169);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665170);
			SDLControllerNativeProfile.NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665171);
			SDLControllerNativeProfile.NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665172);
			SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerXMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665173);
			SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerYMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665174);
			SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerZMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665175);
			SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeXMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665176);
			SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeYMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665177);
			SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeZMapping_Protected_Static_InputControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665178);
			SDLControllerNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr, 100665179);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00038458 File Offset: 0x00036658
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802627, RefRangeEnd = 802638, XrefRangeStart = 802608, XrefRangeEnd = 802627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLControllerNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00038494 File Offset: 0x00036694
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802647, RefRangeEnd = 802658, XrefRangeStart = 802638, XrefRangeEnd = 802647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Action1Mapping(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Action1Mapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000384D8 File Offset: 0x000366D8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802667, RefRangeEnd = 802678, XrefRangeStart = 802658, XrefRangeEnd = 802667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Action2Mapping(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Action2Mapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003851C File Offset: 0x0003671C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802687, RefRangeEnd = 802698, XrefRangeStart = 802678, XrefRangeEnd = 802687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Action3Mapping(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Action3Mapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00038560 File Offset: 0x00036760
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802707, RefRangeEnd = 802718, XrefRangeStart = 802698, XrefRangeEnd = 802707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Action4Mapping(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Action4Mapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000385A4 File Offset: 0x000367A4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802727, RefRangeEnd = 802738, XrefRangeStart = 802718, XrefRangeEnd = 802727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftCommandMapping(string name, InputControlType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000385F8 File Offset: 0x000367F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 802747, RefRangeEnd = 802755, XrefRangeStart = 802738, XrefRangeEnd = 802747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping SystemMapping(string name, InputControlType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_SystemMapping_Protected_Static_InputControlMapping_String_InputControlType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003864C File Offset: 0x0003684C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802764, RefRangeEnd = 802775, XrefRangeStart = 802755, XrefRangeEnd = 802764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightCommandMapping(string name, InputControlType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000386A0 File Offset: 0x000368A0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802786, RefRangeEnd = 802797, XrefRangeStart = 802775, XrefRangeEnd = 802786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickButtonMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickButtonMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000386D4 File Offset: 0x000368D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802808, RefRangeEnd = 802819, XrefRangeStart = 802797, XrefRangeEnd = 802808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickButtonMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickButtonMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00038708 File Offset: 0x00036908
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802828, RefRangeEnd = 802839, XrefRangeStart = 802819, XrefRangeEnd = 802828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftBumperMapping(string name = "Left Bumper")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftBumperMapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003874C File Offset: 0x0003694C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802848, RefRangeEnd = 802859, XrefRangeStart = 802839, XrefRangeEnd = 802848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightBumperMapping(string name = "Right Bumper")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightBumperMapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00038790 File Offset: 0x00036990
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802870, RefRangeEnd = 802881, XrefRangeStart = 802859, XrefRangeEnd = 802870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadUpMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000387C4 File Offset: 0x000369C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802892, RefRangeEnd = 802903, XrefRangeStart = 802881, XrefRangeEnd = 802892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadDownMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000387F8 File Offset: 0x000369F8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802914, RefRangeEnd = 802925, XrefRangeStart = 802903, XrefRangeEnd = 802914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadLeftMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003882C File Offset: 0x00036A2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 802936, RefRangeEnd = 802947, XrefRangeStart = 802925, XrefRangeEnd = 802936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping DPadRightMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00038860 File Offset: 0x00036A60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 802956, RefRangeEnd = 802961, XrefRangeStart = 802947, XrefRangeEnd = 802956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Misc1Mapping(string name, InputControlType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Misc1Mapping_Protected_Static_InputControlMapping_String_InputControlType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000388B4 File Offset: 0x00036AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 802972, RefRangeEnd = 802975, XrefRangeStart = 802961, XrefRangeEnd = 802972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Paddle1Mapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle1Mapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000388E8 File Offset: 0x00036AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 802986, RefRangeEnd = 802989, XrefRangeStart = 802975, XrefRangeEnd = 802986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Paddle2Mapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle2Mapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0003891C File Offset: 0x00036B1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 803000, RefRangeEnd = 803003, XrefRangeStart = 802989, XrefRangeEnd = 803000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Paddle3Mapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle3Mapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00038950 File Offset: 0x00036B50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 803014, RefRangeEnd = 803017, XrefRangeStart = 803003, XrefRangeEnd = 803014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping Paddle4Mapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_Paddle4Mapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00038984 File Offset: 0x00036B84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 803028, RefRangeEnd = 803032, XrefRangeStart = 803017, XrefRangeEnd = 803028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping TouchPadButtonMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_TouchPadButtonMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000389B8 File Offset: 0x00036BB8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803043, RefRangeEnd = 803054, XrefRangeStart = 803032, XrefRangeEnd = 803043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickLeftMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000389EC File Offset: 0x00036BEC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803065, RefRangeEnd = 803076, XrefRangeStart = 803054, XrefRangeEnd = 803065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickRightMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00038A20 File Offset: 0x00036C20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803087, RefRangeEnd = 803098, XrefRangeStart = 803076, XrefRangeEnd = 803087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickUpMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00038A54 File Offset: 0x00036C54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803109, RefRangeEnd = 803120, XrefRangeStart = 803098, XrefRangeEnd = 803109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftStickDownMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00038A88 File Offset: 0x00036C88
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803131, RefRangeEnd = 803142, XrefRangeStart = 803120, XrefRangeEnd = 803131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickLeftMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00038ABC File Offset: 0x00036CBC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803153, RefRangeEnd = 803164, XrefRangeStart = 803142, XrefRangeEnd = 803153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickRightMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00038AF0 File Offset: 0x00036CF0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803175, RefRangeEnd = 803186, XrefRangeStart = 803164, XrefRangeEnd = 803175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickUpMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00038B24 File Offset: 0x00036D24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803197, RefRangeEnd = 803208, XrefRangeStart = 803186, XrefRangeEnd = 803197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightStickDownMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00038B58 File Offset: 0x00036D58
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803217, RefRangeEnd = 803228, XrefRangeStart = 803208, XrefRangeEnd = 803217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping LeftTriggerMapping(string name = "Left Trigger")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00038B9C File Offset: 0x00036D9C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 803237, RefRangeEnd = 803248, XrefRangeStart = 803228, XrefRangeEnd = 803237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping RightTriggerMapping(string name = "Right Trigger")
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00038BE0 File Offset: 0x00036DE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803259, RefRangeEnd = 803264, XrefRangeStart = 803248, XrefRangeEnd = 803259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping AccelerometerXMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerXMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00038C14 File Offset: 0x00036E14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803275, RefRangeEnd = 803280, XrefRangeStart = 803264, XrefRangeEnd = 803275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping AccelerometerYMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerYMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00038C48 File Offset: 0x00036E48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803291, RefRangeEnd = 803296, XrefRangeStart = 803280, XrefRangeEnd = 803291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping AccelerometerZMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_AccelerometerZMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00038C7C File Offset: 0x00036E7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803307, RefRangeEnd = 803312, XrefRangeStart = 803296, XrefRangeEnd = 803307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping GyroscopeXMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeXMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00038CB0 File Offset: 0x00036EB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803323, RefRangeEnd = 803328, XrefRangeStart = 803312, XrefRangeEnd = 803323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping GyroscopeYMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeYMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00038CE4 File Offset: 0x00036EE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 803339, RefRangeEnd = 803344, XrefRangeStart = 803328, XrefRangeEnd = 803339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputControlMapping GyroscopeZMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr_GyroscopeZMapping_Protected_Static_InputControlMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputControlMapping>(intPtr3) : null;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00038D18 File Offset: 0x00036F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803344, XrefRangeEnd = 803348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLControllerNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLControllerNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLControllerNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000676A File Offset: 0x0000496A
		public SDLControllerNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_Action1Mapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_Action2Mapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_Action3Mapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_Action4Mapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_LeftCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_SystemMapping_Protected_Static_InputControlMapping_String_InputControlType_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_RightCommandMapping_Protected_Static_InputControlMapping_String_InputControlType_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickButtonMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_RightStickButtonMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_LeftBumperMapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_RightBumperMapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_DPadUpMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_DPadDownMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_DPadLeftMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_DPadRightMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_Misc1Mapping_Protected_Static_InputControlMapping_String_InputControlType_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_Paddle1Mapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_Paddle2Mapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_Paddle3Mapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_Paddle4Mapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_TouchPadButtonMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickLeftMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickRightMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickUpMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_LeftStickDownMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_RightStickLeftMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_RightStickRightMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_RightStickUpMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_RightStickDownMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_LeftTriggerMapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_RightTriggerMapping_Protected_Static_InputControlMapping_String_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_AccelerometerXMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_AccelerometerYMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_AccelerometerZMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_GyroscopeXMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_GyroscopeYMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_GyroscopeZMapping_Protected_Static_InputControlMapping_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000225 RID: 549
		public enum SDLButtonType
		{
			// Token: 0x04000E08 RID: 3592
			SDL_CONTROLLER_BUTTON_INVALID = -1,
			// Token: 0x04000E09 RID: 3593
			SDL_CONTROLLER_BUTTON_A,
			// Token: 0x04000E0A RID: 3594
			SDL_CONTROLLER_BUTTON_B,
			// Token: 0x04000E0B RID: 3595
			SDL_CONTROLLER_BUTTON_X,
			// Token: 0x04000E0C RID: 3596
			SDL_CONTROLLER_BUTTON_Y,
			// Token: 0x04000E0D RID: 3597
			SDL_CONTROLLER_BUTTON_BACK,
			// Token: 0x04000E0E RID: 3598
			SDL_CONTROLLER_BUTTON_GUIDE,
			// Token: 0x04000E0F RID: 3599
			SDL_CONTROLLER_BUTTON_START,
			// Token: 0x04000E10 RID: 3600
			SDL_CONTROLLER_BUTTON_LEFTSTICK,
			// Token: 0x04000E11 RID: 3601
			SDL_CONTROLLER_BUTTON_RIGHTSTICK,
			// Token: 0x04000E12 RID: 3602
			SDL_CONTROLLER_BUTTON_LEFTSHOULDER,
			// Token: 0x04000E13 RID: 3603
			SDL_CONTROLLER_BUTTON_RIGHTSHOULDER,
			// Token: 0x04000E14 RID: 3604
			SDL_CONTROLLER_BUTTON_DPAD_UP,
			// Token: 0x04000E15 RID: 3605
			SDL_CONTROLLER_BUTTON_DPAD_DOWN,
			// Token: 0x04000E16 RID: 3606
			SDL_CONTROLLER_BUTTON_DPAD_LEFT,
			// Token: 0x04000E17 RID: 3607
			SDL_CONTROLLER_BUTTON_DPAD_RIGHT,
			// Token: 0x04000E18 RID: 3608
			SDL_CONTROLLER_BUTTON_MISC1,
			// Token: 0x04000E19 RID: 3609
			SDL_CONTROLLER_BUTTON_PADDLE1,
			// Token: 0x04000E1A RID: 3610
			SDL_CONTROLLER_BUTTON_PADDLE2,
			// Token: 0x04000E1B RID: 3611
			SDL_CONTROLLER_BUTTON_PADDLE3,
			// Token: 0x04000E1C RID: 3612
			SDL_CONTROLLER_BUTTON_PADDLE4,
			// Token: 0x04000E1D RID: 3613
			SDL_CONTROLLER_BUTTON_TOUCHPAD,
			// Token: 0x04000E1E RID: 3614
			SDL_CONTROLLER_BUTTON_MAX
		}
	}
}
