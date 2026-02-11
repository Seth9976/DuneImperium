using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FB RID: 251
	public sealed class CameraData : ValueType
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x00059C38 File Offset: 0x00057E38
		// Note: this type is marked as 'beforefieldinit'.
		static CameraData()
		{
			Il2CppClassPointerStore<CameraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraData>.NativeClassPtr);
			CameraData.NativeFieldInfoPtr_m_ViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "m_ViewMatrix");
			CameraData.NativeFieldInfoPtr_m_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "m_ProjectionMatrix");
			CameraData.NativeFieldInfoPtr_m_JitterMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "m_JitterMatrix");
			CameraData.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "camera");
			CameraData.NativeFieldInfoPtr_renderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "renderType");
			CameraData.NativeFieldInfoPtr_targetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "targetTexture");
			CameraData.NativeFieldInfoPtr_cameraTargetDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "cameraTargetDescriptor");
			CameraData.NativeFieldInfoPtr_pixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "pixelRect");
			CameraData.NativeFieldInfoPtr_useScreenCoordOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "useScreenCoordOverride");
			CameraData.NativeFieldInfoPtr_screenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "screenSizeOverride");
			CameraData.NativeFieldInfoPtr_screenCoordScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "screenCoordScaleBias");
			CameraData.NativeFieldInfoPtr_pixelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "pixelWidth");
			CameraData.NativeFieldInfoPtr_pixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "pixelHeight");
			CameraData.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "aspectRatio");
			CameraData.NativeFieldInfoPtr_renderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "renderScale");
			CameraData.NativeFieldInfoPtr_imageScalingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "imageScalingMode");
			CameraData.NativeFieldInfoPtr_upscalingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "upscalingFilter");
			CameraData.NativeFieldInfoPtr_fsrOverrideSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "fsrOverrideSharpness");
			CameraData.NativeFieldInfoPtr_fsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "fsrSharpness");
			CameraData.NativeFieldInfoPtr_hdrColorBufferPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "hdrColorBufferPrecision");
			CameraData.NativeFieldInfoPtr_clearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "clearDepth");
			CameraData.NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "cameraType");
			CameraData.NativeFieldInfoPtr_isDefaultViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "isDefaultViewport");
			CameraData.NativeFieldInfoPtr_isHdrEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "isHdrEnabled");
			CameraData.NativeFieldInfoPtr_allowHDROutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "allowHDROutput");
			CameraData.NativeFieldInfoPtr_requiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "requiresDepthTexture");
			CameraData.NativeFieldInfoPtr_requiresOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "requiresOpaqueTexture");
			CameraData.NativeFieldInfoPtr_postProcessingRequiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "postProcessingRequiresDepthTexture");
			CameraData.NativeFieldInfoPtr_xrRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "xrRendering");
			CameraData.NativeFieldInfoPtr_stackLastCameraOutputToHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "stackLastCameraOutputToHDR");
			CameraData.NativeFieldInfoPtr_defaultOpaqueSortFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "defaultOpaqueSortFlags");
			CameraData.NativeFieldInfoPtr__xr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "<xr>k__BackingField");
			CameraData.NativeFieldInfoPtr_isStereoEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "isStereoEnabled");
			CameraData.NativeFieldInfoPtr_maxShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "maxShadowDistance");
			CameraData.NativeFieldInfoPtr_postProcessEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "postProcessEnabled");
			CameraData.NativeFieldInfoPtr_stackAnyPostProcessingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "stackAnyPostProcessingEnabled");
			CameraData.NativeFieldInfoPtr_captureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "captureActions");
			CameraData.NativeFieldInfoPtr_volumeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "volumeLayerMask");
			CameraData.NativeFieldInfoPtr_volumeTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "volumeTrigger");
			CameraData.NativeFieldInfoPtr_isStopNaNEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "isStopNaNEnabled");
			CameraData.NativeFieldInfoPtr_isDitheringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "isDitheringEnabled");
			CameraData.NativeFieldInfoPtr_antialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "antialiasing");
			CameraData.NativeFieldInfoPtr_antialiasingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "antialiasingQuality");
			CameraData.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "renderer");
			CameraData.NativeFieldInfoPtr_resolveFinalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "resolveFinalTarget");
			CameraData.NativeFieldInfoPtr_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "worldSpaceCameraPos");
			CameraData.NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "backgroundColor");
			CameraData.NativeFieldInfoPtr_taaPersistentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "taaPersistentData");
			CameraData.NativeFieldInfoPtr_taaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "taaSettings");
			CameraData.NativeFieldInfoPtr_baseCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "baseCamera");
			CameraData.NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665767);
			CameraData.NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665768);
			CameraData.NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665769);
			CameraData.NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665770);
			CameraData.NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665771);
			CameraData.NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665772);
			CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665773);
			CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665774);
			CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665775);
			CameraData.NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665776);
			CameraData.NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665777);
			CameraData.NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665778);
			CameraData.NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665779);
			CameraData.NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665780);
			CameraData.NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665781);
			CameraData.NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665782);
			CameraData.NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665783);
			CameraData.NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665784);
			CameraData.NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665785);
			CameraData.NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665786);
			CameraData.NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665787);
			CameraData.NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665788);
			CameraData.NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665789);
			CameraData.NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665790);
			CameraData.NativeMethodInfoPtr_get_xr_Public_get_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665791);
			CameraData.NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665792);
			CameraData.NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665793);
			CameraData.NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100665794);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0005A280 File Offset: 0x00058480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622437, XrefRangeEnd = 622439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005A2D4 File Offset: 0x000584D4
		[CallerCount(0)]
		public unsafe void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jitterMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0005A334 File Offset: 0x00058534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622478, RefRangeEnd = 622479, XrefRangeStart = 622439, XrefRangeEnd = 622478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushBuiltinShaderConstantsXR(CommandBuffer cmd, bool renderIntoTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_CommandBuffer_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0005A38C File Offset: 0x0005858C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 622480, RefRangeEnd = 622499, XrefRangeStart = 622479, XrefRangeEnd = 622480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0005A3DC File Offset: 0x000585DC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 622503, RefRangeEnd = 622513, XrefRangeStart = 622499, XrefRangeEnd = 622503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005A42C File Offset: 0x0005862C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 622514, RefRangeEnd = 622517, XrefRangeStart = 622513, XrefRangeEnd = 622514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005A47C File Offset: 0x0005867C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622523, RefRangeEnd = 622524, XrefRangeStart = 622517, XrefRangeEnd = 622523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005A4CC File Offset: 0x000586CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622524, XrefRangeEnd = 622529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005A51C File Offset: 0x0005871C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 622532, RefRangeEnd = 622536, XrefRangeStart = 622529, XrefRangeEnd = 622532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderIntoTexture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0005A578 File Offset: 0x00058778
		public unsafe int scaledWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622536, XrefRangeEnd = 622537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0005A5BC File Offset: 0x000587BC
		public unsafe int scaledHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622537, XrefRangeEnd = 622538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0005A600 File Offset: 0x00058800
		public unsafe bool requireSrgbConversion
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 622548, RefRangeEnd = 622554, XrefRangeStart = 622538, XrefRangeEnd = 622548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0005A644 File Offset: 0x00058844
		public unsafe bool isSceneViewCamera
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 622554, RefRangeEnd = 622562, XrefRangeStart = 622554, XrefRangeEnd = 622554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0005A688 File Offset: 0x00058888
		public unsafe bool isPreviewCamera
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 622562, RefRangeEnd = 622569, XrefRangeStart = 622562, XrefRangeEnd = 622562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0005A6CC File Offset: 0x000588CC
		public unsafe bool isRenderPassSupportedCamera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 622569, RefRangeEnd = 622571, XrefRangeStart = 622569, XrefRangeEnd = 622569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0005A710 File Offset: 0x00058910
		public unsafe bool resolveToScreen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 622575, RefRangeEnd = 622576, XrefRangeStart = 622571, XrefRangeEnd = 622575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0005A754 File Offset: 0x00058954
		public unsafe bool isHDROutputActive
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 622583, RefRangeEnd = 622595, XrefRangeStart = 622576, XrefRangeEnd = 622583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0005A798 File Offset: 0x00058998
		public unsafe HDROutputUtils.HDRDisplayInformation hdrDisplayInformation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 622605, RefRangeEnd = 622612, XrefRangeStart = 622595, XrefRangeEnd = 622605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0005A7DC File Offset: 0x000589DC
		public unsafe ColorGamut hdrDisplayColorGamut
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 622620, RefRangeEnd = 622631, XrefRangeStart = 622612, XrefRangeEnd = 622620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0005A820 File Offset: 0x00058A20
		public unsafe bool rendersOverlayUI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 622635, RefRangeEnd = 622637, XrefRangeStart = 622631, XrefRangeEnd = 622635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0005A864 File Offset: 0x00058A64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 622644, RefRangeEnd = 622647, XrefRangeStart = 622637, XrefRangeEnd = 622644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHandleYFlipped(RTHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 622667, RefRangeEnd = 622677, XrefRangeStart = 622647, XrefRangeEnd = 622667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCameraProjectionMatrixFlipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005A8FC File Offset: 0x00058AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622682, RefRangeEnd = 622683, XrefRangeStart = 622677, XrefRangeEnd = 622682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depth);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0005A960 File Offset: 0x00058B60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 622689, RefRangeEnd = 622697, XrefRangeStart = 622683, XrefRangeEnd = 622689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTemporalAAEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0005A9A4 File Offset: 0x00058BA4
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		public unsafe XRPass xr
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_xr_Public_get_XRPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0005AA30 File Offset: 0x00058C30
		public unsafe XRPassUniversal xrUniversal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 622698, RefRangeEnd = 622709, XrefRangeStart = 622697, XrefRangeEnd = 622698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRPassUniversal>(intPtr3) : null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0005AA74 File Offset: 0x00058C74
		public unsafe bool resetHistory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraData.NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0000B98D File Offset: 0x00009B8D
		public CameraData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0000B996 File Offset: 0x00009B96
		public CameraData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraData>.NativeClassPtr))
		{
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0005AAB8 File Offset: 0x00058CB8
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public unsafe Matrix4x4 m_ViewMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_ViewMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_ViewMatrix)) = value;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0005AAE0 File Offset: 0x00058CE0
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		public unsafe Matrix4x4 m_ProjectionMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_ProjectionMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_ProjectionMatrix)) = value;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0005AB08 File Offset: 0x00058D08
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000B9DE File Offset: 0x00009BDE
		public unsafe Matrix4x4 m_JitterMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_JitterMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_m_JitterMatrix)) = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0005AB30 File Offset: 0x00058D30
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0000B9F9 File Offset: 0x00009BF9
		public unsafe Camera camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0005AB60 File Offset: 0x00058D60
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000BA18 File Offset: 0x00009C18
		public unsafe CameraRenderType renderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderType)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0005AB88 File Offset: 0x00058D88
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0000BA33 File Offset: 0x00009C33
		public unsafe RenderTexture targetTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_targetTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_targetTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0005ABB8 File Offset: 0x00058DB8
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0000BA52 File Offset: 0x00009C52
		public unsafe RenderTextureDescriptor cameraTargetDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_cameraTargetDescriptor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_cameraTargetDescriptor)) = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0005ABE0 File Offset: 0x00058DE0
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000BA6D File Offset: 0x00009C6D
		public unsafe Rect pixelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelRect)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0005AC08 File Offset: 0x00058E08
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0000BA88 File Offset: 0x00009C88
		public unsafe bool useScreenCoordOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_useScreenCoordOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_useScreenCoordOverride)) = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0005AC30 File Offset: 0x00058E30
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000BAA3 File Offset: 0x00009CA3
		public unsafe Vector4 screenSizeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_screenSizeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_screenSizeOverride)) = value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0005AC58 File Offset: 0x00058E58
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x0000BABE File Offset: 0x00009CBE
		public unsafe Vector4 screenCoordScaleBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_screenCoordScaleBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_screenCoordScaleBias)) = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0005AC80 File Offset: 0x00058E80
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x0000BAD9 File Offset: 0x00009CD9
		public unsafe int pixelWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelWidth)) = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		public unsafe int pixelHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_pixelHeight)) = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0005ACD0 File Offset: 0x00058ED0
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x0000BB0F File Offset: 0x00009D0F
		public unsafe float aspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_aspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_aspectRatio)) = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0000BB2A File Offset: 0x00009D2A
		public unsafe float renderScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderScale)) = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0005AD20 File Offset: 0x00058F20
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0000BB45 File Offset: 0x00009D45
		public unsafe ImageScalingMode imageScalingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_imageScalingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_imageScalingMode)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0005AD48 File Offset: 0x00058F48
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000BB60 File Offset: 0x00009D60
		public unsafe ImageUpscalingFilter upscalingFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_upscalingFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_upscalingFilter)) = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0005AD70 File Offset: 0x00058F70
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000BB7B File Offset: 0x00009D7B
		public unsafe bool fsrOverrideSharpness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_fsrOverrideSharpness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_fsrOverrideSharpness)) = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0005AD98 File Offset: 0x00058F98
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0000BB96 File Offset: 0x00009D96
		public unsafe float fsrSharpness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_fsrSharpness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_fsrSharpness)) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0000BBB1 File Offset: 0x00009DB1
		public unsafe HDRColorBufferPrecision hdrColorBufferPrecision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_hdrColorBufferPrecision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_hdrColorBufferPrecision)) = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0005ADE8 File Offset: 0x00058FE8
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public unsafe bool clearDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_clearDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_clearDepth)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0005AE10 File Offset: 0x00059010
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000BBE7 File Offset: 0x00009DE7
		public unsafe CameraType cameraType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_cameraType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_cameraType)) = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0005AE38 File Offset: 0x00059038
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000BC02 File Offset: 0x00009E02
		public unsafe bool isDefaultViewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isDefaultViewport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isDefaultViewport)) = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0005AE60 File Offset: 0x00059060
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000BC1D File Offset: 0x00009E1D
		public unsafe bool isHdrEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isHdrEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isHdrEnabled)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0005AE88 File Offset: 0x00059088
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000BC38 File Offset: 0x00009E38
		public unsafe bool allowHDROutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_allowHDROutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_allowHDROutput)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0005AEB0 File Offset: 0x000590B0
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000BC53 File Offset: 0x00009E53
		public unsafe bool requiresDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_requiresDepthTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_requiresDepthTexture)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0005AED8 File Offset: 0x000590D8
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000BC6E File Offset: 0x00009E6E
		public unsafe bool requiresOpaqueTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_requiresOpaqueTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_requiresOpaqueTexture)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0005AF00 File Offset: 0x00059100
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000BC89 File Offset: 0x00009E89
		public unsafe bool postProcessingRequiresDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_postProcessingRequiresDepthTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_postProcessingRequiresDepthTexture)) = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0005AF28 File Offset: 0x00059128
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		public unsafe bool xrRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_xrRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_xrRendering)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005AF50 File Offset: 0x00059150
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000BCBF File Offset: 0x00009EBF
		public unsafe bool stackLastCameraOutputToHDR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_stackLastCameraOutputToHDR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_stackLastCameraOutputToHDR)) = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0005AF78 File Offset: 0x00059178
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000BCDA File Offset: 0x00009EDA
		public unsafe SortingCriteria defaultOpaqueSortFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_defaultOpaqueSortFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_defaultOpaqueSortFlags)) = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0005AFA0 File Offset: 0x000591A0
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000BCF5 File Offset: 0x00009EF5
		public unsafe XRPass _xr_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr__xr_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr__xr_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0005AFD0 File Offset: 0x000591D0
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000BD14 File Offset: 0x00009F14
		public unsafe bool isStereoEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isStereoEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isStereoEnabled)) = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0005AFF8 File Offset: 0x000591F8
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000BD2F File Offset: 0x00009F2F
		public unsafe float maxShadowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_maxShadowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_maxShadowDistance)) = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0005B020 File Offset: 0x00059220
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000BD4A File Offset: 0x00009F4A
		public unsafe bool postProcessEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_postProcessEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_postProcessEnabled)) = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0005B048 File Offset: 0x00059248
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000BD65 File Offset: 0x00009F65
		public unsafe bool stackAnyPostProcessingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_stackAnyPostProcessingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_stackAnyPostProcessingEnabled)) = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0005B070 File Offset: 0x00059270
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000BD80 File Offset: 0x00009F80
		public unsafe IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_captureActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_captureActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0005B0A0 File Offset: 0x000592A0
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000BD9F File Offset: 0x00009F9F
		public unsafe LayerMask volumeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_volumeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_volumeLayerMask)) = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0005B0C8 File Offset: 0x000592C8
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000BDBA File Offset: 0x00009FBA
		public unsafe Transform volumeTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_volumeTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_volumeTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0005B0F8 File Offset: 0x000592F8
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0000BDD9 File Offset: 0x00009FD9
		public unsafe bool isStopNaNEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isStopNaNEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isStopNaNEnabled)) = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0005B120 File Offset: 0x00059320
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public unsafe bool isDitheringEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isDitheringEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_isDitheringEnabled)) = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0005B148 File Offset: 0x00059348
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0000BE0F File Offset: 0x0000A00F
		public unsafe AntialiasingMode antialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_antialiasing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_antialiasing)) = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0005B170 File Offset: 0x00059370
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0000BE2A File Offset: 0x0000A02A
		public unsafe AntialiasingQuality antialiasingQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_antialiasingQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_antialiasingQuality)) = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0005B198 File Offset: 0x00059398
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0000BE45 File Offset: 0x0000A045
		public unsafe ScriptableRenderer renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005B1C8 File Offset: 0x000593C8
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000BE64 File Offset: 0x0000A064
		public unsafe bool resolveFinalTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_resolveFinalTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_resolveFinalTarget)) = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0005B1F0 File Offset: 0x000593F0
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000BE7F File Offset: 0x0000A07F
		public unsafe Vector3 worldSpaceCameraPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_worldSpaceCameraPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_worldSpaceCameraPos)) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0005B218 File Offset: 0x00059418
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0000BE9A File Offset: 0x0000A09A
		public unsafe Color backgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_backgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_backgroundColor)) = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0005B240 File Offset: 0x00059440
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0000BEB5 File Offset: 0x0000A0B5
		public unsafe TaaPersistentData taaPersistentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_taaPersistentData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaaPersistentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_taaPersistentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005B270 File Offset: 0x00059470
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		public unsafe TemporalAA.Settings taaSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_taaSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_taaSettings)) = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0005B298 File Offset: 0x00059498
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0000BEEF File Offset: 0x0000A0EF
		public unsafe Camera baseCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_baseCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraData.NativeFieldInfoPtr_baseCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewMatrix;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectionMatrix;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_m_JitterMatrix;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeFieldInfoPtr_camera;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeFieldInfoPtr_renderType;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeFieldInfoPtr_targetTexture;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_cameraTargetDescriptor;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_pixelRect;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeFieldInfoPtr_useScreenCoordOverride;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeFieldInfoPtr_screenSizeOverride;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeFieldInfoPtr_screenCoordScaleBias;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeFieldInfoPtr_pixelWidth;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeFieldInfoPtr_pixelHeight;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr_aspectRatio;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeFieldInfoPtr_renderScale;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeFieldInfoPtr_imageScalingMode;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeFieldInfoPtr_upscalingFilter;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr_fsrOverrideSharpness;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeFieldInfoPtr_fsrSharpness;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeFieldInfoPtr_hdrColorBufferPrecision;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr_clearDepth;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_cameraType;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultViewport;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_isHdrEnabled;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_allowHDROutput;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_requiresDepthTexture;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_requiresOpaqueTexture;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_postProcessingRequiresDepthTexture;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_xrRendering;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_stackLastCameraOutputToHDR;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_defaultOpaqueSortFlags;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr__xr_k__BackingField;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_isStereoEnabled;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_maxShadowDistance;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr_postProcessEnabled;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_stackAnyPostProcessingEnabled;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_captureActions;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_volumeLayerMask;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_volumeTrigger;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_isStopNaNEnabled;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_isDitheringEnabled;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_antialiasing;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_antialiasingQuality;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_renderer;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_resolveFinalTarget;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_worldSpaceCameraPos;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_taaPersistentData;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_taaSettings;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_baseCamera;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_CommandBuffer_Boolean_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_get_xr_Public_get_XRPass_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0;
	}
}
