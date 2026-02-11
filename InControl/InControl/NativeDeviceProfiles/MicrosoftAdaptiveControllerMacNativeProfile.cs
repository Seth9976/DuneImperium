using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000CD RID: 205
	public class MicrosoftAdaptiveControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x00033A6C File Offset: 0x00031C6C
		// Note: this type is marked as 'beforefieldinit'.
		static MicrosoftAdaptiveControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<MicrosoftAdaptiveControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MicrosoftAdaptiveControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicrosoftAdaptiveControllerMacNativeProfile>.NativeClassPtr);
			MicrosoftAdaptiveControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicrosoftAdaptiveControllerMacNativeProfile>.NativeClassPtr, 100664967);
			MicrosoftAdaptiveControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicrosoftAdaptiveControllerMacNativeProfile>.NativeClassPtr, 100664968);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00033AC4 File Offset: 0x00031CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793459, XrefRangeEnd = 793476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MicrosoftAdaptiveControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00033B00 File Offset: 0x00031D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MicrosoftAdaptiveControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MicrosoftAdaptiveControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MicrosoftAdaptiveControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0000645B File Offset: 0x0000465B
		public MicrosoftAdaptiveControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
