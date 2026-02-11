using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
	// Token: 0x0200000E RID: 14
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000495C File Offset: 0x00002B5C
		// Note: this type is marked as 'beforefieldinit'.
		static XRDisplaySubsystem()
		{
			Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr);
			XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "displayFocusChanged");
			XRDisplaySubsystem.NativeFieldInfoPtr_m_HDROutputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "m_HDROutputSettings");
			XRDisplaySubsystem.NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663327);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663328);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663329);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663330);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663331);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663332);
			XRDisplaySubsystem.NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663333);
			XRDisplaySubsystem.NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663334);
			XRDisplaySubsystem.NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663335);
			XRDisplaySubsystem.NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663336);
			XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663337);
			XRDisplaySubsystem.NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663338);
			XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663339);
			XRDisplaySubsystem.NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663340);
			XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663341);
			XRDisplaySubsystem.NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663342);
			XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663343);
			XRDisplaySubsystem.NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663344);
			XRDisplaySubsystem.NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663345);
			XRDisplaySubsystem.NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663346);
			XRDisplaySubsystem.NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663347);
			XRDisplaySubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663348);
			XRDisplaySubsystem.get_displayOpaqueDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_displayOpaqueDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_displayOpaque");
			XRDisplaySubsystem.get_contentProtectionEnabledDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_contentProtectionEnabledDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_contentProtectionEnabled");
			XRDisplaySubsystem.set_contentProtectionEnabledDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_contentProtectionEnabledDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_contentProtectionEnabled");
			XRDisplaySubsystem.get_scaleOfAllViewportsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_scaleOfAllViewportsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllViewports");
			XRDisplaySubsystem.set_scaleOfAllViewportsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_scaleOfAllViewportsDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllViewports");
			XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllRenderTargets");
			XRDisplaySubsystem.get_zNearDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_zNearDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zNear");
			XRDisplaySubsystem.get_zFarDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_zFarDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zFar");
			XRDisplaySubsystem.get_sRGBDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_sRGBDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_sRGB");
			XRDisplaySubsystem.get_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_occlusionMaskScaleDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_occlusionMaskScale");
			XRDisplaySubsystem.set_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_occlusionMaskScaleDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_occlusionMaskScale");
			XRDisplaySubsystem.get_foveatedRenderingLevelDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_foveatedRenderingLevelDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_foveatedRenderingLevel");
			XRDisplaySubsystem.set_foveatedRenderingLevelDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_foveatedRenderingLevelDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_foveatedRenderingLevel");
			XRDisplaySubsystem.get_foveatedRenderingFlagsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_foveatedRenderingFlagsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_foveatedRenderingFlags");
			XRDisplaySubsystem.set_foveatedRenderingFlagsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_foveatedRenderingFlagsDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_foveatedRenderingFlags");
			XRDisplaySubsystem.MarkTransformLateLatchedDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.MarkTransformLateLatchedDelegate>("UnityEngine.XR.XRDisplaySubsystem::MarkTransformLateLatched");
			XRDisplaySubsystem.get_textureLayoutDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_textureLayoutDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_textureLayout");
			XRDisplaySubsystem.get_supportedTextureLayoutsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_supportedTextureLayoutsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_supportedTextureLayouts");
			XRDisplaySubsystem.get_reprojectionModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_reprojectionModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_reprojectionMode");
			XRDisplaySubsystem.set_reprojectionModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_reprojectionModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_reprojectionMode");
			XRDisplaySubsystem.get_disableLegacyRendererDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_disableLegacyRendererDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_disableLegacyRenderer");
			XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetAppGPUTimeLastFrame");
			XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetCompositorGPUTimeLastFrame");
			XRDisplaySubsystem.TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDroppedFrameCount");
			XRDisplaySubsystem.TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetFramePresentCountDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetFramePresentCount");
			XRDisplaySubsystem.TryGetDisplayRefreshRateDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetDisplayRefreshRateDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDisplayRefreshRate");
			XRDisplaySubsystem.TryGetMotionToPhotonDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetMotionToPhotonDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetMotionToPhoton");
			XRDisplaySubsystem.GetRenderTextureDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetRenderTextureDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderTexture");
			XRDisplaySubsystem.GetRenderTextureForRenderPassDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetRenderTextureForRenderPassDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderTextureForRenderPass");
			XRDisplaySubsystem.GetSharedDepthTextureForRenderPassDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetSharedDepthTextureForRenderPassDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetSharedDepthTextureForRenderPass");
			XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetPreferredMirrorBlitMode");
			XRDisplaySubsystem.SetFocusPlane_InjectedDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.SetFocusPlane_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetFocusPlane_Injected");
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004D4C File Offset: 0x00002F4C
		[CallerCount(0)]
		public unsafe void InvokeDisplayFocusChanged(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000026FF File Offset: 0x000008FF
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00004D8C File Offset: 0x00002F8C
		public unsafe float scaleOfAllRenderTargets
		{
			get
			{
				return XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258748, RefRangeEnd = 1258749, XrefRangeStart = 1258746, XrefRangeEnd = 1258748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002711 File Offset: 0x00000911
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00004DCC File Offset: 0x00002FCC
		public unsafe float zNear
		{
			get
			{
				return XRDisplaySubsystem.get_zNearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258751, RefRangeEnd = 1258752, XrefRangeStart = 1258749, XrefRangeEnd = 1258751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002723 File Offset: 0x00000923
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00004E0C File Offset: 0x0000300C
		public unsafe float zFar
		{
			get
			{
				return XRDisplaySubsystem.get_zFarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258754, RefRangeEnd = 1258755, XrefRangeStart = 1258752, XrefRangeEnd = 1258754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002735 File Offset: 0x00000935
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004E4C File Offset: 0x0000304C
		public unsafe bool sRGB
		{
			get
			{
				return XRDisplaySubsystem.get_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258757, RefRangeEnd = 1258758, XrefRangeStart = 1258755, XrefRangeEnd = 1258757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000027CF File Offset: 0x000009CF
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00004E8C File Offset: 0x0000308C
		public unsafe XRDisplaySubsystem.TextureLayout textureLayout
		{
			get
			{
				return XRDisplaySubsystem.get_textureLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258760, RefRangeEnd = 1258761, XrefRangeStart = 1258758, XrefRangeEnd = 1258760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004ECC File Offset: 0x000030CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258763, RefRangeEnd = 1258764, XrefRangeStart = 1258761, XrefRangeEnd = 1258763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMSAALevel(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002826 File Offset: 0x00000A26
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00004F0C File Offset: 0x0000310C
		public unsafe bool disableLegacyRenderer
		{
			get
			{
				return XRDisplaySubsystem.get_disableLegacyRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258766, RefRangeEnd = 1258767, XrefRangeStart = 1258764, XrefRangeEnd = 1258766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004F4C File Offset: 0x0000314C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258769, RefRangeEnd = 1258770, XrefRangeStart = 1258767, XrefRangeEnd = 1258769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRenderPassCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004F88 File Offset: 0x00003188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258772, RefRangeEnd = 1258774, XrefRangeStart = 1258770, XrefRangeEnd = 1258772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderPassIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004FD4 File Offset: 0x000031D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258774, XrefRangeEnd = 1258776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_TryGetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderPassIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258782, RefRangeEnd = 1258783, XrefRangeStart = 1258776, XrefRangeEnd = 1258782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndRecordingIfLateLatched(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005070 File Offset: 0x00003270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258783, XrefRangeEnd = 1258785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_TryEndRecordingIfLateLatched(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000050C0 File Offset: 0x000032C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258791, RefRangeEnd = 1258792, XrefRangeStart = 1258785, XrefRangeEnd = 1258791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRecordingIfLateLatched(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005104 File Offset: 0x00003304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258792, XrefRangeEnd = 1258794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_TryBeginRecordingIfLateLatched(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005154 File Offset: 0x00003354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258800, RefRangeEnd = 1258802, XrefRangeStart = 1258794, XrefRangeEnd = 1258800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingPassIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scriptableCullingParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000051B4 File Offset: 0x000033B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258802, XrefRangeEnd = 1258804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingPassIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scriptableCullingParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005220 File Offset: 0x00003420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258806, RefRangeEnd = 1258807, XrefRangeStart = 1258804, XrefRangeEnd = 1258806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPreferredMirrorBlitMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000525C File Offset: 0x0000345C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258809, RefRangeEnd = 1258810, XrefRangeStart = 1258807, XrefRangeEnd = 1258809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mirrorRt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outDesc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000052C8 File Offset: 0x000034C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258812, RefRangeEnd = 1258813, XrefRangeStart = 1258810, XrefRangeEnd = 1258812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowGraphicsStateInvalidate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005334 File Offset: 0x00003534
		public unsafe HDROutputSettings hdrOutputSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1258818, RefRangeEnd = 1258825, XrefRangeStart = 1258813, XrefRangeEnd = 1258818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005374 File Offset: 0x00003574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258825, XrefRangeEnd = 1258828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRDisplaySubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002642 File Offset: 0x00000842
		public XRDisplaySubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000053B0 File Offset: 0x000035B0
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000264B File Offset: 0x0000084B
		public unsafe Action<bool> displayFocusChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000053E0 File Offset: 0x000035E0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000266A File Offset: 0x0000086A
		public unsafe HDROutputSettings m_HDROutputSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_m_HDROutputSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_m_HDROutputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002689 File Offset: 0x00000889
		public void add_displayFocusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002696 File Offset: 0x00000896
		public void remove_displayFocusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005410 File Offset: 0x00003610
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00005430 File Offset: 0x00003630
		public bool singlePassRenderingDisabled
		{
			get
			{
				return (this.textureLayout & XRDisplaySubsystem.TextureLayout.Texture2DArray) == (XRDisplaySubsystem.TextureLayout)0;
			}
			set
			{
				if (value)
				{
					this.textureLayout = XRDisplaySubsystem.TextureLayout.SeparateTexture2Ds;
				}
				else
				{
					bool flag = (this.supportedTextureLayouts & XRDisplaySubsystem.TextureLayout.Texture2DArray) > (XRDisplaySubsystem.TextureLayout)0;
					if (flag)
					{
						this.textureLayout = XRDisplaySubsystem.TextureLayout.Texture2DArray;
					}
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000026A3 File Offset: 0x000008A3
		public bool displayOpaque
		{
			get
			{
				return XRDisplaySubsystem.get_displayOpaqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000026B5 File Offset: 0x000008B5
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000026C7 File Offset: 0x000008C7
		public bool contentProtectionEnabled
		{
			get
			{
				return XRDisplaySubsystem.get_contentProtectionEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_contentProtectionEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000026DA File Offset: 0x000008DA
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000026EC File Offset: 0x000008EC
		public float scaleOfAllViewports
		{
			get
			{
				return XRDisplaySubsystem.get_scaleOfAllViewportsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_scaleOfAllViewportsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002747 File Offset: 0x00000947
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002759 File Offset: 0x00000959
		public float occlusionMaskScale
		{
			get
			{
				return XRDisplaySubsystem.get_occlusionMaskScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_occlusionMaskScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000276C File Offset: 0x0000096C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000277E File Offset: 0x0000097E
		public float foveatedRenderingLevel
		{
			get
			{
				return XRDisplaySubsystem.get_foveatedRenderingLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_foveatedRenderingLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002791 File Offset: 0x00000991
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000027A3 File Offset: 0x000009A3
		public XRDisplaySubsystem.FoveatedRenderingFlags foveatedRenderingFlags
		{
			get
			{
				return XRDisplaySubsystem.get_foveatedRenderingFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_foveatedRenderingFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000027B6 File Offset: 0x000009B6
		public void MarkTransformLateLatched(Transform transform, XRDisplaySubsystem.LateLatchNode nodeType)
		{
			XRDisplaySubsystem.MarkTransformLateLatchedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), nodeType);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000027E1 File Offset: 0x000009E1
		public XRDisplaySubsystem.TextureLayout supportedTextureLayouts
		{
			get
			{
				return XRDisplaySubsystem.get_supportedTextureLayoutsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000027F3 File Offset: 0x000009F3
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002805 File Offset: 0x00000A05
		public XRDisplaySubsystem.ReprojectionMode reprojectionMode
		{
			get
			{
				return XRDisplaySubsystem.get_reprojectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_reprojectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002818 File Offset: 0x00000A18
		public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity)
		{
			this.SetFocusPlane_Injected(ref point, ref normal, ref velocity);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002838 File Offset: 0x00000A38
		public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame)
		{
			return XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out gpuTimeLastFrame);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000284B File Offset: 0x00000A4B
		public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor)
		{
			return XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out gpuTimeLastFrameCompositor);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000285E File Offset: 0x00000A5E
		public bool TryGetDroppedFrameCount(out int droppedFrameCount)
		{
			return XRDisplaySubsystem.TryGetDroppedFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out droppedFrameCount);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002871 File Offset: 0x00000A71
		public bool TryGetFramePresentCount(out int framePresentCount)
		{
			return XRDisplaySubsystem.TryGetFramePresentCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out framePresentCount);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002884 File Offset: 0x00000A84
		public bool TryGetDisplayRefreshRate(out float displayRefreshRate)
		{
			return XRDisplaySubsystem.TryGetDisplayRefreshRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out displayRefreshRate);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002897 File Offset: 0x00000A97
		public bool TryGetMotionToPhoton(out float motionToPhoton)
		{
			return XRDisplaySubsystem.TryGetMotionToPhotonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out motionToPhoton);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005468 File Offset: 0x00003668
		public RenderTexture GetRenderTexture(uint unityXrRenderTextureId)
		{
			IntPtr intPtr = XRDisplaySubsystem.GetRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), unityXrRenderTextureId);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005498 File Offset: 0x00003698
		public RenderTexture GetRenderTextureForRenderPass(int renderPass)
		{
			IntPtr intPtr = XRDisplaySubsystem.GetRenderTextureForRenderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderPass);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000054C8 File Offset: 0x000036C8
		public RenderTexture GetSharedDepthTextureForRenderPass(int renderPass)
		{
			IntPtr intPtr = XRDisplaySubsystem.GetSharedDepthTextureForRenderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderPass);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000028AA File Offset: 0x00000AAA
		public void SetPreferredMirrorBlitMode(int blitMode)
		{
			XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), blitMode);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000054F8 File Offset: 0x000036F8
		public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc)
		{
			return this.GetMirrorViewBlitDesc(mirrorRt, out outDesc, -1);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005514 File Offset: 0x00003714
		public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate)
		{
			return this.AddGraphicsThreadMirrorViewBlit(cmd, allowGraphicsStateInvalidate, -1);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000028BD File Offset: 0x00000ABD
		public void SetFocusPlane_Injected(ref Vector3 point, ref Vector3 normal, ref Vector3 velocity)
		{
			XRDisplaySubsystem.SetFocusPlane_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref normal, ref velocity);
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_displayFocusChanged;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_HDROutputSettings;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B3 RID: 179
		private static readonly XRDisplaySubsystem.get_displayOpaqueDelegate get_displayOpaqueDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly XRDisplaySubsystem.get_contentProtectionEnabledDelegate get_contentProtectionEnabledDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly XRDisplaySubsystem.set_contentProtectionEnabledDelegate set_contentProtectionEnabledDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly XRDisplaySubsystem.get_scaleOfAllViewportsDelegate get_scaleOfAllViewportsDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly XRDisplaySubsystem.set_scaleOfAllViewportsDelegate set_scaleOfAllViewportsDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegate get_scaleOfAllRenderTargetsDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly XRDisplaySubsystem.get_zNearDelegate get_zNearDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly XRDisplaySubsystem.get_zFarDelegate get_zFarDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly XRDisplaySubsystem.get_sRGBDelegate get_sRGBDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly XRDisplaySubsystem.get_occlusionMaskScaleDelegate get_occlusionMaskScaleDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly XRDisplaySubsystem.set_occlusionMaskScaleDelegate set_occlusionMaskScaleDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly XRDisplaySubsystem.get_foveatedRenderingLevelDelegate get_foveatedRenderingLevelDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly XRDisplaySubsystem.set_foveatedRenderingLevelDelegate set_foveatedRenderingLevelDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly XRDisplaySubsystem.get_foveatedRenderingFlagsDelegate get_foveatedRenderingFlagsDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly XRDisplaySubsystem.set_foveatedRenderingFlagsDelegate set_foveatedRenderingFlagsDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly XRDisplaySubsystem.MarkTransformLateLatchedDelegate MarkTransformLateLatchedDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly XRDisplaySubsystem.get_textureLayoutDelegate get_textureLayoutDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly XRDisplaySubsystem.get_supportedTextureLayoutsDelegate get_supportedTextureLayoutsDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly XRDisplaySubsystem.get_reprojectionModeDelegate get_reprojectionModeDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly XRDisplaySubsystem.set_reprojectionModeDelegate set_reprojectionModeDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly XRDisplaySubsystem.get_disableLegacyRendererDelegate get_disableLegacyRendererDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegate TryGetAppGPUTimeLastFrameDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegate TryGetCompositorGPUTimeLastFrameDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly XRDisplaySubsystem.TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly XRDisplaySubsystem.TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly XRDisplaySubsystem.TryGetDisplayRefreshRateDelegate TryGetDisplayRefreshRateDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly XRDisplaySubsystem.TryGetMotionToPhotonDelegate TryGetMotionToPhotonDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly XRDisplaySubsystem.GetRenderTextureDelegate GetRenderTextureDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly XRDisplaySubsystem.GetRenderTextureForRenderPassDelegate GetRenderTextureForRenderPassDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly XRDisplaySubsystem.GetSharedDepthTextureForRenderPassDelegate GetSharedDepthTextureForRenderPassDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegate SetPreferredMirrorBlitModeDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly XRDisplaySubsystem.SetFocusPlane_InjectedDelegate SetFocusPlane_InjectedDelegateField;

		// Token: 0x02000053 RID: 83
		[Flags]
		public enum TextureLayout
		{
			// Token: 0x04000162 RID: 354
			Texture2DArray = 1,
			// Token: 0x04000163 RID: 355
			SingleTexture2D = 2,
			// Token: 0x04000164 RID: 356
			SeparateTexture2Ds = 4
		}

		// Token: 0x02000054 RID: 84
		public sealed class XRRenderParameter : ValueType
		{
			// Token: 0x060001D1 RID: 465 RVA: 0x00006708 File Offset: 0x00004908
			// Note: this type is marked as 'beforefieldinit'.
			static XRRenderParameter()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRRenderParameter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr);
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "view");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_projection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "projection");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "viewport");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_occlusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "occlusionMesh");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_textureArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "textureArraySlice");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_previousView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "previousView");
				XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_isPreviousViewValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr, "isPreviousViewValid");
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x00002CB5 File Offset: 0x00000EB5
			public XRRenderParameter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00002CBE File Offset: 0x00000EBE
			public XRRenderParameter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderParameter>.NativeClassPtr))
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x000067C0 File Offset: 0x000049C0
			// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002CD0 File Offset: 0x00000ED0
			public unsafe Matrix4x4 view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_view);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_view)) = value;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x000067E8 File Offset: 0x000049E8
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002CEB File Offset: 0x00000EEB
			public unsafe Matrix4x4 projection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_projection);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_projection)) = value;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00006810 File Offset: 0x00004A10
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002D06 File Offset: 0x00000F06
			public unsafe Rect viewport
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_viewport);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_viewport)) = value;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00006838 File Offset: 0x00004A38
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002D21 File Offset: 0x00000F21
			public unsafe Mesh occlusionMesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_occlusionMesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_occlusionMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00006868 File Offset: 0x00004A68
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00002D40 File Offset: 0x00000F40
			public unsafe int textureArraySlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_textureArraySlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_textureArraySlice)) = value;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00006890 File Offset: 0x00004A90
			// (set) Token: 0x060001DF RID: 479 RVA: 0x00002D5B File Offset: 0x00000F5B
			public unsafe Matrix4x4 previousView
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_previousView);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_previousView)) = value;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x000068B8 File Offset: 0x00004AB8
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002D76 File Offset: 0x00000F76
			public unsafe bool isPreviousViewValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_isPreviousViewValid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRRenderParameter.NativeFieldInfoPtr_isPreviousViewValid)) = value;
				}
			}

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeFieldInfoPtr_projection;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeFieldInfoPtr_viewport;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeFieldInfoPtr_occlusionMesh;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeFieldInfoPtr_textureArraySlice;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeFieldInfoPtr_previousView;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeFieldInfoPtr_isPreviousViewValid;
		}

		// Token: 0x02000055 RID: 85
		[StructLayout(2)]
		public struct XRRenderPass
		{
			// Token: 0x060001E2 RID: 482 RVA: 0x000068E0 File Offset: 0x00004AE0
			// Note: this type is marked as 'beforefieldinit'.
			static XRRenderPass()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRRenderPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr);
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "displaySubsystemInstance");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderPassIndex");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderTarget");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderTargetDesc");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_hasMotionVectorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "hasMotionVectorPass");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_motionVectorRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "motionVectorRenderTarget");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_motionVectorRenderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "motionVectorRenderTargetDesc");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_shouldFillOutDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "shouldFillOutDepth");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_cullingPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "cullingPassIndex");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "foveatedRenderingInfo");
				XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, 100663349);
				XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, 100663350);
				XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_Camera_Int32_byref_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, 100663351);
				XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameterCount_Injected_Private_Static_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, 100663352);
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x00006A24 File Offset: 0x00004C24
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1258726, RefRangeEnd = 1258733, XrefRangeStart = 1258724, XrefRangeEnd = 1258726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetRenderParameter(Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderParameterIndex;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0, ref this, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				renderParameter = ((intPtr4 == 0) ? null : new XRDisplaySubsystem.XRRenderParameter(intPtr4));
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00006A8C File Offset: 0x00004C8C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1258735, RefRangeEnd = 1258743, XrefRangeStart = 1258733, XrefRangeEnd = 1258735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetRenderParameterCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00006ABC File Offset: 0x00004CBC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1258726, RefRangeEnd = 1258733, XrefRangeStart = 1258726, XrefRangeEnd = 1258733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetRenderParameter_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &_unity_self;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderParameterIndex;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_Camera_Int32_byref_XRRenderParameter_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				renderParameter = ((intPtr4 == 0) ? null : new XRDisplaySubsystem.XRRenderParameter(intPtr4));
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00006B30 File Offset: 0x00004D30
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1258735, RefRangeEnd = 1258743, XrefRangeStart = 1258735, XrefRangeEnd = 1258743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetRenderParameterCount_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &_unity_self;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRRenderPass.NativeMethodInfoPtr_GetRenderParameterCount_Injected_Private_Static_Int32_byref_XRRenderPass_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00002D91 File Offset: 0x00000F91
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, ref this));
			}

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeFieldInfoPtr_renderPassIndex;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeFieldInfoPtr_renderTarget;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeFieldInfoPtr_renderTargetDesc;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeFieldInfoPtr_hasMotionVectorPass;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorRenderTarget;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorRenderTargetDesc;

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeFieldInfoPtr_shouldFillOutDepth;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeFieldInfoPtr_cullingPassIndex;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0;

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_Camera_Int32_byref_XRRenderParameter_0;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeMethodInfoPtr_GetRenderParameterCount_Injected_Private_Static_Int32_byref_XRRenderPass_0;

			// Token: 0x0400017A RID: 378
			[FieldOffset(0)]
			public IntPtr displaySubsystemInstance;

			// Token: 0x0400017B RID: 379
			[FieldOffset(8)]
			public int renderPassIndex;

			// Token: 0x0400017C RID: 380
			[FieldOffset(16)]
			public RenderTargetIdentifier renderTarget;

			// Token: 0x0400017D RID: 381
			[FieldOffset(56)]
			public RenderTextureDescriptor renderTargetDesc;

			// Token: 0x0400017E RID: 382
			[FieldOffset(108)]
			[MarshalAs(4)]
			public bool hasMotionVectorPass;

			// Token: 0x0400017F RID: 383
			[FieldOffset(112)]
			public RenderTargetIdentifier motionVectorRenderTarget;

			// Token: 0x04000180 RID: 384
			[FieldOffset(152)]
			public RenderTextureDescriptor motionVectorRenderTargetDesc;

			// Token: 0x04000181 RID: 385
			[FieldOffset(204)]
			[MarshalAs(4)]
			public bool shouldFillOutDepth;

			// Token: 0x04000182 RID: 386
			[FieldOffset(208)]
			public int cullingPassIndex;

			// Token: 0x04000183 RID: 387
			[FieldOffset(216)]
			public IntPtr foveatedRenderingInfo;
		}

		// Token: 0x02000056 RID: 86
		public sealed class XRBlitParams : ValueType
		{
			// Token: 0x060001E8 RID: 488 RVA: 0x00006B70 File Offset: 0x00004D70
			// Note: this type is marked as 'beforefieldinit'.
			static XRBlitParams()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRBlitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr);
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcTex");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTexArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcTexArraySlice");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcRect");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_destRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "destRect");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "foveatedRenderingInfo");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrEncoded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcHdrEncoded");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrColorGamut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcHdrColorGamut");
				XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrMaxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr, "srcHdrMaxLuminance");
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00002DA3 File Offset: 0x00000FA3
			public XRBlitParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00002DAC File Offset: 0x00000FAC
			public XRBlitParams()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystem.XRBlitParams>.NativeClassPtr))
			{
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060001EB RID: 491 RVA: 0x00006C3C File Offset: 0x00004E3C
			// (set) Token: 0x060001EC RID: 492 RVA: 0x00002DBE File Offset: 0x00000FBE
			public unsafe RenderTexture srcTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060001ED RID: 493 RVA: 0x00006C6C File Offset: 0x00004E6C
			// (set) Token: 0x060001EE RID: 494 RVA: 0x00002DDD File Offset: 0x00000FDD
			public unsafe int srcTexArraySlice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTexArraySlice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcTexArraySlice)) = value;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060001EF RID: 495 RVA: 0x00006C94 File Offset: 0x00004E94
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002DF8 File Offset: 0x00000FF8
			public unsafe Rect srcRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcRect)) = value;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x00006CBC File Offset: 0x00004EBC
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002E13 File Offset: 0x00001013
			public unsafe Rect destRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_destRect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_destRect)) = value;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x00006CE4 File Offset: 0x00004EE4
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002E2E File Offset: 0x0000102E
			public unsafe IntPtr foveatedRenderingInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_foveatedRenderingInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_foveatedRenderingInfo)) = value;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x00006D0C File Offset: 0x00004F0C
			// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002E49 File Offset: 0x00001049
			public unsafe bool srcHdrEncoded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrEncoded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrEncoded)) = value;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x00006D34 File Offset: 0x00004F34
			// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002E64 File Offset: 0x00001064
			public unsafe ColorGamut srcHdrColorGamut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrColorGamut);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrColorGamut)) = value;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x00006D5C File Offset: 0x00004F5C
			// (set) Token: 0x060001FA RID: 506 RVA: 0x00002E7F File Offset: 0x0000107F
			public unsafe int srcHdrMaxLuminance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrMaxLuminance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.XRBlitParams.NativeFieldInfoPtr_srcHdrMaxLuminance)) = value;
				}
			}

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr_srcTex;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeFieldInfoPtr_srcTexArraySlice;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeFieldInfoPtr_srcRect;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeFieldInfoPtr_destRect;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr_srcHdrEncoded;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr_srcHdrColorGamut;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr_srcHdrMaxLuminance;
		}

		// Token: 0x02000057 RID: 87
		[StructLayout(2)]
		public struct XRMirrorViewBlitDesc
		{
			// Token: 0x060001FB RID: 507 RVA: 0x00006D84 File Offset: 0x00004F84
			// Note: this type is marked as 'beforefieldinit'.
			static XRMirrorViewBlitDesc()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRMirrorViewBlitDesc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr);
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "displaySubsystemInstance");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_nativeBlitAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitAvailable");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_nativeBlitInvalidStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitInvalidStates");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_blitParamsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "blitParamsCount");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, 100663353);
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeMethodInfoPtr_GetBlitParameter_Injected_Private_Static_Void_byref_XRMirrorViewBlitDesc_Int32_byref_XRBlitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, 100663354);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x00006E28 File Offset: 0x00005028
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258745, RefRangeEnd = 1258746, XrefRangeStart = 1258743, XrefRangeEnd = 1258745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetBlitParameter(int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref blitParameterIndex;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0, ref this, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				blitParameter = ((intPtr4 == 0) ? null : new XRDisplaySubsystem.XRBlitParams(intPtr4));
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00006E7C File Offset: 0x0000507C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258745, RefRangeEnd = 1258746, XrefRangeStart = 1258745, XrefRangeEnd = 1258746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetBlitParameter_Injected(ref XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &_unity_self;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blitParameterIndex;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeMethodInfoPtr_GetBlitParameter_Injected_Private_Static_Void_byref_XRMirrorViewBlitDesc_Int32_byref_XRBlitParams_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				blitParameter = ((intPtr4 == 0) ? null : new XRDisplaySubsystem.XRBlitParams(intPtr4));
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002E9A File Offset: 0x0000109A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, ref this));
			}

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr_nativeBlitAvailable;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeFieldInfoPtr_nativeBlitInvalidStates;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeFieldInfoPtr_blitParamsCount;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeMethodInfoPtr_GetBlitParameter_Injected_Private_Static_Void_byref_XRMirrorViewBlitDesc_Int32_byref_XRBlitParams_0;

			// Token: 0x04000192 RID: 402
			[FieldOffset(0)]
			public IntPtr displaySubsystemInstance;

			// Token: 0x04000193 RID: 403
			[FieldOffset(8)]
			[MarshalAs(4)]
			public bool nativeBlitAvailable;

			// Token: 0x04000194 RID: 404
			[FieldOffset(9)]
			[MarshalAs(4)]
			public bool nativeBlitInvalidStates;

			// Token: 0x04000195 RID: 405
			[FieldOffset(12)]
			public int blitParamsCount;
		}

		// Token: 0x02000058 RID: 88
		public enum FoveatedRenderingFlags
		{
			// Token: 0x04000197 RID: 407
			None,
			// Token: 0x04000198 RID: 408
			GazeAllowed
		}

		// Token: 0x02000059 RID: 89
		public enum LateLatchNode
		{
			// Token: 0x0400019A RID: 410
			Head,
			// Token: 0x0400019B RID: 411
			LeftHand,
			// Token: 0x0400019C RID: 412
			RightHand
		}

		// Token: 0x0200005A RID: 90
		public enum ReprojectionMode
		{
			// Token: 0x0400019E RID: 414
			Unspecified,
			// Token: 0x0400019F RID: 415
			PositionAndOrientation,
			// Token: 0x040001A0 RID: 416
			OrientationOnly,
			// Token: 0x040001A1 RID: 417
			None
		}

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate bool get_displayOpaqueDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate bool get_contentProtectionEnabledDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate void set_contentProtectionEnabledDelegate(IntPtr @this, bool value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate float get_scaleOfAllViewportsDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate void set_scaleOfAllViewportsDelegate(IntPtr @this, float value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate float get_scaleOfAllRenderTargetsDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate float get_zNearDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate float get_zFarDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate bool get_sRGBDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate float get_occlusionMaskScaleDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void set_occlusionMaskScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate float get_foveatedRenderingLevelDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate void set_foveatedRenderingLevelDelegate(IntPtr @this, float value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate XRDisplaySubsystem.FoveatedRenderingFlags get_foveatedRenderingFlagsDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate void set_foveatedRenderingFlagsDelegate(IntPtr @this, XRDisplaySubsystem.FoveatedRenderingFlags value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate void MarkTransformLateLatchedDelegate(IntPtr @this, IntPtr transform, XRDisplaySubsystem.LateLatchNode nodeType);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate XRDisplaySubsystem.TextureLayout get_textureLayoutDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate XRDisplaySubsystem.TextureLayout get_supportedTextureLayoutsDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate XRDisplaySubsystem.ReprojectionMode get_reprojectionModeDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate void set_reprojectionModeDelegate(IntPtr @this, XRDisplaySubsystem.ReprojectionMode value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate bool get_disableLegacyRendererDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate bool TryGetAppGPUTimeLastFrameDelegate(IntPtr @this, [Out] IntPtr gpuTimeLastFrame);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate bool TryGetCompositorGPUTimeLastFrameDelegate(IntPtr @this, [Out] IntPtr gpuTimeLastFrameCompositor);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate bool TryGetDroppedFrameCountDelegate(IntPtr @this, [Out] IntPtr droppedFrameCount);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate bool TryGetFramePresentCountDelegate(IntPtr @this, [Out] IntPtr framePresentCount);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate bool TryGetDisplayRefreshRateDelegate(IntPtr @this, [Out] IntPtr displayRefreshRate);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate bool TryGetMotionToPhotonDelegate(IntPtr @this, [Out] IntPtr motionToPhoton);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate IntPtr GetRenderTextureDelegate(IntPtr @this, uint unityXrRenderTextureId);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate IntPtr GetRenderTextureForRenderPassDelegate(IntPtr @this, int renderPass);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate IntPtr GetSharedDepthTextureForRenderPassDelegate(IntPtr @this, int renderPass);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate void SetPreferredMirrorBlitModeDelegate(IntPtr @this, int blitMode);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate void SetFocusPlane_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr normal, IntPtr velocity);
	}
}
