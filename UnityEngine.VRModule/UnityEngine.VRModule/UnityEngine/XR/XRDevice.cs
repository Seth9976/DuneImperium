using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000003 RID: 3
	public static class XRDevice : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000026A8 File Offset: 0x000008A8
		// Note: this type is marked as 'beforefieldinit'.
		static XRDevice()
		{
			Il2CppClassPointerStore<XRDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDevice>.NativeClassPtr);
			XRDevice.NativeFieldInfoPtr_deviceLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, "deviceLoaded");
			XRDevice.NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, 100663310);
			XRDevice.get_refreshRateDelegateField = IL2CPP.ResolveICall<XRDevice.get_refreshRateDelegate>("UnityEngine.XR.XRDevice::get_refreshRate");
			XRDevice.GetNativePtrDelegateField = IL2CPP.ResolveICall<XRDevice.GetNativePtrDelegate>("UnityEngine.XR.XRDevice::GetNativePtr");
			XRDevice.GetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<XRDevice.GetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::GetTrackingSpaceType");
			XRDevice.SetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<XRDevice.SetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::SetTrackingSpaceType");
			XRDevice.DisableAutoXRCameraTrackingDelegateField = IL2CPP.ResolveICall<XRDevice.DisableAutoXRCameraTrackingDelegate>("UnityEngine.XR.XRDevice::DisableAutoXRCameraTracking");
			XRDevice.UpdateEyeTextureMSAASettingDelegateField = IL2CPP.ResolveICall<XRDevice.UpdateEyeTextureMSAASettingDelegate>("UnityEngine.XR.XRDevice::UpdateEyeTextureMSAASetting");
			XRDevice.get_fovZoomFactorDelegateField = IL2CPP.ResolveICall<XRDevice.get_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::get_fovZoomFactor");
			XRDevice.set_fovZoomFactorDelegateField = IL2CPP.ResolveICall<XRDevice.set_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::set_fovZoomFactor");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002778 File Offset: 0x00000978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272480, XrefRangeEnd = 1272482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeviceLoaded(string loadedDeviceName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(loadedDeviceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDevice.NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002102 File Offset: 0x00000302
		public XRDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000027B0 File Offset: 0x000009B0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe static Action<string> deviceLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRDevice.NativeFieldInfoPtr_deviceLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRDevice.NativeFieldInfoPtr_deviceLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000211D File Offset: 0x0000031D
		public static bool isPresent
		{
			get
			{
				throw new NotSupportedException("XRDevice is Obsolete. Instead, find the active XRDisplaySubsystem and check to see if it is running.");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000212A File Offset: 0x0000032A
		public static float refreshRate
		{
			get
			{
				return XRDevice.get_refreshRateDelegateField();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002136 File Offset: 0x00000336
		public static IntPtr GetNativePtr()
		{
			return XRDevice.GetNativePtrDelegateField();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002142 File Offset: 0x00000342
		public static TrackingSpaceType GetTrackingSpaceType()
		{
			return XRDevice.GetTrackingSpaceTypeDelegateField();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000214E File Offset: 0x0000034E
		public static bool SetTrackingSpaceType(TrackingSpaceType trackingSpaceType)
		{
			return XRDevice.SetTrackingSpaceTypeDelegateField(trackingSpaceType);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000215B File Offset: 0x0000035B
		public static void DisableAutoXRCameraTracking(Camera camera, bool disabled)
		{
			XRDevice.DisableAutoXRCameraTrackingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), disabled);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000216E File Offset: 0x0000036E
		public static void UpdateEyeTextureMSAASetting()
		{
			XRDevice.UpdateEyeTextureMSAASettingDelegateField();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000217A File Offset: 0x0000037A
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002186 File Offset: 0x00000386
		public static float fovZoomFactor
		{
			get
			{
				return XRDevice.get_fovZoomFactorDelegateField();
			}
			set
			{
				XRDevice.set_fovZoomFactorDelegateField(value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002193 File Offset: 0x00000393
		public static void add_deviceLoaded(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021A0 File Offset: 0x000003A0
		public static void remove_deviceLoaded(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_deviceLoaded;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly XRDevice.get_refreshRateDelegate get_refreshRateDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly XRDevice.GetNativePtrDelegate GetNativePtrDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly XRDevice.GetTrackingSpaceTypeDelegate GetTrackingSpaceTypeDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly XRDevice.SetTrackingSpaceTypeDelegate SetTrackingSpaceTypeDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly XRDevice.DisableAutoXRCameraTrackingDelegate DisableAutoXRCameraTrackingDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly XRDevice.UpdateEyeTextureMSAASettingDelegate UpdateEyeTextureMSAASettingDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly XRDevice.get_fovZoomFactorDelegate get_fovZoomFactorDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly XRDevice.set_fovZoomFactorDelegate set_fovZoomFactorDelegateField;

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate float get_refreshRateDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate IntPtr GetNativePtrDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate TrackingSpaceType GetTrackingSpaceTypeDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate bool SetTrackingSpaceTypeDelegate(TrackingSpaceType trackingSpaceType);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate void DisableAutoXRCameraTrackingDelegate(IntPtr camera, bool disabled);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate void UpdateEyeTextureMSAASettingDelegate();

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate float get_fovZoomFactorDelegate();

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void set_fovZoomFactorDelegate(float value);
	}
}
