using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
	// Token: 0x02000002 RID: 2
	public static class XRSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000220C File Offset: 0x0000040C
		// Note: this type is marked as 'beforefieldinit'.
		static XRSettings()
		{
			Il2CppClassPointerStore<XRSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSettings>.NativeClassPtr);
			XRSettings.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663297);
			XRSettings.NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663298);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663299);
			XRSettings.NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663300);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663301);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663302);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663303);
			XRSettings.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663304);
			XRSettings.NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663305);
			XRSettings.NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663306);
			XRSettings.NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663307);
			XRSettings.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663308);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663309);
			XRSettings.set_enabledDelegateField = IL2CPP.ResolveICall<XRSettings.set_enabledDelegate>("UnityEngine.XR.XRSettings::set_enabled");
			XRSettings.get_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.get_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::get_gameViewRenderMode");
			XRSettings.set_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.set_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::set_gameViewRenderMode");
			XRSettings.get_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.get_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::get_showDeviceView");
			XRSettings.set_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.set_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::set_showDeviceView");
			XRSettings.get_deviceEyeTextureDimensionDelegateField = IL2CPP.ResolveICall<XRSettings.get_deviceEyeTextureDimensionDelegate>("UnityEngine.XR.XRSettings::get_deviceEyeTextureDimension");
			XRSettings.set_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<XRSettings.set_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::set_renderViewportScaleInternal");
			XRSettings.get_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.get_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::get_occlusionMaskScale");
			XRSettings.set_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.set_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::set_occlusionMaskScale");
			XRSettings.get_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.get_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::get_useOcclusionMesh");
			XRSettings.set_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.set_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::set_useOcclusionMesh");
			XRSettings.LoadDeviceByNameDelegateField = IL2CPP.ResolveICall<XRSettings.LoadDeviceByNameDelegate>("UnityEngine.XR.XRSettings::LoadDeviceByName");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000023F4 File Offset: 0x000005F4
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static bool enabled
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1272446, RefRangeEnd = 1272456, XrefRangeStart = 1272444, XrefRangeEnd = 1272446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				XRSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002424 File Offset: 0x00000624
		public unsafe static bool isDeviceActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272456, XrefRangeEnd = 1272458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002454 File Offset: 0x00000654
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe static float eyeTextureResolutionScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272458, XrefRangeEnd = 1272460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272462, RefRangeEnd = 1272463, XrefRangeStart = 1272460, XrefRangeEnd = 1272462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000024B8 File Offset: 0x000006B8
		public unsafe static int eyeTextureWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272463, XrefRangeEnd = 1272465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000024E8 File Offset: 0x000006E8
		public unsafe static int eyeTextureHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272465, XrefRangeEnd = 1272467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe static RenderTextureDescriptor eyeTextureDesc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272467, XrefRangeEnd = 1272469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002548 File Offset: 0x00000748
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000266C File Offset: 0x0000086C
		public unsafe static float renderViewportScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272469, XrefRangeEnd = 1272471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0f || value > 1f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("value", "Render viewport scale should be between 0 and 1.");
				}
				XRSettings.renderViewportScaleInternal = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002578 File Offset: 0x00000778
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020A4 File Offset: 0x000002A4
		public unsafe static float renderViewportScaleInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				XRSettings.set_renderViewportScaleInternalDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000025A8 File Offset: 0x000007A8
		public unsafe static string loadedDeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272471, XrefRangeEnd = 1272473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025D4 File Offset: 0x000007D4
		public unsafe static Il2CppStringArray supportedDevices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272475, RefRangeEnd = 1272476, XrefRangeStart = 1272473, XrefRangeEnd = 1272475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002608 File Offset: 0x00000808
		public unsafe static XRSettings.StereoRenderingMode stereoRenderingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272476, XrefRangeEnd = 1272478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002638 File Offset: 0x00000838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272478, XrefRangeEnd = 1272480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		public XRSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002072 File Offset: 0x00000272
		public static GameViewRenderMode gameViewRenderMode
		{
			get
			{
				return XRSettings.get_gameViewRenderModeDelegateField();
			}
			set
			{
				XRSettings.set_gameViewRenderModeDelegateField(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000208B File Offset: 0x0000028B
		public static bool showDeviceView
		{
			get
			{
				return XRSettings.get_showDeviceViewDelegateField();
			}
			set
			{
				XRSettings.set_showDeviceViewDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002098 File Offset: 0x00000298
		public static TextureDimension deviceEyeTextureDimension
		{
			get
			{
				return XRSettings.get_deviceEyeTextureDimensionDelegateField();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020B1 File Offset: 0x000002B1
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020BD File Offset: 0x000002BD
		public static float occlusionMaskScale
		{
			get
			{
				return XRSettings.get_occlusionMaskScaleDelegateField();
			}
			set
			{
				XRSettings.set_occlusionMaskScaleDelegateField(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020D6 File Offset: 0x000002D6
		public static bool useOcclusionMesh
		{
			get
			{
				return XRSettings.get_useOcclusionMeshDelegateField();
			}
			set
			{
				XRSettings.set_useOcclusionMeshDelegateField(value);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E3 File Offset: 0x000002E3
		public static void LoadDeviceByName(string deviceName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020F0 File Offset: 0x000002F0
		public static void LoadDeviceByName(Il2CppStringArray prioritizedDeviceNameList)
		{
			XRSettings.LoadDeviceByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(prioritizedDeviceNameList));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x0400000E RID: 14
		private static readonly XRSettings.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly XRSettings.get_gameViewRenderModeDelegate get_gameViewRenderModeDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly XRSettings.set_gameViewRenderModeDelegate set_gameViewRenderModeDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly XRSettings.get_showDeviceViewDelegate get_showDeviceViewDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly XRSettings.set_showDeviceViewDelegate set_showDeviceViewDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly XRSettings.get_deviceEyeTextureDimensionDelegate get_deviceEyeTextureDimensionDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly XRSettings.set_renderViewportScaleInternalDelegate set_renderViewportScaleInternalDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly XRSettings.get_occlusionMaskScaleDelegate get_occlusionMaskScaleDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly XRSettings.set_occlusionMaskScaleDelegate set_occlusionMaskScaleDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly XRSettings.get_useOcclusionMeshDelegate get_useOcclusionMeshDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly XRSettings.set_useOcclusionMeshDelegate set_useOcclusionMeshDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly XRSettings.LoadDeviceByNameDelegate LoadDeviceByNameDelegateField;

		// Token: 0x0200000B RID: 11
		public enum StereoRenderingMode
		{
			// Token: 0x04000038 RID: 56
			MultiPass,
			// Token: 0x04000039 RID: 57
			SinglePass,
			// Token: 0x0400003A RID: 58
			SinglePassInstanced,
			// Token: 0x0400003B RID: 59
			SinglePassMultiview
		}

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate GameViewRenderMode get_gameViewRenderModeDelegate();

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate void set_gameViewRenderModeDelegate(GameViewRenderMode value);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600003B RID: 59
		private delegate bool get_showDeviceViewDelegate();

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate void set_showDeviceViewDelegate(bool value);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600003F RID: 63
		private delegate TextureDimension get_deviceEyeTextureDimensionDelegate();

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate void set_renderViewportScaleInternalDelegate(float value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate float get_occlusionMaskScaleDelegate();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate void set_occlusionMaskScaleDelegate(float value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate bool get_useOcclusionMeshDelegate();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate void set_useOcclusionMeshDelegate(bool value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void LoadDeviceByNameDelegate(IntPtr prioritizedDeviceNameList);
	}
}
